/**
 * @(#) Session.cs
 */
using Lebeg134.Module.Missions;
using Lebeg134.Module.Structures;
using Lebeg134.Module.TimeManager;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using static Lebeg134.Module.Session.Player;

namespace Lebeg134.Module.Session
{
    [Serializable]
    public class Session : ITickable
    {
        public static readonly string Filename = "save.dat";
        List<Player> players;
        public Dictionary<Land, int> offers = new Dictionary<Land, int>();
        public List<Mission> missions = new List<Mission>();
        public bool Running = false;
        public static Session Instance
        {
            get
            {
                if (instance != null)
                    return instance;
                else
                    throw new System.Exception("No started Sessions");
            }
        }
        private static Session instance;

        public Session()
        {
            Register();
            players = new List<Player>();
        }
        public void Start()
        {
            instance = this;
            Clock.Instance.Start();
            Running = true;
        }

        public static void Save()
        {
            Stream stream = File.OpenWrite(Filename);
            BinaryFormatter b = new BinaryFormatter();
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
            BinaryFormatter b = new BinaryFormatter();
            instance = (Session)b.Deserialize(stream);
            stream.Close();
            CurrentPlayer = Instance.players[0]; // TODO need to change when multiple players
            Clock.Instance.Clear();
            Clock.Instance.Register(Instance);
        }
        public void Login(Player player)
        {
            if (!players.Contains(player))
                players.Add(player);
            else
                player.UnFreeze(new StandardPlayerStrategy(player));
        }
        public void Logout(Player player)
        {
            if (players.Contains(player))
                player.Freeze();
        }
        public void DeletePlayer(Player player)
        {
            player.GoBankrupt();
            players.Remove(player);
            // TODO Remove ownerships?
        }
        public void Tick()
        {
            //TODO tick market and generate event stuff in the future

            //TODO add land offers randomly

            foreach (Player player in players)
            {
                player.Tick();
            }
        }
        public void Register()
        {
            Clock.Instance.Register(this);
        }
    }

}
