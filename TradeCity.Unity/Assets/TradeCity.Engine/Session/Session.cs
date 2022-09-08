using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using TradeCity.Engine.Missions;
using TradeCity.Engine.Structures;
using TradeCity.Engine.TimeManager;
using static TradeCity.Engine.Session.Player;

namespace TradeCity.Engine.Session
{
    [Serializable]
    public class Session : ITickable
    {
        public static readonly string Filename = "save.dat";
        private static Session _instance;
        private readonly List<Player> _players;
        public List<Mission> Missions = new();
        public Dictionary<Land, int> Offers = new();
        public bool Running;

        public Session()
        {
            Register();
            _players = new List<Player>();
        }

        public static Session Instance
        {
            get
            {
                if (_instance != null)
                    return _instance;
                throw new Exception("No started Sessions");
            }
        }

        public void Tick()
        {
            //TODO tick market and generate event stuff in the future

            //TODO add land offers randomly

            foreach (var player in _players) player.Tick();
        }

        public void Register()
        {
            Clock.Instance.Register(this);
        }

        public void Start()
        {
            _instance = this;
            Clock.Instance.Start();
            Running = true;
        }

        public static void Save()
        {
            Stream stream = File.OpenWrite(Filename);
            BinaryFormatter b = new();
            b.Serialize(stream, Instance);
            stream.Close();
        }

        public static bool SaveExists()
        {
            return File.Exists(Filename);
        }

        public static void Load()
        {
            Stream stream = File.OpenRead(Filename);
            BinaryFormatter b = new();
            _instance = (Session)b.Deserialize(stream);
            stream.Close();
            CurrentPlayer = Instance._players[0]; // TODO need to change when multiple players
            Clock.Instance.Clear();
            Clock.Instance.Register(Instance);
        }

        public void Login(Player player)
        {
            if (!_players.Contains(player))
                _players.Add(player);
            else
                player.UnFreeze(new StandardPlayerStrategy(player));
        }

        public void Logout(Player player)
        {
            if (_players.Contains(player))
                player.Freeze();
        }

        public void DeletePlayer(Player player)
        {
            player.GoBankrupt();
            _players.Remove(player);
            // TODO Remove ownerships?
        }
    }
}