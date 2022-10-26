
using TradeCity.Engine.Core.Interfaces;
using TradeCity.Engine.Session;

namespace TradeCity.Engine.Core
{
    public class StandardPlayerService: IPlayerService
    {
        public Player CurrentPlayer { get; set; }
    }
}
