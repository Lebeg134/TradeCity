using System.Collections.Generic;
using TradeCity.Engine.Resources;
using TradeCity.Engine.Structures;
using TradeCity.Units.Resources.Common;
using TradeCity.Units.Resources.ConstructionIndustry;
using TradeCity.Units.Resources.EnergySector;
using TradeCity.Units.Resources.Workforce;

namespace TradeCity.Units.Structures.Common
{
    public class TownHall: Building
    {
        public override string GetName()
        {
            return "Town Hall";
        }

        public override Branches GetBranch()
        {
            return Branches.Town;
        }

        protected override int GetMaxLevel()
        {
            return 10;
        }

        public override List<Resource> GetUpkeep()
        {
            return new List<Resource>() { new Electricity(15) };
        }

        protected override List<Resource> GetCost(int level)
        {
            return new List<Resource> { new Bricks(100), new Workforce(50) };
        }
    }
}