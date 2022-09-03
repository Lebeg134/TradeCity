/**
 * @(#) Auction.cs
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
    public class Auction : ITickable, IEqualityComparer<Auction>
    {
        private readonly Land subject;
        private readonly int currentPrice;
        private readonly int minBid;
        private Player lastBidder;
        private int timeRemaining;
        private readonly int timePerRound;

        public Auction(Land subject, int minBid, int timePerRound, Player initiater = null)
        {
            this.subject = subject;
            currentPrice = subject.GetStartingPrice();
            this.minBid = minBid;
            timeRemaining = timePerRound;
            this.timePerRound = timePerRound;
            lastBidder = initiater;
        }
        public void Bid(Player by, int bid)
        {
            if (bid > currentPrice + minBid)
            {
                timeRemaining = timePerRound;
                lastBidder = by;
            }
        }
        public void Finish()
        {
            if (lastBidder != null)
            {
                subject.Acquire(lastBidder);
                throw new AuctionFinishedException();
            }
        }
        public void Tick()
        {
            if (--timeRemaining <= 0)
                Finish();
        }
        public void Register()
        {
            //Do nothing - Auctions are ticked by container
        }
        public bool Equals(Auction x, Auction y)
        {
            return x.subject.Equals(y.subject);
        }
        public int GetHashCode(Auction obj)
        {
            return subject.GetHashCode();
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
