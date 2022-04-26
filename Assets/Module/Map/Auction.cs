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
        Land subject;
        int currentPrice;
        int minBid;
        Player lastBidder;
        int timeRemaining;
        int timePerRound;

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
