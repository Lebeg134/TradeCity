using System.Collections.Generic;
using TradeCity.Engine.Market;
using UnityEngine;

namespace TradeCity.Unity.Scripts.GUI.Market
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
