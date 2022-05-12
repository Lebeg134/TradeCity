using Lebeg134.Module.Production;
using Lebeg134.Module.Resources;
using Lebeg134.Module.Structures;
using Lebeg134.Resources.Common;
using Lebeg134.Resources.EnergySector;
using Lebeg134.Resources.Workforce;
using Lebeg134.Units;
using System;
using System.Collections.Generic;
/**
* @(#) SteelForge.cs
*/
namespace Lebeg134.Structures.Common
{
    [Serializable]
    public class SteelForge : Building
    {
        protected static List<Resource>[] GetCostArray
        {
            get
            {
                return new[]{
                    new List<Resource> { new Wood(100), new Workforce(50) }, //Build cost
                    new List<Resource> { new Steel(100), new Workforce(25) }
                };
            }
        }
        public SteelForge()
        {
            recipes.Add(new ManyToOneRecipe(new List<Resource> { new Electricity(1), new Iron(2) }, new Steel(1), 5));
        }
        public override void Upgrade()
        {
            base.Upgrade();
            recipes[0].Limit += 5;
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
            return Branches.COMMON;
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
