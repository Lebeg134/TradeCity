using JHP4SD.Lebeg134.Module.Graphics;
using JHP4SD.Lebeg134.Module.Resources;
using JHP4SD.Lebeg134.Module.Session;
using JHP4SD.Lebeg134.Module.Structures;
using System;
using System.Collections.Generic;
using System.Linq;

namespace JHP4SD.GumRuntimes.LebegForms.BasicComponents
{
    public enum BuildingListItemButtonState
    {
        OFF,
        BUILD,
        BUILDOFF,
        UPGRADE,
        UPGRADEOFF,
        MAXLEVEL
    }
    public partial class BuildingListItemRuntime: IUpdateable
    {
        public Building FocusBuilding { get; set; }

        BuildingListItemButtonState state = BuildingListItemButtonState.OFF;
        partial void CustomInitialize () 
        {
            BuildButton.Click += BuildButton_Click;
        }

        private void BuildButton_Click(FlatRedBall.Gui.IWindow window)
        {
            Console.WriteLine("Button pressed"); //DEBUG
            if (Player.CurrentPlayer.hasStructure(FocusBuilding))
            {
                Console.WriteLine("Had it"); //DEBUG
                if (FocusBuilding is CommonBuilding)
                {
                    ((CommonBuilding)FocusBuilding).levelUp();
                }
            }
            else
            {
                Console.WriteLine("Didn't have it"); //DEBUG
                try
                {
                    FocusBuilding.Build(Player.CurrentPlayer);
                    BuildButton.Text = "Upgrade";
                }
                catch (NotEnoughResourceException e)
                {

                }
               
               
                
            }
        }

        public void Update()
        {
            SetState();
            ResourceList.Children.ToList().Clear();
            UpdateButtonVisual();
        }
        void UpdateButtonVisual()
        {
            BuildButton.Enabled = true;
            switch (state)
            {
                case BuildingListItemButtonState.BUILDOFF:
                    BuildButton.Text = "Build";
                    BuildButton.Enabled = false;
                    break;
                case BuildingListItemButtonState.BUILD:
                    BuildButton.Text = "Build";
                    break;
                case BuildingListItemButtonState.UPGRADEOFF:
                    BuildButton.Text = "Upgrade";
                    BuildButton.Enabled = false;
                    break;
                case BuildingListItemButtonState.UPGRADE:
                    BuildButton.Text = "Upgrade";
                    break;
                case BuildingListItemButtonState.MAXLEVEL:
                    BuildButton.Text = "Max level";
                    BuildButton.Enabled = false;
                    break;
                default:
                    BuildButton.Enabled = false;
                    break;
            }
        }
        void SetState()
        {
            if (Player.CurrentPlayer.hasStructure(FocusBuilding))
            {
                if (FocusBuilding is CommonBuilding)
                {
                    CommonBuilding focus = (CommonBuilding)FocusBuilding;
                    if (focus.checkLevelUp())
                    {
                        state = BuildingListItemButtonState.UPGRADE;
                    }
                    else
                        state = BuildingListItemButtonState.OFF;
                }
                else
                {
                    state = BuildingListItemButtonState.OFF;
                }
            }
            else if(FocusBuilding.CanBeBuilt(Player.CurrentPlayer))
            {
                state = BuildingListItemButtonState.BUILD;
            }
            else
                state = BuildingListItemButtonState.OFF;

        }
    }
}
