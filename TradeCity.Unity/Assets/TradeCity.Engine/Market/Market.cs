using System;
using System.Collections.Generic;
using System.Linq;
using TradeCity.Engine.Session;
using TradeCity.Engine.TimeManager;

namespace TradeCity.Engine.Market
{
    [Serializable]
    public class Market : ITickable
    {
        private readonly Dictionary<Type, ItemLog> _registeredItems;
        private readonly Dictionary<Type, List<Listing>> _listings;

        public Market(Dictionary<Type, List<Listing>> listings)
        {
            _listings = listings;
        }

        private void GenerateListing(ISellable of, int num)
        {

        }

        public int PostListing(ISellable wantSellable, ISellable forSellable, Player by, int amount = 1, bool all = false)
        {
            // TODO check if Listing already exists
            Listing post = new(wantSellable, forSellable, by, amount);
            var relevantListings = _listings[forSellable.GetType()];
            var newAmount = post.LockResources(all);
            if (amount != newAmount)
                post = new Listing(wantSellable, forSellable, by, newAmount);
            relevantListings.Add(post);
            return amount;
        }

        public double GetValueOf(ISellable sellable)
        {
            //TODO
            return 0;
        }

        public Listing GetMinSell(ISellable wantSellable, ISellable forSellable)
        {
            var relevantListings = _listings[wantSellable.GetType()].FindAll(x => x.ForSellable.Equals(forSellable));
            if (relevantListings.Count > 0)
            {
                relevantListings.Sort();
                return relevantListings.First();
            }

            return null;
        }

        public Listing GetMaxBuy(ISellable wantSellable, ISellable forSellable)
        {
            var relevantListings = _listings[forSellable.GetType()].FindAll(x => x.WantSellable.Equals(wantSellable));
            if (!(_listings?.Count > 0)) return null;
            relevantListings.Sort();
            return relevantListings.Last();
        }

        public void RemovePlayer(Player player)
        {
            foreach (var list in _listings.Values)
            {
                foreach (var listing in list)
                {
                    if (listing.Poster.Equals(player))
                    {
                        listing.Cancel();
                        list.Remove(listing);
                    }
                }
            }
        }

        public List<Listing> GetPlayerListingsList(Player player)
        {
            List<Listing> myListings = new();
            foreach (var list in _listings.Values)
            {
                myListings.AddRange(list.FindAll(x => x.Poster.Equals(player)));
            }
            return myListings;
        }
        public void Simulate()
        {
            // Generate new listings
        }

        private void AutoCompleteListings()
        {
            // Could be moved to postListing
        }
        public void Tick()
        {
            foreach (var list in _listings.Values)
            {
                foreach (var listing in list)
                {
                    listing.Tick();
                }
            }
            Simulate();
        }
        public void Register()
        {
            throw new NotImplementedException();
        }
    }
}
