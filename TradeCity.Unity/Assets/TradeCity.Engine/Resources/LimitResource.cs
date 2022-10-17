using System;

namespace TradeCity.Engine.Resources
{
    [Serializable]
    public abstract class LimitResource : Resource
    {
        private int _limit;

        protected LimitResource(int amount) : base(amount)
        {
        }

        public void IncLimit(int by = 1)
        {
            _limit += by;
        }

        public void DecLimit(int by = 1)
        {
            _limit -= by;
            if (_limit < 0)
                _limit = 0;
        }

        public override Resource Gain(int amount)
        {
            if (_stock + amount <= _limit)
                base.Gain(amount);
            else
                base.Gain(_stock + amount - _limit);
            return this;
        }
    }
}