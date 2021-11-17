    using System.Linq;
    namespace JHP4SD.GumRuntimes.LebegForms.BasicComponents
    {
        public partial class PlayButtonRuntime : JHP4SD.GumRuntimes.ContainerRuntime
        {
            #region State Enums
            public enum VariableState
            {
                Default
            }
            public enum ToggleCategory
            {
                EnabledOn,
                EnabledOff,
                DisabledOn,
                DisabledOff,
                HighlightedOn,
                HighlightedOff,
                PushedOn,
                PushedOff
            }
            #endregion
            #region State Fields
            VariableState mCurrentVariableState;
            ToggleCategory? mCurrentToggleCategoryState;
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
                            SpriteInstance.Parent = this.GetGraphicalUiElementByName("ColoredFrameInstance") ?? this;
                            ColoredFrameInstance.CurrentColorCategoryState = JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Black;
                            Height = 75f;
                            Width = 75f;
                            ColoredFrameInstance.Height = 0f;
                            ColoredFrameInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                            ColoredFrameInstance.Width = 0f;
                            ColoredFrameInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                            ColoredFrameInstance.X = 0f;
                            ColoredFrameInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                            ColoredFrameInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            ColoredFrameInstance.Y = 0f;
                            ColoredFrameInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            ColoredFrameInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            SetProperty("SpriteInstance.SourceFile", "../GlobalContent/gameicons/PNG/White/1x/checkmark.png");
                            SpriteInstance.Visible = true;
                            SpriteInstance.X = 0f;
                            SpriteInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                            SpriteInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            SpriteInstance.Y = 0f;
                            SpriteInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            SpriteInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            break;
                    }
                }
            }
            public ToggleCategory? CurrentToggleCategoryState
            {
                get
                {
                    return mCurrentToggleCategoryState;
                }
                set
                {
                    if (value != null)
                    {
                        mCurrentToggleCategoryState = value;
                        switch(mCurrentToggleCategoryState)
                        {
                            case  ToggleCategory.EnabledOn:
                                ColoredFrameInstance.CurrentColorCategoryState = JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Black;
                                ColoredFrameInstance.Blend = Gum.RenderingLibrary.Blend.Normal;
                                ColoredFrameInstance.Blue = 255;
                                ColoredFrameInstance.Green = 255;
                                ColoredFrameInstance.Height = 0f;
                                ColoredFrameInstance.Red = 255;
                                ColoredFrameInstance.Width = 0f;
                                SetProperty("SpriteInstance.SourceFile", "../GlobalContent/gameicons/PNG/White/1x/pause.png");
                                break;
                            case  ToggleCategory.EnabledOff:
                                ColoredFrameInstance.CurrentColorCategoryState = JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Green;
                                ColoredFrameInstance.Blend = Gum.RenderingLibrary.Blend.Normal;
                                ColoredFrameInstance.Blue = 255;
                                ColoredFrameInstance.Green = 255;
                                ColoredFrameInstance.Height = 0f;
                                ColoredFrameInstance.Red = 255;
                                ColoredFrameInstance.Width = 0f;
                                SetProperty("SpriteInstance.SourceFile", "../GlobalContent/gameicons/PNG/White/1x/forward.png");
                                break;
                            case  ToggleCategory.DisabledOn:
                                ColoredFrameInstance.CurrentColorCategoryState = JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Black;
                                ColoredFrameInstance.Blend = Gum.RenderingLibrary.Blend.Normal;
                                ColoredFrameInstance.Blue = 255;
                                ColoredFrameInstance.Green = 255;
                                ColoredFrameInstance.Height = 0f;
                                ColoredFrameInstance.Red = 255;
                                ColoredFrameInstance.Width = 0f;
                                SetProperty("SpriteInstance.SourceFile", "../GlobalContent/gameicons/PNG/White/1x/cross.png");
                                break;
                            case  ToggleCategory.DisabledOff:
                                ColoredFrameInstance.CurrentColorCategoryState = JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Green;
                                ColoredFrameInstance.Blend = Gum.RenderingLibrary.Blend.Normal;
                                ColoredFrameInstance.Blue = 255;
                                ColoredFrameInstance.Green = 255;
                                ColoredFrameInstance.Height = 0f;
                                ColoredFrameInstance.Red = 255;
                                ColoredFrameInstance.Width = 0f;
                                SetProperty("SpriteInstance.SourceFile", "../GlobalContent/gameicons/PNG/White/1x/cross.png");
                                break;
                            case  ToggleCategory.HighlightedOn:
                                ColoredFrameInstance.CurrentColorCategoryState = JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Gray;
                                ColoredFrameInstance.Blue = 128;
                                ColoredFrameInstance.Green = 128;
                                ColoredFrameInstance.Height = 0f;
                                ColoredFrameInstance.Red = 128;
                                ColoredFrameInstance.Width = 0f;
                                SetProperty("SpriteInstance.SourceFile", "../GlobalContent/gameicons/PNG/White/1x/pause.png");
                                break;
                            case  ToggleCategory.HighlightedOff:
                                ColoredFrameInstance.CurrentColorCategoryState = JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Gray;
                                ColoredFrameInstance.Blend = Gum.RenderingLibrary.Blend.Normal;
                                ColoredFrameInstance.Blue = 0;
                                ColoredFrameInstance.Green = 255;
                                ColoredFrameInstance.Height = 0f;
                                ColoredFrameInstance.Red = 0;
                                ColoredFrameInstance.Width = 0f;
                                SetProperty("SpriteInstance.SourceFile", "../GlobalContent/gameicons/PNG/White/1x/forward.png");
                                break;
                            case  ToggleCategory.PushedOn:
                                ColoredFrameInstance.CurrentColorCategoryState = JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Green;
                                ColoredFrameInstance.Blend = Gum.RenderingLibrary.Blend.Normal;
                                ColoredFrameInstance.Blue = 128;
                                ColoredFrameInstance.Green = 128;
                                ColoredFrameInstance.Height = -6f;
                                ColoredFrameInstance.Red = 128;
                                ColoredFrameInstance.Width = -6f;
                                SetProperty("SpriteInstance.SourceFile", "../GlobalContent/gameicons/PNG/White/1x/forward.png");
                                break;
                            case  ToggleCategory.PushedOff:
                                ColoredFrameInstance.CurrentColorCategoryState = JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Black;
                                ColoredFrameInstance.Blend = Gum.RenderingLibrary.Blend.Normal;
                                ColoredFrameInstance.Blue = 128;
                                ColoredFrameInstance.Green = 128;
                                ColoredFrameInstance.Height = -6f;
                                ColoredFrameInstance.Red = 128;
                                ColoredFrameInstance.Width = -6f;
                                SetProperty("SpriteInstance.SourceFile", "../GlobalContent/gameicons/PNG/White/1x/pause.png");
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
                bool setColoredFrameInstanceCurrentColorCategoryStateFirstValue = false;
                bool setColoredFrameInstanceCurrentColorCategoryStateSecondValue = false;
                JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory ColoredFrameInstanceCurrentColorCategoryStateFirstValue= JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Gray;
                JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory ColoredFrameInstanceCurrentColorCategoryStateSecondValue= JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Gray;
                bool setColoredFrameInstanceHeightFirstValue = false;
                bool setColoredFrameInstanceHeightSecondValue = false;
                float ColoredFrameInstanceHeightFirstValue= 0;
                float ColoredFrameInstanceHeightSecondValue= 0;
                bool setColoredFrameInstanceWidthFirstValue = false;
                bool setColoredFrameInstanceWidthSecondValue = false;
                float ColoredFrameInstanceWidthFirstValue= 0;
                float ColoredFrameInstanceWidthSecondValue= 0;
                bool setColoredFrameInstanceXFirstValue = false;
                bool setColoredFrameInstanceXSecondValue = false;
                float ColoredFrameInstanceXFirstValue= 0;
                float ColoredFrameInstanceXSecondValue= 0;
                bool setColoredFrameInstanceYFirstValue = false;
                bool setColoredFrameInstanceYSecondValue = false;
                float ColoredFrameInstanceYFirstValue= 0;
                float ColoredFrameInstanceYSecondValue= 0;
                bool setHeightFirstValue = false;
                bool setHeightSecondValue = false;
                float HeightFirstValue= 0;
                float HeightSecondValue= 0;
                bool setSpriteInstanceXFirstValue = false;
                bool setSpriteInstanceXSecondValue = false;
                float SpriteInstanceXFirstValue= 0;
                float SpriteInstanceXSecondValue= 0;
                bool setSpriteInstanceYFirstValue = false;
                bool setSpriteInstanceYSecondValue = false;
                float SpriteInstanceYFirstValue= 0;
                float SpriteInstanceYSecondValue= 0;
                bool setWidthFirstValue = false;
                bool setWidthSecondValue = false;
                float WidthFirstValue= 0;
                float WidthSecondValue= 0;
                switch(firstState)
                {
                    case  VariableState.Default:
                        setColoredFrameInstanceCurrentColorCategoryStateFirstValue = true;
                        ColoredFrameInstanceCurrentColorCategoryStateFirstValue = JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Black;
                        setColoredFrameInstanceHeightFirstValue = true;
                        ColoredFrameInstanceHeightFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.ColoredFrameInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        setColoredFrameInstanceWidthFirstValue = true;
                        ColoredFrameInstanceWidthFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.ColoredFrameInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        setColoredFrameInstanceXFirstValue = true;
                        ColoredFrameInstanceXFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.ColoredFrameInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.ColoredFrameInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setColoredFrameInstanceYFirstValue = true;
                        ColoredFrameInstanceYFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.ColoredFrameInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.ColoredFrameInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setHeightFirstValue = true;
                        HeightFirstValue = 75f;
                        if (interpolationValue < 1)
                        {
                            this.SpriteInstance.Parent = this.GetGraphicalUiElementByName("ColoredFrameInstance") ?? this;
                        }
                        if (interpolationValue < 1)
                        {
                            SetProperty("SpriteInstance.SourceFile", "../GlobalContent/gameicons/PNG/White/1x/checkmark.png");
                        }
                        if (interpolationValue < 1)
                        {
                            this.SpriteInstance.Visible = true;
                        }
                        setSpriteInstanceXFirstValue = true;
                        SpriteInstanceXFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.SpriteInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.SpriteInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setSpriteInstanceYFirstValue = true;
                        SpriteInstanceYFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.SpriteInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.SpriteInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setWidthFirstValue = true;
                        WidthFirstValue = 75f;
                        break;
                }
                switch(secondState)
                {
                    case  VariableState.Default:
                        setColoredFrameInstanceCurrentColorCategoryStateSecondValue = true;
                        ColoredFrameInstanceCurrentColorCategoryStateSecondValue = JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Black;
                        setColoredFrameInstanceHeightSecondValue = true;
                        ColoredFrameInstanceHeightSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.ColoredFrameInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        setColoredFrameInstanceWidthSecondValue = true;
                        ColoredFrameInstanceWidthSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.ColoredFrameInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        setColoredFrameInstanceXSecondValue = true;
                        ColoredFrameInstanceXSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.ColoredFrameInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.ColoredFrameInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setColoredFrameInstanceYSecondValue = true;
                        ColoredFrameInstanceYSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.ColoredFrameInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.ColoredFrameInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setHeightSecondValue = true;
                        HeightSecondValue = 75f;
                        if (interpolationValue >= 1)
                        {
                            this.SpriteInstance.Parent = this.GetGraphicalUiElementByName("ColoredFrameInstance") ?? this;
                        }
                        if (interpolationValue >= 1)
                        {
                            SetProperty("SpriteInstance.SourceFile", "../GlobalContent/gameicons/PNG/White/1x/checkmark.png");
                        }
                        if (interpolationValue >= 1)
                        {
                            this.SpriteInstance.Visible = true;
                        }
                        setSpriteInstanceXSecondValue = true;
                        SpriteInstanceXSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.SpriteInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.SpriteInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setSpriteInstanceYSecondValue = true;
                        SpriteInstanceYSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.SpriteInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.SpriteInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setWidthSecondValue = true;
                        WidthSecondValue = 75f;
                        break;
                }
                var wasSuppressed = mIsLayoutSuspended;
                if (wasSuppressed == false)
                {
                    SuspendLayout(true);
                }
                if (setColoredFrameInstanceCurrentColorCategoryStateFirstValue && setColoredFrameInstanceCurrentColorCategoryStateSecondValue)
                {
                    ColoredFrameInstance.InterpolateBetween(ColoredFrameInstanceCurrentColorCategoryStateFirstValue, ColoredFrameInstanceCurrentColorCategoryStateSecondValue, interpolationValue);
                }
                if (setColoredFrameInstanceHeightFirstValue && setColoredFrameInstanceHeightSecondValue)
                {
                    ColoredFrameInstance.Height = ColoredFrameInstanceHeightFirstValue * (1 - interpolationValue) + ColoredFrameInstanceHeightSecondValue * interpolationValue;
                }
                if (setColoredFrameInstanceWidthFirstValue && setColoredFrameInstanceWidthSecondValue)
                {
                    ColoredFrameInstance.Width = ColoredFrameInstanceWidthFirstValue * (1 - interpolationValue) + ColoredFrameInstanceWidthSecondValue * interpolationValue;
                }
                if (setColoredFrameInstanceXFirstValue && setColoredFrameInstanceXSecondValue)
                {
                    ColoredFrameInstance.X = ColoredFrameInstanceXFirstValue * (1 - interpolationValue) + ColoredFrameInstanceXSecondValue * interpolationValue;
                }
                if (setColoredFrameInstanceYFirstValue && setColoredFrameInstanceYSecondValue)
                {
                    ColoredFrameInstance.Y = ColoredFrameInstanceYFirstValue * (1 - interpolationValue) + ColoredFrameInstanceYSecondValue * interpolationValue;
                }
                if (setHeightFirstValue && setHeightSecondValue)
                {
                    Height = HeightFirstValue * (1 - interpolationValue) + HeightSecondValue * interpolationValue;
                }
                if (setSpriteInstanceXFirstValue && setSpriteInstanceXSecondValue)
                {
                    SpriteInstance.X = SpriteInstanceXFirstValue * (1 - interpolationValue) + SpriteInstanceXSecondValue * interpolationValue;
                }
                if (setSpriteInstanceYFirstValue && setSpriteInstanceYSecondValue)
                {
                    SpriteInstance.Y = SpriteInstanceYFirstValue * (1 - interpolationValue) + SpriteInstanceYSecondValue * interpolationValue;
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
            public void InterpolateBetween (ToggleCategory firstState, ToggleCategory secondState, float interpolationValue) 
            {
                #if DEBUG
                if (float.IsNaN(interpolationValue))
                {
                    throw new System.Exception("interpolationValue cannot be NaN");
                }
                #endif
                bool setColoredFrameInstanceBlueFirstValue = false;
                bool setColoredFrameInstanceBlueSecondValue = false;
                int ColoredFrameInstanceBlueFirstValue= 0;
                int ColoredFrameInstanceBlueSecondValue= 0;
                bool setColoredFrameInstanceCurrentColorCategoryStateFirstValue = false;
                bool setColoredFrameInstanceCurrentColorCategoryStateSecondValue = false;
                JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory ColoredFrameInstanceCurrentColorCategoryStateFirstValue= JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Gray;
                JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory ColoredFrameInstanceCurrentColorCategoryStateSecondValue= JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Gray;
                bool setColoredFrameInstanceGreenFirstValue = false;
                bool setColoredFrameInstanceGreenSecondValue = false;
                int ColoredFrameInstanceGreenFirstValue= 0;
                int ColoredFrameInstanceGreenSecondValue= 0;
                bool setColoredFrameInstanceHeightFirstValue = false;
                bool setColoredFrameInstanceHeightSecondValue = false;
                float ColoredFrameInstanceHeightFirstValue= 0;
                float ColoredFrameInstanceHeightSecondValue= 0;
                bool setColoredFrameInstanceRedFirstValue = false;
                bool setColoredFrameInstanceRedSecondValue = false;
                int ColoredFrameInstanceRedFirstValue= 0;
                int ColoredFrameInstanceRedSecondValue= 0;
                bool setColoredFrameInstanceWidthFirstValue = false;
                bool setColoredFrameInstanceWidthSecondValue = false;
                float ColoredFrameInstanceWidthFirstValue= 0;
                float ColoredFrameInstanceWidthSecondValue= 0;
                switch(firstState)
                {
                    case  ToggleCategory.EnabledOn:
                        if (interpolationValue < 1)
                        {
                            this.ColoredFrameInstance.Blend = Gum.RenderingLibrary.Blend.Normal;
                        }
                        setColoredFrameInstanceBlueFirstValue = true;
                        ColoredFrameInstanceBlueFirstValue = 255;
                        setColoredFrameInstanceCurrentColorCategoryStateFirstValue = true;
                        ColoredFrameInstanceCurrentColorCategoryStateFirstValue = JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Black;
                        setColoredFrameInstanceGreenFirstValue = true;
                        ColoredFrameInstanceGreenFirstValue = 255;
                        setColoredFrameInstanceHeightFirstValue = true;
                        ColoredFrameInstanceHeightFirstValue = 0f;
                        setColoredFrameInstanceRedFirstValue = true;
                        ColoredFrameInstanceRedFirstValue = 255;
                        setColoredFrameInstanceWidthFirstValue = true;
                        ColoredFrameInstanceWidthFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            SetProperty("SpriteInstance.SourceFile", "../GlobalContent/gameicons/PNG/White/1x/pause.png");
                        }
                        break;
                    case  ToggleCategory.EnabledOff:
                        if (interpolationValue < 1)
                        {
                            this.ColoredFrameInstance.Blend = Gum.RenderingLibrary.Blend.Normal;
                        }
                        setColoredFrameInstanceBlueFirstValue = true;
                        ColoredFrameInstanceBlueFirstValue = 255;
                        setColoredFrameInstanceCurrentColorCategoryStateFirstValue = true;
                        ColoredFrameInstanceCurrentColorCategoryStateFirstValue = JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Green;
                        setColoredFrameInstanceGreenFirstValue = true;
                        ColoredFrameInstanceGreenFirstValue = 255;
                        setColoredFrameInstanceHeightFirstValue = true;
                        ColoredFrameInstanceHeightFirstValue = 0f;
                        setColoredFrameInstanceRedFirstValue = true;
                        ColoredFrameInstanceRedFirstValue = 255;
                        setColoredFrameInstanceWidthFirstValue = true;
                        ColoredFrameInstanceWidthFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            SetProperty("SpriteInstance.SourceFile", "../GlobalContent/gameicons/PNG/White/1x/forward.png");
                        }
                        break;
                    case  ToggleCategory.DisabledOn:
                        if (interpolationValue < 1)
                        {
                            this.ColoredFrameInstance.Blend = Gum.RenderingLibrary.Blend.Normal;
                        }
                        setColoredFrameInstanceBlueFirstValue = true;
                        ColoredFrameInstanceBlueFirstValue = 255;
                        setColoredFrameInstanceCurrentColorCategoryStateFirstValue = true;
                        ColoredFrameInstanceCurrentColorCategoryStateFirstValue = JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Black;
                        setColoredFrameInstanceGreenFirstValue = true;
                        ColoredFrameInstanceGreenFirstValue = 255;
                        setColoredFrameInstanceHeightFirstValue = true;
                        ColoredFrameInstanceHeightFirstValue = 0f;
                        setColoredFrameInstanceRedFirstValue = true;
                        ColoredFrameInstanceRedFirstValue = 255;
                        setColoredFrameInstanceWidthFirstValue = true;
                        ColoredFrameInstanceWidthFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            SetProperty("SpriteInstance.SourceFile", "../GlobalContent/gameicons/PNG/White/1x/cross.png");
                        }
                        break;
                    case  ToggleCategory.DisabledOff:
                        if (interpolationValue < 1)
                        {
                            this.ColoredFrameInstance.Blend = Gum.RenderingLibrary.Blend.Normal;
                        }
                        setColoredFrameInstanceBlueFirstValue = true;
                        ColoredFrameInstanceBlueFirstValue = 255;
                        setColoredFrameInstanceCurrentColorCategoryStateFirstValue = true;
                        ColoredFrameInstanceCurrentColorCategoryStateFirstValue = JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Green;
                        setColoredFrameInstanceGreenFirstValue = true;
                        ColoredFrameInstanceGreenFirstValue = 255;
                        setColoredFrameInstanceHeightFirstValue = true;
                        ColoredFrameInstanceHeightFirstValue = 0f;
                        setColoredFrameInstanceRedFirstValue = true;
                        ColoredFrameInstanceRedFirstValue = 255;
                        setColoredFrameInstanceWidthFirstValue = true;
                        ColoredFrameInstanceWidthFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            SetProperty("SpriteInstance.SourceFile", "../GlobalContent/gameicons/PNG/White/1x/cross.png");
                        }
                        break;
                    case  ToggleCategory.HighlightedOn:
                        setColoredFrameInstanceBlueFirstValue = true;
                        ColoredFrameInstanceBlueFirstValue = 128;
                        setColoredFrameInstanceCurrentColorCategoryStateFirstValue = true;
                        ColoredFrameInstanceCurrentColorCategoryStateFirstValue = JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Gray;
                        setColoredFrameInstanceGreenFirstValue = true;
                        ColoredFrameInstanceGreenFirstValue = 128;
                        setColoredFrameInstanceHeightFirstValue = true;
                        ColoredFrameInstanceHeightFirstValue = 0f;
                        setColoredFrameInstanceRedFirstValue = true;
                        ColoredFrameInstanceRedFirstValue = 128;
                        setColoredFrameInstanceWidthFirstValue = true;
                        ColoredFrameInstanceWidthFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            SetProperty("SpriteInstance.SourceFile", "../GlobalContent/gameicons/PNG/White/1x/pause.png");
                        }
                        break;
                    case  ToggleCategory.HighlightedOff:
                        if (interpolationValue < 1)
                        {
                            this.ColoredFrameInstance.Blend = Gum.RenderingLibrary.Blend.Normal;
                        }
                        setColoredFrameInstanceBlueFirstValue = true;
                        ColoredFrameInstanceBlueFirstValue = 0;
                        setColoredFrameInstanceCurrentColorCategoryStateFirstValue = true;
                        ColoredFrameInstanceCurrentColorCategoryStateFirstValue = JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Gray;
                        setColoredFrameInstanceGreenFirstValue = true;
                        ColoredFrameInstanceGreenFirstValue = 255;
                        setColoredFrameInstanceHeightFirstValue = true;
                        ColoredFrameInstanceHeightFirstValue = 0f;
                        setColoredFrameInstanceRedFirstValue = true;
                        ColoredFrameInstanceRedFirstValue = 0;
                        setColoredFrameInstanceWidthFirstValue = true;
                        ColoredFrameInstanceWidthFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            SetProperty("SpriteInstance.SourceFile", "../GlobalContent/gameicons/PNG/White/1x/forward.png");
                        }
                        break;
                    case  ToggleCategory.PushedOn:
                        if (interpolationValue < 1)
                        {
                            this.ColoredFrameInstance.Blend = Gum.RenderingLibrary.Blend.Normal;
                        }
                        setColoredFrameInstanceBlueFirstValue = true;
                        ColoredFrameInstanceBlueFirstValue = 128;
                        setColoredFrameInstanceCurrentColorCategoryStateFirstValue = true;
                        ColoredFrameInstanceCurrentColorCategoryStateFirstValue = JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Green;
                        setColoredFrameInstanceGreenFirstValue = true;
                        ColoredFrameInstanceGreenFirstValue = 128;
                        setColoredFrameInstanceHeightFirstValue = true;
                        ColoredFrameInstanceHeightFirstValue = -6f;
                        setColoredFrameInstanceRedFirstValue = true;
                        ColoredFrameInstanceRedFirstValue = 128;
                        setColoredFrameInstanceWidthFirstValue = true;
                        ColoredFrameInstanceWidthFirstValue = -6f;
                        if (interpolationValue < 1)
                        {
                            SetProperty("SpriteInstance.SourceFile", "../GlobalContent/gameicons/PNG/White/1x/forward.png");
                        }
                        break;
                    case  ToggleCategory.PushedOff:
                        if (interpolationValue < 1)
                        {
                            this.ColoredFrameInstance.Blend = Gum.RenderingLibrary.Blend.Normal;
                        }
                        setColoredFrameInstanceBlueFirstValue = true;
                        ColoredFrameInstanceBlueFirstValue = 128;
                        setColoredFrameInstanceCurrentColorCategoryStateFirstValue = true;
                        ColoredFrameInstanceCurrentColorCategoryStateFirstValue = JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Black;
                        setColoredFrameInstanceGreenFirstValue = true;
                        ColoredFrameInstanceGreenFirstValue = 128;
                        setColoredFrameInstanceHeightFirstValue = true;
                        ColoredFrameInstanceHeightFirstValue = -6f;
                        setColoredFrameInstanceRedFirstValue = true;
                        ColoredFrameInstanceRedFirstValue = 128;
                        setColoredFrameInstanceWidthFirstValue = true;
                        ColoredFrameInstanceWidthFirstValue = -6f;
                        if (interpolationValue < 1)
                        {
                            SetProperty("SpriteInstance.SourceFile", "../GlobalContent/gameicons/PNG/White/1x/pause.png");
                        }
                        break;
                }
                switch(secondState)
                {
                    case  ToggleCategory.EnabledOn:
                        if (interpolationValue >= 1)
                        {
                            this.ColoredFrameInstance.Blend = Gum.RenderingLibrary.Blend.Normal;
                        }
                        setColoredFrameInstanceBlueSecondValue = true;
                        ColoredFrameInstanceBlueSecondValue = 255;
                        setColoredFrameInstanceCurrentColorCategoryStateSecondValue = true;
                        ColoredFrameInstanceCurrentColorCategoryStateSecondValue = JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Black;
                        setColoredFrameInstanceGreenSecondValue = true;
                        ColoredFrameInstanceGreenSecondValue = 255;
                        setColoredFrameInstanceHeightSecondValue = true;
                        ColoredFrameInstanceHeightSecondValue = 0f;
                        setColoredFrameInstanceRedSecondValue = true;
                        ColoredFrameInstanceRedSecondValue = 255;
                        setColoredFrameInstanceWidthSecondValue = true;
                        ColoredFrameInstanceWidthSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            SetProperty("SpriteInstance.SourceFile", "../GlobalContent/gameicons/PNG/White/1x/pause.png");
                        }
                        break;
                    case  ToggleCategory.EnabledOff:
                        if (interpolationValue >= 1)
                        {
                            this.ColoredFrameInstance.Blend = Gum.RenderingLibrary.Blend.Normal;
                        }
                        setColoredFrameInstanceBlueSecondValue = true;
                        ColoredFrameInstanceBlueSecondValue = 255;
                        setColoredFrameInstanceCurrentColorCategoryStateSecondValue = true;
                        ColoredFrameInstanceCurrentColorCategoryStateSecondValue = JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Green;
                        setColoredFrameInstanceGreenSecondValue = true;
                        ColoredFrameInstanceGreenSecondValue = 255;
                        setColoredFrameInstanceHeightSecondValue = true;
                        ColoredFrameInstanceHeightSecondValue = 0f;
                        setColoredFrameInstanceRedSecondValue = true;
                        ColoredFrameInstanceRedSecondValue = 255;
                        setColoredFrameInstanceWidthSecondValue = true;
                        ColoredFrameInstanceWidthSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            SetProperty("SpriteInstance.SourceFile", "../GlobalContent/gameicons/PNG/White/1x/forward.png");
                        }
                        break;
                    case  ToggleCategory.DisabledOn:
                        if (interpolationValue >= 1)
                        {
                            this.ColoredFrameInstance.Blend = Gum.RenderingLibrary.Blend.Normal;
                        }
                        setColoredFrameInstanceBlueSecondValue = true;
                        ColoredFrameInstanceBlueSecondValue = 255;
                        setColoredFrameInstanceCurrentColorCategoryStateSecondValue = true;
                        ColoredFrameInstanceCurrentColorCategoryStateSecondValue = JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Black;
                        setColoredFrameInstanceGreenSecondValue = true;
                        ColoredFrameInstanceGreenSecondValue = 255;
                        setColoredFrameInstanceHeightSecondValue = true;
                        ColoredFrameInstanceHeightSecondValue = 0f;
                        setColoredFrameInstanceRedSecondValue = true;
                        ColoredFrameInstanceRedSecondValue = 255;
                        setColoredFrameInstanceWidthSecondValue = true;
                        ColoredFrameInstanceWidthSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            SetProperty("SpriteInstance.SourceFile", "../GlobalContent/gameicons/PNG/White/1x/cross.png");
                        }
                        break;
                    case  ToggleCategory.DisabledOff:
                        if (interpolationValue >= 1)
                        {
                            this.ColoredFrameInstance.Blend = Gum.RenderingLibrary.Blend.Normal;
                        }
                        setColoredFrameInstanceBlueSecondValue = true;
                        ColoredFrameInstanceBlueSecondValue = 255;
                        setColoredFrameInstanceCurrentColorCategoryStateSecondValue = true;
                        ColoredFrameInstanceCurrentColorCategoryStateSecondValue = JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Green;
                        setColoredFrameInstanceGreenSecondValue = true;
                        ColoredFrameInstanceGreenSecondValue = 255;
                        setColoredFrameInstanceHeightSecondValue = true;
                        ColoredFrameInstanceHeightSecondValue = 0f;
                        setColoredFrameInstanceRedSecondValue = true;
                        ColoredFrameInstanceRedSecondValue = 255;
                        setColoredFrameInstanceWidthSecondValue = true;
                        ColoredFrameInstanceWidthSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            SetProperty("SpriteInstance.SourceFile", "../GlobalContent/gameicons/PNG/White/1x/cross.png");
                        }
                        break;
                    case  ToggleCategory.HighlightedOn:
                        setColoredFrameInstanceBlueSecondValue = true;
                        ColoredFrameInstanceBlueSecondValue = 128;
                        setColoredFrameInstanceCurrentColorCategoryStateSecondValue = true;
                        ColoredFrameInstanceCurrentColorCategoryStateSecondValue = JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Gray;
                        setColoredFrameInstanceGreenSecondValue = true;
                        ColoredFrameInstanceGreenSecondValue = 128;
                        setColoredFrameInstanceHeightSecondValue = true;
                        ColoredFrameInstanceHeightSecondValue = 0f;
                        setColoredFrameInstanceRedSecondValue = true;
                        ColoredFrameInstanceRedSecondValue = 128;
                        setColoredFrameInstanceWidthSecondValue = true;
                        ColoredFrameInstanceWidthSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            SetProperty("SpriteInstance.SourceFile", "../GlobalContent/gameicons/PNG/White/1x/pause.png");
                        }
                        break;
                    case  ToggleCategory.HighlightedOff:
                        if (interpolationValue >= 1)
                        {
                            this.ColoredFrameInstance.Blend = Gum.RenderingLibrary.Blend.Normal;
                        }
                        setColoredFrameInstanceBlueSecondValue = true;
                        ColoredFrameInstanceBlueSecondValue = 0;
                        setColoredFrameInstanceCurrentColorCategoryStateSecondValue = true;
                        ColoredFrameInstanceCurrentColorCategoryStateSecondValue = JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Gray;
                        setColoredFrameInstanceGreenSecondValue = true;
                        ColoredFrameInstanceGreenSecondValue = 255;
                        setColoredFrameInstanceHeightSecondValue = true;
                        ColoredFrameInstanceHeightSecondValue = 0f;
                        setColoredFrameInstanceRedSecondValue = true;
                        ColoredFrameInstanceRedSecondValue = 0;
                        setColoredFrameInstanceWidthSecondValue = true;
                        ColoredFrameInstanceWidthSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            SetProperty("SpriteInstance.SourceFile", "../GlobalContent/gameicons/PNG/White/1x/forward.png");
                        }
                        break;
                    case  ToggleCategory.PushedOn:
                        if (interpolationValue >= 1)
                        {
                            this.ColoredFrameInstance.Blend = Gum.RenderingLibrary.Blend.Normal;
                        }
                        setColoredFrameInstanceBlueSecondValue = true;
                        ColoredFrameInstanceBlueSecondValue = 128;
                        setColoredFrameInstanceCurrentColorCategoryStateSecondValue = true;
                        ColoredFrameInstanceCurrentColorCategoryStateSecondValue = JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Green;
                        setColoredFrameInstanceGreenSecondValue = true;
                        ColoredFrameInstanceGreenSecondValue = 128;
                        setColoredFrameInstanceHeightSecondValue = true;
                        ColoredFrameInstanceHeightSecondValue = -6f;
                        setColoredFrameInstanceRedSecondValue = true;
                        ColoredFrameInstanceRedSecondValue = 128;
                        setColoredFrameInstanceWidthSecondValue = true;
                        ColoredFrameInstanceWidthSecondValue = -6f;
                        if (interpolationValue >= 1)
                        {
                            SetProperty("SpriteInstance.SourceFile", "../GlobalContent/gameicons/PNG/White/1x/forward.png");
                        }
                        break;
                    case  ToggleCategory.PushedOff:
                        if (interpolationValue >= 1)
                        {
                            this.ColoredFrameInstance.Blend = Gum.RenderingLibrary.Blend.Normal;
                        }
                        setColoredFrameInstanceBlueSecondValue = true;
                        ColoredFrameInstanceBlueSecondValue = 128;
                        setColoredFrameInstanceCurrentColorCategoryStateSecondValue = true;
                        ColoredFrameInstanceCurrentColorCategoryStateSecondValue = JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Black;
                        setColoredFrameInstanceGreenSecondValue = true;
                        ColoredFrameInstanceGreenSecondValue = 128;
                        setColoredFrameInstanceHeightSecondValue = true;
                        ColoredFrameInstanceHeightSecondValue = -6f;
                        setColoredFrameInstanceRedSecondValue = true;
                        ColoredFrameInstanceRedSecondValue = 128;
                        setColoredFrameInstanceWidthSecondValue = true;
                        ColoredFrameInstanceWidthSecondValue = -6f;
                        if (interpolationValue >= 1)
                        {
                            SetProperty("SpriteInstance.SourceFile", "../GlobalContent/gameicons/PNG/White/1x/pause.png");
                        }
                        break;
                }
                var wasSuppressed = mIsLayoutSuspended;
                if (wasSuppressed == false)
                {
                    SuspendLayout(true);
                }
                if (setColoredFrameInstanceBlueFirstValue && setColoredFrameInstanceBlueSecondValue)
                {
                    ColoredFrameInstance.Blue = FlatRedBall.Math.MathFunctions.RoundToInt(ColoredFrameInstanceBlueFirstValue* (1 - interpolationValue) + ColoredFrameInstanceBlueSecondValue * interpolationValue);
                }
                if (setColoredFrameInstanceCurrentColorCategoryStateFirstValue && setColoredFrameInstanceCurrentColorCategoryStateSecondValue)
                {
                    ColoredFrameInstance.InterpolateBetween(ColoredFrameInstanceCurrentColorCategoryStateFirstValue, ColoredFrameInstanceCurrentColorCategoryStateSecondValue, interpolationValue);
                }
                if (setColoredFrameInstanceGreenFirstValue && setColoredFrameInstanceGreenSecondValue)
                {
                    ColoredFrameInstance.Green = FlatRedBall.Math.MathFunctions.RoundToInt(ColoredFrameInstanceGreenFirstValue* (1 - interpolationValue) + ColoredFrameInstanceGreenSecondValue * interpolationValue);
                }
                if (setColoredFrameInstanceHeightFirstValue && setColoredFrameInstanceHeightSecondValue)
                {
                    ColoredFrameInstance.Height = ColoredFrameInstanceHeightFirstValue * (1 - interpolationValue) + ColoredFrameInstanceHeightSecondValue * interpolationValue;
                }
                if (setColoredFrameInstanceRedFirstValue && setColoredFrameInstanceRedSecondValue)
                {
                    ColoredFrameInstance.Red = FlatRedBall.Math.MathFunctions.RoundToInt(ColoredFrameInstanceRedFirstValue* (1 - interpolationValue) + ColoredFrameInstanceRedSecondValue * interpolationValue);
                }
                if (setColoredFrameInstanceWidthFirstValue && setColoredFrameInstanceWidthSecondValue)
                {
                    ColoredFrameInstance.Width = ColoredFrameInstanceWidthFirstValue * (1 - interpolationValue) + ColoredFrameInstanceWidthSecondValue * interpolationValue;
                }
                if (interpolationValue < 1)
                {
                    mCurrentToggleCategoryState = firstState;
                }
                else
                {
                    mCurrentToggleCategoryState = secondState;
                }
                if (!wasSuppressed)
                {
                    ResumeLayout(true);
                }
            }
            #endregion
            #region State Interpolate To
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (JHP4SD.GumRuntimes.LebegForms.BasicComponents.PlayButtonRuntime.VariableState fromState,JHP4SD.GumRuntimes.LebegForms.BasicComponents.PlayButtonRuntime.VariableState toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null) 
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
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (JHP4SD.GumRuntimes.LebegForms.BasicComponents.PlayButtonRuntime.ToggleCategory fromState,JHP4SD.GumRuntimes.LebegForms.BasicComponents.PlayButtonRuntime.ToggleCategory toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null) 
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
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (ToggleCategory toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null ) 
            {
                Gum.DataTypes.Variables.StateSave current = GetCurrentValuesOnState(toState);
                Gum.DataTypes.Variables.StateSave toAsStateSave = this.ElementSave.Categories.First(item => item.Name == "ToggleCategory").States.First(item => item.Name == toState.ToString());
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
                tweener.Ended += ()=> this.CurrentToggleCategoryState = toState;
                tweener.Start();
                StateInterpolationPlugin.TweenerManager.Self.Add(tweener);
                return tweener;
            }
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateToRelative (ToggleCategory toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null ) 
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
                tweener.Ended += ()=> this.CurrentToggleCategoryState = toState;
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
                ColoredFrameInstance.StopAnimations();
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
                            Name = "Height",
                            Type = "float",
                            Value = Height
                        }
                        );
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
                            Name = "ColoredFrameInstance.ColorCategoryState",
                            Type = "ColorCategoryState",
                            Value = ColoredFrameInstance.CurrentColorCategoryState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredFrameInstance.Height",
                            Type = "float",
                            Value = ColoredFrameInstance.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredFrameInstance.Height Units",
                            Type = "DimensionUnitType",
                            Value = ColoredFrameInstance.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredFrameInstance.Width",
                            Type = "float",
                            Value = ColoredFrameInstance.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredFrameInstance.Width Units",
                            Type = "DimensionUnitType",
                            Value = ColoredFrameInstance.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredFrameInstance.X",
                            Type = "float",
                            Value = ColoredFrameInstance.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredFrameInstance.X Origin",
                            Type = "HorizontalAlignment",
                            Value = ColoredFrameInstance.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredFrameInstance.X Units",
                            Type = "PositionUnitType",
                            Value = ColoredFrameInstance.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredFrameInstance.Y",
                            Type = "float",
                            Value = ColoredFrameInstance.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredFrameInstance.Y Origin",
                            Type = "VerticalAlignment",
                            Value = ColoredFrameInstance.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredFrameInstance.Y Units",
                            Type = "PositionUnitType",
                            Value = ColoredFrameInstance.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Parent",
                            Type = "string",
                            Value = SpriteInstance.Parent
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
                            Name = "SpriteInstance.Visible",
                            Type = "bool",
                            Value = SpriteInstance.Visible
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
                            Name = "SpriteInstance.X Origin",
                            Type = "HorizontalAlignment",
                            Value = SpriteInstance.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.X Units",
                            Type = "PositionUnitType",
                            Value = SpriteInstance.XUnits
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
                            Name = "SpriteInstance.Y Origin",
                            Type = "VerticalAlignment",
                            Value = SpriteInstance.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Y Units",
                            Type = "PositionUnitType",
                            Value = SpriteInstance.YUnits
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
                            Name = "Height",
                            Type = "float",
                            Value = Height + 75f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Width",
                            Type = "float",
                            Value = Width + 75f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredFrameInstance.ColorCategoryState",
                            Type = "ColorCategoryState",
                            Value = ColoredFrameInstance.CurrentColorCategoryState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredFrameInstance.Height",
                            Type = "float",
                            Value = ColoredFrameInstance.Height + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredFrameInstance.Height Units",
                            Type = "DimensionUnitType",
                            Value = ColoredFrameInstance.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredFrameInstance.Width",
                            Type = "float",
                            Value = ColoredFrameInstance.Width + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredFrameInstance.Width Units",
                            Type = "DimensionUnitType",
                            Value = ColoredFrameInstance.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredFrameInstance.X",
                            Type = "float",
                            Value = ColoredFrameInstance.X + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredFrameInstance.X Origin",
                            Type = "HorizontalAlignment",
                            Value = ColoredFrameInstance.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredFrameInstance.X Units",
                            Type = "PositionUnitType",
                            Value = ColoredFrameInstance.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredFrameInstance.Y",
                            Type = "float",
                            Value = ColoredFrameInstance.Y + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredFrameInstance.Y Origin",
                            Type = "VerticalAlignment",
                            Value = ColoredFrameInstance.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredFrameInstance.Y Units",
                            Type = "PositionUnitType",
                            Value = ColoredFrameInstance.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Parent",
                            Type = "string",
                            Value = SpriteInstance.Parent
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
                            Name = "SpriteInstance.Visible",
                            Type = "bool",
                            Value = SpriteInstance.Visible
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
                            Name = "SpriteInstance.X Origin",
                            Type = "HorizontalAlignment",
                            Value = SpriteInstance.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.X Units",
                            Type = "PositionUnitType",
                            Value = SpriteInstance.XUnits
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
                            Name = "SpriteInstance.Y Origin",
                            Type = "VerticalAlignment",
                            Value = SpriteInstance.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Y Units",
                            Type = "PositionUnitType",
                            Value = SpriteInstance.YUnits
                        }
                        );
                        break;
                }
                return newState;
            }
            private Gum.DataTypes.Variables.StateSave GetCurrentValuesOnState (ToggleCategory state) 
            {
                Gum.DataTypes.Variables.StateSave newState = new Gum.DataTypes.Variables.StateSave();
                switch(state)
                {
                    case  ToggleCategory.EnabledOn:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredFrameInstance.Blend",
                            Type = "Blend",
                            Value = ColoredFrameInstance.Blend
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredFrameInstance.Blue",
                            Type = "int",
                            Value = ColoredFrameInstance.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredFrameInstance.ColorCategoryState",
                            Type = "ColorCategoryState",
                            Value = ColoredFrameInstance.CurrentColorCategoryState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredFrameInstance.Green",
                            Type = "int",
                            Value = ColoredFrameInstance.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredFrameInstance.Height",
                            Type = "float",
                            Value = ColoredFrameInstance.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredFrameInstance.Red",
                            Type = "int",
                            Value = ColoredFrameInstance.Red
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredFrameInstance.Width",
                            Type = "float",
                            Value = ColoredFrameInstance.Width
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
                        break;
                    case  ToggleCategory.EnabledOff:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredFrameInstance.Blend",
                            Type = "Blend",
                            Value = ColoredFrameInstance.Blend
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredFrameInstance.Blue",
                            Type = "int",
                            Value = ColoredFrameInstance.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredFrameInstance.ColorCategoryState",
                            Type = "ColorCategoryState",
                            Value = ColoredFrameInstance.CurrentColorCategoryState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredFrameInstance.Green",
                            Type = "int",
                            Value = ColoredFrameInstance.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredFrameInstance.Height",
                            Type = "float",
                            Value = ColoredFrameInstance.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredFrameInstance.Red",
                            Type = "int",
                            Value = ColoredFrameInstance.Red
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredFrameInstance.Width",
                            Type = "float",
                            Value = ColoredFrameInstance.Width
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
                        break;
                    case  ToggleCategory.DisabledOn:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredFrameInstance.Blend",
                            Type = "Blend",
                            Value = ColoredFrameInstance.Blend
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredFrameInstance.Blue",
                            Type = "int",
                            Value = ColoredFrameInstance.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredFrameInstance.ColorCategoryState",
                            Type = "ColorCategoryState",
                            Value = ColoredFrameInstance.CurrentColorCategoryState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredFrameInstance.Green",
                            Type = "int",
                            Value = ColoredFrameInstance.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredFrameInstance.Height",
                            Type = "float",
                            Value = ColoredFrameInstance.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredFrameInstance.Red",
                            Type = "int",
                            Value = ColoredFrameInstance.Red
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredFrameInstance.Width",
                            Type = "float",
                            Value = ColoredFrameInstance.Width
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
                        break;
                    case  ToggleCategory.DisabledOff:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredFrameInstance.Blend",
                            Type = "Blend",
                            Value = ColoredFrameInstance.Blend
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredFrameInstance.Blue",
                            Type = "int",
                            Value = ColoredFrameInstance.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredFrameInstance.ColorCategoryState",
                            Type = "ColorCategoryState",
                            Value = ColoredFrameInstance.CurrentColorCategoryState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredFrameInstance.Green",
                            Type = "int",
                            Value = ColoredFrameInstance.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredFrameInstance.Height",
                            Type = "float",
                            Value = ColoredFrameInstance.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredFrameInstance.Red",
                            Type = "int",
                            Value = ColoredFrameInstance.Red
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredFrameInstance.Width",
                            Type = "float",
                            Value = ColoredFrameInstance.Width
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
                        break;
                    case  ToggleCategory.HighlightedOn:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredFrameInstance.Blue",
                            Type = "int",
                            Value = ColoredFrameInstance.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredFrameInstance.ColorCategoryState",
                            Type = "ColorCategoryState",
                            Value = ColoredFrameInstance.CurrentColorCategoryState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredFrameInstance.Green",
                            Type = "int",
                            Value = ColoredFrameInstance.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredFrameInstance.Height",
                            Type = "float",
                            Value = ColoredFrameInstance.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredFrameInstance.Red",
                            Type = "int",
                            Value = ColoredFrameInstance.Red
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredFrameInstance.Width",
                            Type = "float",
                            Value = ColoredFrameInstance.Width
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
                        break;
                    case  ToggleCategory.HighlightedOff:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredFrameInstance.Blend",
                            Type = "Blend",
                            Value = ColoredFrameInstance.Blend
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredFrameInstance.Blue",
                            Type = "int",
                            Value = ColoredFrameInstance.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredFrameInstance.ColorCategoryState",
                            Type = "ColorCategoryState",
                            Value = ColoredFrameInstance.CurrentColorCategoryState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredFrameInstance.Green",
                            Type = "int",
                            Value = ColoredFrameInstance.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredFrameInstance.Height",
                            Type = "float",
                            Value = ColoredFrameInstance.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredFrameInstance.Red",
                            Type = "int",
                            Value = ColoredFrameInstance.Red
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredFrameInstance.Width",
                            Type = "float",
                            Value = ColoredFrameInstance.Width
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
                        break;
                    case  ToggleCategory.PushedOn:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredFrameInstance.Blend",
                            Type = "Blend",
                            Value = ColoredFrameInstance.Blend
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredFrameInstance.Blue",
                            Type = "int",
                            Value = ColoredFrameInstance.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredFrameInstance.ColorCategoryState",
                            Type = "ColorCategoryState",
                            Value = ColoredFrameInstance.CurrentColorCategoryState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredFrameInstance.Green",
                            Type = "int",
                            Value = ColoredFrameInstance.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredFrameInstance.Height",
                            Type = "float",
                            Value = ColoredFrameInstance.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredFrameInstance.Red",
                            Type = "int",
                            Value = ColoredFrameInstance.Red
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredFrameInstance.Width",
                            Type = "float",
                            Value = ColoredFrameInstance.Width
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
                        break;
                    case  ToggleCategory.PushedOff:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredFrameInstance.Blend",
                            Type = "Blend",
                            Value = ColoredFrameInstance.Blend
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredFrameInstance.Blue",
                            Type = "int",
                            Value = ColoredFrameInstance.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredFrameInstance.ColorCategoryState",
                            Type = "ColorCategoryState",
                            Value = ColoredFrameInstance.CurrentColorCategoryState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredFrameInstance.Green",
                            Type = "int",
                            Value = ColoredFrameInstance.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredFrameInstance.Height",
                            Type = "float",
                            Value = ColoredFrameInstance.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredFrameInstance.Red",
                            Type = "int",
                            Value = ColoredFrameInstance.Red
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredFrameInstance.Width",
                            Type = "float",
                            Value = ColoredFrameInstance.Width
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
                        break;
                }
                return newState;
            }
            private Gum.DataTypes.Variables.StateSave AddToCurrentValuesWithState (ToggleCategory state) 
            {
                Gum.DataTypes.Variables.StateSave newState = new Gum.DataTypes.Variables.StateSave();
                switch(state)
                {
                    case  ToggleCategory.EnabledOn:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredFrameInstance.Blend",
                            Type = "Blend",
                            Value = ColoredFrameInstance.Blend
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredFrameInstance.Blue",
                            Type = "int",
                            Value = ColoredFrameInstance.Blue + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredFrameInstance.ColorCategoryState",
                            Type = "ColorCategoryState",
                            Value = ColoredFrameInstance.CurrentColorCategoryState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredFrameInstance.Green",
                            Type = "int",
                            Value = ColoredFrameInstance.Green + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredFrameInstance.Height",
                            Type = "float",
                            Value = ColoredFrameInstance.Height + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredFrameInstance.Red",
                            Type = "int",
                            Value = ColoredFrameInstance.Red + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredFrameInstance.Width",
                            Type = "float",
                            Value = ColoredFrameInstance.Width + 0f
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
                        break;
                    case  ToggleCategory.EnabledOff:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredFrameInstance.Blend",
                            Type = "Blend",
                            Value = ColoredFrameInstance.Blend
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredFrameInstance.Blue",
                            Type = "int",
                            Value = ColoredFrameInstance.Blue + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredFrameInstance.ColorCategoryState",
                            Type = "ColorCategoryState",
                            Value = ColoredFrameInstance.CurrentColorCategoryState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredFrameInstance.Green",
                            Type = "int",
                            Value = ColoredFrameInstance.Green + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredFrameInstance.Height",
                            Type = "float",
                            Value = ColoredFrameInstance.Height + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredFrameInstance.Red",
                            Type = "int",
                            Value = ColoredFrameInstance.Red + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredFrameInstance.Width",
                            Type = "float",
                            Value = ColoredFrameInstance.Width + 0f
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
                        break;
                    case  ToggleCategory.DisabledOn:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredFrameInstance.Blend",
                            Type = "Blend",
                            Value = ColoredFrameInstance.Blend
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredFrameInstance.Blue",
                            Type = "int",
                            Value = ColoredFrameInstance.Blue + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredFrameInstance.ColorCategoryState",
                            Type = "ColorCategoryState",
                            Value = ColoredFrameInstance.CurrentColorCategoryState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredFrameInstance.Green",
                            Type = "int",
                            Value = ColoredFrameInstance.Green + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredFrameInstance.Height",
                            Type = "float",
                            Value = ColoredFrameInstance.Height + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredFrameInstance.Red",
                            Type = "int",
                            Value = ColoredFrameInstance.Red + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredFrameInstance.Width",
                            Type = "float",
                            Value = ColoredFrameInstance.Width + 0f
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
                        break;
                    case  ToggleCategory.DisabledOff:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredFrameInstance.Blend",
                            Type = "Blend",
                            Value = ColoredFrameInstance.Blend
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredFrameInstance.Blue",
                            Type = "int",
                            Value = ColoredFrameInstance.Blue + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredFrameInstance.ColorCategoryState",
                            Type = "ColorCategoryState",
                            Value = ColoredFrameInstance.CurrentColorCategoryState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredFrameInstance.Green",
                            Type = "int",
                            Value = ColoredFrameInstance.Green + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredFrameInstance.Height",
                            Type = "float",
                            Value = ColoredFrameInstance.Height + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredFrameInstance.Red",
                            Type = "int",
                            Value = ColoredFrameInstance.Red + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredFrameInstance.Width",
                            Type = "float",
                            Value = ColoredFrameInstance.Width + 0f
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
                        break;
                    case  ToggleCategory.HighlightedOn:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredFrameInstance.Blue",
                            Type = "int",
                            Value = ColoredFrameInstance.Blue + 128
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredFrameInstance.ColorCategoryState",
                            Type = "ColorCategoryState",
                            Value = ColoredFrameInstance.CurrentColorCategoryState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredFrameInstance.Green",
                            Type = "int",
                            Value = ColoredFrameInstance.Green + 128
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredFrameInstance.Height",
                            Type = "float",
                            Value = ColoredFrameInstance.Height + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredFrameInstance.Red",
                            Type = "int",
                            Value = ColoredFrameInstance.Red + 128
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredFrameInstance.Width",
                            Type = "float",
                            Value = ColoredFrameInstance.Width + 0f
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
                        break;
                    case  ToggleCategory.HighlightedOff:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredFrameInstance.Blend",
                            Type = "Blend",
                            Value = ColoredFrameInstance.Blend
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredFrameInstance.Blue",
                            Type = "int",
                            Value = ColoredFrameInstance.Blue + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredFrameInstance.ColorCategoryState",
                            Type = "ColorCategoryState",
                            Value = ColoredFrameInstance.CurrentColorCategoryState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredFrameInstance.Green",
                            Type = "int",
                            Value = ColoredFrameInstance.Green + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredFrameInstance.Height",
                            Type = "float",
                            Value = ColoredFrameInstance.Height + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredFrameInstance.Red",
                            Type = "int",
                            Value = ColoredFrameInstance.Red + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredFrameInstance.Width",
                            Type = "float",
                            Value = ColoredFrameInstance.Width + 0f
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
                        break;
                    case  ToggleCategory.PushedOn:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredFrameInstance.Blend",
                            Type = "Blend",
                            Value = ColoredFrameInstance.Blend
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredFrameInstance.Blue",
                            Type = "int",
                            Value = ColoredFrameInstance.Blue + 128
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredFrameInstance.ColorCategoryState",
                            Type = "ColorCategoryState",
                            Value = ColoredFrameInstance.CurrentColorCategoryState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredFrameInstance.Green",
                            Type = "int",
                            Value = ColoredFrameInstance.Green + 128
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredFrameInstance.Height",
                            Type = "float",
                            Value = ColoredFrameInstance.Height + -6f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredFrameInstance.Red",
                            Type = "int",
                            Value = ColoredFrameInstance.Red + 128
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredFrameInstance.Width",
                            Type = "float",
                            Value = ColoredFrameInstance.Width + -6f
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
                        break;
                    case  ToggleCategory.PushedOff:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredFrameInstance.Blend",
                            Type = "Blend",
                            Value = ColoredFrameInstance.Blend
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredFrameInstance.Blue",
                            Type = "int",
                            Value = ColoredFrameInstance.Blue + 128
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredFrameInstance.ColorCategoryState",
                            Type = "ColorCategoryState",
                            Value = ColoredFrameInstance.CurrentColorCategoryState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredFrameInstance.Green",
                            Type = "int",
                            Value = ColoredFrameInstance.Green + 128
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredFrameInstance.Height",
                            Type = "float",
                            Value = ColoredFrameInstance.Height + -6f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredFrameInstance.Red",
                            Type = "int",
                            Value = ColoredFrameInstance.Red + 128
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredFrameInstance.Width",
                            Type = "float",
                            Value = ColoredFrameInstance.Width + -6f
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
                    else if (category.Name == "ToggleCategory")
                    {
                        if(state.Name == "EnabledOn") this.mCurrentToggleCategoryState = ToggleCategory.EnabledOn;
                        if(state.Name == "EnabledOff") this.mCurrentToggleCategoryState = ToggleCategory.EnabledOff;
                        if(state.Name == "DisabledOn") this.mCurrentToggleCategoryState = ToggleCategory.DisabledOn;
                        if(state.Name == "DisabledOff") this.mCurrentToggleCategoryState = ToggleCategory.DisabledOff;
                        if(state.Name == "HighlightedOn") this.mCurrentToggleCategoryState = ToggleCategory.HighlightedOn;
                        if(state.Name == "HighlightedOff") this.mCurrentToggleCategoryState = ToggleCategory.HighlightedOff;
                        if(state.Name == "PushedOn") this.mCurrentToggleCategoryState = ToggleCategory.PushedOn;
                        if(state.Name == "PushedOff") this.mCurrentToggleCategoryState = ToggleCategory.PushedOff;
                    }
                }
                base.ApplyState(state);
            }
            private bool tryCreateFormsObject;
            public JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime ColoredFrameInstance { get; set; }
            public JHP4SD.GumRuntimes.SpriteRuntime SpriteInstance { get; set; }
            public PlayButtonRuntime (bool fullInstantiation = true, bool tryCreateFormsObject = true) 
            	: base(false, tryCreateFormsObject)
            {
                this.tryCreateFormsObject = tryCreateFormsObject;
                if (fullInstantiation)
                {
                    Gum.DataTypes.ElementSave elementSave = Gum.Managers.ObjectFinder.Self.GumProjectSave.Components.First(item => item.Name == "LebegForms/BasicComponents/PlayButton");
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
                ColoredFrameInstance = this.GetGraphicalUiElementByName("ColoredFrameInstance") as JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime;
                SpriteInstance = this.GetGraphicalUiElementByName("SpriteInstance") as JHP4SD.GumRuntimes.SpriteRuntime;
                if (tryCreateFormsObject)
                {
                    FormsControlAsObject = new FlatRedBall.Forms.Controls.ToggleButton(this);
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
            public FlatRedBall.Forms.Controls.ToggleButton FormsControl {get => (FlatRedBall.Forms.Controls.ToggleButton) FormsControlAsObject;}
        }
    }
