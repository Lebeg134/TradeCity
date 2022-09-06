using TradeCity.Engine.TimeManager;
using UnityEngine;
using UnityEngine.UI;
using AutSoft.UnitySupplements.Vitamins;

namespace TradeCity.Unity.Scripts.GUI
{
    public class TimeControlButton : MonoBehaviour
    {
        [SerializeField] private Sprite play;
        [SerializeField] private Sprite pause;
        [SerializeField] private Image icon;
        [SerializeField] private Button button;
        [SerializeField] private Color playColor;
        [SerializeField] private Color pauseColor;
        private Clock clock;

        private void Awake()
        {
            this.CheckSerializedField(play, nameof(play));
            this.CheckSerializedField(pause, nameof(pause));
            this.CheckSerializedField(icon, nameof(icon));
            this.CheckSerializedField(button, nameof(button));
        }

        private void Start()
        {
            clock = Clock.Instance;
            button.onClick.AddListener(Toggle);
        }

        private void OnDestroy()
        {
            button.onClick.RemoveListener(Toggle);
        }

        private void Update() => UpdateVisuals();

        private void Toggle() => clock.Toggle();

        private void UpdateVisuals()
        {
            if (clock.IsEnabled())
            {
                icon.sprite = pause;
                button.image.color = pauseColor;
            }
            else
            {
                icon.sprite = play;
                button.image.color = playColor;
            }
        }
    }
}
