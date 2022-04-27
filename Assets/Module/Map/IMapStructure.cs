/**
* @(#) IMapStructure.cs
*/
using System.Collections.Generic;

namespace Lebeg134.Module.MapNS
{
    public interface IMapStructure : IEqualityComparer<IMapStructure>
    {
        void SetCoords(int x, int y);
        bool IsAuctionable();
        //TODO when graphics
    }
}
