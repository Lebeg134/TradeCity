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
                            FullscreenContainer.Parent = this.GetGraphicalUiElementByName("GraphicsContainer");
                            WindowModeText.Parent = this.GetGraphicalUiElementByName("FullscreenContainer");
                            GraphicsContainer.Parent = this.GetGraphicalUiElementByName("GraphicsTopic");
                            WindowModeComboBox.Parent = this.GetGraphicalUiElementByName("FullscreenContainer");
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
                            SoudTopic.ChildrenLayout = Gum.Managers.ChildrenLayout.TopToBottomStack;
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
                            ResolutionComboBox.Width = 50f;
                            ResolutionComboBox.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            ResolutionComboBox.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                            ResolutionComboBox.XUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                            FullscreenContainer.Height = 0f;
                            FullscreenContainer.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                            FullscreenContainer.Width = 100f;
                            FullscreenContainer.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            FullscreenContainer.X = 0f;
                            FullscreenContainer.Y = 5f;
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
                            GraphicsContainer.ChildrenLayout = Gum.Managers.ChildrenLayout.TopToBottomStack;
                            GraphicsContainer.Height = 0f;
                            GraphicsContainer.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                            GraphicsContainer.Width = 98f;
                            GraphicsContainer.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            GraphicsContainer.X = 1f;
                            GraphicsContainer.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                            GraphicsContainer.Y = 40f;
                            WindowModeComboBox.Width = 50f;
                            WindowModeComboBox.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            WindowModeComboBox.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                            WindowModeComboBox.XUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
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
                bool setFullscreenContainerHeightFirstValue = false;
                bool setFullscreenContainerHeightSecondValue = false;
                float FullscreenContainerHeightFirstValue= 0;
                float FullscreenContainerHeightSecondValue= 0;
                bool setFullscreenContainerWidthFirstValue = false;
                bool setFullscreenContainerWidthSecondValue = false;
                float FullscreenContainerWidthFirstValue= 0;
                float FullscreenContainerWidthSecondValue= 0;
                bool setFullscreenContainerXFirstValue = false;
                bool setFullscreenContainerXSecondValue = false;
                float FullscreenContainerXFirstValue= 0;
                float FullscreenContainerXSecondValue= 0;
                bool setFullscreenContainerYFirstValue = false;
                bool setFullscreenContainerYSecondValue = false;
                float FullscreenContainerYFirstValue= 0;
                float FullscreenContainerYSecondValue= 0;
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
                bool setWindowModeComboBoxWidthFirstValue = false;
                bool setWindowModeComboBoxWidthSecondValue = false;
                float WindowModeComboBoxWidthFirstValue= 0;
                float WindowModeComboBoxWidthSecondValue= 0;
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
                        setFullscreenContainerHeightFirstValue = true;
                        FullscreenContainerHeightFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.FullscreenContainer.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                        }
                        if (interpolationValue < 1)
                        {
                            this.FullscreenContainer.Parent = this.GetGraphicalUiElementByName("GraphicsContainer");
                        }
                        setFullscreenContainerWidthFirstValue = true;
                        FullscreenContainerWidthFirstValue = 100f;
                        if (interpolationValue < 1)
                        {
                            this.FullscreenContainer.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setFullscreenContainerXFirstValue = true;
                        FullscreenContainerXFirstValue = 0f;
                        setFullscreenContainerYFirstValue = true;
                        FullscreenContainerYFirstValue = 5f;
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
                            this.SoudTopic.ChildrenLayout = Gum.Managers.ChildrenLayout.TopToBottomStack;
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
                            this.WindowModeComboBox.Parent = this.GetGraphicalUiElementByName("FullscreenContainer");
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
                            this.WindowModeText.Parent = this.GetGraphicalUiElementByName("FullscreenContainer");
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
                        setFullscreenContainerHeightSecondValue = true;
                        FullscreenContainerHeightSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.FullscreenContainer.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.FullscreenContainer.Parent = this.GetGraphicalUiElementByName("GraphicsContainer");
                        }
                        setFullscreenContainerWidthSecondValue = true;
                        FullscreenContainerWidthSecondValue = 100f;
                        if (interpolationValue >= 1)
                        {
                            this.FullscreenContainer.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setFullscreenContainerXSecondValue = true;
                        FullscreenContainerXSecondValue = 0f;
                        setFullscreenContainerYSecondValue = true;
                        FullscreenContainerYSecondValue = 5f;
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
                            this.SoudTopic.ChildrenLayout = Gum.Managers.ChildrenLayout.TopToBottomStack;
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
                            this.WindowModeComboBox.Parent = this.GetGraphicalUiElementByName("FullscreenContainer");
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
                            this.WindowModeText.Parent = this.GetGraphicalUiElementByName("FullscreenContainer");
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
                if (setFullscreenContainerHeightFirstValue && setFullscreenContainerHeightSecondValue)
                {
                    FullscreenContainer.Height = FullscreenContainerHeightFirstValue * (1 - interpolationValue) + FullscreenContainerHeightSecondValue * interpolationValue;
                }
                if (setFullscreenContainerWidthFirstValue && setFullscreenContainerWidthSecondValue)
                {
                    FullscreenContainer.Width = FullscreenContainerWidthFirstValue * (1 - interpolationValue) + FullscreenContainerWidthSecondValue * interpolationValue;
                }
                if (setFullscreenContainerXFirstValue && setFullscreenContainerXSecondValue)
                {
                    FullscreenContainer.X = FullscreenContainerXFirstValue * (1 - interpolationValue) + FullscreenContainerXSecondValue * interpolationValue;
                }
                if (setFullscreenContainerYFirstValue && setFullscreenContainerYSecondValue)
                {
                    FullscreenContainer.Y = FullscreenContainerYFirstValue * (1 - interpolationValue) + FullscreenContainerYSecondValue * interpolationValue;
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
                if (setWindowModeComboBoxWidthFirstValue && setWindowModeComboBoxWidthSecondValue)
                {
                    WindowModeComboBox.Width = WindowModeComboBoxWidthFirstValue * (1 - interpolationValue) + WindowModeComboBoxWidthSecondValue * interpolationValue;
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
                            Name = "FullscreenContainer.Height",
                            Type = "float",
                            Value = FullscreenContainer.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FullscreenContainer.Height Units",
                            Type = "DimensionUnitType",
                            Value = FullscreenContainer.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FullscreenContainer.Parent",
                            Type = "string",
                            Value = FullscreenContainer.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FullscreenContainer.Width",
                            Type = "float",
                            Value = FullscreenContainer.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FullscreenContainer.Width Units",
                            Type = "DimensionUnitType",
                            Value = FullscreenContainer.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FullscreenContainer.X",
                            Type = "float",
                            Value = FullscreenContainer.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FullscreenContainer.Y",
                            Type = "float",
                            Value = FullscreenContainer.Y
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
                            Name = "FullscreenContainer.Height",
                            Type = "float",
                            Value = FullscreenContainer.Height + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FullscreenContainer.Height Units",
                            Type = "DimensionUnitType",
                            Value = FullscreenContainer.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FullscreenContainer.Parent",
                            Type = "string",
                            Value = FullscreenContainer.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FullscreenContainer.Width",
                            Type = "float",
                            Value = FullscreenContainer.Width + 100f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FullscreenContainer.Width Units",
                            Type = "DimensionUnitType",
                            Value = FullscreenContainer.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FullscreenContainer.X",
                            Type = "float",
                            Value = FullscreenContainer.X + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FullscreenContainer.Y",
                            Type = "float",
                            Value = FullscreenContainer.Y + 5f
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
            public JHP4SD.GumRuntimes.ContainerRuntime FullscreenContainer { get; set; }
            public JHP4SD.GumRuntimes.TextRuntime WindowModeText { get; set; }
            public JHP4SD.GumRuntimes.ContainerRuntime GraphicsContainer { get; set; }
            public JHP4SD.GumRuntimes.DefaultForms.ComboBoxRuntime WindowModeComboBox { get; set; }
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
                FullscreenContainer = this.GetGraphicalUiElementByName("FullscreenContainer") as JHP4SD.GumRuntimes.ContainerRuntime;
                WindowModeText = this.GetGraphicalUiElementByName("WindowModeText") as JHP4SD.GumRuntimes.TextRuntime;
                GraphicsContainer = this.GetGraphicalUiElementByName("GraphicsContainer") as JHP4SD.GumRuntimes.ContainerRuntime;
                WindowModeComboBox = this.GetGraphicalUiElementByName("WindowModeComboBox") as JHP4SD.GumRuntimes.DefaultForms.ComboBoxRuntime;
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
