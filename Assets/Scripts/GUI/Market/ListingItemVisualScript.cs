using Assets.Module.Market;
using JHP4SD.Lebeg134.Module.Market;
using JHP4SD.Lebeg134.Units.Resources.Common;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ListingItemVisualScript : MonoBehaviour
{
    public GameObject ListingSubject;
    public GameObject MoneyDisplay;
    public GameObject AboveDisplay;
    public Button CancelButton;
    public SPListing watched;
    // Start is called before the first frame update
    void Start()
    {
        ListingSubject.GetComponent<ResourceDisplayScript>().watched = watched.Sell;
        MoneyDisplay.GetComponent<ResourceDisplayScript>().watched = new Money(watched.getValue());
        AboveDisplay.GetComponent<ResourceDisplayScript>().watched = watched.Sell.getNewResource(watched.above);

        CancelButton.onClick.AddListener(() => OnClick()); ;
    }

    private void OnClick()
    {
        SPMarket.Instance.RemoveListing(watched);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
