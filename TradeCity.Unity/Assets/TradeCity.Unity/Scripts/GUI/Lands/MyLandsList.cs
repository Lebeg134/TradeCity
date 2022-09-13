using System.Collections.Generic;
using TradeCity.Engine.Session;
using TradeCity.Engine.Structures;
using UnityEngine;

namespace TradeCity.Unity.Scripts.GUI.Lands
{
    public class MyLandsList : SimpleList<Land, OwnedLandVisual>
    {
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
