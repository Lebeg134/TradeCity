using System;
using System.Collections.Generic;
using TradeCity.Engine.Production;
using TradeCity.Engine.Resources;
using TradeCity.Engine.Structures;
using TradeCity.Engine.Structures.Interfaces;
using TradeCity.Units.Resources.ConstructionIndustry;
using TradeCity.Units.Resources.EnergySector;
using TradeCity.Units.Resources.Workforce;
using TradeCity.Units.Structures.Town;

namespace TradeCity.Units.Structures.Common
{
    [Serializable]
    public class GlassKiln : Building
    {
        public GlassKiln()
        {
            Recipes.Add(new ManyToOneRecipe(
                new List<Resource> { new Electricity(1), new Sand(1) }, 
                new Glass(1), 10));
        }

        public override string GetName()
        {
            return "Glass Kiln";
        }
        public override Branches GetBranch()
        {
            return Branches.Construction;
        }

        public override List<IOwnable> GetCriteria()
        {
            return new List<IOwnable> { new CraftsmanHq() };
        }

        protected override int GetMaxLevel()
        {
            return 10;
        }
        
        public override List<Resource> GetProduce()
        {
            return new List<Resource> { new Glass(5 * _level) };
        }

        protected override List<Resource> GetUpkeep(int level)
        {
            return new List<Resource> { new Sand(25 * level), new Electricity(25 * level) };
        }

        protected override List<Resource> GetCost(int level)
        {
            return level == 0 ? new List<Resource> { new Bricks(150), new Workforce(25) } :
                new List<Resource> { new Bricks(100 * level), new Concrete(50 * level) };
        }
    }
}