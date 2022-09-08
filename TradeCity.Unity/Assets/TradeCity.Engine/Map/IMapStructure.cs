using TradeCity.Engine.Session;

namespace TradeCity.Engine.Map
{
    public interface IMapStructure
    {
        void GetPosition(); //TODO when graphics
        bool IsAuctionable();
        void Purchase(Player by);
    }
}