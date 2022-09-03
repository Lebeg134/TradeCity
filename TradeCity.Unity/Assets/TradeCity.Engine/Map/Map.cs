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
        private readonly int _defaultBid = 100;
        private readonly int _defaultTimePerRound = 100;
        private readonly IMapStructure[,] _structures;
        private readonly int _sizeX, _sizeY;
        private readonly List<Auction> _liveAuctions = new();

        public Map(int sizeX, int sizeY)
        {
            _sizeX = sizeX;
            _sizeY = sizeY;
            _structures = new IMapStructure[_sizeX, _sizeY];
            Register();
        }

        public IMapStructure GetStructure(int x, int y)
        {
            return _structures[x, y];
        }

        public void StartAuction(int x, int y, Player by)
        {
            var subject = _structures[x, y];
            if (!subject.IsAuctionable())
                throw new NotAuctionableException();

            Auction newAuction = new((Land)subject, _defaultBid, _defaultTimePerRound, by);
            if (_liveAuctions.Contains(newAuction))
            {
                throw new AuctionAlreadyExistsException();
            }

            _liveAuctions.Add(newAuction);
        }

        public void Tick()
        {
            foreach (var auction in _liveAuctions)
            {
                try
                {
                    auction.Tick();
                }
                catch (AuctionFinishedException)
                {
                    _liveAuctions.Remove(auction);
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
