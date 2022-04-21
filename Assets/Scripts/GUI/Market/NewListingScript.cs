using Assets.Module.Market;
using JHP4SD.Lebeg134.Module.Market;
using JHP4SD.Lebeg134.Module.Resources;
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
    public InputField amountInput;
    public InputField aboveInput;
    // Start is called before the first frame update
    void Start()
    {
        resourceSelector.onValueChanged.AddListener((var) => UpdateButtons());
        amountInput.onValueChanged.AddListener((var) => UpdateButtons());
        aboveInput.onValueChanged.AddListener((var) => UpdateButtons());

        UpdateButtons();
        sellOneButton.onClick.AddListener(() => 
            GetListing(false)?.Complete()
        );
        sellAllButton.onClick.AddListener(() => 
            GetListing(false)?.completeAll()
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
    SPListing GetListing(bool autoListing)
    {
        Resource res = resourceSelector.GetComponent<ResourceSelectorScript>().selected;
        int amount = int.Parse(amountInput.text);
        int above = 0;
        if (autoListing)
            int.TryParse(aboveInput.text, out above);
        return new SPListing(res.getNewResource(amount), above);
    }
}
