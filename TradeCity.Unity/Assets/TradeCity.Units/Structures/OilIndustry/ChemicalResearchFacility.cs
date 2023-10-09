using System;
using System.Collections.Generic;
using TradeCity.Engine.Resources;
using TradeCity.Engine.Structures;
using TradeCity.Engine.Structures.Interfaces;
using TradeCity.Units.Resources.ConstructionIndustry;
using TradeCity.Units.Resources.EnergySector;
using TradeCity.Units.Resources.OilIndustry;
using TradeCity.Units.Resources.Workforce;

namespace TradeCity.Units.Structures.OilIndustry
{
    [Serializable]
    public class ChemicalResearchFacility : Building
    {
        public override string GetName()
        {
            return "Chemical Research Facility";
        }

        public override Branches GetBranch()
        {
            return Branches.Workforce;
        }

        public override List<IOwnable> GetCriteria()
        {
            return new List<IOwnable>();
        }

        

        protected override int GetMaxLevel()
        {
            return 10;
        }

        

        protected override List<Resource> GetUpkeep(int level)
        {
            return new List<Resource> { new Electricity(2 * level), new Oil(10) };
        }

        protected override List<Resource> GetCost(int level)
        {
            if (level == 0)
                return new List<Resource> { new Concrete(100), new Workforce(25) };
            return new List<Resource> { new Concrete(100 + 50 * level), new Glass(50 * level) };
        }
    }
}