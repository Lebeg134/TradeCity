using AutSoft.UnitySupplements.EventBus;
using AutSoft.UnitySupplements.Vitamins;
using Injecter;
using TMPro;
using TradeCity.Engine.Core;
using TradeCity.Engine.Core.Interfaces;
using TradeCity.Engine.Resources;
using TradeCity.Engine.Session;
using TradeCity.Engine.Structures;
using TradeCity.Units.Resources.Common;
using TradeCity.Unity.Scripts.GUI.ResourceDisplays;
using UnityEditor.VersionControl;
using UnityEngine;
using UnityEngine.UI;

namespace TradeCity.Unity.Scripts.GUI.Lands
{
    public class LandBuyPanel: MonoBehaviour
    {
        [Inject] private IPlayerService _playerService;

        [SerializeField] private Image _sprite = default!;
        [SerializeField] private TMP_Text _nameText = default!;
        [SerializeField] private CostResourceDisplay _costDisplay = default!;
        [SerializeField] private Button _buyButton = default!;

        private Land _watched;
        private Resource _price;

        private void Awake()
        {
            _playerService = EngineCore.InjectPlayerService();

            this.CheckSerializedField(_sprite, nameof(_sprite));
            this.CheckSerializedField(_nameText, nameof(_nameText));
            this.CheckSerializedField(_costDisplay, nameof(_costDisplay));
            this.CheckSerializedField(_buyButton, nameof(_buyButton));

            _buyButton.onClick.AddListener(OnClicked);
        }

        private void Start()
        {
            if (_watched == null) return;
            Display(_watched);
        }

        private void Update()
        {
            var player = _playerService.CurrentPlayer;
            if (player.HasStructure(_watched))
            {
                Hide();
                return;
            }
            _buyButton.enabled = player.HasResource(_price);
        }

        private void OnClicked()
        {
            var player = _playerService.CurrentPlayer;
            _watched.Purchase(player);
            Hide();
        }

        public void Display(Land watchLand)
        {
            _watched = watchLand;
            _price = _watched.GetStartingCost();

            _nameText.text = _watched.GetName();
            _costDisplay.Watched = _price;

            var loadedSprite = Resources.Load<Sprite>(_watched.GetResourcePath());
            if (loadedSprite != null)
                _sprite.sprite = loadedSprite;
            gameObject.SetActive(true);
        }

        public void Hide()
        {
            gameObject.SetActive(false);
        }
    }
}