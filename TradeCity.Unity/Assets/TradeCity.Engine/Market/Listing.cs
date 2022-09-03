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
        private int amount;
        private int timeLeft;

        public Listing(ISellable wantSellable, ISellable forSellable, Player postedBy, int amount = 1)
        {
            WantSellable = wantSellable;
            ForSellable = forSellable;
            Poster = postedBy;
            this.amount = amount;
            timeLeft = defaultTime;
        }
        public int Complete(Player by, int number = -1)
        {
            if (number == -1)
                number = amount;
            int count = 0;
            if (number <= 0 || Poster == by) return 0;
            for (; count <= number; count++)
            {
                try
                {
                    by.SubRes((Resource)WantSellable);
                    by.GiveRes((Resource)ForSellable);
                }
                catch (Exception)
                {
                    break;
                }
            }
            return count;
        }
        public void Cancel()
        {
            for (; amount > 0; amount--)
                Poster.GiveRes((Resource)ForSellable);
        }
        public int LockResources(bool all = false)
        {
            int count = 0;
            if (all)
            {
                count = amount;
                Resource sub = ForSellable.GetNewResource(amount);
                Poster.CheckResource(sub);
                Poster.SubRes(sub);
            }
            else
            {
                try
                {
                    for (; count < amount; count++)
                        Poster.SubRes((Resource)ForSellable);
                }
                catch (Exception)
                {
                    amount = count;
                }
            }
            return count;
        }
        public double Value()
        {
            return WantSellable.GetStock() / ForSellable.GetStock();
        }
        public void Tick()
        {
            if (--timeLeft <= 0)
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
