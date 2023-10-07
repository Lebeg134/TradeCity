/**
 * @(#) ReinforcedConcretePackager.cs
 */

using System.Collections.Generic;
using TradeCity.Engine.Resources;
using TradeCity.Engine.Structures;

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
            throw new System.NotImplementedException();
        }

        protected override int GetMaxLevel()
        {
            throw new System.NotImplementedException();
        }

        protected override List<Resource> GetCost(int level)
        {
            throw new System.NotImplementedException();
        }
    }
}