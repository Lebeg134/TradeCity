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



namespace JHP4SD.Screens
{
    public partial class GameScreen
    {
        static bool playState = false;
        void CustomInitialize()
        {
            //TODO Persistent PlayButton;

            Forms.BackButtonInstance.Click += BackButtonInstance_Click;

            Forms.ScreenSelectorInstance.CityTab.Click += CityTab_Click;
            Forms.ScreenSelectorInstance.MapTab.Click += MapTab_Click;
            Forms.ScreenSelectorInstance.MarketTab.Click += MarketTab_Click;
        }

        private void CityTab_Click(object sender, EventArgs e)
        {
            MoveToScreen(typeof(CityScreen));
        }

        private void MapTab_Click(object sender, EventArgs e)
        {
            MoveToScreen(typeof(MapScreen));
        }

        private void MarketTab_Click(object sender, EventArgs e)
        {
            MoveToScreen(typeof(MarketScreen));
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

    }
}
