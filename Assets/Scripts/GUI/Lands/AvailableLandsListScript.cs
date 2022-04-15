using JHP4SD.Lebeg134.Module.Session;
using JHP4SD.Lebeg134.Module.Structures;
using JHP4SD.Lebeg134.Units.Resources.Common;
using Lebeg134.Structures.Lands;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AvailableLandsListScript : ListScript<Land>
{
    protected override ICollection<Land> GetCollection()
    {
        return new List<Land>() { new Forest(), new ClearwaterLake() };
        //return Session.Instance.offers.Keys;
    }

    protected override void ProcessListItem(Land item, ref GameObject newListItem)
    {
        newListItem.GetComponent<LandOfferVisualsScript>().watched = item;
        newListItem.GetComponent<LandOfferVisualsScript>().price = 100;
    }
}


//public class AvailableLandsListScript : MonoBehaviour
//{
//    public GameObject listItem;
//    public GameObject Content;
//    // Start is called before the first frame update
//    void Start()
//    {
//        Dictionary<Land, int> offers = Session.Instance.offers;
//        foreach (Land landOffer in offers.Keys)
//        {
//            GameObject landOfferItem = Instantiate(listItem);
//            landOfferItem.GetComponent<LandOfferVisualsScript>().watched = landOffer;
//            landOfferItem.GetComponent<LandOfferVisualsScript>().price = offers[landOffer];
//            landOfferItem.transform.SetParent(Content.transform);
//        }
//    }
//    public void Refresh()
//    {
//        foreach (Transform child in Content.transform)
//        {
//            Destroy(child.gameObject);
//        }
//        Start();
//    }
//    // Update is called once per frame
//    void Update()
//    {

//    }
//}
