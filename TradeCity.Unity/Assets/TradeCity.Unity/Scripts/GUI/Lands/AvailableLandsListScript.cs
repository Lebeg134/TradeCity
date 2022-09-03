using System.Collections.Generic;
using TradeCity.Engine.Session;
using TradeCity.Engine.Structures;
using UnityEngine;

namespace TradeCity.Unity.Scripts.GUI.Lands
{
    public class AvailableLandsListScript : ListScript<Land>
    {
        protected override ICollection<Land> GetCollection()
        {
            return Session.Instance.Offers.Keys;
        }

        protected override void ProcessListItem(Land item, GameObject newListItem)
        {
            newListItem.GetComponent<LandOfferVisualsScript>().watched = item;
            newListItem.GetComponent<LandOfferVisualsScript>().price = Session.Instance.Offers[item];
        }
    }
}
