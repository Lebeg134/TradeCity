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
using JHP4SD.Lebeg134.Module.Session;
using Lebeg134.Resources.Workforce;
using JHP4SD.Lebeg134.Units.Resources.Common;
using Lebeg134.Resources.EnergySector;
using Lebeg134.Resources.Common;
using JHP4SD.Lebeg134.Module.TimeManager;
using Lebeg134.Structures.Lands;
using JHP4SD.Lebeg134.Module.Resources;
using JHP4SD.GumRuntimes.LebegForms.BasicComponents;

namespace JHP4SD.Screens
{
    public partial class GameScreen
    {
        void CustomInitialize()
        {
            Resource.spriteLibrary = new GumRuntimes.LebegForms.Resources.ResourceIconsRuntime();
            if (Session.Instance.Running)
                Clock.Instance.start();
            Forms.PlayButtonInstance.IsChecked = Clock.Instance.isEnabled();
            Forms.PlayButtonInstance.Click += PlayButtonInstance_Click;

            Forms.BackButtonInstance.Click += BackButtonInstance_Click;

            Forms.ScreenSelectorInstance.CityTab.Click += CityTab_Click;
            Forms.ScreenSelectorInstance.MapTab.Click += MapTab_Click;
            Forms.ScreenSelectorInstance.MarketTab.Click += MarketTab_Click;


            foreach (Resource resource in Player.CurrentPlayer.getAllRes())
            {
                AddToList(resource);
            }
        }

        private void PlayButtonInstance_Click(object sender, EventArgs e)
        {
            if (Forms.PlayButtonInstance.IsChecked?? false)
            {
                Clock.Instance.start();
                Session.Instance.Running = true;
            }
            else
            {
                Clock.Instance.pause();
                Session.Instance.Running = false;
            }
            Resource.updater.Update();
        }

        private void CityTab_Click(object sender, EventArgs e)
        {
            MoveToScreen(typeof(CityScreen));
            Clock.Instance.pause();
        }

        private void MapTab_Click(object sender, EventArgs e)
        {
            MoveToScreen(typeof(MapScreen));
            Clock.Instance.pause();
        }

        private void MarketTab_Click(object sender, EventArgs e)
        {
            MoveToScreen(typeof(MarketScreen));
            Clock.Instance.pause();
        }

        private void BackButtonInstance_Click(object sender, EventArgs e)
        {
            MoveToScreen(typeof(MainMenuScreen));
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

        void AddToList(Resource resource)
        {
            var visualItem = new ResourceListItemRuntime();
            visualItem.Focus = resource;
            Resource.updater.Register(visualItem.ResourceDisplayInstance);
            var listBoxItem = visualItem.FormsControl;
            listBoxItem.UpdateToObject(resource.getName());
            Forms.ResourceList.Items.Add(listBoxItem);
        }
    }
}
