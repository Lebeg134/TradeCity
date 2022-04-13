using JHP4SD.Lebeg134.Module.Session;
using JHP4SD.Lebeg134.Module.Structures;
using JHP4SD.Lebeg134.Units.Resources.Common;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LandOfferVisualsScript : MonoBehaviour
{
    public Image sprite;
    public Text buildingName;
    public Button buildButton;
    public GameObject costDisplay;
    [Dropdown("options")]
    public string target;
    string[] options = getOptions();
    public Land watched;
    private static string[] getOptions()
    {
        
        List<string> options = new List<string>();
        foreach (Land land in SessionGenerator.GetAllLands())
        {
            options.Add(land.getName());
        }
        return options.ToArray();
    }

    
    // Start is called before the first frame update
    void Start()
    {
        if (watched == null)
        {
            watched = ConvertStringToLand(target);
        }
        buildingName.text = watched.getName();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    Land ConvertStringToLand(string name)
    {
        foreach (Land land in SessionGenerator.GetAllLands())
        {
            if (land.getName() == name)
                return land;
        }
        return null;
    }
}
