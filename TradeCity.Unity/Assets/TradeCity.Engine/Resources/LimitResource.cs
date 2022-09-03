

using System;

/**
* @(#) LimitResource.cs
*/
namespace TradeCity.Engine.Resources
{
    [Serializable]
    public abstract class LimitResource : Resource
    {
        private int limit;
        public LimitResource(int amount) : base(amount) { }
        public void IncLimit(int by = 1)
        {
            limit += by;
        }
        public void DecLimit(int by = 1)
        {
            limit -= by;
            if (limit < 0)
                limit = 0;
        }
        override public Resource Gain(int amount)
        {
            if (stock + amount <= limit)
            {
                base.Gain(amount);
            }
            else
            {
                base.Gain(stock + amount - limit);
            }
            return this;
        }
    }
}
