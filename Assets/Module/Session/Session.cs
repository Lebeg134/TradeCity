/**
 * @(#) Session.cs
 */
using Lebeg134.Module.TimeManager;
using Lebeg134.Module.MapNS;
using Lebeg134.Module.MarketNS;
using System.Collections.Generic;
using static Lebeg134.Module.Session.Player;
using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using Lebeg134.Module.Structures;

namespace Lebeg134.Module.Session
{
    [Serializable]
    public class Session : ITickable
    {
        public static readonly string Filename = "save.dat";
        //Market _market;
        List<Player> players;
        //Map _map; not implemented
        public Dictionary<Land, int> offers = new Dictionary<Land, int>();
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
