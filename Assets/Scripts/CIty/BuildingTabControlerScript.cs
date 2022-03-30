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
    Branches active = Branches.COMMON;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Switch(Branches tab)
    {
        active = tab;
        
    }

    public void RegisterBuilding(Building building)
    {
        building.getBranch();
    }

    public void RegisterAllBuildings()
    {
        foreach (Building building in Player.CurrentPlayer.getAllBuildings())
        {
            RegisterBuilding(building);
        }
        foreach (Building building in SessionGenerator.GetAllBuildings())
        {
            if (!Player.CurrentPlayer.hasStructure(building))
                RegisterBuilding(building);
        }
    }
}
