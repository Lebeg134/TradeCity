using Lebeg134.Module.Market;
using Lebeg134.Module.TimeManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lebeg134.Module.Market
{
    class SPMarket
    {
        public delegate void Notify();
        public static event Notify notifySubscribers; 
        public static SPMarket Instance {
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
            newListing.register();
            notifySubscribers?.Invoke();
        }
        public void RemoveListing(SPListing listing)
        {
            listings.Remove(listing);
            Clock.Instance.unRegister(listing);
            notifySubscribers?.Invoke();
        }
    }
}
