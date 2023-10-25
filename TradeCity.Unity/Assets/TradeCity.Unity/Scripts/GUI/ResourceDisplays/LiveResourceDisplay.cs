using AutSoft.UnitySupplements.Vitamins;
using TradeCity.Engine.Resources;
using UnityEngine;
using UnityEngine.UI;

namespace TradeCity.Unity.Scripts.GUI.ResourceDisplays
{
    internal enum IndicatorState
    {
        Up,
        Neutral,
        Down
    }

    public class LiveResourceDisplay : ResourceDisplay
    {
        [SerializeField] private Image _upIndicator = default!;
        [SerializeField] private Image _downIndicator = default!;
        [SerializeField] private float _indicatorTimeShown = 1.2f;

        private float _currentIndicatorTime;
        private int _prevAmount = 0;
        private IndicatorState _state = IndicatorState.Neutral;

        protected override void Awake()
        {
            base.Awake();
            this.CheckSerializedField(_upIndicator, nameof(_upIndicator));
            this.CheckSerializedField(_downIndicator, nameof(_downIndicator));
        }

        protected override void Start()
        {
            base.Start();
            _prevAmount = Watched.GetStock();
            UpdateIndicator(_state);
        }

        protected override void Update()
        {
            if (Watched == null) return;

            int amount = Watched.GetStock();
            if (Watched is ContinuousResource continousResource)
            {
                _display.text = amount + "/" + continousResource.Buffer;
            }
            else
            {
                _display.text = Watched.GetStock().ToString();
            }

            if (_prevAmount == amount && (_currentIndicatorTime += Time.deltaTime) >= _indicatorTimeShown)
            {
                _state = IndicatorState.Neutral;
                _currentIndicatorTime = 0;
            }
            else if (_prevAmount < amount)
            {
                _state = IndicatorState.Up;
                _currentIndicatorTime = 0;
            }
            else if (_prevAmount > amount)
            {
                _state = IndicatorState.Down;
                _currentIndicatorTime = 0;
            }

            UpdateIndicator(_state);
            _prevAmount = amount;
        }

        private void UpdateIndicator(IndicatorState state)
        {
            switch (state)
            {
                case IndicatorState.Up:
                    _upIndicator.enabled = true;
                    _downIndicator.enabled = false;
                    break;
                case IndicatorState.Neutral:
                    _upIndicator.enabled = false;
                    _downIndicator.enabled = false;
                    break;
                case IndicatorState.Down:
                    _upIndicator.enabled = false;
                    _downIndicator.enabled = true;
                    break;
            }
        }
    }
}
