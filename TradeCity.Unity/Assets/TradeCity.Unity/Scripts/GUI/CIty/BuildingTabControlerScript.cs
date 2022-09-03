using TradeCity.Engine.Session;
using TradeCity.Engine.Structures;
using TradeCity.Units;
using UnityEngine;
using UnityEngine.UI;

namespace TradeCity.Unity.Scripts.GUI.CIty
{
    public class BuildingTabControlerScript : MonoBehaviour
    {
        public Button commonBranch;
        public Button constructionBranch;
        public Button energyBranch;
        public Button oilBranch;
        public Button workforceBranch;
        public GameObject content;
        public GameObject buildingListItemPrefab;
        Branches active = Branches.Common;
        // Start is called before the first frame update
        void Start()
        {
            commonBranch.onClick.AddListener(() => Switch(Branches.Common));
            constructionBranch.onClick.AddListener(() => Switch(Branches.Construction));
            energyBranch.onClick.AddListener(() => Switch(Branches.Energy));
            oilBranch.onClick.AddListener(() => Switch(Branches.Oil));
            workforceBranch.onClick.AddListener(() => Switch(Branches.Workforce));
            Switch(Branches.Construction);
        }

        // Update is called once per frame
        void Update()
        {

        }

        void Switch(Branches tab)
        {
            GetBranchButton(active).interactable = true;
            GetBranchButton(tab).interactable = false;
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
            listItem.GetComponent<BuildingListItemScript>().building = building.GetName();
            listItem.transform.SetParent(content.transform);
        }

        public void RegisterAllBuildings(Branches branch) //TODO add player checks
        {
            foreach (Building building in Player.CurrentPlayer.GetAllBuildings())
            {
                if (building.GetBranch() == branch)
                    RegisterBuilding(building);
            }
            foreach (Building building in SessionGenerator.GetAllBuildings())
            {
                if (building.GetBranch() == branch && !Player.CurrentPlayer.HasStructure(building))
                    RegisterBuilding(building);
            }
        }
        Button GetBranchButton(Branches branch)
        {
            switch (branch)
            {
                case Branches.Common:
                    return commonBranch;
                case Branches.Construction:
                    return constructionBranch;
                case Branches.Energy:
                    return energyBranch;
                case Branches.Oil:
                    return oilBranch;
                case Branches.Workforce:
                    return workforceBranch;
                default:
                    return null;
            }
        }
    }
}