using FlatRedBall.Forms.Controls;
using JHP4SD.Lebeg134.Module.Session;
using JHP4SD.Lebeg134.Module.Structures;
using System;
using System.Collections.Generic;
using System.Linq;

namespace JHP4SD.FormsControls.Components.LebegForms.ComplexComponents
{
    public partial class TabMenuForms
    {
        private int selected = 0;
        List<Button> tabButtons;
        List<ListBox> tabLists;
        partial void CustomInitialize () 
        {
            tabButtons = new List<Button> { CommonTab, ConstructionTab, EnergyTab, OilTab, WorkforceTab };
            tabLists = new List<ListBox> { CommonList, ConstructionList, EnergyList, OilList, WorkforceList };
            CommonTab.Click += CommonTab_Click;
            ConstructionTab.Click += ConstructionTab_Click;
            EnergyTab.Click += EnergyTab_Click;
            OilTab.Click += OilTab_Click;
            WorkforceTab.Click += WorkforceTab_Click;

            
            RefreshActiveTab();
        }
        private void CommonTab_Click(object sender, EventArgs e)
        {
            selected = 0;
            RefreshActiveTab();
        }
        private void ConstructionTab_Click(object sender, EventArgs e)
        {
            selected = 1;
            RefreshActiveTab();
        }
        private void EnergyTab_Click(object sender, EventArgs e)
        {
            selected = 2;
            RefreshActiveTab();
        }
        private void OilTab_Click(object sender, EventArgs e)
        {
            selected = 3;
            RefreshActiveTab();
        }
        private void WorkforceTab_Click(object sender, EventArgs e)
        {
            selected = 4;
            RefreshActiveTab();
        }
        private void RefreshActiveTab()
        {
            for (int i = 0; i < tabButtons.Count; i++)
            {
                tabButtons[i].IsEnabled = (i != selected);
            }
            for (int i = 0; i < tabLists.Count; i++)
            {
                tabLists[i].IsVisible = (i == selected);
            }
        }

        public void RegisterBuilding(Building building)
        {
            if (building == null)
                return;
            var visualItem = new GumRuntimes.LebegForms.BasicComponents.BuildingListItemRuntime();
            visualItem.FocusBuilding = building;
            visualItem.register();
            var listBoxItem = visualItem.FormsControl;
            listBoxItem.UpdateToObject(building.getName());
            tabLists[(int)building.getBranch()].Items.Add(listBoxItem);
        }


        public void RegisterAllBuildings()
        {
            foreach (Building building in Player.CurrentPlayer.getAllBuildings())
            {
                RegisterBuilding(building);
            }
            foreach (Building building in SessionGenerator.GetAllBuildings())
            {
                if(!Player.CurrentPlayer.hasStructure(building))
                    RegisterBuilding(building);
            }
        }
    }
}
