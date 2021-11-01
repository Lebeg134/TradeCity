/**
* @(#) Map.cs
*/
using Lebeg134.Module.Session;
using Lebeg134.Module.Structures;
using System.Collections.Generic;

namespace Lebeg134.Module.Map
{
    public class Map
    {
        IMapStructure[,] _structures;
        readonly int _sizeX, _sizeY;
        List<Auction> _liveAuctions = new List<Auction>();

        public Map(int sizeX, int sizeY)
        {
            _sizeX = sizeX;
            _sizeY = sizeY;
            _structures = new IMapStructure[_sizeX, _sizeY];
        }
        public IMapStructure GetStructure(int x, int y) 
        {
            return _structures[x, y];
        }
        public void SetStructure(int x, int y, IMapStructure structure, bool replace = false)
        {
            if(replace || _structures[x,y] == null)
                _structures[x, y] = structure;
        }
        public void startAuction(Land land, Player by)
        {

        }
    }
}
