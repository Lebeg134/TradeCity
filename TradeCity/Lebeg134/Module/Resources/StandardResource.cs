/**
* @(#) StandardResource.cs
*/
using JHP4SD.Lebeg134.Module.MarketNS;

namespace JHP4SD.Lebeg134.Module.Resources
{
    public abstract class StandardResource : Resource, ISellable
    {
        public double getValue()
        {
            throw new System.NotImplementedException();
        }
        public void reportListing(Listing listing)
        {
            throw new System.NotImplementedException();
        }
        public void simulatePrice()
        {
            throw new System.NotImplementedException();
        }
        public bool Equals(ISellable x, ISellable y)
        {
            throw new System.NotImplementedException();
        }

        public int GetHashCode(ISellable obj)
        {
            throw new System.NotImplementedException();
        }
    }
}
