using AutSoft.UnitySupplements.Vitamins;
using Injecter;
using TradeCity.Engine.Core;
using TradeCity.Engine.TimeManager;
using UnityEngine;
using UnityEngine.UI;

namespace TradeCity.Unity.Scripts.GUI
{
    public class TimeControlButton : MonoBehaviour
    {
        [Inject]
        private IClock _clock;

        [SerializeField] private Sprite _play = default!;
        [SerializeField] private Sprite _pause = default!;
        [SerializeField] private Image _icon = default!;
        [SerializeField] private Button _button = default!;
        [SerializeField] private Color _playColor = default!;
        [SerializeField] private Color _pauseColor = default!;
        
        private void Awake()
        {
            _clock = EngineCore.Instance.InjectClock();

            this.CheckSerializedField(_play, nameof(_play));
            this.CheckSerializedField(_pause, nameof(_pause));
            this.CheckSerializedField(_icon, nameof(_icon));
            this.CheckSerializedField(_button, nameof(_button));
        }

        private void Start()
        {
            _clock = EngineCore.Instance.InjectClock();
            _button.onClick.AddListener(Toggle);
        }

        private void OnDestroy()
        {
            _button.onClick.RemoveListener(Toggle);
        }

        private void Update()
        {
            UpdateVisuals();
        }

        private void Toggle()
        {
            _clock.Toggle();
        }

        private void UpdateVisuals()
        {
            if (_clock.IsEnabled)
            {
                _icon.sprite = _pause;
                _button.image.color = _pauseColor;
            }
            else
            {
                _icon.sprite = _play;
                _button.image.color = _playColor;
            }
        }
    }
}
