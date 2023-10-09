using System;
using System.Collections.Generic;
using TradeCity.Engine.Resources;
using TradeCity.Engine.Structures.EasyInheritance;
using TradeCity.Engine.Structures.Interfaces;
using TradeCity.Units.Resources.Common;
using TradeCity.Units.Resources.ConstructionIndustry;
using TradeCity.Units.Resources.EnergySector;

namespace TradeCity.Units.Structures.Common
{
    [Serializable]
    public class CraftsmanHq : SpecialBuilding
    {
        public override string GetName()
        {
            return "Craftsman HQ";
        }
        public override Branches GetBranch()
        {
            return Branches.Town;
        }

        public override List<Resource> GetCost()
        {
            return new List<Resource> { new Concrete(100), new Steel(100) };
        }

        public override List<IOwnable> GetCriteria()
        {
            return new List<IOwnable>();
        }


        

        public override List<Resource> GetUpkeep()
        {
            return new List<Resource> { new Electricity(5) };
        }
    }
}