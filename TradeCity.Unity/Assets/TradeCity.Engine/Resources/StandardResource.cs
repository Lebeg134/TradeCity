/**
* @(#) StandardResource.cs
*/

using System;
using TradeCity.Engine.Market;

namespace TradeCity.Engine.Resources
{
    [Serializable]
    public abstract class StandardResource : Resource, ISellable
    {
        public StandardResource(int amount) : base(amount) { }
        public abstract double GetValue();
        public void ReportListing(Listing listing)
        {
            throw new System.NotImplementedException();
        }
        public void SimulatePrice()
        {
            throw new System.NotImplementedException();
        }
        public bool Equals(ISellable x, ISellable y)
        {
            // POT
            return (x.GetType() == y.GetType());
        }

        public int GetHashCode(ISellable obj)
        {
            throw new System.NotImplementedException();
        }
    }
}
