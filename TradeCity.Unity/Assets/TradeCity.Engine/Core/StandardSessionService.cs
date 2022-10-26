using System.Collections.Generic;
using TradeCity.Engine.Core.Interfaces;
using TradeCity.Engine.Resources;

namespace TradeCity.Engine.Core
{
    public class StandardSessionService : ISessionService
    {
        public Session.Session CurrentSession { get; set; }

        public IEnumerable<Resource> GetResourceList()
        {
            return CurrentSession.GetResourceList();
        }
    }
}