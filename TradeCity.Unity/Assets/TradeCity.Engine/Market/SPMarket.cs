using Lebeg134.Module.TimeManager;
using System.Collections.Generic;

namespace Lebeg134.Module.Market
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
            set
            {
                instance = value;
            }
        }
        static SPMarket instance;

        List<SPListing> listings = new List<SPListing>();
        public List<SPListing> Listings { get { return listings; } }
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
