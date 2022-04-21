using JHP4SD.Lebeg134.Module.MarketNS;
using JHP4SD.Lebeg134.Module.Resources;
using JHP4SD.Lebeg134.Module.Session;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResourceSelectorScript : MonoBehaviour
{
    public Resource selected;
    public Dropdown dropdown;
    List<string> options = getOptions();
    // Start is called before the first frame update
    void Start()
    {
        dropdown.captionText.text = "Select Resource...";
        dropdown.ClearOptions();
        dropdown.AddOptions(options);
        dropdown.onValueChanged.AddListener((int i) =>
        {
            selected = ResourceDisplayScript.ConvertToRes(options[i]);
            dropdown.captionText.text = selected.getName();
            dropdown.Hide();
        }
        );
    }

    private static List<string> getOptions()
    {
        List<string> options = new List<string>();
        foreach (Resource res in SessionGenerator.GetResourceList())
        {
            if (res is ISellable && res.getName() != "Money")
                options.Add(res.getName());
        }
        return options;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
