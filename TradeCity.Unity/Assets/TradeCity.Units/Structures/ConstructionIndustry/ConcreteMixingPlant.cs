using System;
using System.Collections.Generic;
using TradeCity.Engine.Production;
using TradeCity.Engine.Resources;
using TradeCity.Engine.Structures;
using TradeCity.Engine.Structures.Interfaces;
using TradeCity.Units.Resources.Common;
using TradeCity.Units.Resources.ConstructionIndustry;
using TradeCity.Units.Resources.EnergySector;
using TradeCity.Units.Resources.Workforce;

/**
* @(#) ConcreteMixingPlant.cs
*/
namespace TradeCity.Units.Structures.ConstructionIndustry
{
    [Serializable]
    public class ConcreteMixingPlant : Building
    {
        public ConcreteMixingPlant()
        {
            Recipes.Add(new ManyToOneRecipe(new List<Resource> { new Water(1), new Sand(5) }, new Concrete(3), 5));
        }
        public override List<IOwnable> GetCriteria()
        {
            return new List<IOwnable>();
        }

        public override Branches GetBranch()
        {
            return Branches.Construction;
        }

        protected override int GetMaxLevel()
        {
            return 5;
        }

        public override string GetName()
        {
            return "Concrete Mixing Plant";
        }

        public override List<Resource> GetProduce()
        {
            return new List<Resource> { new Concrete(5 * _level) };
        }

        protected override List<Resource> GetUpkeep(int level)
        {
            return new List<Resource> { new Water(5 * level), new Sand(15 * level), new Electricity(10 * level) };
        }

        protected override List<Resource> GetCost(int level)
        {
            if (level == 0)
                return new List<Resource> { new Stone(100), new Workforce(25) };
            return new List<Resource> { new Concrete(50 + 50 * level), new Workforce(10) };
        }
    }

}
