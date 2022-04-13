using JHP4SD.Lebeg134.Module.Session;
using JHP4SD.Lebeg134.Module.Structures;
using JHP4SD.Lebeg134.Units.Resources.Common;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AvailableLandsListScript : MonoBehaviour
{
    public GameObject listItem;
    public GameObject Content;
    // Start is called before the first frame update
    void Start()
    {
        Dictionary<Land, int> offers = Session.Instance.offers;
        foreach (Land landOffer in offers.Keys)
        {
            GameObject landOfferItem = Instantiate(listItem);
            landOfferItem.GetComponent<LandOfferVisualsScript>().watched = landOffer;
            landOfferItem.GetComponent<LandOfferVisualsScript>().costDisplay.GetComponent<ResourceDisplayScript>().watched = new Money(offers[landOffer]);
            landOfferItem.transform.SetParent(Content.transform);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
