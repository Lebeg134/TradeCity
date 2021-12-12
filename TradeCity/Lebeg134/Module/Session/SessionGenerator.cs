using JHP4SD.Lebeg134.Module.Resources;
using JHP4SD.Lebeg134.Module.Structures;
using JHP4SD.Lebeg134.Units.Resources.Common;
using Lebeg134.Resources.Common;
using Lebeg134.Resources.EnergySector;
using Lebeg134.Resources.Workforce;
using Lebeg134.Structures.Common;
using Lebeg134.Structures.EnergySector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JHP4SD.Lebeg134.Module.Session
{
    static class SessionGenerator
    {
        public static Session GenerateStandard()
        {
            Session newSession = new Session();
            Player thisPlayer = new Player();
            Player.CurrentPlayer = thisPlayer;
            FillPlayerWithStandard(thisPlayer);
            newSession.login(thisPlayer);


            return newSession;
        }
        static void FillPlayerWithStandard(Player player)
        {
            List<Resource> template = new List<Resource>
            {
                new Money(0), new Workforce(0), new Electricity(0), new Wood(0), new Iron(0), new Steel(0), new Water(0), new Coal(0)
            };
            player.registerResources(template);
            player.giveRes(new Money(1500));
            player.giveRes(new Workforce(500));
            player.giveRes(new Wood(500));
            player.giveRes(new Iron(100));
            player.giveRes(new Coal(1000));
        }

        internal static List<Building> GetAllBuildings()
        {
            return new List<Building> { new SteelForge(), new CoalPowerplant()};
        }
    }
}
