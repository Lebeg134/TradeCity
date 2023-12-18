/**
 * @(#) BiomassPowerplant.cs
 */

using System.Collections.Generic;
using TradeCity.Engine.Production;
using TradeCity.Engine.Resources;
using TradeCity.Engine.Structures;
using TradeCity.Units.Resources.Common;
using TradeCity.Units.Resources.ConstructionIndustry;
using TradeCity.Units.Resources.EnergySector;
using TradeCity.Units.Resources.Workforce;

namespace TradeCity.Units.Structures.EnergySector
{
    public class BiomassPowerplant : Building
    {
        public BiomassPowerplant()
        {
            Recipes.Add(new SimpleRecipe(new Wood(5), new Electricity(1), 5));
        }

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