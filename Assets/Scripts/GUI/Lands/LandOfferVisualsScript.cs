using Lebeg134.Module.Session;
using Lebeg134.Module.Structures;
using Lebeg134.Units.Resources.Common;
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
    public int price =1000;
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
        costDisplay.GetComponent<ResourceDisplayScript>().watched = new Money(price);

        var loadedSprite = Resources.Load<Sprite>(watched.GetResourcepath());
        if (loadedSprite != null)
            sprite.sprite = loadedSprite;

        buildButton.onClick.AddListener(() => OnClick());
        
    }

    private void OnClick()
    {
        if (Player.CurrentPlayer.checkResource(new Money(price)))
        {
            Player.CurrentPlayer.subRes(new Money(price));
            Player.CurrentPlayer.giveStructure(watched);
            Session.Instance.offers.Remove(watched);
            int newPrice = price * 2;
            Session.Instance.offers.Add(watched.GetNew(), newPrice);
            gameObject.GetComponentInParent<AvailableLandsListScript>().Refresh();
            gameObject.GetComponentInParent<VisualUpdater>().VisualUpdate();
        }
    }

    // Update is called once per frame
    void Update()
    {
        buildButton.interactable = Player.CurrentPlayer.checkResource(new Money(price));
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
