using AutSoft.UnitySupplements.EventBus;
using System.Collections.Generic;
using Injecter;
using TradeCity.Engine.Market;
using UnityEngine;
using TradeCity.Engine.Core;

namespace TradeCity.Unity.Scripts.GUI.Market
{
    public class MyListingsList : SimpleList<SpListing, ListingItemVisual>
    {
        [Inject] private IEventBus _eventBus;

        protected override void Start()
        {
            base.Start();
            _eventBus = EngineCore.InjectEventBus();
            _eventBus.SubscribeWeak<SpMarket.ListingRegistered>(this, (message)=> Refresh());
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
