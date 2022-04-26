using Lebeg134.Module.Resources;
using Lebeg134.Module.Structures;
using Lebeg134.Units;
using Lebeg134.Resources.Common;
using Lebeg134.Resources.ConstructionIndustry;
using Lebeg134.Resources.EnergySector;
using Lebeg134.Resources.Workforce;
using System;
using System.Collections.Generic;
/**
* @(#) ConcreteMixingPlant.cs
*/
namespace Lebeg134.Structures.ConstructionIndustry
{
    [Serializable]
    public class ConcreteMixingPlant : CommonProdBuilding
    {
        public override List<IOwnable> Criteria()
        {
            return new List<IOwnable>();
        }

        public override Branches GetBranch()
        {
            return Branches.CONSTRUCTION;
        }

        public override int GetMaxLevel()
        {
            return 5;
        }

        public override string GetName()
        {
            return "Concrete Mixing Plant";
        }

        public override List<Resource> GetProduce()
        {
            return new List<Resource> { new Concrete(5*level) };
        }

        public override List<Resource> GetUpkeep()
        {
            return new List<Resource> { new Water(5 * level), new Sand(15 * level), new Electricity(10*level)};
        }

        public override List<Resource> UpgradeLevelsCosts(int level)
        {
            if (level == 0)
                return new List<Resource> { new Stone(100), new Workforce(25) };
            else
                return new List<Resource> { new Concrete(50 + 50 * level), new Workforce(10) };
        }
    }

}
