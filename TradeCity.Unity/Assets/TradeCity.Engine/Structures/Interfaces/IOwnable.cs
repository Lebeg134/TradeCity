using TradeCity.Engine.Session;

namespace TradeCity.Engine.Structures.Interfaces
{
    public interface IOwnable
    {
        Player Owner { get; }
        void Acquire(Player by);
    }
}