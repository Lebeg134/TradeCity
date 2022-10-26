
using System.Collections.Generic;
using TradeCity.Engine.Missions;
using TradeCity.Engine.Resources;
using TradeCity.Engine.Session;
using TradeCity.Engine.Structures;
using TradeCity.Engine.Structures.Interfaces;

namespace TradeCity.Units.Campaign
{
    internal class CampaignTemplate: ISessionTemplate
    {
        public ICollection<Resource> AllResources()
        {
            throw new System.NotImplementedException();
        }

        public ICollection<ILand> AllLands()
        {
            throw new System.NotImplementedException();
        }

        public ICollection<Building> AllBuildings()
        {
            throw new System.NotImplementedException();
        }

        public ICollection<Mission> AllMissions()
        {
            throw new System.NotImplementedException();
        }

        public ICollection<Resource> StartingResources()
        {
            throw new System.NotImplementedException();
        }

        public ICollection<ILand> StartingLands()
        {
            throw new System.NotImplementedException();
        }

        public ICollection<Building> StartingBuildings()
        {
            throw new System.NotImplementedException();
        }

        public ICollection<Mission> StartingMissions()
        {
            throw new System.NotImplementedException();
        }
    }
}
