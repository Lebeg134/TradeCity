    namespace JHP4SD.FormsControls.Screens
    {
        public partial class SettingsGumForms
        {
            private Gum.Wireframe.GraphicalUiElement Visual;
            public FlatRedBall.Forms.Controls.Button BackButtonInstance { get; set; }
            public FlatRedBall.Forms.Controls.ComboBox ResolutionComboBox { get; set; }
            public FlatRedBall.Forms.Controls.ComboBox WindowModeComboBox { get; set; }
            public FlatRedBall.Forms.Controls.Slider VolumeSliderInstance { get; set; }
            public FlatRedBall.Forms.Controls.Slider MusicSliderInstance { get; set; }
            public FlatRedBall.Forms.Controls.Label CurrentVolumeLabel { get; set; }
            public FlatRedBall.Forms.Controls.Label CurrentMusicVolumeLabel { get; set; }
            public SettingsGumForms () 
            {
                CustomInitialize();
            }
            public SettingsGumForms (Gum.Wireframe.GraphicalUiElement visual) 
            {
                Visual = visual;
                ReactToVisualChanged();
                CustomInitialize();
            }
            private void ReactToVisualChanged () 
            {
                BackButtonInstance = (FlatRedBall.Forms.Controls.Button)Visual.GetGraphicalUiElementByName("BackButtonInstance").FormsControlAsObject;
                ResolutionComboBox = (FlatRedBall.Forms.Controls.ComboBox)Visual.GetGraphicalUiElementByName("ResolutionComboBox").FormsControlAsObject;
                WindowModeComboBox = (FlatRedBall.Forms.Controls.ComboBox)Visual.GetGraphicalUiElementByName("WindowModeComboBox").FormsControlAsObject;
                VolumeSliderInstance = (FlatRedBall.Forms.Controls.Slider)Visual.GetGraphicalUiElementByName("VolumeSliderInstance").FormsControlAsObject;
                MusicSliderInstance = (FlatRedBall.Forms.Controls.Slider)Visual.GetGraphicalUiElementByName("MusicSliderInstance").FormsControlAsObject;
                CurrentVolumeLabel = (FlatRedBall.Forms.Controls.Label)Visual.GetGraphicalUiElementByName("CurrentVolumeLabel").FormsControlAsObject;
                CurrentMusicVolumeLabel = (FlatRedBall.Forms.Controls.Label)Visual.GetGraphicalUiElementByName("CurrentMusicVolumeLabel").FormsControlAsObject;
            }
            partial void CustomInitialize();
        }
    }
