#nullable enable
using System;
using AutSoft.UnitySupplements.Vitamins;
using Injecter;
using TMPro;
using TradeCity.Engine.Core;
using TradeCity.Engine.Core.Interfaces;
using TradeCity.Engine.Session;
using TradeCity.Engine.Structures;
using TradeCity.Engine.Structures.Interfaces;
using TradeCity.Unity.Scripts.GUI.ResourceDisplays;
using UnityEngine;
using UnityEngine.UI;

namespace TradeCity.Unity.Scripts.GUI.CIty
{
    public class BuildingListItem : MonoBehaviour
    {
        [Inject] private IPlayerService _playerService; 

        public string Building = default!;
        [SerializeField] private Image _buildingImage = default!;
        [SerializeField] private TMP_Text _buildingName = default!;
        [SerializeField] private Button _buildButton = default!;
        [SerializeField] private TMP_Text _levelText = default!;
        [SerializeField] private HorizontalLayoutGroup _costsList = default!;
        [SerializeField] private GameObject _costDisplayPrefab = default!;

        private Building? _target;

        private void Awake()
        {
            _playerService = EngineCore.InjectPlayerService();

            this.CheckSerializedField(_buildingImage, nameof(_buildingImage));
            this.CheckSerializedField(_buildingName, nameof(_buildingName));
            this.CheckSerializedField(_buildButton, nameof(_buildButton));
            this.CheckSerializedField(_levelText, nameof(_levelText));
            this.CheckSerializedField(_costsList, nameof(_costsList));
            this.CheckSerializedField(_costDisplayPrefab, nameof(_costDisplayPrefab));
        }

        private void Start()
        {
            if (_target == null) return;
            _buildingName.text = _target.GetName();

            var loadedSprite = Resources.Load<Sprite>(_target.GetResourcePath());
            if (loadedSprite != null)
                _buildingImage.sprite = loadedSprite;

            _levelText.text = "Lvl:" + (_target).Level;

            UpdateCostDisplay();
            _buildButton.onClick.AddListener(OnClick);
        }

        private void Update()
        {
            if (_target == null) return;
            UpdateButton();
        }

        private void OnDestroy()
        {
            _buildButton.onClick.RemoveListener(OnClick);
        }

        public void SetTarget(Building target)
        {
            _target = target;
        }

        private void OnClick()
        {
            if (_target == null) throw new InvalidOperationException();
            switch (_target.BuildingState)
            {
                case BuildingState.Build:
                    _target.Build(_playerService.CurrentPlayer);
                    break;
                case BuildingState.Upgrade:
                    if (_playerService.CurrentPlayer.HasStructure(_target))
                    {
                        _target.Upgrade();
                    }
                    break;
                case BuildingState.Maxlevel:
                    //Do nothing
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
            _levelText.text = "Lvl:" + _target.Level;
            UpdateButton();
            UpdateCostDisplay();
        }

        private void UpdateButton()
        {
            if (_target == null)
            {
                _buildButton.GetComponentInChildren<Text>().text = "null";
                _buildButton.interactable = false;
                return;
            }
            switch (_target.BuildingState)
            {
                case BuildingState.Build:
                    _buildButton.GetComponentInChildren<Text>().text = "Build";
                    _buildButton.interactable = _target.CanBuild(_playerService.CurrentPlayer);
                    break;
                case BuildingState.Upgrade:
                    _buildButton.GetComponentInChildren<Text>().text = "Upgrade";
                    _buildButton.interactable = _target.CanUpgrade();
                    break;
                case BuildingState.Maxlevel:
                    _buildButton.GetComponentInChildren<Text>().text = "Maxed";
                    _buildButton.interactable = false;
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
            _buildButton.Select();
        }

        private void UpdateCostDisplay()
        {
            foreach (Transform child in _costsList.transform)
            {
                Destroy(child.gameObject);
            }

            if (_target == null) return;
            foreach (var res in _target.GetCost())
            {
                var listItem = Instantiate(_costDisplayPrefab);
                listItem.GetComponent<ResourceDisplay>().Watched = res;
                listItem.transform.SetParent(_costsList.transform);
            }
        }
    }
}
