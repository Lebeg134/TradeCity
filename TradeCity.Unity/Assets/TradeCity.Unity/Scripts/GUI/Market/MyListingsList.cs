using System.Collections.Generic;
using TradeCity.Engine.Market;
using UnityEngine;

namespace TradeCity.Unity.Scripts.GUI.Market
{
    internal class MyListingsList : SimpleList<SpListing, ListingItemVisual>
    {
        protected override void Start()
        {
            base.Start();
            SpMarket.NotifySubscribers += Refresh;
        }

        protected override IEnumerable<SpListing> GetCollection()
        {
            return SpMarket.Instance.Listings;
        }

        protected override void ProcessListItem(SpListing item, ListingItemVisual newListItem)
        {
            newListItem.Watched = item;
        }

    }
}
