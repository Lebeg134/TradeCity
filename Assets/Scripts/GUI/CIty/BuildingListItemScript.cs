using Lebeg134.Module.Resources;
using Lebeg134.Module.Session;
using Lebeg134.Module.Structures;
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
    string[] options = GetOptions();
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
        buildingName.text = target.GetName();

        var loadedSprite = Resources.Load<Sprite>(target.GetResourcepath());
        if (loadedSprite != null)
            buildingImage.sprite = loadedSprite;

        if (target is CommonBuilding)
            levelText.text = "Lvl:" + ((CommonBuilding)target).REPLACEMEGetLevel();

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
                if (Player.CurrentPlayer.HasStructure(target))
                {
                    if (target is CommonBuilding)
                    {
                        ((CommonBuilding)target).LevelUp();
                    }
                }
                break;
            case ButtonState.MAXLEVEL:
                //Do nothing
                break;
        }
        if (target is CommonBuilding)
        {
            levelText.text = "Lvl:" + ((CommonBuilding)target).REPLACEMEGetLevel();
        }
        UpdateState();
        UpdateButton();
        UpdateCostDisplay();
    }

    private void UpdateState()
    {
        btnState = ButtonState.BUILD;
        if (target is CommonBuilding)
        {
            CommonBuilding focus = (CommonBuilding)target;
            if (focus.IsMaxLevel())
            {
                btnState = ButtonState.MAXLEVEL;
            }
            else if (focus.REPLACEMEGetLevel() > 0)
            {
                btnState = ButtonState.UPGRADE;
            }
        }
    }
    private void UpdateButton()
    {
        switch (btnState)
        {
            case ButtonState.BUILD:
                buildButton.GetComponentInChildren<Text>().text = "Build";
                buildButton.interactable = target.CanBuild(Player.CurrentPlayer);
                break;
            case ButtonState.UPGRADE:
                buildButton.GetComponentInChildren<Text>().text = "Upgrade";
                buildButton.interactable = target.CanBuild(Player.CurrentPlayer);
                break;
            case ButtonState.MAXLEVEL:
                buildButton.GetComponentInChildren<Text>().text = "Maxed";
                buildButton.interactable = false;
                break;
        }
        buildButton.Select();
    }
    private void UpdateCostDisplay()
    {
        foreach (Transform child in costsList.transform)
        {
            Destroy(child.gameObject);
        }
        foreach (Resource res in target.GetCost())
        {
            GameObject listItem = Instantiate(CostDisplayPrefab);
            listItem.GetComponent<ResourceDisplayScript>().Watched = res;
            listItem.transform.SetParent(costsList.transform);
        }
    }

    static string[] GetOptions()
    {
        List<Building> buildingList = SessionGenerator.GetAllBuildings();
        List<string> strlist = new List<string>();
        foreach (Building building in buildingList)
        {
            strlist.Add(building.GetName());
        }
        return strlist.ToArray();
    }
    static Building ConvertToBuilding(string name)
    {
        foreach (Building building in SessionGenerator.GetAllBuildings())
        {
            if (building.GetName() == name)
                return building;
        }
        return null;
    }
}
