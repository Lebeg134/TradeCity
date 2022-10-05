using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using AutSoft.UnitySupplements.EventBus;
using Injecter;
using TradeCity.Engine.Core;
using TradeCity.Engine.Missions;
using TradeCity.Engine.Structures;
using TradeCity.Engine.TimeManager;
using static TradeCity.Engine.Session.Player;

namespace TradeCity.Engine.Session
{
    [Serializable]
    public class Session : ITickable
    {
        [Inject] private readonly IEventBus _eventBus;
        [Inject] private readonly IClock _clock;

        public static readonly string Filename = "save.dat";
        private static Session _instance;
        private readonly List<Player> _players;
        public List<Mission> Missions = new();
        public Dictionary<Land, int> Offers = new();
        public bool Running;

        public Session()
        {
            _eventBus = EngineCore.Instance.InjectEventBus();
            _clock = EngineCore.Instance.InjectClock();
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
            _clock.Register(this);
        }

        public void Start()
        {
            _instance = this;
            _clock.Start();
            Running = true;
            _eventBus.Invoke(new SessionStarted(this));
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

        public void Load()
        {
            Stream stream = File.OpenRead(Filename);
            BinaryFormatter b = new();
            _instance = (Session)b.Deserialize(stream);
            stream.Close();
            CurrentPlayer = Instance._players[0]; // TODO need to change when multiple players
            _clock.Clear();
            _clock.Register(Instance);
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

        public sealed class SessionStarted : IEvent
        {
            public SessionStarted(Session startedSession)
            {
                StartedSession = startedSession;
            }

            public Session StartedSession { get; }
        }
    }
}