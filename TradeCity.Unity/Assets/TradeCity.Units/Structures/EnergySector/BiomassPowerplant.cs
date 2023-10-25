/**
 * @(#) BiomassPowerplant.cs
 */

using System.Collections.Generic;
using TradeCity.Engine.Resources;
using TradeCity.Engine.Structures;
using TradeCity.Units.Resources.Common;
using TradeCity.Units.Resources.Workforce;

namespace TradeCity.Units.Structures.EnergySector
{
    public class BiomassPowerplant : Building
    {
        public override string GetName()
        {
            return "Biomass Power Plant";
        }

        public override Branches GetBranch()
        {
            return Branches.Energy;
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