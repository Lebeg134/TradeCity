using JHP4SD.Lebeg134.Module.Resources;
using JHP4SD.Lebeg134.Module.Session;
using JHP4SD.Lebeg134.Module.Structures;
using System;
using System.Collections.Generic;
using System.Linq;

namespace JHP4SD.GumRuntimes.LebegForms.BasicComponents
{
    public partial class BuildingListItemRuntime
    {
        public Building FocusBuilding { get; set; }


        partial void CustomInitialize () 
        {
            BuildButton.Click += BuildButton_Click;
            if (Player.CurrentPlayer.hasStructure(FocusBuilding))
            {
                BuildButton.Text = "Upgrade";
            }
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
                }
                catch (NotEnoughResourceException e)
                {

                }
               
               
                
            }
        }
    }
}
