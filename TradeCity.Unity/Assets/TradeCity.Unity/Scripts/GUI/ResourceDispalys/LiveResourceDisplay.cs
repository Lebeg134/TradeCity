using TradeCity.Engine.Resources;
using UnityEngine;
using UnityEngine.UI;
using AutSoft.UnitySupplements.Vitamins;

namespace TradeCity.Unity.Scripts.GUI.ResourceDispalys
{
    enum IndicatorState
    {
        UP,
        NEUTRAL,
        DOWN
    }

    public class LiveResourceDisplay : ResourceDisplay
    {
        [SerializeField] private Image upIndicator;
        [SerializeField] private Image downIndicator;
        [SerializeField] private float indicatorTimeShown = 0.75f;

        private float currentIndicatorTime;
        private int prevAmount = 0;
        private IndicatorState state = IndicatorState.NEUTRAL;

        protected override void Awake()
        {
            base.Awake();
            this.CheckSerializedField(upIndicator, nameof(upIndicator));
            this.CheckSerializedField(downIndicator, nameof(downIndicator));
        }

        protected override void Start()
        {
            base.Start();
            prevAmount = Watched.GetStock();
            UpdateIndicator(state);
        }

        protected override void Update()
        {
            if (Watched == null) return;

            int amount = Watched.GetStock();
            if (Watched is ContinousResource continousResource)
            {
                display.text = amount + "/" + continousResource.Buffer;
            }
            else
            {
                display.text = Watched.GetStock().ToString();
            }

            if (prevAmount == amount && (currentIndicatorTime += Time.deltaTime) >= indicatorTimeShown)
            {
                state = IndicatorState.NEUTRAL;
                currentIndicatorTime = 0;
            }
            else if (prevAmount < amount)
            {
                state = IndicatorState.UP;
                currentIndicatorTime = 0;
            }
            else if (prevAmount > amount)
            {
                state = IndicatorState.DOWN;
                currentIndicatorTime = 0;
            }

            UpdateIndicator(state);
            prevAmount = amount;
        }

        private void UpdateIndicator(IndicatorState state)
        {
            switch (state)
            {
                case IndicatorState.UP:
                    upIndicator.enabled = true;
                    downIndicator.enabled = false;
                    break;
                case IndicatorState.NEUTRAL:
                    upIndicator.enabled = false;
                    downIndicator.enabled = false;
                    break;
                case IndicatorState.DOWN:
                    upIndicator.enabled = false;
                    downIndicator.enabled = true;
                    break;
            }
        }
    }
}
