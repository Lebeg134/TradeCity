using System.Collections.Generic;
using TradeCity.Engine.TimeManager;

namespace TradeCity.Engine.Market
{
    public class SPMarket
    {
        public delegate void Notify();
        public static event Notify NotifySubscribers;
        public static SPMarket Instance
        {
            get
            {
                if (instance == null)
                    return instance = new SPMarket();
                else
                    return instance;
            }
            set => instance = value;
        }

        private static SPMarket instance;
        private readonly List<SPListing> listings = new();
        public List<SPListing> Listings => listings;
        public void RegisterListing(SPListing newListing)
        {
            listings.Add(newListing);
            newListing.Register();
            NotifySubscribers?.Invoke();
        }
        public void RemoveListing(SPListing listing)
        {
            listings.Remove(listing);
            Clock.Instance.UnRegister(listing);
            NotifySubscribers?.Invoke();
        }
    }
}
