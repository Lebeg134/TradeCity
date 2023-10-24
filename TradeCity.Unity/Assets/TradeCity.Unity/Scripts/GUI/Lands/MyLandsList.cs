using System.Collections.Generic;
using AutSoft.UnitySupplements.EventBus;
using Injecter;
using TradeCity.Engine.Core;
using TradeCity.Engine.Core.Interfaces;
using TradeCity.Engine.Session;
using TradeCity.Engine.Structures;
using UnityEngine;

namespace TradeCity.Unity.Scripts.GUI.Lands
{
    public class MyLandsList : SimpleList<Land, OwnedLandVisual>
    {
        [Inject] private IPlayerService _playerService;
        [Inject] private IEventBus _eventBus;

        protected override void Awake()
        {
            base.Awake();
            _playerService = EngineCore.InjectPlayerService();
            _eventBus = EngineCore.InjectEventBus();
            
            _eventBus.SubscribeWeak<Player.StructureAcquired>(this, OnStructureAcquired);
        }

        private void OnStructureAcquired(Player.StructureAcquired message) => Refresh();

        protected override IEnumerable<Land> GetCollection()
        {
            return _playerService.CurrentPlayer == null ? new List<Land>() : _playerService.CurrentPlayer.GetLands();
        }

        protected override void ProcessListItem(Land item, OwnedLandVisual newListItem)
        {
            newListItem.SetWatched(item);
        }
    }
}
