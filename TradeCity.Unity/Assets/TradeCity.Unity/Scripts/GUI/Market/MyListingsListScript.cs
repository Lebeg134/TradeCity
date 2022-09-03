using System.Collections.Generic;
using TradeCity.Engine.Market;
using UnityEngine;

namespace TradeCity.Unity.Scripts.GUI.Market
{
    class MyListingsListScript : ListScript<SpListing>
    {
        protected override void Start()
        {
            base.Start();
            SpMarket.NotifySubscribers += Refresh;
        }
        protected override ICollection<SpListing> GetCollection()
        {
            return SpMarket.Instance.Listings;
        }

        protected override void ProcessListItem(SpListing item, GameObject newListItem)
        {
            newListItem.GetComponent<ListingItemVisualScript>().watched = item;
        }

    }
}
