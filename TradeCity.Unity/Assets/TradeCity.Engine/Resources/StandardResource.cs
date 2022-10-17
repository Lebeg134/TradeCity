using System;
using TradeCity.Engine.Market;

namespace TradeCity.Engine.Resources
{
    [Serializable]
    public abstract class StandardResource : Resource, ISellable
    {
        protected StandardResource(int amount) : base(amount)
        {
        }

        public abstract double GetValue();

        public void SimulatePrice()
        {
            throw new NotImplementedException();
        }

        public bool Equals(ISellable x, ISellable y)
        {
            // POT
            return x.GetType() == y.GetType();
        }

        public int GetHashCode(ISellable obj)
        {
            throw new NotImplementedException();
        }

        public void ReportListing(Listing listing)
        {
            throw new NotImplementedException();
        }
    }
}