using AutSoft.UnitySupplements.EventBus;
using AutSoft.UnitySupplements.Vitamins;
using Injecter;
using System;
using TMPro;
using TradeCity.Engine.Core;
using TradeCity.Engine.Core.Interfaces;
using TradeCity.Engine.Structures;
using TradeCity.Unity.Scripts.GUI.ResourceDisplays;
using UnityEngine;
using UnityEngine.UI;

namespace TradeCity.Unity.Scripts.GUI.Lands
{
    public class OwnedLandVisual : MonoBehaviour
    {
        [Inject] private IPlayerService _playerService = default!;
        [Inject] private IEventBus _eventBus = default!;

        [SerializeField] private Image _sprite = default!;
        [SerializeField] private TMP_Text _nameText = default!;
        [SerializeField] private TMP_Text _levelText = default!;
        [SerializeField] private Button _upgradeButton= default!;
        [SerializeField] private CostResourceDisplay _produceDisplay = default!;
        [SerializeField] private CostResourceDisplay _produceDisplay2 = default!;
        [SerializeField] private CostResourceDisplay _upgradeCostDisplay = default!;

        private Land _watched;

        private void Awake()
        {
            this.CheckSerializedField(_sprite, nameof(_sprite));
            this.CheckSerializedField(_nameText, nameof(_nameText));
            this.CheckSerializedField(_levelText, nameof(_levelText));
            this.CheckSerializedField(_upgradeButton, nameof(_upgradeButton));
            this.CheckSerializedField(_produceDisplay, nameof(_produceDisplay));
            this.CheckSerializedField(_produceDisplay2, nameof(_produceDisplay2));
            this.CheckSerializedField(_upgradeCostDisplay, nameof(_upgradeCostDisplay));

            _playerService = EngineCore.InjectPlayerService();
            _eventBus = EngineCore.InjectEventBus();

            _upgradeButton.onClick.AddListener(OnUpgradeClicked);

            _eventBus.SubscribeWeak<CommonStructure.StructureUpgraded>(this, OnStructureUpgraded);
        }

        private void Update()
        {
            _upgradeButton.enabled = _watched.CanUpgrade();
        }

        private void OnStructureUpgraded(CommonStructure.StructureUpgraded message)
        {
            UpdateVisuals();
        }

        private void OnUpgradeClicked()
        {

            if (_watched == null) throw new InvalidOperationException();
            _watched.Upgrade();
            UpdateVisuals();
        }

        public void SetWatched(Land watchedLand)
        {
            _watched = watchedLand;
            var loadedSprite = Resources.Load<Sprite>(_watched.GetResourcePath());
            if (loadedSprite != null)
                _sprite.sprite = loadedSprite;
            UpdateVisuals();
        }

        private void UpdateVisuals()
        {
            _nameText.text = _watched.GetName();
            _levelText.text = _watched.Level.ToString();
            var produce = _watched.GetProduce();
            _produceDisplay.Watched = produce[0];
            if (produce.Count > 1)
            {
                _produceDisplay2.gameObject.SetActive(true);
                _produceDisplay2.Watched = produce[1];
            }
            else
            {
                _produceDisplay2.gameObject.SetActive(false);
            }

            _upgradeCostDisplay.Watched = _watched.GetUpgradeCost();


        }

    }
}
