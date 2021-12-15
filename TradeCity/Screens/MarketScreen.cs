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
        List<Resource> selections;
        Resource selection;
        void CustomInitialize()
        {
            RefreshListingsList();
            InitCombobox();
            Update();
            Forms.SellOneButtonInstance.Click += SellOneButtonInstance_Click;
            Forms.SellAllButtonInstance.Click += SellAllButtonInstance_Click;
            Forms.AutoSellButtonInstance.Click += AutoSellButtonInstance_Click;
            Forms.ComboBoxInstance.SelectionChanged += ComboBoxInstance_SelectionChanged;
            Forms.ToSellAmountTextBoxInstance.TextChanged += TextChanged;
            Forms.AutoSellAmountTextBoxInstance.TextChanged += TextChanged;
        }

        private void TextChanged(object sender, EventArgs e)
        {
            UpdateButtons();
        }

        private void ComboBoxInstance_SelectionChanged(object arg1, FlatRedBall.Forms.Controls.SelectionChangedEventArgs arg2)
        {
            Console.WriteLine(Forms.ComboBoxInstance.SelectedIndex);
            selection = selections[Forms.ComboBoxInstance.SelectedIndex];
            UpdateButtons();
        }

        private void SellOneButtonInstance_Click(object sender, EventArgs e)
        {
            GetListing(true)?.Complete();
            Resource.updater.Update();
        }

        private void SellAllButtonInstance_Click(object sender, EventArgs e)
        {
            GetListing(true)?.completeAll();
            Resource.updater.Update();
        }

        private void AutoSellButtonInstance_Click(object sender, EventArgs e)
        {
            if (AreListingFieldsValid())
            {
                SPListing newListing = GetListing();
                listings.Add(newListing);
                newListing.register();
                RefreshListingsList();
            }
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
            selections = new List<Resource>();
            foreach (Resource resource in Player.CurrentPlayer.getAllRes())
            {
                if (resource is ISellable)
                {
                    if (resource is Money) continue;
                    selections.Add(resource);
                    var visualItem = new ResourceListItemSmallRuntime();
                    visualItem.Focus = resource;
                    var listBoxItem = visualItem.FormsControl;
                    listBoxItem.UpdateToObject(resource.ToString());
                    Forms.ComboBoxInstance.Items.Add(listBoxItem);
                    visualItem.TextInstance.Text = resource.getName();
                    
                }
            }
        }
        void RefreshListingsList()
        {
            Forms.MyListingsList.Items.Clear();
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
            Console.WriteLine(Forms.ComboBoxInstance.SelectedObject?.ToString());
        }
        void UpdateButtons()
        {
            int amount = 0;
            var resource = Forms.ComboBoxInstance.SelectedObject;
            if (int.TryParse(Forms.ToSellAmountTextBoxInstance.Text, out amount) && amount > 0 && resource != null)
            {
                Forms.SellOneButtonInstance.IsEnabled = true;
                Forms.SellAllButtonInstance.IsEnabled = true;
                if (int.TryParse(Forms.AutoSellAmountTextBoxInstance.Text, out int i))
                    Forms.AutoSellButtonInstance.IsEnabled = true;
                else
                    Forms.AutoSellButtonInstance.IsEnabled = false;
            }
            else
            {
                Forms.SellOneButtonInstance.IsEnabled = false;
                Forms.SellAllButtonInstance.IsEnabled = false;
                Forms.AutoSellButtonInstance.IsEnabled = false;
            }
        }
        SPListing GetListing(bool all = false)
        {
            if (!AreSellFieldsValid()) return null;
            int amount = 1;
            int.TryParse(Forms.ToSellAmountTextBoxInstance.Text, out amount);
            Resource resource = selection.getNewResource(amount);
            if (!AreListingFieldsValid() || all) return new SPListing(resource, 0);
            int above = 1000;
            int.TryParse(Forms.AutoSellAmountTextBoxInstance.Text, out above);
            return new SPListing(resource, above);
        }
    }
}
