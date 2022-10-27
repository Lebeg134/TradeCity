using System.Collections.Generic;
using TradeCity.Engine.Resources;
using TradeCity.Engine.Session.Interfaces;
using TradeCity.Engine.Structures;

namespace TradeCity.Engine.Core.Interfaces
{
    public interface ISessionService
    {
        Session.Session CurrentSession { get; set; }
        IEnumerable<Resource> GetResourceList();
        IEnumerable<Building> GetAllBuildings();
        void Load(string name);
        bool SaveExists();
    }
}