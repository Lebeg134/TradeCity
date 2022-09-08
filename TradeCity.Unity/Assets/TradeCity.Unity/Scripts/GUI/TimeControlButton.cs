using AutSoft.UnitySupplements.Vitamins;
using TradeCity.Engine.TimeManager;
using UnityEngine;
using UnityEngine.UI;

namespace TradeCity.Unity.Scripts.GUI
{
    public class TimeControlButton : MonoBehaviour
    {
        [SerializeField] private Sprite _play;
        [SerializeField] private Sprite _pause;
        [SerializeField] private Image _icon;
        [SerializeField] private Button _button;
        [SerializeField] private Color _playColor;
        [SerializeField] private Color _pauseColor;
        private Clock _clock;

        private void Awake()
        {
            this.CheckSerializedField(_play, nameof(_play));
            this.CheckSerializedField(_pause, nameof(_pause));
            this.CheckSerializedField(_icon, nameof(_icon));
            this.CheckSerializedField(_button, nameof(_button));
        }

        private void Start()
        {
            _clock = Clock.Instance;
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
            if (_clock.IsEnabled())
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
