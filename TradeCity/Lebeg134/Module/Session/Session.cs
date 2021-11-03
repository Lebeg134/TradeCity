/**
 * @(#) Session.cs
 */
using JHP4SD.Lebeg134.Module.TimeManager;
using JHP4SD.Lebeg134.Module.MapNS;
using JHP4SD.Lebeg134.Module.MarketNS;
using System.Collections.Generic;
using static JHP4SD.Lebeg134.Module.Session.Player;

namespace JHP4SD.Lebeg134.Module.Session
{

    public class Session : ITickable
    {
        Market _market;
        List<Player> _players;
        Map _map;

        public Session()
        {
            register();
            _players = new List<Player>();
        }
        public void load(string path)
        {
            //Menemto?
        }
        public void save(string path)
        {
            //Memento?	
        }
        public void login(Player player)
        {
            if (!_players.Contains(player))
                _players.Add(player);
            else
                player.unFreeze(new StandardPlayerStrategy(player));
        }
        public void logout(Player player)
        {
            if (_players.Contains(player))
                player.freeze();
        }
        public void deletePlayer(Player player)
        {
            player.goBankrupt();
            _players.Remove(player);
            //Remove ownerships
        }
        public void tick()
        {
            //TODO
            throw new System.NotImplementedException();
        }
        public void register()
        {
            Clock.Instance.Register(this);
        }
    }

}
