

using System;
/**
* @(#) LimitResource.cs
*/
namespace Lebeg134.Module.Resources
{
    [Serializable]
    public abstract class LimitResource : Resource
    {
        static int limit;

        public LimitResource(int amount) : base(amount) { }
        public void incLimit(int by) //Static?
        {
            limit += by;
        }
        public void decLimit(int by) //Static?
        {
            int newLimit = limit - by;
            if (newLimit >= 0)
            {
                limit = newLimit;
            }
        }
        override public void gain(int amount)
        {
            int newStock = limit + stock;
            if (newStock <= limit)
            {
                base.gain(amount);
            }
            else
            {
                stock = limit;
                //throw new ResourceLimitExceededException();
            }
        }
    }
}
