

using Lebeg134.Module.Production;
using Lebeg134.Module.Resources;
using Lebeg134.Module.Structures;
using Lebeg134.Resources.Common;
using Lebeg134.Resources.ConstructionIndustry;
using Lebeg134.Resources.Workforce;
using Lebeg134.Units;
using System.Collections.Generic;
/**
* @(#) StoneCutter.cs
*/
namespace Lebeg134.Structures.ConstructionIndustry
{
    public class StoneCutter : Building
    {
        public StoneCutter()
        {
            Recipes.Add(new SimpleRecipe(new Stone(3), new Bricks(1), 10));
        }
        public override void Upgrade()
        {
            base.Upgrade();
            Recipes[0].Limit += level * 5+5;
        }
        public override Branches GetBranch()
        {
            return Branches.CONSTRUCTION;
        }

        public override string GetName()
        {
            return "Stone Cutter";
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
