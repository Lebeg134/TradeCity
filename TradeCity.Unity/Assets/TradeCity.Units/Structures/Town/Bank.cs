using System.Collections.Generic;
using TradeCity.Engine.Production;
using TradeCity.Engine.Resources;
using TradeCity.Engine.Structures;
using TradeCity.Engine.Structures.Interfaces;
using TradeCity.Units.Resources.Common;
using TradeCity.Units.Resources.Workforce;

namespace TradeCity.Units.Structures.Common
{
    public class Bank :Building
    {
        public Bank()
        {
            Recipes.Add(new SimpleRecipe(new Money(10), new Money(11), 1000));
        }

        public override string GetName()
        {
            return "Bank";
        }

        public override Branches GetBranch()
        {
            return Branches.Town;
        }

        protected override int GetMaxLevel()
        {
            return 10;
        }

        public override List<IOwnable> GetCriteria()
        {
            return new List<IOwnable>(){new TownHall()};
        }


        protected override List<Resource> GetCost(int level)
        {
            return new List<Resource> { new Wood(100), new Workforce(200) };
        }
    }
}