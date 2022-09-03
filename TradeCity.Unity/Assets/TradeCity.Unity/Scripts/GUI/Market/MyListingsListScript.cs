using Lebeg134.Module.Market;
using System.Collections.Generic;
using UnityEngine;

namespace Lebeg134.Scripts.GUI.Market
{
    class MyListingsListScript : ListScript<SPListing>
    {
        protected override void Start()
        {
            base.Start();
            SPMarket.NotifySubscribers += Refresh;
        }
        protected override ICollection<SPListing> GetCollection()
        {
            return SPMarket.Instance.Listings;
        }

        protected override void ProcessListItem(SPListing item, GameObject newListItem)
        {
            newListItem.GetComponent<ListingItemVisualScript>().watched = item;
        }

    }
}
