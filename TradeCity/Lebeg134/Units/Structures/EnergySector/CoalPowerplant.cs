

using JHP4SD.Lebeg134.Module.Resources;
using JHP4SD.Lebeg134.Module.Structures;
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
		protected static new readonly List<Resource>[] upgradeLevelsCosts=
		{
			new List<Resource>{new Wood(100), new Workforce(50)},
			new List<Resource>{new Wood(100), new Steel(100)}
		};
		protected static new readonly List<Resource>[] upkeepLevels =
		{
			new List<Resource>{new Coal(50)},
			new List<Resource>{new Coal(75)}
		};
		protected static readonly new List<Resource>[] productionLevels =
		{
			new List<Resource>{new Electricity(5)},
			new List<Resource>{new Electricity(10)}
		};
	}
	
}
