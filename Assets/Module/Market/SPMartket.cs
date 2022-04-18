using JHP4SD.Lebeg134.Module.Market;
using JHP4SD.Lebeg134.Module.TimeManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Module.Market
{
    class SPMartket
    {
        public static SPMartket Instance {
            get
            {
                if (instance == null)
                    return instance = new SPMartket();
                else
                    return instance;
            }
            set
            {
                instance = value;
            }
        }
        static SPMartket instance;

        List<SPListing> listings = new List<SPListing>();

        public void RegisterListing(SPListing newListing)
        {
            listings.Add(newListing);
            newListing.register();
        }
        public void RemoveListing(SPListing listing)
        {
            listings.Remove(listing);
            Clock.Instance.unRegister(listing);
        }

    }
}
