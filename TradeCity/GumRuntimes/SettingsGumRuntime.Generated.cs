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
                            SettingsText.Parent = this.GetGraphicalUiElementByName("BackgroundColor");
                            GraphicsTopic.Parent = this.GetGraphicalUiElementByName("BackgroundColor");
                            SoudTopic.Parent = this.GetGraphicalUiElementByName("BackgroundColor");
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
                            GraphicsTopic.Height = 40f;
                            GraphicsTopic.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                            GraphicsTopic.TopicName = "Graphics";
                            GraphicsTopic.Width = 47f;
                            GraphicsTopic.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            GraphicsTopic.X = 2f;
                            GraphicsTopic.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                            GraphicsTopic.Y = 152f;
                            SoudTopic.Height = 40f;
                            SoudTopic.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                            SoudTopic.TopicName = "Sound";
                            SoudTopic.Width = 47f;
                            SoudTopic.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            SoudTopic.X = 98f;
                            SoudTopic.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                            SoudTopic.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                            SoudTopic.Y = 152f;
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
                        setGraphicsTopicHeightFirstValue = true;
                        GraphicsTopicHeightFirstValue = 40f;
                        if (interpolationValue < 1)
                        {
                            this.GraphicsTopic.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                        }
                        if (interpolationValue < 1)
                        {
                            this.GraphicsTopic.Parent = this.GetGraphicalUiElementByName("BackgroundColor");
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
                        setSettingsTextBlueFirstValue = true;
                        SettingsTextBlueFirstValue = 0;
                        setSettingsTextFontSizeFirstValue = true;
                        SettingsTextFontSizeFirstValue = 72;
                        setSettingsTextGreenFirstValue = true;
                        SettingsTextGreenFirstValue = 0;
                        if (interpolationValue < 1)
                        {
                            this.SettingsText.Parent = this.GetGraphicalUiElementByName("BackgroundColor");
                        }
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
                        setSoudTopicHeightFirstValue = true;
                        SoudTopicHeightFirstValue = 40f;
                        if (interpolationValue < 1)
                        {
                            this.SoudTopic.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                        }
                        if (interpolationValue < 1)
                        {
                            this.SoudTopic.Parent = this.GetGraphicalUiElementByName("BackgroundColor");
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
                        setGraphicsTopicHeightSecondValue = true;
                        GraphicsTopicHeightSecondValue = 40f;
                        if (interpolationValue >= 1)
                        {
                            this.GraphicsTopic.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.GraphicsTopic.Parent = this.GetGraphicalUiElementByName("BackgroundColor");
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
                        setSettingsTextBlueSecondValue = true;
                        SettingsTextBlueSecondValue = 0;
                        setSettingsTextFontSizeSecondValue = true;
                        SettingsTextFontSizeSecondValue = 72;
                        setSettingsTextGreenSecondValue = true;
                        SettingsTextGreenSecondValue = 0;
                        if (interpolationValue >= 1)
                        {
                            this.SettingsText.Parent = this.GetGraphicalUiElementByName("BackgroundColor");
                        }
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
                        setSoudTopicHeightSecondValue = true;
                        SoudTopicHeightSecondValue = 40f;
                        if (interpolationValue >= 1)
                        {
                            this.SoudTopic.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.SoudTopic.Parent = this.GetGraphicalUiElementByName("BackgroundColor");
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
                            Name = "SettingsText.Parent",
                            Type = "string",
                            Value = SettingsText.Parent
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
                            Name = "GraphicsTopic.Parent",
                            Type = "string",
                            Value = GraphicsTopic.Parent
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
                            Name = "SoudTopic.Parent",
                            Type = "string",
                            Value = SoudTopic.Parent
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
                            Name = "SettingsText.Parent",
                            Type = "string",
                            Value = SettingsText.Parent
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
                            Name = "GraphicsTopic.Height",
                            Type = "float",
                            Value = GraphicsTopic.Height + 40f
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
                            Name = "GraphicsTopic.Parent",
                            Type = "string",
                            Value = GraphicsTopic.Parent
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
                            Name = "SoudTopic.Height",
                            Type = "float",
                            Value = SoudTopic.Height + 40f
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
                            Name = "SoudTopic.Parent",
                            Type = "string",
                            Value = SoudTopic.Parent
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
