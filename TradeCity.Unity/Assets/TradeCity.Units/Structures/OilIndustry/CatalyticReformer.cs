/**
 * @(#) CatalyticReformer.cs
 */

using System.Collections.Generic;
using TradeCity.Engine.Resources;
using TradeCity.Engine.Structures;

namespace TradeCity.Units.Structures.OilIndustry
{
    public class CatalyticReformer : Building
    {
        public override string GetName()
        {
            return "Catalytic Reformer";
        }

        public override Branches GetBranch()
        {
            return Branches.Oil;
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