using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TradeCity.Engine.Missions;
using TradeCity.Engine.Resources;
using TradeCity.Engine.Session.Interfaces;
using TradeCity.Engine.Structures;
using TradeCity.Engine.Structures.Interfaces;
using TradeCity.Units.Resources.Common;
using TradeCity.Units.Resources.ConstructionIndustry;
using TradeCity.Units.Resources.EnergySector;
using TradeCity.Units.Resources.OilIndustry;
using TradeCity.Units.Resources.Workforce;

namespace TradeCity.Engine.Session.Templates
{
    public class CampaignTemplate : ISessionTemplate
    {
        public ICollection<Building> AllBuildings()
        {
            throw new NotImplementedException();
        }

        public ICollection<ILand> AllLands()
        {
            throw new NotImplementedException();
        }

        public ICollection<Mission> AllMissions()
        {
            throw new NotImplementedException();
        }

        public ICollection<Resource> AllResources()
        {
            Workforce workforce = new(0);
            workforce.IncLimit(10000);
            List<Resource> template = new()
            {
                new Money(0),
                new Iron(0), new Steel(0), new Water(0), new Wood(0),
                new Bricks(0), new Concrete(0), new Glass(0), new Insulation(0), new Lumber(0),
                new ReinforcedConcrete(0), new Sand(0), new Stone(0),
                new Electricity(0), new Coal(0),
                new Chemicals(0), new Fuel(0), new Ink(0), new Kerosine(0), new Oil(0), new Paint(0), new Plastic(0),
                workforce
            };
            return template;
        }

        public ICollection<Building> StartingBuildings()
        {
            throw new NotImplementedException();
        }

        public ICollection<ILand> StartingLands()
        {
            throw new NotImplementedException();
        }

        public ICollection<Mission> StartingMissions()
        {
            throw new NotImplementedException();
        }

        public ICollection<Resource> StartingResources()
        {
            throw new NotImplementedException();
        }
    }
}
