/**
* @(#) Market.cs
*/
using JHP4SD.Lebeg134.Module.Resources;
using JHP4SD.Lebeg134.Module.Session;
using JHP4SD.Lebeg134.Module.TimeManager;
using System.Collections.Generic;

namespace JHP4SD.Lebeg134.Module.MarketNS
{
    public class Market : ITickable
    {
        private Dictionary<System.Type, ItemLog> _registeredItems;
        private Dictionary<System.Type, List<Listing>> _listings;


        void generateListing(ISellable of, int num)
        {

        }
        public int postListing(ISellable wantSellable, ISellable forSellable, Player by, int amount = 1, bool all = false)
        {
            // TODO check if Listing already exists
            Listing post = new Listing(wantSellable, forSellable, by, amount);
            List<Listing> listings = _listings[forSellable.GetType()];
            int newAmount = post.lockResources(all);
            if (amount != newAmount)
                post = new Listing(wantSellable, forSellable, by, newAmount);

            listings.Add(post);
            return amount;
        }
        public double getValueOf(ISellable sellable)
        {
            return 0;
        }
        public Listing getMinSell(ISellable wantSellable, ISellable forSellable)
        {
            List<Listing> listings = _listings[wantSellable.GetType()];
            if (listings.Count != 0)
            {
                listings.Sort();
                return listings[0];
            }
            else
                return null;
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
            simulate();
        }
        public void register()
        {
            throw new System.NotImplementedException();
        }
    }

}
