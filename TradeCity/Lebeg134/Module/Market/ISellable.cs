/**
 * @(#) ISellable.cs
 */

namespace Lebeg134.Module.Market
{
    public interface ISellable
    {
        double getValue();

        void simulatePrice();

        void reportListing(Listing listing);

    }

}
