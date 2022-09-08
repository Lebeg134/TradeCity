using System.Collections.Generic;
using TradeCity.Engine.TimeManager;

namespace TradeCity.Engine.Market
{
    public class SpMarket
    {
        public delegate void Notify();

        private static SpMarket _instance;

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

        public List<SpListing> Listings { get; } = new();

        public static event Notify NotifySubscribers;

        public void RegisterListing(SpListing newListing)
        {
            Listings.Add(newListing);
            newListing.Register();
            NotifySubscribers?.Invoke();
        }

        public void RemoveListing(SpListing listing)
        {
            Listings.Remove(listing);
            Clock.Instance.UnRegister(listing);
            NotifySubscribers?.Invoke();
        }
    }
}