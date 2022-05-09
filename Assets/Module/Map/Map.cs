/**
* @(#) Map.cs
*/
using Lebeg134.Module.Session;
using Lebeg134.Module.Structures;
using Lebeg134.Module.TimeManager;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Lebeg134.Module.MapNS
{
    [Serializable]
    public class Map : ITickable
    {
        readonly int defaultBid = 100;
        readonly int defaultTimePerRound = 100;

        IMapStructure[,] structures;
        readonly int sizeX, sizeY;
        List<Auction> liveAuctions = new List<Auction>();

        public Map(int sizeX, int sizeY)
        {
            this.sizeX = sizeX;
            this.sizeY = sizeY;
            structures = new IMapStructure[this.sizeX, this.sizeY];
            Register();
        }
        public IMapStructure GetStructure(int x, int y)
        {
            return structures[x, y];
        }
        //public void SetStructure(int x, int y, IMapStructure structure, bool replace = false)
        //{
        //    if (replace || structures[x, y] == null)
        //    {
        //        structure.SetCoords(x, y);
        //        structures[x, y] = structure;
        //    }
        //}
        public void StartAuction(int x, int y, Player by)
        {
            IMapStructure subject = structures[x, y];
            if (!subject.IsAuctionable())
                throw new NotAuctionableException();
            else
            {
                Auction newAuction = new Auction((Land)subject, defaultBid, defaultTimePerRound, by);
                if (liveAuctions.Contains(newAuction))
                {
                    throw new AuctionAlreadyExistsException();
                }
                else
                {
                    liveAuctions.Add(newAuction);
                }
            }
        }
        public void Tick()
        {
            foreach (Auction auction in liveAuctions)
            {
                try
                {
                    auction.Tick();
                }
                catch (AuctionFinishedException)
                {
                    liveAuctions.Remove(auction);
                }
            }
        }
        public void Register()
        {
            Clock.Instance.Register(this);
        }
    }
    [Serializable]
    internal class AuctionAlreadyExistsException : Exception
    {
        public AuctionAlreadyExistsException()
        {
        }

        public AuctionAlreadyExistsException(string message) : base(message)
        {
        }

        public AuctionAlreadyExistsException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected AuctionAlreadyExistsException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
    [Serializable]
    internal class NotAuctionableException : Exception
    {
        public NotAuctionableException()
        {
        }

        public NotAuctionableException(string message) : base(message)
        {
        }

        public NotAuctionableException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected NotAuctionableException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
