using JHP4SD.Lebeg134.Module.Session;
using JHP4SD.Lebeg134.Module.Structures;
using JHP4SD.Lebeg134.Units;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuildingTabControlerScript : MonoBehaviour
{
    public Button commonBranch;
    public Button constructionBranch;
    public Button energyBranch;
    public Button oilBranch;
    public Button workforceBranch;
    public GameObject content;
    public GameObject buildingListItemPrefab;
    Branches active = Branches.COMMON;
    // Start is called before the first frame update
    void Start()
    {
        commonBranch.onClick.AddListener(() => Switch(Branches.COMMON));
        constructionBranch.onClick.AddListener(() => Switch(Branches.CONSTRUCTION));
        energyBranch.onClick.AddListener(() => Switch(Branches.ENERGY));
        oilBranch.onClick.AddListener(() => Switch(Branches.OIL));
        workforceBranch.onClick.AddListener(() => Switch(Branches.WORKFORCE));
        Switch(Branches.CONSTRUCTION);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Switch(Branches tab)
    {
        getBranchButton(active).interactable = true;
        getBranchButton(tab).interactable = false;
        active = tab;
        for (int i = 0; i < content.transform.childCount; i++)
        {
            Destroy(content.transform.GetChild(i).gameObject);
        }
        RegisterAllBuildings(tab);
    }
    public void RegisterBuilding(Building building)
    {
        GameObject listItem = Instantiate(buildingListItemPrefab);
        listItem.GetComponent<BuildingListItemScript>().building = building.getName();
        listItem.transform.SetParent(content.transform);
    }

    public void RegisterAllBuildings(Branches branch) //TODO add player checks
    {
        //foreach (Building building in Player.CurrentPlayer.getAllBuildings())
        //{
        //    if (building.getBranch()==branch)
        //        RegisterBuilding(building);
        //}
        foreach (Building building in SessionGenerator.GetAllBuildings())
        {
            if (building.getBranch() == branch)
                RegisterBuilding(building);
        }
    }
    Button getBranchButton(Branches branch)
    {
        switch (branch)
        {
            case Branches.COMMON:
                return commonBranch;
            case Branches.CONSTRUCTION:
                return constructionBranch;
            case Branches.ENERGY:
                return energyBranch;
            case Branches.OIL:
                return oilBranch;
            case Branches.WORKFORCE:
                return workforceBranch;
            default:
                return null;
        }
    }
}