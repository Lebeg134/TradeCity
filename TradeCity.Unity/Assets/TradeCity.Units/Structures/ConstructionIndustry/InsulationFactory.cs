/**
 * @(#) InsulationFactory.cs
 */

using System.Collections.Generic;
using TradeCity.Engine.Resources;
using TradeCity.Engine.Structures;

namespace TradeCity.Units.Structures.ConstructionIndustry
{
    public class InsulationFactory : Building
    {
        public override string GetName()
        {
            return "Insulation Factory";
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