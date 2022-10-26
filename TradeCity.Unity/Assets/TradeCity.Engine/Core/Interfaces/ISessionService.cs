using System.Collections.Generic;
using TradeCity.Engine.Resources;

namespace TradeCity.Engine.Core.Interfaces
{
    public interface ISessionService
    {
        Session.Session CurrentSession { get; set; }

        IEnumerable<Resource> GetResourceList();
    }
}