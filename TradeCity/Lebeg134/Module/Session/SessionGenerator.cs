using Lebeg134.Resources.Common;
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
            player.giveRes(new Wood(0));
        }
    }
}
