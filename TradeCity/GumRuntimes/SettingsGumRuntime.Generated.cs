    using System.Linq;
    namespace JHP4SD.GumRuntimes
    {
        public partial class SettingsGumRuntime : Gum.Wireframe.GraphicalUiElement
        {
            #region State Enums
            public enum VariableState
            {
                Default
            }
            #endregion
            #region State Fields
            VariableState mCurrentVariableState;
            #endregion
            #region State Properties
            public VariableState CurrentVariableState
            {
                get
                {
                    return mCurrentVariableState;
                }
                set
                {
                    mCurrentVariableState = value;
                    switch(mCurrentVariableState)
                    {
                        case  VariableState.Default:
                            ResolutionContainer.Parent = this.GetGraphicalUiElementByName("GraphicsContainer");
                            ResolutionText.Parent = this.GetGraphicalUiElementByName("ResolutionContainer");
                            ResolutionComboBox.Parent = this.GetGraphicalUiElementByName("ResolutionContainer");
                            WindowModeContainer.Parent = this.GetGraphicalUiElementByName("GraphicsContainer");
                            WindowModeText.Parent = this.GetGraphicalUiElementByName("WindowModeContainer");
                            VolumeText.Parent = this.GetGraphicalUiElementByName("VolumeContainer");
                            MusicText.Parent = this.GetGraphicalUiElementByName("MusicContainer");
                            GraphicsContainer.Parent = this.GetGraphicalUiElementByName("GraphicsTopic");
                            WindowModeComboBox.Parent = this.GetGraphicalUiElementByName("WindowModeContainer");
                            SoundContainer.Parent = this.GetGraphicalUiElementByName("SoudTopic");
                            VolumeContainer.Parent = this.GetGraphicalUiElementByName("SoundContainer");
                            MusicContainer.Parent = this.GetGraphicalUiElementByName("SoundContainer");
                            VolumeSlider.Parent = this.GetGraphicalUiElementByName("VolumeContainer");
                            MusicSlider.Parent = this.GetGraphicalUiElementByName("MusicContainer");
                            VolumeMinText.Parent = this.GetGraphicalUiElementByName("VolumeSlider");
                            MusicMinText.Parent = this.GetGraphicalUiElementByName("MusicSlider");
                            VolumeSliderInstance.Parent = this.GetGraphicalUiElementByName("VolumeSlider");
                            MusicSliderInstance.Parent = this.GetGraphicalUiElementByName("MusicSlider");
                            VolumeMaxText.Parent = this.GetGraphicalUiElementByName("VolumeSlider");
                            MusicMaxText.Parent = this.GetGraphicalUiElementByName("MusicSlider");
                            CurrentVolumeLabel.Parent = this.GetGraphicalUiElementByName("VolumeContainer");
                            CurrentMusicVolumeLabel.Parent = this.GetGraphicalUiElementByName("MusicContainer");
                            RectangleInstance.Parent = this.GetGraphicalUiElementByName("VolumeContainer");
                            BackgroundColor.Blue = 128;
                            BackgroundColor.Green = 128;
                            BackgroundColor.Height = 0f;
                            BackgroundColor.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                            BackgroundColor.Red = 128;
                            BackgroundColor.Width = 0f;
                            BackgroundColor.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                            BackgroundColor.X = 0f;
                            BackgroundColor.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                            BackgroundColor.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            BackgroundColor.Y = 0f;
                            BackgroundColor.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            BackgroundColor.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            BackButtonInstance.X = -40f;
                            BackButtonInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                            BackButtonInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                            BackButtonInstance.Y = -40f;
                            BackButtonInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Bottom;
                            BackButtonInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                            SettingsText.Blue = 0;
                            SettingsText.FontSize = 72;
                            SettingsText.Green = 0;
                            SettingsText.Red = 0;
                            SettingsText.Text = "Settings";
                            SettingsText.X = 2f;
                            SettingsText.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                            SettingsText.Y = 40f;
                            GraphicsTopic.ChildrenLayout = Gum.Managers.ChildrenLayout.Regular;
                            GraphicsTopic.Height = 0f;
                            GraphicsTopic.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                            GraphicsTopic.TopicName = "Graphics";
                            GraphicsTopic.Width = 47f;
                            GraphicsTopic.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            GraphicsTopic.X = 2f;
                            GraphicsTopic.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                            GraphicsTopic.Y = 152f;
                            GraphicsTopic.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Top;
                            SoudTopic.ChildrenLayout = Gum.Managers.ChildrenLayout.Regular;
                            SoudTopic.Height = 0f;
                            SoudTopic.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                            SoudTopic.TopicName = "Sound";
                            SoudTopic.Width = 47f;
                            SoudTopic.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            SoudTopic.X = 98f;
                            SoudTopic.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                            SoudTopic.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                            SoudTopic.Y = 152f;
                            ResolutionContainer.Height = 0f;
                            ResolutionContainer.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                            ResolutionContainer.Width = 100f;
                            ResolutionContainer.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            ResolutionContainer.X = 0f;
                            ResolutionContainer.XUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                            ResolutionContainer.Y = 0f;
                            ResolutionContainer.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Top;
                            ResolutionText.Blue = 0;
                            ResolutionText.Green = 0;
                            ResolutionText.Height = 0f;
                            ResolutionText.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                            ResolutionText.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                            ResolutionText.Red = 0;
                            ResolutionText.Text = "Resolution:";
                            ResolutionText.VerticalAlignment = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            ResolutionText.Width = 0f;
                            ResolutionText.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                            ResolutionText.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                            ResolutionText.XUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                            ResolutionText.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            ResolutionText.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            ResolutionComboBox.ListBoxInstanceHeight = 96f;
                            ResolutionComboBox.Width = 50f;
                            ResolutionComboBox.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            ResolutionComboBox.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                            ResolutionComboBox.XUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                            WindowModeContainer.Height = 0f;
                            WindowModeContainer.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                            WindowModeContainer.Width = 100f;
                            WindowModeContainer.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            WindowModeContainer.X = 0f;
                            WindowModeContainer.Y = 5f;
                            WindowModeText.Blue = 0;
                            WindowModeText.Green = 0;
                            WindowModeText.Height = 0f;
                            WindowModeText.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                            WindowModeText.Red = 0;
                            WindowModeText.Text = "Window mode:";
                            WindowModeText.Width = 0f;
                            WindowModeText.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                            WindowModeText.XUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                            WindowModeText.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            WindowModeText.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            VolumeText.Blue = 0;
                            VolumeText.Green = 0;
                            VolumeText.Height = 0f;
                            VolumeText.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                            VolumeText.Red = 0;
                            VolumeText.Text = "Volume:";
                            VolumeText.Width = 0f;
                            VolumeText.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                            VolumeText.XUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                            VolumeText.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            VolumeText.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            MusicText.Blue = 0;
                            MusicText.Green = 0;
                            MusicText.Height = 0f;
                            MusicText.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                            MusicText.Red = 0;
                            MusicText.Text = "Music";
                            MusicText.Width = 0f;
                            MusicText.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                            MusicText.XUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                            MusicText.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            MusicText.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            GraphicsContainer.ChildrenLayout = Gum.Managers.ChildrenLayout.TopToBottomStack;
                            GraphicsContainer.Height = 0f;
                            GraphicsContainer.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                            GraphicsContainer.Width = 98f;
                            GraphicsContainer.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            GraphicsContainer.X = 1f;
                            GraphicsContainer.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                            GraphicsContainer.Y = 40f;
                            WindowModeComboBox.ListBoxInstanceHeight = 64f;
                            WindowModeComboBox.Width = 50f;
                            WindowModeComboBox.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            WindowModeComboBox.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                            WindowModeComboBox.XUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                            SoundContainer.ChildrenLayout = Gum.Managers.ChildrenLayout.TopToBottomStack;
                            SoundContainer.Height = 0f;
                            SoundContainer.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                            SoundContainer.Width = 98f;
                            SoundContainer.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            SoundContainer.X = 1f;
                            SoundContainer.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                            SoundContainer.Y = 40f;
                            VolumeContainer.ChildrenLayout = Gum.Managers.ChildrenLayout.Regular;
                            VolumeContainer.Height = 0f;
                            VolumeContainer.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                            VolumeContainer.Width = 0f;
                            VolumeContainer.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                            MusicContainer.ChildrenLayout = Gum.Managers.ChildrenLayout.Regular;
                            MusicContainer.Height = 0f;
                            MusicContainer.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                            MusicContainer.Width = 0f;
                            MusicContainer.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                            VolumeSlider.Height = 0f;
                            VolumeSlider.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                            VolumeSlider.Width = 80f;
                            VolumeSlider.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            VolumeSlider.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                            VolumeSlider.XUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                            MusicSlider.Height = 0f;
                            MusicSlider.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                            MusicSlider.Width = 80f;
                            MusicSlider.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            MusicSlider.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                            MusicSlider.XUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                            VolumeMinText.Blue = 0;
                            VolumeMinText.FontSize = 24;
                            VolumeMinText.Green = 0;
                            VolumeMinText.Height = 0f;
                            VolumeMinText.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                            VolumeMinText.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                            VolumeMinText.Red = 0;
                            VolumeMinText.Text = "0";
                            VolumeMinText.VerticalAlignment = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            VolumeMinText.Width = 2f;
                            VolumeMinText.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            VolumeMinText.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            VolumeMinText.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            MusicMinText.Blue = 0;
                            MusicMinText.FontSize = 24;
                            MusicMinText.Green = 0;
                            MusicMinText.Height = 0f;
                            MusicMinText.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                            MusicMinText.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                            MusicMinText.Red = 0;
                            MusicMinText.Text = "0";
                            MusicMinText.VerticalAlignment = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            MusicMinText.Width = 2f;
                            MusicMinText.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            MusicMinText.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            MusicMinText.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            VolumeSliderInstance.Width = 92f;
                            VolumeSliderInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            VolumeSliderInstance.X = 2f;
                            VolumeSliderInstance.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                            MusicSliderInstance.Width = 92f;
                            MusicSliderInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            MusicSliderInstance.X = 2f;
                            MusicSliderInstance.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                            VolumeMaxText.Blue = 0;
                            VolumeMaxText.FontSize = 24;
                            VolumeMaxText.Green = 0;
                            VolumeMaxText.Height = 0f;
                            VolumeMaxText.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                            VolumeMaxText.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                            VolumeMaxText.Red = 0;
                            VolumeMaxText.Text = "100";
                            VolumeMaxText.Width = 5f;
                            VolumeMaxText.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            VolumeMaxText.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                            VolumeMaxText.XUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                            VolumeMaxText.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            VolumeMaxText.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            MusicMaxText.Blue = 0;
                            MusicMaxText.FontSize = 24;
                            MusicMaxText.Green = 0;
                            MusicMaxText.Height = 0f;
                            MusicMaxText.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                            MusicMaxText.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                            MusicMaxText.Red = 0;
                            MusicMaxText.Text = "100";
                            MusicMaxText.Width = 5f;
                            MusicMaxText.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            MusicMaxText.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                            MusicMaxText.XUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                            MusicMaxText.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            MusicMaxText.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            CurrentVolumeLabel.Height = 100f;
                            CurrentVolumeLabel.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            CurrentVolumeLabel.LabelTextAlpha = 255;
                            CurrentVolumeLabel.LabelTextBlue = 0;
                            CurrentVolumeLabel.LabelTextGreen = 0;
                            CurrentVolumeLabel.LabelTextRed = 0;
                            CurrentVolumeLabel.Width = 10f;
                            CurrentVolumeLabel.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            CurrentVolumeLabel.X = 20f;
                            CurrentVolumeLabel.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                            CurrentVolumeLabel.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                            CurrentMusicVolumeLabel.Height = 100f;
                            CurrentMusicVolumeLabel.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            CurrentMusicVolumeLabel.LabelTextAlpha = 255;
                            CurrentMusicVolumeLabel.LabelTextBlue = 0;
                            CurrentMusicVolumeLabel.LabelTextGreen = 0;
                            CurrentMusicVolumeLabel.LabelTextRed = 0;
                            CurrentMusicVolumeLabel.Width = 10f;
                            CurrentMusicVolumeLabel.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            CurrentMusicVolumeLabel.X = 20f;
                            CurrentMusicVolumeLabel.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                            CurrentMusicVolumeLabel.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                            RectangleInstance.Blue = 0;
                            RectangleInstance.Green = 0;
                            RectangleInstance.Height = 0f;
                            RectangleInstance.Red = 0;
                            RectangleInstance.Width = 100f;
                            RectangleInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            RectangleInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                            break;
                    }
                }
            }
            #endregion
            #region State Interpolation
            public void InterpolateBetween (VariableState firstState, VariableState secondState, float interpolationValue) 
            {
                #if DEBUG
                if (float.IsNaN(interpolationValue))
                {
                    throw new System.Exception("interpolationValue cannot be NaN");
                }
                #endif
                bool setBackButtonInstanceXFirstValue = false;
                bool setBackButtonInstanceXSecondValue = false;
                float BackButtonInstanceXFirstValue= 0;
                float BackButtonInstanceXSecondValue= 0;
                bool setBackButtonInstanceYFirstValue = false;
                bool setBackButtonInstanceYSecondValue = false;
                float BackButtonInstanceYFirstValue= 0;
                float BackButtonInstanceYSecondValue= 0;
                bool setBackgroundColorBlueFirstValue = false;
                bool setBackgroundColorBlueSecondValue = false;
                int BackgroundColorBlueFirstValue= 0;
                int BackgroundColorBlueSecondValue= 0;
                bool setBackgroundColorGreenFirstValue = false;
                bool setBackgroundColorGreenSecondValue = false;
                int BackgroundColorGreenFirstValue= 0;
                int BackgroundColorGreenSecondValue= 0;
                bool setBackgroundColorHeightFirstValue = false;
                bool setBackgroundColorHeightSecondValue = false;
                float BackgroundColorHeightFirstValue= 0;
                float BackgroundColorHeightSecondValue= 0;
                bool setBackgroundColorRedFirstValue = false;
                bool setBackgroundColorRedSecondValue = false;
                int BackgroundColorRedFirstValue= 0;
                int BackgroundColorRedSecondValue= 0;
                bool setBackgroundColorWidthFirstValue = false;
                bool setBackgroundColorWidthSecondValue = false;
                float BackgroundColorWidthFirstValue= 0;
                float BackgroundColorWidthSecondValue= 0;
                bool setBackgroundColorXFirstValue = false;
                bool setBackgroundColorXSecondValue = false;
                float BackgroundColorXFirstValue= 0;
                float BackgroundColorXSecondValue= 0;
                bool setBackgroundColorYFirstValue = false;
                bool setBackgroundColorYSecondValue = false;
                float BackgroundColorYFirstValue= 0;
                float BackgroundColorYSecondValue= 0;
                bool setCurrentMusicVolumeLabelHeightFirstValue = false;
                bool setCurrentMusicVolumeLabelHeightSecondValue = false;
                float CurrentMusicVolumeLabelHeightFirstValue= 0;
                float CurrentMusicVolumeLabelHeightSecondValue= 0;
                bool setCurrentMusicVolumeLabelLabelTextAlphaFirstValue = false;
                bool setCurrentMusicVolumeLabelLabelTextAlphaSecondValue = false;
                int CurrentMusicVolumeLabelLabelTextAlphaFirstValue= 0;
                int CurrentMusicVolumeLabelLabelTextAlphaSecondValue= 0;
                bool setCurrentMusicVolumeLabelLabelTextBlueFirstValue = false;
                bool setCurrentMusicVolumeLabelLabelTextBlueSecondValue = false;
                int CurrentMusicVolumeLabelLabelTextBlueFirstValue= 0;
                int CurrentMusicVolumeLabelLabelTextBlueSecondValue= 0;
                bool setCurrentMusicVolumeLabelLabelTextGreenFirstValue = false;
                bool setCurrentMusicVolumeLabelLabelTextGreenSecondValue = false;
                int CurrentMusicVolumeLabelLabelTextGreenFirstValue= 0;
                int CurrentMusicVolumeLabelLabelTextGreenSecondValue= 0;
                bool setCurrentMusicVolumeLabelLabelTextRedFirstValue = false;
                bool setCurrentMusicVolumeLabelLabelTextRedSecondValue = false;
                int CurrentMusicVolumeLabelLabelTextRedFirstValue= 0;
                int CurrentMusicVolumeLabelLabelTextRedSecondValue= 0;
                bool setCurrentMusicVolumeLabelWidthFirstValue = false;
                bool setCurrentMusicVolumeLabelWidthSecondValue = false;
                float CurrentMusicVolumeLabelWidthFirstValue= 0;
                float CurrentMusicVolumeLabelWidthSecondValue= 0;
                bool setCurrentMusicVolumeLabelXFirstValue = false;
                bool setCurrentMusicVolumeLabelXSecondValue = false;
                float CurrentMusicVolumeLabelXFirstValue= 0;
                float CurrentMusicVolumeLabelXSecondValue= 0;
                bool setCurrentVolumeLabelHeightFirstValue = false;
                bool setCurrentVolumeLabelHeightSecondValue = false;
                float CurrentVolumeLabelHeightFirstValue= 0;
                float CurrentVolumeLabelHeightSecondValue= 0;
                bool setCurrentVolumeLabelLabelTextAlphaFirstValue = false;
                bool setCurrentVolumeLabelLabelTextAlphaSecondValue = false;
                int CurrentVolumeLabelLabelTextAlphaFirstValue= 0;
                int CurrentVolumeLabelLabelTextAlphaSecondValue= 0;
                bool setCurrentVolumeLabelLabelTextBlueFirstValue = false;
                bool setCurrentVolumeLabelLabelTextBlueSecondValue = false;
                int CurrentVolumeLabelLabelTextBlueFirstValue= 0;
                int CurrentVolumeLabelLabelTextBlueSecondValue= 0;
                bool setCurrentVolumeLabelLabelTextGreenFirstValue = false;
                bool setCurrentVolumeLabelLabelTextGreenSecondValue = false;
                int CurrentVolumeLabelLabelTextGreenFirstValue= 0;
                int CurrentVolumeLabelLabelTextGreenSecondValue= 0;
                bool setCurrentVolumeLabelLabelTextRedFirstValue = false;
                bool setCurrentVolumeLabelLabelTextRedSecondValue = false;
                int CurrentVolumeLabelLabelTextRedFirstValue= 0;
                int CurrentVolumeLabelLabelTextRedSecondValue= 0;
                bool setCurrentVolumeLabelWidthFirstValue = false;
                bool setCurrentVolumeLabelWidthSecondValue = false;
                float CurrentVolumeLabelWidthFirstValue= 0;
                float CurrentVolumeLabelWidthSecondValue= 0;
                bool setCurrentVolumeLabelXFirstValue = false;
                bool setCurrentVolumeLabelXSecondValue = false;
                float CurrentVolumeLabelXFirstValue= 0;
                float CurrentVolumeLabelXSecondValue= 0;
                bool setGraphicsContainerHeightFirstValue = false;
                bool setGraphicsContainerHeightSecondValue = false;
                float GraphicsContainerHeightFirstValue= 0;
                float GraphicsContainerHeightSecondValue= 0;
                bool setGraphicsContainerWidthFirstValue = false;
                bool setGraphicsContainerWidthSecondValue = false;
                float GraphicsContainerWidthFirstValue= 0;
                float GraphicsContainerWidthSecondValue= 0;
                bool setGraphicsContainerXFirstValue = false;
                bool setGraphicsContainerXSecondValue = false;
                float GraphicsContainerXFirstValue= 0;
                float GraphicsContainerXSecondValue= 0;
                bool setGraphicsContainerYFirstValue = false;
                bool setGraphicsContainerYSecondValue = false;
                float GraphicsContainerYFirstValue= 0;
                float GraphicsContainerYSecondValue= 0;
                bool setGraphicsTopicHeightFirstValue = false;
                bool setGraphicsTopicHeightSecondValue = false;
                float GraphicsTopicHeightFirstValue= 0;
                float GraphicsTopicHeightSecondValue= 0;
                bool setGraphicsTopicWidthFirstValue = false;
                bool setGraphicsTopicWidthSecondValue = false;
                float GraphicsTopicWidthFirstValue= 0;
                float GraphicsTopicWidthSecondValue= 0;
                bool setGraphicsTopicXFirstValue = false;
                bool setGraphicsTopicXSecondValue = false;
                float GraphicsTopicXFirstValue= 0;
                float GraphicsTopicXSecondValue= 0;
                bool setGraphicsTopicYFirstValue = false;
                bool setGraphicsTopicYSecondValue = false;
                float GraphicsTopicYFirstValue= 0;
                float GraphicsTopicYSecondValue= 0;
                bool setMusicContainerHeightFirstValue = false;
                bool setMusicContainerHeightSecondValue = false;
                float MusicContainerHeightFirstValue= 0;
                float MusicContainerHeightSecondValue= 0;
                bool setMusicContainerWidthFirstValue = false;
                bool setMusicContainerWidthSecondValue = false;
                float MusicContainerWidthFirstValue= 0;
                float MusicContainerWidthSecondValue= 0;
                bool setMusicMaxTextBlueFirstValue = false;
                bool setMusicMaxTextBlueSecondValue = false;
                int MusicMaxTextBlueFirstValue= 0;
                int MusicMaxTextBlueSecondValue= 0;
                bool setMusicMaxTextFontSizeFirstValue = false;
                bool setMusicMaxTextFontSizeSecondValue = false;
                int MusicMaxTextFontSizeFirstValue= 0;
                int MusicMaxTextFontSizeSecondValue= 0;
                bool setMusicMaxTextGreenFirstValue = false;
                bool setMusicMaxTextGreenSecondValue = false;
                int MusicMaxTextGreenFirstValue= 0;
                int MusicMaxTextGreenSecondValue= 0;
                bool setMusicMaxTextHeightFirstValue = false;
                bool setMusicMaxTextHeightSecondValue = false;
                float MusicMaxTextHeightFirstValue= 0;
                float MusicMaxTextHeightSecondValue= 0;
                bool setMusicMaxTextRedFirstValue = false;
                bool setMusicMaxTextRedSecondValue = false;
                int MusicMaxTextRedFirstValue= 0;
                int MusicMaxTextRedSecondValue= 0;
                bool setMusicMaxTextWidthFirstValue = false;
                bool setMusicMaxTextWidthSecondValue = false;
                float MusicMaxTextWidthFirstValue= 0;
                float MusicMaxTextWidthSecondValue= 0;
                bool setMusicMinTextBlueFirstValue = false;
                bool setMusicMinTextBlueSecondValue = false;
                int MusicMinTextBlueFirstValue= 0;
                int MusicMinTextBlueSecondValue= 0;
                bool setMusicMinTextFontSizeFirstValue = false;
                bool setMusicMinTextFontSizeSecondValue = false;
                int MusicMinTextFontSizeFirstValue= 0;
                int MusicMinTextFontSizeSecondValue= 0;
                bool setMusicMinTextGreenFirstValue = false;
                bool setMusicMinTextGreenSecondValue = false;
                int MusicMinTextGreenFirstValue= 0;
                int MusicMinTextGreenSecondValue= 0;
                bool setMusicMinTextHeightFirstValue = false;
                bool setMusicMinTextHeightSecondValue = false;
                float MusicMinTextHeightFirstValue= 0;
                float MusicMinTextHeightSecondValue= 0;
                bool setMusicMinTextRedFirstValue = false;
                bool setMusicMinTextRedSecondValue = false;
                int MusicMinTextRedFirstValue= 0;
                int MusicMinTextRedSecondValue= 0;
                bool setMusicMinTextWidthFirstValue = false;
                bool setMusicMinTextWidthSecondValue = false;
                float MusicMinTextWidthFirstValue= 0;
                float MusicMinTextWidthSecondValue= 0;
                bool setMusicSliderHeightFirstValue = false;
                bool setMusicSliderHeightSecondValue = false;
                float MusicSliderHeightFirstValue= 0;
                float MusicSliderHeightSecondValue= 0;
                bool setMusicSliderWidthFirstValue = false;
                bool setMusicSliderWidthSecondValue = false;
                float MusicSliderWidthFirstValue= 0;
                float MusicSliderWidthSecondValue= 0;
                bool setMusicSliderInstanceWidthFirstValue = false;
                bool setMusicSliderInstanceWidthSecondValue = false;
                float MusicSliderInstanceWidthFirstValue= 0;
                float MusicSliderInstanceWidthSecondValue= 0;
                bool setMusicSliderInstanceXFirstValue = false;
                bool setMusicSliderInstanceXSecondValue = false;
                float MusicSliderInstanceXFirstValue= 0;
                float MusicSliderInstanceXSecondValue= 0;
                bool setMusicTextBlueFirstValue = false;
                bool setMusicTextBlueSecondValue = false;
                int MusicTextBlueFirstValue= 0;
                int MusicTextBlueSecondValue= 0;
                bool setMusicTextGreenFirstValue = false;
                bool setMusicTextGreenSecondValue = false;
                int MusicTextGreenFirstValue= 0;
                int MusicTextGreenSecondValue= 0;
                bool setMusicTextHeightFirstValue = false;
                bool setMusicTextHeightSecondValue = false;
                float MusicTextHeightFirstValue= 0;
                float MusicTextHeightSecondValue= 0;
                bool setMusicTextRedFirstValue = false;
                bool setMusicTextRedSecondValue = false;
                int MusicTextRedFirstValue= 0;
                int MusicTextRedSecondValue= 0;
                bool setMusicTextWidthFirstValue = false;
                bool setMusicTextWidthSecondValue = false;
                float MusicTextWidthFirstValue= 0;
                float MusicTextWidthSecondValue= 0;
                bool setRectangleInstanceBlueFirstValue = false;
                bool setRectangleInstanceBlueSecondValue = false;
                int RectangleInstanceBlueFirstValue= 0;
                int RectangleInstanceBlueSecondValue= 0;
                bool setRectangleInstanceGreenFirstValue = false;
                bool setRectangleInstanceGreenSecondValue = false;
                int RectangleInstanceGreenFirstValue= 0;
                int RectangleInstanceGreenSecondValue= 0;
                bool setRectangleInstanceHeightFirstValue = false;
                bool setRectangleInstanceHeightSecondValue = false;
                float RectangleInstanceHeightFirstValue= 0;
                float RectangleInstanceHeightSecondValue= 0;
                bool setRectangleInstanceRedFirstValue = false;
                bool setRectangleInstanceRedSecondValue = false;
                int RectangleInstanceRedFirstValue= 0;
                int RectangleInstanceRedSecondValue= 0;
                bool setRectangleInstanceWidthFirstValue = false;
                bool setRectangleInstanceWidthSecondValue = false;
                float RectangleInstanceWidthFirstValue= 0;
                float RectangleInstanceWidthSecondValue= 0;
                bool setResolutionComboBoxListBoxInstanceHeightFirstValue = false;
                bool setResolutionComboBoxListBoxInstanceHeightSecondValue = false;
                float ResolutionComboBoxListBoxInstanceHeightFirstValue= 0;
                float ResolutionComboBoxListBoxInstanceHeightSecondValue= 0;
                bool setResolutionComboBoxWidthFirstValue = false;
                bool setResolutionComboBoxWidthSecondValue = false;
                float ResolutionComboBoxWidthFirstValue= 0;
                float ResolutionComboBoxWidthSecondValue= 0;
                bool setResolutionContainerHeightFirstValue = false;
                bool setResolutionContainerHeightSecondValue = false;
                float ResolutionContainerHeightFirstValue= 0;
                float ResolutionContainerHeightSecondValue= 0;
                bool setResolutionContainerWidthFirstValue = false;
                bool setResolutionContainerWidthSecondValue = false;
                float ResolutionContainerWidthFirstValue= 0;
                float ResolutionContainerWidthSecondValue= 0;
                bool setResolutionContainerXFirstValue = false;
                bool setResolutionContainerXSecondValue = false;
                float ResolutionContainerXFirstValue= 0;
                float ResolutionContainerXSecondValue= 0;
                bool setResolutionContainerYFirstValue = false;
                bool setResolutionContainerYSecondValue = false;
                float ResolutionContainerYFirstValue= 0;
                float ResolutionContainerYSecondValue= 0;
                bool setResolutionTextBlueFirstValue = false;
                bool setResolutionTextBlueSecondValue = false;
                int ResolutionTextBlueFirstValue= 0;
                int ResolutionTextBlueSecondValue= 0;
                bool setResolutionTextGreenFirstValue = false;
                bool setResolutionTextGreenSecondValue = false;
                int ResolutionTextGreenFirstValue= 0;
                int ResolutionTextGreenSecondValue= 0;
                bool setResolutionTextHeightFirstValue = false;
                bool setResolutionTextHeightSecondValue = false;
                float ResolutionTextHeightFirstValue= 0;
                float ResolutionTextHeightSecondValue= 0;
                bool setResolutionTextRedFirstValue = false;
                bool setResolutionTextRedSecondValue = false;
                int ResolutionTextRedFirstValue= 0;
                int ResolutionTextRedSecondValue= 0;
                bool setResolutionTextWidthFirstValue = false;
                bool setResolutionTextWidthSecondValue = false;
                float ResolutionTextWidthFirstValue= 0;
                float ResolutionTextWidthSecondValue= 0;
                bool setSettingsTextBlueFirstValue = false;
                bool setSettingsTextBlueSecondValue = false;
                int SettingsTextBlueFirstValue= 0;
                int SettingsTextBlueSecondValue= 0;
                bool setSettingsTextFontSizeFirstValue = false;
                bool setSettingsTextFontSizeSecondValue = false;
                int SettingsTextFontSizeFirstValue= 0;
                int SettingsTextFontSizeSecondValue= 0;
                bool setSettingsTextGreenFirstValue = false;
                bool setSettingsTextGreenSecondValue = false;
                int SettingsTextGreenFirstValue= 0;
                int SettingsTextGreenSecondValue= 0;
                bool setSettingsTextRedFirstValue = false;
                bool setSettingsTextRedSecondValue = false;
                int SettingsTextRedFirstValue= 0;
                int SettingsTextRedSecondValue= 0;
                bool setSettingsTextXFirstValue = false;
                bool setSettingsTextXSecondValue = false;
                float SettingsTextXFirstValue= 0;
                float SettingsTextXSecondValue= 0;
                bool setSettingsTextYFirstValue = false;
                bool setSettingsTextYSecondValue = false;
                float SettingsTextYFirstValue= 0;
                float SettingsTextYSecondValue= 0;
                bool setSoudTopicHeightFirstValue = false;
                bool setSoudTopicHeightSecondValue = false;
                float SoudTopicHeightFirstValue= 0;
                float SoudTopicHeightSecondValue= 0;
                bool setSoudTopicWidthFirstValue = false;
                bool setSoudTopicWidthSecondValue = false;
                float SoudTopicWidthFirstValue= 0;
                float SoudTopicWidthSecondValue= 0;
                bool setSoudTopicXFirstValue = false;
                bool setSoudTopicXSecondValue = false;
                float SoudTopicXFirstValue= 0;
                float SoudTopicXSecondValue= 0;
                bool setSoudTopicYFirstValue = false;
                bool setSoudTopicYSecondValue = false;
                float SoudTopicYFirstValue= 0;
                float SoudTopicYSecondValue= 0;
                bool setSoundContainerHeightFirstValue = false;
                bool setSoundContainerHeightSecondValue = false;
                float SoundContainerHeightFirstValue= 0;
                float SoundContainerHeightSecondValue= 0;
                bool setSoundContainerWidthFirstValue = false;
                bool setSoundContainerWidthSecondValue = false;
                float SoundContainerWidthFirstValue= 0;
                float SoundContainerWidthSecondValue= 0;
                bool setSoundContainerXFirstValue = false;
                bool setSoundContainerXSecondValue = false;
                float SoundContainerXFirstValue= 0;
                float SoundContainerXSecondValue= 0;
                bool setSoundContainerYFirstValue = false;
                bool setSoundContainerYSecondValue = false;
                float SoundContainerYFirstValue= 0;
                float SoundContainerYSecondValue= 0;
                bool setVolumeContainerHeightFirstValue = false;
                bool setVolumeContainerHeightSecondValue = false;
                float VolumeContainerHeightFirstValue= 0;
                float VolumeContainerHeightSecondValue= 0;
                bool setVolumeContainerWidthFirstValue = false;
                bool setVolumeContainerWidthSecondValue = false;
                float VolumeContainerWidthFirstValue= 0;
                float VolumeContainerWidthSecondValue= 0;
                bool setVolumeMaxTextBlueFirstValue = false;
                bool setVolumeMaxTextBlueSecondValue = false;
                int VolumeMaxTextBlueFirstValue= 0;
                int VolumeMaxTextBlueSecondValue= 0;
                bool setVolumeMaxTextFontSizeFirstValue = false;
                bool setVolumeMaxTextFontSizeSecondValue = false;
                int VolumeMaxTextFontSizeFirstValue= 0;
                int VolumeMaxTextFontSizeSecondValue= 0;
                bool setVolumeMaxTextGreenFirstValue = false;
                bool setVolumeMaxTextGreenSecondValue = false;
                int VolumeMaxTextGreenFirstValue= 0;
                int VolumeMaxTextGreenSecondValue= 0;
                bool setVolumeMaxTextHeightFirstValue = false;
                bool setVolumeMaxTextHeightSecondValue = false;
                float VolumeMaxTextHeightFirstValue= 0;
                float VolumeMaxTextHeightSecondValue= 0;
                bool setVolumeMaxTextRedFirstValue = false;
                bool setVolumeMaxTextRedSecondValue = false;
                int VolumeMaxTextRedFirstValue= 0;
                int VolumeMaxTextRedSecondValue= 0;
                bool setVolumeMaxTextWidthFirstValue = false;
                bool setVolumeMaxTextWidthSecondValue = false;
                float VolumeMaxTextWidthFirstValue= 0;
                float VolumeMaxTextWidthSecondValue= 0;
                bool setVolumeMinTextBlueFirstValue = false;
                bool setVolumeMinTextBlueSecondValue = false;
                int VolumeMinTextBlueFirstValue= 0;
                int VolumeMinTextBlueSecondValue= 0;
                bool setVolumeMinTextFontSizeFirstValue = false;
                bool setVolumeMinTextFontSizeSecondValue = false;
                int VolumeMinTextFontSizeFirstValue= 0;
                int VolumeMinTextFontSizeSecondValue= 0;
                bool setVolumeMinTextGreenFirstValue = false;
                bool setVolumeMinTextGreenSecondValue = false;
                int VolumeMinTextGreenFirstValue= 0;
                int VolumeMinTextGreenSecondValue= 0;
                bool setVolumeMinTextHeightFirstValue = false;
                bool setVolumeMinTextHeightSecondValue = false;
                float VolumeMinTextHeightFirstValue= 0;
                float VolumeMinTextHeightSecondValue= 0;
                bool setVolumeMinTextRedFirstValue = false;
                bool setVolumeMinTextRedSecondValue = false;
                int VolumeMinTextRedFirstValue= 0;
                int VolumeMinTextRedSecondValue= 0;
                bool setVolumeMinTextWidthFirstValue = false;
                bool setVolumeMinTextWidthSecondValue = false;
                float VolumeMinTextWidthFirstValue= 0;
                float VolumeMinTextWidthSecondValue= 0;
                bool setVolumeSliderHeightFirstValue = false;
                bool setVolumeSliderHeightSecondValue = false;
                float VolumeSliderHeightFirstValue= 0;
                float VolumeSliderHeightSecondValue= 0;
                bool setVolumeSliderWidthFirstValue = false;
                bool setVolumeSliderWidthSecondValue = false;
                float VolumeSliderWidthFirstValue= 0;
                float VolumeSliderWidthSecondValue= 0;
                bool setVolumeSliderInstanceWidthFirstValue = false;
                bool setVolumeSliderInstanceWidthSecondValue = false;
                float VolumeSliderInstanceWidthFirstValue= 0;
                float VolumeSliderInstanceWidthSecondValue= 0;
                bool setVolumeSliderInstanceXFirstValue = false;
                bool setVolumeSliderInstanceXSecondValue = false;
                float VolumeSliderInstanceXFirstValue= 0;
                float VolumeSliderInstanceXSecondValue= 0;
                bool setVolumeTextBlueFirstValue = false;
                bool setVolumeTextBlueSecondValue = false;
                int VolumeTextBlueFirstValue= 0;
                int VolumeTextBlueSecondValue= 0;
                bool setVolumeTextGreenFirstValue = false;
                bool setVolumeTextGreenSecondValue = false;
                int VolumeTextGreenFirstValue= 0;
                int VolumeTextGreenSecondValue= 0;
                bool setVolumeTextHeightFirstValue = false;
                bool setVolumeTextHeightSecondValue = false;
                float VolumeTextHeightFirstValue= 0;
                float VolumeTextHeightSecondValue= 0;
                bool setVolumeTextRedFirstValue = false;
                bool setVolumeTextRedSecondValue = false;
                int VolumeTextRedFirstValue= 0;
                int VolumeTextRedSecondValue= 0;
                bool setVolumeTextWidthFirstValue = false;
                bool setVolumeTextWidthSecondValue = false;
                float VolumeTextWidthFirstValue= 0;
                float VolumeTextWidthSecondValue= 0;
                bool setWindowModeComboBoxListBoxInstanceHeightFirstValue = false;
                bool setWindowModeComboBoxListBoxInstanceHeightSecondValue = false;
                float WindowModeComboBoxListBoxInstanceHeightFirstValue= 0;
                float WindowModeComboBoxListBoxInstanceHeightSecondValue= 0;
                bool setWindowModeComboBoxWidthFirstValue = false;
                bool setWindowModeComboBoxWidthSecondValue = false;
                float WindowModeComboBoxWidthFirstValue= 0;
                float WindowModeComboBoxWidthSecondValue= 0;
                bool setWindowModeContainerHeightFirstValue = false;
                bool setWindowModeContainerHeightSecondValue = false;
                float WindowModeContainerHeightFirstValue= 0;
                float WindowModeContainerHeightSecondValue= 0;
                bool setWindowModeContainerWidthFirstValue = false;
                bool setWindowModeContainerWidthSecondValue = false;
                float WindowModeContainerWidthFirstValue= 0;
                float WindowModeContainerWidthSecondValue= 0;
                bool setWindowModeContainerXFirstValue = false;
                bool setWindowModeContainerXSecondValue = false;
                float WindowModeContainerXFirstValue= 0;
                float WindowModeContainerXSecondValue= 0;
                bool setWindowModeContainerYFirstValue = false;
                bool setWindowModeContainerYSecondValue = false;
                float WindowModeContainerYFirstValue= 0;
                float WindowModeContainerYSecondValue= 0;
                bool setWindowModeTextBlueFirstValue = false;
                bool setWindowModeTextBlueSecondValue = false;
                int WindowModeTextBlueFirstValue= 0;
                int WindowModeTextBlueSecondValue= 0;
                bool setWindowModeTextGreenFirstValue = false;
                bool setWindowModeTextGreenSecondValue = false;
                int WindowModeTextGreenFirstValue= 0;
                int WindowModeTextGreenSecondValue= 0;
                bool setWindowModeTextHeightFirstValue = false;
                bool setWindowModeTextHeightSecondValue = false;
                float WindowModeTextHeightFirstValue= 0;
                float WindowModeTextHeightSecondValue= 0;
                bool setWindowModeTextRedFirstValue = false;
                bool setWindowModeTextRedSecondValue = false;
                int WindowModeTextRedFirstValue= 0;
                int WindowModeTextRedSecondValue= 0;
                bool setWindowModeTextWidthFirstValue = false;
                bool setWindowModeTextWidthSecondValue = false;
                float WindowModeTextWidthFirstValue= 0;
                float WindowModeTextWidthSecondValue= 0;
                switch(firstState)
                {
                    case  VariableState.Default:
                        setBackButtonInstanceXFirstValue = true;
                        BackButtonInstanceXFirstValue = -40f;
                        if (interpolationValue < 1)
                        {
                            this.BackButtonInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                        }
                        if (interpolationValue < 1)
                        {
                            this.BackButtonInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                        }
                        setBackButtonInstanceYFirstValue = true;
                        BackButtonInstanceYFirstValue = -40f;
                        if (interpolationValue < 1)
                        {
                            this.BackButtonInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Bottom;
                        }
                        if (interpolationValue < 1)
                        {
                            this.BackButtonInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                        }
                        setBackgroundColorBlueFirstValue = true;
                        BackgroundColorBlueFirstValue = 128;
                        setBackgroundColorGreenFirstValue = true;
                        BackgroundColorGreenFirstValue = 128;
                        setBackgroundColorHeightFirstValue = true;
                        BackgroundColorHeightFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.BackgroundColor.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        setBackgroundColorRedFirstValue = true;
                        BackgroundColorRedFirstValue = 128;
                        setBackgroundColorWidthFirstValue = true;
                        BackgroundColorWidthFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.BackgroundColor.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        setBackgroundColorXFirstValue = true;
                        BackgroundColorXFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.BackgroundColor.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.BackgroundColor.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setBackgroundColorYFirstValue = true;
                        BackgroundColorYFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.BackgroundColor.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.BackgroundColor.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setCurrentMusicVolumeLabelHeightFirstValue = true;
                        CurrentMusicVolumeLabelHeightFirstValue = 100f;
                        if (interpolationValue < 1)
                        {
                            this.CurrentMusicVolumeLabel.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setCurrentMusicVolumeLabelLabelTextAlphaFirstValue = true;
                        CurrentMusicVolumeLabelLabelTextAlphaFirstValue = 255;
                        setCurrentMusicVolumeLabelLabelTextBlueFirstValue = true;
                        CurrentMusicVolumeLabelLabelTextBlueFirstValue = 0;
                        setCurrentMusicVolumeLabelLabelTextGreenFirstValue = true;
                        CurrentMusicVolumeLabelLabelTextGreenFirstValue = 0;
                        setCurrentMusicVolumeLabelLabelTextRedFirstValue = true;
                        CurrentMusicVolumeLabelLabelTextRedFirstValue = 0;
                        if (interpolationValue < 1)
                        {
                            this.CurrentMusicVolumeLabel.Parent = this.GetGraphicalUiElementByName("MusicContainer");
                        }
                        setCurrentMusicVolumeLabelWidthFirstValue = true;
                        CurrentMusicVolumeLabelWidthFirstValue = 10f;
                        if (interpolationValue < 1)
                        {
                            this.CurrentMusicVolumeLabel.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setCurrentMusicVolumeLabelXFirstValue = true;
                        CurrentMusicVolumeLabelXFirstValue = 20f;
                        if (interpolationValue < 1)
                        {
                            this.CurrentMusicVolumeLabel.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                        }
                        if (interpolationValue < 1)
                        {
                            this.CurrentMusicVolumeLabel.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setCurrentVolumeLabelHeightFirstValue = true;
                        CurrentVolumeLabelHeightFirstValue = 100f;
                        if (interpolationValue < 1)
                        {
                            this.CurrentVolumeLabel.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setCurrentVolumeLabelLabelTextAlphaFirstValue = true;
                        CurrentVolumeLabelLabelTextAlphaFirstValue = 255;
                        setCurrentVolumeLabelLabelTextBlueFirstValue = true;
                        CurrentVolumeLabelLabelTextBlueFirstValue = 0;
                        setCurrentVolumeLabelLabelTextGreenFirstValue = true;
                        CurrentVolumeLabelLabelTextGreenFirstValue = 0;
                        setCurrentVolumeLabelLabelTextRedFirstValue = true;
                        CurrentVolumeLabelLabelTextRedFirstValue = 0;
                        if (interpolationValue < 1)
                        {
                            this.CurrentVolumeLabel.Parent = this.GetGraphicalUiElementByName("VolumeContainer");
                        }
                        setCurrentVolumeLabelWidthFirstValue = true;
                        CurrentVolumeLabelWidthFirstValue = 10f;
                        if (interpolationValue < 1)
                        {
                            this.CurrentVolumeLabel.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setCurrentVolumeLabelXFirstValue = true;
                        CurrentVolumeLabelXFirstValue = 20f;
                        if (interpolationValue < 1)
                        {
                            this.CurrentVolumeLabel.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                        }
                        if (interpolationValue < 1)
                        {
                            this.CurrentVolumeLabel.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.GraphicsContainer.ChildrenLayout = Gum.Managers.ChildrenLayout.TopToBottomStack;
                        }
                        setGraphicsContainerHeightFirstValue = true;
                        GraphicsContainerHeightFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.GraphicsContainer.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                        }
                        if (interpolationValue < 1)
                        {
                            this.GraphicsContainer.Parent = this.GetGraphicalUiElementByName("GraphicsTopic");
                        }
                        setGraphicsContainerWidthFirstValue = true;
                        GraphicsContainerWidthFirstValue = 98f;
                        if (interpolationValue < 1)
                        {
                            this.GraphicsContainer.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setGraphicsContainerXFirstValue = true;
                        GraphicsContainerXFirstValue = 1f;
                        if (interpolationValue < 1)
                        {
                            this.GraphicsContainer.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setGraphicsContainerYFirstValue = true;
                        GraphicsContainerYFirstValue = 40f;
                        if (interpolationValue < 1)
                        {
                            this.GraphicsTopic.ChildrenLayout = Gum.Managers.ChildrenLayout.Regular;
                        }
                        setGraphicsTopicHeightFirstValue = true;
                        GraphicsTopicHeightFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.GraphicsTopic.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                        }
                        if (interpolationValue < 1)
                        {
                            this.GraphicsTopic.TopicName = "Graphics";
                        }
                        setGraphicsTopicWidthFirstValue = true;
                        GraphicsTopicWidthFirstValue = 47f;
                        if (interpolationValue < 1)
                        {
                            this.GraphicsTopic.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setGraphicsTopicXFirstValue = true;
                        GraphicsTopicXFirstValue = 2f;
                        if (interpolationValue < 1)
                        {
                            this.GraphicsTopic.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setGraphicsTopicYFirstValue = true;
                        GraphicsTopicYFirstValue = 152f;
                        if (interpolationValue < 1)
                        {
                            this.GraphicsTopic.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Top;
                        }
                        if (interpolationValue < 1)
                        {
                            this.MusicContainer.ChildrenLayout = Gum.Managers.ChildrenLayout.Regular;
                        }
                        setMusicContainerHeightFirstValue = true;
                        MusicContainerHeightFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.MusicContainer.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                        }
                        if (interpolationValue < 1)
                        {
                            this.MusicContainer.Parent = this.GetGraphicalUiElementByName("SoundContainer");
                        }
                        setMusicContainerWidthFirstValue = true;
                        MusicContainerWidthFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.MusicContainer.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        setMusicMaxTextBlueFirstValue = true;
                        MusicMaxTextBlueFirstValue = 0;
                        setMusicMaxTextFontSizeFirstValue = true;
                        MusicMaxTextFontSizeFirstValue = 24;
                        setMusicMaxTextGreenFirstValue = true;
                        MusicMaxTextGreenFirstValue = 0;
                        setMusicMaxTextHeightFirstValue = true;
                        MusicMaxTextHeightFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.MusicMaxText.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                        }
                        if (interpolationValue < 1)
                        {
                            this.MusicMaxText.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                        }
                        if (interpolationValue < 1)
                        {
                            this.MusicMaxText.Parent = this.GetGraphicalUiElementByName("MusicSlider");
                        }
                        setMusicMaxTextRedFirstValue = true;
                        MusicMaxTextRedFirstValue = 0;
                        if (interpolationValue < 1)
                        {
                            this.MusicMaxText.Text = "100";
                        }
                        setMusicMaxTextWidthFirstValue = true;
                        MusicMaxTextWidthFirstValue = 5f;
                        if (interpolationValue < 1)
                        {
                            this.MusicMaxText.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.MusicMaxText.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                        }
                        if (interpolationValue < 1)
                        {
                            this.MusicMaxText.XUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                        }
                        if (interpolationValue < 1)
                        {
                            this.MusicMaxText.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.MusicMaxText.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setMusicMinTextBlueFirstValue = true;
                        MusicMinTextBlueFirstValue = 0;
                        setMusicMinTextFontSizeFirstValue = true;
                        MusicMinTextFontSizeFirstValue = 24;
                        setMusicMinTextGreenFirstValue = true;
                        MusicMinTextGreenFirstValue = 0;
                        setMusicMinTextHeightFirstValue = true;
                        MusicMinTextHeightFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.MusicMinText.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                        }
                        if (interpolationValue < 1)
                        {
                            this.MusicMinText.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                        }
                        if (interpolationValue < 1)
                        {
                            this.MusicMinText.Parent = this.GetGraphicalUiElementByName("MusicSlider");
                        }
                        setMusicMinTextRedFirstValue = true;
                        MusicMinTextRedFirstValue = 0;
                        if (interpolationValue < 1)
                        {
                            this.MusicMinText.Text = "0";
                        }
                        if (interpolationValue < 1)
                        {
                            this.MusicMinText.VerticalAlignment = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        setMusicMinTextWidthFirstValue = true;
                        MusicMinTextWidthFirstValue = 2f;
                        if (interpolationValue < 1)
                        {
                            this.MusicMinText.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.MusicMinText.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.MusicMinText.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setMusicSliderHeightFirstValue = true;
                        MusicSliderHeightFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.MusicSlider.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                        }
                        if (interpolationValue < 1)
                        {
                            this.MusicSlider.Parent = this.GetGraphicalUiElementByName("MusicContainer");
                        }
                        setMusicSliderWidthFirstValue = true;
                        MusicSliderWidthFirstValue = 80f;
                        if (interpolationValue < 1)
                        {
                            this.MusicSlider.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.MusicSlider.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                        }
                        if (interpolationValue < 1)
                        {
                            this.MusicSlider.XUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                        }
                        if (interpolationValue < 1)
                        {
                            this.MusicSliderInstance.Parent = this.GetGraphicalUiElementByName("MusicSlider");
                        }
                        setMusicSliderInstanceWidthFirstValue = true;
                        MusicSliderInstanceWidthFirstValue = 92f;
                        if (interpolationValue < 1)
                        {
                            this.MusicSliderInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setMusicSliderInstanceXFirstValue = true;
                        MusicSliderInstanceXFirstValue = 2f;
                        if (interpolationValue < 1)
                        {
                            this.MusicSliderInstance.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setMusicTextBlueFirstValue = true;
                        MusicTextBlueFirstValue = 0;
                        setMusicTextGreenFirstValue = true;
                        MusicTextGreenFirstValue = 0;
                        setMusicTextHeightFirstValue = true;
                        MusicTextHeightFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.MusicText.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                        }
                        if (interpolationValue < 1)
                        {
                            this.MusicText.Parent = this.GetGraphicalUiElementByName("MusicContainer");
                        }
                        setMusicTextRedFirstValue = true;
                        MusicTextRedFirstValue = 0;
                        if (interpolationValue < 1)
                        {
                            this.MusicText.Text = "Music";
                        }
                        setMusicTextWidthFirstValue = true;
                        MusicTextWidthFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.MusicText.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                        }
                        if (interpolationValue < 1)
                        {
                            this.MusicText.XUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                        }
                        if (interpolationValue < 1)
                        {
                            this.MusicText.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.MusicText.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setRectangleInstanceBlueFirstValue = true;
                        RectangleInstanceBlueFirstValue = 0;
                        setRectangleInstanceGreenFirstValue = true;
                        RectangleInstanceGreenFirstValue = 0;
                        setRectangleInstanceHeightFirstValue = true;
                        RectangleInstanceHeightFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.RectangleInstance.Parent = this.GetGraphicalUiElementByName("VolumeContainer");
                        }
                        setRectangleInstanceRedFirstValue = true;
                        RectangleInstanceRedFirstValue = 0;
                        setRectangleInstanceWidthFirstValue = true;
                        RectangleInstanceWidthFirstValue = 100f;
                        if (interpolationValue < 1)
                        {
                            this.RectangleInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.RectangleInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                        }
                        setResolutionComboBoxListBoxInstanceHeightFirstValue = true;
                        ResolutionComboBoxListBoxInstanceHeightFirstValue = 96f;
                        if (interpolationValue < 1)
                        {
                            this.ResolutionComboBox.Parent = this.GetGraphicalUiElementByName("ResolutionContainer");
                        }
                        setResolutionComboBoxWidthFirstValue = true;
                        ResolutionComboBoxWidthFirstValue = 50f;
                        if (interpolationValue < 1)
                        {
                            this.ResolutionComboBox.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.ResolutionComboBox.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                        }
                        if (interpolationValue < 1)
                        {
                            this.ResolutionComboBox.XUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                        }
                        setResolutionContainerHeightFirstValue = true;
                        ResolutionContainerHeightFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.ResolutionContainer.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                        }
                        if (interpolationValue < 1)
                        {
                            this.ResolutionContainer.Parent = this.GetGraphicalUiElementByName("GraphicsContainer");
                        }
                        setResolutionContainerWidthFirstValue = true;
                        ResolutionContainerWidthFirstValue = 100f;
                        if (interpolationValue < 1)
                        {
                            this.ResolutionContainer.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setResolutionContainerXFirstValue = true;
                        ResolutionContainerXFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.ResolutionContainer.XUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                        }
                        setResolutionContainerYFirstValue = true;
                        ResolutionContainerYFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.ResolutionContainer.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Top;
                        }
                        setResolutionTextBlueFirstValue = true;
                        ResolutionTextBlueFirstValue = 0;
                        setResolutionTextGreenFirstValue = true;
                        ResolutionTextGreenFirstValue = 0;
                        setResolutionTextHeightFirstValue = true;
                        ResolutionTextHeightFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.ResolutionText.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                        }
                        if (interpolationValue < 1)
                        {
                            this.ResolutionText.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                        }
                        if (interpolationValue < 1)
                        {
                            this.ResolutionText.Parent = this.GetGraphicalUiElementByName("ResolutionContainer");
                        }
                        setResolutionTextRedFirstValue = true;
                        ResolutionTextRedFirstValue = 0;
                        if (interpolationValue < 1)
                        {
                            this.ResolutionText.Text = "Resolution:";
                        }
                        if (interpolationValue < 1)
                        {
                            this.ResolutionText.VerticalAlignment = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        setResolutionTextWidthFirstValue = true;
                        ResolutionTextWidthFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.ResolutionText.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                        }
                        if (interpolationValue < 1)
                        {
                            this.ResolutionText.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                        }
                        if (interpolationValue < 1)
                        {
                            this.ResolutionText.XUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                        }
                        if (interpolationValue < 1)
                        {
                            this.ResolutionText.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.ResolutionText.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setSettingsTextBlueFirstValue = true;
                        SettingsTextBlueFirstValue = 0;
                        setSettingsTextFontSizeFirstValue = true;
                        SettingsTextFontSizeFirstValue = 72;
                        setSettingsTextGreenFirstValue = true;
                        SettingsTextGreenFirstValue = 0;
                        setSettingsTextRedFirstValue = true;
                        SettingsTextRedFirstValue = 0;
                        if (interpolationValue < 1)
                        {
                            this.SettingsText.Text = "Settings";
                        }
                        setSettingsTextXFirstValue = true;
                        SettingsTextXFirstValue = 2f;
                        if (interpolationValue < 1)
                        {
                            this.SettingsText.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setSettingsTextYFirstValue = true;
                        SettingsTextYFirstValue = 40f;
                        if (interpolationValue < 1)
                        {
                            this.SoudTopic.ChildrenLayout = Gum.Managers.ChildrenLayout.Regular;
                        }
                        setSoudTopicHeightFirstValue = true;
                        SoudTopicHeightFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.SoudTopic.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                        }
                        if (interpolationValue < 1)
                        {
                            this.SoudTopic.TopicName = "Sound";
                        }
                        setSoudTopicWidthFirstValue = true;
                        SoudTopicWidthFirstValue = 47f;
                        if (interpolationValue < 1)
                        {
                            this.SoudTopic.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setSoudTopicXFirstValue = true;
                        SoudTopicXFirstValue = 98f;
                        if (interpolationValue < 1)
                        {
                            this.SoudTopic.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                        }
                        if (interpolationValue < 1)
                        {
                            this.SoudTopic.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setSoudTopicYFirstValue = true;
                        SoudTopicYFirstValue = 152f;
                        if (interpolationValue < 1)
                        {
                            this.SoundContainer.ChildrenLayout = Gum.Managers.ChildrenLayout.TopToBottomStack;
                        }
                        setSoundContainerHeightFirstValue = true;
                        SoundContainerHeightFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.SoundContainer.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                        }
                        if (interpolationValue < 1)
                        {
                            this.SoundContainer.Parent = this.GetGraphicalUiElementByName("SoudTopic");
                        }
                        setSoundContainerWidthFirstValue = true;
                        SoundContainerWidthFirstValue = 98f;
                        if (interpolationValue < 1)
                        {
                            this.SoundContainer.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setSoundContainerXFirstValue = true;
                        SoundContainerXFirstValue = 1f;
                        if (interpolationValue < 1)
                        {
                            this.SoundContainer.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setSoundContainerYFirstValue = true;
                        SoundContainerYFirstValue = 40f;
                        if (interpolationValue < 1)
                        {
                            this.VolumeContainer.ChildrenLayout = Gum.Managers.ChildrenLayout.Regular;
                        }
                        setVolumeContainerHeightFirstValue = true;
                        VolumeContainerHeightFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.VolumeContainer.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                        }
                        if (interpolationValue < 1)
                        {
                            this.VolumeContainer.Parent = this.GetGraphicalUiElementByName("SoundContainer");
                        }
                        setVolumeContainerWidthFirstValue = true;
                        VolumeContainerWidthFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.VolumeContainer.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        setVolumeMaxTextBlueFirstValue = true;
                        VolumeMaxTextBlueFirstValue = 0;
                        setVolumeMaxTextFontSizeFirstValue = true;
                        VolumeMaxTextFontSizeFirstValue = 24;
                        setVolumeMaxTextGreenFirstValue = true;
                        VolumeMaxTextGreenFirstValue = 0;
                        setVolumeMaxTextHeightFirstValue = true;
                        VolumeMaxTextHeightFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.VolumeMaxText.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                        }
                        if (interpolationValue < 1)
                        {
                            this.VolumeMaxText.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                        }
                        if (interpolationValue < 1)
                        {
                            this.VolumeMaxText.Parent = this.GetGraphicalUiElementByName("VolumeSlider");
                        }
                        setVolumeMaxTextRedFirstValue = true;
                        VolumeMaxTextRedFirstValue = 0;
                        if (interpolationValue < 1)
                        {
                            this.VolumeMaxText.Text = "100";
                        }
                        setVolumeMaxTextWidthFirstValue = true;
                        VolumeMaxTextWidthFirstValue = 5f;
                        if (interpolationValue < 1)
                        {
                            this.VolumeMaxText.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.VolumeMaxText.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                        }
                        if (interpolationValue < 1)
                        {
                            this.VolumeMaxText.XUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                        }
                        if (interpolationValue < 1)
                        {
                            this.VolumeMaxText.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.VolumeMaxText.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setVolumeMinTextBlueFirstValue = true;
                        VolumeMinTextBlueFirstValue = 0;
                        setVolumeMinTextFontSizeFirstValue = true;
                        VolumeMinTextFontSizeFirstValue = 24;
                        setVolumeMinTextGreenFirstValue = true;
                        VolumeMinTextGreenFirstValue = 0;
                        setVolumeMinTextHeightFirstValue = true;
                        VolumeMinTextHeightFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.VolumeMinText.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                        }
                        if (interpolationValue < 1)
                        {
                            this.VolumeMinText.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                        }
                        if (interpolationValue < 1)
                        {
                            this.VolumeMinText.Parent = this.GetGraphicalUiElementByName("VolumeSlider");
                        }
                        setVolumeMinTextRedFirstValue = true;
                        VolumeMinTextRedFirstValue = 0;
                        if (interpolationValue < 1)
                        {
                            this.VolumeMinText.Text = "0";
                        }
                        if (interpolationValue < 1)
                        {
                            this.VolumeMinText.VerticalAlignment = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        setVolumeMinTextWidthFirstValue = true;
                        VolumeMinTextWidthFirstValue = 2f;
                        if (interpolationValue < 1)
                        {
                            this.VolumeMinText.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.VolumeMinText.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.VolumeMinText.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setVolumeSliderHeightFirstValue = true;
                        VolumeSliderHeightFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.VolumeSlider.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                        }
                        if (interpolationValue < 1)
                        {
                            this.VolumeSlider.Parent = this.GetGraphicalUiElementByName("VolumeContainer");
                        }
                        setVolumeSliderWidthFirstValue = true;
                        VolumeSliderWidthFirstValue = 80f;
                        if (interpolationValue < 1)
                        {
                            this.VolumeSlider.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.VolumeSlider.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                        }
                        if (interpolationValue < 1)
                        {
                            this.VolumeSlider.XUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                        }
                        if (interpolationValue < 1)
                        {
                            this.VolumeSliderInstance.Parent = this.GetGraphicalUiElementByName("VolumeSlider");
                        }
                        setVolumeSliderInstanceWidthFirstValue = true;
                        VolumeSliderInstanceWidthFirstValue = 92f;
                        if (interpolationValue < 1)
                        {
                            this.VolumeSliderInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setVolumeSliderInstanceXFirstValue = true;
                        VolumeSliderInstanceXFirstValue = 2f;
                        if (interpolationValue < 1)
                        {
                            this.VolumeSliderInstance.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setVolumeTextBlueFirstValue = true;
                        VolumeTextBlueFirstValue = 0;
                        setVolumeTextGreenFirstValue = true;
                        VolumeTextGreenFirstValue = 0;
                        setVolumeTextHeightFirstValue = true;
                        VolumeTextHeightFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.VolumeText.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                        }
                        if (interpolationValue < 1)
                        {
                            this.VolumeText.Parent = this.GetGraphicalUiElementByName("VolumeContainer");
                        }
                        setVolumeTextRedFirstValue = true;
                        VolumeTextRedFirstValue = 0;
                        if (interpolationValue < 1)
                        {
                            this.VolumeText.Text = "Volume:";
                        }
                        setVolumeTextWidthFirstValue = true;
                        VolumeTextWidthFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.VolumeText.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                        }
                        if (interpolationValue < 1)
                        {
                            this.VolumeText.XUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                        }
                        if (interpolationValue < 1)
                        {
                            this.VolumeText.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.VolumeText.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setWindowModeComboBoxListBoxInstanceHeightFirstValue = true;
                        WindowModeComboBoxListBoxInstanceHeightFirstValue = 64f;
                        if (interpolationValue < 1)
                        {
                            this.WindowModeComboBox.Parent = this.GetGraphicalUiElementByName("WindowModeContainer");
                        }
                        setWindowModeComboBoxWidthFirstValue = true;
                        WindowModeComboBoxWidthFirstValue = 50f;
                        if (interpolationValue < 1)
                        {
                            this.WindowModeComboBox.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.WindowModeComboBox.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                        }
                        if (interpolationValue < 1)
                        {
                            this.WindowModeComboBox.XUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                        }
                        setWindowModeContainerHeightFirstValue = true;
                        WindowModeContainerHeightFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.WindowModeContainer.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                        }
                        if (interpolationValue < 1)
                        {
                            this.WindowModeContainer.Parent = this.GetGraphicalUiElementByName("GraphicsContainer");
                        }
                        setWindowModeContainerWidthFirstValue = true;
                        WindowModeContainerWidthFirstValue = 100f;
                        if (interpolationValue < 1)
                        {
                            this.WindowModeContainer.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setWindowModeContainerXFirstValue = true;
                        WindowModeContainerXFirstValue = 0f;
                        setWindowModeContainerYFirstValue = true;
                        WindowModeContainerYFirstValue = 5f;
                        setWindowModeTextBlueFirstValue = true;
                        WindowModeTextBlueFirstValue = 0;
                        setWindowModeTextGreenFirstValue = true;
                        WindowModeTextGreenFirstValue = 0;
                        setWindowModeTextHeightFirstValue = true;
                        WindowModeTextHeightFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.WindowModeText.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                        }
                        if (interpolationValue < 1)
                        {
                            this.WindowModeText.Parent = this.GetGraphicalUiElementByName("WindowModeContainer");
                        }
                        setWindowModeTextRedFirstValue = true;
                        WindowModeTextRedFirstValue = 0;
                        if (interpolationValue < 1)
                        {
                            this.WindowModeText.Text = "Window mode:";
                        }
                        setWindowModeTextWidthFirstValue = true;
                        WindowModeTextWidthFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.WindowModeText.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                        }
                        if (interpolationValue < 1)
                        {
                            this.WindowModeText.XUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                        }
                        if (interpolationValue < 1)
                        {
                            this.WindowModeText.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.WindowModeText.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        break;
                }
                switch(secondState)
                {
                    case  VariableState.Default:
                        setBackButtonInstanceXSecondValue = true;
                        BackButtonInstanceXSecondValue = -40f;
                        if (interpolationValue >= 1)
                        {
                            this.BackButtonInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.BackButtonInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                        }
                        setBackButtonInstanceYSecondValue = true;
                        BackButtonInstanceYSecondValue = -40f;
                        if (interpolationValue >= 1)
                        {
                            this.BackButtonInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Bottom;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.BackButtonInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                        }
                        setBackgroundColorBlueSecondValue = true;
                        BackgroundColorBlueSecondValue = 128;
                        setBackgroundColorGreenSecondValue = true;
                        BackgroundColorGreenSecondValue = 128;
                        setBackgroundColorHeightSecondValue = true;
                        BackgroundColorHeightSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.BackgroundColor.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        setBackgroundColorRedSecondValue = true;
                        BackgroundColorRedSecondValue = 128;
                        setBackgroundColorWidthSecondValue = true;
                        BackgroundColorWidthSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.BackgroundColor.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        setBackgroundColorXSecondValue = true;
                        BackgroundColorXSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.BackgroundColor.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.BackgroundColor.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setBackgroundColorYSecondValue = true;
                        BackgroundColorYSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.BackgroundColor.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.BackgroundColor.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setCurrentMusicVolumeLabelHeightSecondValue = true;
                        CurrentMusicVolumeLabelHeightSecondValue = 100f;
                        if (interpolationValue >= 1)
                        {
                            this.CurrentMusicVolumeLabel.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setCurrentMusicVolumeLabelLabelTextAlphaSecondValue = true;
                        CurrentMusicVolumeLabelLabelTextAlphaSecondValue = 255;
                        setCurrentMusicVolumeLabelLabelTextBlueSecondValue = true;
                        CurrentMusicVolumeLabelLabelTextBlueSecondValue = 0;
                        setCurrentMusicVolumeLabelLabelTextGreenSecondValue = true;
                        CurrentMusicVolumeLabelLabelTextGreenSecondValue = 0;
                        setCurrentMusicVolumeLabelLabelTextRedSecondValue = true;
                        CurrentMusicVolumeLabelLabelTextRedSecondValue = 0;
                        if (interpolationValue >= 1)
                        {
                            this.CurrentMusicVolumeLabel.Parent = this.GetGraphicalUiElementByName("MusicContainer");
                        }
                        setCurrentMusicVolumeLabelWidthSecondValue = true;
                        CurrentMusicVolumeLabelWidthSecondValue = 10f;
                        if (interpolationValue >= 1)
                        {
                            this.CurrentMusicVolumeLabel.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setCurrentMusicVolumeLabelXSecondValue = true;
                        CurrentMusicVolumeLabelXSecondValue = 20f;
                        if (interpolationValue >= 1)
                        {
                            this.CurrentMusicVolumeLabel.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.CurrentMusicVolumeLabel.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setCurrentVolumeLabelHeightSecondValue = true;
                        CurrentVolumeLabelHeightSecondValue = 100f;
                        if (interpolationValue >= 1)
                        {
                            this.CurrentVolumeLabel.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setCurrentVolumeLabelLabelTextAlphaSecondValue = true;
                        CurrentVolumeLabelLabelTextAlphaSecondValue = 255;
                        setCurrentVolumeLabelLabelTextBlueSecondValue = true;
                        CurrentVolumeLabelLabelTextBlueSecondValue = 0;
                        setCurrentVolumeLabelLabelTextGreenSecondValue = true;
                        CurrentVolumeLabelLabelTextGreenSecondValue = 0;
                        setCurrentVolumeLabelLabelTextRedSecondValue = true;
                        CurrentVolumeLabelLabelTextRedSecondValue = 0;
                        if (interpolationValue >= 1)
                        {
                            this.CurrentVolumeLabel.Parent = this.GetGraphicalUiElementByName("VolumeContainer");
                        }
                        setCurrentVolumeLabelWidthSecondValue = true;
                        CurrentVolumeLabelWidthSecondValue = 10f;
                        if (interpolationValue >= 1)
                        {
                            this.CurrentVolumeLabel.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setCurrentVolumeLabelXSecondValue = true;
                        CurrentVolumeLabelXSecondValue = 20f;
                        if (interpolationValue >= 1)
                        {
                            this.CurrentVolumeLabel.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.CurrentVolumeLabel.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.GraphicsContainer.ChildrenLayout = Gum.Managers.ChildrenLayout.TopToBottomStack;
                        }
                        setGraphicsContainerHeightSecondValue = true;
                        GraphicsContainerHeightSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.GraphicsContainer.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.GraphicsContainer.Parent = this.GetGraphicalUiElementByName("GraphicsTopic");
                        }
                        setGraphicsContainerWidthSecondValue = true;
                        GraphicsContainerWidthSecondValue = 98f;
                        if (interpolationValue >= 1)
                        {
                            this.GraphicsContainer.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setGraphicsContainerXSecondValue = true;
                        GraphicsContainerXSecondValue = 1f;
                        if (interpolationValue >= 1)
                        {
                            this.GraphicsContainer.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setGraphicsContainerYSecondValue = true;
                        GraphicsContainerYSecondValue = 40f;
                        if (interpolationValue >= 1)
                        {
                            this.GraphicsTopic.ChildrenLayout = Gum.Managers.ChildrenLayout.Regular;
                        }
                        setGraphicsTopicHeightSecondValue = true;
                        GraphicsTopicHeightSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.GraphicsTopic.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.GraphicsTopic.TopicName = "Graphics";
                        }
                        setGraphicsTopicWidthSecondValue = true;
                        GraphicsTopicWidthSecondValue = 47f;
                        if (interpolationValue >= 1)
                        {
                            this.GraphicsTopic.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setGraphicsTopicXSecondValue = true;
                        GraphicsTopicXSecondValue = 2f;
                        if (interpolationValue >= 1)
                        {
                            this.GraphicsTopic.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setGraphicsTopicYSecondValue = true;
                        GraphicsTopicYSecondValue = 152f;
                        if (interpolationValue >= 1)
                        {
                            this.GraphicsTopic.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Top;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.MusicContainer.ChildrenLayout = Gum.Managers.ChildrenLayout.Regular;
                        }
                        setMusicContainerHeightSecondValue = true;
                        MusicContainerHeightSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.MusicContainer.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.MusicContainer.Parent = this.GetGraphicalUiElementByName("SoundContainer");
                        }
                        setMusicContainerWidthSecondValue = true;
                        MusicContainerWidthSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.MusicContainer.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        setMusicMaxTextBlueSecondValue = true;
                        MusicMaxTextBlueSecondValue = 0;
                        setMusicMaxTextFontSizeSecondValue = true;
                        MusicMaxTextFontSizeSecondValue = 24;
                        setMusicMaxTextGreenSecondValue = true;
                        MusicMaxTextGreenSecondValue = 0;
                        setMusicMaxTextHeightSecondValue = true;
                        MusicMaxTextHeightSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.MusicMaxText.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.MusicMaxText.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.MusicMaxText.Parent = this.GetGraphicalUiElementByName("MusicSlider");
                        }
                        setMusicMaxTextRedSecondValue = true;
                        MusicMaxTextRedSecondValue = 0;
                        if (interpolationValue >= 1)
                        {
                            this.MusicMaxText.Text = "100";
                        }
                        setMusicMaxTextWidthSecondValue = true;
                        MusicMaxTextWidthSecondValue = 5f;
                        if (interpolationValue >= 1)
                        {
                            this.MusicMaxText.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.MusicMaxText.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.MusicMaxText.XUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.MusicMaxText.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.MusicMaxText.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setMusicMinTextBlueSecondValue = true;
                        MusicMinTextBlueSecondValue = 0;
                        setMusicMinTextFontSizeSecondValue = true;
                        MusicMinTextFontSizeSecondValue = 24;
                        setMusicMinTextGreenSecondValue = true;
                        MusicMinTextGreenSecondValue = 0;
                        setMusicMinTextHeightSecondValue = true;
                        MusicMinTextHeightSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.MusicMinText.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.MusicMinText.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.MusicMinText.Parent = this.GetGraphicalUiElementByName("MusicSlider");
                        }
                        setMusicMinTextRedSecondValue = true;
                        MusicMinTextRedSecondValue = 0;
                        if (interpolationValue >= 1)
                        {
                            this.MusicMinText.Text = "0";
                        }
                        if (interpolationValue >= 1)
                        {
                            this.MusicMinText.VerticalAlignment = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        setMusicMinTextWidthSecondValue = true;
                        MusicMinTextWidthSecondValue = 2f;
                        if (interpolationValue >= 1)
                        {
                            this.MusicMinText.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.MusicMinText.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.MusicMinText.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setMusicSliderHeightSecondValue = true;
                        MusicSliderHeightSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.MusicSlider.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.MusicSlider.Parent = this.GetGraphicalUiElementByName("MusicContainer");
                        }
                        setMusicSliderWidthSecondValue = true;
                        MusicSliderWidthSecondValue = 80f;
                        if (interpolationValue >= 1)
                        {
                            this.MusicSlider.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.MusicSlider.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.MusicSlider.XUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.MusicSliderInstance.Parent = this.GetGraphicalUiElementByName("MusicSlider");
                        }
                        setMusicSliderInstanceWidthSecondValue = true;
                        MusicSliderInstanceWidthSecondValue = 92f;
                        if (interpolationValue >= 1)
                        {
                            this.MusicSliderInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setMusicSliderInstanceXSecondValue = true;
                        MusicSliderInstanceXSecondValue = 2f;
                        if (interpolationValue >= 1)
                        {
                            this.MusicSliderInstance.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setMusicTextBlueSecondValue = true;
                        MusicTextBlueSecondValue = 0;
                        setMusicTextGreenSecondValue = true;
                        MusicTextGreenSecondValue = 0;
                        setMusicTextHeightSecondValue = true;
                        MusicTextHeightSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.MusicText.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.MusicText.Parent = this.GetGraphicalUiElementByName("MusicContainer");
                        }
                        setMusicTextRedSecondValue = true;
                        MusicTextRedSecondValue = 0;
                        if (interpolationValue >= 1)
                        {
                            this.MusicText.Text = "Music";
                        }
                        setMusicTextWidthSecondValue = true;
                        MusicTextWidthSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.MusicText.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.MusicText.XUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.MusicText.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.MusicText.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setRectangleInstanceBlueSecondValue = true;
                        RectangleInstanceBlueSecondValue = 0;
                        setRectangleInstanceGreenSecondValue = true;
                        RectangleInstanceGreenSecondValue = 0;
                        setRectangleInstanceHeightSecondValue = true;
                        RectangleInstanceHeightSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.RectangleInstance.Parent = this.GetGraphicalUiElementByName("VolumeContainer");
                        }
                        setRectangleInstanceRedSecondValue = true;
                        RectangleInstanceRedSecondValue = 0;
                        setRectangleInstanceWidthSecondValue = true;
                        RectangleInstanceWidthSecondValue = 100f;
                        if (interpolationValue >= 1)
                        {
                            this.RectangleInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.RectangleInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                        }
                        setResolutionComboBoxListBoxInstanceHeightSecondValue = true;
                        ResolutionComboBoxListBoxInstanceHeightSecondValue = 96f;
                        if (interpolationValue >= 1)
                        {
                            this.ResolutionComboBox.Parent = this.GetGraphicalUiElementByName("ResolutionContainer");
                        }
                        setResolutionComboBoxWidthSecondValue = true;
                        ResolutionComboBoxWidthSecondValue = 50f;
                        if (interpolationValue >= 1)
                        {
                            this.ResolutionComboBox.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.ResolutionComboBox.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.ResolutionComboBox.XUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                        }
                        setResolutionContainerHeightSecondValue = true;
                        ResolutionContainerHeightSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.ResolutionContainer.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.ResolutionContainer.Parent = this.GetGraphicalUiElementByName("GraphicsContainer");
                        }
                        setResolutionContainerWidthSecondValue = true;
                        ResolutionContainerWidthSecondValue = 100f;
                        if (interpolationValue >= 1)
                        {
                            this.ResolutionContainer.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setResolutionContainerXSecondValue = true;
                        ResolutionContainerXSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.ResolutionContainer.XUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                        }
                        setResolutionContainerYSecondValue = true;
                        ResolutionContainerYSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.ResolutionContainer.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Top;
                        }
                        setResolutionTextBlueSecondValue = true;
                        ResolutionTextBlueSecondValue = 0;
                        setResolutionTextGreenSecondValue = true;
                        ResolutionTextGreenSecondValue = 0;
                        setResolutionTextHeightSecondValue = true;
                        ResolutionTextHeightSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.ResolutionText.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.ResolutionText.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.ResolutionText.Parent = this.GetGraphicalUiElementByName("ResolutionContainer");
                        }
                        setResolutionTextRedSecondValue = true;
                        ResolutionTextRedSecondValue = 0;
                        if (interpolationValue >= 1)
                        {
                            this.ResolutionText.Text = "Resolution:";
                        }
                        if (interpolationValue >= 1)
                        {
                            this.ResolutionText.VerticalAlignment = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        setResolutionTextWidthSecondValue = true;
                        ResolutionTextWidthSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.ResolutionText.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.ResolutionText.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.ResolutionText.XUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.ResolutionText.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.ResolutionText.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setSettingsTextBlueSecondValue = true;
                        SettingsTextBlueSecondValue = 0;
                        setSettingsTextFontSizeSecondValue = true;
                        SettingsTextFontSizeSecondValue = 72;
                        setSettingsTextGreenSecondValue = true;
                        SettingsTextGreenSecondValue = 0;
                        setSettingsTextRedSecondValue = true;
                        SettingsTextRedSecondValue = 0;
                        if (interpolationValue >= 1)
                        {
                            this.SettingsText.Text = "Settings";
                        }
                        setSettingsTextXSecondValue = true;
                        SettingsTextXSecondValue = 2f;
                        if (interpolationValue >= 1)
                        {
                            this.SettingsText.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setSettingsTextYSecondValue = true;
                        SettingsTextYSecondValue = 40f;
                        if (interpolationValue >= 1)
                        {
                            this.SoudTopic.ChildrenLayout = Gum.Managers.ChildrenLayout.Regular;
                        }
                        setSoudTopicHeightSecondValue = true;
                        SoudTopicHeightSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.SoudTopic.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.SoudTopic.TopicName = "Sound";
                        }
                        setSoudTopicWidthSecondValue = true;
                        SoudTopicWidthSecondValue = 47f;
                        if (interpolationValue >= 1)
                        {
                            this.SoudTopic.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setSoudTopicXSecondValue = true;
                        SoudTopicXSecondValue = 98f;
                        if (interpolationValue >= 1)
                        {
                            this.SoudTopic.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.SoudTopic.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setSoudTopicYSecondValue = true;
                        SoudTopicYSecondValue = 152f;
                        if (interpolationValue >= 1)
                        {
                            this.SoundContainer.ChildrenLayout = Gum.Managers.ChildrenLayout.TopToBottomStack;
                        }
                        setSoundContainerHeightSecondValue = true;
                        SoundContainerHeightSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.SoundContainer.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.SoundContainer.Parent = this.GetGraphicalUiElementByName("SoudTopic");
                        }
                        setSoundContainerWidthSecondValue = true;
                        SoundContainerWidthSecondValue = 98f;
                        if (interpolationValue >= 1)
                        {
                            this.SoundContainer.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setSoundContainerXSecondValue = true;
                        SoundContainerXSecondValue = 1f;
                        if (interpolationValue >= 1)
                        {
                            this.SoundContainer.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setSoundContainerYSecondValue = true;
                        SoundContainerYSecondValue = 40f;
                        if (interpolationValue >= 1)
                        {
                            this.VolumeContainer.ChildrenLayout = Gum.Managers.ChildrenLayout.Regular;
                        }
                        setVolumeContainerHeightSecondValue = true;
                        VolumeContainerHeightSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.VolumeContainer.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.VolumeContainer.Parent = this.GetGraphicalUiElementByName("SoundContainer");
                        }
                        setVolumeContainerWidthSecondValue = true;
                        VolumeContainerWidthSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.VolumeContainer.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        setVolumeMaxTextBlueSecondValue = true;
                        VolumeMaxTextBlueSecondValue = 0;
                        setVolumeMaxTextFontSizeSecondValue = true;
                        VolumeMaxTextFontSizeSecondValue = 24;
                        setVolumeMaxTextGreenSecondValue = true;
                        VolumeMaxTextGreenSecondValue = 0;
                        setVolumeMaxTextHeightSecondValue = true;
                        VolumeMaxTextHeightSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.VolumeMaxText.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.VolumeMaxText.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.VolumeMaxText.Parent = this.GetGraphicalUiElementByName("VolumeSlider");
                        }
                        setVolumeMaxTextRedSecondValue = true;
                        VolumeMaxTextRedSecondValue = 0;
                        if (interpolationValue >= 1)
                        {
                            this.VolumeMaxText.Text = "100";
                        }
                        setVolumeMaxTextWidthSecondValue = true;
                        VolumeMaxTextWidthSecondValue = 5f;
                        if (interpolationValue >= 1)
                        {
                            this.VolumeMaxText.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.VolumeMaxText.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.VolumeMaxText.XUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.VolumeMaxText.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.VolumeMaxText.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setVolumeMinTextBlueSecondValue = true;
                        VolumeMinTextBlueSecondValue = 0;
                        setVolumeMinTextFontSizeSecondValue = true;
                        VolumeMinTextFontSizeSecondValue = 24;
                        setVolumeMinTextGreenSecondValue = true;
                        VolumeMinTextGreenSecondValue = 0;
                        setVolumeMinTextHeightSecondValue = true;
                        VolumeMinTextHeightSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.VolumeMinText.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.VolumeMinText.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.VolumeMinText.Parent = this.GetGraphicalUiElementByName("VolumeSlider");
                        }
                        setVolumeMinTextRedSecondValue = true;
                        VolumeMinTextRedSecondValue = 0;
                        if (interpolationValue >= 1)
                        {
                            this.VolumeMinText.Text = "0";
                        }
                        if (interpolationValue >= 1)
                        {
                            this.VolumeMinText.VerticalAlignment = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        setVolumeMinTextWidthSecondValue = true;
                        VolumeMinTextWidthSecondValue = 2f;
                        if (interpolationValue >= 1)
                        {
                            this.VolumeMinText.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.VolumeMinText.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.VolumeMinText.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setVolumeSliderHeightSecondValue = true;
                        VolumeSliderHeightSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.VolumeSlider.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.VolumeSlider.Parent = this.GetGraphicalUiElementByName("VolumeContainer");
                        }
                        setVolumeSliderWidthSecondValue = true;
                        VolumeSliderWidthSecondValue = 80f;
                        if (interpolationValue >= 1)
                        {
                            this.VolumeSlider.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.VolumeSlider.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.VolumeSlider.XUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.VolumeSliderInstance.Parent = this.GetGraphicalUiElementByName("VolumeSlider");
                        }
                        setVolumeSliderInstanceWidthSecondValue = true;
                        VolumeSliderInstanceWidthSecondValue = 92f;
                        if (interpolationValue >= 1)
                        {
                            this.VolumeSliderInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setVolumeSliderInstanceXSecondValue = true;
                        VolumeSliderInstanceXSecondValue = 2f;
                        if (interpolationValue >= 1)
                        {
                            this.VolumeSliderInstance.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setVolumeTextBlueSecondValue = true;
                        VolumeTextBlueSecondValue = 0;
                        setVolumeTextGreenSecondValue = true;
                        VolumeTextGreenSecondValue = 0;
                        setVolumeTextHeightSecondValue = true;
                        VolumeTextHeightSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.VolumeText.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.VolumeText.Parent = this.GetGraphicalUiElementByName("VolumeContainer");
                        }
                        setVolumeTextRedSecondValue = true;
                        VolumeTextRedSecondValue = 0;
                        if (interpolationValue >= 1)
                        {
                            this.VolumeText.Text = "Volume:";
                        }
                        setVolumeTextWidthSecondValue = true;
                        VolumeTextWidthSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.VolumeText.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.VolumeText.XUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.VolumeText.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.VolumeText.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setWindowModeComboBoxListBoxInstanceHeightSecondValue = true;
                        WindowModeComboBoxListBoxInstanceHeightSecondValue = 64f;
                        if (interpolationValue >= 1)
                        {
                            this.WindowModeComboBox.Parent = this.GetGraphicalUiElementByName("WindowModeContainer");
                        }
                        setWindowModeComboBoxWidthSecondValue = true;
                        WindowModeComboBoxWidthSecondValue = 50f;
                        if (interpolationValue >= 1)
                        {
                            this.WindowModeComboBox.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.WindowModeComboBox.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.WindowModeComboBox.XUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                        }
                        setWindowModeContainerHeightSecondValue = true;
                        WindowModeContainerHeightSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.WindowModeContainer.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.WindowModeContainer.Parent = this.GetGraphicalUiElementByName("GraphicsContainer");
                        }
                        setWindowModeContainerWidthSecondValue = true;
                        WindowModeContainerWidthSecondValue = 100f;
                        if (interpolationValue >= 1)
                        {
                            this.WindowModeContainer.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setWindowModeContainerXSecondValue = true;
                        WindowModeContainerXSecondValue = 0f;
                        setWindowModeContainerYSecondValue = true;
                        WindowModeContainerYSecondValue = 5f;
                        setWindowModeTextBlueSecondValue = true;
                        WindowModeTextBlueSecondValue = 0;
                        setWindowModeTextGreenSecondValue = true;
                        WindowModeTextGreenSecondValue = 0;
                        setWindowModeTextHeightSecondValue = true;
                        WindowModeTextHeightSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.WindowModeText.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.WindowModeText.Parent = this.GetGraphicalUiElementByName("WindowModeContainer");
                        }
                        setWindowModeTextRedSecondValue = true;
                        WindowModeTextRedSecondValue = 0;
                        if (interpolationValue >= 1)
                        {
                            this.WindowModeText.Text = "Window mode:";
                        }
                        setWindowModeTextWidthSecondValue = true;
                        WindowModeTextWidthSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.WindowModeText.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.WindowModeText.XUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.WindowModeText.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.WindowModeText.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        break;
                }
                var wasSuppressed = mIsLayoutSuspended;
                if (wasSuppressed == false)
                {
                    SuspendLayout(true);
                }
                if (setBackButtonInstanceXFirstValue && setBackButtonInstanceXSecondValue)
                {
                    BackButtonInstance.X = BackButtonInstanceXFirstValue * (1 - interpolationValue) + BackButtonInstanceXSecondValue * interpolationValue;
                }
                if (setBackButtonInstanceYFirstValue && setBackButtonInstanceYSecondValue)
                {
                    BackButtonInstance.Y = BackButtonInstanceYFirstValue * (1 - interpolationValue) + BackButtonInstanceYSecondValue * interpolationValue;
                }
                if (setBackgroundColorBlueFirstValue && setBackgroundColorBlueSecondValue)
                {
                    BackgroundColor.Blue = FlatRedBall.Math.MathFunctions.RoundToInt(BackgroundColorBlueFirstValue* (1 - interpolationValue) + BackgroundColorBlueSecondValue * interpolationValue);
                }
                if (setBackgroundColorGreenFirstValue && setBackgroundColorGreenSecondValue)
                {
                    BackgroundColor.Green = FlatRedBall.Math.MathFunctions.RoundToInt(BackgroundColorGreenFirstValue* (1 - interpolationValue) + BackgroundColorGreenSecondValue * interpolationValue);
                }
                if (setBackgroundColorHeightFirstValue && setBackgroundColorHeightSecondValue)
                {
                    BackgroundColor.Height = BackgroundColorHeightFirstValue * (1 - interpolationValue) + BackgroundColorHeightSecondValue * interpolationValue;
                }
                if (setBackgroundColorRedFirstValue && setBackgroundColorRedSecondValue)
                {
                    BackgroundColor.Red = FlatRedBall.Math.MathFunctions.RoundToInt(BackgroundColorRedFirstValue* (1 - interpolationValue) + BackgroundColorRedSecondValue * interpolationValue);
                }
                if (setBackgroundColorWidthFirstValue && setBackgroundColorWidthSecondValue)
                {
                    BackgroundColor.Width = BackgroundColorWidthFirstValue * (1 - interpolationValue) + BackgroundColorWidthSecondValue * interpolationValue;
                }
                if (setBackgroundColorXFirstValue && setBackgroundColorXSecondValue)
                {
                    BackgroundColor.X = BackgroundColorXFirstValue * (1 - interpolationValue) + BackgroundColorXSecondValue * interpolationValue;
                }
                if (setBackgroundColorYFirstValue && setBackgroundColorYSecondValue)
                {
                    BackgroundColor.Y = BackgroundColorYFirstValue * (1 - interpolationValue) + BackgroundColorYSecondValue * interpolationValue;
                }
                if (setCurrentMusicVolumeLabelHeightFirstValue && setCurrentMusicVolumeLabelHeightSecondValue)
                {
                    CurrentMusicVolumeLabel.Height = CurrentMusicVolumeLabelHeightFirstValue * (1 - interpolationValue) + CurrentMusicVolumeLabelHeightSecondValue * interpolationValue;
                }
                if (setCurrentMusicVolumeLabelLabelTextAlphaFirstValue && setCurrentMusicVolumeLabelLabelTextAlphaSecondValue)
                {
                    CurrentMusicVolumeLabel.LabelTextAlpha = FlatRedBall.Math.MathFunctions.RoundToInt(CurrentMusicVolumeLabelLabelTextAlphaFirstValue* (1 - interpolationValue) + CurrentMusicVolumeLabelLabelTextAlphaSecondValue * interpolationValue);
                }
                if (setCurrentMusicVolumeLabelLabelTextBlueFirstValue && setCurrentMusicVolumeLabelLabelTextBlueSecondValue)
                {
                    CurrentMusicVolumeLabel.LabelTextBlue = FlatRedBall.Math.MathFunctions.RoundToInt(CurrentMusicVolumeLabelLabelTextBlueFirstValue* (1 - interpolationValue) + CurrentMusicVolumeLabelLabelTextBlueSecondValue * interpolationValue);
                }
                if (setCurrentMusicVolumeLabelLabelTextGreenFirstValue && setCurrentMusicVolumeLabelLabelTextGreenSecondValue)
                {
                    CurrentMusicVolumeLabel.LabelTextGreen = FlatRedBall.Math.MathFunctions.RoundToInt(CurrentMusicVolumeLabelLabelTextGreenFirstValue* (1 - interpolationValue) + CurrentMusicVolumeLabelLabelTextGreenSecondValue * interpolationValue);
                }
                if (setCurrentMusicVolumeLabelLabelTextRedFirstValue && setCurrentMusicVolumeLabelLabelTextRedSecondValue)
                {
                    CurrentMusicVolumeLabel.LabelTextRed = FlatRedBall.Math.MathFunctions.RoundToInt(CurrentMusicVolumeLabelLabelTextRedFirstValue* (1 - interpolationValue) + CurrentMusicVolumeLabelLabelTextRedSecondValue * interpolationValue);
                }
                if (setCurrentMusicVolumeLabelWidthFirstValue && setCurrentMusicVolumeLabelWidthSecondValue)
                {
                    CurrentMusicVolumeLabel.Width = CurrentMusicVolumeLabelWidthFirstValue * (1 - interpolationValue) + CurrentMusicVolumeLabelWidthSecondValue * interpolationValue;
                }
                if (setCurrentMusicVolumeLabelXFirstValue && setCurrentMusicVolumeLabelXSecondValue)
                {
                    CurrentMusicVolumeLabel.X = CurrentMusicVolumeLabelXFirstValue * (1 - interpolationValue) + CurrentMusicVolumeLabelXSecondValue * interpolationValue;
                }
                if (setCurrentVolumeLabelHeightFirstValue && setCurrentVolumeLabelHeightSecondValue)
                {
                    CurrentVolumeLabel.Height = CurrentVolumeLabelHeightFirstValue * (1 - interpolationValue) + CurrentVolumeLabelHeightSecondValue * interpolationValue;
                }
                if (setCurrentVolumeLabelLabelTextAlphaFirstValue && setCurrentVolumeLabelLabelTextAlphaSecondValue)
                {
                    CurrentVolumeLabel.LabelTextAlpha = FlatRedBall.Math.MathFunctions.RoundToInt(CurrentVolumeLabelLabelTextAlphaFirstValue* (1 - interpolationValue) + CurrentVolumeLabelLabelTextAlphaSecondValue * interpolationValue);
                }
                if (setCurrentVolumeLabelLabelTextBlueFirstValue && setCurrentVolumeLabelLabelTextBlueSecondValue)
                {
                    CurrentVolumeLabel.LabelTextBlue = FlatRedBall.Math.MathFunctions.RoundToInt(CurrentVolumeLabelLabelTextBlueFirstValue* (1 - interpolationValue) + CurrentVolumeLabelLabelTextBlueSecondValue * interpolationValue);
                }
                if (setCurrentVolumeLabelLabelTextGreenFirstValue && setCurrentVolumeLabelLabelTextGreenSecondValue)
                {
                    CurrentVolumeLabel.LabelTextGreen = FlatRedBall.Math.MathFunctions.RoundToInt(CurrentVolumeLabelLabelTextGreenFirstValue* (1 - interpolationValue) + CurrentVolumeLabelLabelTextGreenSecondValue * interpolationValue);
                }
                if (setCurrentVolumeLabelLabelTextRedFirstValue && setCurrentVolumeLabelLabelTextRedSecondValue)
                {
                    CurrentVolumeLabel.LabelTextRed = FlatRedBall.Math.MathFunctions.RoundToInt(CurrentVolumeLabelLabelTextRedFirstValue* (1 - interpolationValue) + CurrentVolumeLabelLabelTextRedSecondValue * interpolationValue);
                }
                if (setCurrentVolumeLabelWidthFirstValue && setCurrentVolumeLabelWidthSecondValue)
                {
                    CurrentVolumeLabel.Width = CurrentVolumeLabelWidthFirstValue * (1 - interpolationValue) + CurrentVolumeLabelWidthSecondValue * interpolationValue;
                }
                if (setCurrentVolumeLabelXFirstValue && setCurrentVolumeLabelXSecondValue)
                {
                    CurrentVolumeLabel.X = CurrentVolumeLabelXFirstValue * (1 - interpolationValue) + CurrentVolumeLabelXSecondValue * interpolationValue;
                }
                if (setGraphicsContainerHeightFirstValue && setGraphicsContainerHeightSecondValue)
                {
                    GraphicsContainer.Height = GraphicsContainerHeightFirstValue * (1 - interpolationValue) + GraphicsContainerHeightSecondValue * interpolationValue;
                }
                if (setGraphicsContainerWidthFirstValue && setGraphicsContainerWidthSecondValue)
                {
                    GraphicsContainer.Width = GraphicsContainerWidthFirstValue * (1 - interpolationValue) + GraphicsContainerWidthSecondValue * interpolationValue;
                }
                if (setGraphicsContainerXFirstValue && setGraphicsContainerXSecondValue)
                {
                    GraphicsContainer.X = GraphicsContainerXFirstValue * (1 - interpolationValue) + GraphicsContainerXSecondValue * interpolationValue;
                }
                if (setGraphicsContainerYFirstValue && setGraphicsContainerYSecondValue)
                {
                    GraphicsContainer.Y = GraphicsContainerYFirstValue * (1 - interpolationValue) + GraphicsContainerYSecondValue * interpolationValue;
                }
                if (setGraphicsTopicHeightFirstValue && setGraphicsTopicHeightSecondValue)
                {
                    GraphicsTopic.Height = GraphicsTopicHeightFirstValue * (1 - interpolationValue) + GraphicsTopicHeightSecondValue * interpolationValue;
                }
                if (setGraphicsTopicWidthFirstValue && setGraphicsTopicWidthSecondValue)
                {
                    GraphicsTopic.Width = GraphicsTopicWidthFirstValue * (1 - interpolationValue) + GraphicsTopicWidthSecondValue * interpolationValue;
                }
                if (setGraphicsTopicXFirstValue && setGraphicsTopicXSecondValue)
                {
                    GraphicsTopic.X = GraphicsTopicXFirstValue * (1 - interpolationValue) + GraphicsTopicXSecondValue * interpolationValue;
                }
                if (setGraphicsTopicYFirstValue && setGraphicsTopicYSecondValue)
                {
                    GraphicsTopic.Y = GraphicsTopicYFirstValue * (1 - interpolationValue) + GraphicsTopicYSecondValue * interpolationValue;
                }
                if (setMusicContainerHeightFirstValue && setMusicContainerHeightSecondValue)
                {
                    MusicContainer.Height = MusicContainerHeightFirstValue * (1 - interpolationValue) + MusicContainerHeightSecondValue * interpolationValue;
                }
                if (setMusicContainerWidthFirstValue && setMusicContainerWidthSecondValue)
                {
                    MusicContainer.Width = MusicContainerWidthFirstValue * (1 - interpolationValue) + MusicContainerWidthSecondValue * interpolationValue;
                }
                if (setMusicMaxTextBlueFirstValue && setMusicMaxTextBlueSecondValue)
                {
                    MusicMaxText.Blue = FlatRedBall.Math.MathFunctions.RoundToInt(MusicMaxTextBlueFirstValue* (1 - interpolationValue) + MusicMaxTextBlueSecondValue * interpolationValue);
                }
                if (setMusicMaxTextFontSizeFirstValue && setMusicMaxTextFontSizeSecondValue)
                {
                    MusicMaxText.FontSize = FlatRedBall.Math.MathFunctions.RoundToInt(MusicMaxTextFontSizeFirstValue* (1 - interpolationValue) + MusicMaxTextFontSizeSecondValue * interpolationValue);
                }
                if (setMusicMaxTextGreenFirstValue && setMusicMaxTextGreenSecondValue)
                {
                    MusicMaxText.Green = FlatRedBall.Math.MathFunctions.RoundToInt(MusicMaxTextGreenFirstValue* (1 - interpolationValue) + MusicMaxTextGreenSecondValue * interpolationValue);
                }
                if (setMusicMaxTextHeightFirstValue && setMusicMaxTextHeightSecondValue)
                {
                    MusicMaxText.Height = MusicMaxTextHeightFirstValue * (1 - interpolationValue) + MusicMaxTextHeightSecondValue * interpolationValue;
                }
                if (setMusicMaxTextRedFirstValue && setMusicMaxTextRedSecondValue)
                {
                    MusicMaxText.Red = FlatRedBall.Math.MathFunctions.RoundToInt(MusicMaxTextRedFirstValue* (1 - interpolationValue) + MusicMaxTextRedSecondValue * interpolationValue);
                }
                if (setMusicMaxTextWidthFirstValue && setMusicMaxTextWidthSecondValue)
                {
                    MusicMaxText.Width = MusicMaxTextWidthFirstValue * (1 - interpolationValue) + MusicMaxTextWidthSecondValue * interpolationValue;
                }
                if (setMusicMinTextBlueFirstValue && setMusicMinTextBlueSecondValue)
                {
                    MusicMinText.Blue = FlatRedBall.Math.MathFunctions.RoundToInt(MusicMinTextBlueFirstValue* (1 - interpolationValue) + MusicMinTextBlueSecondValue * interpolationValue);
                }
                if (setMusicMinTextFontSizeFirstValue && setMusicMinTextFontSizeSecondValue)
                {
                    MusicMinText.FontSize = FlatRedBall.Math.MathFunctions.RoundToInt(MusicMinTextFontSizeFirstValue* (1 - interpolationValue) + MusicMinTextFontSizeSecondValue * interpolationValue);
                }
                if (setMusicMinTextGreenFirstValue && setMusicMinTextGreenSecondValue)
                {
                    MusicMinText.Green = FlatRedBall.Math.MathFunctions.RoundToInt(MusicMinTextGreenFirstValue* (1 - interpolationValue) + MusicMinTextGreenSecondValue * interpolationValue);
                }
                if (setMusicMinTextHeightFirstValue && setMusicMinTextHeightSecondValue)
                {
                    MusicMinText.Height = MusicMinTextHeightFirstValue * (1 - interpolationValue) + MusicMinTextHeightSecondValue * interpolationValue;
                }
                if (setMusicMinTextRedFirstValue && setMusicMinTextRedSecondValue)
                {
                    MusicMinText.Red = FlatRedBall.Math.MathFunctions.RoundToInt(MusicMinTextRedFirstValue* (1 - interpolationValue) + MusicMinTextRedSecondValue * interpolationValue);
                }
                if (setMusicMinTextWidthFirstValue && setMusicMinTextWidthSecondValue)
                {
                    MusicMinText.Width = MusicMinTextWidthFirstValue * (1 - interpolationValue) + MusicMinTextWidthSecondValue * interpolationValue;
                }
                if (setMusicSliderHeightFirstValue && setMusicSliderHeightSecondValue)
                {
                    MusicSlider.Height = MusicSliderHeightFirstValue * (1 - interpolationValue) + MusicSliderHeightSecondValue * interpolationValue;
                }
                if (setMusicSliderWidthFirstValue && setMusicSliderWidthSecondValue)
                {
                    MusicSlider.Width = MusicSliderWidthFirstValue * (1 - interpolationValue) + MusicSliderWidthSecondValue * interpolationValue;
                }
                if (setMusicSliderInstanceWidthFirstValue && setMusicSliderInstanceWidthSecondValue)
                {
                    MusicSliderInstance.Width = MusicSliderInstanceWidthFirstValue * (1 - interpolationValue) + MusicSliderInstanceWidthSecondValue * interpolationValue;
                }
                if (setMusicSliderInstanceXFirstValue && setMusicSliderInstanceXSecondValue)
                {
                    MusicSliderInstance.X = MusicSliderInstanceXFirstValue * (1 - interpolationValue) + MusicSliderInstanceXSecondValue * interpolationValue;
                }
                if (setMusicTextBlueFirstValue && setMusicTextBlueSecondValue)
                {
                    MusicText.Blue = FlatRedBall.Math.MathFunctions.RoundToInt(MusicTextBlueFirstValue* (1 - interpolationValue) + MusicTextBlueSecondValue * interpolationValue);
                }
                if (setMusicTextGreenFirstValue && setMusicTextGreenSecondValue)
                {
                    MusicText.Green = FlatRedBall.Math.MathFunctions.RoundToInt(MusicTextGreenFirstValue* (1 - interpolationValue) + MusicTextGreenSecondValue * interpolationValue);
                }
                if (setMusicTextHeightFirstValue && setMusicTextHeightSecondValue)
                {
                    MusicText.Height = MusicTextHeightFirstValue * (1 - interpolationValue) + MusicTextHeightSecondValue * interpolationValue;
                }
                if (setMusicTextRedFirstValue && setMusicTextRedSecondValue)
                {
                    MusicText.Red = FlatRedBall.Math.MathFunctions.RoundToInt(MusicTextRedFirstValue* (1 - interpolationValue) + MusicTextRedSecondValue * interpolationValue);
                }
                if (setMusicTextWidthFirstValue && setMusicTextWidthSecondValue)
                {
                    MusicText.Width = MusicTextWidthFirstValue * (1 - interpolationValue) + MusicTextWidthSecondValue * interpolationValue;
                }
                if (setRectangleInstanceBlueFirstValue && setRectangleInstanceBlueSecondValue)
                {
                    RectangleInstance.Blue = FlatRedBall.Math.MathFunctions.RoundToInt(RectangleInstanceBlueFirstValue* (1 - interpolationValue) + RectangleInstanceBlueSecondValue * interpolationValue);
                }
                if (setRectangleInstanceGreenFirstValue && setRectangleInstanceGreenSecondValue)
                {
                    RectangleInstance.Green = FlatRedBall.Math.MathFunctions.RoundToInt(RectangleInstanceGreenFirstValue* (1 - interpolationValue) + RectangleInstanceGreenSecondValue * interpolationValue);
                }
                if (setRectangleInstanceHeightFirstValue && setRectangleInstanceHeightSecondValue)
                {
                    RectangleInstance.Height = RectangleInstanceHeightFirstValue * (1 - interpolationValue) + RectangleInstanceHeightSecondValue * interpolationValue;
                }
                if (setRectangleInstanceRedFirstValue && setRectangleInstanceRedSecondValue)
                {
                    RectangleInstance.Red = FlatRedBall.Math.MathFunctions.RoundToInt(RectangleInstanceRedFirstValue* (1 - interpolationValue) + RectangleInstanceRedSecondValue * interpolationValue);
                }
                if (setRectangleInstanceWidthFirstValue && setRectangleInstanceWidthSecondValue)
                {
                    RectangleInstance.Width = RectangleInstanceWidthFirstValue * (1 - interpolationValue) + RectangleInstanceWidthSecondValue * interpolationValue;
                }
                if (setResolutionComboBoxListBoxInstanceHeightFirstValue && setResolutionComboBoxListBoxInstanceHeightSecondValue)
                {
                    ResolutionComboBox.ListBoxInstanceHeight = ResolutionComboBoxListBoxInstanceHeightFirstValue * (1 - interpolationValue) + ResolutionComboBoxListBoxInstanceHeightSecondValue * interpolationValue;
                }
                if (setResolutionComboBoxWidthFirstValue && setResolutionComboBoxWidthSecondValue)
                {
                    ResolutionComboBox.Width = ResolutionComboBoxWidthFirstValue * (1 - interpolationValue) + ResolutionComboBoxWidthSecondValue * interpolationValue;
                }
                if (setResolutionContainerHeightFirstValue && setResolutionContainerHeightSecondValue)
                {
                    ResolutionContainer.Height = ResolutionContainerHeightFirstValue * (1 - interpolationValue) + ResolutionContainerHeightSecondValue * interpolationValue;
                }
                if (setResolutionContainerWidthFirstValue && setResolutionContainerWidthSecondValue)
                {
                    ResolutionContainer.Width = ResolutionContainerWidthFirstValue * (1 - interpolationValue) + ResolutionContainerWidthSecondValue * interpolationValue;
                }
                if (setResolutionContainerXFirstValue && setResolutionContainerXSecondValue)
                {
                    ResolutionContainer.X = ResolutionContainerXFirstValue * (1 - interpolationValue) + ResolutionContainerXSecondValue * interpolationValue;
                }
                if (setResolutionContainerYFirstValue && setResolutionContainerYSecondValue)
                {
                    ResolutionContainer.Y = ResolutionContainerYFirstValue * (1 - interpolationValue) + ResolutionContainerYSecondValue * interpolationValue;
                }
                if (setResolutionTextBlueFirstValue && setResolutionTextBlueSecondValue)
                {
                    ResolutionText.Blue = FlatRedBall.Math.MathFunctions.RoundToInt(ResolutionTextBlueFirstValue* (1 - interpolationValue) + ResolutionTextBlueSecondValue * interpolationValue);
                }
                if (setResolutionTextGreenFirstValue && setResolutionTextGreenSecondValue)
                {
                    ResolutionText.Green = FlatRedBall.Math.MathFunctions.RoundToInt(ResolutionTextGreenFirstValue* (1 - interpolationValue) + ResolutionTextGreenSecondValue * interpolationValue);
                }
                if (setResolutionTextHeightFirstValue && setResolutionTextHeightSecondValue)
                {
                    ResolutionText.Height = ResolutionTextHeightFirstValue * (1 - interpolationValue) + ResolutionTextHeightSecondValue * interpolationValue;
                }
                if (setResolutionTextRedFirstValue && setResolutionTextRedSecondValue)
                {
                    ResolutionText.Red = FlatRedBall.Math.MathFunctions.RoundToInt(ResolutionTextRedFirstValue* (1 - interpolationValue) + ResolutionTextRedSecondValue * interpolationValue);
                }
                if (setResolutionTextWidthFirstValue && setResolutionTextWidthSecondValue)
                {
                    ResolutionText.Width = ResolutionTextWidthFirstValue * (1 - interpolationValue) + ResolutionTextWidthSecondValue * interpolationValue;
                }
                if (setSettingsTextBlueFirstValue && setSettingsTextBlueSecondValue)
                {
                    SettingsText.Blue = FlatRedBall.Math.MathFunctions.RoundToInt(SettingsTextBlueFirstValue* (1 - interpolationValue) + SettingsTextBlueSecondValue * interpolationValue);
                }
                if (setSettingsTextFontSizeFirstValue && setSettingsTextFontSizeSecondValue)
                {
                    SettingsText.FontSize = FlatRedBall.Math.MathFunctions.RoundToInt(SettingsTextFontSizeFirstValue* (1 - interpolationValue) + SettingsTextFontSizeSecondValue * interpolationValue);
                }
                if (setSettingsTextGreenFirstValue && setSettingsTextGreenSecondValue)
                {
                    SettingsText.Green = FlatRedBall.Math.MathFunctions.RoundToInt(SettingsTextGreenFirstValue* (1 - interpolationValue) + SettingsTextGreenSecondValue * interpolationValue);
                }
                if (setSettingsTextRedFirstValue && setSettingsTextRedSecondValue)
                {
                    SettingsText.Red = FlatRedBall.Math.MathFunctions.RoundToInt(SettingsTextRedFirstValue* (1 - interpolationValue) + SettingsTextRedSecondValue * interpolationValue);
                }
                if (setSettingsTextXFirstValue && setSettingsTextXSecondValue)
                {
                    SettingsText.X = SettingsTextXFirstValue * (1 - interpolationValue) + SettingsTextXSecondValue * interpolationValue;
                }
                if (setSettingsTextYFirstValue && setSettingsTextYSecondValue)
                {
                    SettingsText.Y = SettingsTextYFirstValue * (1 - interpolationValue) + SettingsTextYSecondValue * interpolationValue;
                }
                if (setSoudTopicHeightFirstValue && setSoudTopicHeightSecondValue)
                {
                    SoudTopic.Height = SoudTopicHeightFirstValue * (1 - interpolationValue) + SoudTopicHeightSecondValue * interpolationValue;
                }
                if (setSoudTopicWidthFirstValue && setSoudTopicWidthSecondValue)
                {
                    SoudTopic.Width = SoudTopicWidthFirstValue * (1 - interpolationValue) + SoudTopicWidthSecondValue * interpolationValue;
                }
                if (setSoudTopicXFirstValue && setSoudTopicXSecondValue)
                {
                    SoudTopic.X = SoudTopicXFirstValue * (1 - interpolationValue) + SoudTopicXSecondValue * interpolationValue;
                }
                if (setSoudTopicYFirstValue && setSoudTopicYSecondValue)
                {
                    SoudTopic.Y = SoudTopicYFirstValue * (1 - interpolationValue) + SoudTopicYSecondValue * interpolationValue;
                }
                if (setSoundContainerHeightFirstValue && setSoundContainerHeightSecondValue)
                {
                    SoundContainer.Height = SoundContainerHeightFirstValue * (1 - interpolationValue) + SoundContainerHeightSecondValue * interpolationValue;
                }
                if (setSoundContainerWidthFirstValue && setSoundContainerWidthSecondValue)
                {
                    SoundContainer.Width = SoundContainerWidthFirstValue * (1 - interpolationValue) + SoundContainerWidthSecondValue * interpolationValue;
                }
                if (setSoundContainerXFirstValue && setSoundContainerXSecondValue)
                {
                    SoundContainer.X = SoundContainerXFirstValue * (1 - interpolationValue) + SoundContainerXSecondValue * interpolationValue;
                }
                if (setSoundContainerYFirstValue && setSoundContainerYSecondValue)
                {
                    SoundContainer.Y = SoundContainerYFirstValue * (1 - interpolationValue) + SoundContainerYSecondValue * interpolationValue;
                }
                if (setVolumeContainerHeightFirstValue && setVolumeContainerHeightSecondValue)
                {
                    VolumeContainer.Height = VolumeContainerHeightFirstValue * (1 - interpolationValue) + VolumeContainerHeightSecondValue * interpolationValue;
                }
                if (setVolumeContainerWidthFirstValue && setVolumeContainerWidthSecondValue)
                {
                    VolumeContainer.Width = VolumeContainerWidthFirstValue * (1 - interpolationValue) + VolumeContainerWidthSecondValue * interpolationValue;
                }
                if (setVolumeMaxTextBlueFirstValue && setVolumeMaxTextBlueSecondValue)
                {
                    VolumeMaxText.Blue = FlatRedBall.Math.MathFunctions.RoundToInt(VolumeMaxTextBlueFirstValue* (1 - interpolationValue) + VolumeMaxTextBlueSecondValue * interpolationValue);
                }
                if (setVolumeMaxTextFontSizeFirstValue && setVolumeMaxTextFontSizeSecondValue)
                {
                    VolumeMaxText.FontSize = FlatRedBall.Math.MathFunctions.RoundToInt(VolumeMaxTextFontSizeFirstValue* (1 - interpolationValue) + VolumeMaxTextFontSizeSecondValue * interpolationValue);
                }
                if (setVolumeMaxTextGreenFirstValue && setVolumeMaxTextGreenSecondValue)
                {
                    VolumeMaxText.Green = FlatRedBall.Math.MathFunctions.RoundToInt(VolumeMaxTextGreenFirstValue* (1 - interpolationValue) + VolumeMaxTextGreenSecondValue * interpolationValue);
                }
                if (setVolumeMaxTextHeightFirstValue && setVolumeMaxTextHeightSecondValue)
                {
                    VolumeMaxText.Height = VolumeMaxTextHeightFirstValue * (1 - interpolationValue) + VolumeMaxTextHeightSecondValue * interpolationValue;
                }
                if (setVolumeMaxTextRedFirstValue && setVolumeMaxTextRedSecondValue)
                {
                    VolumeMaxText.Red = FlatRedBall.Math.MathFunctions.RoundToInt(VolumeMaxTextRedFirstValue* (1 - interpolationValue) + VolumeMaxTextRedSecondValue * interpolationValue);
                }
                if (setVolumeMaxTextWidthFirstValue && setVolumeMaxTextWidthSecondValue)
                {
                    VolumeMaxText.Width = VolumeMaxTextWidthFirstValue * (1 - interpolationValue) + VolumeMaxTextWidthSecondValue * interpolationValue;
                }
                if (setVolumeMinTextBlueFirstValue && setVolumeMinTextBlueSecondValue)
                {
                    VolumeMinText.Blue = FlatRedBall.Math.MathFunctions.RoundToInt(VolumeMinTextBlueFirstValue* (1 - interpolationValue) + VolumeMinTextBlueSecondValue * interpolationValue);
                }
                if (setVolumeMinTextFontSizeFirstValue && setVolumeMinTextFontSizeSecondValue)
                {
                    VolumeMinText.FontSize = FlatRedBall.Math.MathFunctions.RoundToInt(VolumeMinTextFontSizeFirstValue* (1 - interpolationValue) + VolumeMinTextFontSizeSecondValue * interpolationValue);
                }
                if (setVolumeMinTextGreenFirstValue && setVolumeMinTextGreenSecondValue)
                {
                    VolumeMinText.Green = FlatRedBall.Math.MathFunctions.RoundToInt(VolumeMinTextGreenFirstValue* (1 - interpolationValue) + VolumeMinTextGreenSecondValue * interpolationValue);
                }
                if (setVolumeMinTextHeightFirstValue && setVolumeMinTextHeightSecondValue)
                {
                    VolumeMinText.Height = VolumeMinTextHeightFirstValue * (1 - interpolationValue) + VolumeMinTextHeightSecondValue * interpolationValue;
                }
                if (setVolumeMinTextRedFirstValue && setVolumeMinTextRedSecondValue)
                {
                    VolumeMinText.Red = FlatRedBall.Math.MathFunctions.RoundToInt(VolumeMinTextRedFirstValue* (1 - interpolationValue) + VolumeMinTextRedSecondValue * interpolationValue);
                }
                if (setVolumeMinTextWidthFirstValue && setVolumeMinTextWidthSecondValue)
                {
                    VolumeMinText.Width = VolumeMinTextWidthFirstValue * (1 - interpolationValue) + VolumeMinTextWidthSecondValue * interpolationValue;
                }
                if (setVolumeSliderHeightFirstValue && setVolumeSliderHeightSecondValue)
                {
                    VolumeSlider.Height = VolumeSliderHeightFirstValue * (1 - interpolationValue) + VolumeSliderHeightSecondValue * interpolationValue;
                }
                if (setVolumeSliderWidthFirstValue && setVolumeSliderWidthSecondValue)
                {
                    VolumeSlider.Width = VolumeSliderWidthFirstValue * (1 - interpolationValue) + VolumeSliderWidthSecondValue * interpolationValue;
                }
                if (setVolumeSliderInstanceWidthFirstValue && setVolumeSliderInstanceWidthSecondValue)
                {
                    VolumeSliderInstance.Width = VolumeSliderInstanceWidthFirstValue * (1 - interpolationValue) + VolumeSliderInstanceWidthSecondValue * interpolationValue;
                }
                if (setVolumeSliderInstanceXFirstValue && setVolumeSliderInstanceXSecondValue)
                {
                    VolumeSliderInstance.X = VolumeSliderInstanceXFirstValue * (1 - interpolationValue) + VolumeSliderInstanceXSecondValue * interpolationValue;
                }
                if (setVolumeTextBlueFirstValue && setVolumeTextBlueSecondValue)
                {
                    VolumeText.Blue = FlatRedBall.Math.MathFunctions.RoundToInt(VolumeTextBlueFirstValue* (1 - interpolationValue) + VolumeTextBlueSecondValue * interpolationValue);
                }
                if (setVolumeTextGreenFirstValue && setVolumeTextGreenSecondValue)
                {
                    VolumeText.Green = FlatRedBall.Math.MathFunctions.RoundToInt(VolumeTextGreenFirstValue* (1 - interpolationValue) + VolumeTextGreenSecondValue * interpolationValue);
                }
                if (setVolumeTextHeightFirstValue && setVolumeTextHeightSecondValue)
                {
                    VolumeText.Height = VolumeTextHeightFirstValue * (1 - interpolationValue) + VolumeTextHeightSecondValue * interpolationValue;
                }
                if (setVolumeTextRedFirstValue && setVolumeTextRedSecondValue)
                {
                    VolumeText.Red = FlatRedBall.Math.MathFunctions.RoundToInt(VolumeTextRedFirstValue* (1 - interpolationValue) + VolumeTextRedSecondValue * interpolationValue);
                }
                if (setVolumeTextWidthFirstValue && setVolumeTextWidthSecondValue)
                {
                    VolumeText.Width = VolumeTextWidthFirstValue * (1 - interpolationValue) + VolumeTextWidthSecondValue * interpolationValue;
                }
                if (setWindowModeComboBoxListBoxInstanceHeightFirstValue && setWindowModeComboBoxListBoxInstanceHeightSecondValue)
                {
                    WindowModeComboBox.ListBoxInstanceHeight = WindowModeComboBoxListBoxInstanceHeightFirstValue * (1 - interpolationValue) + WindowModeComboBoxListBoxInstanceHeightSecondValue * interpolationValue;
                }
                if (setWindowModeComboBoxWidthFirstValue && setWindowModeComboBoxWidthSecondValue)
                {
                    WindowModeComboBox.Width = WindowModeComboBoxWidthFirstValue * (1 - interpolationValue) + WindowModeComboBoxWidthSecondValue * interpolationValue;
                }
                if (setWindowModeContainerHeightFirstValue && setWindowModeContainerHeightSecondValue)
                {
                    WindowModeContainer.Height = WindowModeContainerHeightFirstValue * (1 - interpolationValue) + WindowModeContainerHeightSecondValue * interpolationValue;
                }
                if (setWindowModeContainerWidthFirstValue && setWindowModeContainerWidthSecondValue)
                {
                    WindowModeContainer.Width = WindowModeContainerWidthFirstValue * (1 - interpolationValue) + WindowModeContainerWidthSecondValue * interpolationValue;
                }
                if (setWindowModeContainerXFirstValue && setWindowModeContainerXSecondValue)
                {
                    WindowModeContainer.X = WindowModeContainerXFirstValue * (1 - interpolationValue) + WindowModeContainerXSecondValue * interpolationValue;
                }
                if (setWindowModeContainerYFirstValue && setWindowModeContainerYSecondValue)
                {
                    WindowModeContainer.Y = WindowModeContainerYFirstValue * (1 - interpolationValue) + WindowModeContainerYSecondValue * interpolationValue;
                }
                if (setWindowModeTextBlueFirstValue && setWindowModeTextBlueSecondValue)
                {
                    WindowModeText.Blue = FlatRedBall.Math.MathFunctions.RoundToInt(WindowModeTextBlueFirstValue* (1 - interpolationValue) + WindowModeTextBlueSecondValue * interpolationValue);
                }
                if (setWindowModeTextGreenFirstValue && setWindowModeTextGreenSecondValue)
                {
                    WindowModeText.Green = FlatRedBall.Math.MathFunctions.RoundToInt(WindowModeTextGreenFirstValue* (1 - interpolationValue) + WindowModeTextGreenSecondValue * interpolationValue);
                }
                if (setWindowModeTextHeightFirstValue && setWindowModeTextHeightSecondValue)
                {
                    WindowModeText.Height = WindowModeTextHeightFirstValue * (1 - interpolationValue) + WindowModeTextHeightSecondValue * interpolationValue;
                }
                if (setWindowModeTextRedFirstValue && setWindowModeTextRedSecondValue)
                {
                    WindowModeText.Red = FlatRedBall.Math.MathFunctions.RoundToInt(WindowModeTextRedFirstValue* (1 - interpolationValue) + WindowModeTextRedSecondValue * interpolationValue);
                }
                if (setWindowModeTextWidthFirstValue && setWindowModeTextWidthSecondValue)
                {
                    WindowModeText.Width = WindowModeTextWidthFirstValue * (1 - interpolationValue) + WindowModeTextWidthSecondValue * interpolationValue;
                }
                if (interpolationValue < 1)
                {
                    mCurrentVariableState = firstState;
                }
                else
                {
                    mCurrentVariableState = secondState;
                }
                if (!wasSuppressed)
                {
                    ResumeLayout(true);
                }
            }
            #endregion
            #region State Interpolate To
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (JHP4SD.GumRuntimes.SettingsGumRuntime.VariableState fromState,JHP4SD.GumRuntimes.SettingsGumRuntime.VariableState toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null) 
            {
                FlatRedBall.Glue.StateInterpolation.Tweener tweener = new FlatRedBall.Glue.StateInterpolation.Tweener(from:0, to:1, duration:(float)secondsToTake, type:interpolationType, easing:easing );
                if (owner == null)
                {
                    tweener.Owner = this;
                }
                else
                {
                    tweener.Owner = owner;
                }
                tweener.PositionChanged = newPosition => this.InterpolateBetween(fromState, toState, newPosition);
                tweener.Start();
                StateInterpolationPlugin.TweenerManager.Self.Add(tweener);
                return tweener;
            }
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (VariableState toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null ) 
            {
                Gum.DataTypes.Variables.StateSave current = GetCurrentValuesOnState(toState);
                Gum.DataTypes.Variables.StateSave toAsStateSave = this.ElementSave.States.First(item => item.Name == toState.ToString());
                FlatRedBall.Glue.StateInterpolation.Tweener tweener = new FlatRedBall.Glue.StateInterpolation.Tweener(from: 0, to: 1, duration: (float)secondsToTake, type: interpolationType, easing: easing);
                if (owner == null)
                {
                    tweener.Owner = this;
                }
                else
                {
                    tweener.Owner = owner;
                }
                tweener.PositionChanged = newPosition => this.InterpolateBetween(current, toAsStateSave, newPosition);
                tweener.Ended += ()=> this.CurrentVariableState = toState;
                tweener.Start();
                StateInterpolationPlugin.TweenerManager.Self.Add(tweener);
                return tweener;
            }
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateToRelative (VariableState toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null ) 
            {
                Gum.DataTypes.Variables.StateSave current = GetCurrentValuesOnState(toState);
                Gum.DataTypes.Variables.StateSave toAsStateSave = AddToCurrentValuesWithState(toState);
                FlatRedBall.Glue.StateInterpolation.Tweener tweener = new FlatRedBall.Glue.StateInterpolation.Tweener(from: 0, to: 1, duration: (float)secondsToTake, type: interpolationType, easing: easing);
                if (owner == null)
                {
                    tweener.Owner = this;
                }
                else
                {
                    tweener.Owner = owner;
                }
                tweener.PositionChanged = newPosition => this.InterpolateBetween(current, toAsStateSave, newPosition);
                tweener.Ended += ()=> this.CurrentVariableState = toState;
                tweener.Start();
                StateInterpolationPlugin.TweenerManager.Self.Add(tweener);
                return tweener;
            }
            #endregion
            #region State Animations
            #endregion
            public override void StopAnimations () 
            {
                base.StopAnimations();
                BackButtonInstance.StopAnimations();
                GraphicsTopic.StopAnimations();
                SoudTopic.StopAnimations();
                ResolutionComboBox.StopAnimations();
                WindowModeComboBox.StopAnimations();
                VolumeSliderInstance.StopAnimations();
                MusicSliderInstance.StopAnimations();
                CurrentVolumeLabel.StopAnimations();
                CurrentMusicVolumeLabel.StopAnimations();
            }
            public override FlatRedBall.Gum.Animation.GumAnimation GetAnimation (string animationName) 
            {
                return base.GetAnimation(animationName);
            }
            #region Get Current Values on State
            private Gum.DataTypes.Variables.StateSave GetCurrentValuesOnState (VariableState state) 
            {
                Gum.DataTypes.Variables.StateSave newState = new Gum.DataTypes.Variables.StateSave();
                switch(state)
                {
                    case  VariableState.Default:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackgroundColor.Blue",
                            Type = "int",
                            Value = BackgroundColor.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackgroundColor.Green",
                            Type = "int",
                            Value = BackgroundColor.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackgroundColor.Height",
                            Type = "float",
                            Value = BackgroundColor.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackgroundColor.Height Units",
                            Type = "DimensionUnitType",
                            Value = BackgroundColor.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackgroundColor.Red",
                            Type = "int",
                            Value = BackgroundColor.Red
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackgroundColor.Width",
                            Type = "float",
                            Value = BackgroundColor.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackgroundColor.Width Units",
                            Type = "DimensionUnitType",
                            Value = BackgroundColor.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackgroundColor.X",
                            Type = "float",
                            Value = BackgroundColor.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackgroundColor.X Origin",
                            Type = "HorizontalAlignment",
                            Value = BackgroundColor.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackgroundColor.X Units",
                            Type = "PositionUnitType",
                            Value = BackgroundColor.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackgroundColor.Y",
                            Type = "float",
                            Value = BackgroundColor.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackgroundColor.Y Origin",
                            Type = "VerticalAlignment",
                            Value = BackgroundColor.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackgroundColor.Y Units",
                            Type = "PositionUnitType",
                            Value = BackgroundColor.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackButtonInstance.X",
                            Type = "float",
                            Value = BackButtonInstance.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackButtonInstance.X Origin",
                            Type = "HorizontalAlignment",
                            Value = BackButtonInstance.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackButtonInstance.X Units",
                            Type = "PositionUnitType",
                            Value = BackButtonInstance.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackButtonInstance.Y",
                            Type = "float",
                            Value = BackButtonInstance.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackButtonInstance.Y Origin",
                            Type = "VerticalAlignment",
                            Value = BackButtonInstance.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackButtonInstance.Y Units",
                            Type = "PositionUnitType",
                            Value = BackButtonInstance.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SettingsText.Blue",
                            Type = "int",
                            Value = SettingsText.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SettingsText.FontSize",
                            Type = "int",
                            Value = SettingsText.FontSize
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SettingsText.Green",
                            Type = "int",
                            Value = SettingsText.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SettingsText.Red",
                            Type = "int",
                            Value = SettingsText.Red
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SettingsText.Text",
                            Type = "string",
                            Value = SettingsText.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SettingsText.X",
                            Type = "float",
                            Value = SettingsText.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SettingsText.X Units",
                            Type = "PositionUnitType",
                            Value = SettingsText.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SettingsText.Y",
                            Type = "float",
                            Value = SettingsText.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "GraphicsTopic.Children Layout",
                            Type = "ChildrenLayout",
                            Value = GraphicsTopic.ChildrenLayout
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "GraphicsTopic.Height",
                            Type = "float",
                            Value = GraphicsTopic.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "GraphicsTopic.Height Units",
                            Type = "DimensionUnitType",
                            Value = GraphicsTopic.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "GraphicsTopic.TopicName",
                            Type = "string",
                            Value = GraphicsTopic.TopicName
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "GraphicsTopic.Width",
                            Type = "float",
                            Value = GraphicsTopic.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "GraphicsTopic.Width Units",
                            Type = "DimensionUnitType",
                            Value = GraphicsTopic.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "GraphicsTopic.X",
                            Type = "float",
                            Value = GraphicsTopic.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "GraphicsTopic.X Units",
                            Type = "PositionUnitType",
                            Value = GraphicsTopic.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "GraphicsTopic.Y",
                            Type = "float",
                            Value = GraphicsTopic.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "GraphicsTopic.Y Origin",
                            Type = "VerticalAlignment",
                            Value = GraphicsTopic.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SoudTopic.Children Layout",
                            Type = "ChildrenLayout",
                            Value = SoudTopic.ChildrenLayout
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SoudTopic.Height",
                            Type = "float",
                            Value = SoudTopic.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SoudTopic.Height Units",
                            Type = "DimensionUnitType",
                            Value = SoudTopic.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SoudTopic.TopicName",
                            Type = "string",
                            Value = SoudTopic.TopicName
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SoudTopic.Width",
                            Type = "float",
                            Value = SoudTopic.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SoudTopic.Width Units",
                            Type = "DimensionUnitType",
                            Value = SoudTopic.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SoudTopic.X",
                            Type = "float",
                            Value = SoudTopic.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SoudTopic.X Origin",
                            Type = "HorizontalAlignment",
                            Value = SoudTopic.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SoudTopic.X Units",
                            Type = "PositionUnitType",
                            Value = SoudTopic.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SoudTopic.Y",
                            Type = "float",
                            Value = SoudTopic.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResolutionContainer.Height",
                            Type = "float",
                            Value = ResolutionContainer.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResolutionContainer.Height Units",
                            Type = "DimensionUnitType",
                            Value = ResolutionContainer.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResolutionContainer.Parent",
                            Type = "string",
                            Value = ResolutionContainer.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResolutionContainer.Width",
                            Type = "float",
                            Value = ResolutionContainer.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResolutionContainer.Width Units",
                            Type = "DimensionUnitType",
                            Value = ResolutionContainer.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResolutionContainer.X",
                            Type = "float",
                            Value = ResolutionContainer.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResolutionContainer.X Units",
                            Type = "PositionUnitType",
                            Value = ResolutionContainer.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResolutionContainer.Y",
                            Type = "float",
                            Value = ResolutionContainer.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResolutionContainer.Y Origin",
                            Type = "VerticalAlignment",
                            Value = ResolutionContainer.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResolutionText.Blue",
                            Type = "int",
                            Value = ResolutionText.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResolutionText.Green",
                            Type = "int",
                            Value = ResolutionText.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResolutionText.Height",
                            Type = "float",
                            Value = ResolutionText.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResolutionText.Height Units",
                            Type = "DimensionUnitType",
                            Value = ResolutionText.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResolutionText.HorizontalAlignment",
                            Type = "HorizontalAlignment",
                            Value = ResolutionText.HorizontalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResolutionText.Parent",
                            Type = "string",
                            Value = ResolutionText.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResolutionText.Red",
                            Type = "int",
                            Value = ResolutionText.Red
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResolutionText.Text",
                            Type = "string",
                            Value = ResolutionText.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResolutionText.VerticalAlignment",
                            Type = "VerticalAlignment",
                            Value = ResolutionText.VerticalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResolutionText.Width",
                            Type = "float",
                            Value = ResolutionText.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResolutionText.Width Units",
                            Type = "DimensionUnitType",
                            Value = ResolutionText.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResolutionText.X Origin",
                            Type = "HorizontalAlignment",
                            Value = ResolutionText.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResolutionText.X Units",
                            Type = "PositionUnitType",
                            Value = ResolutionText.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResolutionText.Y Origin",
                            Type = "VerticalAlignment",
                            Value = ResolutionText.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResolutionText.Y Units",
                            Type = "PositionUnitType",
                            Value = ResolutionText.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResolutionComboBox.ListBoxInstanceHeight",
                            Type = "float",
                            Value = ResolutionComboBox.ListBoxInstanceHeight
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResolutionComboBox.Parent",
                            Type = "string",
                            Value = ResolutionComboBox.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResolutionComboBox.Width",
                            Type = "float",
                            Value = ResolutionComboBox.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResolutionComboBox.Width Units",
                            Type = "DimensionUnitType",
                            Value = ResolutionComboBox.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResolutionComboBox.X Origin",
                            Type = "HorizontalAlignment",
                            Value = ResolutionComboBox.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResolutionComboBox.X Units",
                            Type = "PositionUnitType",
                            Value = ResolutionComboBox.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WindowModeContainer.Height",
                            Type = "float",
                            Value = WindowModeContainer.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WindowModeContainer.Height Units",
                            Type = "DimensionUnitType",
                            Value = WindowModeContainer.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WindowModeContainer.Parent",
                            Type = "string",
                            Value = WindowModeContainer.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WindowModeContainer.Width",
                            Type = "float",
                            Value = WindowModeContainer.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WindowModeContainer.Width Units",
                            Type = "DimensionUnitType",
                            Value = WindowModeContainer.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WindowModeContainer.X",
                            Type = "float",
                            Value = WindowModeContainer.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WindowModeContainer.Y",
                            Type = "float",
                            Value = WindowModeContainer.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WindowModeText.Blue",
                            Type = "int",
                            Value = WindowModeText.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WindowModeText.Green",
                            Type = "int",
                            Value = WindowModeText.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WindowModeText.Height",
                            Type = "float",
                            Value = WindowModeText.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WindowModeText.Height Units",
                            Type = "DimensionUnitType",
                            Value = WindowModeText.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WindowModeText.Parent",
                            Type = "string",
                            Value = WindowModeText.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WindowModeText.Red",
                            Type = "int",
                            Value = WindowModeText.Red
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WindowModeText.Text",
                            Type = "string",
                            Value = WindowModeText.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WindowModeText.Width",
                            Type = "float",
                            Value = WindowModeText.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WindowModeText.Width Units",
                            Type = "DimensionUnitType",
                            Value = WindowModeText.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WindowModeText.X Units",
                            Type = "PositionUnitType",
                            Value = WindowModeText.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WindowModeText.Y Origin",
                            Type = "VerticalAlignment",
                            Value = WindowModeText.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WindowModeText.Y Units",
                            Type = "PositionUnitType",
                            Value = WindowModeText.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "VolumeText.Blue",
                            Type = "int",
                            Value = VolumeText.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "VolumeText.Green",
                            Type = "int",
                            Value = VolumeText.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "VolumeText.Height",
                            Type = "float",
                            Value = VolumeText.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "VolumeText.Height Units",
                            Type = "DimensionUnitType",
                            Value = VolumeText.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "VolumeText.Parent",
                            Type = "string",
                            Value = VolumeText.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "VolumeText.Red",
                            Type = "int",
                            Value = VolumeText.Red
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "VolumeText.Text",
                            Type = "string",
                            Value = VolumeText.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "VolumeText.Width",
                            Type = "float",
                            Value = VolumeText.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "VolumeText.Width Units",
                            Type = "DimensionUnitType",
                            Value = VolumeText.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "VolumeText.X Units",
                            Type = "PositionUnitType",
                            Value = VolumeText.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "VolumeText.Y Origin",
                            Type = "VerticalAlignment",
                            Value = VolumeText.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "VolumeText.Y Units",
                            Type = "PositionUnitType",
                            Value = VolumeText.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MusicText.Blue",
                            Type = "int",
                            Value = MusicText.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MusicText.Green",
                            Type = "int",
                            Value = MusicText.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MusicText.Height",
                            Type = "float",
                            Value = MusicText.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MusicText.Height Units",
                            Type = "DimensionUnitType",
                            Value = MusicText.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MusicText.Parent",
                            Type = "string",
                            Value = MusicText.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MusicText.Red",
                            Type = "int",
                            Value = MusicText.Red
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MusicText.Text",
                            Type = "string",
                            Value = MusicText.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MusicText.Width",
                            Type = "float",
                            Value = MusicText.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MusicText.Width Units",
                            Type = "DimensionUnitType",
                            Value = MusicText.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MusicText.X Units",
                            Type = "PositionUnitType",
                            Value = MusicText.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MusicText.Y Origin",
                            Type = "VerticalAlignment",
                            Value = MusicText.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MusicText.Y Units",
                            Type = "PositionUnitType",
                            Value = MusicText.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "GraphicsContainer.Children Layout",
                            Type = "ChildrenLayout",
                            Value = GraphicsContainer.ChildrenLayout
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "GraphicsContainer.Height",
                            Type = "float",
                            Value = GraphicsContainer.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "GraphicsContainer.Height Units",
                            Type = "DimensionUnitType",
                            Value = GraphicsContainer.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "GraphicsContainer.Parent",
                            Type = "string",
                            Value = GraphicsContainer.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "GraphicsContainer.Width",
                            Type = "float",
                            Value = GraphicsContainer.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "GraphicsContainer.Width Units",
                            Type = "DimensionUnitType",
                            Value = GraphicsContainer.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "GraphicsContainer.X",
                            Type = "float",
                            Value = GraphicsContainer.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "GraphicsContainer.X Units",
                            Type = "PositionUnitType",
                            Value = GraphicsContainer.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "GraphicsContainer.Y",
                            Type = "float",
                            Value = GraphicsContainer.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WindowModeComboBox.ListBoxInstanceHeight",
                            Type = "float",
                            Value = WindowModeComboBox.ListBoxInstanceHeight
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WindowModeComboBox.Parent",
                            Type = "string",
                            Value = WindowModeComboBox.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WindowModeComboBox.Width",
                            Type = "float",
                            Value = WindowModeComboBox.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WindowModeComboBox.Width Units",
                            Type = "DimensionUnitType",
                            Value = WindowModeComboBox.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WindowModeComboBox.X Origin",
                            Type = "HorizontalAlignment",
                            Value = WindowModeComboBox.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WindowModeComboBox.X Units",
                            Type = "PositionUnitType",
                            Value = WindowModeComboBox.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SoundContainer.Children Layout",
                            Type = "ChildrenLayout",
                            Value = SoundContainer.ChildrenLayout
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SoundContainer.Height",
                            Type = "float",
                            Value = SoundContainer.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SoundContainer.Height Units",
                            Type = "DimensionUnitType",
                            Value = SoundContainer.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SoundContainer.Parent",
                            Type = "string",
                            Value = SoundContainer.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SoundContainer.Width",
                            Type = "float",
                            Value = SoundContainer.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SoundContainer.Width Units",
                            Type = "DimensionUnitType",
                            Value = SoundContainer.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SoundContainer.X",
                            Type = "float",
                            Value = SoundContainer.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SoundContainer.X Units",
                            Type = "PositionUnitType",
                            Value = SoundContainer.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SoundContainer.Y",
                            Type = "float",
                            Value = SoundContainer.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "VolumeContainer.Children Layout",
                            Type = "ChildrenLayout",
                            Value = VolumeContainer.ChildrenLayout
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "VolumeContainer.Height",
                            Type = "float",
                            Value = VolumeContainer.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "VolumeContainer.Height Units",
                            Type = "DimensionUnitType",
                            Value = VolumeContainer.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "VolumeContainer.Parent",
                            Type = "string",
                            Value = VolumeContainer.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "VolumeContainer.Width",
                            Type = "float",
                            Value = VolumeContainer.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "VolumeContainer.Width Units",
                            Type = "DimensionUnitType",
                            Value = VolumeContainer.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MusicContainer.Children Layout",
                            Type = "ChildrenLayout",
                            Value = MusicContainer.ChildrenLayout
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MusicContainer.Height",
                            Type = "float",
                            Value = MusicContainer.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MusicContainer.Height Units",
                            Type = "DimensionUnitType",
                            Value = MusicContainer.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MusicContainer.Parent",
                            Type = "string",
                            Value = MusicContainer.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MusicContainer.Width",
                            Type = "float",
                            Value = MusicContainer.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MusicContainer.Width Units",
                            Type = "DimensionUnitType",
                            Value = MusicContainer.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "VolumeSlider.Height",
                            Type = "float",
                            Value = VolumeSlider.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "VolumeSlider.Height Units",
                            Type = "DimensionUnitType",
                            Value = VolumeSlider.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "VolumeSlider.Parent",
                            Type = "string",
                            Value = VolumeSlider.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "VolumeSlider.Width",
                            Type = "float",
                            Value = VolumeSlider.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "VolumeSlider.Width Units",
                            Type = "DimensionUnitType",
                            Value = VolumeSlider.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "VolumeSlider.X Origin",
                            Type = "HorizontalAlignment",
                            Value = VolumeSlider.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "VolumeSlider.X Units",
                            Type = "PositionUnitType",
                            Value = VolumeSlider.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MusicSlider.Height",
                            Type = "float",
                            Value = MusicSlider.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MusicSlider.Height Units",
                            Type = "DimensionUnitType",
                            Value = MusicSlider.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MusicSlider.Parent",
                            Type = "string",
                            Value = MusicSlider.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MusicSlider.Width",
                            Type = "float",
                            Value = MusicSlider.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MusicSlider.Width Units",
                            Type = "DimensionUnitType",
                            Value = MusicSlider.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MusicSlider.X Origin",
                            Type = "HorizontalAlignment",
                            Value = MusicSlider.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MusicSlider.X Units",
                            Type = "PositionUnitType",
                            Value = MusicSlider.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "VolumeMinText.Blue",
                            Type = "int",
                            Value = VolumeMinText.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "VolumeMinText.FontSize",
                            Type = "int",
                            Value = VolumeMinText.FontSize
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "VolumeMinText.Green",
                            Type = "int",
                            Value = VolumeMinText.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "VolumeMinText.Height",
                            Type = "float",
                            Value = VolumeMinText.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "VolumeMinText.Height Units",
                            Type = "DimensionUnitType",
                            Value = VolumeMinText.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "VolumeMinText.HorizontalAlignment",
                            Type = "HorizontalAlignment",
                            Value = VolumeMinText.HorizontalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "VolumeMinText.Parent",
                            Type = "string",
                            Value = VolumeMinText.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "VolumeMinText.Red",
                            Type = "int",
                            Value = VolumeMinText.Red
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "VolumeMinText.Text",
                            Type = "string",
                            Value = VolumeMinText.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "VolumeMinText.VerticalAlignment",
                            Type = "VerticalAlignment",
                            Value = VolumeMinText.VerticalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "VolumeMinText.Width",
                            Type = "float",
                            Value = VolumeMinText.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "VolumeMinText.Width Units",
                            Type = "DimensionUnitType",
                            Value = VolumeMinText.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "VolumeMinText.Y Origin",
                            Type = "VerticalAlignment",
                            Value = VolumeMinText.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "VolumeMinText.Y Units",
                            Type = "PositionUnitType",
                            Value = VolumeMinText.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MusicMinText.Blue",
                            Type = "int",
                            Value = MusicMinText.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MusicMinText.FontSize",
                            Type = "int",
                            Value = MusicMinText.FontSize
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MusicMinText.Green",
                            Type = "int",
                            Value = MusicMinText.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MusicMinText.Height",
                            Type = "float",
                            Value = MusicMinText.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MusicMinText.Height Units",
                            Type = "DimensionUnitType",
                            Value = MusicMinText.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MusicMinText.HorizontalAlignment",
                            Type = "HorizontalAlignment",
                            Value = MusicMinText.HorizontalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MusicMinText.Parent",
                            Type = "string",
                            Value = MusicMinText.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MusicMinText.Red",
                            Type = "int",
                            Value = MusicMinText.Red
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MusicMinText.Text",
                            Type = "string",
                            Value = MusicMinText.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MusicMinText.VerticalAlignment",
                            Type = "VerticalAlignment",
                            Value = MusicMinText.VerticalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MusicMinText.Width",
                            Type = "float",
                            Value = MusicMinText.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MusicMinText.Width Units",
                            Type = "DimensionUnitType",
                            Value = MusicMinText.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MusicMinText.Y Origin",
                            Type = "VerticalAlignment",
                            Value = MusicMinText.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MusicMinText.Y Units",
                            Type = "PositionUnitType",
                            Value = MusicMinText.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "VolumeSliderInstance.Parent",
                            Type = "string",
                            Value = VolumeSliderInstance.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "VolumeSliderInstance.Width",
                            Type = "float",
                            Value = VolumeSliderInstance.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "VolumeSliderInstance.Width Units",
                            Type = "DimensionUnitType",
                            Value = VolumeSliderInstance.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "VolumeSliderInstance.X",
                            Type = "float",
                            Value = VolumeSliderInstance.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "VolumeSliderInstance.X Units",
                            Type = "PositionUnitType",
                            Value = VolumeSliderInstance.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MusicSliderInstance.Parent",
                            Type = "string",
                            Value = MusicSliderInstance.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MusicSliderInstance.Width",
                            Type = "float",
                            Value = MusicSliderInstance.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MusicSliderInstance.Width Units",
                            Type = "DimensionUnitType",
                            Value = MusicSliderInstance.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MusicSliderInstance.X",
                            Type = "float",
                            Value = MusicSliderInstance.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MusicSliderInstance.X Units",
                            Type = "PositionUnitType",
                            Value = MusicSliderInstance.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "VolumeMaxText.Blue",
                            Type = "int",
                            Value = VolumeMaxText.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "VolumeMaxText.FontSize",
                            Type = "int",
                            Value = VolumeMaxText.FontSize
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "VolumeMaxText.Green",
                            Type = "int",
                            Value = VolumeMaxText.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "VolumeMaxText.Height",
                            Type = "float",
                            Value = VolumeMaxText.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "VolumeMaxText.Height Units",
                            Type = "DimensionUnitType",
                            Value = VolumeMaxText.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "VolumeMaxText.HorizontalAlignment",
                            Type = "HorizontalAlignment",
                            Value = VolumeMaxText.HorizontalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "VolumeMaxText.Parent",
                            Type = "string",
                            Value = VolumeMaxText.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "VolumeMaxText.Red",
                            Type = "int",
                            Value = VolumeMaxText.Red
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "VolumeMaxText.Text",
                            Type = "string",
                            Value = VolumeMaxText.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "VolumeMaxText.Width",
                            Type = "float",
                            Value = VolumeMaxText.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "VolumeMaxText.Width Units",
                            Type = "DimensionUnitType",
                            Value = VolumeMaxText.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "VolumeMaxText.X Origin",
                            Type = "HorizontalAlignment",
                            Value = VolumeMaxText.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "VolumeMaxText.X Units",
                            Type = "PositionUnitType",
                            Value = VolumeMaxText.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "VolumeMaxText.Y Origin",
                            Type = "VerticalAlignment",
                            Value = VolumeMaxText.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "VolumeMaxText.Y Units",
                            Type = "PositionUnitType",
                            Value = VolumeMaxText.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MusicMaxText.Blue",
                            Type = "int",
                            Value = MusicMaxText.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MusicMaxText.FontSize",
                            Type = "int",
                            Value = MusicMaxText.FontSize
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MusicMaxText.Green",
                            Type = "int",
                            Value = MusicMaxText.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MusicMaxText.Height",
                            Type = "float",
                            Value = MusicMaxText.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MusicMaxText.Height Units",
                            Type = "DimensionUnitType",
                            Value = MusicMaxText.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MusicMaxText.HorizontalAlignment",
                            Type = "HorizontalAlignment",
                            Value = MusicMaxText.HorizontalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MusicMaxText.Parent",
                            Type = "string",
                            Value = MusicMaxText.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MusicMaxText.Red",
                            Type = "int",
                            Value = MusicMaxText.Red
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MusicMaxText.Text",
                            Type = "string",
                            Value = MusicMaxText.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MusicMaxText.Width",
                            Type = "float",
                            Value = MusicMaxText.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MusicMaxText.Width Units",
                            Type = "DimensionUnitType",
                            Value = MusicMaxText.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MusicMaxText.X Origin",
                            Type = "HorizontalAlignment",
                            Value = MusicMaxText.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MusicMaxText.X Units",
                            Type = "PositionUnitType",
                            Value = MusicMaxText.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MusicMaxText.Y Origin",
                            Type = "VerticalAlignment",
                            Value = MusicMaxText.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MusicMaxText.Y Units",
                            Type = "PositionUnitType",
                            Value = MusicMaxText.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CurrentVolumeLabel.Height",
                            Type = "float",
                            Value = CurrentVolumeLabel.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CurrentVolumeLabel.Height Units",
                            Type = "DimensionUnitType",
                            Value = CurrentVolumeLabel.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CurrentVolumeLabel.LabelTextAlpha",
                            Type = "int",
                            Value = CurrentVolumeLabel.LabelTextAlpha
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CurrentVolumeLabel.LabelTextBlue",
                            Type = "int",
                            Value = CurrentVolumeLabel.LabelTextBlue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CurrentVolumeLabel.LabelTextGreen",
                            Type = "int",
                            Value = CurrentVolumeLabel.LabelTextGreen
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CurrentVolumeLabel.LabelTextRed",
                            Type = "int",
                            Value = CurrentVolumeLabel.LabelTextRed
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CurrentVolumeLabel.Parent",
                            Type = "string",
                            Value = CurrentVolumeLabel.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CurrentVolumeLabel.Width",
                            Type = "float",
                            Value = CurrentVolumeLabel.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CurrentVolumeLabel.Width Units",
                            Type = "DimensionUnitType",
                            Value = CurrentVolumeLabel.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CurrentVolumeLabel.X",
                            Type = "float",
                            Value = CurrentVolumeLabel.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CurrentVolumeLabel.X Origin",
                            Type = "HorizontalAlignment",
                            Value = CurrentVolumeLabel.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CurrentVolumeLabel.X Units",
                            Type = "PositionUnitType",
                            Value = CurrentVolumeLabel.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CurrentMusicVolumeLabel.Height",
                            Type = "float",
                            Value = CurrentMusicVolumeLabel.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CurrentMusicVolumeLabel.Height Units",
                            Type = "DimensionUnitType",
                            Value = CurrentMusicVolumeLabel.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CurrentMusicVolumeLabel.LabelTextAlpha",
                            Type = "int",
                            Value = CurrentMusicVolumeLabel.LabelTextAlpha
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CurrentMusicVolumeLabel.LabelTextBlue",
                            Type = "int",
                            Value = CurrentMusicVolumeLabel.LabelTextBlue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CurrentMusicVolumeLabel.LabelTextGreen",
                            Type = "int",
                            Value = CurrentMusicVolumeLabel.LabelTextGreen
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CurrentMusicVolumeLabel.LabelTextRed",
                            Type = "int",
                            Value = CurrentMusicVolumeLabel.LabelTextRed
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CurrentMusicVolumeLabel.Parent",
                            Type = "string",
                            Value = CurrentMusicVolumeLabel.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CurrentMusicVolumeLabel.Width",
                            Type = "float",
                            Value = CurrentMusicVolumeLabel.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CurrentMusicVolumeLabel.Width Units",
                            Type = "DimensionUnitType",
                            Value = CurrentMusicVolumeLabel.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CurrentMusicVolumeLabel.X",
                            Type = "float",
                            Value = CurrentMusicVolumeLabel.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CurrentMusicVolumeLabel.X Origin",
                            Type = "HorizontalAlignment",
                            Value = CurrentMusicVolumeLabel.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CurrentMusicVolumeLabel.X Units",
                            Type = "PositionUnitType",
                            Value = CurrentMusicVolumeLabel.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RectangleInstance.Blue",
                            Type = "int",
                            Value = RectangleInstance.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RectangleInstance.Green",
                            Type = "int",
                            Value = RectangleInstance.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RectangleInstance.Height",
                            Type = "float",
                            Value = RectangleInstance.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RectangleInstance.Parent",
                            Type = "string",
                            Value = RectangleInstance.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RectangleInstance.Red",
                            Type = "int",
                            Value = RectangleInstance.Red
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RectangleInstance.Width",
                            Type = "float",
                            Value = RectangleInstance.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RectangleInstance.Width Units",
                            Type = "DimensionUnitType",
                            Value = RectangleInstance.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RectangleInstance.Y Units",
                            Type = "PositionUnitType",
                            Value = RectangleInstance.YUnits
                        }
                        );
                        break;
                }
                return newState;
            }
            private Gum.DataTypes.Variables.StateSave AddToCurrentValuesWithState (VariableState state) 
            {
                Gum.DataTypes.Variables.StateSave newState = new Gum.DataTypes.Variables.StateSave();
                switch(state)
                {
                    case  VariableState.Default:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackgroundColor.Blue",
                            Type = "int",
                            Value = BackgroundColor.Blue + 128
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackgroundColor.Green",
                            Type = "int",
                            Value = BackgroundColor.Green + 128
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackgroundColor.Height",
                            Type = "float",
                            Value = BackgroundColor.Height + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackgroundColor.Height Units",
                            Type = "DimensionUnitType",
                            Value = BackgroundColor.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackgroundColor.Red",
                            Type = "int",
                            Value = BackgroundColor.Red + 128
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackgroundColor.Width",
                            Type = "float",
                            Value = BackgroundColor.Width + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackgroundColor.Width Units",
                            Type = "DimensionUnitType",
                            Value = BackgroundColor.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackgroundColor.X",
                            Type = "float",
                            Value = BackgroundColor.X + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackgroundColor.X Origin",
                            Type = "HorizontalAlignment",
                            Value = BackgroundColor.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackgroundColor.X Units",
                            Type = "PositionUnitType",
                            Value = BackgroundColor.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackgroundColor.Y",
                            Type = "float",
                            Value = BackgroundColor.Y + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackgroundColor.Y Origin",
                            Type = "VerticalAlignment",
                            Value = BackgroundColor.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackgroundColor.Y Units",
                            Type = "PositionUnitType",
                            Value = BackgroundColor.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackButtonInstance.X",
                            Type = "float",
                            Value = BackButtonInstance.X + -40f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackButtonInstance.X Origin",
                            Type = "HorizontalAlignment",
                            Value = BackButtonInstance.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackButtonInstance.X Units",
                            Type = "PositionUnitType",
                            Value = BackButtonInstance.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackButtonInstance.Y",
                            Type = "float",
                            Value = BackButtonInstance.Y + -40f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackButtonInstance.Y Origin",
                            Type = "VerticalAlignment",
                            Value = BackButtonInstance.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackButtonInstance.Y Units",
                            Type = "PositionUnitType",
                            Value = BackButtonInstance.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SettingsText.Blue",
                            Type = "int",
                            Value = SettingsText.Blue + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SettingsText.FontSize",
                            Type = "int",
                            Value = SettingsText.FontSize + 72
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SettingsText.Green",
                            Type = "int",
                            Value = SettingsText.Green + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SettingsText.Red",
                            Type = "int",
                            Value = SettingsText.Red + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SettingsText.Text",
                            Type = "string",
                            Value = SettingsText.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SettingsText.X",
                            Type = "float",
                            Value = SettingsText.X + 2f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SettingsText.X Units",
                            Type = "PositionUnitType",
                            Value = SettingsText.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SettingsText.Y",
                            Type = "float",
                            Value = SettingsText.Y + 40f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "GraphicsTopic.Children Layout",
                            Type = "ChildrenLayout",
                            Value = GraphicsTopic.ChildrenLayout
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "GraphicsTopic.Height",
                            Type = "float",
                            Value = GraphicsTopic.Height + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "GraphicsTopic.Height Units",
                            Type = "DimensionUnitType",
                            Value = GraphicsTopic.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "GraphicsTopic.TopicName",
                            Type = "string",
                            Value = GraphicsTopic.TopicName
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "GraphicsTopic.Width",
                            Type = "float",
                            Value = GraphicsTopic.Width + 47f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "GraphicsTopic.Width Units",
                            Type = "DimensionUnitType",
                            Value = GraphicsTopic.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "GraphicsTopic.X",
                            Type = "float",
                            Value = GraphicsTopic.X + 2f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "GraphicsTopic.X Units",
                            Type = "PositionUnitType",
                            Value = GraphicsTopic.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "GraphicsTopic.Y",
                            Type = "float",
                            Value = GraphicsTopic.Y + 152f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "GraphicsTopic.Y Origin",
                            Type = "VerticalAlignment",
                            Value = GraphicsTopic.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SoudTopic.Children Layout",
                            Type = "ChildrenLayout",
                            Value = SoudTopic.ChildrenLayout
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SoudTopic.Height",
                            Type = "float",
                            Value = SoudTopic.Height + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SoudTopic.Height Units",
                            Type = "DimensionUnitType",
                            Value = SoudTopic.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SoudTopic.TopicName",
                            Type = "string",
                            Value = SoudTopic.TopicName
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SoudTopic.Width",
                            Type = "float",
                            Value = SoudTopic.Width + 47f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SoudTopic.Width Units",
                            Type = "DimensionUnitType",
                            Value = SoudTopic.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SoudTopic.X",
                            Type = "float",
                            Value = SoudTopic.X + 98f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SoudTopic.X Origin",
                            Type = "HorizontalAlignment",
                            Value = SoudTopic.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SoudTopic.X Units",
                            Type = "PositionUnitType",
                            Value = SoudTopic.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SoudTopic.Y",
                            Type = "float",
                            Value = SoudTopic.Y + 152f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResolutionContainer.Height",
                            Type = "float",
                            Value = ResolutionContainer.Height + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResolutionContainer.Height Units",
                            Type = "DimensionUnitType",
                            Value = ResolutionContainer.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResolutionContainer.Parent",
                            Type = "string",
                            Value = ResolutionContainer.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResolutionContainer.Width",
                            Type = "float",
                            Value = ResolutionContainer.Width + 100f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResolutionContainer.Width Units",
                            Type = "DimensionUnitType",
                            Value = ResolutionContainer.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResolutionContainer.X",
                            Type = "float",
                            Value = ResolutionContainer.X + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResolutionContainer.X Units",
                            Type = "PositionUnitType",
                            Value = ResolutionContainer.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResolutionContainer.Y",
                            Type = "float",
                            Value = ResolutionContainer.Y + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResolutionContainer.Y Origin",
                            Type = "VerticalAlignment",
                            Value = ResolutionContainer.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResolutionText.Blue",
                            Type = "int",
                            Value = ResolutionText.Blue + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResolutionText.Green",
                            Type = "int",
                            Value = ResolutionText.Green + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResolutionText.Height",
                            Type = "float",
                            Value = ResolutionText.Height + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResolutionText.Height Units",
                            Type = "DimensionUnitType",
                            Value = ResolutionText.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResolutionText.HorizontalAlignment",
                            Type = "HorizontalAlignment",
                            Value = ResolutionText.HorizontalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResolutionText.Parent",
                            Type = "string",
                            Value = ResolutionText.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResolutionText.Red",
                            Type = "int",
                            Value = ResolutionText.Red + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResolutionText.Text",
                            Type = "string",
                            Value = ResolutionText.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResolutionText.VerticalAlignment",
                            Type = "VerticalAlignment",
                            Value = ResolutionText.VerticalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResolutionText.Width",
                            Type = "float",
                            Value = ResolutionText.Width + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResolutionText.Width Units",
                            Type = "DimensionUnitType",
                            Value = ResolutionText.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResolutionText.X Origin",
                            Type = "HorizontalAlignment",
                            Value = ResolutionText.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResolutionText.X Units",
                            Type = "PositionUnitType",
                            Value = ResolutionText.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResolutionText.Y Origin",
                            Type = "VerticalAlignment",
                            Value = ResolutionText.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResolutionText.Y Units",
                            Type = "PositionUnitType",
                            Value = ResolutionText.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResolutionComboBox.ListBoxInstanceHeight",
                            Type = "float",
                            Value = ResolutionComboBox.ListBoxInstanceHeight + 96f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResolutionComboBox.Parent",
                            Type = "string",
                            Value = ResolutionComboBox.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResolutionComboBox.Width",
                            Type = "float",
                            Value = ResolutionComboBox.Width + 50f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResolutionComboBox.Width Units",
                            Type = "DimensionUnitType",
                            Value = ResolutionComboBox.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResolutionComboBox.X Origin",
                            Type = "HorizontalAlignment",
                            Value = ResolutionComboBox.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResolutionComboBox.X Units",
                            Type = "PositionUnitType",
                            Value = ResolutionComboBox.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WindowModeContainer.Height",
                            Type = "float",
                            Value = WindowModeContainer.Height + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WindowModeContainer.Height Units",
                            Type = "DimensionUnitType",
                            Value = WindowModeContainer.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WindowModeContainer.Parent",
                            Type = "string",
                            Value = WindowModeContainer.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WindowModeContainer.Width",
                            Type = "float",
                            Value = WindowModeContainer.Width + 100f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WindowModeContainer.Width Units",
                            Type = "DimensionUnitType",
                            Value = WindowModeContainer.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WindowModeContainer.X",
                            Type = "float",
                            Value = WindowModeContainer.X + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WindowModeContainer.Y",
                            Type = "float",
                            Value = WindowModeContainer.Y + 5f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WindowModeText.Blue",
                            Type = "int",
                            Value = WindowModeText.Blue + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WindowModeText.Green",
                            Type = "int",
                            Value = WindowModeText.Green + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WindowModeText.Height",
                            Type = "float",
                            Value = WindowModeText.Height + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WindowModeText.Height Units",
                            Type = "DimensionUnitType",
                            Value = WindowModeText.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WindowModeText.Parent",
                            Type = "string",
                            Value = WindowModeText.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WindowModeText.Red",
                            Type = "int",
                            Value = WindowModeText.Red + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WindowModeText.Text",
                            Type = "string",
                            Value = WindowModeText.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WindowModeText.Width",
                            Type = "float",
                            Value = WindowModeText.Width + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WindowModeText.Width Units",
                            Type = "DimensionUnitType",
                            Value = WindowModeText.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WindowModeText.X Units",
                            Type = "PositionUnitType",
                            Value = WindowModeText.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WindowModeText.Y Origin",
                            Type = "VerticalAlignment",
                            Value = WindowModeText.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WindowModeText.Y Units",
                            Type = "PositionUnitType",
                            Value = WindowModeText.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "VolumeText.Blue",
                            Type = "int",
                            Value = VolumeText.Blue + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "VolumeText.Green",
                            Type = "int",
                            Value = VolumeText.Green + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "VolumeText.Height",
                            Type = "float",
                            Value = VolumeText.Height + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "VolumeText.Height Units",
                            Type = "DimensionUnitType",
                            Value = VolumeText.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "VolumeText.Parent",
                            Type = "string",
                            Value = VolumeText.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "VolumeText.Red",
                            Type = "int",
                            Value = VolumeText.Red + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "VolumeText.Text",
                            Type = "string",
                            Value = VolumeText.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "VolumeText.Width",
                            Type = "float",
                            Value = VolumeText.Width + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "VolumeText.Width Units",
                            Type = "DimensionUnitType",
                            Value = VolumeText.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "VolumeText.X Units",
                            Type = "PositionUnitType",
                            Value = VolumeText.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "VolumeText.Y Origin",
                            Type = "VerticalAlignment",
                            Value = VolumeText.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "VolumeText.Y Units",
                            Type = "PositionUnitType",
                            Value = VolumeText.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MusicText.Blue",
                            Type = "int",
                            Value = MusicText.Blue + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MusicText.Green",
                            Type = "int",
                            Value = MusicText.Green + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MusicText.Height",
                            Type = "float",
                            Value = MusicText.Height + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MusicText.Height Units",
                            Type = "DimensionUnitType",
                            Value = MusicText.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MusicText.Parent",
                            Type = "string",
                            Value = MusicText.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MusicText.Red",
                            Type = "int",
                            Value = MusicText.Red + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MusicText.Text",
                            Type = "string",
                            Value = MusicText.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MusicText.Width",
                            Type = "float",
                            Value = MusicText.Width + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MusicText.Width Units",
                            Type = "DimensionUnitType",
                            Value = MusicText.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MusicText.X Units",
                            Type = "PositionUnitType",
                            Value = MusicText.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MusicText.Y Origin",
                            Type = "VerticalAlignment",
                            Value = MusicText.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MusicText.Y Units",
                            Type = "PositionUnitType",
                            Value = MusicText.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "GraphicsContainer.Children Layout",
                            Type = "ChildrenLayout",
                            Value = GraphicsContainer.ChildrenLayout
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "GraphicsContainer.Height",
                            Type = "float",
                            Value = GraphicsContainer.Height + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "GraphicsContainer.Height Units",
                            Type = "DimensionUnitType",
                            Value = GraphicsContainer.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "GraphicsContainer.Parent",
                            Type = "string",
                            Value = GraphicsContainer.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "GraphicsContainer.Width",
                            Type = "float",
                            Value = GraphicsContainer.Width + 98f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "GraphicsContainer.Width Units",
                            Type = "DimensionUnitType",
                            Value = GraphicsContainer.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "GraphicsContainer.X",
                            Type = "float",
                            Value = GraphicsContainer.X + 1f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "GraphicsContainer.X Units",
                            Type = "PositionUnitType",
                            Value = GraphicsContainer.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "GraphicsContainer.Y",
                            Type = "float",
                            Value = GraphicsContainer.Y + 40f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WindowModeComboBox.ListBoxInstanceHeight",
                            Type = "float",
                            Value = WindowModeComboBox.ListBoxInstanceHeight + 64f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WindowModeComboBox.Parent",
                            Type = "string",
                            Value = WindowModeComboBox.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WindowModeComboBox.Width",
                            Type = "float",
                            Value = WindowModeComboBox.Width + 50f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WindowModeComboBox.Width Units",
                            Type = "DimensionUnitType",
                            Value = WindowModeComboBox.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WindowModeComboBox.X Origin",
                            Type = "HorizontalAlignment",
                            Value = WindowModeComboBox.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WindowModeComboBox.X Units",
                            Type = "PositionUnitType",
                            Value = WindowModeComboBox.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SoundContainer.Children Layout",
                            Type = "ChildrenLayout",
                            Value = SoundContainer.ChildrenLayout
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SoundContainer.Height",
                            Type = "float",
                            Value = SoundContainer.Height + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SoundContainer.Height Units",
                            Type = "DimensionUnitType",
                            Value = SoundContainer.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SoundContainer.Parent",
                            Type = "string",
                            Value = SoundContainer.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SoundContainer.Width",
                            Type = "float",
                            Value = SoundContainer.Width + 98f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SoundContainer.Width Units",
                            Type = "DimensionUnitType",
                            Value = SoundContainer.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SoundContainer.X",
                            Type = "float",
                            Value = SoundContainer.X + 1f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SoundContainer.X Units",
                            Type = "PositionUnitType",
                            Value = SoundContainer.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SoundContainer.Y",
                            Type = "float",
                            Value = SoundContainer.Y + 40f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "VolumeContainer.Children Layout",
                            Type = "ChildrenLayout",
                            Value = VolumeContainer.ChildrenLayout
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "VolumeContainer.Height",
                            Type = "float",
                            Value = VolumeContainer.Height + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "VolumeContainer.Height Units",
                            Type = "DimensionUnitType",
                            Value = VolumeContainer.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "VolumeContainer.Parent",
                            Type = "string",
                            Value = VolumeContainer.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "VolumeContainer.Width",
                            Type = "float",
                            Value = VolumeContainer.Width + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "VolumeContainer.Width Units",
                            Type = "DimensionUnitType",
                            Value = VolumeContainer.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MusicContainer.Children Layout",
                            Type = "ChildrenLayout",
                            Value = MusicContainer.ChildrenLayout
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MusicContainer.Height",
                            Type = "float",
                            Value = MusicContainer.Height + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MusicContainer.Height Units",
                            Type = "DimensionUnitType",
                            Value = MusicContainer.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MusicContainer.Parent",
                            Type = "string",
                            Value = MusicContainer.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MusicContainer.Width",
                            Type = "float",
                            Value = MusicContainer.Width + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MusicContainer.Width Units",
                            Type = "DimensionUnitType",
                            Value = MusicContainer.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "VolumeSlider.Height",
                            Type = "float",
                            Value = VolumeSlider.Height + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "VolumeSlider.Height Units",
                            Type = "DimensionUnitType",
                            Value = VolumeSlider.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "VolumeSlider.Parent",
                            Type = "string",
                            Value = VolumeSlider.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "VolumeSlider.Width",
                            Type = "float",
                            Value = VolumeSlider.Width + 80f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "VolumeSlider.Width Units",
                            Type = "DimensionUnitType",
                            Value = VolumeSlider.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "VolumeSlider.X Origin",
                            Type = "HorizontalAlignment",
                            Value = VolumeSlider.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "VolumeSlider.X Units",
                            Type = "PositionUnitType",
                            Value = VolumeSlider.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MusicSlider.Height",
                            Type = "float",
                            Value = MusicSlider.Height + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MusicSlider.Height Units",
                            Type = "DimensionUnitType",
                            Value = MusicSlider.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MusicSlider.Parent",
                            Type = "string",
                            Value = MusicSlider.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MusicSlider.Width",
                            Type = "float",
                            Value = MusicSlider.Width + 80f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MusicSlider.Width Units",
                            Type = "DimensionUnitType",
                            Value = MusicSlider.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MusicSlider.X Origin",
                            Type = "HorizontalAlignment",
                            Value = MusicSlider.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MusicSlider.X Units",
                            Type = "PositionUnitType",
                            Value = MusicSlider.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "VolumeMinText.Blue",
                            Type = "int",
                            Value = VolumeMinText.Blue + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "VolumeMinText.FontSize",
                            Type = "int",
                            Value = VolumeMinText.FontSize + 24
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "VolumeMinText.Green",
                            Type = "int",
                            Value = VolumeMinText.Green + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "VolumeMinText.Height",
                            Type = "float",
                            Value = VolumeMinText.Height + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "VolumeMinText.Height Units",
                            Type = "DimensionUnitType",
                            Value = VolumeMinText.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "VolumeMinText.HorizontalAlignment",
                            Type = "HorizontalAlignment",
                            Value = VolumeMinText.HorizontalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "VolumeMinText.Parent",
                            Type = "string",
                            Value = VolumeMinText.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "VolumeMinText.Red",
                            Type = "int",
                            Value = VolumeMinText.Red + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "VolumeMinText.Text",
                            Type = "string",
                            Value = VolumeMinText.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "VolumeMinText.VerticalAlignment",
                            Type = "VerticalAlignment",
                            Value = VolumeMinText.VerticalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "VolumeMinText.Width",
                            Type = "float",
                            Value = VolumeMinText.Width + 2f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "VolumeMinText.Width Units",
                            Type = "DimensionUnitType",
                            Value = VolumeMinText.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "VolumeMinText.Y Origin",
                            Type = "VerticalAlignment",
                            Value = VolumeMinText.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "VolumeMinText.Y Units",
                            Type = "PositionUnitType",
                            Value = VolumeMinText.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MusicMinText.Blue",
                            Type = "int",
                            Value = MusicMinText.Blue + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MusicMinText.FontSize",
                            Type = "int",
                            Value = MusicMinText.FontSize + 24
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MusicMinText.Green",
                            Type = "int",
                            Value = MusicMinText.Green + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MusicMinText.Height",
                            Type = "float",
                            Value = MusicMinText.Height + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MusicMinText.Height Units",
                            Type = "DimensionUnitType",
                            Value = MusicMinText.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MusicMinText.HorizontalAlignment",
                            Type = "HorizontalAlignment",
                            Value = MusicMinText.HorizontalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MusicMinText.Parent",
                            Type = "string",
                            Value = MusicMinText.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MusicMinText.Red",
                            Type = "int",
                            Value = MusicMinText.Red + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MusicMinText.Text",
                            Type = "string",
                            Value = MusicMinText.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MusicMinText.VerticalAlignment",
                            Type = "VerticalAlignment",
                            Value = MusicMinText.VerticalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MusicMinText.Width",
                            Type = "float",
                            Value = MusicMinText.Width + 2f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MusicMinText.Width Units",
                            Type = "DimensionUnitType",
                            Value = MusicMinText.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MusicMinText.Y Origin",
                            Type = "VerticalAlignment",
                            Value = MusicMinText.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MusicMinText.Y Units",
                            Type = "PositionUnitType",
                            Value = MusicMinText.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "VolumeSliderInstance.Parent",
                            Type = "string",
                            Value = VolumeSliderInstance.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "VolumeSliderInstance.Width",
                            Type = "float",
                            Value = VolumeSliderInstance.Width + 92f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "VolumeSliderInstance.Width Units",
                            Type = "DimensionUnitType",
                            Value = VolumeSliderInstance.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "VolumeSliderInstance.X",
                            Type = "float",
                            Value = VolumeSliderInstance.X + 2f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "VolumeSliderInstance.X Units",
                            Type = "PositionUnitType",
                            Value = VolumeSliderInstance.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MusicSliderInstance.Parent",
                            Type = "string",
                            Value = MusicSliderInstance.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MusicSliderInstance.Width",
                            Type = "float",
                            Value = MusicSliderInstance.Width + 92f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MusicSliderInstance.Width Units",
                            Type = "DimensionUnitType",
                            Value = MusicSliderInstance.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MusicSliderInstance.X",
                            Type = "float",
                            Value = MusicSliderInstance.X + 2f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MusicSliderInstance.X Units",
                            Type = "PositionUnitType",
                            Value = MusicSliderInstance.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "VolumeMaxText.Blue",
                            Type = "int",
                            Value = VolumeMaxText.Blue + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "VolumeMaxText.FontSize",
                            Type = "int",
                            Value = VolumeMaxText.FontSize + 24
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "VolumeMaxText.Green",
                            Type = "int",
                            Value = VolumeMaxText.Green + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "VolumeMaxText.Height",
                            Type = "float",
                            Value = VolumeMaxText.Height + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "VolumeMaxText.Height Units",
                            Type = "DimensionUnitType",
                            Value = VolumeMaxText.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "VolumeMaxText.HorizontalAlignment",
                            Type = "HorizontalAlignment",
                            Value = VolumeMaxText.HorizontalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "VolumeMaxText.Parent",
                            Type = "string",
                            Value = VolumeMaxText.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "VolumeMaxText.Red",
                            Type = "int",
                            Value = VolumeMaxText.Red + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "VolumeMaxText.Text",
                            Type = "string",
                            Value = VolumeMaxText.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "VolumeMaxText.Width",
                            Type = "float",
                            Value = VolumeMaxText.Width + 5f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "VolumeMaxText.Width Units",
                            Type = "DimensionUnitType",
                            Value = VolumeMaxText.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "VolumeMaxText.X Origin",
                            Type = "HorizontalAlignment",
                            Value = VolumeMaxText.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "VolumeMaxText.X Units",
                            Type = "PositionUnitType",
                            Value = VolumeMaxText.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "VolumeMaxText.Y Origin",
                            Type = "VerticalAlignment",
                            Value = VolumeMaxText.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "VolumeMaxText.Y Units",
                            Type = "PositionUnitType",
                            Value = VolumeMaxText.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MusicMaxText.Blue",
                            Type = "int",
                            Value = MusicMaxText.Blue + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MusicMaxText.FontSize",
                            Type = "int",
                            Value = MusicMaxText.FontSize + 24
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MusicMaxText.Green",
                            Type = "int",
                            Value = MusicMaxText.Green + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MusicMaxText.Height",
                            Type = "float",
                            Value = MusicMaxText.Height + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MusicMaxText.Height Units",
                            Type = "DimensionUnitType",
                            Value = MusicMaxText.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MusicMaxText.HorizontalAlignment",
                            Type = "HorizontalAlignment",
                            Value = MusicMaxText.HorizontalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MusicMaxText.Parent",
                            Type = "string",
                            Value = MusicMaxText.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MusicMaxText.Red",
                            Type = "int",
                            Value = MusicMaxText.Red + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MusicMaxText.Text",
                            Type = "string",
                            Value = MusicMaxText.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MusicMaxText.Width",
                            Type = "float",
                            Value = MusicMaxText.Width + 5f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MusicMaxText.Width Units",
                            Type = "DimensionUnitType",
                            Value = MusicMaxText.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MusicMaxText.X Origin",
                            Type = "HorizontalAlignment",
                            Value = MusicMaxText.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MusicMaxText.X Units",
                            Type = "PositionUnitType",
                            Value = MusicMaxText.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MusicMaxText.Y Origin",
                            Type = "VerticalAlignment",
                            Value = MusicMaxText.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MusicMaxText.Y Units",
                            Type = "PositionUnitType",
                            Value = MusicMaxText.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CurrentVolumeLabel.Height",
                            Type = "float",
                            Value = CurrentVolumeLabel.Height + 100f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CurrentVolumeLabel.Height Units",
                            Type = "DimensionUnitType",
                            Value = CurrentVolumeLabel.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CurrentVolumeLabel.LabelTextAlpha",
                            Type = "int",
                            Value = CurrentVolumeLabel.LabelTextAlpha + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CurrentVolumeLabel.LabelTextBlue",
                            Type = "int",
                            Value = CurrentVolumeLabel.LabelTextBlue + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CurrentVolumeLabel.LabelTextGreen",
                            Type = "int",
                            Value = CurrentVolumeLabel.LabelTextGreen + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CurrentVolumeLabel.LabelTextRed",
                            Type = "int",
                            Value = CurrentVolumeLabel.LabelTextRed + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CurrentVolumeLabel.Parent",
                            Type = "string",
                            Value = CurrentVolumeLabel.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CurrentVolumeLabel.Width",
                            Type = "float",
                            Value = CurrentVolumeLabel.Width + 10f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CurrentVolumeLabel.Width Units",
                            Type = "DimensionUnitType",
                            Value = CurrentVolumeLabel.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CurrentVolumeLabel.X",
                            Type = "float",
                            Value = CurrentVolumeLabel.X + 20f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CurrentVolumeLabel.X Origin",
                            Type = "HorizontalAlignment",
                            Value = CurrentVolumeLabel.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CurrentVolumeLabel.X Units",
                            Type = "PositionUnitType",
                            Value = CurrentVolumeLabel.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CurrentMusicVolumeLabel.Height",
                            Type = "float",
                            Value = CurrentMusicVolumeLabel.Height + 100f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CurrentMusicVolumeLabel.Height Units",
                            Type = "DimensionUnitType",
                            Value = CurrentMusicVolumeLabel.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CurrentMusicVolumeLabel.LabelTextAlpha",
                            Type = "int",
                            Value = CurrentMusicVolumeLabel.LabelTextAlpha + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CurrentMusicVolumeLabel.LabelTextBlue",
                            Type = "int",
                            Value = CurrentMusicVolumeLabel.LabelTextBlue + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CurrentMusicVolumeLabel.LabelTextGreen",
                            Type = "int",
                            Value = CurrentMusicVolumeLabel.LabelTextGreen + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CurrentMusicVolumeLabel.LabelTextRed",
                            Type = "int",
                            Value = CurrentMusicVolumeLabel.LabelTextRed + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CurrentMusicVolumeLabel.Parent",
                            Type = "string",
                            Value = CurrentMusicVolumeLabel.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CurrentMusicVolumeLabel.Width",
                            Type = "float",
                            Value = CurrentMusicVolumeLabel.Width + 10f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CurrentMusicVolumeLabel.Width Units",
                            Type = "DimensionUnitType",
                            Value = CurrentMusicVolumeLabel.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CurrentMusicVolumeLabel.X",
                            Type = "float",
                            Value = CurrentMusicVolumeLabel.X + 20f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CurrentMusicVolumeLabel.X Origin",
                            Type = "HorizontalAlignment",
                            Value = CurrentMusicVolumeLabel.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CurrentMusicVolumeLabel.X Units",
                            Type = "PositionUnitType",
                            Value = CurrentMusicVolumeLabel.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RectangleInstance.Blue",
                            Type = "int",
                            Value = RectangleInstance.Blue + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RectangleInstance.Green",
                            Type = "int",
                            Value = RectangleInstance.Green + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RectangleInstance.Height",
                            Type = "float",
                            Value = RectangleInstance.Height + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RectangleInstance.Parent",
                            Type = "string",
                            Value = RectangleInstance.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RectangleInstance.Red",
                            Type = "int",
                            Value = RectangleInstance.Red + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RectangleInstance.Width",
                            Type = "float",
                            Value = RectangleInstance.Width + 100f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RectangleInstance.Width Units",
                            Type = "DimensionUnitType",
                            Value = RectangleInstance.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RectangleInstance.Y Units",
                            Type = "PositionUnitType",
                            Value = RectangleInstance.YUnits
                        }
                        );
                        break;
                }
                return newState;
            }
            #endregion
            public override void ApplyState (Gum.DataTypes.Variables.StateSave state) 
            {
                bool matches = this.ElementSave.AllStates.Contains(state);
                if (matches)
                {
                    var category = this.ElementSave.Categories.FirstOrDefault(item => item.States.Contains(state));
                    if (category == null)
                    {
                        if (state.Name == "Default") this.mCurrentVariableState = VariableState.Default;
                    }
                }
                base.ApplyState(state);
            }
            private bool tryCreateFormsObject;
            public JHP4SD.GumRuntimes.ColoredRectangleRuntime BackgroundColor { get; set; }
            public JHP4SD.GumRuntimes.LebegForms.BasicComponents.BackButtonRuntime BackButtonInstance { get; set; }
            public JHP4SD.GumRuntimes.TextRuntime SettingsText { get; set; }
            public JHP4SD.GumRuntimes.LebegForms.ComplexComponents.TopicRuntime GraphicsTopic { get; set; }
            public JHP4SD.GumRuntimes.LebegForms.ComplexComponents.TopicRuntime SoudTopic { get; set; }
            public JHP4SD.GumRuntimes.ContainerRuntime ResolutionContainer { get; set; }
            public JHP4SD.GumRuntimes.TextRuntime ResolutionText { get; set; }
            public JHP4SD.GumRuntimes.DefaultForms.ComboBoxRuntime ResolutionComboBox { get; set; }
            public JHP4SD.GumRuntimes.ContainerRuntime WindowModeContainer { get; set; }
            public JHP4SD.GumRuntimes.TextRuntime WindowModeText { get; set; }
            public JHP4SD.GumRuntimes.TextRuntime VolumeText { get; set; }
            public JHP4SD.GumRuntimes.TextRuntime MusicText { get; set; }
            public JHP4SD.GumRuntimes.ContainerRuntime GraphicsContainer { get; set; }
            public JHP4SD.GumRuntimes.DefaultForms.ComboBoxRuntime WindowModeComboBox { get; set; }
            public JHP4SD.GumRuntimes.ContainerRuntime SoundContainer { get; set; }
            public JHP4SD.GumRuntimes.ContainerRuntime VolumeContainer { get; set; }
            public JHP4SD.GumRuntimes.ContainerRuntime MusicContainer { get; set; }
            public JHP4SD.GumRuntimes.ContainerRuntime VolumeSlider { get; set; }
            public JHP4SD.GumRuntimes.ContainerRuntime MusicSlider { get; set; }
            public JHP4SD.GumRuntimes.TextRuntime VolumeMinText { get; set; }
            public JHP4SD.GumRuntimes.TextRuntime MusicMinText { get; set; }
            public JHP4SD.GumRuntimes.DefaultForms.SliderRuntime VolumeSliderInstance { get; set; }
            public JHP4SD.GumRuntimes.DefaultForms.SliderRuntime MusicSliderInstance { get; set; }
            public JHP4SD.GumRuntimes.TextRuntime VolumeMaxText { get; set; }
            public JHP4SD.GumRuntimes.TextRuntime MusicMaxText { get; set; }
            public JHP4SD.GumRuntimes.DefaultForms.LabelRuntime CurrentVolumeLabel { get; set; }
            public JHP4SD.GumRuntimes.DefaultForms.LabelRuntime CurrentMusicVolumeLabel { get; set; }
            public JHP4SD.GumRuntimes.RectangleRuntime RectangleInstance { get; set; }
            public SettingsGumRuntime (bool fullInstantiation = true, bool tryCreateFormsObject = true) 
            {
                this.tryCreateFormsObject = tryCreateFormsObject;
                if (fullInstantiation)
                {
                    Gum.DataTypes.ElementSave elementSave = Gum.Managers.ObjectFinder.Self.GumProjectSave.Screens.First(item => item.Name == "SettingsGum");
                    this.ElementSave = elementSave;
                    string oldDirectory = FlatRedBall.IO.FileManager.RelativeDirectory;
                    FlatRedBall.IO.FileManager.RelativeDirectory = FlatRedBall.IO.FileManager.GetDirectory(Gum.Managers.ObjectFinder.Self.GumProjectSave.FullFileName);
                    GumRuntime.ElementSaveExtensions.SetGraphicalUiElement(elementSave, this, RenderingLibrary.SystemManagers.Default);
                    FlatRedBall.IO.FileManager.RelativeDirectory = oldDirectory;
                }
            }
            public override void SetInitialState () 
            {
                base.SetInitialState();
                this.CurrentVariableState = VariableState.Default;
                CallCustomInitialize();
            }
            public override void CreateChildrenRecursively (Gum.DataTypes.ElementSave elementSave, RenderingLibrary.SystemManagers systemManagers) 
            {
                base.CreateChildrenRecursively(elementSave, systemManagers);
                this.AssignReferences();
            }
            private void AssignReferences () 
            {
                BackgroundColor = this.GetGraphicalUiElementByName("BackgroundColor") as JHP4SD.GumRuntimes.ColoredRectangleRuntime;
                BackButtonInstance = this.GetGraphicalUiElementByName("BackButtonInstance") as JHP4SD.GumRuntimes.LebegForms.BasicComponents.BackButtonRuntime;
                SettingsText = this.GetGraphicalUiElementByName("SettingsText") as JHP4SD.GumRuntimes.TextRuntime;
                GraphicsTopic = this.GetGraphicalUiElementByName("GraphicsTopic") as JHP4SD.GumRuntimes.LebegForms.ComplexComponents.TopicRuntime;
                SoudTopic = this.GetGraphicalUiElementByName("SoudTopic") as JHP4SD.GumRuntimes.LebegForms.ComplexComponents.TopicRuntime;
                ResolutionContainer = this.GetGraphicalUiElementByName("ResolutionContainer") as JHP4SD.GumRuntimes.ContainerRuntime;
                ResolutionText = this.GetGraphicalUiElementByName("ResolutionText") as JHP4SD.GumRuntimes.TextRuntime;
                ResolutionComboBox = this.GetGraphicalUiElementByName("ResolutionComboBox") as JHP4SD.GumRuntimes.DefaultForms.ComboBoxRuntime;
                WindowModeContainer = this.GetGraphicalUiElementByName("WindowModeContainer") as JHP4SD.GumRuntimes.ContainerRuntime;
                WindowModeText = this.GetGraphicalUiElementByName("WindowModeText") as JHP4SD.GumRuntimes.TextRuntime;
                VolumeText = this.GetGraphicalUiElementByName("VolumeText") as JHP4SD.GumRuntimes.TextRuntime;
                MusicText = this.GetGraphicalUiElementByName("MusicText") as JHP4SD.GumRuntimes.TextRuntime;
                GraphicsContainer = this.GetGraphicalUiElementByName("GraphicsContainer") as JHP4SD.GumRuntimes.ContainerRuntime;
                WindowModeComboBox = this.GetGraphicalUiElementByName("WindowModeComboBox") as JHP4SD.GumRuntimes.DefaultForms.ComboBoxRuntime;
                SoundContainer = this.GetGraphicalUiElementByName("SoundContainer") as JHP4SD.GumRuntimes.ContainerRuntime;
                VolumeContainer = this.GetGraphicalUiElementByName("VolumeContainer") as JHP4SD.GumRuntimes.ContainerRuntime;
                MusicContainer = this.GetGraphicalUiElementByName("MusicContainer") as JHP4SD.GumRuntimes.ContainerRuntime;
                VolumeSlider = this.GetGraphicalUiElementByName("VolumeSlider") as JHP4SD.GumRuntimes.ContainerRuntime;
                MusicSlider = this.GetGraphicalUiElementByName("MusicSlider") as JHP4SD.GumRuntimes.ContainerRuntime;
                VolumeMinText = this.GetGraphicalUiElementByName("VolumeMinText") as JHP4SD.GumRuntimes.TextRuntime;
                MusicMinText = this.GetGraphicalUiElementByName("MusicMinText") as JHP4SD.GumRuntimes.TextRuntime;
                VolumeSliderInstance = this.GetGraphicalUiElementByName("VolumeSliderInstance") as JHP4SD.GumRuntimes.DefaultForms.SliderRuntime;
                MusicSliderInstance = this.GetGraphicalUiElementByName("MusicSliderInstance") as JHP4SD.GumRuntimes.DefaultForms.SliderRuntime;
                VolumeMaxText = this.GetGraphicalUiElementByName("VolumeMaxText") as JHP4SD.GumRuntimes.TextRuntime;
                MusicMaxText = this.GetGraphicalUiElementByName("MusicMaxText") as JHP4SD.GumRuntimes.TextRuntime;
                CurrentVolumeLabel = this.GetGraphicalUiElementByName("CurrentVolumeLabel") as JHP4SD.GumRuntimes.DefaultForms.LabelRuntime;
                CurrentMusicVolumeLabel = this.GetGraphicalUiElementByName("CurrentMusicVolumeLabel") as JHP4SD.GumRuntimes.DefaultForms.LabelRuntime;
                RectangleInstance = this.GetGraphicalUiElementByName("RectangleInstance") as JHP4SD.GumRuntimes.RectangleRuntime;
                if (tryCreateFormsObject)
                {
                    FormsControlAsObject = new JHP4SD.FormsControls.Screens.SettingsGumForms(this);
                }
            }
            public override void AddToManagers (RenderingLibrary.SystemManagers managers, RenderingLibrary.Graphics.Layer layer) 
            {
                base.AddToManagers(managers, layer);
            }
            private void CallCustomInitialize () 
            {
                CustomInitialize();
            }
            partial void CustomInitialize();
            public JHP4SD.FormsControls.Screens.SettingsGumForms FormsControl {get => (JHP4SD.FormsControls.Screens.SettingsGumForms) FormsControlAsObject;}
        }
    }
