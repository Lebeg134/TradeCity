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
using System.IO;

namespace JHP4SD.Screens
{
    public partial class MainMenuScreen
    {

        void CustomInitialize()
        {
            Forms.MultiplayerButton.IsEnabled = false;
            Forms.NewGameButton.Click += NewGameButton_Click;
            Forms.SettingsButton.Click += SettingsButton_Click;
            Forms.LoadGameButton.Click += LoadGameButton_Click;
            Forms.LoadGameButton.IsEnabled = File.Exists(Session.Filename);

        }

        private void LoadGameButton_Click(object sender, EventArgs e)
        {
            try
            {
                Session.load();
                MoveToScreen(typeof(CityScreen));
                Session.Instance.start();
            }
            catch (Exception)
            {
                Forms.LoadGameButton.IsEnabled = false;
            }
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            MoveToScreen(typeof(SettingsScreen));
        }

        private void NewGameButton_Click(object sender, EventArgs e)
        {
            MoveToScreen(typeof(CityScreen));
            Session session = SessionGenerator.GenerateStandard();
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
