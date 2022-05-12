using Lebeg134.Module.Production;
using Lebeg134.Module.Resources;
using Lebeg134.Module.Structures;
using Lebeg134.Resources.ConstructionIndustry;
using Lebeg134.Resources.EnergySector;
using Lebeg134.Resources.Workforce;
using Lebeg134.Units;
using System;
using System.Collections.Generic;
/**
* @(#) GlassKiln.cs
*/
namespace Lebeg134.Structures.ConstructionIndustry
{
    [Serializable]
    public class GlassKiln : Building
    {
        public GlassKiln()
        {
            Recipes.Add(new ManyToOneRecipe(new List<Resource> { new Electricity(1), new Sand(1) }, new Glass(1), 10));
        }
        public override List<IOwnable> GetCriteria()
        {
            return new List<IOwnable> { new CraftsmanHQ() };
        }

        public override Branches GetBranch()
        {
            return Branches.CONSTRUCTION;
        }

        protected override int GetMaxLevel()
        {
            return 10;
        }

        public override string GetName()
        {
            return "Glass Kiln";
        }

        public override List<Resource> GetProduce()
        {
            return new List<Resource> { new Glass(5 * level) };
        }

        protected override List<Resource> GetUpkeep(int level)
        {
            return new List<Resource> { new Sand(25 * level), new Electricity(25 * level) };
        }

        protected override List<Resource> GetCost(int level)
        {
            if (level == 0)
                return new List<Resource> { new Bricks(150), new Workforce(25) };
            else
                return new List<Resource> { new Bricks(100 * level), new Concrete(50 * level) };
        }
    }

}
