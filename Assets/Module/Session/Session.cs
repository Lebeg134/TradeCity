/**
 * @(#) Session.cs
 */
using JHP4SD.Lebeg134.Module.TimeManager;
using JHP4SD.Lebeg134.Module.MapNS;
using JHP4SD.Lebeg134.Module.MarketNS;
using System.Collections.Generic;
using static JHP4SD.Lebeg134.Module.Session.Player;
using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using JHP4SD.Lebeg134.Module.Structures;

namespace JHP4SD.Lebeg134.Module.Session
{
    [Serializable]
    public class Session : ITickable
    {
        public static readonly string Filename = "save.dat";
        //Market _market;
        List<Player> _players;
        //Map _map; not implemented
        public Dictionary<Land, int> offers = new Dictionary<Land, int>();
        public bool Running = false;
        public static Session Instance
        {
            get
            {
                if (_instance != null)
                    return _instance;
                else
                    throw new System.Exception("No started Sessions");
            }
        }
        private static Session _instance;

        public Session()
        {
            register();
            _players = new List<Player>();
        }
        public void start()
        {
            _instance = this;
            Clock.Instance.start();
            Running = true;
        }
        ///// <summary>
        ///// Loads saved instance
        ///// </summary>
        //public Session load()
        //{
        //    return null;
        //}
        //public void save(string path)
        //{
        //    //Memento?	
        //}

        public static void save()
        {
            Stream stream = File.OpenWrite(Filename);
            BinaryFormatter b = new BinaryFormatter();
            b.Serialize(stream, Instance);
            stream.Close();
        }
        public static void load()
        {
            Stream stream = File.OpenRead(Filename);
            BinaryFormatter b = new BinaryFormatter();
            _instance = (Session)b.Deserialize(stream);
            stream.Close();
            CurrentPlayer = Instance._players[0]; // TODO need to change when multiple players
            Clock.Instance.Clear();
            Clock.Instance.Register(Instance);
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
            // TODO Remove ownerships?
        }
        public void tick()
        {
            //TODO tick market and generate event stuff in the future

            //TODO add land offers randomly

            foreach (Player player in _players)
            {
                player.tick();
            }
        }
        public void register()
        {
            Clock.Instance.Register(this);
        }
    }

}