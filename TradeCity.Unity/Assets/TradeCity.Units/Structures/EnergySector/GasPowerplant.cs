/**
 * @(#) GasPowerplant.cs
 */

using System.Collections.Generic;
using TradeCity.Engine.Resources;
using TradeCity.Engine.Structures;

namespace TradeCity.Units.Structures.EnergySector
{
    public class GasPowerplant : Building
    {
        public override string GetName()
        {
            return "Gas Power Plant";
        }

        public override Branches GetBranch()
        {
            return Branches.Energy;
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