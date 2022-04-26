/**
* @(#) Listing.cs
*/
using Lebeg134.Module.Resources;
using Lebeg134.Module.Session;
using Lebeg134.Module.TimeManager;
using System;
using System.Collections.Generic;

namespace Lebeg134.Module.MarketNS
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
        public int Complete(Player by, int number = -1)
        {
            if (number == -1)
                number = _amount;
            int count = 0;
            if (number <= 0 || Poster == by) return 0;
            for (; count <= number; count++)
            {
                try
                {
                    by.SubRes((Resource)WantSellable);
                    by.GiveRes((Resource)ForSellable);
                }
                catch (NotEnoughResourceException)
                {
                    break;
                }
            }
            return count;
        }
        public void Cancel()
        {
            for (; _amount > 0; _amount--)
                Poster.GiveRes((Resource)ForSellable);
        }
        public int LockResources(bool all = false)
        {
            int count = 0;
            if (all)
            {
                count = _amount;
                Resource sub = ForSellable.GetNewResource(_amount);
                Poster.CheckResource(sub);
                Poster.SubRes(sub);
            }
            else
            {
                try
                {
                    for (; count < _amount; count++)
                        Poster.SubRes((Resource)ForSellable);
                }
                catch (NotEnoughResourceException)
                {
                    _amount = count;
                }
            }
            return count;
        }
        public double Value()
        {
            return WantSellable.Amount() / ForSellable.Amount();
        }
        public void Tick()
        {
            if (--_timeLeft <= 0)
            {
                Cancel();
            }
        }
        public void Register()
        {
            throw new System.NotImplementedException();
        }
        public int Compare(Listing x, Listing y)
        {
            return x.Value().CompareTo(y.Value());
        }
    }
}
