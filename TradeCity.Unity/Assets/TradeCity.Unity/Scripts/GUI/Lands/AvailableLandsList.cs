#nullable enable
using System.Collections;
using System.Collections.Generic;
using TradeCity.Engine.Session;
using TradeCity.Engine.Structures;
using UnityEngine;

namespace TradeCity.Unity.Scripts.GUI.Lands
{
    public class AvailableLandsList : SimpleList<Land, LandOfferVisuals>
    {
        protected override IEnumerable<Land> GetCollection()
        {
            return Session.Instance.Offers.Keys;
        }

        protected override void ProcessListItem(Land item, LandOfferVisuals newListItem)
        {
            newListItem.Watched = item;
            newListItem.Price = Session.Instance.Offers[item];
        }
    }
}
