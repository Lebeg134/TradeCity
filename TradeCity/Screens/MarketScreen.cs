using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

using FlatRedBall;
using FlatRedBall.Input;
using FlatRedBall.Instructions;
using FlatRedBall.AI.Pathfinding;
using FlatRedBall.Graphics.Animation;
using FlatRedBall.Graphics.Particle;
using FlatRedBall.Math.Geometry;
using FlatRedBall.Localization;
using JHP4SD.Lebeg134.Module.Market;
using JHP4SD.GumRuntimes.LebegForms.BasicComponents;
using JHP4SD.Lebeg134.Module.Graphics;
using JHP4SD.Lebeg134.Module.Session;
using JHP4SD.Lebeg134.Module.Resources;
using JHP4SD.Lebeg134.Module.MarketNS;
using JHP4SD.Lebeg134.Units.Resources.Common;
using JHP4SD.GumRuntimes.DefaultForms;

namespace JHP4SD.Screens
{
    public partial class MarketScreen: IUpdateable
    {
        static List<SPListing> listings = new List<SPListing>();
        void CustomInitialize()
        {
            RefreshListingsList();
            InitCombobox();
        }

        void CustomActivity(bool firstTimeCalled)
        {


        }

        void CustomDestroy()
        {


        }

        static void CustomLoadStaticContent(string contentManagerName)
        {


        }

        void InitCombobox()
        {
            foreach (Resource resource in Player.CurrentPlayer.getAllRes())
            {
                
                if (resource is ISellable)
                {
                    if (resource is Money) continue;
                    ListBoxItemRuntime visualItem = new ListBoxItemRuntime();
                    visualItem.TextInstance.Text = resource.getName();
                    var listBoxItem = visualItem.FormsControl;
                    listBoxItem.UpdateToObject(resource);
                    Forms.ComboBoxInstance.Items.Add(listBoxItem);
                }
            }
        }
        void RefreshListingsList()
        {
            foreach(SPListing listing in listings)
            {
                var visualItem = new ListingListBoxItemRuntime();
                visualItem.Focus = listing;
                visualItem.register();
                visualItem.ButtonInstance.Click += (FlatRedBall.Gui.IWindow window) =>
                {
                    listings.Remove(listing);
                    RefreshListingsList();
                };
                var listBoxItem = visualItem.FormsControl;
                listBoxItem.UpdateToObject(listing.Sell.getName());
                Forms.MyListingsList.Items.Add(listBoxItem);
            }
        }
        bool AreSellFieldsValid()
        {
            bool valid = true;
            valid = valid && Forms.ComboBoxInstance.SelectedObject != null;


            return valid;
        }
        bool AreListingFieldsValid()
        {
            bool valid = true;


            return valid && AreSellFieldsValid();
        }
        public void Update()
        {
            
        }
    }
}
