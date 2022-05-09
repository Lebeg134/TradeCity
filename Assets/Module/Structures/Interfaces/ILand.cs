using Lebeg134.Module.Resources;
using Lebeg134.Module.Session;
using Lebeg134.Module.TimeManager;
using Lebeg134.Resources.Common;
using System;
using System.Collections.Generic;

namespace Lebeg134.Module.Structures
{
    internal interface ILand: IOwnable, IUpgradeable, ITickable
    {
        event Action<Land> OnPurchase;
        public void Purchase(Player by);
        List<Resource> GetStartingCost();
        List<Resource> GetProduce();
    }
}
