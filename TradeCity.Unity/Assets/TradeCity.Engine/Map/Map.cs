/**
* @(#) Map.cs
*/

using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using TradeCity.Engine.Session;
using TradeCity.Engine.Structures;
using TradeCity.Engine.TimeManager;

namespace TradeCity.Engine.Map
{
    [Serializable]
    public class Map : ITickable
    {
        private readonly int defaultBid = 100;
        private readonly int defaultTimePerRound = 100;
        private readonly IMapStructure[,] structures;
        private readonly int sizeX, sizeY;
        private readonly List<Auction> liveAuctions = new();

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
                Auction newAuction = new((Land)subject, defaultBid, defaultTimePerRound, by);
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
