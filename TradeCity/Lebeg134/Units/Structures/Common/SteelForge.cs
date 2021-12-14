

using JHP4SD.Lebeg134.Module.Resources;
using JHP4SD.Lebeg134.Module.Structures;
using JHP4SD.Lebeg134.Units;
using Lebeg134.Resources.Common;
using Lebeg134.Resources.EnergySector;
using Lebeg134.Resources.Workforce;
using System.Collections.Generic;
/**
* @(#) SteelForge.cs
*/
namespace Lebeg134.Structures.Common
{
    public class SteelForge : CommonProdBuilding
    {
        protected static List<Resource>[] upgradeLevelsCostsArray
        {
            get
            {
                return new[]{
                    new List<Resource> { new Wood(100), new Workforce(50) }, //Build cost
                    new List<Resource> { new Steel(100), new Workforce(25) }
                };
            }
        }

        protected static List<Resource>[] upkeepLevelsArray
        {
            get
            {
                return new[]{
                    new List<Resource>{new Iron(10), new Electricity(1)},
                    new List<Resource>{new Iron(20), new Electricity(2)}
                };
            }
        }

        protected static List<Resource>[] productionLevels
        {
            get
            {
                return new[]{
                    new List<Resource> { new Steel(5) },
                    new List<Resource> { new Steel(10) }
                };
            }
        }
        public override string getName()
        {
            return "Steel Forge";
        }
        public override Branches getBranch()
        {
            return Branches.COMMON;
        }

        public override List<IOwnable> Criteria()
        {
            return new List<IOwnable>();
        }

        public override List<Resource> upgradeLevelsCosts(int level)
        {
            return upgradeLevelsCostsArray[level];
        }

        public override List<Resource> getUpkeep()
        {
            
            return upkeepLevelsArray[level - 1];
        }

        public override List<Resource> getProduce()
        {
            return productionLevels[level - 1];
        }

        public override int getMaxLevel()
        {
            return 2;
        }
    }

}
