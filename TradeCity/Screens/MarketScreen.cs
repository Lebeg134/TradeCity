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
    public partial class MarketScreen : IUpdateable
    {
        static List<SPListing> listings = new List<SPListing>();
        void CustomInitialize()
        {
            RefreshListingsList();
            InitCombobox();
            Update();
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
                    var listBoxItem = visualItem.FormsControl;
                    listBoxItem.UpdateToObject(resource);
                    visualItem.TextInstance.Text = resource.getName();
                    Forms.ComboBoxInstance.Items.Add(listBoxItem);
                }
            }
        }
        void RefreshListingsList()
        {
            foreach (SPListing listing in listings)
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
            return Forms.ComboBoxInstance.SelectedObject != null
                && int.TryParse(Forms.ToSellAmountTextBoxInstance.Text, out int i);
        }
        bool AreListingFieldsValid()
        {
            return int.TryParse(Forms.AutoSellAmountTextBoxInstance.Text, out int i) && AreSellFieldsValid();
        }
        public void Update()
        {
            UpdateButtons();
        }
        void UpdateButtons()
        {
            int amount = 0;
            Resource resource = (Resource)Forms.ComboBoxInstance.SelectedObject;
            if (int.TryParse(Forms.ToSellAmountTextBoxInstance.Text, out amount)&& amount > 0 &&resource!=null)
            {
                Forms.SellAllButtonInstance.IsEnabled = true;
                Forms.SellAllButtonInstance.IsEnabled = true;
                if(int.TryParse(Forms.AutoSellAmountTextBoxInstance.Text, out int i))
                    Forms.AutoSellButtonInstance.IsEnabled = true;
                else
                    Forms.AutoSellButtonInstance.IsEnabled = false;
            }
            else
            {
                Forms.SellAllButtonInstance.IsEnabled = false;
                Forms.SellAllButtonInstance.IsEnabled = false;
                Forms.AutoSellButtonInstance.IsEnabled = false;
            }
        }
    }
}
