/**
* @(#) IMapStructure.cs
*/
using System.Collections.Generic;

namespace Lebeg134.Module.Map
{
	public interface IMapStructure : IEqualityComparer<IMapStructure>
	{
		void SetCoords(int x, int y);
		//TODO when graphics
	}
}
