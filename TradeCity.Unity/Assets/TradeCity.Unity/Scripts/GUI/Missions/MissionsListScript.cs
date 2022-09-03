using System.Collections.Generic;
using TradeCity.Engine.Missions;
using TradeCity.Engine.Session;
using UnityEngine;

namespace TradeCity.Unity.Scripts.GUI.Missions
{
    class MissionsListScript : ListScript<Mission>
    {
        protected override ICollection<Mission> GetCollection()
        {
            return Session.Instance.Missions;
        }

        protected override void ProcessListItem(Mission item, GameObject newListItem)
        {
            newListItem.GetComponent<MissionListItemScript>().SetWatched(item);
        }
    }
}
