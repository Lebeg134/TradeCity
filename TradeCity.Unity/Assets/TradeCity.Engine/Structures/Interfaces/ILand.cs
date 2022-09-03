using System;
using System.Collections.Generic;
using TradeCity.Engine.Resources;
using TradeCity.Engine.Session;
using TradeCity.Engine.TimeManager;

namespace TradeCity.Engine.Structures.Interfaces
{
    internal interface ILand : IOwnable, IUpgradeable, ITickable
    {
        event Action<Land> OnPurchase;
        Land GetNew();
        public void Purchase(Player by);
        List<Resource> GetStartingCost();
        List<Resource> GetProduce();
    }
}
