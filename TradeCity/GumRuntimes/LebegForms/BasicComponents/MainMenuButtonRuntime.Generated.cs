    using System.Linq;
    namespace JHP4SD.GumRuntimes.LebegForms.BasicComponents
    {
        public partial class MainMenuButtonRuntime : JHP4SD.GumRuntimes.ContainerRuntime
        {
            #region State Enums
            public enum VariableState
            {
                Default
            }
            public enum ButtonCategory
            {
                Enabled,
                Disabled,
                Highlighted,
                Pushed,
                HighlightedFocused,
                Focused
            }
            #endregion
            #region State Fields
            VariableState mCurrentVariableState;
            ButtonCategory? mCurrentButtonCategoryState;
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
                            TextInstance.Parent = this.GetGraphicalUiElementByName("SpriteInstance") ?? this;
                            PaceholderText.Parent = this.GetGraphicalUiElementByName("SpriteInstance") ?? this;
                            HighlightRectangle.Parent = this.GetGraphicalUiElementByName("SpriteInstance") ?? this;
                            Width = 400f;
                            SetProperty("SpriteInstance.SourceFile", "Components/LebegForms/Resources/PlaceholderGradient.png");
                            TextInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                            TextInstance.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                            TextInstance.Text = "MainButtonText";
                            TextInstance.VerticalAlignment = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            TextInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                            TextInstance.X = 25f;
                            TextInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                            TextInstance.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                            TextInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            TextInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            PaceholderText.Alpha = 150;
                            PaceholderText.Blue = 0;
                            PaceholderText.FontSize = 32;
                            PaceholderText.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            PaceholderText.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                            PaceholderText.IsItalic = false;
                            PaceholderText.Rotation = -20f;
                            PaceholderText.Text = "PLACEHOLDER";
                            PaceholderText.VerticalAlignment = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            PaceholderText.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            PaceholderText.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                            PaceholderText.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            PaceholderText.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            PaceholderText.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            HighlightRectangle.Blue = 0;
                            HighlightRectangle.Green = 255;
                            HighlightRectangle.Height = 0f;
                            HighlightRectangle.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                            HighlightRectangle.Red = 255;
                            HighlightRectangle.Width = 0f;
                            HighlightRectangle.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                            HighlightRectangle.X = 0f;
                            HighlightRectangle.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                            HighlightRectangle.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            HighlightRectangle.Y = 0f;
                            HighlightRectangle.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            HighlightRectangle.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            break;
                    }
                }
            }
            public ButtonCategory? CurrentButtonCategoryState
            {
                get
                {
                    return mCurrentButtonCategoryState;
                }
                set
                {
                    if (value != null)
                    {
                        mCurrentButtonCategoryState = value;
                        switch(mCurrentButtonCategoryState)
                        {
                            case  ButtonCategory.Enabled:
                                TextInstance.Parent = this.GetGraphicalUiElementByName("SpriteInstance") ?? this;
                                PaceholderText.Parent = this.GetGraphicalUiElementByName("SpriteInstance") ?? this;
                                SpriteInstance.Alpha = 255;
                                SpriteInstance.Animate = false;
                                SpriteInstance.Blue = 255;
                                SpriteInstance.Green = 255;
                                SpriteInstance.Red = 255;
                                SpriteInstance.X = 0f;
                                SpriteInstance.Y = 0f;
                                TextInstance.Blue = 255;
                                TextInstance.Green = 255;
                                TextInstance.Red = 255;
                                HighlightRectangle.Blue = 0;
                                HighlightRectangle.Green = 255;
                                HighlightRectangle.Red = 255;
                                HighlightRectangle.Visible = false;
                                break;
                            case  ButtonCategory.Disabled:
                                TextInstance.Parent = this.GetGraphicalUiElementByName("SpriteInstance") ?? this;
                                PaceholderText.Parent = this.GetGraphicalUiElementByName("SpriteInstance") ?? this;
                                SpriteInstance.Alpha = 150;
                                SpriteInstance.Animate = false;
                                SpriteInstance.Blue = 128;
                                SpriteInstance.Green = 128;
                                SpriteInstance.Red = 128;
                                SpriteInstance.X = 0f;
                                SpriteInstance.Y = 0f;
                                TextInstance.Blue = 255;
                                TextInstance.Green = 255;
                                TextInstance.Red = 255;
                                HighlightRectangle.Blue = 0;
                                HighlightRectangle.Green = 255;
                                HighlightRectangle.Red = 255;
                                HighlightRectangle.Visible = false;
                                break;
                            case  ButtonCategory.Highlighted:
                                TextInstance.Parent = this.GetGraphicalUiElementByName("SpriteInstance") ?? this;
                                PaceholderText.Parent = this.GetGraphicalUiElementByName("SpriteInstance") ?? this;
                                SpriteInstance.Alpha = 255;
                                SpriteInstance.Animate = false;
                                SpriteInstance.Blue = 0;
                                SpriteInstance.Green = 255;
                                SpriteInstance.Red = 255;
                                SpriteInstance.X = 20f;
                                SpriteInstance.Y = 0f;
                                TextInstance.Blue = 0;
                                TextInstance.Green = 0;
                                TextInstance.Red = 0;
                                HighlightRectangle.Blue = 255;
                                HighlightRectangle.Green = 255;
                                HighlightRectangle.Red = 255;
                                HighlightRectangle.Visible = true;
                                break;
                            case  ButtonCategory.Pushed:
                                TextInstance.Parent = this.GetGraphicalUiElementByName("SpriteInstance") ?? this;
                                PaceholderText.Parent = this.GetGraphicalUiElementByName("SpriteInstance") ?? this;
                                SpriteInstance.Alpha = 255;
                                SpriteInstance.Animate = false;
                                SpriteInstance.Blue = 128;
                                SpriteInstance.Green = 128;
                                SpriteInstance.Red = 128;
                                SpriteInstance.X = 25f;
                                SpriteInstance.Y = 5f;
                                TextInstance.Blue = 0;
                                TextInstance.Green = 0;
                                TextInstance.Red = 0;
                                HighlightRectangle.Blue = 0;
                                HighlightRectangle.Green = 255;
                                HighlightRectangle.Red = 255;
                                HighlightRectangle.Visible = false;
                                break;
                            case  ButtonCategory.HighlightedFocused:
                                TextInstance.Parent = this.GetGraphicalUiElementByName("SpriteInstance") ?? this;
                                PaceholderText.Parent = this.GetGraphicalUiElementByName("SpriteInstance") ?? this;
                                SpriteInstance.Alpha = 255;
                                SpriteInstance.Animate = false;
                                SpriteInstance.Blue = 0;
                                SpriteInstance.Green = 255;
                                SpriteInstance.Red = 255;
                                SpriteInstance.X = 20f;
                                SpriteInstance.Y = 0f;
                                TextInstance.Blue = 0;
                                TextInstance.Green = 0;
                                TextInstance.Red = 0;
                                HighlightRectangle.Blue = 0;
                                HighlightRectangle.Green = 255;
                                HighlightRectangle.Red = 255;
                                HighlightRectangle.Visible = true;
                                break;
                            case  ButtonCategory.Focused:
                                TextInstance.Parent = this.GetGraphicalUiElementByName("SpriteInstance") ?? this;
                                PaceholderText.Parent = this.GetGraphicalUiElementByName("SpriteInstance") ?? this;
                                SpriteInstance.Alpha = 255;
                                SpriteInstance.Animate = false;
                                SpriteInstance.Blue = 255;
                                SpriteInstance.Green = 255;
                                SpriteInstance.Red = 255;
                                SpriteInstance.X = 0f;
                                SpriteInstance.Y = 0f;
                                TextInstance.Blue = 0;
                                TextInstance.Green = 0;
                                TextInstance.Red = 0;
                                HighlightRectangle.Blue = 0;
                                HighlightRectangle.Green = 255;
                                HighlightRectangle.Red = 255;
                                HighlightRectangle.Visible = true;
                                break;
                        }
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
                bool setHighlightRectangleBlueFirstValue = false;
                bool setHighlightRectangleBlueSecondValue = false;
                int HighlightRectangleBlueFirstValue= 0;
                int HighlightRectangleBlueSecondValue= 0;
                bool setHighlightRectangleGreenFirstValue = false;
                bool setHighlightRectangleGreenSecondValue = false;
                int HighlightRectangleGreenFirstValue= 0;
                int HighlightRectangleGreenSecondValue= 0;
                bool setHighlightRectangleHeightFirstValue = false;
                bool setHighlightRectangleHeightSecondValue = false;
                float HighlightRectangleHeightFirstValue= 0;
                float HighlightRectangleHeightSecondValue= 0;
                bool setHighlightRectangleRedFirstValue = false;
                bool setHighlightRectangleRedSecondValue = false;
                int HighlightRectangleRedFirstValue= 0;
                int HighlightRectangleRedSecondValue= 0;
                bool setHighlightRectangleWidthFirstValue = false;
                bool setHighlightRectangleWidthSecondValue = false;
                float HighlightRectangleWidthFirstValue= 0;
                float HighlightRectangleWidthSecondValue= 0;
                bool setHighlightRectangleXFirstValue = false;
                bool setHighlightRectangleXSecondValue = false;
                float HighlightRectangleXFirstValue= 0;
                float HighlightRectangleXSecondValue= 0;
                bool setHighlightRectangleYFirstValue = false;
                bool setHighlightRectangleYSecondValue = false;
                float HighlightRectangleYFirstValue= 0;
                float HighlightRectangleYSecondValue= 0;
                bool setPaceholderTextAlphaFirstValue = false;
                bool setPaceholderTextAlphaSecondValue = false;
                int PaceholderTextAlphaFirstValue= 0;
                int PaceholderTextAlphaSecondValue= 0;
                bool setPaceholderTextBlueFirstValue = false;
                bool setPaceholderTextBlueSecondValue = false;
                int PaceholderTextBlueFirstValue= 0;
                int PaceholderTextBlueSecondValue= 0;
                bool setPaceholderTextFontSizeFirstValue = false;
                bool setPaceholderTextFontSizeSecondValue = false;
                int PaceholderTextFontSizeFirstValue= 0;
                int PaceholderTextFontSizeSecondValue= 0;
                bool setPaceholderTextRotationFirstValue = false;
                bool setPaceholderTextRotationSecondValue = false;
                float PaceholderTextRotationFirstValue= 0;
                float PaceholderTextRotationSecondValue= 0;
                bool setTextInstanceXFirstValue = false;
                bool setTextInstanceXSecondValue = false;
                float TextInstanceXFirstValue= 0;
                float TextInstanceXSecondValue= 0;
                bool setWidthFirstValue = false;
                bool setWidthSecondValue = false;
                float WidthFirstValue= 0;
                float WidthSecondValue= 0;
                switch(firstState)
                {
                    case  VariableState.Default:
                        setHighlightRectangleBlueFirstValue = true;
                        HighlightRectangleBlueFirstValue = 0;
                        setHighlightRectangleGreenFirstValue = true;
                        HighlightRectangleGreenFirstValue = 255;
                        setHighlightRectangleHeightFirstValue = true;
                        HighlightRectangleHeightFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.HighlightRectangle.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        if (interpolationValue < 1)
                        {
                            this.HighlightRectangle.Parent = this.GetGraphicalUiElementByName("SpriteInstance") ?? this;
                        }
                        setHighlightRectangleRedFirstValue = true;
                        HighlightRectangleRedFirstValue = 255;
                        setHighlightRectangleWidthFirstValue = true;
                        HighlightRectangleWidthFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.HighlightRectangle.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        setHighlightRectangleXFirstValue = true;
                        HighlightRectangleXFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.HighlightRectangle.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.HighlightRectangle.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setHighlightRectangleYFirstValue = true;
                        HighlightRectangleYFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.HighlightRectangle.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.HighlightRectangle.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setPaceholderTextAlphaFirstValue = true;
                        PaceholderTextAlphaFirstValue = 150;
                        setPaceholderTextBlueFirstValue = true;
                        PaceholderTextBlueFirstValue = 0;
                        setPaceholderTextFontSizeFirstValue = true;
                        PaceholderTextFontSizeFirstValue = 32;
                        if (interpolationValue < 1)
                        {
                            this.PaceholderText.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.PaceholderText.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.PaceholderText.IsItalic = false;
                        }
                        if (interpolationValue < 1)
                        {
                            this.PaceholderText.Parent = this.GetGraphicalUiElementByName("SpriteInstance") ?? this;
                        }
                        setPaceholderTextRotationFirstValue = true;
                        PaceholderTextRotationFirstValue = -20f;
                        if (interpolationValue < 1)
                        {
                            this.PaceholderText.Text = "PLACEHOLDER";
                        }
                        if (interpolationValue < 1)
                        {
                            this.PaceholderText.VerticalAlignment = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.PaceholderText.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.PaceholderText.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.PaceholderText.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        if (interpolationValue < 1)
                        {
                            this.PaceholderText.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.PaceholderText.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        if (interpolationValue < 1)
                        {
                            SetProperty("SpriteInstance.SourceFile", "Components/LebegForms/Resources/PlaceholderGradient.png");
                        }
                        if (interpolationValue < 1)
                        {
                            this.TextInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                        }
                        if (interpolationValue < 1)
                        {
                            this.TextInstance.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                        }
                        if (interpolationValue < 1)
                        {
                            this.TextInstance.Parent = this.GetGraphicalUiElementByName("SpriteInstance") ?? this;
                        }
                        if (interpolationValue < 1)
                        {
                            this.TextInstance.Text = "MainButtonText";
                        }
                        if (interpolationValue < 1)
                        {
                            this.TextInstance.VerticalAlignment = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.TextInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                        }
                        setTextInstanceXFirstValue = true;
                        TextInstanceXFirstValue = 25f;
                        if (interpolationValue < 1)
                        {
                            this.TextInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                        }
                        if (interpolationValue < 1)
                        {
                            this.TextInstance.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.TextInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.TextInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setWidthFirstValue = true;
                        WidthFirstValue = 400f;
                        break;
                }
                switch(secondState)
                {
                    case  VariableState.Default:
                        setHighlightRectangleBlueSecondValue = true;
                        HighlightRectangleBlueSecondValue = 0;
                        setHighlightRectangleGreenSecondValue = true;
                        HighlightRectangleGreenSecondValue = 255;
                        setHighlightRectangleHeightSecondValue = true;
                        HighlightRectangleHeightSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.HighlightRectangle.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.HighlightRectangle.Parent = this.GetGraphicalUiElementByName("SpriteInstance") ?? this;
                        }
                        setHighlightRectangleRedSecondValue = true;
                        HighlightRectangleRedSecondValue = 255;
                        setHighlightRectangleWidthSecondValue = true;
                        HighlightRectangleWidthSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.HighlightRectangle.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        setHighlightRectangleXSecondValue = true;
                        HighlightRectangleXSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.HighlightRectangle.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.HighlightRectangle.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setHighlightRectangleYSecondValue = true;
                        HighlightRectangleYSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.HighlightRectangle.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.HighlightRectangle.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setPaceholderTextAlphaSecondValue = true;
                        PaceholderTextAlphaSecondValue = 150;
                        setPaceholderTextBlueSecondValue = true;
                        PaceholderTextBlueSecondValue = 0;
                        setPaceholderTextFontSizeSecondValue = true;
                        PaceholderTextFontSizeSecondValue = 32;
                        if (interpolationValue >= 1)
                        {
                            this.PaceholderText.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.PaceholderText.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.PaceholderText.IsItalic = false;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.PaceholderText.Parent = this.GetGraphicalUiElementByName("SpriteInstance") ?? this;
                        }
                        setPaceholderTextRotationSecondValue = true;
                        PaceholderTextRotationSecondValue = -20f;
                        if (interpolationValue >= 1)
                        {
                            this.PaceholderText.Text = "PLACEHOLDER";
                        }
                        if (interpolationValue >= 1)
                        {
                            this.PaceholderText.VerticalAlignment = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.PaceholderText.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.PaceholderText.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.PaceholderText.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.PaceholderText.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.PaceholderText.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        if (interpolationValue >= 1)
                        {
                            SetProperty("SpriteInstance.SourceFile", "Components/LebegForms/Resources/PlaceholderGradient.png");
                        }
                        if (interpolationValue >= 1)
                        {
                            this.TextInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.TextInstance.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.TextInstance.Parent = this.GetGraphicalUiElementByName("SpriteInstance") ?? this;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.TextInstance.Text = "MainButtonText";
                        }
                        if (interpolationValue >= 1)
                        {
                            this.TextInstance.VerticalAlignment = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.TextInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                        }
                        setTextInstanceXSecondValue = true;
                        TextInstanceXSecondValue = 25f;
                        if (interpolationValue >= 1)
                        {
                            this.TextInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.TextInstance.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.TextInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.TextInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setWidthSecondValue = true;
                        WidthSecondValue = 400f;
                        break;
                }
                var wasSuppressed = mIsLayoutSuspended;
                if (wasSuppressed == false)
                {
                    SuspendLayout(true);
                }
                if (setHighlightRectangleBlueFirstValue && setHighlightRectangleBlueSecondValue)
                {
                    HighlightRectangle.Blue = FlatRedBall.Math.MathFunctions.RoundToInt(HighlightRectangleBlueFirstValue* (1 - interpolationValue) + HighlightRectangleBlueSecondValue * interpolationValue);
                }
                if (setHighlightRectangleGreenFirstValue && setHighlightRectangleGreenSecondValue)
                {
                    HighlightRectangle.Green = FlatRedBall.Math.MathFunctions.RoundToInt(HighlightRectangleGreenFirstValue* (1 - interpolationValue) + HighlightRectangleGreenSecondValue * interpolationValue);
                }
                if (setHighlightRectangleHeightFirstValue && setHighlightRectangleHeightSecondValue)
                {
                    HighlightRectangle.Height = HighlightRectangleHeightFirstValue * (1 - interpolationValue) + HighlightRectangleHeightSecondValue * interpolationValue;
                }
                if (setHighlightRectangleRedFirstValue && setHighlightRectangleRedSecondValue)
                {
                    HighlightRectangle.Red = FlatRedBall.Math.MathFunctions.RoundToInt(HighlightRectangleRedFirstValue* (1 - interpolationValue) + HighlightRectangleRedSecondValue * interpolationValue);
                }
                if (setHighlightRectangleWidthFirstValue && setHighlightRectangleWidthSecondValue)
                {
                    HighlightRectangle.Width = HighlightRectangleWidthFirstValue * (1 - interpolationValue) + HighlightRectangleWidthSecondValue * interpolationValue;
                }
                if (setHighlightRectangleXFirstValue && setHighlightRectangleXSecondValue)
                {
                    HighlightRectangle.X = HighlightRectangleXFirstValue * (1 - interpolationValue) + HighlightRectangleXSecondValue * interpolationValue;
                }
                if (setHighlightRectangleYFirstValue && setHighlightRectangleYSecondValue)
                {
                    HighlightRectangle.Y = HighlightRectangleYFirstValue * (1 - interpolationValue) + HighlightRectangleYSecondValue * interpolationValue;
                }
                if (setPaceholderTextAlphaFirstValue && setPaceholderTextAlphaSecondValue)
                {
                    PaceholderText.Alpha = FlatRedBall.Math.MathFunctions.RoundToInt(PaceholderTextAlphaFirstValue* (1 - interpolationValue) + PaceholderTextAlphaSecondValue * interpolationValue);
                }
                if (setPaceholderTextBlueFirstValue && setPaceholderTextBlueSecondValue)
                {
                    PaceholderText.Blue = FlatRedBall.Math.MathFunctions.RoundToInt(PaceholderTextBlueFirstValue* (1 - interpolationValue) + PaceholderTextBlueSecondValue * interpolationValue);
                }
                if (setPaceholderTextFontSizeFirstValue && setPaceholderTextFontSizeSecondValue)
                {
                    PaceholderText.FontSize = FlatRedBall.Math.MathFunctions.RoundToInt(PaceholderTextFontSizeFirstValue* (1 - interpolationValue) + PaceholderTextFontSizeSecondValue * interpolationValue);
                }
                if (setPaceholderTextRotationFirstValue && setPaceholderTextRotationSecondValue)
                {
                    PaceholderText.Rotation = PaceholderTextRotationFirstValue * (1 - interpolationValue) + PaceholderTextRotationSecondValue * interpolationValue;
                }
                if (setTextInstanceXFirstValue && setTextInstanceXSecondValue)
                {
                    TextInstance.X = TextInstanceXFirstValue * (1 - interpolationValue) + TextInstanceXSecondValue * interpolationValue;
                }
                if (setWidthFirstValue && setWidthSecondValue)
                {
                    Width = WidthFirstValue * (1 - interpolationValue) + WidthSecondValue * interpolationValue;
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
            public void InterpolateBetween (ButtonCategory firstState, ButtonCategory secondState, float interpolationValue) 
            {
                #if DEBUG
                if (float.IsNaN(interpolationValue))
                {
                    throw new System.Exception("interpolationValue cannot be NaN");
                }
                #endif
                bool setHighlightRectangleBlueFirstValue = false;
                bool setHighlightRectangleBlueSecondValue = false;
                int HighlightRectangleBlueFirstValue= 0;
                int HighlightRectangleBlueSecondValue= 0;
                bool setHighlightRectangleGreenFirstValue = false;
                bool setHighlightRectangleGreenSecondValue = false;
                int HighlightRectangleGreenFirstValue= 0;
                int HighlightRectangleGreenSecondValue= 0;
                bool setHighlightRectangleRedFirstValue = false;
                bool setHighlightRectangleRedSecondValue = false;
                int HighlightRectangleRedFirstValue= 0;
                int HighlightRectangleRedSecondValue= 0;
                bool setSpriteInstanceAlphaFirstValue = false;
                bool setSpriteInstanceAlphaSecondValue = false;
                int SpriteInstanceAlphaFirstValue= 0;
                int SpriteInstanceAlphaSecondValue= 0;
                bool setSpriteInstanceBlueFirstValue = false;
                bool setSpriteInstanceBlueSecondValue = false;
                int SpriteInstanceBlueFirstValue= 0;
                int SpriteInstanceBlueSecondValue= 0;
                bool setSpriteInstanceGreenFirstValue = false;
                bool setSpriteInstanceGreenSecondValue = false;
                int SpriteInstanceGreenFirstValue= 0;
                int SpriteInstanceGreenSecondValue= 0;
                bool setSpriteInstanceRedFirstValue = false;
                bool setSpriteInstanceRedSecondValue = false;
                int SpriteInstanceRedFirstValue= 0;
                int SpriteInstanceRedSecondValue= 0;
                bool setSpriteInstanceXFirstValue = false;
                bool setSpriteInstanceXSecondValue = false;
                float SpriteInstanceXFirstValue= 0;
                float SpriteInstanceXSecondValue= 0;
                bool setSpriteInstanceYFirstValue = false;
                bool setSpriteInstanceYSecondValue = false;
                float SpriteInstanceYFirstValue= 0;
                float SpriteInstanceYSecondValue= 0;
                bool setTextInstanceBlueFirstValue = false;
                bool setTextInstanceBlueSecondValue = false;
                int TextInstanceBlueFirstValue= 0;
                int TextInstanceBlueSecondValue= 0;
                bool setTextInstanceGreenFirstValue = false;
                bool setTextInstanceGreenSecondValue = false;
                int TextInstanceGreenFirstValue= 0;
                int TextInstanceGreenSecondValue= 0;
                bool setTextInstanceRedFirstValue = false;
                bool setTextInstanceRedSecondValue = false;
                int TextInstanceRedFirstValue= 0;
                int TextInstanceRedSecondValue= 0;
                switch(firstState)
                {
                    case  ButtonCategory.Enabled:
                        setHighlightRectangleBlueFirstValue = true;
                        HighlightRectangleBlueFirstValue = 0;
                        setHighlightRectangleGreenFirstValue = true;
                        HighlightRectangleGreenFirstValue = 255;
                        setHighlightRectangleRedFirstValue = true;
                        HighlightRectangleRedFirstValue = 255;
                        if (interpolationValue < 1)
                        {
                            this.HighlightRectangle.Visible = false;
                        }
                        if (interpolationValue < 1)
                        {
                            this.PaceholderText.Parent = this.GetGraphicalUiElementByName("SpriteInstance") ?? this;
                        }
                        setSpriteInstanceAlphaFirstValue = true;
                        SpriteInstanceAlphaFirstValue = 255;
                        if (interpolationValue < 1)
                        {
                            this.SpriteInstance.Animate = false;
                        }
                        setSpriteInstanceBlueFirstValue = true;
                        SpriteInstanceBlueFirstValue = 255;
                        setSpriteInstanceGreenFirstValue = true;
                        SpriteInstanceGreenFirstValue = 255;
                        setSpriteInstanceRedFirstValue = true;
                        SpriteInstanceRedFirstValue = 255;
                        setSpriteInstanceXFirstValue = true;
                        SpriteInstanceXFirstValue = 0f;
                        setSpriteInstanceYFirstValue = true;
                        SpriteInstanceYFirstValue = 0f;
                        setTextInstanceBlueFirstValue = true;
                        TextInstanceBlueFirstValue = 255;
                        setTextInstanceGreenFirstValue = true;
                        TextInstanceGreenFirstValue = 255;
                        if (interpolationValue < 1)
                        {
                            this.TextInstance.Parent = this.GetGraphicalUiElementByName("SpriteInstance") ?? this;
                        }
                        setTextInstanceRedFirstValue = true;
                        TextInstanceRedFirstValue = 255;
                        break;
                    case  ButtonCategory.Disabled:
                        setHighlightRectangleBlueFirstValue = true;
                        HighlightRectangleBlueFirstValue = 0;
                        setHighlightRectangleGreenFirstValue = true;
                        HighlightRectangleGreenFirstValue = 255;
                        setHighlightRectangleRedFirstValue = true;
                        HighlightRectangleRedFirstValue = 255;
                        if (interpolationValue < 1)
                        {
                            this.HighlightRectangle.Visible = false;
                        }
                        if (interpolationValue < 1)
                        {
                            this.PaceholderText.Parent = this.GetGraphicalUiElementByName("SpriteInstance") ?? this;
                        }
                        setSpriteInstanceAlphaFirstValue = true;
                        SpriteInstanceAlphaFirstValue = 150;
                        if (interpolationValue < 1)
                        {
                            this.SpriteInstance.Animate = false;
                        }
                        setSpriteInstanceBlueFirstValue = true;
                        SpriteInstanceBlueFirstValue = 128;
                        setSpriteInstanceGreenFirstValue = true;
                        SpriteInstanceGreenFirstValue = 128;
                        setSpriteInstanceRedFirstValue = true;
                        SpriteInstanceRedFirstValue = 128;
                        setSpriteInstanceXFirstValue = true;
                        SpriteInstanceXFirstValue = 0f;
                        setSpriteInstanceYFirstValue = true;
                        SpriteInstanceYFirstValue = 0f;
                        setTextInstanceBlueFirstValue = true;
                        TextInstanceBlueFirstValue = 255;
                        setTextInstanceGreenFirstValue = true;
                        TextInstanceGreenFirstValue = 255;
                        if (interpolationValue < 1)
                        {
                            this.TextInstance.Parent = this.GetGraphicalUiElementByName("SpriteInstance") ?? this;
                        }
                        setTextInstanceRedFirstValue = true;
                        TextInstanceRedFirstValue = 255;
                        break;
                    case  ButtonCategory.Highlighted:
                        setHighlightRectangleBlueFirstValue = true;
                        HighlightRectangleBlueFirstValue = 255;
                        setHighlightRectangleGreenFirstValue = true;
                        HighlightRectangleGreenFirstValue = 255;
                        setHighlightRectangleRedFirstValue = true;
                        HighlightRectangleRedFirstValue = 255;
                        if (interpolationValue < 1)
                        {
                            this.HighlightRectangle.Visible = true;
                        }
                        if (interpolationValue < 1)
                        {
                            this.PaceholderText.Parent = this.GetGraphicalUiElementByName("SpriteInstance") ?? this;
                        }
                        setSpriteInstanceAlphaFirstValue = true;
                        SpriteInstanceAlphaFirstValue = 255;
                        if (interpolationValue < 1)
                        {
                            this.SpriteInstance.Animate = false;
                        }
                        setSpriteInstanceBlueFirstValue = true;
                        SpriteInstanceBlueFirstValue = 0;
                        setSpriteInstanceGreenFirstValue = true;
                        SpriteInstanceGreenFirstValue = 255;
                        setSpriteInstanceRedFirstValue = true;
                        SpriteInstanceRedFirstValue = 255;
                        setSpriteInstanceXFirstValue = true;
                        SpriteInstanceXFirstValue = 20f;
                        setSpriteInstanceYFirstValue = true;
                        SpriteInstanceYFirstValue = 0f;
                        setTextInstanceBlueFirstValue = true;
                        TextInstanceBlueFirstValue = 0;
                        setTextInstanceGreenFirstValue = true;
                        TextInstanceGreenFirstValue = 0;
                        if (interpolationValue < 1)
                        {
                            this.TextInstance.Parent = this.GetGraphicalUiElementByName("SpriteInstance") ?? this;
                        }
                        setTextInstanceRedFirstValue = true;
                        TextInstanceRedFirstValue = 0;
                        break;
                    case  ButtonCategory.Pushed:
                        setHighlightRectangleBlueFirstValue = true;
                        HighlightRectangleBlueFirstValue = 0;
                        setHighlightRectangleGreenFirstValue = true;
                        HighlightRectangleGreenFirstValue = 255;
                        setHighlightRectangleRedFirstValue = true;
                        HighlightRectangleRedFirstValue = 255;
                        if (interpolationValue < 1)
                        {
                            this.HighlightRectangle.Visible = false;
                        }
                        if (interpolationValue < 1)
                        {
                            this.PaceholderText.Parent = this.GetGraphicalUiElementByName("SpriteInstance") ?? this;
                        }
                        setSpriteInstanceAlphaFirstValue = true;
                        SpriteInstanceAlphaFirstValue = 255;
                        if (interpolationValue < 1)
                        {
                            this.SpriteInstance.Animate = false;
                        }
                        setSpriteInstanceBlueFirstValue = true;
                        SpriteInstanceBlueFirstValue = 128;
                        setSpriteInstanceGreenFirstValue = true;
                        SpriteInstanceGreenFirstValue = 128;
                        setSpriteInstanceRedFirstValue = true;
                        SpriteInstanceRedFirstValue = 128;
                        setSpriteInstanceXFirstValue = true;
                        SpriteInstanceXFirstValue = 25f;
                        setSpriteInstanceYFirstValue = true;
                        SpriteInstanceYFirstValue = 5f;
                        setTextInstanceBlueFirstValue = true;
                        TextInstanceBlueFirstValue = 0;
                        setTextInstanceGreenFirstValue = true;
                        TextInstanceGreenFirstValue = 0;
                        if (interpolationValue < 1)
                        {
                            this.TextInstance.Parent = this.GetGraphicalUiElementByName("SpriteInstance") ?? this;
                        }
                        setTextInstanceRedFirstValue = true;
                        TextInstanceRedFirstValue = 0;
                        break;
                    case  ButtonCategory.HighlightedFocused:
                        setHighlightRectangleBlueFirstValue = true;
                        HighlightRectangleBlueFirstValue = 0;
                        setHighlightRectangleGreenFirstValue = true;
                        HighlightRectangleGreenFirstValue = 255;
                        setHighlightRectangleRedFirstValue = true;
                        HighlightRectangleRedFirstValue = 255;
                        if (interpolationValue < 1)
                        {
                            this.HighlightRectangle.Visible = true;
                        }
                        if (interpolationValue < 1)
                        {
                            this.PaceholderText.Parent = this.GetGraphicalUiElementByName("SpriteInstance") ?? this;
                        }
                        setSpriteInstanceAlphaFirstValue = true;
                        SpriteInstanceAlphaFirstValue = 255;
                        if (interpolationValue < 1)
                        {
                            this.SpriteInstance.Animate = false;
                        }
                        setSpriteInstanceBlueFirstValue = true;
                        SpriteInstanceBlueFirstValue = 0;
                        setSpriteInstanceGreenFirstValue = true;
                        SpriteInstanceGreenFirstValue = 255;
                        setSpriteInstanceRedFirstValue = true;
                        SpriteInstanceRedFirstValue = 255;
                        setSpriteInstanceXFirstValue = true;
                        SpriteInstanceXFirstValue = 20f;
                        setSpriteInstanceYFirstValue = true;
                        SpriteInstanceYFirstValue = 0f;
                        setTextInstanceBlueFirstValue = true;
                        TextInstanceBlueFirstValue = 0;
                        setTextInstanceGreenFirstValue = true;
                        TextInstanceGreenFirstValue = 0;
                        if (interpolationValue < 1)
                        {
                            this.TextInstance.Parent = this.GetGraphicalUiElementByName("SpriteInstance") ?? this;
                        }
                        setTextInstanceRedFirstValue = true;
                        TextInstanceRedFirstValue = 0;
                        break;
                    case  ButtonCategory.Focused:
                        setHighlightRectangleBlueFirstValue = true;
                        HighlightRectangleBlueFirstValue = 0;
                        setHighlightRectangleGreenFirstValue = true;
                        HighlightRectangleGreenFirstValue = 255;
                        setHighlightRectangleRedFirstValue = true;
                        HighlightRectangleRedFirstValue = 255;
                        if (interpolationValue < 1)
                        {
                            this.HighlightRectangle.Visible = true;
                        }
                        if (interpolationValue < 1)
                        {
                            this.PaceholderText.Parent = this.GetGraphicalUiElementByName("SpriteInstance") ?? this;
                        }
                        setSpriteInstanceAlphaFirstValue = true;
                        SpriteInstanceAlphaFirstValue = 255;
                        if (interpolationValue < 1)
                        {
                            this.SpriteInstance.Animate = false;
                        }
                        setSpriteInstanceBlueFirstValue = true;
                        SpriteInstanceBlueFirstValue = 255;
                        setSpriteInstanceGreenFirstValue = true;
                        SpriteInstanceGreenFirstValue = 255;
                        setSpriteInstanceRedFirstValue = true;
                        SpriteInstanceRedFirstValue = 255;
                        setSpriteInstanceXFirstValue = true;
                        SpriteInstanceXFirstValue = 0f;
                        setSpriteInstanceYFirstValue = true;
                        SpriteInstanceYFirstValue = 0f;
                        setTextInstanceBlueFirstValue = true;
                        TextInstanceBlueFirstValue = 0;
                        setTextInstanceGreenFirstValue = true;
                        TextInstanceGreenFirstValue = 0;
                        if (interpolationValue < 1)
                        {
                            this.TextInstance.Parent = this.GetGraphicalUiElementByName("SpriteInstance") ?? this;
                        }
                        setTextInstanceRedFirstValue = true;
                        TextInstanceRedFirstValue = 0;
                        break;
                }
                switch(secondState)
                {
                    case  ButtonCategory.Enabled:
                        setHighlightRectangleBlueSecondValue = true;
                        HighlightRectangleBlueSecondValue = 0;
                        setHighlightRectangleGreenSecondValue = true;
                        HighlightRectangleGreenSecondValue = 255;
                        setHighlightRectangleRedSecondValue = true;
                        HighlightRectangleRedSecondValue = 255;
                        if (interpolationValue >= 1)
                        {
                            this.HighlightRectangle.Visible = false;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.PaceholderText.Parent = this.GetGraphicalUiElementByName("SpriteInstance") ?? this;
                        }
                        setSpriteInstanceAlphaSecondValue = true;
                        SpriteInstanceAlphaSecondValue = 255;
                        if (interpolationValue >= 1)
                        {
                            this.SpriteInstance.Animate = false;
                        }
                        setSpriteInstanceBlueSecondValue = true;
                        SpriteInstanceBlueSecondValue = 255;
                        setSpriteInstanceGreenSecondValue = true;
                        SpriteInstanceGreenSecondValue = 255;
                        setSpriteInstanceRedSecondValue = true;
                        SpriteInstanceRedSecondValue = 255;
                        setSpriteInstanceXSecondValue = true;
                        SpriteInstanceXSecondValue = 0f;
                        setSpriteInstanceYSecondValue = true;
                        SpriteInstanceYSecondValue = 0f;
                        setTextInstanceBlueSecondValue = true;
                        TextInstanceBlueSecondValue = 255;
                        setTextInstanceGreenSecondValue = true;
                        TextInstanceGreenSecondValue = 255;
                        if (interpolationValue >= 1)
                        {
                            this.TextInstance.Parent = this.GetGraphicalUiElementByName("SpriteInstance") ?? this;
                        }
                        setTextInstanceRedSecondValue = true;
                        TextInstanceRedSecondValue = 255;
                        break;
                    case  ButtonCategory.Disabled:
                        setHighlightRectangleBlueSecondValue = true;
                        HighlightRectangleBlueSecondValue = 0;
                        setHighlightRectangleGreenSecondValue = true;
                        HighlightRectangleGreenSecondValue = 255;
                        setHighlightRectangleRedSecondValue = true;
                        HighlightRectangleRedSecondValue = 255;
                        if (interpolationValue >= 1)
                        {
                            this.HighlightRectangle.Visible = false;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.PaceholderText.Parent = this.GetGraphicalUiElementByName("SpriteInstance") ?? this;
                        }
                        setSpriteInstanceAlphaSecondValue = true;
                        SpriteInstanceAlphaSecondValue = 150;
                        if (interpolationValue >= 1)
                        {
                            this.SpriteInstance.Animate = false;
                        }
                        setSpriteInstanceBlueSecondValue = true;
                        SpriteInstanceBlueSecondValue = 128;
                        setSpriteInstanceGreenSecondValue = true;
                        SpriteInstanceGreenSecondValue = 128;
                        setSpriteInstanceRedSecondValue = true;
                        SpriteInstanceRedSecondValue = 128;
                        setSpriteInstanceXSecondValue = true;
                        SpriteInstanceXSecondValue = 0f;
                        setSpriteInstanceYSecondValue = true;
                        SpriteInstanceYSecondValue = 0f;
                        setTextInstanceBlueSecondValue = true;
                        TextInstanceBlueSecondValue = 255;
                        setTextInstanceGreenSecondValue = true;
                        TextInstanceGreenSecondValue = 255;
                        if (interpolationValue >= 1)
                        {
                            this.TextInstance.Parent = this.GetGraphicalUiElementByName("SpriteInstance") ?? this;
                        }
                        setTextInstanceRedSecondValue = true;
                        TextInstanceRedSecondValue = 255;
                        break;
                    case  ButtonCategory.Highlighted:
                        setHighlightRectangleBlueSecondValue = true;
                        HighlightRectangleBlueSecondValue = 255;
                        setHighlightRectangleGreenSecondValue = true;
                        HighlightRectangleGreenSecondValue = 255;
                        setHighlightRectangleRedSecondValue = true;
                        HighlightRectangleRedSecondValue = 255;
                        if (interpolationValue >= 1)
                        {
                            this.HighlightRectangle.Visible = true;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.PaceholderText.Parent = this.GetGraphicalUiElementByName("SpriteInstance") ?? this;
                        }
                        setSpriteInstanceAlphaSecondValue = true;
                        SpriteInstanceAlphaSecondValue = 255;
                        if (interpolationValue >= 1)
                        {
                            this.SpriteInstance.Animate = false;
                        }
                        setSpriteInstanceBlueSecondValue = true;
                        SpriteInstanceBlueSecondValue = 0;
                        setSpriteInstanceGreenSecondValue = true;
                        SpriteInstanceGreenSecondValue = 255;
                        setSpriteInstanceRedSecondValue = true;
                        SpriteInstanceRedSecondValue = 255;
                        setSpriteInstanceXSecondValue = true;
                        SpriteInstanceXSecondValue = 20f;
                        setSpriteInstanceYSecondValue = true;
                        SpriteInstanceYSecondValue = 0f;
                        setTextInstanceBlueSecondValue = true;
                        TextInstanceBlueSecondValue = 0;
                        setTextInstanceGreenSecondValue = true;
                        TextInstanceGreenSecondValue = 0;
                        if (interpolationValue >= 1)
                        {
                            this.TextInstance.Parent = this.GetGraphicalUiElementByName("SpriteInstance") ?? this;
                        }
                        setTextInstanceRedSecondValue = true;
                        TextInstanceRedSecondValue = 0;
                        break;
                    case  ButtonCategory.Pushed:
                        setHighlightRectangleBlueSecondValue = true;
                        HighlightRectangleBlueSecondValue = 0;
                        setHighlightRectangleGreenSecondValue = true;
                        HighlightRectangleGreenSecondValue = 255;
                        setHighlightRectangleRedSecondValue = true;
                        HighlightRectangleRedSecondValue = 255;
                        if (interpolationValue >= 1)
                        {
                            this.HighlightRectangle.Visible = false;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.PaceholderText.Parent = this.GetGraphicalUiElementByName("SpriteInstance") ?? this;
                        }
                        setSpriteInstanceAlphaSecondValue = true;
                        SpriteInstanceAlphaSecondValue = 255;
                        if (interpolationValue >= 1)
                        {
                            this.SpriteInstance.Animate = false;
                        }
                        setSpriteInstanceBlueSecondValue = true;
                        SpriteInstanceBlueSecondValue = 128;
                        setSpriteInstanceGreenSecondValue = true;
                        SpriteInstanceGreenSecondValue = 128;
                        setSpriteInstanceRedSecondValue = true;
                        SpriteInstanceRedSecondValue = 128;
                        setSpriteInstanceXSecondValue = true;
                        SpriteInstanceXSecondValue = 25f;
                        setSpriteInstanceYSecondValue = true;
                        SpriteInstanceYSecondValue = 5f;
                        setTextInstanceBlueSecondValue = true;
                        TextInstanceBlueSecondValue = 0;
                        setTextInstanceGreenSecondValue = true;
                        TextInstanceGreenSecondValue = 0;
                        if (interpolationValue >= 1)
                        {
                            this.TextInstance.Parent = this.GetGraphicalUiElementByName("SpriteInstance") ?? this;
                        }
                        setTextInstanceRedSecondValue = true;
                        TextInstanceRedSecondValue = 0;
                        break;
                    case  ButtonCategory.HighlightedFocused:
                        setHighlightRectangleBlueSecondValue = true;
                        HighlightRectangleBlueSecondValue = 0;
                        setHighlightRectangleGreenSecondValue = true;
                        HighlightRectangleGreenSecondValue = 255;
                        setHighlightRectangleRedSecondValue = true;
                        HighlightRectangleRedSecondValue = 255;
                        if (interpolationValue >= 1)
                        {
                            this.HighlightRectangle.Visible = true;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.PaceholderText.Parent = this.GetGraphicalUiElementByName("SpriteInstance") ?? this;
                        }
                        setSpriteInstanceAlphaSecondValue = true;
                        SpriteInstanceAlphaSecondValue = 255;
                        if (interpolationValue >= 1)
                        {
                            this.SpriteInstance.Animate = false;
                        }
                        setSpriteInstanceBlueSecondValue = true;
                        SpriteInstanceBlueSecondValue = 0;
                        setSpriteInstanceGreenSecondValue = true;
                        SpriteInstanceGreenSecondValue = 255;
                        setSpriteInstanceRedSecondValue = true;
                        SpriteInstanceRedSecondValue = 255;
                        setSpriteInstanceXSecondValue = true;
                        SpriteInstanceXSecondValue = 20f;
                        setSpriteInstanceYSecondValue = true;
                        SpriteInstanceYSecondValue = 0f;
                        setTextInstanceBlueSecondValue = true;
                        TextInstanceBlueSecondValue = 0;
                        setTextInstanceGreenSecondValue = true;
                        TextInstanceGreenSecondValue = 0;
                        if (interpolationValue >= 1)
                        {
                            this.TextInstance.Parent = this.GetGraphicalUiElementByName("SpriteInstance") ?? this;
                        }
                        setTextInstanceRedSecondValue = true;
                        TextInstanceRedSecondValue = 0;
                        break;
                    case  ButtonCategory.Focused:
                        setHighlightRectangleBlueSecondValue = true;
                        HighlightRectangleBlueSecondValue = 0;
                        setHighlightRectangleGreenSecondValue = true;
                        HighlightRectangleGreenSecondValue = 255;
                        setHighlightRectangleRedSecondValue = true;
                        HighlightRectangleRedSecondValue = 255;
                        if (interpolationValue >= 1)
                        {
                            this.HighlightRectangle.Visible = true;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.PaceholderText.Parent = this.GetGraphicalUiElementByName("SpriteInstance") ?? this;
                        }
                        setSpriteInstanceAlphaSecondValue = true;
                        SpriteInstanceAlphaSecondValue = 255;
                        if (interpolationValue >= 1)
                        {
                            this.SpriteInstance.Animate = false;
                        }
                        setSpriteInstanceBlueSecondValue = true;
                        SpriteInstanceBlueSecondValue = 255;
                        setSpriteInstanceGreenSecondValue = true;
                        SpriteInstanceGreenSecondValue = 255;
                        setSpriteInstanceRedSecondValue = true;
                        SpriteInstanceRedSecondValue = 255;
                        setSpriteInstanceXSecondValue = true;
                        SpriteInstanceXSecondValue = 0f;
                        setSpriteInstanceYSecondValue = true;
                        SpriteInstanceYSecondValue = 0f;
                        setTextInstanceBlueSecondValue = true;
                        TextInstanceBlueSecondValue = 0;
                        setTextInstanceGreenSecondValue = true;
                        TextInstanceGreenSecondValue = 0;
                        if (interpolationValue >= 1)
                        {
                            this.TextInstance.Parent = this.GetGraphicalUiElementByName("SpriteInstance") ?? this;
                        }
                        setTextInstanceRedSecondValue = true;
                        TextInstanceRedSecondValue = 0;
                        break;
                }
                var wasSuppressed = mIsLayoutSuspended;
                if (wasSuppressed == false)
                {
                    SuspendLayout(true);
                }
                if (setHighlightRectangleBlueFirstValue && setHighlightRectangleBlueSecondValue)
                {
                    HighlightRectangle.Blue = FlatRedBall.Math.MathFunctions.RoundToInt(HighlightRectangleBlueFirstValue* (1 - interpolationValue) + HighlightRectangleBlueSecondValue * interpolationValue);
                }
                if (setHighlightRectangleGreenFirstValue && setHighlightRectangleGreenSecondValue)
                {
                    HighlightRectangle.Green = FlatRedBall.Math.MathFunctions.RoundToInt(HighlightRectangleGreenFirstValue* (1 - interpolationValue) + HighlightRectangleGreenSecondValue * interpolationValue);
                }
                if (setHighlightRectangleRedFirstValue && setHighlightRectangleRedSecondValue)
                {
                    HighlightRectangle.Red = FlatRedBall.Math.MathFunctions.RoundToInt(HighlightRectangleRedFirstValue* (1 - interpolationValue) + HighlightRectangleRedSecondValue * interpolationValue);
                }
                if (setSpriteInstanceAlphaFirstValue && setSpriteInstanceAlphaSecondValue)
                {
                    SpriteInstance.Alpha = FlatRedBall.Math.MathFunctions.RoundToInt(SpriteInstanceAlphaFirstValue* (1 - interpolationValue) + SpriteInstanceAlphaSecondValue * interpolationValue);
                }
                if (setSpriteInstanceBlueFirstValue && setSpriteInstanceBlueSecondValue)
                {
                    SpriteInstance.Blue = FlatRedBall.Math.MathFunctions.RoundToInt(SpriteInstanceBlueFirstValue* (1 - interpolationValue) + SpriteInstanceBlueSecondValue * interpolationValue);
                }
                if (setSpriteInstanceGreenFirstValue && setSpriteInstanceGreenSecondValue)
                {
                    SpriteInstance.Green = FlatRedBall.Math.MathFunctions.RoundToInt(SpriteInstanceGreenFirstValue* (1 - interpolationValue) + SpriteInstanceGreenSecondValue * interpolationValue);
                }
                if (setSpriteInstanceRedFirstValue && setSpriteInstanceRedSecondValue)
                {
                    SpriteInstance.Red = FlatRedBall.Math.MathFunctions.RoundToInt(SpriteInstanceRedFirstValue* (1 - interpolationValue) + SpriteInstanceRedSecondValue * interpolationValue);
                }
                if (setSpriteInstanceXFirstValue && setSpriteInstanceXSecondValue)
                {
                    SpriteInstance.X = SpriteInstanceXFirstValue * (1 - interpolationValue) + SpriteInstanceXSecondValue * interpolationValue;
                }
                if (setSpriteInstanceYFirstValue && setSpriteInstanceYSecondValue)
                {
                    SpriteInstance.Y = SpriteInstanceYFirstValue * (1 - interpolationValue) + SpriteInstanceYSecondValue * interpolationValue;
                }
                if (setTextInstanceBlueFirstValue && setTextInstanceBlueSecondValue)
                {
                    TextInstance.Blue = FlatRedBall.Math.MathFunctions.RoundToInt(TextInstanceBlueFirstValue* (1 - interpolationValue) + TextInstanceBlueSecondValue * interpolationValue);
                }
                if (setTextInstanceGreenFirstValue && setTextInstanceGreenSecondValue)
                {
                    TextInstance.Green = FlatRedBall.Math.MathFunctions.RoundToInt(TextInstanceGreenFirstValue* (1 - interpolationValue) + TextInstanceGreenSecondValue * interpolationValue);
                }
                if (setTextInstanceRedFirstValue && setTextInstanceRedSecondValue)
                {
                    TextInstance.Red = FlatRedBall.Math.MathFunctions.RoundToInt(TextInstanceRedFirstValue* (1 - interpolationValue) + TextInstanceRedSecondValue * interpolationValue);
                }
                if (interpolationValue < 1)
                {
                    mCurrentButtonCategoryState = firstState;
                }
                else
                {
                    mCurrentButtonCategoryState = secondState;
                }
                if (!wasSuppressed)
                {
                    ResumeLayout(true);
                }
            }
            #endregion
            #region State Interpolate To
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (JHP4SD.GumRuntimes.LebegForms.BasicComponents.MainMenuButtonRuntime.VariableState fromState,JHP4SD.GumRuntimes.LebegForms.BasicComponents.MainMenuButtonRuntime.VariableState toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null) 
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
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (JHP4SD.GumRuntimes.LebegForms.BasicComponents.MainMenuButtonRuntime.ButtonCategory fromState,JHP4SD.GumRuntimes.LebegForms.BasicComponents.MainMenuButtonRuntime.ButtonCategory toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null) 
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
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (ButtonCategory toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null ) 
            {
                Gum.DataTypes.Variables.StateSave current = GetCurrentValuesOnState(toState);
                Gum.DataTypes.Variables.StateSave toAsStateSave = this.ElementSave.Categories.First(item => item.Name == "ButtonCategory").States.First(item => item.Name == toState.ToString());
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
                tweener.Ended += ()=> this.CurrentButtonCategoryState = toState;
                tweener.Start();
                StateInterpolationPlugin.TweenerManager.Self.Add(tweener);
                return tweener;
            }
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateToRelative (ButtonCategory toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null ) 
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
                tweener.Ended += ()=> this.CurrentButtonCategoryState = toState;
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
                            Name = "Width",
                            Type = "float",
                            Value = Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.SourceFile",
                            Type = "string",
                            Value = SpriteInstance.SourceFile
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
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PaceholderText.Alpha",
                            Type = "int",
                            Value = PaceholderText.Alpha
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PaceholderText.Blue",
                            Type = "int",
                            Value = PaceholderText.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PaceholderText.FontSize",
                            Type = "int",
                            Value = PaceholderText.FontSize
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PaceholderText.Height Units",
                            Type = "DimensionUnitType",
                            Value = PaceholderText.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PaceholderText.HorizontalAlignment",
                            Type = "HorizontalAlignment",
                            Value = PaceholderText.HorizontalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PaceholderText.IsItalic",
                            Type = "bool",
                            Value = PaceholderText.IsItalic
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PaceholderText.Parent",
                            Type = "string",
                            Value = PaceholderText.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PaceholderText.Rotation",
                            Type = "float",
                            Value = PaceholderText.Rotation
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PaceholderText.Text",
                            Type = "string",
                            Value = PaceholderText.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PaceholderText.VerticalAlignment",
                            Type = "VerticalAlignment",
                            Value = PaceholderText.VerticalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PaceholderText.Width Units",
                            Type = "DimensionUnitType",
                            Value = PaceholderText.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PaceholderText.X Origin",
                            Type = "HorizontalAlignment",
                            Value = PaceholderText.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PaceholderText.X Units",
                            Type = "PositionUnitType",
                            Value = PaceholderText.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PaceholderText.Y Origin",
                            Type = "VerticalAlignment",
                            Value = PaceholderText.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PaceholderText.Y Units",
                            Type = "PositionUnitType",
                            Value = PaceholderText.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HighlightRectangle.Blue",
                            Type = "int",
                            Value = HighlightRectangle.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HighlightRectangle.Green",
                            Type = "int",
                            Value = HighlightRectangle.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HighlightRectangle.Height",
                            Type = "float",
                            Value = HighlightRectangle.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HighlightRectangle.Height Units",
                            Type = "DimensionUnitType",
                            Value = HighlightRectangle.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HighlightRectangle.Parent",
                            Type = "string",
                            Value = HighlightRectangle.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HighlightRectangle.Red",
                            Type = "int",
                            Value = HighlightRectangle.Red
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HighlightRectangle.Width",
                            Type = "float",
                            Value = HighlightRectangle.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HighlightRectangle.Width Units",
                            Type = "DimensionUnitType",
                            Value = HighlightRectangle.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HighlightRectangle.X",
                            Type = "float",
                            Value = HighlightRectangle.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HighlightRectangle.X Origin",
                            Type = "HorizontalAlignment",
                            Value = HighlightRectangle.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HighlightRectangle.X Units",
                            Type = "PositionUnitType",
                            Value = HighlightRectangle.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HighlightRectangle.Y",
                            Type = "float",
                            Value = HighlightRectangle.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HighlightRectangle.Y Origin",
                            Type = "VerticalAlignment",
                            Value = HighlightRectangle.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HighlightRectangle.Y Units",
                            Type = "PositionUnitType",
                            Value = HighlightRectangle.YUnits
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
                            Name = "Width",
                            Type = "float",
                            Value = Width + 400f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.SourceFile",
                            Type = "string",
                            Value = SpriteInstance.SourceFile
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
                            Value = TextInstance.X + 25f
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
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PaceholderText.Alpha",
                            Type = "int",
                            Value = PaceholderText.Alpha + 150
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PaceholderText.Blue",
                            Type = "int",
                            Value = PaceholderText.Blue + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PaceholderText.FontSize",
                            Type = "int",
                            Value = PaceholderText.FontSize + 32
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PaceholderText.Height Units",
                            Type = "DimensionUnitType",
                            Value = PaceholderText.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PaceholderText.HorizontalAlignment",
                            Type = "HorizontalAlignment",
                            Value = PaceholderText.HorizontalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PaceholderText.IsItalic",
                            Type = "bool",
                            Value = PaceholderText.IsItalic
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PaceholderText.Parent",
                            Type = "string",
                            Value = PaceholderText.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PaceholderText.Rotation",
                            Type = "float",
                            Value = PaceholderText.Rotation + -20f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PaceholderText.Text",
                            Type = "string",
                            Value = PaceholderText.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PaceholderText.VerticalAlignment",
                            Type = "VerticalAlignment",
                            Value = PaceholderText.VerticalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PaceholderText.Width Units",
                            Type = "DimensionUnitType",
                            Value = PaceholderText.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PaceholderText.X Origin",
                            Type = "HorizontalAlignment",
                            Value = PaceholderText.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PaceholderText.X Units",
                            Type = "PositionUnitType",
                            Value = PaceholderText.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PaceholderText.Y Origin",
                            Type = "VerticalAlignment",
                            Value = PaceholderText.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PaceholderText.Y Units",
                            Type = "PositionUnitType",
                            Value = PaceholderText.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HighlightRectangle.Blue",
                            Type = "int",
                            Value = HighlightRectangle.Blue + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HighlightRectangle.Green",
                            Type = "int",
                            Value = HighlightRectangle.Green + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HighlightRectangle.Height",
                            Type = "float",
                            Value = HighlightRectangle.Height + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HighlightRectangle.Height Units",
                            Type = "DimensionUnitType",
                            Value = HighlightRectangle.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HighlightRectangle.Parent",
                            Type = "string",
                            Value = HighlightRectangle.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HighlightRectangle.Red",
                            Type = "int",
                            Value = HighlightRectangle.Red + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HighlightRectangle.Width",
                            Type = "float",
                            Value = HighlightRectangle.Width + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HighlightRectangle.Width Units",
                            Type = "DimensionUnitType",
                            Value = HighlightRectangle.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HighlightRectangle.X",
                            Type = "float",
                            Value = HighlightRectangle.X + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HighlightRectangle.X Origin",
                            Type = "HorizontalAlignment",
                            Value = HighlightRectangle.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HighlightRectangle.X Units",
                            Type = "PositionUnitType",
                            Value = HighlightRectangle.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HighlightRectangle.Y",
                            Type = "float",
                            Value = HighlightRectangle.Y + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HighlightRectangle.Y Origin",
                            Type = "VerticalAlignment",
                            Value = HighlightRectangle.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HighlightRectangle.Y Units",
                            Type = "PositionUnitType",
                            Value = HighlightRectangle.YUnits
                        }
                        );
                        break;
                }
                return newState;
            }
            private Gum.DataTypes.Variables.StateSave GetCurrentValuesOnState (ButtonCategory state) 
            {
                Gum.DataTypes.Variables.StateSave newState = new Gum.DataTypes.Variables.StateSave();
                switch(state)
                {
                    case  ButtonCategory.Enabled:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Alpha",
                            Type = "int",
                            Value = SpriteInstance.Alpha
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Animate",
                            Type = "bool",
                            Value = SpriteInstance.Animate
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Blue",
                            Type = "int",
                            Value = SpriteInstance.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Green",
                            Type = "int",
                            Value = SpriteInstance.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Red",
                            Type = "int",
                            Value = SpriteInstance.Red
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.X",
                            Type = "float",
                            Value = SpriteInstance.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Y",
                            Type = "float",
                            Value = SpriteInstance.Y
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
                            Name = "TextInstance.Green",
                            Type = "int",
                            Value = TextInstance.Green
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
                            Name = "PaceholderText.Parent",
                            Type = "string",
                            Value = PaceholderText.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HighlightRectangle.Blue",
                            Type = "int",
                            Value = HighlightRectangle.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HighlightRectangle.Green",
                            Type = "int",
                            Value = HighlightRectangle.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HighlightRectangle.Red",
                            Type = "int",
                            Value = HighlightRectangle.Red
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HighlightRectangle.Visible",
                            Type = "bool",
                            Value = HighlightRectangle.Visible
                        }
                        );
                        break;
                    case  ButtonCategory.Disabled:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Alpha",
                            Type = "int",
                            Value = SpriteInstance.Alpha
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Animate",
                            Type = "bool",
                            Value = SpriteInstance.Animate
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Blue",
                            Type = "int",
                            Value = SpriteInstance.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Green",
                            Type = "int",
                            Value = SpriteInstance.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Red",
                            Type = "int",
                            Value = SpriteInstance.Red
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.X",
                            Type = "float",
                            Value = SpriteInstance.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Y",
                            Type = "float",
                            Value = SpriteInstance.Y
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
                            Name = "TextInstance.Green",
                            Type = "int",
                            Value = TextInstance.Green
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
                            Name = "PaceholderText.Parent",
                            Type = "string",
                            Value = PaceholderText.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HighlightRectangle.Blue",
                            Type = "int",
                            Value = HighlightRectangle.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HighlightRectangle.Green",
                            Type = "int",
                            Value = HighlightRectangle.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HighlightRectangle.Red",
                            Type = "int",
                            Value = HighlightRectangle.Red
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HighlightRectangle.Visible",
                            Type = "bool",
                            Value = HighlightRectangle.Visible
                        }
                        );
                        break;
                    case  ButtonCategory.Highlighted:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Alpha",
                            Type = "int",
                            Value = SpriteInstance.Alpha
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Animate",
                            Type = "bool",
                            Value = SpriteInstance.Animate
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Blue",
                            Type = "int",
                            Value = SpriteInstance.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Green",
                            Type = "int",
                            Value = SpriteInstance.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Red",
                            Type = "int",
                            Value = SpriteInstance.Red
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.X",
                            Type = "float",
                            Value = SpriteInstance.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Y",
                            Type = "float",
                            Value = SpriteInstance.Y
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
                            Name = "TextInstance.Green",
                            Type = "int",
                            Value = TextInstance.Green
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
                            Name = "PaceholderText.Parent",
                            Type = "string",
                            Value = PaceholderText.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HighlightRectangle.Blue",
                            Type = "int",
                            Value = HighlightRectangle.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HighlightRectangle.Green",
                            Type = "int",
                            Value = HighlightRectangle.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HighlightRectangle.Red",
                            Type = "int",
                            Value = HighlightRectangle.Red
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HighlightRectangle.Visible",
                            Type = "bool",
                            Value = HighlightRectangle.Visible
                        }
                        );
                        break;
                    case  ButtonCategory.Pushed:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Alpha",
                            Type = "int",
                            Value = SpriteInstance.Alpha
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Animate",
                            Type = "bool",
                            Value = SpriteInstance.Animate
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Blue",
                            Type = "int",
                            Value = SpriteInstance.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Green",
                            Type = "int",
                            Value = SpriteInstance.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Red",
                            Type = "int",
                            Value = SpriteInstance.Red
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.X",
                            Type = "float",
                            Value = SpriteInstance.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Y",
                            Type = "float",
                            Value = SpriteInstance.Y
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
                            Name = "TextInstance.Green",
                            Type = "int",
                            Value = TextInstance.Green
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
                            Name = "PaceholderText.Parent",
                            Type = "string",
                            Value = PaceholderText.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HighlightRectangle.Blue",
                            Type = "int",
                            Value = HighlightRectangle.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HighlightRectangle.Green",
                            Type = "int",
                            Value = HighlightRectangle.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HighlightRectangle.Red",
                            Type = "int",
                            Value = HighlightRectangle.Red
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HighlightRectangle.Visible",
                            Type = "bool",
                            Value = HighlightRectangle.Visible
                        }
                        );
                        break;
                    case  ButtonCategory.HighlightedFocused:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Alpha",
                            Type = "int",
                            Value = SpriteInstance.Alpha
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Animate",
                            Type = "bool",
                            Value = SpriteInstance.Animate
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Blue",
                            Type = "int",
                            Value = SpriteInstance.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Green",
                            Type = "int",
                            Value = SpriteInstance.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Red",
                            Type = "int",
                            Value = SpriteInstance.Red
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.X",
                            Type = "float",
                            Value = SpriteInstance.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Y",
                            Type = "float",
                            Value = SpriteInstance.Y
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
                            Name = "TextInstance.Green",
                            Type = "int",
                            Value = TextInstance.Green
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
                            Name = "PaceholderText.Parent",
                            Type = "string",
                            Value = PaceholderText.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HighlightRectangle.Blue",
                            Type = "int",
                            Value = HighlightRectangle.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HighlightRectangle.Green",
                            Type = "int",
                            Value = HighlightRectangle.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HighlightRectangle.Red",
                            Type = "int",
                            Value = HighlightRectangle.Red
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HighlightRectangle.Visible",
                            Type = "bool",
                            Value = HighlightRectangle.Visible
                        }
                        );
                        break;
                    case  ButtonCategory.Focused:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Alpha",
                            Type = "int",
                            Value = SpriteInstance.Alpha
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Animate",
                            Type = "bool",
                            Value = SpriteInstance.Animate
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Blue",
                            Type = "int",
                            Value = SpriteInstance.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Green",
                            Type = "int",
                            Value = SpriteInstance.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Red",
                            Type = "int",
                            Value = SpriteInstance.Red
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.X",
                            Type = "float",
                            Value = SpriteInstance.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Y",
                            Type = "float",
                            Value = SpriteInstance.Y
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
                            Name = "TextInstance.Green",
                            Type = "int",
                            Value = TextInstance.Green
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
                            Name = "PaceholderText.Parent",
                            Type = "string",
                            Value = PaceholderText.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HighlightRectangle.Blue",
                            Type = "int",
                            Value = HighlightRectangle.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HighlightRectangle.Green",
                            Type = "int",
                            Value = HighlightRectangle.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HighlightRectangle.Red",
                            Type = "int",
                            Value = HighlightRectangle.Red
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HighlightRectangle.Visible",
                            Type = "bool",
                            Value = HighlightRectangle.Visible
                        }
                        );
                        break;
                }
                return newState;
            }
            private Gum.DataTypes.Variables.StateSave AddToCurrentValuesWithState (ButtonCategory state) 
            {
                Gum.DataTypes.Variables.StateSave newState = new Gum.DataTypes.Variables.StateSave();
                switch(state)
                {
                    case  ButtonCategory.Enabled:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Alpha",
                            Type = "int",
                            Value = SpriteInstance.Alpha + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Animate",
                            Type = "bool",
                            Value = SpriteInstance.Animate
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Blue",
                            Type = "int",
                            Value = SpriteInstance.Blue + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Green",
                            Type = "int",
                            Value = SpriteInstance.Green + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Red",
                            Type = "int",
                            Value = SpriteInstance.Red + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.X",
                            Type = "float",
                            Value = SpriteInstance.X + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Y",
                            Type = "float",
                            Value = SpriteInstance.Y + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Blue",
                            Type = "int",
                            Value = TextInstance.Blue + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Green",
                            Type = "int",
                            Value = TextInstance.Green + 255
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
                            Value = TextInstance.Red + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PaceholderText.Parent",
                            Type = "string",
                            Value = PaceholderText.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HighlightRectangle.Blue",
                            Type = "int",
                            Value = HighlightRectangle.Blue + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HighlightRectangle.Green",
                            Type = "int",
                            Value = HighlightRectangle.Green + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HighlightRectangle.Red",
                            Type = "int",
                            Value = HighlightRectangle.Red + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HighlightRectangle.Visible",
                            Type = "bool",
                            Value = HighlightRectangle.Visible
                        }
                        );
                        break;
                    case  ButtonCategory.Disabled:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Alpha",
                            Type = "int",
                            Value = SpriteInstance.Alpha + 150
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Animate",
                            Type = "bool",
                            Value = SpriteInstance.Animate
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Blue",
                            Type = "int",
                            Value = SpriteInstance.Blue + 128
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Green",
                            Type = "int",
                            Value = SpriteInstance.Green + 128
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Red",
                            Type = "int",
                            Value = SpriteInstance.Red + 128
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.X",
                            Type = "float",
                            Value = SpriteInstance.X + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Y",
                            Type = "float",
                            Value = SpriteInstance.Y + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Blue",
                            Type = "int",
                            Value = TextInstance.Blue + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Green",
                            Type = "int",
                            Value = TextInstance.Green + 255
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
                            Value = TextInstance.Red + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PaceholderText.Parent",
                            Type = "string",
                            Value = PaceholderText.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HighlightRectangle.Blue",
                            Type = "int",
                            Value = HighlightRectangle.Blue + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HighlightRectangle.Green",
                            Type = "int",
                            Value = HighlightRectangle.Green + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HighlightRectangle.Red",
                            Type = "int",
                            Value = HighlightRectangle.Red + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HighlightRectangle.Visible",
                            Type = "bool",
                            Value = HighlightRectangle.Visible
                        }
                        );
                        break;
                    case  ButtonCategory.Highlighted:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Alpha",
                            Type = "int",
                            Value = SpriteInstance.Alpha + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Animate",
                            Type = "bool",
                            Value = SpriteInstance.Animate
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Blue",
                            Type = "int",
                            Value = SpriteInstance.Blue + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Green",
                            Type = "int",
                            Value = SpriteInstance.Green + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Red",
                            Type = "int",
                            Value = SpriteInstance.Red + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.X",
                            Type = "float",
                            Value = SpriteInstance.X + 20f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Y",
                            Type = "float",
                            Value = SpriteInstance.Y + 0f
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
                            Name = "TextInstance.Green",
                            Type = "int",
                            Value = TextInstance.Green + 0
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
                            Name = "PaceholderText.Parent",
                            Type = "string",
                            Value = PaceholderText.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HighlightRectangle.Blue",
                            Type = "int",
                            Value = HighlightRectangle.Blue + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HighlightRectangle.Green",
                            Type = "int",
                            Value = HighlightRectangle.Green + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HighlightRectangle.Red",
                            Type = "int",
                            Value = HighlightRectangle.Red + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HighlightRectangle.Visible",
                            Type = "bool",
                            Value = HighlightRectangle.Visible
                        }
                        );
                        break;
                    case  ButtonCategory.Pushed:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Alpha",
                            Type = "int",
                            Value = SpriteInstance.Alpha + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Animate",
                            Type = "bool",
                            Value = SpriteInstance.Animate
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Blue",
                            Type = "int",
                            Value = SpriteInstance.Blue + 128
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Green",
                            Type = "int",
                            Value = SpriteInstance.Green + 128
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Red",
                            Type = "int",
                            Value = SpriteInstance.Red + 128
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.X",
                            Type = "float",
                            Value = SpriteInstance.X + 25f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Y",
                            Type = "float",
                            Value = SpriteInstance.Y + 5f
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
                            Name = "TextInstance.Green",
                            Type = "int",
                            Value = TextInstance.Green + 0
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
                            Name = "PaceholderText.Parent",
                            Type = "string",
                            Value = PaceholderText.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HighlightRectangle.Blue",
                            Type = "int",
                            Value = HighlightRectangle.Blue + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HighlightRectangle.Green",
                            Type = "int",
                            Value = HighlightRectangle.Green + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HighlightRectangle.Red",
                            Type = "int",
                            Value = HighlightRectangle.Red + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HighlightRectangle.Visible",
                            Type = "bool",
                            Value = HighlightRectangle.Visible
                        }
                        );
                        break;
                    case  ButtonCategory.HighlightedFocused:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Alpha",
                            Type = "int",
                            Value = SpriteInstance.Alpha + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Animate",
                            Type = "bool",
                            Value = SpriteInstance.Animate
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Blue",
                            Type = "int",
                            Value = SpriteInstance.Blue + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Green",
                            Type = "int",
                            Value = SpriteInstance.Green + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Red",
                            Type = "int",
                            Value = SpriteInstance.Red + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.X",
                            Type = "float",
                            Value = SpriteInstance.X + 20f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Y",
                            Type = "float",
                            Value = SpriteInstance.Y + 0f
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
                            Name = "TextInstance.Green",
                            Type = "int",
                            Value = TextInstance.Green + 0
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
                            Name = "PaceholderText.Parent",
                            Type = "string",
                            Value = PaceholderText.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HighlightRectangle.Blue",
                            Type = "int",
                            Value = HighlightRectangle.Blue + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HighlightRectangle.Green",
                            Type = "int",
                            Value = HighlightRectangle.Green + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HighlightRectangle.Red",
                            Type = "int",
                            Value = HighlightRectangle.Red + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HighlightRectangle.Visible",
                            Type = "bool",
                            Value = HighlightRectangle.Visible
                        }
                        );
                        break;
                    case  ButtonCategory.Focused:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Alpha",
                            Type = "int",
                            Value = SpriteInstance.Alpha + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Animate",
                            Type = "bool",
                            Value = SpriteInstance.Animate
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Blue",
                            Type = "int",
                            Value = SpriteInstance.Blue + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Green",
                            Type = "int",
                            Value = SpriteInstance.Green + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Red",
                            Type = "int",
                            Value = SpriteInstance.Red + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.X",
                            Type = "float",
                            Value = SpriteInstance.X + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Y",
                            Type = "float",
                            Value = SpriteInstance.Y + 0f
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
                            Name = "TextInstance.Green",
                            Type = "int",
                            Value = TextInstance.Green + 0
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
                            Name = "PaceholderText.Parent",
                            Type = "string",
                            Value = PaceholderText.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HighlightRectangle.Blue",
                            Type = "int",
                            Value = HighlightRectangle.Blue + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HighlightRectangle.Green",
                            Type = "int",
                            Value = HighlightRectangle.Green + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HighlightRectangle.Red",
                            Type = "int",
                            Value = HighlightRectangle.Red + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HighlightRectangle.Visible",
                            Type = "bool",
                            Value = HighlightRectangle.Visible
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
                    else if (category.Name == "ButtonCategory")
                    {
                        if(state.Name == "Enabled") this.mCurrentButtonCategoryState = ButtonCategory.Enabled;
                        if(state.Name == "Disabled") this.mCurrentButtonCategoryState = ButtonCategory.Disabled;
                        if(state.Name == "Highlighted") this.mCurrentButtonCategoryState = ButtonCategory.Highlighted;
                        if(state.Name == "Pushed") this.mCurrentButtonCategoryState = ButtonCategory.Pushed;
                        if(state.Name == "HighlightedFocused") this.mCurrentButtonCategoryState = ButtonCategory.HighlightedFocused;
                        if(state.Name == "Focused") this.mCurrentButtonCategoryState = ButtonCategory.Focused;
                    }
                }
                base.ApplyState(state);
            }
            private bool tryCreateFormsObject;
            public JHP4SD.GumRuntimes.SpriteRuntime SpriteInstance { get; set; }
            public JHP4SD.GumRuntimes.TextRuntime TextInstance { get; set; }
            public JHP4SD.GumRuntimes.TextRuntime PaceholderText { get; set; }
            public JHP4SD.GumRuntimes.RectangleRuntime HighlightRectangle { get; set; }
            public string MainButtonText
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
                        MainButtonTextChanged?.Invoke(this, null);
                    }
                }
            }
            public event System.EventHandler MainButtonTextChanged;
            public MainMenuButtonRuntime (bool fullInstantiation = true, bool tryCreateFormsObject = true) 
            	: base(false, tryCreateFormsObject)
            {
                this.tryCreateFormsObject = tryCreateFormsObject;
                if (fullInstantiation)
                {
                    Gum.DataTypes.ElementSave elementSave = Gum.Managers.ObjectFinder.Self.GumProjectSave.Components.First(item => item.Name == "LebegForms/BasicComponents/MainMenuButton");
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
                SpriteInstance = this.GetGraphicalUiElementByName("SpriteInstance") as JHP4SD.GumRuntimes.SpriteRuntime;
                TextInstance = this.GetGraphicalUiElementByName("TextInstance") as JHP4SD.GumRuntimes.TextRuntime;
                PaceholderText = this.GetGraphicalUiElementByName("PaceholderText") as JHP4SD.GumRuntimes.TextRuntime;
                HighlightRectangle = this.GetGraphicalUiElementByName("HighlightRectangle") as JHP4SD.GumRuntimes.RectangleRuntime;
                if (tryCreateFormsObject)
                {
                    FormsControlAsObject = new FlatRedBall.Forms.Controls.Button(this);
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
            public FlatRedBall.Forms.Controls.Button FormsControl {get => (FlatRedBall.Forms.Controls.Button) FormsControlAsObject;}
        }
    }
