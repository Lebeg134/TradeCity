using Lebeg134.Module.Missions;
using Lebeg134.Module.Resources;
using Lebeg134.Module.Structures;
using Lebeg134.Resources.Common;
using Lebeg134.Resources.ConstructionIndustry;
using Lebeg134.Resources.EnergySector;
using Lebeg134.Resources.OilIndustry;
using Lebeg134.Resources.Workforce;
using Lebeg134.Structures.Common;
using Lebeg134.Structures.ConstructionIndustry;
using Lebeg134.Structures.EnergySector;
using Lebeg134.Structures.Lands;
using Lebeg134.Structures.OilIndustry;
using System.Collections.Generic;

namespace Lebeg134.Module.Session
{
    static class SessionGenerator
    {
        static List<Building> allBuildings;
        public static Session GenerateStandard()
        {
            Session newSession = new Session();
            Player thisPlayer = new Player();
            Player.CurrentPlayer = thisPlayer;
            FillPlayerWithStandard(thisPlayer);
            newSession.Login(thisPlayer);
            GenerateStartingOffers(newSession);
            newSession.missions.AddRange(GenerateMissions());
            foreach (Mission m in newSession.missions)
            {
                m.Accept(Player.CurrentPlayer);
            }

            return newSession;
        }
        static void FillPlayerWithStandard(Player player)
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
            Workforce workforce = new Workforce(0);
            workforce.IncLimit(10000);
            List<Resource> template = new List<Resource>
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
        static void GenerateStartingOffers(Session session)
        {
            session.offers.Add(new ClearwaterLake(), 1000);
            session.offers.Add(new Well(), 2000);
            session.offers.Add(new Forest(), 5000);
            session.offers.Add(new CoalMine(), 5000);
            session.offers.Add(new IronMine(), 10000);
            session.offers.Add(new SandQuarry(), 10000);
            session.offers.Add(new StoneQuarry(), 10000);
            session.offers.Add(new OilField(), 40000);
            session.offers.Add(new OilRig(), 80000);
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
        internal static List<Building> GetAllBuildings()
        {
            if (allBuildings == null)
            {
                allBuildings = new List<Building> {
                    new SteelForge(),
                    new ConcreteMixingPlant(), new CraftsmanHQ(), new GlassKiln(),new Lumberyard(),new StoneCutter(),
                    new CoalPowerplant(),
                    new ChemicalResearchFacility(), new ChemicalSafetyBureau(), new OilDistillery()
                };
            }
            return allBuildings;
        }
    }
}
