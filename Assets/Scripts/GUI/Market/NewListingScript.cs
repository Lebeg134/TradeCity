using Lebeg134.Module.Market;
using Lebeg134.Module.MarketNS;
using Lebeg134.Module.Resources;
using Lebeg134.Units.Resources.Common;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class NewListingScript : MonoBehaviour
{
    public Button sellOneButton;
    public Button sellAllButton;
    public Button createListingButton;
    public Dropdown resourceSelector;
    public GameObject valueDisplay;
    public GameObject forDisplay;
    public InputField amountInput;
    public InputField aboveInput;
    // Start is called before the first frame update
    void Start()
    {
        resourceSelector.onValueChanged.AddListener((var) => UpdateResourceDisplay());
        amountInput.onValueChanged.AddListener((var) => UpdateResourceDisplay());
        aboveInput.onValueChanged.AddListener((var) => UpdateResourceDisplay());

        resourceSelector.onValueChanged.AddListener((var) => UpdateButtons());
        amountInput.onValueChanged.AddListener((var) => UpdateButtons());
        aboveInput.onValueChanged.AddListener((var) => UpdateButtons());

        UpdateButtons();
        sellOneButton.onClick.AddListener(() => 
            GetListing(false)?.Complete()
        );
        sellAllButton.onClick.AddListener(() => 
            GetListing(false)?.CompleteAll()
        );
        createListingButton.onClick.AddListener(() =>
            SPMarket.Instance.RegisterListing(GetListing(true))
        );
    }


    // Update is called once per frame
    void Update()
    {
        
    }
    void UpdateButtons()
    {
        bool resValid = resourceSelector.GetComponent<ResourceSelectorScript>().selected != null;
        sellOneButton.interactable = resValid && int.Parse(amountInput.text) > 0;
        sellAllButton.interactable = resValid && int.Parse(amountInput.text) > 0;
        createListingButton.interactable = resValid && int.Parse(amountInput.text) > 0 && int.Parse(aboveInput.text) > 0;
    }
    void UpdateResourceDisplay()
    {
        Resource res = resourceSelector.GetComponent<ResourceSelectorScript>().selected;
        Resource money = new Money(0);
        int amount = 0;
        if (res != null)
        {
            amount = int.Parse(amountInput.text);
            if (amount > 0)
            {
                money = new Money(GetListing(false).GetValue());
                res = res.GetNewResource(amount);
            }
        }
        valueDisplay.GetComponent<ResourceDisplayScript>().Watched = money;
        forDisplay.GetComponent<ResourceDisplayScript>().Watched = res;
    }
    SPListing GetListing(bool autoListing)
    {
        Resource res = resourceSelector.GetComponent<ResourceSelectorScript>().selected;
        int amount = int.Parse(amountInput.text);
        int above = 0;
        if (autoListing)
            int.TryParse(aboveInput.text, out above);
        return new SPListing(res.GetNewResource(amount), above);
    }
}
