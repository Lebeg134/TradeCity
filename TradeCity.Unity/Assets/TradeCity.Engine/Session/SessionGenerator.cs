using TradeCity.Engine.Session.Interfaces;

namespace TradeCity.Engine.Session
{
    public static class SessionGenerator
    {
        public static Session Generate(ISessionTemplate template)
        {
            var session = new Session(template);
            var player = new Player();
            session.Login(player);

            player.RegisterResources(template.AllResources());

            foreach(var resource in template.StartingResources())
            {
                player.GiveRes(resource);
            }
            foreach(var land in template.StartingLands())
            {
                player.GiveStructure(land);
            }
            foreach(var structure in template.StartingBuildings())
            {
                player.GiveStructure(structure);
            }
            foreach(var mission in template.StartingMissions())
            {
                mission.Accept(player);
            }
            
            return session;
        }
    }
}