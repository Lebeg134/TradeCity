using System;
using System.Collections.Generic;
using TradeCity.Engine.Production;
using TradeCity.Engine.Resources;
using TradeCity.Engine.Structures;
using TradeCity.Units.Resources.Common;
using TradeCity.Units.Resources.ConstructionIndustry;
using TradeCity.Units.Resources.Workforce;

namespace TradeCity.Units.Structures.ConstructionIndustry
{
    [Serializable]
    public class StoneCutter : Building
    {
        public StoneCutter()
        {
            Recipes.Add(new SimpleRecipe(new Stone(3), new Bricks(1), 10));
        }

        public override string GetName()
        {
            return "Stone Cutter";
        }

        public override Branches GetBranch()
        {
            return Branches.Construction;
        }

        public override void Upgrade()
        {
            base.Upgrade();
            Recipes[0].Limit += _level * 5 + 5;
        }


        protected override List<Resource> GetCost(int level)
        {
            return new List<Resource> { new Workforce(10 + level * 15), new Wood(25 + level * 50) };
        }

        protected override int GetMaxLevel()
        {
            return 10;
        }
    }
}