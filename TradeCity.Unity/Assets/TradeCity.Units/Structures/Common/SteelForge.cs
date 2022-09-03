using System;
using System.Collections.Generic;
using TradeCity.Engine.Production;
using TradeCity.Engine.Resources;
using TradeCity.Engine.Structures;
using TradeCity.Engine.Structures.Interfaces;
using TradeCity.Units.Resources.Common;
using TradeCity.Units.Resources.EnergySector;
using TradeCity.Units.Resources.Workforce;

/**
* @(#) SteelForge.cs
*/
namespace TradeCity.Units.Structures.Common
{
    [Serializable]
    public class SteelForge : Building
    {
        protected static List<Resource>[] GetCostArray => new[]{
                    new List<Resource> { new Wood(100), new Workforce(50) }, //Build cost
                    new List<Resource> { new Steel(100), new Workforce(25) }
                };
        public SteelForge()
        {
            _recipes.Add(new ManyToOneRecipe(new List<Resource> { new Electricity(1), new Iron(2) }, new Steel(1), 5));
        }
        public override void Upgrade()
        {
            base.Upgrade();
            _recipes[0].Limit += 5;
        }

        public override string GetName()
        {
            return "Steel Forge";
        }
        public override string GetResourcepath()
        {
            return GetBasePath() + "steel_forge";
        }
        public override Branches GetBranch()
        {
            return Branches.Common;
        }

        public override List<IOwnable> GetCriteria()
        {
            return new List<IOwnable>();
        }

        protected override List<Resource> GetCost(int level)
        {
            return GetCostArray[level];
        }

        protected override int GetMaxLevel()
        {
            return 2;
        }
    }

}
