using System.Collections.Generic;
using TradeCity.Engine.Missions;
using TradeCity.Engine.Resources;
using TradeCity.Engine.Structures;
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

namespace TradeCity.Engine.Session
{
    static public class SessionGenerator
    {
        private static List<Building> _allBuildings;
        public static Session GenerateStandard()
        {
            Session newSession = new();
            Player thisPlayer = new();
            Player.CurrentPlayer = thisPlayer;
            FillPlayerWithStandard(thisPlayer);
            newSession.Login(thisPlayer);
            GenerateStartingOffers(newSession);
            newSession.Missions.AddRange(GenerateMissions());
            foreach (var m in newSession.Missions)
            {
                m.Accept(Player.CurrentPlayer);
            }

            return newSession;
        }

        private static void FillPlayerWithStandard(Player player)
        {
            player.RegisterResources(GetResourceList());
            player.GiveRes(new Money(50000));
            player.GiveRes(new Workforce(2000));
            player.GiveRes(new Wood(1000));
            player.GiveRes(new Iron(1000));
            player.GiveRes(new Stone(1000));
        }
        public static List<Resource> GetResourceList()
        {
            Workforce workforce = new(0);
            workforce.IncLimit(10000);
            List<Resource> template = new()
            {
                new Money(0),
                new Iron(0), new Steel(0), new Water(0), new Wood(0),
                new Bricks(0), new Concrete(0), new Glass(0), new Insulation(0), new Lumber(0), new ReinforcedConcrete(0), new Sand(0), new Stone(0),
                new Electricity(0), new Coal(0),
                new Chemicals(0), new Fuel(0), new Ink(0), new Kerosine(0), new Oil(0), new Paint(0), new Plastic(0),
                workforce
            };

            return template;
        }

        private static void GenerateStartingOffers(Session session)
        {
            session.Offers.Add(new ClearwaterLake(), 1000);
            session.Offers.Add(new Well(), 2000);
            session.Offers.Add(new Forest(), 5000);
            session.Offers.Add(new CoalMine(), 5000);
            session.Offers.Add(new IronMine(), 10000);
            session.Offers.Add(new SandQuarry(), 10000);
            session.Offers.Add(new StoneQuarry(), 10000);
            session.Offers.Add(new OilField(), 40000);
            session.Offers.Add(new OilRig(), 80000);
        }
        public static List<Land> GetAllLands()
        {
            return new List<Land>{
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
        public static List<Mission> GenerateMissions()
        {
            return new List<Mission>
            {
                new Mission(new ReachResourceGoal(new Money(100000)), new ResourceReward(new Workforce(1000))),
                new Mission(new CollectResourceGoal(new Steel(1000)), new ResourceReward(new Money(10000))),
                new Mission(new CollectResourceGoal(new Coal(100)), new ResourceReward(new Bricks(250)))

            };
        }
        public static List<Building> GetAllBuildings()
        {
            if (_allBuildings == null)
            {
                _allBuildings = new List<Building> {
                    new SteelForge(),
                    new ConcreteMixingPlant(), new CraftsmanHq(), new GlassKiln(),new Lumberyard(),new StoneCutter(),
                    new CoalPowerplant(),
                    new ChemicalResearchFacility(), new ChemicalSafetyBureau(), new OilDistillery()
                };
            }
            return _allBuildings;
        }
    }
}
