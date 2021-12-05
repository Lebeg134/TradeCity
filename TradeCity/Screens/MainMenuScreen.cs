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

namespace JHP4SD.Screens
{
    public partial class MainMenuScreen
    {

        void CustomInitialize()
        {
            Forms.NewGameButton.Click += NewGameButton_Click;
            Forms.MultiplayerButton.IsEnabled = false;
            Forms.LoadGameButton.IsEnabled = false;
            Forms.SettingsButton.Click += SettingsButton_Click;
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            MoveToScreen(typeof(SettingsScreen));
        }

        private void NewGameButton_Click(object sender, EventArgs e)
        {
            MoveToScreen(typeof(CityScreen));
            Session session = new Session();
            session.start();
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
