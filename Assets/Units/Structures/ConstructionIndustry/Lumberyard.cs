using Lebeg134.Module.Resources;
using Lebeg134.Module.Structures;
using Lebeg134.Resources.Common;
using Lebeg134.Resources.ConstructionIndustry;
using Lebeg134.Resources.EnergySector;
using Lebeg134.Resources.Workforce;
using Lebeg134.Units;
using System;
using System.Collections.Generic;
/**
* @(#) Lumberyard.cs
*/
namespace Lebeg134.Structures.ConstructionIndustry
{
    [Serializable]
    public class Lumberyard : CommonProdBuilding
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

        public override List<Resource> GetUpkeep()
        {
            return new List<Resource> { new Wood(3 * level), new Electricity(2 * level) };
        }

        public override List<Resource> UpgradeLevelsCosts(int level)
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
