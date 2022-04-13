using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.GUI.ResourceDispalys
{
    class LiveResourceDisplayScript: ResourceDisplayScript
    {
        enum IndicatorState
        {
            UP,
            NEUTRAL,
            DOWN
        }
        public float indicatorLimit;
        float indicatorTime;
        int prevAmount = 0;
        public Image upIndicator;
        public Image downIndicator;
        IndicatorState state = IndicatorState.NEUTRAL;
        protected override void Start()
        {
            base.Start();
            prevAmount = watched.amount();
            UpdateIndicator(state);
        }
        protected override void Update()
        {
            int amount = watched.amount();
            display.text = amount.ToString();
            if (prevAmount == amount && (indicatorTime += Time.deltaTime) >= indicatorLimit)
            {
                state = IndicatorState.NEUTRAL;
                indicatorTime = 0;
            }
            else if(prevAmount < amount)
            {
                state = IndicatorState.UP;
                indicatorTime = 0;
            }
            else if(prevAmount > amount)
            {
                state = IndicatorState.DOWN;
                indicatorTime = 0;
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
