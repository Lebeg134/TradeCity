

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
        protected static List<Resource>[] upgradeLevelsCosts
        {
            get
            {
                return new[]{
                    new List<Resource> { new Wood(100), new Workforce(50) },
                    new List<Resource> { new Wood(100), new Steel(100) }
                };
            }
        }

        protected static List<Resource>[] upkeepLevels
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
        public override Branches getBranch()
        {
            return Branches.COMMON;
        }

    }

}
