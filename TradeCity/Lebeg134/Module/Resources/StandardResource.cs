/**
* @(#) StandardResource.cs
*/
using Lebeg134.Module.MarketNS;

namespace Lebeg134.Module.Resources
{
    public abstract class StandardResource : Resource, Market.ISellable
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
    }
}
