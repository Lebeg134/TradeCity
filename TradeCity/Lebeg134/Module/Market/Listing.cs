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
    public class Listing : ITickable, IComparer<Listing>
    {
        private static readonly int defaultTime = 100;
        private ISellable _wantSellable;
        private ISellable _forSellable;
        private Player _postedBy;
        private int _amount;
        private int _timeLeft;

        public Listing(ISellable wantSellable, ISellable forSellable, Player postedBy, int amount = 1)
        {
            _wantSellable = wantSellable;
            _forSellable = forSellable;
            _postedBy = postedBy;
            _amount = amount;
            _timeLeft = defaultTime;
        }
        public int complete(Player by, int number = -1)
        {
            if (number == -1)
                number = _amount;
            int count = 0;
            if (number <= 0 || _postedBy == by) return 0;
            for (; count <= number; count++)
            {
                try
                {
                    by.subRes((Resource)_wantSellable);
                    by.giveRes((Resource)_forSellable);
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
                _postedBy.giveRes((Resource)_forSellable);
        }
        public int lockResources(bool all = false)
        {
            int count = 0;
            if (all)
            {
                count = _amount;
                Resource sub = _forSellable.getNewResource(_amount);                
                _postedBy.checkResource(sub);
                _postedBy.subRes(sub);
            }
            else
            {
                try
                {
                    for (; count < _amount; count++)
                        _postedBy.subRes((Resource)_forSellable);
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
            return _wantSellable.amount() / _forSellable.amount();
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
        //public void merge(Listing with) Not going to be used
        //{
        //    if (_wantSellable.Equals(with._wantSellable) && _forSellable.Equals(with._forSellable))
        //    {
        //        _amount += with._amount;
        //    }
        //}
    }
}
