using System.Collections.Generic;
using TradeCity.Engine.Missions;
using TradeCity.Engine.Resources;
using TradeCity.Engine.Structures;
using TradeCity.Engine.Structures.Interfaces;
using TradeCity.Engine.TimeManager;

namespace TradeCity.Engine.Session.Interfaces
{
    public interface ISession : ITickable
    {
        public void Start();
        public void Login(Player player);
        public void Logout(Player player);
        public void DeletePlayer(Player player);
        public Player GetFirstPlayer();
        IEnumerable<Resource> GetResourceList();
        IEnumerable<Building> GetAllBuildings();
        IEnumerable<Land> GetAllLands();
        IEnumerable<Mission> Missions { get; set; }
        void Save();
    }
}