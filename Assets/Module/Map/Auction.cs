/**
 * @(#) Auction.cs
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
    public class Auction : ITickable, IEqualityComparer<Auction>
    {
        Land _subject;
        int _currentPrice;
        int _minBid;
        Player _lastBidder;
        int _timeRemaining;
        int _timePerRound;

        public Auction(Land subject, int minBid, int timePerRound, Player initiater = null)
        {
            _subject = subject;
            _currentPrice = subject.GetStartingPrice();
            _minBid = minBid;
            _timeRemaining = timePerRound;
            _timePerRound = timePerRound;
            _lastBidder = initiater;
        }
        public void Bid(Player by, int bid)
        {
            if (bid > _currentPrice + _minBid)
            {
                _timeRemaining = _timePerRound;
                _lastBidder = by;
            }
        }
        public void Finish()
        {
            if (_lastBidder != null)
            {
                _subject.acquire(_lastBidder);
                throw new AuctionFinishedException();
            }
        }
        public void tick()
        {
            if (--_timeRemaining <= 0)
                Finish();
        }
        public void register()
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
