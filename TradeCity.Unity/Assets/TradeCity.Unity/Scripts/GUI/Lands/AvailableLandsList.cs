using System.Collections.Generic;
using TradeCity.Engine.Session;
using TradeCity.Engine.Structures;
using UnityEngine;

namespace TradeCity.Unity.Scripts.GUI.Lands
{
    public class AvailableLandsList : SimpleList<Land>
    {
        protected override ICollection<Land> GetCollection()
        {
            return Session.Instance.Offers.Keys;
        }

        protected override void ProcessListItem(Land item, GameObject newListItem)
        {
            newListItem.GetComponent<LandOfferVisuals>().watched = item;
            newListItem.GetComponent<LandOfferVisuals>().price = Session.Instance.Offers[item];
        }
    }
}
