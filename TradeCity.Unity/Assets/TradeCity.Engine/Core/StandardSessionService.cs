using TradeCity.Engine.Core.Interfaces;

namespace TradeCity.Engine.Core
{
    public class StandardSessionService : ISessionService
    {
        public Session.Session CurrentSession { get; }
    }
}