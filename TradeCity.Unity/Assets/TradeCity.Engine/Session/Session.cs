using AutSoft.UnitySupplements.EventBus;
using Injecter;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using TradeCity.Engine.Core;
using TradeCity.Engine.Missions;
using TradeCity.Engine.Resources;
using TradeCity.Engine.Session.Interfaces;
using TradeCity.Engine.Structures;
using TradeCity.Engine.Structures.Interfaces;
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

        public bool Debug { get; protected set; }
        public string Name;
        

        public IEnumerable<Mission> Missions { get; set; }

        private readonly List<Player> _players;
        private readonly ISessionTemplate _template;

        public Session(ISessionTemplate template, string name = DefaultName)
        {
            _eventBus = EngineCore.InjectEventBus();
            _clock = EngineCore.InjectClock();
            _template = template;
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

        public Player GetFirstPlayer()
        {
            return _players[0];
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

        public IEnumerable<Resource> GetResourceList()
        {
            return _template.AllResources();
        }

        public IEnumerable<Building> GetAllBuildings()
        {
            return _template.AllBuildings();
        }

        public IEnumerable<Land> GetAllLands()
        {
            return _template.AllLands();
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