

using JHP4SD.Lebeg134.Module.Resources;
using JHP4SD.Lebeg134.Module.Structures;
using JHP4SD.Lebeg134.Units;
using Lebeg134.Resources.Common;
using Lebeg134.Resources.EnergySector;
using Lebeg134.Resources.Workforce;
using System.Collections.Generic;
/**
* @(#) CoalPowerplant.cs
*/
namespace Lebeg134.Structures.EnergySector
{
	public class CoalPowerplant: CommonProdBuilding
	{
		protected static new readonly List<Resource>[] upgradeLevelsCostsArray =
		{
			new List<Resource>{new Wood(100), new Workforce(50)},
			new List<Resource>{new Wood(100), new Steel(100)}
		};
		protected static new readonly List<Resource>[] upkeepLevelsArray =
		{
			new List<Resource>{new Coal(50)},
			new List<Resource>{new Coal(75)}
		};
		protected static readonly new List<Resource>[] productionLevelsArray =
		{
			new List<Resource>{new Electricity(5)},
			new List<Resource>{new Electricity(10)}
		};
		public override Branches getBranch()
		{
			return Branches.ENERGY;
		}

        public override string getName()
        {
			return "Coal Powerplant";
        }

        public override List<Resource> getProduce()
        {
			return productionLevelsArray[level - 1];
        }

        public override List<Resource> getUpkeep()
        {
			return upkeepLevelsArray[level - 1];
        }

        public override List<IOwnable> Criteria()
        {
			return new List<IOwnable>();
        }

        public override List<Resource> upgradeLevelsCosts(int level)
        {
			return upgradeLevelsCostsArray[level];
        }

        public override int getMaxLevel()
        {
			return 2;
        }
    }
}
