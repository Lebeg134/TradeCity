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

namespace JHP4SD.Screens
{
    public partial class MapScreen
    {
        Camera mainCamera = FlatRedBall.Camera.Main;
        static Dictionary<Land, int> offers = new Dictionary<Land, int>();
        void CustomInitialize()
        {
            LoadPlayerLands();
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
            int i = 0;
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

        }

    }
}
