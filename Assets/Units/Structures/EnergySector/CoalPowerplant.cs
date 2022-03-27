using JHP4SD.Lebeg134.Module.Resources;
using JHP4SD.Lebeg134.Module.Structures;
using JHP4SD.Lebeg134.Units;
using Lebeg134.Resources.Common;
using Lebeg134.Resources.ConstructionIndustry;
using Lebeg134.Resources.EnergySector;
using Lebeg134.Resources.Workforce;
using System;
using System.Collections.Generic;
/**
* @(#) CoalPowerplant.cs
*/
namespace Lebeg134.Structures.EnergySector
{
	[Serializable]
	public class CoalPowerplant: CommonProdBuilding
	{
		//protected static new readonly List<Resource>[] upgradeLevelsCostsArray =
		//{
		//	new List<Resource>{new Wood(100), new Workforce(50)},
		//	new List<Resource>{new Wood(100), new Steel(100)}
		//};
		//protected static new readonly List<Resource>[] upkeepLevelsArray =
		//{
		//	new List<Resource>{new Coal(45)},
		//	new List<Resource>{new Coal(65)}
		//};
		//protected static readonly new List<Resource>[] productionLevelsArray =
		//{
		//	new List<Resource>{new Electricity(5)},
		//	new List<Resource>{new Electricity(10)}
		//};
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
			return new List<Resource> { new Electricity(5*level) };
        }

        public override List<Resource> getUpkeep()
        {
			return new List<Resource> { new Coal(15 * level) };
        }

        public override List<IOwnable> Criteria()
        {
			return new List<IOwnable>();
        }

        public override List<Resource> upgradeLevelsCosts(int level)
        {
			if (level == 0)
				return new List<Resource> { new Stone(100), new Workforce(50) };
			else if (level < 25)
				return new List<Resource> { new Bricks(50 * level), new Steel(25 * level) };
			else if (level < 75)
				return new List<Resource> { new Concrete(50 * level), new Steel(25 * level) };
			else
				return new List<Resource> { new ReinforcedConcrete(50 * level), new Steel(25 * level) };
        }

        public override int getMaxLevel()
        {
			return 100;
        }
    }
}
