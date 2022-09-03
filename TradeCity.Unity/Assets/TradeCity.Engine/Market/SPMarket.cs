using System.Collections.Generic;
using TradeCity.Engine.TimeManager;

namespace TradeCity.Engine.Market
{
    public class SpMarket
    {
        public delegate void Notify();
        public static event Notify NotifySubscribers;
        public static SpMarket Instance
        {
            get
            {
                if (_instance == null)
                    return _instance = new SpMarket();
                return _instance;
            }
            set => _instance = value;
        }

        private static SpMarket _instance;
        private readonly List<SpListing> _listings = new();
        public List<SpListing> Listings => _listings;
        public void RegisterListing(SpListing newListing)
        {
            _listings.Add(newListing);
            newListing.Register();
            NotifySubscribers?.Invoke();
        }
        public void RemoveListing(SpListing listing)
        {
            _listings.Remove(listing);
            Clock.Instance.UnRegister(listing);
            NotifySubscribers?.Invoke();
        }
    }
}
