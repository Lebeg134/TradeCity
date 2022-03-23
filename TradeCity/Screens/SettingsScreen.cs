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
    struct SliderInfo
    {
    
        public double lastSelected { get; set; }
        public Label displayLabel { get; set; }
        public SliderInfo(double parLastSelected, Label parDisplayLabel)
        {
            lastSelected = parLastSelected;
            displayLabel = parDisplayLabel;
        }
    }
    public partial class SettingsScreen
    {
        static int _resolutionLastSelected = 1;
        static int _windowModeLastSelected = 0;
        static double _currentVolume = 100;
        static double _currentMusic = 50;
        static double _currentEffects = 75;
        Dictionary<Slider, SliderInfo> sliders = new Dictionary<Slider, SliderInfo>();

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


            sliders.Add(Forms.VolumeSliderInstance, new SliderInfo(_currentVolume, Forms.CurrentVolumeLabel));
            sliders.Add(Forms.MusicSliderInstance, new SliderInfo(_currentMusic, Forms.CurrentMusicVolumeLabel));
            sliders.Add(Forms.EffectsSliderInstance, new SliderInfo(_currentEffects, Forms.CurrentEffectsVolumeLabel));
            Forms.VolumeSliderInstance.ValueChanged += VolumeSlider_ValueChanged;
            Forms.MusicSliderInstance.ValueChanged += MusicSliderInstance_ValueChanged;
            Forms.EffectsSliderInstance.ValueChanged += EffectsSliderInstance_ValueChanged;

            foreach (Slider slider in sliders.Keys)
            {
                slider.Value = sliders[slider].lastSelected;
                slider.LargeChange = 10;
                slider.IsMoveToPointEnabled = true;
                slider.ValueChanged += UpdateSlider;
            }
            UpdateSliders();

            Forms.BackButtonInstance.Click += BackButtonInstance_Click;
        }

        

        private void VolumeSlider_ValueChanged(object sender, EventArgs e)
        {

            if (_currentVolume == 0)
            {
                foreach(Slider slider in sliders.Keys)
                {
                    if (slider.Equals(Forms.VolumeSliderInstance)) continue;
                    slider.Value = Forms.VolumeSliderInstance.Value;
                }
            }
            else
            {
                double volumeChange = Forms.VolumeSliderInstance.Value / _currentVolume;
                foreach (Slider slider in sliders.Keys)
                {
                    if (slider.Equals(Forms.VolumeSliderInstance)) continue;
                    slider.Value *= volumeChange;
                }
            }
            _currentVolume = Forms.VolumeSliderInstance.Value;
        }
        private void MusicSliderInstance_ValueChanged(object sender, EventArgs e)
        {
            _currentMusic = Forms.MusicSliderInstance.Value;
            if (_currentMusic > Forms.VolumeSliderInstance.Value)
            {
                Forms.MusicSliderInstance.Value = Forms.VolumeSliderInstance.Value;
            }

        }
        private void EffectsSliderInstance_ValueChanged(object sender, EventArgs e)
        {
            _currentEffects = Forms.EffectsSliderInstance.Value;
            if (_currentEffects > Forms.VolumeSliderInstance.Value)
            {
                Forms.EffectsSliderInstance.Value = Forms.VolumeSliderInstance.Value;
            }
        }

        private void UpdateSliders()
        {
            foreach (Slider slider in sliders.Keys)
            {
                sliders[slider].displayLabel.Text = string.Format("{0:0}", slider.Value);
            }
        }
        private void UpdateSlider(object sender, EventArgs e)
        {
            UpdateSliders();
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
