using JHP4SD.Lebeg134.Module.Resources;
using JHP4SD.Lebeg134.Module.Structures;
using JHP4SD.Lebeg134.Units.Resources.Common;
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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JHP4SD.Lebeg134.Module.Session
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
            newSession.login(thisPlayer);
            GenerateStartingOffers(newSession);

            return newSession;
        }
        static void FillPlayerWithStandard(Player player)
        {
            player.registerResources(GetResourceList());
            player.giveRes(new Money(50000));
            player.giveRes(new Workforce(2000));
        }
        public static List<Resource> GetResourceList()
        {
            List<Resource> template = new List<Resource>
            {
                new Money(0),
                new Iron(0), new Steel(0), new Water(0), new Wood(0),
                new Bricks(0), new Concrete(0), new Glass(0), new Insulation(0), new Lumber(0), new ReinforcedConcrete(0), new Sand(0), new Stone(0),
                new Electricity(0), new Coal(0),
                new Chemicals(0), new Fuel(0), new Ink(0), new Kerosine(0), new Oil(0), new Paint(0), new Plastic(0),
                new Workforce(0)

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
        internal static List<Building> GetAllBuildings()
        {
            if (allBuildings == null)
            {
                allBuildings = new List<Building> {
                    new SteelForge(),
                    new ConcreteMixingPlant(), new CraftsmanHQ(), new GlassKiln(),new Lumberyard(),
                    new CoalPowerplant(),
                    new ChemicalResearchFacility(), new ChemicalSafetyBureau(), new OilDistillery()
                };
            }
            return allBuildings;
        }
    }
}
