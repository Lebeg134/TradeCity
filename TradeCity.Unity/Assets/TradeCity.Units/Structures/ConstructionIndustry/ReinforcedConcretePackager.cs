/**
 * @(#) ReinforcedConcretePackager.cs
 */

using System.Collections.Generic;
using TradeCity.Engine.Resources;
using TradeCity.Engine.Structures;
using TradeCity.Units.Resources.Common;
using TradeCity.Units.Resources.Workforce;

namespace TradeCity.Units.Structures.ConstructionIndustry
{
    public class ReinforcedConcretePackager : Building
    {
        public override string GetName()
        {
            return "Reinforced Concrete Factory";
        }

        public override Branches GetBranch()
        {
            return Branches.Construction;
        }

        protected override int GetMaxLevel()
        {
            return 10;
        }

        protected override List<Resource> GetCost(int level)
        {
            return new List<Resource> { new Wood(100), new Workforce(50) };
        }
    }
}