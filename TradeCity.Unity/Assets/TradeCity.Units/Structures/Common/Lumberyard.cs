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

namespace TradeCity.Units.Structures.Common
{
    [Serializable]
    public class Lumberyard : Building
    {
        public Lumberyard()
        {
            Recipes.Add(new ManyToOneRecipe(
                new List<Resource> { new Electricity(1), new Wood(10) }, 
                new Lumber(5), 5));
        }

        public override string GetName()
        {
            return "Lumberyard";
        }

        public override Branches GetBranch()
        {
            return Branches.Construction;
        }

        public override List<IOwnable> GetCriteria()
        {
            return new List<IOwnable>();
        }

        protected override int GetMaxLevel()
        {
            return 20;
        }

        public override List<Resource> GetProduce()
        {
            return new List<Resource> { new Lumber(_level * 2) };
        }

        protected override List<Resource> GetUpkeep(int level)
        {
            return new List<Resource> { new Wood(3 * level), new Electricity(2 * level) };
        }

        protected override List<Resource> GetCost(int level)
        {
            if (level == 0)
                return new List<Resource> { new Wood(100), new Workforce(10) };
            if (level < 10)
                return new List<Resource> { new Lumber(50 * level), new Workforce(5) };
            return new List<Resource> { new Concrete(50 * level), new Workforce(2) };
        }
    }
}