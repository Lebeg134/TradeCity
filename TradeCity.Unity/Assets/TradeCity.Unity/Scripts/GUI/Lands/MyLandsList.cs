using System.Collections.Generic;
using AutSoft.UnitySupplements.EventBus;
using Injecter;
using TradeCity.Engine.Session;
using TradeCity.Engine.Structures;
using UnityEngine;

namespace TradeCity.Unity.Scripts.GUI.Lands
{
    public class MyLandsList : SimpleList<Land, OwnedLandVisual>
    {
        [Inject] private readonly IEventBus _eventBus = default!;

        protected override void Awake()
        {
            base.Awake();
            _eventBus.SubscribeWeak<Player.StructureAcquired>(this, OnStructureAcquired);
        }

        private void OnStructureAcquired(Player.StructureAcquired message) => Refresh();

        protected override IEnumerable<Land> GetCollection()
        {
            return Player.CurrentPlayer.GetLands();
        }

        protected override void ProcessListItem(Land item, OwnedLandVisual newListItem)
        {
            newListItem.Watched = item;
        }
    }
}
