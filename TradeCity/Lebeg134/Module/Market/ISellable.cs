/**
* @(#) ISellable.cs
*/
using JHP4SD.Lebeg134.Module.Resources;
using System.Collections.Generic;
namespace JHP4SD.Lebeg134.Module.MarketNS
{
    public interface ISellable : IEqualityComparer<ISellable>
    {
        double getValue();
        void simulatePrice();
        void reportListing(Listing listing);
        Resource getNewResource(int amount);
        int amount();
    }

}
