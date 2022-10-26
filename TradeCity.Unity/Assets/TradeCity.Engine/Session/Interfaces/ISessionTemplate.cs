using System.Collections.Generic;
using TradeCity.Engine.Missions;
using TradeCity.Engine.Resources;
using TradeCity.Engine.Structures;
using TradeCity.Engine.Structures.Interfaces;

namespace TradeCity.Engine.Session.Interfaces
{
    public interface ISessionTemplate
    {
        public ICollection<Resource> AllResources();
        public ICollection<ILand> AllLands();
        public ICollection<Building> AllBuildings();
        public ICollection<Mission> AllMissions();
        public ICollection<Resource> StartingResources();
        public ICollection<ILand> StartingLands();
        public ICollection<Building> StartingBuildings();
        public ICollection<Mission> StartingMissions();



    }
}