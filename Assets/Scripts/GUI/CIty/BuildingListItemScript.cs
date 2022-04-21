using JHP4SD.Lebeg134.Module.Resources;
using JHP4SD.Lebeg134.Module.Session;
using JHP4SD.Lebeg134.Module.Structures;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuildingListItemScript : MonoBehaviour
{
    public enum ButtonState
    {
        BUILD,
        UPGRADE,
        MAXLEVEL
    }
    string[] options = getOptions();
    [Dropdown("options")]
    public string building;
    public Image buildingImage;
    public Text buildingName;
    public Button buildButton;
    public Text levelText;
    public HorizontalLayoutGroup costsList;
    public GameObject CostDisplayPrefab;
    Building target;
    ButtonState btnState = ButtonState.BUILD;
    
    // Start is called before the first frame update
    void Start()
    {
        target = ConvertToBuilding(building);
        buildingName.text = target.getName();

        var loadedSprite = Resources.Load<Sprite>(target.GetResourcepath());
        if (loadedSprite != null)
            buildingImage.sprite = loadedSprite;

        levelText.text = "Lvl:" + ((CommonBuilding)target).getLevel();

        UpdateCostDisplay();
        buildButton.onClick.AddListener(() => OnClick());
    }

    // Update is called once per frame
    void Update()
    {
        UpdateButton();
        if (target == null) return;
        UpdateState();
    }

    private void OnClick()
    {
        switch (btnState)
        {
            case ButtonState.BUILD:
                target.Build(Player.CurrentPlayer);
                break;
            case ButtonState.UPGRADE:
                if (Player.CurrentPlayer.hasStructure(target))
                {
                    if (target is CommonBuilding)
                    {
                        ((CommonBuilding)target).levelUp();
                    }
                }
                break;
            case ButtonState.MAXLEVEL:
                //Do nothing
                break;
        }
        if (target is CommonBuilding)
        {
            levelText.text = "Lvl:" + ((CommonBuilding)target).getLevel();
        }
        UpdateState();
        UpdateButton();
        UpdateCostDisplay();
    }

    private void UpdateState()
    {
        if (target.CanBeBuilt(Player.CurrentPlayer))
        {
            btnState= ButtonState.BUILD;
            if (target is CommonBuilding)
            {
                CommonBuilding focus = (CommonBuilding)target;
                if (focus.IsMaxLevel())
                {
                    btnState = ButtonState.MAXLEVEL;
                }
                else if (focus.getLevel() > 0)
                {
                    btnState = ButtonState.UPGRADE;
                }
            }
        }
        
    }
    private void UpdateButton()
    {
        buildButton.interactable = target.CanBeBuilt(Player.CurrentPlayer);
        if (btnState == ButtonState.MAXLEVEL)
        {
            buildButton.interactable = false;
        }
        switch (btnState)
        {
            case ButtonState.BUILD:
                buildButton.GetComponentInChildren<Text>().text = "Build";
                break;
            case ButtonState.UPGRADE:
                buildButton.GetComponentInChildren<Text>().text = "Upgrade";
                break;
            case ButtonState.MAXLEVEL:
                buildButton.GetComponentInChildren<Text>().text = "Maxed";
                break;
        }
    }
    private void UpdateCostDisplay()
    {
        foreach (Transform child in costsList.transform)
        {
            Destroy(child.gameObject);
        }
        foreach (Resource res in target.Cost())
        {
            GameObject listItem = Instantiate(CostDisplayPrefab);
            listItem.GetComponent<ResourceDisplayScript>().watched = res;
            listItem.transform.SetParent(costsList.transform);
        }
    }

    static string[] getOptions()
    {
        List<Building> buildingList = SessionGenerator.GetAllBuildings();
        List<string> strlist = new List<string>();
        foreach (Building building in buildingList)
        {
            strlist.Add(building.getName());
        }
        return strlist.ToArray();
    }
    static Building ConvertToBuilding(string name)
    {
        foreach (Building building in SessionGenerator.GetAllBuildings())
        {
            if (building.getName() == name)
                return building;
        }
        return null;
    }
}
