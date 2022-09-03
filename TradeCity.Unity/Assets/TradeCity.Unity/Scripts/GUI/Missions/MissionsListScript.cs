using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lebeg134.Module.Missions;
using Lebeg134.Module.Session;
using UnityEngine;

namespace Assets.Scripts.GUI.Missions
{
    class MissionsListScript : ListScript<Mission>
    {
        protected override ICollection<Mission> GetCollection()
        {
            return Session.Instance.missions;
        }

        protected override void ProcessListItem(Mission item, GameObject newListItem)
        {
            newListItem.GetComponent<MissionListItemScript>().SetWatched(item);
        }
    }
}
