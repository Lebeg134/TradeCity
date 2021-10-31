/**
 * @(#) LimitResource.cs
 */

namespace Lebeg134.Module.Resources
{
    public class LimitResource : Resource
    {
        static int limit;

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
            }
        }
    }
}