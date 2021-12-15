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
using Microsoft.Xna.Framework.Input;
using JHP4SD.Lebeg134.Module.Session;
using Lebeg134.Structures.Lands;
using JHP4SD.Lebeg134.Module.Structures;
using JHP4SD.GumRuntimes.LebegForms.BasicComponents;
using JHP4SD.Lebeg134.Module.Resources;
using JHP4SD.Lebeg134.Module.Graphics;
using JHP4SD.GumRuntimes.LebegForms.Resources;

namespace JHP4SD.Screens
{
    public partial class MapScreen : IUpdateable
    {
        Camera mainCamera = FlatRedBall.Camera.Main;
        void CustomInitialize()
        {
            Land.spriteLibrary = new LandImagesRuntime();
            Land.landUpdater.Register(this);
            Resource.updater.Register(this);
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

        void LoadPlayerLands()
        {
            Forms.OwnedLands.Items.Clear();
            foreach (Land land in Player.CurrentPlayer.GetLands())
            {
                var visualItem = new OwnedLandListItemRuntime();
                visualItem.Focus = land;
                visualItem.Init();
                var listBoxItem = visualItem.FormsControl;
                listBoxItem.UpdateToObject(land.getName());
                Forms.OwnedLands.Items.Add(listBoxItem);
            }
        }
        void LoadOffers()
        {
            Dictionary<Land, int> offers = Session.Instance.offers;
            Forms.BuyableLands.Items.Clear();
            foreach (Land land in offers.Keys)
            {
                var visualItem = new LandListItemRuntime();
                visualItem.Focus = land;
                visualItem.Price = offers[land];
                visualItem.Init();
                visualItem.register();
                var listBoxItem = visualItem.FormsControl;
                listBoxItem.UpdateToObject(land.getName());
                Forms.BuyableLands.Items.Add(listBoxItem);
            }
        }

        public void Update()
        {
            LoadPlayerLands();
            LoadOffers();
        }
    }
}
