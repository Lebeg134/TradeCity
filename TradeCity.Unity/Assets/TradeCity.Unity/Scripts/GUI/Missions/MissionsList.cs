using Injecter;
using System.Collections.Generic;
using TradeCity.Engine.Core;
using TradeCity.Engine.Core.Interfaces;
using TradeCity.Engine.Missions;
using TradeCity.Engine.Session;
using UnityEngine;

namespace TradeCity.Unity.Scripts.GUI.Missions
{
    public class MissionsList : SimpleList<Mission, MissionListItem>
    {
        [Inject] private ISessionService _sessionService;

        protected override void Awake()
        {
            base.Awake();
            _sessionService = EngineCore.InjectSessionService();
        }
        protected override IEnumerable<Mission> GetCollection()
        {
            return _sessionService.CurrentSession.Missions;
        }

        protected override void ProcessListItem(Mission item, MissionListItem newListItem)
        {
            newListItem.SetWatched(item);
        }
    }
}
