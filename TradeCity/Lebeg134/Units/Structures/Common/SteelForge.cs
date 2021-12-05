

using JHP4SD.Lebeg134.Module.Resources;
using JHP4SD.Lebeg134.Module.Structures;
using Lebeg134.Resources.Common;
using System.Collections.Generic;
/**
* @(#) SteelForge.cs
*/
namespace Lebeg134.Structures.Common
{
	public class SteelForge: CommonProdBuilding
	{
		protected static readonly new List<Resource>[] upgradeLevelsCosts = new[]
		{
			new List<Resource>{new Wood(100)}
		};
		protected static readonly new List<Resource>[] upkeepLevels = new[]
		{
			new List<Resource>{new Iron(10)}
		};
		protected static readonly new List<Resource>[] productionLevels = new[]
		{
			new List<Resource>{new Steel(5)}
		};
	}
	
}
