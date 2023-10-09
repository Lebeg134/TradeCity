using Injecter;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using TradeCity.Engine.Core.Interfaces;
using TradeCity.Engine.Resources;
using TradeCity.Engine.Session.Interfaces;
using TradeCity.Engine.Structures;
using TradeCity.Engine.TimeManager;

namespace TradeCity.Engine.Core
{
    public class StandardSessionService : ISessionService
    {
        private const string SavePath = "/saves/";

        [Inject] private readonly IPlayerService _playerService;
        [Inject] private readonly IClock _clock;
        public ISession CurrentSession { get; private set; }

        public StandardSessionService(IPlayerService playerService, IClock clock)
        {
            _playerService = playerService;
            _clock = clock;
        }

        public void SwitchToSession(ISession session)
        {
            _playerService.CurrentPlayer = session.GetFirstPlayer();
            CurrentSession = session;
        }

        public IEnumerable<Resource> GetResourceList()
        {
            return CurrentSession == null ? new List<Resource>() : CurrentSession.GetResourceList();
        }

        public IEnumerable<Building> GetAllBuildings()
        {
            return CurrentSession == null ? new List<Building>() : CurrentSession.GetAllBuildings();
        }

        public void Load(string name)
        {
            Stream stream = File.OpenRead(SavePath + name);
            BinaryFormatter b = new();
            var session = (Session.Session)b.Deserialize(stream);
            stream.Close();
            _clock.Clear();
            _clock.Register(session);
            _playerService.CurrentPlayer = session.GetFirstPlayer();
            CurrentSession = session;
        }

        public bool SaveExists()
        {
            return false;
            //TODO
            /*var di = new DirectoryInfo(SavePath);
            var saves = di.GetFiles("*.sav");
            return saves.Length > 0;*/
        }
    }
}