using Assets.Module.Market;
using JHP4SD.Lebeg134.Module.Market;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.GUI.Market
{
    class MyListingsListScript : ListScript<SPListing>
    {
        protected override void Start()
        {
            base.Start();
            SPMarket.notifySubscribers += Refresh;
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
