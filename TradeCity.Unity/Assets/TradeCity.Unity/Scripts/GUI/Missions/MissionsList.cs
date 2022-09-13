﻿using System.Collections.Generic;
using TradeCity.Engine.Missions;
using TradeCity.Engine.Session;
using UnityEngine;

namespace TradeCity.Unity.Scripts.GUI.Missions
{
    internal class MissionsList : SimpleList<Mission, MissionListItem>
    {
        protected override IEnumerable<Mission> GetCollection()
        {
            return Session.Instance.Missions;
        }

        protected override void ProcessListItem(Mission item, MissionListItem newListItem)
        {
            newListItem.SetWatched(item);
        }
    }
}
