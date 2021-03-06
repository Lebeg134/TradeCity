using Lebeg134.Module.Session;
using Lebeg134.Module.Structures;
using System.Collections.Generic;
using UnityEngine;

public class AvailableLandsListScript : ListScript<Land>
{
    protected override ICollection<Land> GetCollection()
    {
        return Session.Instance.offers.Keys;
    }

    protected override void ProcessListItem(Land item, GameObject newListItem)
    {
        newListItem.GetComponent<LandOfferVisualsScript>().watched = item;
        newListItem.GetComponent<LandOfferVisualsScript>().price = Session.Instance.offers[item];
    }
}
