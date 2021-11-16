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
using FlatRedBall.Forms.Controls;

namespace JHP4SD.Screens
{
    public partial class SettingsScreen
    {
        static int _lastSelected = 1;
        
        void CustomInitialize()
        {
            var comboBox = Forms.ComboBoxInstance;
            comboBox.Items.Add("Option1");
            comboBox.Items.Add("Option2");
            comboBox.Items.Add("Option3");


            Forms.BackButtonInstance.Click += BackButtonInstance_Click;
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
