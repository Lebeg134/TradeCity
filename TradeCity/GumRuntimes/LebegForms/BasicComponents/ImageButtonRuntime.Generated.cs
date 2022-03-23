    using System.Linq;
    namespace JHP4SD.GumRuntimes.LebegForms.BasicComponents
    {
        public partial class ImageButtonRuntime : JHP4SD.GumRuntimes.ContainerRuntime
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
                Focused,
                DisabledFocused
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
                            NineSliceInstance.CurrentColorCategoryState = JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Gray;
                            Height = 56f;
                            Width = 56f;
                            X = 0f;
                            Y = 0f;
                            NineSliceInstance.Blue = 170;
                            NineSliceInstance.Green = 205;
                            NineSliceInstance.Height = 0f;
                            NineSliceInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                            NineSliceInstance.Red = 102;
                            NineSliceInstance.Width = 0f;
                            NineSliceInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                            NineSliceInstance.X = 0f;
                            NineSliceInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                            NineSliceInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            NineSliceInstance.Y = 0f;
                            NineSliceInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            NineSliceInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            HighlightRectangle.Height = -6f;
                            HighlightRectangle.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                            HighlightRectangle.Visible = false;
                            HighlightRectangle.Width = -6f;
                            HighlightRectangle.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                            HighlightRectangle.X = 0f;
                            HighlightRectangle.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                            HighlightRectangle.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            HighlightRectangle.Y = -1f;
                            HighlightRectangle.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            HighlightRectangle.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            SpriteInstance.Height = 48f;
                            SpriteInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                            SpriteInstance.Width = 48f;
                            SpriteInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                            SpriteInstance.X = 4f;
                            SpriteInstance.Y = 4f;
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
                                NineSliceInstance.CurrentColorCategoryState = JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Blue;
                                NineSliceInstance.Blue = 255;
                                NineSliceInstance.Green = 255;
                                NineSliceInstance.Red = 255;
                                HighlightRectangle.Visible = false;
                                break;
                            case  ButtonCategory.Disabled:
                                NineSliceInstance.CurrentColorCategoryState = JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Black;
                                NineSliceInstance.Blue = 255;
                                NineSliceInstance.Green = 255;
                                NineSliceInstance.Red = 255;
                                HighlightRectangle.Visible = false;
                                break;
                            case  ButtonCategory.Highlighted:
                                NineSliceInstance.CurrentColorCategoryState = JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Yellow;
                                NineSliceInstance.Blue = 255;
                                NineSliceInstance.Green = 255;
                                NineSliceInstance.Red = 255;
                                HighlightRectangle.Visible = false;
                                break;
                            case  ButtonCategory.Pushed:
                                NineSliceInstance.CurrentColorCategoryState = JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Yellow;
                                NineSliceInstance.Blue = 200;
                                NineSliceInstance.Green = 200;
                                NineSliceInstance.Red = 200;
                                HighlightRectangle.Visible = false;
                                break;
                            case  ButtonCategory.HighlightedFocused:
                                NineSliceInstance.CurrentColorCategoryState = JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Yellow;
                                NineSliceInstance.Blue = 255;
                                NineSliceInstance.Green = 255;
                                NineSliceInstance.Red = 255;
                                HighlightRectangle.Visible = true;
                                break;
                            case  ButtonCategory.Focused:
                                NineSliceInstance.CurrentColorCategoryState = JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Blue;
                                NineSliceInstance.Blue = 255;
                                NineSliceInstance.Green = 255;
                                NineSliceInstance.Red = 255;
                                HighlightRectangle.Visible = true;
                                break;
                            case  ButtonCategory.DisabledFocused:
                                NineSliceInstance.CurrentColorCategoryState = JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Black;
                                NineSliceInstance.Blue = 255;
                                NineSliceInstance.Green = 255;
                                NineSliceInstance.Red = 255;
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
                bool setHeightFirstValue = false;
                bool setHeightSecondValue = false;
                float HeightFirstValue= 0;
                float HeightSecondValue= 0;
                bool setHighlightRectangleHeightFirstValue = false;
                bool setHighlightRectangleHeightSecondValue = false;
                float HighlightRectangleHeightFirstValue= 0;
                float HighlightRectangleHeightSecondValue= 0;
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
                bool setNineSliceInstanceBlueFirstValue = false;
                bool setNineSliceInstanceBlueSecondValue = false;
                int NineSliceInstanceBlueFirstValue= 0;
                int NineSliceInstanceBlueSecondValue= 0;
                bool setNineSliceInstanceCurrentColorCategoryStateFirstValue = false;
                bool setNineSliceInstanceCurrentColorCategoryStateSecondValue = false;
                JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory NineSliceInstanceCurrentColorCategoryStateFirstValue= JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Gray;
                JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory NineSliceInstanceCurrentColorCategoryStateSecondValue= JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Gray;
                bool setNineSliceInstanceGreenFirstValue = false;
                bool setNineSliceInstanceGreenSecondValue = false;
                int NineSliceInstanceGreenFirstValue= 0;
                int NineSliceInstanceGreenSecondValue= 0;
                bool setNineSliceInstanceHeightFirstValue = false;
                bool setNineSliceInstanceHeightSecondValue = false;
                float NineSliceInstanceHeightFirstValue= 0;
                float NineSliceInstanceHeightSecondValue= 0;
                bool setNineSliceInstanceRedFirstValue = false;
                bool setNineSliceInstanceRedSecondValue = false;
                int NineSliceInstanceRedFirstValue= 0;
                int NineSliceInstanceRedSecondValue= 0;
                bool setNineSliceInstanceWidthFirstValue = false;
                bool setNineSliceInstanceWidthSecondValue = false;
                float NineSliceInstanceWidthFirstValue= 0;
                float NineSliceInstanceWidthSecondValue= 0;
                bool setNineSliceInstanceXFirstValue = false;
                bool setNineSliceInstanceXSecondValue = false;
                float NineSliceInstanceXFirstValue= 0;
                float NineSliceInstanceXSecondValue= 0;
                bool setNineSliceInstanceYFirstValue = false;
                bool setNineSliceInstanceYSecondValue = false;
                float NineSliceInstanceYFirstValue= 0;
                float NineSliceInstanceYSecondValue= 0;
                bool setSpriteInstanceHeightFirstValue = false;
                bool setSpriteInstanceHeightSecondValue = false;
                float SpriteInstanceHeightFirstValue= 0;
                float SpriteInstanceHeightSecondValue= 0;
                bool setSpriteInstanceWidthFirstValue = false;
                bool setSpriteInstanceWidthSecondValue = false;
                float SpriteInstanceWidthFirstValue= 0;
                float SpriteInstanceWidthSecondValue= 0;
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
                bool setXFirstValue = false;
                bool setXSecondValue = false;
                float XFirstValue= 0;
                float XSecondValue= 0;
                bool setYFirstValue = false;
                bool setYSecondValue = false;
                float YFirstValue= 0;
                float YSecondValue= 0;
                switch(firstState)
                {
                    case  VariableState.Default:
                        setHeightFirstValue = true;
                        HeightFirstValue = 56f;
                        setHighlightRectangleHeightFirstValue = true;
                        HighlightRectangleHeightFirstValue = -6f;
                        if (interpolationValue < 1)
                        {
                            this.HighlightRectangle.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        if (interpolationValue < 1)
                        {
                            this.HighlightRectangle.Visible = false;
                        }
                        setHighlightRectangleWidthFirstValue = true;
                        HighlightRectangleWidthFirstValue = -6f;
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
                        HighlightRectangleYFirstValue = -1f;
                        if (interpolationValue < 1)
                        {
                            this.HighlightRectangle.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.HighlightRectangle.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setNineSliceInstanceBlueFirstValue = true;
                        NineSliceInstanceBlueFirstValue = 170;
                        setNineSliceInstanceCurrentColorCategoryStateFirstValue = true;
                        NineSliceInstanceCurrentColorCategoryStateFirstValue = JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Gray;
                        setNineSliceInstanceGreenFirstValue = true;
                        NineSliceInstanceGreenFirstValue = 205;
                        setNineSliceInstanceHeightFirstValue = true;
                        NineSliceInstanceHeightFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.NineSliceInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        setNineSliceInstanceRedFirstValue = true;
                        NineSliceInstanceRedFirstValue = 102;
                        setNineSliceInstanceWidthFirstValue = true;
                        NineSliceInstanceWidthFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.NineSliceInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        setNineSliceInstanceXFirstValue = true;
                        NineSliceInstanceXFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.NineSliceInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.NineSliceInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setNineSliceInstanceYFirstValue = true;
                        NineSliceInstanceYFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.NineSliceInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.NineSliceInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setSpriteInstanceHeightFirstValue = true;
                        SpriteInstanceHeightFirstValue = 48f;
                        if (interpolationValue < 1)
                        {
                            this.SpriteInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        setSpriteInstanceWidthFirstValue = true;
                        SpriteInstanceWidthFirstValue = 48f;
                        if (interpolationValue < 1)
                        {
                            this.SpriteInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        setSpriteInstanceXFirstValue = true;
                        SpriteInstanceXFirstValue = 4f;
                        setSpriteInstanceYFirstValue = true;
                        SpriteInstanceYFirstValue = 4f;
                        setWidthFirstValue = true;
                        WidthFirstValue = 56f;
                        setXFirstValue = true;
                        XFirstValue = 0f;
                        setYFirstValue = true;
                        YFirstValue = 0f;
                        break;
                }
                switch(secondState)
                {
                    case  VariableState.Default:
                        setHeightSecondValue = true;
                        HeightSecondValue = 56f;
                        setHighlightRectangleHeightSecondValue = true;
                        HighlightRectangleHeightSecondValue = -6f;
                        if (interpolationValue >= 1)
                        {
                            this.HighlightRectangle.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.HighlightRectangle.Visible = false;
                        }
                        setHighlightRectangleWidthSecondValue = true;
                        HighlightRectangleWidthSecondValue = -6f;
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
                        HighlightRectangleYSecondValue = -1f;
                        if (interpolationValue >= 1)
                        {
                            this.HighlightRectangle.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.HighlightRectangle.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setNineSliceInstanceBlueSecondValue = true;
                        NineSliceInstanceBlueSecondValue = 170;
                        setNineSliceInstanceCurrentColorCategoryStateSecondValue = true;
                        NineSliceInstanceCurrentColorCategoryStateSecondValue = JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Gray;
                        setNineSliceInstanceGreenSecondValue = true;
                        NineSliceInstanceGreenSecondValue = 205;
                        setNineSliceInstanceHeightSecondValue = true;
                        NineSliceInstanceHeightSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.NineSliceInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        setNineSliceInstanceRedSecondValue = true;
                        NineSliceInstanceRedSecondValue = 102;
                        setNineSliceInstanceWidthSecondValue = true;
                        NineSliceInstanceWidthSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.NineSliceInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        setNineSliceInstanceXSecondValue = true;
                        NineSliceInstanceXSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.NineSliceInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.NineSliceInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setNineSliceInstanceYSecondValue = true;
                        NineSliceInstanceYSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.NineSliceInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.NineSliceInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setSpriteInstanceHeightSecondValue = true;
                        SpriteInstanceHeightSecondValue = 48f;
                        if (interpolationValue >= 1)
                        {
                            this.SpriteInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        setSpriteInstanceWidthSecondValue = true;
                        SpriteInstanceWidthSecondValue = 48f;
                        if (interpolationValue >= 1)
                        {
                            this.SpriteInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        setSpriteInstanceXSecondValue = true;
                        SpriteInstanceXSecondValue = 4f;
                        setSpriteInstanceYSecondValue = true;
                        SpriteInstanceYSecondValue = 4f;
                        setWidthSecondValue = true;
                        WidthSecondValue = 56f;
                        setXSecondValue = true;
                        XSecondValue = 0f;
                        setYSecondValue = true;
                        YSecondValue = 0f;
                        break;
                }
                var wasSuppressed = mIsLayoutSuspended;
                if (wasSuppressed == false)
                {
                    SuspendLayout(true);
                }
                if (setHeightFirstValue && setHeightSecondValue)
                {
                    Height = HeightFirstValue * (1 - interpolationValue) + HeightSecondValue * interpolationValue;
                }
                if (setHighlightRectangleHeightFirstValue && setHighlightRectangleHeightSecondValue)
                {
                    HighlightRectangle.Height = HighlightRectangleHeightFirstValue * (1 - interpolationValue) + HighlightRectangleHeightSecondValue * interpolationValue;
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
                if (setNineSliceInstanceBlueFirstValue && setNineSliceInstanceBlueSecondValue)
                {
                    NineSliceInstance.Blue = FlatRedBall.Math.MathFunctions.RoundToInt(NineSliceInstanceBlueFirstValue* (1 - interpolationValue) + NineSliceInstanceBlueSecondValue * interpolationValue);
                }
                if (setNineSliceInstanceCurrentColorCategoryStateFirstValue && setNineSliceInstanceCurrentColorCategoryStateSecondValue)
                {
                    NineSliceInstance.InterpolateBetween(NineSliceInstanceCurrentColorCategoryStateFirstValue, NineSliceInstanceCurrentColorCategoryStateSecondValue, interpolationValue);
                }
                if (setNineSliceInstanceGreenFirstValue && setNineSliceInstanceGreenSecondValue)
                {
                    NineSliceInstance.Green = FlatRedBall.Math.MathFunctions.RoundToInt(NineSliceInstanceGreenFirstValue* (1 - interpolationValue) + NineSliceInstanceGreenSecondValue * interpolationValue);
                }
                if (setNineSliceInstanceHeightFirstValue && setNineSliceInstanceHeightSecondValue)
                {
                    NineSliceInstance.Height = NineSliceInstanceHeightFirstValue * (1 - interpolationValue) + NineSliceInstanceHeightSecondValue * interpolationValue;
                }
                if (setNineSliceInstanceRedFirstValue && setNineSliceInstanceRedSecondValue)
                {
                    NineSliceInstance.Red = FlatRedBall.Math.MathFunctions.RoundToInt(NineSliceInstanceRedFirstValue* (1 - interpolationValue) + NineSliceInstanceRedSecondValue * interpolationValue);
                }
                if (setNineSliceInstanceWidthFirstValue && setNineSliceInstanceWidthSecondValue)
                {
                    NineSliceInstance.Width = NineSliceInstanceWidthFirstValue * (1 - interpolationValue) + NineSliceInstanceWidthSecondValue * interpolationValue;
                }
                if (setNineSliceInstanceXFirstValue && setNineSliceInstanceXSecondValue)
                {
                    NineSliceInstance.X = NineSliceInstanceXFirstValue * (1 - interpolationValue) + NineSliceInstanceXSecondValue * interpolationValue;
                }
                if (setNineSliceInstanceYFirstValue && setNineSliceInstanceYSecondValue)
                {
                    NineSliceInstance.Y = NineSliceInstanceYFirstValue * (1 - interpolationValue) + NineSliceInstanceYSecondValue * interpolationValue;
                }
                if (setSpriteInstanceHeightFirstValue && setSpriteInstanceHeightSecondValue)
                {
                    SpriteInstance.Height = SpriteInstanceHeightFirstValue * (1 - interpolationValue) + SpriteInstanceHeightSecondValue * interpolationValue;
                }
                if (setSpriteInstanceWidthFirstValue && setSpriteInstanceWidthSecondValue)
                {
                    SpriteInstance.Width = SpriteInstanceWidthFirstValue * (1 - interpolationValue) + SpriteInstanceWidthSecondValue * interpolationValue;
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
                if (setXFirstValue && setXSecondValue)
                {
                    X = XFirstValue * (1 - interpolationValue) + XSecondValue * interpolationValue;
                }
                if (setYFirstValue && setYSecondValue)
                {
                    Y = YFirstValue * (1 - interpolationValue) + YSecondValue * interpolationValue;
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
                bool setNineSliceInstanceBlueFirstValue = false;
                bool setNineSliceInstanceBlueSecondValue = false;
                int NineSliceInstanceBlueFirstValue= 0;
                int NineSliceInstanceBlueSecondValue= 0;
                bool setNineSliceInstanceCurrentColorCategoryStateFirstValue = false;
                bool setNineSliceInstanceCurrentColorCategoryStateSecondValue = false;
                JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory NineSliceInstanceCurrentColorCategoryStateFirstValue= JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Gray;
                JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory NineSliceInstanceCurrentColorCategoryStateSecondValue= JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Gray;
                bool setNineSliceInstanceGreenFirstValue = false;
                bool setNineSliceInstanceGreenSecondValue = false;
                int NineSliceInstanceGreenFirstValue= 0;
                int NineSliceInstanceGreenSecondValue= 0;
                bool setNineSliceInstanceRedFirstValue = false;
                bool setNineSliceInstanceRedSecondValue = false;
                int NineSliceInstanceRedFirstValue= 0;
                int NineSliceInstanceRedSecondValue= 0;
                switch(firstState)
                {
                    case  ButtonCategory.Enabled:
                        if (interpolationValue < 1)
                        {
                            this.HighlightRectangle.Visible = false;
                        }
                        setNineSliceInstanceBlueFirstValue = true;
                        NineSliceInstanceBlueFirstValue = 255;
                        setNineSliceInstanceCurrentColorCategoryStateFirstValue = true;
                        NineSliceInstanceCurrentColorCategoryStateFirstValue = JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Blue;
                        setNineSliceInstanceGreenFirstValue = true;
                        NineSliceInstanceGreenFirstValue = 255;
                        setNineSliceInstanceRedFirstValue = true;
                        NineSliceInstanceRedFirstValue = 255;
                        break;
                    case  ButtonCategory.Disabled:
                        if (interpolationValue < 1)
                        {
                            this.HighlightRectangle.Visible = false;
                        }
                        setNineSliceInstanceBlueFirstValue = true;
                        NineSliceInstanceBlueFirstValue = 255;
                        setNineSliceInstanceCurrentColorCategoryStateFirstValue = true;
                        NineSliceInstanceCurrentColorCategoryStateFirstValue = JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Black;
                        setNineSliceInstanceGreenFirstValue = true;
                        NineSliceInstanceGreenFirstValue = 255;
                        setNineSliceInstanceRedFirstValue = true;
                        NineSliceInstanceRedFirstValue = 255;
                        break;
                    case  ButtonCategory.Highlighted:
                        if (interpolationValue < 1)
                        {
                            this.HighlightRectangle.Visible = false;
                        }
                        setNineSliceInstanceBlueFirstValue = true;
                        NineSliceInstanceBlueFirstValue = 255;
                        setNineSliceInstanceCurrentColorCategoryStateFirstValue = true;
                        NineSliceInstanceCurrentColorCategoryStateFirstValue = JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Yellow;
                        setNineSliceInstanceGreenFirstValue = true;
                        NineSliceInstanceGreenFirstValue = 255;
                        setNineSliceInstanceRedFirstValue = true;
                        NineSliceInstanceRedFirstValue = 255;
                        break;
                    case  ButtonCategory.Pushed:
                        if (interpolationValue < 1)
                        {
                            this.HighlightRectangle.Visible = false;
                        }
                        setNineSliceInstanceBlueFirstValue = true;
                        NineSliceInstanceBlueFirstValue = 200;
                        setNineSliceInstanceCurrentColorCategoryStateFirstValue = true;
                        NineSliceInstanceCurrentColorCategoryStateFirstValue = JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Yellow;
                        setNineSliceInstanceGreenFirstValue = true;
                        NineSliceInstanceGreenFirstValue = 200;
                        setNineSliceInstanceRedFirstValue = true;
                        NineSliceInstanceRedFirstValue = 200;
                        break;
                    case  ButtonCategory.HighlightedFocused:
                        if (interpolationValue < 1)
                        {
                            this.HighlightRectangle.Visible = true;
                        }
                        setNineSliceInstanceBlueFirstValue = true;
                        NineSliceInstanceBlueFirstValue = 255;
                        setNineSliceInstanceCurrentColorCategoryStateFirstValue = true;
                        NineSliceInstanceCurrentColorCategoryStateFirstValue = JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Yellow;
                        setNineSliceInstanceGreenFirstValue = true;
                        NineSliceInstanceGreenFirstValue = 255;
                        setNineSliceInstanceRedFirstValue = true;
                        NineSliceInstanceRedFirstValue = 255;
                        break;
                    case  ButtonCategory.Focused:
                        if (interpolationValue < 1)
                        {
                            this.HighlightRectangle.Visible = true;
                        }
                        setNineSliceInstanceBlueFirstValue = true;
                        NineSliceInstanceBlueFirstValue = 255;
                        setNineSliceInstanceCurrentColorCategoryStateFirstValue = true;
                        NineSliceInstanceCurrentColorCategoryStateFirstValue = JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Blue;
                        setNineSliceInstanceGreenFirstValue = true;
                        NineSliceInstanceGreenFirstValue = 255;
                        setNineSliceInstanceRedFirstValue = true;
                        NineSliceInstanceRedFirstValue = 255;
                        break;
                    case  ButtonCategory.DisabledFocused:
                        if (interpolationValue < 1)
                        {
                            this.HighlightRectangle.Visible = true;
                        }
                        setNineSliceInstanceBlueFirstValue = true;
                        NineSliceInstanceBlueFirstValue = 255;
                        setNineSliceInstanceCurrentColorCategoryStateFirstValue = true;
                        NineSliceInstanceCurrentColorCategoryStateFirstValue = JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Black;
                        setNineSliceInstanceGreenFirstValue = true;
                        NineSliceInstanceGreenFirstValue = 255;
                        setNineSliceInstanceRedFirstValue = true;
                        NineSliceInstanceRedFirstValue = 255;
                        break;
                }
                switch(secondState)
                {
                    case  ButtonCategory.Enabled:
                        if (interpolationValue >= 1)
                        {
                            this.HighlightRectangle.Visible = false;
                        }
                        setNineSliceInstanceBlueSecondValue = true;
                        NineSliceInstanceBlueSecondValue = 255;
                        setNineSliceInstanceCurrentColorCategoryStateSecondValue = true;
                        NineSliceInstanceCurrentColorCategoryStateSecondValue = JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Blue;
                        setNineSliceInstanceGreenSecondValue = true;
                        NineSliceInstanceGreenSecondValue = 255;
                        setNineSliceInstanceRedSecondValue = true;
                        NineSliceInstanceRedSecondValue = 255;
                        break;
                    case  ButtonCategory.Disabled:
                        if (interpolationValue >= 1)
                        {
                            this.HighlightRectangle.Visible = false;
                        }
                        setNineSliceInstanceBlueSecondValue = true;
                        NineSliceInstanceBlueSecondValue = 255;
                        setNineSliceInstanceCurrentColorCategoryStateSecondValue = true;
                        NineSliceInstanceCurrentColorCategoryStateSecondValue = JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Black;
                        setNineSliceInstanceGreenSecondValue = true;
                        NineSliceInstanceGreenSecondValue = 255;
                        setNineSliceInstanceRedSecondValue = true;
                        NineSliceInstanceRedSecondValue = 255;
                        break;
                    case  ButtonCategory.Highlighted:
                        if (interpolationValue >= 1)
                        {
                            this.HighlightRectangle.Visible = false;
                        }
                        setNineSliceInstanceBlueSecondValue = true;
                        NineSliceInstanceBlueSecondValue = 255;
                        setNineSliceInstanceCurrentColorCategoryStateSecondValue = true;
                        NineSliceInstanceCurrentColorCategoryStateSecondValue = JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Yellow;
                        setNineSliceInstanceGreenSecondValue = true;
                        NineSliceInstanceGreenSecondValue = 255;
                        setNineSliceInstanceRedSecondValue = true;
                        NineSliceInstanceRedSecondValue = 255;
                        break;
                    case  ButtonCategory.Pushed:
                        if (interpolationValue >= 1)
                        {
                            this.HighlightRectangle.Visible = false;
                        }
                        setNineSliceInstanceBlueSecondValue = true;
                        NineSliceInstanceBlueSecondValue = 200;
                        setNineSliceInstanceCurrentColorCategoryStateSecondValue = true;
                        NineSliceInstanceCurrentColorCategoryStateSecondValue = JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Yellow;
                        setNineSliceInstanceGreenSecondValue = true;
                        NineSliceInstanceGreenSecondValue = 200;
                        setNineSliceInstanceRedSecondValue = true;
                        NineSliceInstanceRedSecondValue = 200;
                        break;
                    case  ButtonCategory.HighlightedFocused:
                        if (interpolationValue >= 1)
                        {
                            this.HighlightRectangle.Visible = true;
                        }
                        setNineSliceInstanceBlueSecondValue = true;
                        NineSliceInstanceBlueSecondValue = 255;
                        setNineSliceInstanceCurrentColorCategoryStateSecondValue = true;
                        NineSliceInstanceCurrentColorCategoryStateSecondValue = JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Yellow;
                        setNineSliceInstanceGreenSecondValue = true;
                        NineSliceInstanceGreenSecondValue = 255;
                        setNineSliceInstanceRedSecondValue = true;
                        NineSliceInstanceRedSecondValue = 255;
                        break;
                    case  ButtonCategory.Focused:
                        if (interpolationValue >= 1)
                        {
                            this.HighlightRectangle.Visible = true;
                        }
                        setNineSliceInstanceBlueSecondValue = true;
                        NineSliceInstanceBlueSecondValue = 255;
                        setNineSliceInstanceCurrentColorCategoryStateSecondValue = true;
                        NineSliceInstanceCurrentColorCategoryStateSecondValue = JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Blue;
                        setNineSliceInstanceGreenSecondValue = true;
                        NineSliceInstanceGreenSecondValue = 255;
                        setNineSliceInstanceRedSecondValue = true;
                        NineSliceInstanceRedSecondValue = 255;
                        break;
                    case  ButtonCategory.DisabledFocused:
                        if (interpolationValue >= 1)
                        {
                            this.HighlightRectangle.Visible = true;
                        }
                        setNineSliceInstanceBlueSecondValue = true;
                        NineSliceInstanceBlueSecondValue = 255;
                        setNineSliceInstanceCurrentColorCategoryStateSecondValue = true;
                        NineSliceInstanceCurrentColorCategoryStateSecondValue = JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Black;
                        setNineSliceInstanceGreenSecondValue = true;
                        NineSliceInstanceGreenSecondValue = 255;
                        setNineSliceInstanceRedSecondValue = true;
                        NineSliceInstanceRedSecondValue = 255;
                        break;
                }
                var wasSuppressed = mIsLayoutSuspended;
                if (wasSuppressed == false)
                {
                    SuspendLayout(true);
                }
                if (setNineSliceInstanceBlueFirstValue && setNineSliceInstanceBlueSecondValue)
                {
                    NineSliceInstance.Blue = FlatRedBall.Math.MathFunctions.RoundToInt(NineSliceInstanceBlueFirstValue* (1 - interpolationValue) + NineSliceInstanceBlueSecondValue * interpolationValue);
                }
                if (setNineSliceInstanceCurrentColorCategoryStateFirstValue && setNineSliceInstanceCurrentColorCategoryStateSecondValue)
                {
                    NineSliceInstance.InterpolateBetween(NineSliceInstanceCurrentColorCategoryStateFirstValue, NineSliceInstanceCurrentColorCategoryStateSecondValue, interpolationValue);
                }
                if (setNineSliceInstanceGreenFirstValue && setNineSliceInstanceGreenSecondValue)
                {
                    NineSliceInstance.Green = FlatRedBall.Math.MathFunctions.RoundToInt(NineSliceInstanceGreenFirstValue* (1 - interpolationValue) + NineSliceInstanceGreenSecondValue * interpolationValue);
                }
                if (setNineSliceInstanceRedFirstValue && setNineSliceInstanceRedSecondValue)
                {
                    NineSliceInstance.Red = FlatRedBall.Math.MathFunctions.RoundToInt(NineSliceInstanceRedFirstValue* (1 - interpolationValue) + NineSliceInstanceRedSecondValue * interpolationValue);
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
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (JHP4SD.GumRuntimes.LebegForms.BasicComponents.ImageButtonRuntime.VariableState fromState,JHP4SD.GumRuntimes.LebegForms.BasicComponents.ImageButtonRuntime.VariableState toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null) 
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
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (JHP4SD.GumRuntimes.LebegForms.BasicComponents.ImageButtonRuntime.ButtonCategory fromState,JHP4SD.GumRuntimes.LebegForms.BasicComponents.ImageButtonRuntime.ButtonCategory toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null) 
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
                NineSliceInstance.StopAnimations();
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
                            Name = "X",
                            Type = "float",
                            Value = X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Y",
                            Type = "float",
                            Value = Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NineSliceInstance.Blue",
                            Type = "int",
                            Value = NineSliceInstance.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NineSliceInstance.ColorCategoryState",
                            Type = "ColorCategoryState",
                            Value = NineSliceInstance.CurrentColorCategoryState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NineSliceInstance.Green",
                            Type = "int",
                            Value = NineSliceInstance.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NineSliceInstance.Height",
                            Type = "float",
                            Value = NineSliceInstance.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NineSliceInstance.Height Units",
                            Type = "DimensionUnitType",
                            Value = NineSliceInstance.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NineSliceInstance.Red",
                            Type = "int",
                            Value = NineSliceInstance.Red
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NineSliceInstance.Width",
                            Type = "float",
                            Value = NineSliceInstance.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NineSliceInstance.Width Units",
                            Type = "DimensionUnitType",
                            Value = NineSliceInstance.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NineSliceInstance.X",
                            Type = "float",
                            Value = NineSliceInstance.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NineSliceInstance.X Origin",
                            Type = "HorizontalAlignment",
                            Value = NineSliceInstance.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NineSliceInstance.X Units",
                            Type = "PositionUnitType",
                            Value = NineSliceInstance.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NineSliceInstance.Y",
                            Type = "float",
                            Value = NineSliceInstance.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NineSliceInstance.Y Origin",
                            Type = "VerticalAlignment",
                            Value = NineSliceInstance.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NineSliceInstance.Y Units",
                            Type = "PositionUnitType",
                            Value = NineSliceInstance.YUnits
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
                            Name = "HighlightRectangle.Visible",
                            Type = "bool",
                            Value = HighlightRectangle.Visible
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
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Height",
                            Type = "float",
                            Value = SpriteInstance.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Height Units",
                            Type = "DimensionUnitType",
                            Value = SpriteInstance.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Width",
                            Type = "float",
                            Value = SpriteInstance.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Width Units",
                            Type = "DimensionUnitType",
                            Value = SpriteInstance.WidthUnits
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
                            Value = Height + 56f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Width",
                            Type = "float",
                            Value = Width + 56f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "X",
                            Type = "float",
                            Value = X + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Y",
                            Type = "float",
                            Value = Y + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NineSliceInstance.Blue",
                            Type = "int",
                            Value = NineSliceInstance.Blue + 170
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NineSliceInstance.ColorCategoryState",
                            Type = "ColorCategoryState",
                            Value = NineSliceInstance.CurrentColorCategoryState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NineSliceInstance.Green",
                            Type = "int",
                            Value = NineSliceInstance.Green + 205
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NineSliceInstance.Height",
                            Type = "float",
                            Value = NineSliceInstance.Height + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NineSliceInstance.Height Units",
                            Type = "DimensionUnitType",
                            Value = NineSliceInstance.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NineSliceInstance.Red",
                            Type = "int",
                            Value = NineSliceInstance.Red + 102
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NineSliceInstance.Width",
                            Type = "float",
                            Value = NineSliceInstance.Width + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NineSliceInstance.Width Units",
                            Type = "DimensionUnitType",
                            Value = NineSliceInstance.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NineSliceInstance.X",
                            Type = "float",
                            Value = NineSliceInstance.X + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NineSliceInstance.X Origin",
                            Type = "HorizontalAlignment",
                            Value = NineSliceInstance.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NineSliceInstance.X Units",
                            Type = "PositionUnitType",
                            Value = NineSliceInstance.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NineSliceInstance.Y",
                            Type = "float",
                            Value = NineSliceInstance.Y + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NineSliceInstance.Y Origin",
                            Type = "VerticalAlignment",
                            Value = NineSliceInstance.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NineSliceInstance.Y Units",
                            Type = "PositionUnitType",
                            Value = NineSliceInstance.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HighlightRectangle.Height",
                            Type = "float",
                            Value = HighlightRectangle.Height + -6f
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
                            Name = "HighlightRectangle.Visible",
                            Type = "bool",
                            Value = HighlightRectangle.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HighlightRectangle.Width",
                            Type = "float",
                            Value = HighlightRectangle.Width + -6f
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
                            Value = HighlightRectangle.Y + -1f
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
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Height",
                            Type = "float",
                            Value = SpriteInstance.Height + 48f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Height Units",
                            Type = "DimensionUnitType",
                            Value = SpriteInstance.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Width",
                            Type = "float",
                            Value = SpriteInstance.Width + 48f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Width Units",
                            Type = "DimensionUnitType",
                            Value = SpriteInstance.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.X",
                            Type = "float",
                            Value = SpriteInstance.X + 4f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Y",
                            Type = "float",
                            Value = SpriteInstance.Y + 4f
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
                            Name = "NineSliceInstance.Blue",
                            Type = "int",
                            Value = NineSliceInstance.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NineSliceInstance.ColorCategoryState",
                            Type = "ColorCategoryState",
                            Value = NineSliceInstance.CurrentColorCategoryState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NineSliceInstance.Green",
                            Type = "int",
                            Value = NineSliceInstance.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NineSliceInstance.Red",
                            Type = "int",
                            Value = NineSliceInstance.Red
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
                            Name = "NineSliceInstance.Blue",
                            Type = "int",
                            Value = NineSliceInstance.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NineSliceInstance.ColorCategoryState",
                            Type = "ColorCategoryState",
                            Value = NineSliceInstance.CurrentColorCategoryState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NineSliceInstance.Green",
                            Type = "int",
                            Value = NineSliceInstance.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NineSliceInstance.Red",
                            Type = "int",
                            Value = NineSliceInstance.Red
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
                            Name = "NineSliceInstance.Blue",
                            Type = "int",
                            Value = NineSliceInstance.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NineSliceInstance.ColorCategoryState",
                            Type = "ColorCategoryState",
                            Value = NineSliceInstance.CurrentColorCategoryState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NineSliceInstance.Green",
                            Type = "int",
                            Value = NineSliceInstance.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NineSliceInstance.Red",
                            Type = "int",
                            Value = NineSliceInstance.Red
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
                            Name = "NineSliceInstance.Blue",
                            Type = "int",
                            Value = NineSliceInstance.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NineSliceInstance.ColorCategoryState",
                            Type = "ColorCategoryState",
                            Value = NineSliceInstance.CurrentColorCategoryState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NineSliceInstance.Green",
                            Type = "int",
                            Value = NineSliceInstance.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NineSliceInstance.Red",
                            Type = "int",
                            Value = NineSliceInstance.Red
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
                            Name = "NineSliceInstance.Blue",
                            Type = "int",
                            Value = NineSliceInstance.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NineSliceInstance.ColorCategoryState",
                            Type = "ColorCategoryState",
                            Value = NineSliceInstance.CurrentColorCategoryState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NineSliceInstance.Green",
                            Type = "int",
                            Value = NineSliceInstance.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NineSliceInstance.Red",
                            Type = "int",
                            Value = NineSliceInstance.Red
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
                            Name = "NineSliceInstance.Blue",
                            Type = "int",
                            Value = NineSliceInstance.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NineSliceInstance.ColorCategoryState",
                            Type = "ColorCategoryState",
                            Value = NineSliceInstance.CurrentColorCategoryState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NineSliceInstance.Green",
                            Type = "int",
                            Value = NineSliceInstance.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NineSliceInstance.Red",
                            Type = "int",
                            Value = NineSliceInstance.Red
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
                    case  ButtonCategory.DisabledFocused:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NineSliceInstance.Blue",
                            Type = "int",
                            Value = NineSliceInstance.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NineSliceInstance.ColorCategoryState",
                            Type = "ColorCategoryState",
                            Value = NineSliceInstance.CurrentColorCategoryState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NineSliceInstance.Green",
                            Type = "int",
                            Value = NineSliceInstance.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NineSliceInstance.Red",
                            Type = "int",
                            Value = NineSliceInstance.Red
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
                            Name = "NineSliceInstance.Blue",
                            Type = "int",
                            Value = NineSliceInstance.Blue + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NineSliceInstance.ColorCategoryState",
                            Type = "ColorCategoryState",
                            Value = NineSliceInstance.CurrentColorCategoryState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NineSliceInstance.Green",
                            Type = "int",
                            Value = NineSliceInstance.Green + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NineSliceInstance.Red",
                            Type = "int",
                            Value = NineSliceInstance.Red + 255
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
                            Name = "NineSliceInstance.Blue",
                            Type = "int",
                            Value = NineSliceInstance.Blue + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NineSliceInstance.ColorCategoryState",
                            Type = "ColorCategoryState",
                            Value = NineSliceInstance.CurrentColorCategoryState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NineSliceInstance.Green",
                            Type = "int",
                            Value = NineSliceInstance.Green + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NineSliceInstance.Red",
                            Type = "int",
                            Value = NineSliceInstance.Red + 255
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
                            Name = "NineSliceInstance.Blue",
                            Type = "int",
                            Value = NineSliceInstance.Blue + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NineSliceInstance.ColorCategoryState",
                            Type = "ColorCategoryState",
                            Value = NineSliceInstance.CurrentColorCategoryState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NineSliceInstance.Green",
                            Type = "int",
                            Value = NineSliceInstance.Green + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NineSliceInstance.Red",
                            Type = "int",
                            Value = NineSliceInstance.Red + 255
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
                            Name = "NineSliceInstance.Blue",
                            Type = "int",
                            Value = NineSliceInstance.Blue + 200
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NineSliceInstance.ColorCategoryState",
                            Type = "ColorCategoryState",
                            Value = NineSliceInstance.CurrentColorCategoryState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NineSliceInstance.Green",
                            Type = "int",
                            Value = NineSliceInstance.Green + 200
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NineSliceInstance.Red",
                            Type = "int",
                            Value = NineSliceInstance.Red + 200
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
                            Name = "NineSliceInstance.Blue",
                            Type = "int",
                            Value = NineSliceInstance.Blue + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NineSliceInstance.ColorCategoryState",
                            Type = "ColorCategoryState",
                            Value = NineSliceInstance.CurrentColorCategoryState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NineSliceInstance.Green",
                            Type = "int",
                            Value = NineSliceInstance.Green + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NineSliceInstance.Red",
                            Type = "int",
                            Value = NineSliceInstance.Red + 255
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
                            Name = "NineSliceInstance.Blue",
                            Type = "int",
                            Value = NineSliceInstance.Blue + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NineSliceInstance.ColorCategoryState",
                            Type = "ColorCategoryState",
                            Value = NineSliceInstance.CurrentColorCategoryState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NineSliceInstance.Green",
                            Type = "int",
                            Value = NineSliceInstance.Green + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NineSliceInstance.Red",
                            Type = "int",
                            Value = NineSliceInstance.Red + 255
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
                    case  ButtonCategory.DisabledFocused:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NineSliceInstance.Blue",
                            Type = "int",
                            Value = NineSliceInstance.Blue + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NineSliceInstance.ColorCategoryState",
                            Type = "ColorCategoryState",
                            Value = NineSliceInstance.CurrentColorCategoryState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NineSliceInstance.Green",
                            Type = "int",
                            Value = NineSliceInstance.Green + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NineSliceInstance.Red",
                            Type = "int",
                            Value = NineSliceInstance.Red + 255
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
                        if(state.Name == "DisabledFocused") this.mCurrentButtonCategoryState = ButtonCategory.DisabledFocused;
                    }
                }
                base.ApplyState(state);
            }
            private bool tryCreateFormsObject;
            public JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime NineSliceInstance { get; set; }
            public JHP4SD.GumRuntimes.RectangleRuntime HighlightRectangle { get; set; }
            public JHP4SD.GumRuntimes.SpriteRuntime SpriteInstance { get; set; }
            public ImageButtonRuntime (bool fullInstantiation = true, bool tryCreateFormsObject = true) 
            	: base(false, tryCreateFormsObject)
            {
                this.tryCreateFormsObject = tryCreateFormsObject;
                this.ExposeChildrenEvents = false;
                if (fullInstantiation)
                {
                    Gum.DataTypes.ElementSave elementSave = Gum.Managers.ObjectFinder.Self.GumProjectSave.Components.First(item => item.Name == "LebegForms/BasicComponents/ImageButton");
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
                NineSliceInstance = this.GetGraphicalUiElementByName("NineSliceInstance") as JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime;
                HighlightRectangle = this.GetGraphicalUiElementByName("HighlightRectangle") as JHP4SD.GumRuntimes.RectangleRuntime;
                SpriteInstance = this.GetGraphicalUiElementByName("SpriteInstance") as JHP4SD.GumRuntimes.SpriteRuntime;
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
