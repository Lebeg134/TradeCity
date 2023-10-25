using System;
using System.Collections.Generic;
using TradeCity.Engine.Resources;
using TradeCity.Engine.Structures.EasyInheritance;
using TradeCity.Engine.Structures.Interfaces;
using TradeCity.Units.Resources.ConstructionIndustry;
using TradeCity.Units.Resources.EnergySector;
using TradeCity.Units.Resources.Workforce;

namespace TradeCity.Units.Structures.OilIndustry
{
    [Serializable]
    public class ChemicalSafetyBureau : SpecialBuilding
    {
        public override string GetName()
        {
            return "Chemical Safety Bureau";
        }

        public override Branches GetBranch()
        {
            return Branches.Town;
        }

        public override List<Resource> GetCost()
        {
            return new List<Resource> { new Bricks(250), new Workforce(25) };
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