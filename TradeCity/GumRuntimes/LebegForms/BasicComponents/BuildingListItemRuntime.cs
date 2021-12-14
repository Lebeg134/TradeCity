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
        UPGRADE
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
            ResourceList.Children.ToList().Clear();
        }
        void UpdateButtonVisual()
        {

        }
        void SetState()
        {
            if (Player.CurrentPlayer.hasStructure(FocusBuilding))
            {
                if (FocusBuilding is CommonBuilding)
                {
                    CommonBuilding focus = (CommonBuilding)FocusBuilding;

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
