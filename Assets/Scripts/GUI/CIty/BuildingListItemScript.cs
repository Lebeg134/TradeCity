using JHP4SD.Lebeg134.Module.Resources;
using JHP4SD.Lebeg134.Module.Session;
using JHP4SD.Lebeg134.Module.Structures;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuildingListItemScript : MonoBehaviour
{
    string[] options = getOptions();
    [Dropdown("options")]
    public string building;
    public Text buildingName;
    public HorizontalLayoutGroup costsList;
    public GameObject CostDisplayPrefab;
    Building target;
    
    // Start is called before the first frame update
    void Start()
    {
        target = ConvertToBuilding(building);
        buildingName.text = target.getName();

        foreach (Resource res in target.Cost())
        {
            GameObject listItem = Instantiate(CostDisplayPrefab);
            listItem.GetComponent<ResourceDisplayScript>().resource = res.getName();
            listItem.transform.SetParent(costsList.transform);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
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
