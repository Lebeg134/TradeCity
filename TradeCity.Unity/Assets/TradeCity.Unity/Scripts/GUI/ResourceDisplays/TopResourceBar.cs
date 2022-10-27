using AutSoft.UnitySupplements.Vitamins;
using TradeCity.Units.Resources.Common;
using TradeCity.Units.Resources.EnergySector;
using TradeCity.Units.Resources.Workforce;
using UnityEngine;

namespace TradeCity.Unity.Scripts.GUI.ResourceDisplays
{
    public class TopResourceBar: MonoBehaviour
    {
        [SerializeField] private ResourceDisplay _moneyDisplay = default!;
        [SerializeField] private ResourceDisplay _electricityDisplay = default!;
        [SerializeField] private ResourceDisplay _waterDisplay = default!;
        [SerializeField] private ResourceDisplay _workforceDisplay = default!;
        private void Awake()
        {
            this.CheckSerializedField(_moneyDisplay, nameof(_moneyDisplay));
            this.CheckSerializedField(_electricityDisplay, nameof(_electricityDisplay));
            this.CheckSerializedField(_waterDisplay, nameof(_waterDisplay));
            this.CheckSerializedField(_workforceDisplay, nameof(_workforceDisplay));

            _moneyDisplay.Watched = new Money(0);
            _electricityDisplay.Watched = new Electricity(0);
            _waterDisplay.Watched = new Water(0);
            _workforceDisplay.Watched = new Workforce(0);
        }
        
    }
}