/**
* @(#) Market.cs
*/
using Lebeg134.Module.Session;
using Lebeg134.Module.TimeManager;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Lebeg134.Module.MarketNS
{
    [Serializable]
    public class Market : ITickable
    {
        private Dictionary<System.Type, ItemLog> _registeredItems;
        private Dictionary<System.Type, List<Listing>> listings;

        void GenerateListing(ISellable of, int num)
        {

        }
        public int PostListing(ISellable wantSellable, ISellable forSellable, Player by, int amount = 1, bool all = false)
        {
            // TODO check if Listing already exists
            Listing post = new Listing(wantSellable, forSellable, by, amount);
            List<Listing> listings = listings[forSellable.GetType()];
            int newAmount = post.LockResources(all);
            if (amount != newAmount)
                post = new Listing(wantSellable, forSellable, by, newAmount);
            listings.Add(post);
            return amount;
        }
        public double GetValueOf(ISellable sellable)
        {
            //TODO
            return 0;
        }
        public Listing GetMinSell(ISellable wantSellable, ISellable forSellable)
        {
            List<Listing> listings = listings[wantSellable.GetType()].FindAll(x => x.ForSellable.Equals(forSellable));
            if (listings.Count > 0)
            {
                listings.Sort();
                return listings.First();
            }
            else
                return null;
        }
        public Listing GetMaxBuy(ISellable wantSellable, ISellable forSellable)
        {
            List<Listing> listings = listings[forSellable.GetType()].FindAll(x => x.WantSellable.Equals(wantSellable));
            if (listings?.Count > 0)
            {
                listings.Sort();
                return listings.Last();
            }
            else
                return null;
        }
        public void RemovePlayer(Player player)
        {
            foreach (List<Listing> list in listings.Values)
            {
                foreach (Listing listing in list)
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
            List<Listing> myListings = new List<Listing>();
            foreach (List<Listing> list in listings.Values)
            {
                myListings.AddRange(list.FindAll(x => x.Poster.Equals(player)));
            }
            return myListings;
        }
        public void Simulate()
        {
            // Generate new listings
        }
        void AutoCompleteListings()
        {
            // Could be moved to postListing
        }
        public void Tick()
        {
            foreach (List<Listing> list in listings.Values)
            {
                foreach (Listing listing in list)
                {
                    listing.Tick();
                }
            }
            Simulate();
        }
        public void Register()
        {
            throw new System.NotImplementedException();
        }
    }
}
