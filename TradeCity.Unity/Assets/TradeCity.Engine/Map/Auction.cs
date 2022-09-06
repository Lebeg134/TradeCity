using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using TradeCity.Engine.Session;
using TradeCity.Engine.Structures;
using TradeCity.Engine.TimeManager;

namespace TradeCity.Engine.Map
{
    [Serializable]
    public class Auction : ITickable, IEqualityComparer<Auction>
    {
        private readonly Land _subject;
        private readonly int _currentPrice;
        private readonly int _minBid;
        private Player _lastBidder;
        private int _timeRemaining;
        private readonly int _timePerRound;

        public Auction(Land subject, int minBid, int timePerRound, Player initiator = null)
        {
            _subject = subject;
            _currentPrice = subject.GetStartingPrice();
            _minBid = minBid;
            _timeRemaining = timePerRound;
            _timePerRound = timePerRound;
            _lastBidder = initiator;
        }

        public void Bid(Player by, int bid)
        {
            if (bid <= _currentPrice + _minBid) return;
            _timeRemaining = _timePerRound;
            _lastBidder = by;
        }

        public void Finish()
        {
            if (_lastBidder == null) return;
            _subject.Acquire(_lastBidder);
            throw new AuctionFinishedException();
        }

        public void Tick()
        {
            if (--_timeRemaining <= 0)
                Finish();
        }

        public void Register()
        {
            //Do nothing - Auctions are ticked by container
        }

        public bool Equals(Auction x, Auction y)
        {
            return x._subject.Equals(y._subject);
        }

        public int GetHashCode(Auction obj)
        {
            return _subject.GetHashCode();
        }
    }
    [Serializable]
    internal class AuctionFinishedException : Exception
    {
        public AuctionFinishedException()
        {
        }

        public AuctionFinishedException(string message) : base(message)
        {
        }

        public AuctionFinishedException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected AuctionFinishedException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}