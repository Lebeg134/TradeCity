using UnityEngine;
using UnityEngine.UI;
using AutSoft.UnitySupplements.Vitamins;

namespace TradeCity.Unity.Scripts.GUI.Navigation
{
    public enum ActiveScreen
    {
        CITY,
        MAP,
        MARKET
    }
    public class MenuController : MonoBehaviour
    {
        [SerializeField] private Canvas city;
        [SerializeField] private Canvas map;
        [SerializeField] private Canvas market;
        [SerializeField] private Button cityButton;
        [SerializeField] private Button mapButton;
        [SerializeField] private Button marketButton;

        private ActiveScreen _active;
        public ActiveScreen Active
        {
            get => _active;
            set
            {
                _active = value;
                OnScreenChanged.Invoke(value);
            }
        }

        public delegate void ActiveChanged(ActiveScreen newScreen);
        public event ActiveChanged OnScreenChanged;

        private void Awake()
        {
            this.CheckSerializedField(city, nameof(city));
            this.CheckSerializedField(map, nameof(map));
            this.CheckSerializedField(market, nameof(market));
            this.CheckSerializedField(cityButton, nameof(cityButton));
            this.CheckSerializedField(mapButton, nameof(mapButton));
            this.CheckSerializedField(marketButton, nameof(marketButton));


            cityButton.onClick.AddListener(() => SwitchTo(ActiveScreen.CITY));
            mapButton.onClick.AddListener(() => SwitchTo(ActiveScreen.MAP));
            marketButton.onClick.AddListener(() => SwitchTo(ActiveScreen.MARKET));
        }

        private void Start()
        {
            Active = ActiveScreen.CITY;
            SwitchTo(Active);
        }

        private void SwitchTo(ActiveScreen screen)
        {
            if (Active != screen)
                Active = screen;
            switch (screen)
            {
                case ActiveScreen.CITY:
                    city.enabled = true;
                    map.enabled = false;
                    market.enabled = false;
                    break;
                case ActiveScreen.MAP:
                    city.enabled = false;
                    map.enabled = true;
                    market.enabled = false;
                    break;
                case ActiveScreen.MARKET:
                    city.enabled = false;
                    map.enabled = false;
                    market.enabled = true;
                    break;
            }
        }
    }
}