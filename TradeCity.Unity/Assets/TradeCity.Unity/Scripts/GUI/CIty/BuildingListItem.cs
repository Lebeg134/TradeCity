using AutSoft.UnitySupplements.Vitamins;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using TradeCity.Engine.Resources;
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
        private readonly string[] _options = GetOptions();
        [Dropdown("_options")]
        public string Building = default!;
        [SerializeField] private Image _buildingImage = default!;
        [SerializeField] private TMP_Text _buildingName = default!;
        [SerializeField] private Button _buildButton = default!;
        [SerializeField] private TMP_Text _levelText = default!;
        [SerializeField] private HorizontalLayoutGroup _costsList = default!;
        [SerializeField] private GameObject _costDisplayPrefab = default!;

        private Building _target;

        private void Awake()
        {
            this.CheckSerializedField(_buildingImage, nameof(_buildingImage));
            this.CheckSerializedField(_buildingName, nameof(_buildingName));
            this.CheckSerializedField(_buildButton, nameof(_buildButton));
            this.CheckSerializedField(_levelText, nameof(_levelText));
            this.CheckSerializedField(_costsList, nameof(_costsList));
            this.CheckSerializedField(_costDisplayPrefab, nameof(_costDisplayPrefab));
        }

        private void Start()
        {
            _target = ConvertToBuilding(Building);

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

        private void OnClick()
        {
            Debug.Log(_target.BuildingState);
            switch (_target.BuildingState)
            {
                case BuildingState.Build:
                    _target.Build(Player.CurrentPlayer);
                    break;
                case BuildingState.Upgrade:
                    if (Player.CurrentPlayer.HasStructure(_target))
                    {
                        _target.Upgrade();
                    }
                    break;
                case BuildingState.Maxlevel:
                    //Do nothing
                    break;
            }
            _levelText.text = "Lvl:" + _target.Level;
            UpdateButton();
            UpdateCostDisplay();
        }

        private void UpdateButton()
        {
            switch (_target.BuildingState)
            {
                case BuildingState.Build:
                    _buildButton.GetComponentInChildren<Text>().text = "Build";
                    _buildButton.interactable = _target.CanBuild(Player.CurrentPlayer);
                    break;
                case BuildingState.Upgrade:
                    _buildButton.GetComponentInChildren<Text>().text = "Upgrade";
                    _buildButton.interactable = _target.CanUpgrade();
                    break;
                case BuildingState.Maxlevel:
                    _buildButton.GetComponentInChildren<Text>().text = "Maxed";
                    _buildButton.interactable = false;
                    break;
            }
            _buildButton.Select();
        }

        private void UpdateCostDisplay()
        {
            foreach (Transform child in _costsList.transform)
            {
                Destroy(child.gameObject);
            }
            foreach (var res in _target.GetCost())
            {
                var listItem = Instantiate(_costDisplayPrefab);
                listItem.GetComponent<ResourceDisplay>().Watched = res;
                listItem.transform.SetParent(_costsList.transform);
            }
        }

        private static string[] GetOptions()
        {
            var buildingList = SessionGenerator.GetAllBuildings();
            return buildingList.Select(building => building.GetName()).ToArray();
        }

        private static Building ConvertToBuilding(string name)
        {
            return SessionGenerator.GetAllBuildings().FirstOrDefault(building => building.GetName() == name);
        }
    }
}
