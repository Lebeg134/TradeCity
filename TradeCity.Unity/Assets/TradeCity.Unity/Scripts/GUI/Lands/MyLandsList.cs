using System.Collections.Generic;
using TradeCity.Engine.Session;
using TradeCity.Engine.Structures;
using TradeCity.Unity.Scripts.GUI.VisualUpdaters;
using UnityEngine;

namespace TradeCity.Unity.Scripts.GUI.Lands
{
    public class MyLandsList : SimpleList<Land>, IVisualUpdateable
    {
        public void VisualUpdate()
        {
            Refresh();
        }

        protected override ICollection<Land> GetCollection()
        {
            return Player.CurrentPlayer.GetLands();
        }

        protected override void ProcessListItem(Land item, GameObject newListItem)
        {
            newListItem.GetComponent<OwnedLandVisual>().Watched = item;
        }
    }
}
