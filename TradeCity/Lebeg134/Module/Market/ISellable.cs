/**
 * @(#) ISellable.cs
 */

namespace Lebeg134.Module.MarketNS
{
    public interface ISellable
    {
        double getValue();

        void simulatePrice();

        void reportListing(Listing listing);

    }

}
