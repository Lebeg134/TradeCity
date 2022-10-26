using TradeCity.Engine.TimeManager;

namespace TradeCity.Engine.Session.Interfaces
{
    public interface ISession : ITickable
    {
        public void Start();
        public void Login(Player player);
        public void Logout(Player player);
        public void DeletePlayer(Player player);
    }
}