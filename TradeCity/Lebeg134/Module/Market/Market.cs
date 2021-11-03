/**
* @(#) Market.cs
*/
using JHP4SD.Lebeg134.Module.Session;
using JHP4SD.Lebeg134.Module.TimeManager;
using System.Collections.Generic;

namespace JHP4SD.Lebeg134.Module.MarketNS
{
    public class Market: ITickable
    {
        private Dictionary<System.Type, ItemLog> _registeredItems;
        private Dictionary<System.Type, List<Listing>> _listings;


        void generateListing(ISellable of, int num)
        {

        }

        public void postListing(Listing listing, Player by)
        {

        }

        public double getValueOf(ISellable sellable)
        {
            return 0;
        }

        public Listing getMinSell(ISellable wantSellable, ISellable forSellable)
        {
            //_listings[wantSellable.GetType()]
            return null
                
        }

        public int getMaxBuy(ISellable sellable)
        {
            return null;
        }

        public void removePlayer(Player player)
        {

        }

        public Listing searchPlayerListings(Player player)
        {
            return null;
        }

        public void simulate()
        {

        }

        void autoCompleteListings()
        {

        }

        public void tick()
        {
            foreach (List<Listing> list in _listings.Values)
            {
                foreach (Listing listing in list)
                {
                    listing.tick();
                }
            }
        }
        public void register()
        {
            throw new System.NotImplementedException();
        }
    }

}
