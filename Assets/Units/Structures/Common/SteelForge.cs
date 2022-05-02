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
    public class SteelForge : CommonProdBuilding
    {
        protected static List<Resource>[] UpgradeLevelsCostsArray
        {
            get
            {
                return new[]{
                    new List<Resource> { new Wood(100), new Workforce(50) }, //Build cost
                    new List<Resource> { new Steel(100), new Workforce(25) }
                };
            }
        }

        protected static List<Resource>[] UpkeepLevelsArray
        {
            get
            {
                return new[]{
                    new List<Resource>{new Iron(10), new Electricity(1)},
                    new List<Resource>{new Iron(20), new Electricity(2)}
                };
            }
        }

        protected static List<Resource>[] ProductionLevels
        {
            get
            {
                return new[]{
                    new List<Resource> { new Steel(5) },
                    new List<Resource> { new Steel(10) }
                };
            }
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

        public override List<Resource> GetUpgradeCost(int level)
        {
            return UpgradeLevelsCostsArray[level];
        }

        public override List<Resource> GetUpkeep()
        {

            return UpkeepLevelsArray[level - 1];
        }

        public override List<Resource> GetProduce()
        {
            return ProductionLevels[level - 1];
        }

        public override int REPLACEMEGetMaxLevel()
        {
            return 2;
        }
    }

}
