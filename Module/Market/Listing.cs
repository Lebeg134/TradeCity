/**
* @(#) Listing.cs
*/
using JHP4SD.Lebeg134.Module.Resources;
using JHP4SD.Lebeg134.Module.Session;
using JHP4SD.Lebeg134.Module.TimeManager;
using System;
using System.Collections.Generic;

namespace JHP4SD.Lebeg134.Module.MarketNS
{
    [Serializable]
    public class Listing : ITickable, IComparer<Listing>
    {
        private static readonly int defaultTime = 100;
        public ISellable WantSellable { get; }
        public ISellable ForSellable { get; }
        public Player Poster { get; }
        private int _amount;
        private int _timeLeft;

        public Listing(ISellable wantSellable, ISellable forSellable, Player postedBy, int amount = 1)
        {
            WantSellable = wantSellable;
            ForSellable = forSellable;
            Poster = postedBy;
            _amount = amount;
            _timeLeft = defaultTime;
        }
        public int complete(Player by, int number = -1)
        {
            if (number == -1)
                number = _amount;
            int count = 0;
            if (number <= 0 || Poster == by) return 0;
            for (; count <= number; count++)
            {
                try
                {
                    by.subRes((Resource)WantSellable);
                    by.giveRes((Resource)ForSellable);
                }
                catch (NotEnoughResourceException)
                {
                    break;
                }
            }
            return count;
        }
        public void cancel()
        {
            for (; _amount > 0; _amount--)
                Poster.giveRes((Resource)ForSellable);
        }
        public int lockResources(bool all = false)
        {
            int count = 0;
            if (all)
            {
                count = _amount;
                Resource sub = ForSellable.getNewResource(_amount);
                Poster.checkResource(sub);
                Poster.subRes(sub);
            }
            else
            {
                try
                {
                    for (; count < _amount; count++)
                        Poster.subRes((Resource)ForSellable);
                }
                catch (NotEnoughResourceException)
                {
                    _amount = count;
                }
            }
            return count;
        }
        public double value()
        {
            return WantSellable.amount() / ForSellable.amount();
        }
        public void tick()
        {
            if (--_timeLeft <= 0)
            {
                cancel();
            }
        }
        public void register()
        {
            throw new System.NotImplementedException();
        }
        public int Compare(Listing x, Listing y)
        {
            return x.value().CompareTo(y.value());
        }
    }
}
