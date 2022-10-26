using AutSoft.UnitySupplements.EventBus;
using AutSoft.UnitySupplements.Vitamins;
using Injecter;
using TradeCity.Engine.Core;
using UnityEngine;
using UnityEngine.UI;

namespace TradeCity.Unity.Scripts.GUI.Navigation
{
    public enum ActiveScreen
    {
        City,
        Map,
        Market
    }
    public class MenuController : MonoBehaviour
    {
        [Inject] private IEventBus _eventBus = default!;

        [SerializeField] private Canvas _city = default!;
        [SerializeField] private Canvas _map = default!;
        [SerializeField] private Canvas _market = default!;
        [SerializeField] private Button _cityButton = default!;
        [SerializeField] private Button _mapButton = default!;
        [SerializeField] private Button _marketButton = default!;

        private ActiveScreen _active;
        public ActiveScreen Active
        {
            get => _active;
            set
            {
                _active = value;
                _eventBus.Invoke(new ScreenChanged(_active));
            }
        }

        public delegate void ActiveChanged(ActiveScreen newScreen);


        private void Awake()
        {
            _eventBus = EngineCore.InjectEventBus();

            this.CheckSerializedField(_city, nameof(_city));
            this.CheckSerializedField(_map, nameof(_map));
            this.CheckSerializedField(_market, nameof(_market));
            this.CheckSerializedField(_cityButton, nameof(_cityButton));
            this.CheckSerializedField(_mapButton, nameof(_mapButton));
            this.CheckSerializedField(_marketButton, nameof(_marketButton));


            _cityButton.onClick.AddListener(() => SwitchTo(ActiveScreen.City));
            _mapButton.onClick.AddListener(() => SwitchTo(ActiveScreen.Map));
            _marketButton.onClick.AddListener(() => SwitchTo(ActiveScreen.Market));
        }

        private void Start()
        {
            Active = ActiveScreen.City;
            SwitchTo(Active);
        }

        private void SwitchTo(ActiveScreen screen)
        {
            if (Active != screen)
                Active = screen;
            switch (screen)
            {
                case ActiveScreen.City:
                    _city.enabled = true;
                    _map.enabled = false;
                    _market.enabled = false;
                    break;
                case ActiveScreen.Map:
                    _city.enabled = false;
                    _map.enabled = true;
                    _market.enabled = false;
                    break;
                case ActiveScreen.Market:
                    _city.enabled = false;
                    _map.enabled = false;
                    _market.enabled = true;
                    break;
            }
        }
        public class ScreenChanged : IEvent
        {
            public ScreenChanged(ActiveScreen screen)
            {
                ActiveScreen = screen;
            }

            public ActiveScreen ActiveScreen { get; }
        }
    }
}