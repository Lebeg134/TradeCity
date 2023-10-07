/**
 * @(#) MeroxPlant.cs
 */

using System.Collections.Generic;
using TradeCity.Engine.Resources;
using TradeCity.Engine.Structures;

namespace TradeCity.Units.Structures.OilIndustry
{
    public class MeroxPlant : Building
    {
        public override string GetName()
        {
            return "Merox Plant";
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