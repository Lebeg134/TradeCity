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
using TradeCity.Units.Structures.Common;
using TradeCity.Units.Structures.ConstructionIndustry;
using TradeCity.Units.Structures.EnergySector;
using TradeCity.Units.Structures.Lands;
using TradeCity.Units.Structures.OilIndustry;

namespace TradeCity.Engine.Session.Templates
{
    public class CampaignTemplate : ISessionTemplate
    {
        public ICollection<Building> AllBuildings()
        {
            return new List<Building>
            {
                new SteelForge(),
                new ConcreteMixingPlant(), new CraftsmanHq(), new GlassKiln(), new Lumberyard(), new StoneCutter(),
                new CoalPowerplant(),
                new ChemicalResearchFacility(), new ChemicalSafetyBureau(), new OilDistillery()
            };
        }

        public ICollection<ILand> AllLands()
        {
            return new List<ILand>
            {
                new ClearwaterLake(),
                new Well(),
                new Forest(),
                new CoalMine(),
                new IronMine(),
                new SandQuarry(),
                new StoneQuarry(),
                new OilField(),
                new OilRig()
            };
        }

        public ICollection<Mission> AllMissions()
        {
            return new List<Mission>();
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
            return new List<Building>();
        }

        public ICollection<ILand> StartingLands()
        {
            return new List<ILand>();
        }

        public ICollection<Mission> StartingMissions()
        {
            return new List<Mission>
            {
                new(new ReachResourceGoal(new Money(100000)), new ResourceReward(new Workforce(1000))),
                new(new CollectResourceGoal(new Steel(1000)), new ResourceReward(new Money(10000))),
                new(new CollectResourceGoal(new Coal(100)), new ResourceReward(new Bricks(250)))
            };
        }

        public ICollection<Resource> StartingResources()
        {
            return new List<Resource>
            {
                new Money(50000),
                new Workforce(2000),
                new Wood(1000),
                new Iron(1000),
                new Stone(1000),
            };
        }
    }
}
