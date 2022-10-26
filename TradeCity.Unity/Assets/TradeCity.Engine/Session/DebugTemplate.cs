using System;
using System.Collections.Generic;
using TradeCity.Engine.Missions;
using TradeCity.Engine.Resources;
using TradeCity.Engine.Session;
using TradeCity.Engine.Structures;
using TradeCity.Engine.Structures.Interfaces;

namespace TradeCity.Engine.Session
{
    internal class DebugTemplate : ISessionTemplate
    {
        public ICollection<Resource> AllResources()
        {
            throw new NotImplementedException();
        }

        public ICollection<ILand> AllLands()
        {
            throw new NotImplementedException();
        }

        public ICollection<Building> AllBuildings()
        {
            throw new NotImplementedException();
        }

        public ICollection<Mission> AllMissions()
        {
            throw new NotImplementedException();
        }

        public ICollection<Resource> StartingResources()
        {
            throw new NotImplementedException();
        }

        public ICollection<ILand> StartingLands()
        {
            throw new NotImplementedException();
        }

        public ICollection<Building> StartingBuildings()
        {
            throw new NotImplementedException();
        }

        public ICollection<Mission> StartingMissions()
        {
            throw new NotImplementedException();
        }
    }
}
