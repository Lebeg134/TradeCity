using System.Collections.Generic;
using AutSoft.UnitySupplements.EventBus;
using Injecter;
using TradeCity.Engine.Core;
using TradeCity.Engine.TimeManager;

namespace TradeCity.Engine.Market
{
    public class SpMarket
    {
        [Inject] private readonly IEventBus _eventBus = default!;
        
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

        public void RegisterListing(SpListing newListing)
        {
            Listings.Add(newListing);
            newListing.Register();
            _eventBus.Invoke(new ListingRegistered(newListing));
        }

        public void RemoveListing(SpListing listing)
        {
            Listings.Remove(listing);
            EngineCore.Instance.RemoveTickable(listing);
            _eventBus.Invoke(new ListingRegistered(listing));
        }

        public sealed class ListingRegistered : IEvent
        {
            public ListingRegistered(SpListing newListing)
            {
                NewListing = newListing;
            }

            public SpListing NewListing { get; }
        }

        public sealed class ListingRemoved: IEvent
        {
            public ListingRemoved(SpListing removedListing)
            {
                RemovedListing = removedListing;
            }

            public SpListing RemovedListing { get; }
        }
    }
}