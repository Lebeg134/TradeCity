/**
* @(#) StandardResource.cs
*/
using Lebeg134.Module.MarketNS;
using System;

namespace Lebeg134.Module.Resources
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
