    using System.Linq;
    namespace JHP4SD.GumRuntimes.LebegForms.ComplexComponents
    {
        public partial class TopicRuntime : JHP4SD.GumRuntimes.ContainerRuntime
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
                            TextInstance.Parent = this.GetGraphicalUiElementByName("Top") ?? this;
                            HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                            WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                            BackgroundColor.Blue = 105;
                            BackgroundColor.Green = 105;
                            BackgroundColor.Height = 0f;
                            BackgroundColor.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                            BackgroundColor.Red = 105;
                            BackgroundColor.Width = 0f;
                            BackgroundColor.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                            BackgroundColor.X = 0f;
                            BackgroundColor.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                            BackgroundColor.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            BackgroundColor.Y = 0f;
                            BackgroundColor.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            BackgroundColor.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            Border.Blue = 0;
                            Border.Green = 0;
                            Border.Height = 0f;
                            Border.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                            Border.Red = 0;
                            Border.Width = 0f;
                            Border.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                            Border.X = 0f;
                            Border.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                            Border.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            Border.Y = 0f;
                            Border.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            Border.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            Top.Blue = 0;
                            Top.Green = 0;
                            Top.Height = 20f;
                            Top.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                            Top.Red = 0;
                            Top.Width = 100f;
                            Top.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            Top.X = 0f;
                            Top.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                            Top.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            Top.Y = 0f;
                            Top.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Top;
                            Top.YUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                            TextInstance.Blue = 0;
                            TextInstance.Font = "Arial";
                            TextInstance.FontSize = 24;
                            TextInstance.Green = 0;
                            TextInstance.Height = 0f;
                            TextInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                            TextInstance.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                            TextInstance.Red = 0;
                            TextInstance.Text = "TopicName";
                            TextInstance.VerticalAlignment = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            TextInstance.Visible = true;
                            TextInstance.Width = 95f;
                            TextInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            TextInstance.X = 5f;
                            TextInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                            TextInstance.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                            TextInstance.Y = 0f;
                            TextInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            TextInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
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
                bool setBorderBlueFirstValue = false;
                bool setBorderBlueSecondValue = false;
                int BorderBlueFirstValue= 0;
                int BorderBlueSecondValue= 0;
                bool setBorderGreenFirstValue = false;
                bool setBorderGreenSecondValue = false;
                int BorderGreenFirstValue= 0;
                int BorderGreenSecondValue= 0;
                bool setBorderHeightFirstValue = false;
                bool setBorderHeightSecondValue = false;
                float BorderHeightFirstValue= 0;
                float BorderHeightSecondValue= 0;
                bool setBorderRedFirstValue = false;
                bool setBorderRedSecondValue = false;
                int BorderRedFirstValue= 0;
                int BorderRedSecondValue= 0;
                bool setBorderWidthFirstValue = false;
                bool setBorderWidthSecondValue = false;
                float BorderWidthFirstValue= 0;
                float BorderWidthSecondValue= 0;
                bool setBorderXFirstValue = false;
                bool setBorderXSecondValue = false;
                float BorderXFirstValue= 0;
                float BorderXSecondValue= 0;
                bool setBorderYFirstValue = false;
                bool setBorderYSecondValue = false;
                float BorderYFirstValue= 0;
                float BorderYSecondValue= 0;
                bool setTextInstanceBlueFirstValue = false;
                bool setTextInstanceBlueSecondValue = false;
                int TextInstanceBlueFirstValue= 0;
                int TextInstanceBlueSecondValue= 0;
                bool setTextInstanceFontSizeFirstValue = false;
                bool setTextInstanceFontSizeSecondValue = false;
                int TextInstanceFontSizeFirstValue= 0;
                int TextInstanceFontSizeSecondValue= 0;
                bool setTextInstanceGreenFirstValue = false;
                bool setTextInstanceGreenSecondValue = false;
                int TextInstanceGreenFirstValue= 0;
                int TextInstanceGreenSecondValue= 0;
                bool setTextInstanceHeightFirstValue = false;
                bool setTextInstanceHeightSecondValue = false;
                float TextInstanceHeightFirstValue= 0;
                float TextInstanceHeightSecondValue= 0;
                bool setTextInstanceRedFirstValue = false;
                bool setTextInstanceRedSecondValue = false;
                int TextInstanceRedFirstValue= 0;
                int TextInstanceRedSecondValue= 0;
                bool setTextInstanceWidthFirstValue = false;
                bool setTextInstanceWidthSecondValue = false;
                float TextInstanceWidthFirstValue= 0;
                float TextInstanceWidthSecondValue= 0;
                bool setTextInstanceXFirstValue = false;
                bool setTextInstanceXSecondValue = false;
                float TextInstanceXFirstValue= 0;
                float TextInstanceXSecondValue= 0;
                bool setTextInstanceYFirstValue = false;
                bool setTextInstanceYSecondValue = false;
                float TextInstanceYFirstValue= 0;
                float TextInstanceYSecondValue= 0;
                bool setTopBlueFirstValue = false;
                bool setTopBlueSecondValue = false;
                int TopBlueFirstValue= 0;
                int TopBlueSecondValue= 0;
                bool setTopGreenFirstValue = false;
                bool setTopGreenSecondValue = false;
                int TopGreenFirstValue= 0;
                int TopGreenSecondValue= 0;
                bool setTopHeightFirstValue = false;
                bool setTopHeightSecondValue = false;
                float TopHeightFirstValue= 0;
                float TopHeightSecondValue= 0;
                bool setTopRedFirstValue = false;
                bool setTopRedSecondValue = false;
                int TopRedFirstValue= 0;
                int TopRedSecondValue= 0;
                bool setTopWidthFirstValue = false;
                bool setTopWidthSecondValue = false;
                float TopWidthFirstValue= 0;
                float TopWidthSecondValue= 0;
                bool setTopXFirstValue = false;
                bool setTopXSecondValue = false;
                float TopXFirstValue= 0;
                float TopXSecondValue= 0;
                bool setTopYFirstValue = false;
                bool setTopYSecondValue = false;
                float TopYFirstValue= 0;
                float TopYSecondValue= 0;
                switch(firstState)
                {
                    case  VariableState.Default:
                        setBackgroundColorBlueFirstValue = true;
                        BackgroundColorBlueFirstValue = 105;
                        setBackgroundColorGreenFirstValue = true;
                        BackgroundColorGreenFirstValue = 105;
                        setBackgroundColorHeightFirstValue = true;
                        BackgroundColorHeightFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.BackgroundColor.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        setBackgroundColorRedFirstValue = true;
                        BackgroundColorRedFirstValue = 105;
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
                        setBorderBlueFirstValue = true;
                        BorderBlueFirstValue = 0;
                        setBorderGreenFirstValue = true;
                        BorderGreenFirstValue = 0;
                        setBorderHeightFirstValue = true;
                        BorderHeightFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.Border.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        setBorderRedFirstValue = true;
                        BorderRedFirstValue = 0;
                        setBorderWidthFirstValue = true;
                        BorderWidthFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.Border.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        setBorderXFirstValue = true;
                        BorderXFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.Border.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.Border.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setBorderYFirstValue = true;
                        BorderYFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.Border.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.Border.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        if (interpolationValue < 1)
                        {
                            this.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                        }
                        setTextInstanceBlueFirstValue = true;
                        TextInstanceBlueFirstValue = 0;
                        if (interpolationValue < 1)
                        {
                            this.TextInstance.Font = "Arial";
                        }
                        setTextInstanceFontSizeFirstValue = true;
                        TextInstanceFontSizeFirstValue = 24;
                        setTextInstanceGreenFirstValue = true;
                        TextInstanceGreenFirstValue = 0;
                        setTextInstanceHeightFirstValue = true;
                        TextInstanceHeightFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.TextInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        if (interpolationValue < 1)
                        {
                            this.TextInstance.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                        }
                        if (interpolationValue < 1)
                        {
                            this.TextInstance.Parent = this.GetGraphicalUiElementByName("Top") ?? this;
                        }
                        setTextInstanceRedFirstValue = true;
                        TextInstanceRedFirstValue = 0;
                        if (interpolationValue < 1)
                        {
                            this.TextInstance.Text = "TopicName";
                        }
                        if (interpolationValue < 1)
                        {
                            this.TextInstance.VerticalAlignment = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.TextInstance.Visible = true;
                        }
                        setTextInstanceWidthFirstValue = true;
                        TextInstanceWidthFirstValue = 95f;
                        if (interpolationValue < 1)
                        {
                            this.TextInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setTextInstanceXFirstValue = true;
                        TextInstanceXFirstValue = 5f;
                        if (interpolationValue < 1)
                        {
                            this.TextInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                        }
                        if (interpolationValue < 1)
                        {
                            this.TextInstance.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setTextInstanceYFirstValue = true;
                        TextInstanceYFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.TextInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.TextInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setTopBlueFirstValue = true;
                        TopBlueFirstValue = 0;
                        setTopGreenFirstValue = true;
                        TopGreenFirstValue = 0;
                        setTopHeightFirstValue = true;
                        TopHeightFirstValue = 20f;
                        if (interpolationValue < 1)
                        {
                            this.Top.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                        }
                        setTopRedFirstValue = true;
                        TopRedFirstValue = 0;
                        setTopWidthFirstValue = true;
                        TopWidthFirstValue = 100f;
                        if (interpolationValue < 1)
                        {
                            this.Top.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setTopXFirstValue = true;
                        TopXFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.Top.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.Top.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setTopYFirstValue = true;
                        TopYFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.Top.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Top;
                        }
                        if (interpolationValue < 1)
                        {
                            this.Top.YUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                        }
                        if (interpolationValue < 1)
                        {
                            this.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                        }
                        break;
                }
                switch(secondState)
                {
                    case  VariableState.Default:
                        setBackgroundColorBlueSecondValue = true;
                        BackgroundColorBlueSecondValue = 105;
                        setBackgroundColorGreenSecondValue = true;
                        BackgroundColorGreenSecondValue = 105;
                        setBackgroundColorHeightSecondValue = true;
                        BackgroundColorHeightSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.BackgroundColor.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        setBackgroundColorRedSecondValue = true;
                        BackgroundColorRedSecondValue = 105;
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
                        setBorderBlueSecondValue = true;
                        BorderBlueSecondValue = 0;
                        setBorderGreenSecondValue = true;
                        BorderGreenSecondValue = 0;
                        setBorderHeightSecondValue = true;
                        BorderHeightSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.Border.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        setBorderRedSecondValue = true;
                        BorderRedSecondValue = 0;
                        setBorderWidthSecondValue = true;
                        BorderWidthSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.Border.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        setBorderXSecondValue = true;
                        BorderXSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.Border.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.Border.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setBorderYSecondValue = true;
                        BorderYSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.Border.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.Border.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                        }
                        setTextInstanceBlueSecondValue = true;
                        TextInstanceBlueSecondValue = 0;
                        if (interpolationValue >= 1)
                        {
                            this.TextInstance.Font = "Arial";
                        }
                        setTextInstanceFontSizeSecondValue = true;
                        TextInstanceFontSizeSecondValue = 24;
                        setTextInstanceGreenSecondValue = true;
                        TextInstanceGreenSecondValue = 0;
                        setTextInstanceHeightSecondValue = true;
                        TextInstanceHeightSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.TextInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.TextInstance.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.TextInstance.Parent = this.GetGraphicalUiElementByName("Top") ?? this;
                        }
                        setTextInstanceRedSecondValue = true;
                        TextInstanceRedSecondValue = 0;
                        if (interpolationValue >= 1)
                        {
                            this.TextInstance.Text = "TopicName";
                        }
                        if (interpolationValue >= 1)
                        {
                            this.TextInstance.VerticalAlignment = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.TextInstance.Visible = true;
                        }
                        setTextInstanceWidthSecondValue = true;
                        TextInstanceWidthSecondValue = 95f;
                        if (interpolationValue >= 1)
                        {
                            this.TextInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setTextInstanceXSecondValue = true;
                        TextInstanceXSecondValue = 5f;
                        if (interpolationValue >= 1)
                        {
                            this.TextInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.TextInstance.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setTextInstanceYSecondValue = true;
                        TextInstanceYSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.TextInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.TextInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setTopBlueSecondValue = true;
                        TopBlueSecondValue = 0;
                        setTopGreenSecondValue = true;
                        TopGreenSecondValue = 0;
                        setTopHeightSecondValue = true;
                        TopHeightSecondValue = 20f;
                        if (interpolationValue >= 1)
                        {
                            this.Top.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                        }
                        setTopRedSecondValue = true;
                        TopRedSecondValue = 0;
                        setTopWidthSecondValue = true;
                        TopWidthSecondValue = 100f;
                        if (interpolationValue >= 1)
                        {
                            this.Top.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setTopXSecondValue = true;
                        TopXSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.Top.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.Top.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setTopYSecondValue = true;
                        TopYSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.Top.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Top;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.Top.YUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                        }
                        break;
                }
                var wasSuppressed = mIsLayoutSuspended;
                if (wasSuppressed == false)
                {
                    SuspendLayout(true);
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
                if (setBorderBlueFirstValue && setBorderBlueSecondValue)
                {
                    Border.Blue = FlatRedBall.Math.MathFunctions.RoundToInt(BorderBlueFirstValue* (1 - interpolationValue) + BorderBlueSecondValue * interpolationValue);
                }
                if (setBorderGreenFirstValue && setBorderGreenSecondValue)
                {
                    Border.Green = FlatRedBall.Math.MathFunctions.RoundToInt(BorderGreenFirstValue* (1 - interpolationValue) + BorderGreenSecondValue * interpolationValue);
                }
                if (setBorderHeightFirstValue && setBorderHeightSecondValue)
                {
                    Border.Height = BorderHeightFirstValue * (1 - interpolationValue) + BorderHeightSecondValue * interpolationValue;
                }
                if (setBorderRedFirstValue && setBorderRedSecondValue)
                {
                    Border.Red = FlatRedBall.Math.MathFunctions.RoundToInt(BorderRedFirstValue* (1 - interpolationValue) + BorderRedSecondValue * interpolationValue);
                }
                if (setBorderWidthFirstValue && setBorderWidthSecondValue)
                {
                    Border.Width = BorderWidthFirstValue * (1 - interpolationValue) + BorderWidthSecondValue * interpolationValue;
                }
                if (setBorderXFirstValue && setBorderXSecondValue)
                {
                    Border.X = BorderXFirstValue * (1 - interpolationValue) + BorderXSecondValue * interpolationValue;
                }
                if (setBorderYFirstValue && setBorderYSecondValue)
                {
                    Border.Y = BorderYFirstValue * (1 - interpolationValue) + BorderYSecondValue * interpolationValue;
                }
                if (setTextInstanceBlueFirstValue && setTextInstanceBlueSecondValue)
                {
                    TextInstance.Blue = FlatRedBall.Math.MathFunctions.RoundToInt(TextInstanceBlueFirstValue* (1 - interpolationValue) + TextInstanceBlueSecondValue * interpolationValue);
                }
                if (setTextInstanceFontSizeFirstValue && setTextInstanceFontSizeSecondValue)
                {
                    TextInstance.FontSize = FlatRedBall.Math.MathFunctions.RoundToInt(TextInstanceFontSizeFirstValue* (1 - interpolationValue) + TextInstanceFontSizeSecondValue * interpolationValue);
                }
                if (setTextInstanceGreenFirstValue && setTextInstanceGreenSecondValue)
                {
                    TextInstance.Green = FlatRedBall.Math.MathFunctions.RoundToInt(TextInstanceGreenFirstValue* (1 - interpolationValue) + TextInstanceGreenSecondValue * interpolationValue);
                }
                if (setTextInstanceHeightFirstValue && setTextInstanceHeightSecondValue)
                {
                    TextInstance.Height = TextInstanceHeightFirstValue * (1 - interpolationValue) + TextInstanceHeightSecondValue * interpolationValue;
                }
                if (setTextInstanceRedFirstValue && setTextInstanceRedSecondValue)
                {
                    TextInstance.Red = FlatRedBall.Math.MathFunctions.RoundToInt(TextInstanceRedFirstValue* (1 - interpolationValue) + TextInstanceRedSecondValue * interpolationValue);
                }
                if (setTextInstanceWidthFirstValue && setTextInstanceWidthSecondValue)
                {
                    TextInstance.Width = TextInstanceWidthFirstValue * (1 - interpolationValue) + TextInstanceWidthSecondValue * interpolationValue;
                }
                if (setTextInstanceXFirstValue && setTextInstanceXSecondValue)
                {
                    TextInstance.X = TextInstanceXFirstValue * (1 - interpolationValue) + TextInstanceXSecondValue * interpolationValue;
                }
                if (setTextInstanceYFirstValue && setTextInstanceYSecondValue)
                {
                    TextInstance.Y = TextInstanceYFirstValue * (1 - interpolationValue) + TextInstanceYSecondValue * interpolationValue;
                }
                if (setTopBlueFirstValue && setTopBlueSecondValue)
                {
                    Top.Blue = FlatRedBall.Math.MathFunctions.RoundToInt(TopBlueFirstValue* (1 - interpolationValue) + TopBlueSecondValue * interpolationValue);
                }
                if (setTopGreenFirstValue && setTopGreenSecondValue)
                {
                    Top.Green = FlatRedBall.Math.MathFunctions.RoundToInt(TopGreenFirstValue* (1 - interpolationValue) + TopGreenSecondValue * interpolationValue);
                }
                if (setTopHeightFirstValue && setTopHeightSecondValue)
                {
                    Top.Height = TopHeightFirstValue * (1 - interpolationValue) + TopHeightSecondValue * interpolationValue;
                }
                if (setTopRedFirstValue && setTopRedSecondValue)
                {
                    Top.Red = FlatRedBall.Math.MathFunctions.RoundToInt(TopRedFirstValue* (1 - interpolationValue) + TopRedSecondValue * interpolationValue);
                }
                if (setTopWidthFirstValue && setTopWidthSecondValue)
                {
                    Top.Width = TopWidthFirstValue * (1 - interpolationValue) + TopWidthSecondValue * interpolationValue;
                }
                if (setTopXFirstValue && setTopXSecondValue)
                {
                    Top.X = TopXFirstValue * (1 - interpolationValue) + TopXSecondValue * interpolationValue;
                }
                if (setTopYFirstValue && setTopYSecondValue)
                {
                    Top.Y = TopYFirstValue * (1 - interpolationValue) + TopYSecondValue * interpolationValue;
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
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (JHP4SD.GumRuntimes.LebegForms.ComplexComponents.TopicRuntime.VariableState fromState,JHP4SD.GumRuntimes.LebegForms.ComplexComponents.TopicRuntime.VariableState toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null) 
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
                            Name = "Height Units",
                            Type = "DimensionUnitType",
                            Value = HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Width Units",
                            Type = "DimensionUnitType",
                            Value = WidthUnits
                        }
                        );
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
                            Name = "Border.Blue",
                            Type = "int",
                            Value = Border.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Border.Green",
                            Type = "int",
                            Value = Border.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Border.Height",
                            Type = "float",
                            Value = Border.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Border.Height Units",
                            Type = "DimensionUnitType",
                            Value = Border.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Border.Red",
                            Type = "int",
                            Value = Border.Red
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Border.Width",
                            Type = "float",
                            Value = Border.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Border.Width Units",
                            Type = "DimensionUnitType",
                            Value = Border.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Border.X",
                            Type = "float",
                            Value = Border.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Border.X Origin",
                            Type = "HorizontalAlignment",
                            Value = Border.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Border.X Units",
                            Type = "PositionUnitType",
                            Value = Border.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Border.Y",
                            Type = "float",
                            Value = Border.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Border.Y Origin",
                            Type = "VerticalAlignment",
                            Value = Border.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Border.Y Units",
                            Type = "PositionUnitType",
                            Value = Border.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Top.Blue",
                            Type = "int",
                            Value = Top.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Top.Green",
                            Type = "int",
                            Value = Top.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Top.Height",
                            Type = "float",
                            Value = Top.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Top.Height Units",
                            Type = "DimensionUnitType",
                            Value = Top.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Top.Red",
                            Type = "int",
                            Value = Top.Red
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Top.Width",
                            Type = "float",
                            Value = Top.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Top.Width Units",
                            Type = "DimensionUnitType",
                            Value = Top.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Top.X",
                            Type = "float",
                            Value = Top.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Top.X Origin",
                            Type = "HorizontalAlignment",
                            Value = Top.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Top.X Units",
                            Type = "PositionUnitType",
                            Value = Top.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Top.Y",
                            Type = "float",
                            Value = Top.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Top.Y Origin",
                            Type = "VerticalAlignment",
                            Value = Top.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Top.Y Units",
                            Type = "PositionUnitType",
                            Value = Top.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Blue",
                            Type = "int",
                            Value = TextInstance.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Font",
                            Type = "string",
                            Value = TextInstance.Font
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.FontSize",
                            Type = "int",
                            Value = TextInstance.FontSize
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Green",
                            Type = "int",
                            Value = TextInstance.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Height",
                            Type = "float",
                            Value = TextInstance.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Height Units",
                            Type = "DimensionUnitType",
                            Value = TextInstance.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.HorizontalAlignment",
                            Type = "HorizontalAlignment",
                            Value = TextInstance.HorizontalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Parent",
                            Type = "string",
                            Value = TextInstance.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Red",
                            Type = "int",
                            Value = TextInstance.Red
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Text",
                            Type = "string",
                            Value = TextInstance.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.VerticalAlignment",
                            Type = "VerticalAlignment",
                            Value = TextInstance.VerticalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Visible",
                            Type = "bool",
                            Value = TextInstance.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Width",
                            Type = "float",
                            Value = TextInstance.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Width Units",
                            Type = "DimensionUnitType",
                            Value = TextInstance.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.X",
                            Type = "float",
                            Value = TextInstance.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.X Origin",
                            Type = "HorizontalAlignment",
                            Value = TextInstance.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.X Units",
                            Type = "PositionUnitType",
                            Value = TextInstance.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Y",
                            Type = "float",
                            Value = TextInstance.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Y Origin",
                            Type = "VerticalAlignment",
                            Value = TextInstance.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Y Units",
                            Type = "PositionUnitType",
                            Value = TextInstance.YUnits
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
                            Name = "Height Units",
                            Type = "DimensionUnitType",
                            Value = HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Width Units",
                            Type = "DimensionUnitType",
                            Value = WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackgroundColor.Blue",
                            Type = "int",
                            Value = BackgroundColor.Blue + 105
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackgroundColor.Green",
                            Type = "int",
                            Value = BackgroundColor.Green + 105
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
                            Value = BackgroundColor.Red + 105
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
                            Name = "Border.Blue",
                            Type = "int",
                            Value = Border.Blue + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Border.Green",
                            Type = "int",
                            Value = Border.Green + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Border.Height",
                            Type = "float",
                            Value = Border.Height + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Border.Height Units",
                            Type = "DimensionUnitType",
                            Value = Border.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Border.Red",
                            Type = "int",
                            Value = Border.Red + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Border.Width",
                            Type = "float",
                            Value = Border.Width + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Border.Width Units",
                            Type = "DimensionUnitType",
                            Value = Border.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Border.X",
                            Type = "float",
                            Value = Border.X + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Border.X Origin",
                            Type = "HorizontalAlignment",
                            Value = Border.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Border.X Units",
                            Type = "PositionUnitType",
                            Value = Border.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Border.Y",
                            Type = "float",
                            Value = Border.Y + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Border.Y Origin",
                            Type = "VerticalAlignment",
                            Value = Border.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Border.Y Units",
                            Type = "PositionUnitType",
                            Value = Border.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Top.Blue",
                            Type = "int",
                            Value = Top.Blue + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Top.Green",
                            Type = "int",
                            Value = Top.Green + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Top.Height",
                            Type = "float",
                            Value = Top.Height + 20f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Top.Height Units",
                            Type = "DimensionUnitType",
                            Value = Top.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Top.Red",
                            Type = "int",
                            Value = Top.Red + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Top.Width",
                            Type = "float",
                            Value = Top.Width + 100f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Top.Width Units",
                            Type = "DimensionUnitType",
                            Value = Top.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Top.X",
                            Type = "float",
                            Value = Top.X + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Top.X Origin",
                            Type = "HorizontalAlignment",
                            Value = Top.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Top.X Units",
                            Type = "PositionUnitType",
                            Value = Top.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Top.Y",
                            Type = "float",
                            Value = Top.Y + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Top.Y Origin",
                            Type = "VerticalAlignment",
                            Value = Top.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Top.Y Units",
                            Type = "PositionUnitType",
                            Value = Top.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Blue",
                            Type = "int",
                            Value = TextInstance.Blue + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Font",
                            Type = "string",
                            Value = TextInstance.Font
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.FontSize",
                            Type = "int",
                            Value = TextInstance.FontSize + 24
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Green",
                            Type = "int",
                            Value = TextInstance.Green + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Height",
                            Type = "float",
                            Value = TextInstance.Height + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Height Units",
                            Type = "DimensionUnitType",
                            Value = TextInstance.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.HorizontalAlignment",
                            Type = "HorizontalAlignment",
                            Value = TextInstance.HorizontalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Parent",
                            Type = "string",
                            Value = TextInstance.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Red",
                            Type = "int",
                            Value = TextInstance.Red + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Text",
                            Type = "string",
                            Value = TextInstance.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.VerticalAlignment",
                            Type = "VerticalAlignment",
                            Value = TextInstance.VerticalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Visible",
                            Type = "bool",
                            Value = TextInstance.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Width",
                            Type = "float",
                            Value = TextInstance.Width + 95f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Width Units",
                            Type = "DimensionUnitType",
                            Value = TextInstance.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.X",
                            Type = "float",
                            Value = TextInstance.X + 5f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.X Origin",
                            Type = "HorizontalAlignment",
                            Value = TextInstance.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.X Units",
                            Type = "PositionUnitType",
                            Value = TextInstance.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Y",
                            Type = "float",
                            Value = TextInstance.Y + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Y Origin",
                            Type = "VerticalAlignment",
                            Value = TextInstance.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Y Units",
                            Type = "PositionUnitType",
                            Value = TextInstance.YUnits
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
            public JHP4SD.GumRuntimes.ColoredRectangleRuntime BackgroundColor { get; set; }
            public JHP4SD.GumRuntimes.RectangleRuntime Border { get; set; }
            public JHP4SD.GumRuntimes.RectangleRuntime Top { get; set; }
            public JHP4SD.GumRuntimes.TextRuntime TextInstance { get; set; }
            public int Alpha
            {
                get
                {
                    return BackgroundColor.Alpha;
                }
                set
                {
                    if (BackgroundColor.Alpha != value)
                    {
                        BackgroundColor.Alpha = value;
                        AlphaChanged?.Invoke(this, null);
                    }
                }
            }
            public Gum.RenderingLibrary.Blend Blend
            {
                get
                {
                    return BackgroundColor.Blend;
                }
                set
                {
                    if (BackgroundColor.Blend != value)
                    {
                        BackgroundColor.Blend = value;
                        BlendChanged?.Invoke(this, null);
                    }
                }
            }
            public int Blue
            {
                get
                {
                    return BackgroundColor.Blue;
                }
                set
                {
                    if (BackgroundColor.Blue != value)
                    {
                        BackgroundColor.Blue = value;
                        BlueChanged?.Invoke(this, null);
                    }
                }
            }
            public int Green
            {
                get
                {
                    return BackgroundColor.Green;
                }
                set
                {
                    if (BackgroundColor.Green != value)
                    {
                        BackgroundColor.Green = value;
                        GreenChanged?.Invoke(this, null);
                    }
                }
            }
            public int Red
            {
                get
                {
                    return BackgroundColor.Red;
                }
                set
                {
                    if (BackgroundColor.Red != value)
                    {
                        BackgroundColor.Red = value;
                        RedChanged?.Invoke(this, null);
                    }
                }
            }
            public int TopicFontSize
            {
                get
                {
                    return TextInstance.FontSize;
                }
                set
                {
                    if (TextInstance.FontSize != value)
                    {
                        TextInstance.FontSize = value;
                        TopicFontSizeChanged?.Invoke(this, null);
                    }
                }
            }
            public string TopicName
            {
                get
                {
                    return TextInstance.Text;
                }
                set
                {
                    if (TextInstance.Text != value)
                    {
                        TextInstance.Text = value;
                        TopicNameChanged?.Invoke(this, null);
                    }
                }
            }
            public event System.EventHandler AlphaChanged;
            public event System.EventHandler BlendChanged;
            public event System.EventHandler BlueChanged;
            public event System.EventHandler GreenChanged;
            public event System.EventHandler RedChanged;
            public event System.EventHandler TopicFontSizeChanged;
            public event System.EventHandler TopicNameChanged;
            public TopicRuntime (bool fullInstantiation = true, bool tryCreateFormsObject = true) 
            	: base(false, tryCreateFormsObject)
            {
                if (fullInstantiation)
                {
                    Gum.DataTypes.ElementSave elementSave = Gum.Managers.ObjectFinder.Self.GumProjectSave.Components.First(item => item.Name == "LebegForms/ComplexComponents/Topic");
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
                Border = this.GetGraphicalUiElementByName("Border") as JHP4SD.GumRuntimes.RectangleRuntime;
                Top = this.GetGraphicalUiElementByName("Top") as JHP4SD.GumRuntimes.RectangleRuntime;
                TextInstance = this.GetGraphicalUiElementByName("TextInstance") as JHP4SD.GumRuntimes.TextRuntime;
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
        }
    }
