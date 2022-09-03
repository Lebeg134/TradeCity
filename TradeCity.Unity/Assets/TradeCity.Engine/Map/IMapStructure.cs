/**
* @(#) IMapStructure.cs
*/
using Lebeg134.Module.Session;

namespace Lebeg134.Module.MapNS
{
    public interface IMapStructure
    {
        void GetPosition(); //TODO when graphics
        bool IsAuctionable();
        void Purchase(Player by);
    }
}
