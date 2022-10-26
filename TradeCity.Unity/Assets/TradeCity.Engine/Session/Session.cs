using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using AutSoft.UnitySupplements.EventBus;
using Injecter;
using TradeCity.Engine.Core;
using TradeCity.Engine.Missions;
using TradeCity.Engine.Session.Interfaces;
using TradeCity.Engine.TimeManager;
using static TradeCity.Engine.Session.Player;

namespace TradeCity.Engine.Session
{
    [Serializable]
    public class Session : ISession
    {
        private const string SavePath = "/saves/";
        private const string DefaultName = "NewSave";

        [NonSerialized]
        [Inject] private readonly IEventBus _eventBus;
        [NonSerialized]
        [Inject] private readonly IClock _clock;

        public string Name;
        public List<Mission> Missions = new();
        
        private readonly List<Player> _players;
        public bool Debug { get; protected set; }

        public Session(string name = DefaultName)
        {
            _eventBus = EngineCore.InjectEventBus();
            _clock = EngineCore.InjectClock();
            _players = new List<Player>();
            Name = name;
            Register();
        }

        public void Tick()
        {
            foreach (var player in _players) player.Tick();
        }

        public void Register()
        {
            _clock.Register(this);
        }

        public void Start()
        {
            _clock.Start();
            _eventBus.Invoke(new SessionStarted(this));
        }

        public void Save()
        {
            Stream stream = File.OpenWrite(GetPath(Name));
            BinaryFormatter b = new();
            b.Serialize(stream, this);
            stream.Close();
        }

        public bool SaveExists()
        {
            return File.Exists(GetPath(Name));
        }

        public static Session Load(string path)
        {
            Stream stream = File.OpenRead(path);
            BinaryFormatter b = new();
           var session = (Session)b.Deserialize(stream);
            stream.Close();
            CurrentPlayer = session._players[0]; // TODO need to change when multiple players
            session._clock.Clear();
            session._clock.Register(session);
            return session;
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

        private string GetPath(string name)
        {
            return SavePath + name;
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