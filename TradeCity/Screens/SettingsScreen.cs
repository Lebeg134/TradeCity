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
        static int _resolutionLastSelected = 1;
        static int _windowModeLastSelected = 0;
        static double _currentVolume = 100;

        void CustomInitialize()
        {
            var resolutionComboBox = Forms.ResolutionComboBox;
            resolutionComboBox.Items.Add("2560x1440");
            resolutionComboBox.Items.Add("1920x1080");
            resolutionComboBox.Items.Add("1280x720");
            resolutionComboBox.SelectedIndex = _resolutionLastSelected;
            resolutionComboBox.SelectionChanged += ResolutionComboBox_SelectionChanged;

            var windowModeComboBox = Forms.WindowModeComboBox;
            windowModeComboBox.Items.Add("Windowed");
            windowModeComboBox.Items.Add("Fullscreen");
            windowModeComboBox.SelectedIndex = _windowModeLastSelected;
            windowModeComboBox.SelectionChanged += WindowModeComboBox_SelectionChanged;

            var volumeSlider = Forms.VolumeSliderInstance;
            volumeSlider.Value = _currentVolume;
            volumeSlider.LargeChange = 10;
            volumeSlider.SmallChange = 1;
            Forms.CurrentVolumeLabel.Text = string.Format("{0:0}", _currentVolume);
            volumeSlider.ValueChanged += VolumeSlider_ValueChanged;


            Forms.BackButtonInstance.Click += BackButtonInstance_Click;
        }

        private void VolumeSlider_ValueChanged(object sender, EventArgs e)
        {
            _currentVolume = Forms.VolumeSliderInstance.Value;
            Forms.CurrentVolumeLabel.Text = string.Format("{0:0}", _currentVolume);
        }

        private void WindowModeComboBox_SelectionChanged(object arg1, SelectionChangedEventArgs arg2)
        {
            _windowModeLastSelected = Forms.WindowModeComboBox.SelectedIndex;
        }

        private void ResolutionComboBox_SelectionChanged(object arg1, SelectionChangedEventArgs arg2)
        {
            _resolutionLastSelected = Forms.ResolutionComboBox.SelectedIndex;
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
