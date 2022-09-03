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
* @(#) Lumberyard.cs
*/
namespace TradeCity.Units.Structures.ConstructionIndustry
{
    [Serializable]
    public class Lumberyard : Building
    {
        public Lumberyard()
        {
            Recipes.Add(new ManyToOneRecipe(new List<Resource> { new Electricity(1), new Wood(10) }, new Lumber(5), 5));
        }
        public override List<IOwnable> GetCriteria()
        {
            return new List<IOwnable>();
        }

        public override Branches GetBranch()
        {
            return Branches.CONSTRUCTION;
        }

        protected override int GetMaxLevel()
        {
            return 20;
        }

        public override string GetName()
        {
            return "Lumberyard";
        }

        public override List<Resource> GetProduce()
        {
            return new List<Resource> { new Lumber(level * 2) };
        }

        protected override List<Resource> GetUpkeep(int level)
        {
            return new List<Resource> { new Wood(3 * level), new Electricity(2 * level) };
        }

        protected override List<Resource> GetCost(int level)
        {
            if (level == 0)
                return new List<Resource> { new Wood(100), new Workforce(10) };
            else if (level < 10)
                return new List<Resource> { new Lumber(50 * level), new Workforce(5) };
            else
                return new List<Resource> { new Concrete(50 * level), new Workforce(2) };
        }
    }

}
