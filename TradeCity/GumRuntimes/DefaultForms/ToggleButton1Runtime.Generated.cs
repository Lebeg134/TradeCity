    using System.Linq;
    namespace JHP4SD.GumRuntimes.DefaultForms
    {
        public partial class ToggleButton1Runtime : JHP4SD.GumRuntimes.ContainerRuntime
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
                            NineSliceInstance.CurrentColorCategoryState = JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Blue;
                            TextInstance.CurrentColorCategoryState = JHP4SD.GumRuntimes.TextRuntime.ColorCategory.Gray;
                            Height = 48f;
                            Width = 256f;
                            NineSliceInstance.Height = 0f;
                            NineSliceInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                            NineSliceInstance.Width = 0f;
                            NineSliceInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                            NineSliceInstance.X = 0f;
                            NineSliceInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                            NineSliceInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            NineSliceInstance.Y = 0f;
                            NineSliceInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            NineSliceInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            TextInstance.Height = 0f;
                            TextInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                            TextInstance.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                            TextInstance.VerticalAlignment = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            TextInstance.Width = 0f;
                            TextInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                            TextInstance.X = 0f;
                            TextInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                            TextInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            TextInstance.Y = 0f;
                            TextInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            TextInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            NineSliceInstance1.Height = 6f;
                            SetProperty("NineSliceInstance1.SourceFile", "UISpriteSheet.png");
                            NineSliceInstance1.TextureAddress = Gum.Managers.TextureAddress.Custom;
                            NineSliceInstance1.TextureHeight = 26;
                            NineSliceInstance1.TextureLeft = 2;
                            NineSliceInstance1.TextureTop = 338;
                            NineSliceInstance1.TextureWidth = 44;
                            NineSliceInstance1.Width = -13f;
                            NineSliceInstance1.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                            NineSliceInstance1.X = 0f;
                            NineSliceInstance1.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                            NineSliceInstance1.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            NineSliceInstance1.Y = -4f;
                            NineSliceInstance1.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Bottom;
                            NineSliceInstance1.YUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                            ColoredRectangleInstance.Blue = 49;
                            ColoredRectangleInstance.Green = 49;
                            ColoredRectangleInstance.Height = 2f;
                            ColoredRectangleInstance.Red = 49;
                            ColoredRectangleInstance.Width = -19f;
                            ColoredRectangleInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                            ColoredRectangleInstance.X = 0f;
                            ColoredRectangleInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                            ColoredRectangleInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            ColoredRectangleInstance.Y = -6f;
                            ColoredRectangleInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Bottom;
                            ColoredRectangleInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
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
                                NineSliceInstance.CurrentColorCategoryState = JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Blue;
                                TextInstance.CurrentColorCategoryState = JHP4SD.GumRuntimes.TextRuntime.ColorCategory.Gray;
                                NineSliceInstance.Blue = 255;
                                NineSliceInstance.Green = 255;
                                NineSliceInstance.Red = 255;
                                ColoredRectangleInstance.Visible = true;
                                break;
                            case  ToggleCategory.EnabledOff:
                                NineSliceInstance.CurrentColorCategoryState = JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Blue;
                                TextInstance.CurrentColorCategoryState = JHP4SD.GumRuntimes.TextRuntime.ColorCategory.Gray;
                                NineSliceInstance.Blue = 255;
                                NineSliceInstance.Green = 255;
                                NineSliceInstance.Red = 255;
                                ColoredRectangleInstance.Visible = false;
                                break;
                            case  ToggleCategory.DisabledOn:
                                NineSliceInstance.CurrentColorCategoryState = JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Black;
                                TextInstance.CurrentColorCategoryState = JHP4SD.GumRuntimes.TextRuntime.ColorCategory.Gray;
                                NineSliceInstance.Blue = 255;
                                NineSliceInstance.Green = 255;
                                NineSliceInstance.Red = 255;
                                ColoredRectangleInstance.Visible = true;
                                break;
                            case  ToggleCategory.DisabledOff:
                                NineSliceInstance.CurrentColorCategoryState = JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Black;
                                TextInstance.CurrentColorCategoryState = JHP4SD.GumRuntimes.TextRuntime.ColorCategory.Gray;
                                NineSliceInstance.Blue = 255;
                                NineSliceInstance.Green = 255;
                                NineSliceInstance.Red = 255;
                                ColoredRectangleInstance.Visible = false;
                                break;
                            case  ToggleCategory.HighlightedOn:
                                NineSliceInstance.CurrentColorCategoryState = JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Yellow;
                                TextInstance.CurrentColorCategoryState = JHP4SD.GumRuntimes.TextRuntime.ColorCategory.Black;
                                NineSliceInstance.Blue = 255;
                                NineSliceInstance.Green = 255;
                                NineSliceInstance.Red = 255;
                                ColoredRectangleInstance.Visible = true;
                                break;
                            case  ToggleCategory.HighlightedOff:
                                NineSliceInstance.CurrentColorCategoryState = JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Yellow;
                                TextInstance.CurrentColorCategoryState = JHP4SD.GumRuntimes.TextRuntime.ColorCategory.Black;
                                NineSliceInstance.Blue = 255;
                                NineSliceInstance.Green = 255;
                                NineSliceInstance.Red = 255;
                                ColoredRectangleInstance.Visible = false;
                                break;
                            case  ToggleCategory.PushedOn:
                                NineSliceInstance.CurrentColorCategoryState = JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Yellow;
                                TextInstance.CurrentColorCategoryState = JHP4SD.GumRuntimes.TextRuntime.ColorCategory.Black;
                                NineSliceInstance.Blue = 200;
                                NineSliceInstance.Green = 200;
                                NineSliceInstance.Red = 200;
                                ColoredRectangleInstance.Visible = true;
                                break;
                            case  ToggleCategory.PushedOff:
                                NineSliceInstance.CurrentColorCategoryState = JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Yellow;
                                TextInstance.CurrentColorCategoryState = JHP4SD.GumRuntimes.TextRuntime.ColorCategory.Black;
                                NineSliceInstance.Blue = 200;
                                NineSliceInstance.Green = 200;
                                NineSliceInstance.Red = 200;
                                ColoredRectangleInstance.Visible = false;
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
                bool setColoredRectangleInstanceBlueFirstValue = false;
                bool setColoredRectangleInstanceBlueSecondValue = false;
                int ColoredRectangleInstanceBlueFirstValue= 0;
                int ColoredRectangleInstanceBlueSecondValue= 0;
                bool setColoredRectangleInstanceGreenFirstValue = false;
                bool setColoredRectangleInstanceGreenSecondValue = false;
                int ColoredRectangleInstanceGreenFirstValue= 0;
                int ColoredRectangleInstanceGreenSecondValue= 0;
                bool setColoredRectangleInstanceHeightFirstValue = false;
                bool setColoredRectangleInstanceHeightSecondValue = false;
                float ColoredRectangleInstanceHeightFirstValue= 0;
                float ColoredRectangleInstanceHeightSecondValue= 0;
                bool setColoredRectangleInstanceRedFirstValue = false;
                bool setColoredRectangleInstanceRedSecondValue = false;
                int ColoredRectangleInstanceRedFirstValue= 0;
                int ColoredRectangleInstanceRedSecondValue= 0;
                bool setColoredRectangleInstanceWidthFirstValue = false;
                bool setColoredRectangleInstanceWidthSecondValue = false;
                float ColoredRectangleInstanceWidthFirstValue= 0;
                float ColoredRectangleInstanceWidthSecondValue= 0;
                bool setColoredRectangleInstanceXFirstValue = false;
                bool setColoredRectangleInstanceXSecondValue = false;
                float ColoredRectangleInstanceXFirstValue= 0;
                float ColoredRectangleInstanceXSecondValue= 0;
                bool setColoredRectangleInstanceYFirstValue = false;
                bool setColoredRectangleInstanceYSecondValue = false;
                float ColoredRectangleInstanceYFirstValue= 0;
                float ColoredRectangleInstanceYSecondValue= 0;
                bool setHeightFirstValue = false;
                bool setHeightSecondValue = false;
                float HeightFirstValue= 0;
                float HeightSecondValue= 0;
                bool setNineSliceInstanceCurrentColorCategoryStateFirstValue = false;
                bool setNineSliceInstanceCurrentColorCategoryStateSecondValue = false;
                JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory NineSliceInstanceCurrentColorCategoryStateFirstValue= JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Gray;
                JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory NineSliceInstanceCurrentColorCategoryStateSecondValue= JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Gray;
                bool setNineSliceInstanceHeightFirstValue = false;
                bool setNineSliceInstanceHeightSecondValue = false;
                float NineSliceInstanceHeightFirstValue= 0;
                float NineSliceInstanceHeightSecondValue= 0;
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
                bool setNineSliceInstance1HeightFirstValue = false;
                bool setNineSliceInstance1HeightSecondValue = false;
                float NineSliceInstance1HeightFirstValue= 0;
                float NineSliceInstance1HeightSecondValue= 0;
                bool setNineSliceInstance1TextureHeightFirstValue = false;
                bool setNineSliceInstance1TextureHeightSecondValue = false;
                int NineSliceInstance1TextureHeightFirstValue= 0;
                int NineSliceInstance1TextureHeightSecondValue= 0;
                bool setNineSliceInstance1TextureLeftFirstValue = false;
                bool setNineSliceInstance1TextureLeftSecondValue = false;
                int NineSliceInstance1TextureLeftFirstValue= 0;
                int NineSliceInstance1TextureLeftSecondValue= 0;
                bool setNineSliceInstance1TextureTopFirstValue = false;
                bool setNineSliceInstance1TextureTopSecondValue = false;
                int NineSliceInstance1TextureTopFirstValue= 0;
                int NineSliceInstance1TextureTopSecondValue= 0;
                bool setNineSliceInstance1TextureWidthFirstValue = false;
                bool setNineSliceInstance1TextureWidthSecondValue = false;
                int NineSliceInstance1TextureWidthFirstValue= 0;
                int NineSliceInstance1TextureWidthSecondValue= 0;
                bool setNineSliceInstance1WidthFirstValue = false;
                bool setNineSliceInstance1WidthSecondValue = false;
                float NineSliceInstance1WidthFirstValue= 0;
                float NineSliceInstance1WidthSecondValue= 0;
                bool setNineSliceInstance1XFirstValue = false;
                bool setNineSliceInstance1XSecondValue = false;
                float NineSliceInstance1XFirstValue= 0;
                float NineSliceInstance1XSecondValue= 0;
                bool setNineSliceInstance1YFirstValue = false;
                bool setNineSliceInstance1YSecondValue = false;
                float NineSliceInstance1YFirstValue= 0;
                float NineSliceInstance1YSecondValue= 0;
                bool setTextInstanceCurrentColorCategoryStateFirstValue = false;
                bool setTextInstanceCurrentColorCategoryStateSecondValue = false;
                JHP4SD.GumRuntimes.TextRuntime.ColorCategory TextInstanceCurrentColorCategoryStateFirstValue= JHP4SD.GumRuntimes.TextRuntime.ColorCategory.Gray;
                JHP4SD.GumRuntimes.TextRuntime.ColorCategory TextInstanceCurrentColorCategoryStateSecondValue= JHP4SD.GumRuntimes.TextRuntime.ColorCategory.Gray;
                bool setTextInstanceHeightFirstValue = false;
                bool setTextInstanceHeightSecondValue = false;
                float TextInstanceHeightFirstValue= 0;
                float TextInstanceHeightSecondValue= 0;
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
                bool setWidthFirstValue = false;
                bool setWidthSecondValue = false;
                float WidthFirstValue= 0;
                float WidthSecondValue= 0;
                switch(firstState)
                {
                    case  VariableState.Default:
                        setColoredRectangleInstanceBlueFirstValue = true;
                        ColoredRectangleInstanceBlueFirstValue = 49;
                        setColoredRectangleInstanceGreenFirstValue = true;
                        ColoredRectangleInstanceGreenFirstValue = 49;
                        setColoredRectangleInstanceHeightFirstValue = true;
                        ColoredRectangleInstanceHeightFirstValue = 2f;
                        setColoredRectangleInstanceRedFirstValue = true;
                        ColoredRectangleInstanceRedFirstValue = 49;
                        setColoredRectangleInstanceWidthFirstValue = true;
                        ColoredRectangleInstanceWidthFirstValue = -19f;
                        if (interpolationValue < 1)
                        {
                            this.ColoredRectangleInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        setColoredRectangleInstanceXFirstValue = true;
                        ColoredRectangleInstanceXFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.ColoredRectangleInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.ColoredRectangleInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setColoredRectangleInstanceYFirstValue = true;
                        ColoredRectangleInstanceYFirstValue = -6f;
                        if (interpolationValue < 1)
                        {
                            this.ColoredRectangleInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Bottom;
                        }
                        if (interpolationValue < 1)
                        {
                            this.ColoredRectangleInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                        }
                        setHeightFirstValue = true;
                        HeightFirstValue = 48f;
                        setNineSliceInstanceCurrentColorCategoryStateFirstValue = true;
                        NineSliceInstanceCurrentColorCategoryStateFirstValue = JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Blue;
                        setNineSliceInstanceHeightFirstValue = true;
                        NineSliceInstanceHeightFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.NineSliceInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
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
                        setNineSliceInstance1HeightFirstValue = true;
                        NineSliceInstance1HeightFirstValue = 6f;
                        if (interpolationValue < 1)
                        {
                            SetProperty("NineSliceInstance1.SourceFile", "UISpriteSheet.png");
                        }
                        if (interpolationValue < 1)
                        {
                            this.NineSliceInstance1.TextureAddress = Gum.Managers.TextureAddress.Custom;
                        }
                        setNineSliceInstance1TextureHeightFirstValue = true;
                        NineSliceInstance1TextureHeightFirstValue = 26;
                        setNineSliceInstance1TextureLeftFirstValue = true;
                        NineSliceInstance1TextureLeftFirstValue = 2;
                        setNineSliceInstance1TextureTopFirstValue = true;
                        NineSliceInstance1TextureTopFirstValue = 338;
                        setNineSliceInstance1TextureWidthFirstValue = true;
                        NineSliceInstance1TextureWidthFirstValue = 44;
                        setNineSliceInstance1WidthFirstValue = true;
                        NineSliceInstance1WidthFirstValue = -13f;
                        if (interpolationValue < 1)
                        {
                            this.NineSliceInstance1.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        setNineSliceInstance1XFirstValue = true;
                        NineSliceInstance1XFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.NineSliceInstance1.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.NineSliceInstance1.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setNineSliceInstance1YFirstValue = true;
                        NineSliceInstance1YFirstValue = -4f;
                        if (interpolationValue < 1)
                        {
                            this.NineSliceInstance1.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Bottom;
                        }
                        if (interpolationValue < 1)
                        {
                            this.NineSliceInstance1.YUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                        }
                        setTextInstanceCurrentColorCategoryStateFirstValue = true;
                        TextInstanceCurrentColorCategoryStateFirstValue = JHP4SD.GumRuntimes.TextRuntime.ColorCategory.Gray;
                        setTextInstanceHeightFirstValue = true;
                        TextInstanceHeightFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.TextInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                        }
                        if (interpolationValue < 1)
                        {
                            this.TextInstance.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.TextInstance.VerticalAlignment = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        setTextInstanceWidthFirstValue = true;
                        TextInstanceWidthFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.TextInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                        }
                        setTextInstanceXFirstValue = true;
                        TextInstanceXFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.TextInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.TextInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
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
                        setWidthFirstValue = true;
                        WidthFirstValue = 256f;
                        break;
                }
                switch(secondState)
                {
                    case  VariableState.Default:
                        setColoredRectangleInstanceBlueSecondValue = true;
                        ColoredRectangleInstanceBlueSecondValue = 49;
                        setColoredRectangleInstanceGreenSecondValue = true;
                        ColoredRectangleInstanceGreenSecondValue = 49;
                        setColoredRectangleInstanceHeightSecondValue = true;
                        ColoredRectangleInstanceHeightSecondValue = 2f;
                        setColoredRectangleInstanceRedSecondValue = true;
                        ColoredRectangleInstanceRedSecondValue = 49;
                        setColoredRectangleInstanceWidthSecondValue = true;
                        ColoredRectangleInstanceWidthSecondValue = -19f;
                        if (interpolationValue >= 1)
                        {
                            this.ColoredRectangleInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        setColoredRectangleInstanceXSecondValue = true;
                        ColoredRectangleInstanceXSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.ColoredRectangleInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.ColoredRectangleInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setColoredRectangleInstanceYSecondValue = true;
                        ColoredRectangleInstanceYSecondValue = -6f;
                        if (interpolationValue >= 1)
                        {
                            this.ColoredRectangleInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Bottom;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.ColoredRectangleInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                        }
                        setHeightSecondValue = true;
                        HeightSecondValue = 48f;
                        setNineSliceInstanceCurrentColorCategoryStateSecondValue = true;
                        NineSliceInstanceCurrentColorCategoryStateSecondValue = JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Blue;
                        setNineSliceInstanceHeightSecondValue = true;
                        NineSliceInstanceHeightSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.NineSliceInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
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
                        setNineSliceInstance1HeightSecondValue = true;
                        NineSliceInstance1HeightSecondValue = 6f;
                        if (interpolationValue >= 1)
                        {
                            SetProperty("NineSliceInstance1.SourceFile", "UISpriteSheet.png");
                        }
                        if (interpolationValue >= 1)
                        {
                            this.NineSliceInstance1.TextureAddress = Gum.Managers.TextureAddress.Custom;
                        }
                        setNineSliceInstance1TextureHeightSecondValue = true;
                        NineSliceInstance1TextureHeightSecondValue = 26;
                        setNineSliceInstance1TextureLeftSecondValue = true;
                        NineSliceInstance1TextureLeftSecondValue = 2;
                        setNineSliceInstance1TextureTopSecondValue = true;
                        NineSliceInstance1TextureTopSecondValue = 338;
                        setNineSliceInstance1TextureWidthSecondValue = true;
                        NineSliceInstance1TextureWidthSecondValue = 44;
                        setNineSliceInstance1WidthSecondValue = true;
                        NineSliceInstance1WidthSecondValue = -13f;
                        if (interpolationValue >= 1)
                        {
                            this.NineSliceInstance1.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        setNineSliceInstance1XSecondValue = true;
                        NineSliceInstance1XSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.NineSliceInstance1.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.NineSliceInstance1.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setNineSliceInstance1YSecondValue = true;
                        NineSliceInstance1YSecondValue = -4f;
                        if (interpolationValue >= 1)
                        {
                            this.NineSliceInstance1.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Bottom;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.NineSliceInstance1.YUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                        }
                        setTextInstanceCurrentColorCategoryStateSecondValue = true;
                        TextInstanceCurrentColorCategoryStateSecondValue = JHP4SD.GumRuntimes.TextRuntime.ColorCategory.Gray;
                        setTextInstanceHeightSecondValue = true;
                        TextInstanceHeightSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.TextInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.TextInstance.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.TextInstance.VerticalAlignment = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        setTextInstanceWidthSecondValue = true;
                        TextInstanceWidthSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.TextInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                        }
                        setTextInstanceXSecondValue = true;
                        TextInstanceXSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.TextInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.TextInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
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
                        setWidthSecondValue = true;
                        WidthSecondValue = 256f;
                        break;
                }
                var wasSuppressed = mIsLayoutSuspended;
                if (wasSuppressed == false)
                {
                    SuspendLayout(true);
                }
                if (setColoredRectangleInstanceBlueFirstValue && setColoredRectangleInstanceBlueSecondValue)
                {
                    ColoredRectangleInstance.Blue = FlatRedBall.Math.MathFunctions.RoundToInt(ColoredRectangleInstanceBlueFirstValue* (1 - interpolationValue) + ColoredRectangleInstanceBlueSecondValue * interpolationValue);
                }
                if (setColoredRectangleInstanceGreenFirstValue && setColoredRectangleInstanceGreenSecondValue)
                {
                    ColoredRectangleInstance.Green = FlatRedBall.Math.MathFunctions.RoundToInt(ColoredRectangleInstanceGreenFirstValue* (1 - interpolationValue) + ColoredRectangleInstanceGreenSecondValue * interpolationValue);
                }
                if (setColoredRectangleInstanceHeightFirstValue && setColoredRectangleInstanceHeightSecondValue)
                {
                    ColoredRectangleInstance.Height = ColoredRectangleInstanceHeightFirstValue * (1 - interpolationValue) + ColoredRectangleInstanceHeightSecondValue * interpolationValue;
                }
                if (setColoredRectangleInstanceRedFirstValue && setColoredRectangleInstanceRedSecondValue)
                {
                    ColoredRectangleInstance.Red = FlatRedBall.Math.MathFunctions.RoundToInt(ColoredRectangleInstanceRedFirstValue* (1 - interpolationValue) + ColoredRectangleInstanceRedSecondValue * interpolationValue);
                }
                if (setColoredRectangleInstanceWidthFirstValue && setColoredRectangleInstanceWidthSecondValue)
                {
                    ColoredRectangleInstance.Width = ColoredRectangleInstanceWidthFirstValue * (1 - interpolationValue) + ColoredRectangleInstanceWidthSecondValue * interpolationValue;
                }
                if (setColoredRectangleInstanceXFirstValue && setColoredRectangleInstanceXSecondValue)
                {
                    ColoredRectangleInstance.X = ColoredRectangleInstanceXFirstValue * (1 - interpolationValue) + ColoredRectangleInstanceXSecondValue * interpolationValue;
                }
                if (setColoredRectangleInstanceYFirstValue && setColoredRectangleInstanceYSecondValue)
                {
                    ColoredRectangleInstance.Y = ColoredRectangleInstanceYFirstValue * (1 - interpolationValue) + ColoredRectangleInstanceYSecondValue * interpolationValue;
                }
                if (setHeightFirstValue && setHeightSecondValue)
                {
                    Height = HeightFirstValue * (1 - interpolationValue) + HeightSecondValue * interpolationValue;
                }
                if (setNineSliceInstanceCurrentColorCategoryStateFirstValue && setNineSliceInstanceCurrentColorCategoryStateSecondValue)
                {
                    NineSliceInstance.InterpolateBetween(NineSliceInstanceCurrentColorCategoryStateFirstValue, NineSliceInstanceCurrentColorCategoryStateSecondValue, interpolationValue);
                }
                if (setNineSliceInstanceHeightFirstValue && setNineSliceInstanceHeightSecondValue)
                {
                    NineSliceInstance.Height = NineSliceInstanceHeightFirstValue * (1 - interpolationValue) + NineSliceInstanceHeightSecondValue * interpolationValue;
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
                if (setNineSliceInstance1HeightFirstValue && setNineSliceInstance1HeightSecondValue)
                {
                    NineSliceInstance1.Height = NineSliceInstance1HeightFirstValue * (1 - interpolationValue) + NineSliceInstance1HeightSecondValue * interpolationValue;
                }
                if (setNineSliceInstance1TextureHeightFirstValue && setNineSliceInstance1TextureHeightSecondValue)
                {
                    NineSliceInstance1.TextureHeight = FlatRedBall.Math.MathFunctions.RoundToInt(NineSliceInstance1TextureHeightFirstValue* (1 - interpolationValue) + NineSliceInstance1TextureHeightSecondValue * interpolationValue);
                }
                if (setNineSliceInstance1TextureLeftFirstValue && setNineSliceInstance1TextureLeftSecondValue)
                {
                    NineSliceInstance1.TextureLeft = FlatRedBall.Math.MathFunctions.RoundToInt(NineSliceInstance1TextureLeftFirstValue* (1 - interpolationValue) + NineSliceInstance1TextureLeftSecondValue * interpolationValue);
                }
                if (setNineSliceInstance1TextureTopFirstValue && setNineSliceInstance1TextureTopSecondValue)
                {
                    NineSliceInstance1.TextureTop = FlatRedBall.Math.MathFunctions.RoundToInt(NineSliceInstance1TextureTopFirstValue* (1 - interpolationValue) + NineSliceInstance1TextureTopSecondValue * interpolationValue);
                }
                if (setNineSliceInstance1TextureWidthFirstValue && setNineSliceInstance1TextureWidthSecondValue)
                {
                    NineSliceInstance1.TextureWidth = FlatRedBall.Math.MathFunctions.RoundToInt(NineSliceInstance1TextureWidthFirstValue* (1 - interpolationValue) + NineSliceInstance1TextureWidthSecondValue * interpolationValue);
                }
                if (setNineSliceInstance1WidthFirstValue && setNineSliceInstance1WidthSecondValue)
                {
                    NineSliceInstance1.Width = NineSliceInstance1WidthFirstValue * (1 - interpolationValue) + NineSliceInstance1WidthSecondValue * interpolationValue;
                }
                if (setNineSliceInstance1XFirstValue && setNineSliceInstance1XSecondValue)
                {
                    NineSliceInstance1.X = NineSliceInstance1XFirstValue * (1 - interpolationValue) + NineSliceInstance1XSecondValue * interpolationValue;
                }
                if (setNineSliceInstance1YFirstValue && setNineSliceInstance1YSecondValue)
                {
                    NineSliceInstance1.Y = NineSliceInstance1YFirstValue * (1 - interpolationValue) + NineSliceInstance1YSecondValue * interpolationValue;
                }
                if (setTextInstanceCurrentColorCategoryStateFirstValue && setTextInstanceCurrentColorCategoryStateSecondValue)
                {
                    TextInstance.InterpolateBetween(TextInstanceCurrentColorCategoryStateFirstValue, TextInstanceCurrentColorCategoryStateSecondValue, interpolationValue);
                }
                if (setTextInstanceHeightFirstValue && setTextInstanceHeightSecondValue)
                {
                    TextInstance.Height = TextInstanceHeightFirstValue * (1 - interpolationValue) + TextInstanceHeightSecondValue * interpolationValue;
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
                bool setTextInstanceCurrentColorCategoryStateFirstValue = false;
                bool setTextInstanceCurrentColorCategoryStateSecondValue = false;
                JHP4SD.GumRuntimes.TextRuntime.ColorCategory TextInstanceCurrentColorCategoryStateFirstValue= JHP4SD.GumRuntimes.TextRuntime.ColorCategory.Gray;
                JHP4SD.GumRuntimes.TextRuntime.ColorCategory TextInstanceCurrentColorCategoryStateSecondValue= JHP4SD.GumRuntimes.TextRuntime.ColorCategory.Gray;
                switch(firstState)
                {
                    case  ToggleCategory.EnabledOn:
                        if (interpolationValue < 1)
                        {
                            this.ColoredRectangleInstance.Visible = true;
                        }
                        setNineSliceInstanceBlueFirstValue = true;
                        NineSliceInstanceBlueFirstValue = 255;
                        setNineSliceInstanceCurrentColorCategoryStateFirstValue = true;
                        NineSliceInstanceCurrentColorCategoryStateFirstValue = JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Blue;
                        setNineSliceInstanceGreenFirstValue = true;
                        NineSliceInstanceGreenFirstValue = 255;
                        setNineSliceInstanceRedFirstValue = true;
                        NineSliceInstanceRedFirstValue = 255;
                        setTextInstanceCurrentColorCategoryStateFirstValue = true;
                        TextInstanceCurrentColorCategoryStateFirstValue = JHP4SD.GumRuntimes.TextRuntime.ColorCategory.Gray;
                        break;
                    case  ToggleCategory.EnabledOff:
                        if (interpolationValue < 1)
                        {
                            this.ColoredRectangleInstance.Visible = false;
                        }
                        setNineSliceInstanceBlueFirstValue = true;
                        NineSliceInstanceBlueFirstValue = 255;
                        setNineSliceInstanceCurrentColorCategoryStateFirstValue = true;
                        NineSliceInstanceCurrentColorCategoryStateFirstValue = JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Blue;
                        setNineSliceInstanceGreenFirstValue = true;
                        NineSliceInstanceGreenFirstValue = 255;
                        setNineSliceInstanceRedFirstValue = true;
                        NineSliceInstanceRedFirstValue = 255;
                        setTextInstanceCurrentColorCategoryStateFirstValue = true;
                        TextInstanceCurrentColorCategoryStateFirstValue = JHP4SD.GumRuntimes.TextRuntime.ColorCategory.Gray;
                        break;
                    case  ToggleCategory.DisabledOn:
                        if (interpolationValue < 1)
                        {
                            this.ColoredRectangleInstance.Visible = true;
                        }
                        setNineSliceInstanceBlueFirstValue = true;
                        NineSliceInstanceBlueFirstValue = 255;
                        setNineSliceInstanceCurrentColorCategoryStateFirstValue = true;
                        NineSliceInstanceCurrentColorCategoryStateFirstValue = JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Black;
                        setNineSliceInstanceGreenFirstValue = true;
                        NineSliceInstanceGreenFirstValue = 255;
                        setNineSliceInstanceRedFirstValue = true;
                        NineSliceInstanceRedFirstValue = 255;
                        setTextInstanceCurrentColorCategoryStateFirstValue = true;
                        TextInstanceCurrentColorCategoryStateFirstValue = JHP4SD.GumRuntimes.TextRuntime.ColorCategory.Gray;
                        break;
                    case  ToggleCategory.DisabledOff:
                        if (interpolationValue < 1)
                        {
                            this.ColoredRectangleInstance.Visible = false;
                        }
                        setNineSliceInstanceBlueFirstValue = true;
                        NineSliceInstanceBlueFirstValue = 255;
                        setNineSliceInstanceCurrentColorCategoryStateFirstValue = true;
                        NineSliceInstanceCurrentColorCategoryStateFirstValue = JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Black;
                        setNineSliceInstanceGreenFirstValue = true;
                        NineSliceInstanceGreenFirstValue = 255;
                        setNineSliceInstanceRedFirstValue = true;
                        NineSliceInstanceRedFirstValue = 255;
                        setTextInstanceCurrentColorCategoryStateFirstValue = true;
                        TextInstanceCurrentColorCategoryStateFirstValue = JHP4SD.GumRuntimes.TextRuntime.ColorCategory.Gray;
                        break;
                    case  ToggleCategory.HighlightedOn:
                        if (interpolationValue < 1)
                        {
                            this.ColoredRectangleInstance.Visible = true;
                        }
                        setNineSliceInstanceBlueFirstValue = true;
                        NineSliceInstanceBlueFirstValue = 255;
                        setNineSliceInstanceCurrentColorCategoryStateFirstValue = true;
                        NineSliceInstanceCurrentColorCategoryStateFirstValue = JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Yellow;
                        setNineSliceInstanceGreenFirstValue = true;
                        NineSliceInstanceGreenFirstValue = 255;
                        setNineSliceInstanceRedFirstValue = true;
                        NineSliceInstanceRedFirstValue = 255;
                        setTextInstanceCurrentColorCategoryStateFirstValue = true;
                        TextInstanceCurrentColorCategoryStateFirstValue = JHP4SD.GumRuntimes.TextRuntime.ColorCategory.Black;
                        break;
                    case  ToggleCategory.HighlightedOff:
                        if (interpolationValue < 1)
                        {
                            this.ColoredRectangleInstance.Visible = false;
                        }
                        setNineSliceInstanceBlueFirstValue = true;
                        NineSliceInstanceBlueFirstValue = 255;
                        setNineSliceInstanceCurrentColorCategoryStateFirstValue = true;
                        NineSliceInstanceCurrentColorCategoryStateFirstValue = JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Yellow;
                        setNineSliceInstanceGreenFirstValue = true;
                        NineSliceInstanceGreenFirstValue = 255;
                        setNineSliceInstanceRedFirstValue = true;
                        NineSliceInstanceRedFirstValue = 255;
                        setTextInstanceCurrentColorCategoryStateFirstValue = true;
                        TextInstanceCurrentColorCategoryStateFirstValue = JHP4SD.GumRuntimes.TextRuntime.ColorCategory.Black;
                        break;
                    case  ToggleCategory.PushedOn:
                        if (interpolationValue < 1)
                        {
                            this.ColoredRectangleInstance.Visible = true;
                        }
                        setNineSliceInstanceBlueFirstValue = true;
                        NineSliceInstanceBlueFirstValue = 200;
                        setNineSliceInstanceCurrentColorCategoryStateFirstValue = true;
                        NineSliceInstanceCurrentColorCategoryStateFirstValue = JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Yellow;
                        setNineSliceInstanceGreenFirstValue = true;
                        NineSliceInstanceGreenFirstValue = 200;
                        setNineSliceInstanceRedFirstValue = true;
                        NineSliceInstanceRedFirstValue = 200;
                        setTextInstanceCurrentColorCategoryStateFirstValue = true;
                        TextInstanceCurrentColorCategoryStateFirstValue = JHP4SD.GumRuntimes.TextRuntime.ColorCategory.Black;
                        break;
                    case  ToggleCategory.PushedOff:
                        if (interpolationValue < 1)
                        {
                            this.ColoredRectangleInstance.Visible = false;
                        }
                        setNineSliceInstanceBlueFirstValue = true;
                        NineSliceInstanceBlueFirstValue = 200;
                        setNineSliceInstanceCurrentColorCategoryStateFirstValue = true;
                        NineSliceInstanceCurrentColorCategoryStateFirstValue = JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Yellow;
                        setNineSliceInstanceGreenFirstValue = true;
                        NineSliceInstanceGreenFirstValue = 200;
                        setNineSliceInstanceRedFirstValue = true;
                        NineSliceInstanceRedFirstValue = 200;
                        setTextInstanceCurrentColorCategoryStateFirstValue = true;
                        TextInstanceCurrentColorCategoryStateFirstValue = JHP4SD.GumRuntimes.TextRuntime.ColorCategory.Black;
                        break;
                }
                switch(secondState)
                {
                    case  ToggleCategory.EnabledOn:
                        if (interpolationValue >= 1)
                        {
                            this.ColoredRectangleInstance.Visible = true;
                        }
                        setNineSliceInstanceBlueSecondValue = true;
                        NineSliceInstanceBlueSecondValue = 255;
                        setNineSliceInstanceCurrentColorCategoryStateSecondValue = true;
                        NineSliceInstanceCurrentColorCategoryStateSecondValue = JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Blue;
                        setNineSliceInstanceGreenSecondValue = true;
                        NineSliceInstanceGreenSecondValue = 255;
                        setNineSliceInstanceRedSecondValue = true;
                        NineSliceInstanceRedSecondValue = 255;
                        setTextInstanceCurrentColorCategoryStateSecondValue = true;
                        TextInstanceCurrentColorCategoryStateSecondValue = JHP4SD.GumRuntimes.TextRuntime.ColorCategory.Gray;
                        break;
                    case  ToggleCategory.EnabledOff:
                        if (interpolationValue >= 1)
                        {
                            this.ColoredRectangleInstance.Visible = false;
                        }
                        setNineSliceInstanceBlueSecondValue = true;
                        NineSliceInstanceBlueSecondValue = 255;
                        setNineSliceInstanceCurrentColorCategoryStateSecondValue = true;
                        NineSliceInstanceCurrentColorCategoryStateSecondValue = JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Blue;
                        setNineSliceInstanceGreenSecondValue = true;
                        NineSliceInstanceGreenSecondValue = 255;
                        setNineSliceInstanceRedSecondValue = true;
                        NineSliceInstanceRedSecondValue = 255;
                        setTextInstanceCurrentColorCategoryStateSecondValue = true;
                        TextInstanceCurrentColorCategoryStateSecondValue = JHP4SD.GumRuntimes.TextRuntime.ColorCategory.Gray;
                        break;
                    case  ToggleCategory.DisabledOn:
                        if (interpolationValue >= 1)
                        {
                            this.ColoredRectangleInstance.Visible = true;
                        }
                        setNineSliceInstanceBlueSecondValue = true;
                        NineSliceInstanceBlueSecondValue = 255;
                        setNineSliceInstanceCurrentColorCategoryStateSecondValue = true;
                        NineSliceInstanceCurrentColorCategoryStateSecondValue = JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Black;
                        setNineSliceInstanceGreenSecondValue = true;
                        NineSliceInstanceGreenSecondValue = 255;
                        setNineSliceInstanceRedSecondValue = true;
                        NineSliceInstanceRedSecondValue = 255;
                        setTextInstanceCurrentColorCategoryStateSecondValue = true;
                        TextInstanceCurrentColorCategoryStateSecondValue = JHP4SD.GumRuntimes.TextRuntime.ColorCategory.Gray;
                        break;
                    case  ToggleCategory.DisabledOff:
                        if (interpolationValue >= 1)
                        {
                            this.ColoredRectangleInstance.Visible = false;
                        }
                        setNineSliceInstanceBlueSecondValue = true;
                        NineSliceInstanceBlueSecondValue = 255;
                        setNineSliceInstanceCurrentColorCategoryStateSecondValue = true;
                        NineSliceInstanceCurrentColorCategoryStateSecondValue = JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Black;
                        setNineSliceInstanceGreenSecondValue = true;
                        NineSliceInstanceGreenSecondValue = 255;
                        setNineSliceInstanceRedSecondValue = true;
                        NineSliceInstanceRedSecondValue = 255;
                        setTextInstanceCurrentColorCategoryStateSecondValue = true;
                        TextInstanceCurrentColorCategoryStateSecondValue = JHP4SD.GumRuntimes.TextRuntime.ColorCategory.Gray;
                        break;
                    case  ToggleCategory.HighlightedOn:
                        if (interpolationValue >= 1)
                        {
                            this.ColoredRectangleInstance.Visible = true;
                        }
                        setNineSliceInstanceBlueSecondValue = true;
                        NineSliceInstanceBlueSecondValue = 255;
                        setNineSliceInstanceCurrentColorCategoryStateSecondValue = true;
                        NineSliceInstanceCurrentColorCategoryStateSecondValue = JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Yellow;
                        setNineSliceInstanceGreenSecondValue = true;
                        NineSliceInstanceGreenSecondValue = 255;
                        setNineSliceInstanceRedSecondValue = true;
                        NineSliceInstanceRedSecondValue = 255;
                        setTextInstanceCurrentColorCategoryStateSecondValue = true;
                        TextInstanceCurrentColorCategoryStateSecondValue = JHP4SD.GumRuntimes.TextRuntime.ColorCategory.Black;
                        break;
                    case  ToggleCategory.HighlightedOff:
                        if (interpolationValue >= 1)
                        {
                            this.ColoredRectangleInstance.Visible = false;
                        }
                        setNineSliceInstanceBlueSecondValue = true;
                        NineSliceInstanceBlueSecondValue = 255;
                        setNineSliceInstanceCurrentColorCategoryStateSecondValue = true;
                        NineSliceInstanceCurrentColorCategoryStateSecondValue = JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Yellow;
                        setNineSliceInstanceGreenSecondValue = true;
                        NineSliceInstanceGreenSecondValue = 255;
                        setNineSliceInstanceRedSecondValue = true;
                        NineSliceInstanceRedSecondValue = 255;
                        setTextInstanceCurrentColorCategoryStateSecondValue = true;
                        TextInstanceCurrentColorCategoryStateSecondValue = JHP4SD.GumRuntimes.TextRuntime.ColorCategory.Black;
                        break;
                    case  ToggleCategory.PushedOn:
                        if (interpolationValue >= 1)
                        {
                            this.ColoredRectangleInstance.Visible = true;
                        }
                        setNineSliceInstanceBlueSecondValue = true;
                        NineSliceInstanceBlueSecondValue = 200;
                        setNineSliceInstanceCurrentColorCategoryStateSecondValue = true;
                        NineSliceInstanceCurrentColorCategoryStateSecondValue = JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Yellow;
                        setNineSliceInstanceGreenSecondValue = true;
                        NineSliceInstanceGreenSecondValue = 200;
                        setNineSliceInstanceRedSecondValue = true;
                        NineSliceInstanceRedSecondValue = 200;
                        setTextInstanceCurrentColorCategoryStateSecondValue = true;
                        TextInstanceCurrentColorCategoryStateSecondValue = JHP4SD.GumRuntimes.TextRuntime.ColorCategory.Black;
                        break;
                    case  ToggleCategory.PushedOff:
                        if (interpolationValue >= 1)
                        {
                            this.ColoredRectangleInstance.Visible = false;
                        }
                        setNineSliceInstanceBlueSecondValue = true;
                        NineSliceInstanceBlueSecondValue = 200;
                        setNineSliceInstanceCurrentColorCategoryStateSecondValue = true;
                        NineSliceInstanceCurrentColorCategoryStateSecondValue = JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Yellow;
                        setNineSliceInstanceGreenSecondValue = true;
                        NineSliceInstanceGreenSecondValue = 200;
                        setNineSliceInstanceRedSecondValue = true;
                        NineSliceInstanceRedSecondValue = 200;
                        setTextInstanceCurrentColorCategoryStateSecondValue = true;
                        TextInstanceCurrentColorCategoryStateSecondValue = JHP4SD.GumRuntimes.TextRuntime.ColorCategory.Black;
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
                if (setTextInstanceCurrentColorCategoryStateFirstValue && setTextInstanceCurrentColorCategoryStateSecondValue)
                {
                    TextInstance.InterpolateBetween(TextInstanceCurrentColorCategoryStateFirstValue, TextInstanceCurrentColorCategoryStateSecondValue, interpolationValue);
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
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (JHP4SD.GumRuntimes.DefaultForms.ToggleButton1Runtime.VariableState fromState,JHP4SD.GumRuntimes.DefaultForms.ToggleButton1Runtime.VariableState toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null) 
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
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (JHP4SD.GumRuntimes.DefaultForms.ToggleButton1Runtime.ToggleCategory fromState,JHP4SD.GumRuntimes.DefaultForms.ToggleButton1Runtime.ToggleCategory toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null) 
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
                            Name = "NineSliceInstance.ColorCategoryState",
                            Type = "ColorCategoryState",
                            Value = NineSliceInstance.CurrentColorCategoryState
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
                            Name = "TextInstance.ColorCategoryState",
                            Type = "ColorCategoryState",
                            Value = TextInstance.CurrentColorCategoryState
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
                            Name = "TextInstance.VerticalAlignment",
                            Type = "VerticalAlignment",
                            Value = TextInstance.VerticalAlignment
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
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NineSliceInstance1.Height",
                            Type = "float",
                            Value = NineSliceInstance1.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NineSliceInstance1.SourceFile",
                            Type = "string",
                            Value = NineSliceInstance1.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NineSliceInstance1.Texture Address",
                            Type = "TextureAddress",
                            Value = NineSliceInstance1.TextureAddress
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NineSliceInstance1.Texture Height",
                            Type = "int",
                            Value = NineSliceInstance1.TextureHeight
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NineSliceInstance1.Texture Left",
                            Type = "int",
                            Value = NineSliceInstance1.TextureLeft
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NineSliceInstance1.Texture Top",
                            Type = "int",
                            Value = NineSliceInstance1.TextureTop
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NineSliceInstance1.Texture Width",
                            Type = "int",
                            Value = NineSliceInstance1.TextureWidth
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NineSliceInstance1.Width",
                            Type = "float",
                            Value = NineSliceInstance1.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NineSliceInstance1.Width Units",
                            Type = "DimensionUnitType",
                            Value = NineSliceInstance1.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NineSliceInstance1.X",
                            Type = "float",
                            Value = NineSliceInstance1.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NineSliceInstance1.X Origin",
                            Type = "HorizontalAlignment",
                            Value = NineSliceInstance1.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NineSliceInstance1.X Units",
                            Type = "PositionUnitType",
                            Value = NineSliceInstance1.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NineSliceInstance1.Y",
                            Type = "float",
                            Value = NineSliceInstance1.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NineSliceInstance1.Y Origin",
                            Type = "VerticalAlignment",
                            Value = NineSliceInstance1.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NineSliceInstance1.Y Units",
                            Type = "PositionUnitType",
                            Value = NineSliceInstance1.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance.Blue",
                            Type = "int",
                            Value = ColoredRectangleInstance.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance.Green",
                            Type = "int",
                            Value = ColoredRectangleInstance.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance.Height",
                            Type = "float",
                            Value = ColoredRectangleInstance.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance.Red",
                            Type = "int",
                            Value = ColoredRectangleInstance.Red
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance.Width",
                            Type = "float",
                            Value = ColoredRectangleInstance.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance.Width Units",
                            Type = "DimensionUnitType",
                            Value = ColoredRectangleInstance.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance.X",
                            Type = "float",
                            Value = ColoredRectangleInstance.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance.X Origin",
                            Type = "HorizontalAlignment",
                            Value = ColoredRectangleInstance.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance.X Units",
                            Type = "PositionUnitType",
                            Value = ColoredRectangleInstance.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance.Y",
                            Type = "float",
                            Value = ColoredRectangleInstance.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance.Y Origin",
                            Type = "VerticalAlignment",
                            Value = ColoredRectangleInstance.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance.Y Units",
                            Type = "PositionUnitType",
                            Value = ColoredRectangleInstance.YUnits
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
                            Value = Height + 48f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Width",
                            Type = "float",
                            Value = Width + 256f
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
                            Name = "TextInstance.ColorCategoryState",
                            Type = "ColorCategoryState",
                            Value = TextInstance.CurrentColorCategoryState
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
                            Name = "TextInstance.VerticalAlignment",
                            Type = "VerticalAlignment",
                            Value = TextInstance.VerticalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Width",
                            Type = "float",
                            Value = TextInstance.Width + 0f
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
                            Value = TextInstance.X + 0f
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
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NineSliceInstance1.Height",
                            Type = "float",
                            Value = NineSliceInstance1.Height + 6f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NineSliceInstance1.SourceFile",
                            Type = "string",
                            Value = NineSliceInstance1.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NineSliceInstance1.Texture Address",
                            Type = "TextureAddress",
                            Value = NineSliceInstance1.TextureAddress
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NineSliceInstance1.Texture Height",
                            Type = "int",
                            Value = NineSliceInstance1.TextureHeight + 26
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NineSliceInstance1.Texture Left",
                            Type = "int",
                            Value = NineSliceInstance1.TextureLeft + 2
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NineSliceInstance1.Texture Top",
                            Type = "int",
                            Value = NineSliceInstance1.TextureTop + 338
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NineSliceInstance1.Texture Width",
                            Type = "int",
                            Value = NineSliceInstance1.TextureWidth + 44
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NineSliceInstance1.Width",
                            Type = "float",
                            Value = NineSliceInstance1.Width + -13f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NineSliceInstance1.Width Units",
                            Type = "DimensionUnitType",
                            Value = NineSliceInstance1.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NineSliceInstance1.X",
                            Type = "float",
                            Value = NineSliceInstance1.X + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NineSliceInstance1.X Origin",
                            Type = "HorizontalAlignment",
                            Value = NineSliceInstance1.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NineSliceInstance1.X Units",
                            Type = "PositionUnitType",
                            Value = NineSliceInstance1.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NineSliceInstance1.Y",
                            Type = "float",
                            Value = NineSliceInstance1.Y + -4f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NineSliceInstance1.Y Origin",
                            Type = "VerticalAlignment",
                            Value = NineSliceInstance1.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NineSliceInstance1.Y Units",
                            Type = "PositionUnitType",
                            Value = NineSliceInstance1.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance.Blue",
                            Type = "int",
                            Value = ColoredRectangleInstance.Blue + 49
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance.Green",
                            Type = "int",
                            Value = ColoredRectangleInstance.Green + 49
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance.Height",
                            Type = "float",
                            Value = ColoredRectangleInstance.Height + 2f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance.Red",
                            Type = "int",
                            Value = ColoredRectangleInstance.Red + 49
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance.Width",
                            Type = "float",
                            Value = ColoredRectangleInstance.Width + -19f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance.Width Units",
                            Type = "DimensionUnitType",
                            Value = ColoredRectangleInstance.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance.X",
                            Type = "float",
                            Value = ColoredRectangleInstance.X + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance.X Origin",
                            Type = "HorizontalAlignment",
                            Value = ColoredRectangleInstance.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance.X Units",
                            Type = "PositionUnitType",
                            Value = ColoredRectangleInstance.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance.Y",
                            Type = "float",
                            Value = ColoredRectangleInstance.Y + -6f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance.Y Origin",
                            Type = "VerticalAlignment",
                            Value = ColoredRectangleInstance.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance.Y Units",
                            Type = "PositionUnitType",
                            Value = ColoredRectangleInstance.YUnits
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
                            Name = "TextInstance.ColorCategoryState",
                            Type = "ColorCategoryState",
                            Value = TextInstance.CurrentColorCategoryState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance.Visible",
                            Type = "bool",
                            Value = ColoredRectangleInstance.Visible
                        }
                        );
                        break;
                    case  ToggleCategory.EnabledOff:
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
                            Name = "TextInstance.ColorCategoryState",
                            Type = "ColorCategoryState",
                            Value = TextInstance.CurrentColorCategoryState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance.Visible",
                            Type = "bool",
                            Value = ColoredRectangleInstance.Visible
                        }
                        );
                        break;
                    case  ToggleCategory.DisabledOn:
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
                            Name = "TextInstance.ColorCategoryState",
                            Type = "ColorCategoryState",
                            Value = TextInstance.CurrentColorCategoryState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance.Visible",
                            Type = "bool",
                            Value = ColoredRectangleInstance.Visible
                        }
                        );
                        break;
                    case  ToggleCategory.DisabledOff:
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
                            Name = "TextInstance.ColorCategoryState",
                            Type = "ColorCategoryState",
                            Value = TextInstance.CurrentColorCategoryState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance.Visible",
                            Type = "bool",
                            Value = ColoredRectangleInstance.Visible
                        }
                        );
                        break;
                    case  ToggleCategory.HighlightedOn:
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
                            Name = "TextInstance.ColorCategoryState",
                            Type = "ColorCategoryState",
                            Value = TextInstance.CurrentColorCategoryState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance.Visible",
                            Type = "bool",
                            Value = ColoredRectangleInstance.Visible
                        }
                        );
                        break;
                    case  ToggleCategory.HighlightedOff:
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
                            Name = "TextInstance.ColorCategoryState",
                            Type = "ColorCategoryState",
                            Value = TextInstance.CurrentColorCategoryState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance.Visible",
                            Type = "bool",
                            Value = ColoredRectangleInstance.Visible
                        }
                        );
                        break;
                    case  ToggleCategory.PushedOn:
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
                            Name = "TextInstance.ColorCategoryState",
                            Type = "ColorCategoryState",
                            Value = TextInstance.CurrentColorCategoryState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance.Visible",
                            Type = "bool",
                            Value = ColoredRectangleInstance.Visible
                        }
                        );
                        break;
                    case  ToggleCategory.PushedOff:
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
                            Name = "TextInstance.ColorCategoryState",
                            Type = "ColorCategoryState",
                            Value = TextInstance.CurrentColorCategoryState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance.Visible",
                            Type = "bool",
                            Value = ColoredRectangleInstance.Visible
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
                            Name = "TextInstance.ColorCategoryState",
                            Type = "ColorCategoryState",
                            Value = TextInstance.CurrentColorCategoryState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance.Visible",
                            Type = "bool",
                            Value = ColoredRectangleInstance.Visible
                        }
                        );
                        break;
                    case  ToggleCategory.EnabledOff:
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
                            Name = "TextInstance.ColorCategoryState",
                            Type = "ColorCategoryState",
                            Value = TextInstance.CurrentColorCategoryState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance.Visible",
                            Type = "bool",
                            Value = ColoredRectangleInstance.Visible
                        }
                        );
                        break;
                    case  ToggleCategory.DisabledOn:
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
                            Name = "TextInstance.ColorCategoryState",
                            Type = "ColorCategoryState",
                            Value = TextInstance.CurrentColorCategoryState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance.Visible",
                            Type = "bool",
                            Value = ColoredRectangleInstance.Visible
                        }
                        );
                        break;
                    case  ToggleCategory.DisabledOff:
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
                            Name = "TextInstance.ColorCategoryState",
                            Type = "ColorCategoryState",
                            Value = TextInstance.CurrentColorCategoryState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance.Visible",
                            Type = "bool",
                            Value = ColoredRectangleInstance.Visible
                        }
                        );
                        break;
                    case  ToggleCategory.HighlightedOn:
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
                            Name = "TextInstance.ColorCategoryState",
                            Type = "ColorCategoryState",
                            Value = TextInstance.CurrentColorCategoryState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance.Visible",
                            Type = "bool",
                            Value = ColoredRectangleInstance.Visible
                        }
                        );
                        break;
                    case  ToggleCategory.HighlightedOff:
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
                            Name = "TextInstance.ColorCategoryState",
                            Type = "ColorCategoryState",
                            Value = TextInstance.CurrentColorCategoryState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance.Visible",
                            Type = "bool",
                            Value = ColoredRectangleInstance.Visible
                        }
                        );
                        break;
                    case  ToggleCategory.PushedOn:
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
                            Name = "TextInstance.ColorCategoryState",
                            Type = "ColorCategoryState",
                            Value = TextInstance.CurrentColorCategoryState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance.Visible",
                            Type = "bool",
                            Value = ColoredRectangleInstance.Visible
                        }
                        );
                        break;
                    case  ToggleCategory.PushedOff:
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
                            Name = "TextInstance.ColorCategoryState",
                            Type = "ColorCategoryState",
                            Value = TextInstance.CurrentColorCategoryState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance.Visible",
                            Type = "bool",
                            Value = ColoredRectangleInstance.Visible
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
            public JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime NineSliceInstance { get; set; }
            public JHP4SD.GumRuntimes.TextRuntime TextInstance { get; set; }
            public JHP4SD.GumRuntimes.NineSliceRuntime NineSliceInstance1 { get; set; }
            public JHP4SD.GumRuntimes.ColoredRectangleRuntime ColoredRectangleInstance { get; set; }
            public string Text
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
                        TextChanged?.Invoke(this, null);
                    }
                }
            }
            public event System.EventHandler TextChanged;
            public ToggleButton1Runtime (bool fullInstantiation = true, bool tryCreateFormsObject = true) 
            	: base(false, tryCreateFormsObject)
            {
                this.tryCreateFormsObject = tryCreateFormsObject;
                this.ExposeChildrenEvents = false;
                if (fullInstantiation)
                {
                    Gum.DataTypes.ElementSave elementSave = Gum.Managers.ObjectFinder.Self.GumProjectSave.Components.First(item => item.Name == "DefaultForms/ToggleButton1");
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
                TextInstance = this.GetGraphicalUiElementByName("TextInstance") as JHP4SD.GumRuntimes.TextRuntime;
                NineSliceInstance1 = this.GetGraphicalUiElementByName("NineSliceInstance1") as JHP4SD.GumRuntimes.NineSliceRuntime;
                ColoredRectangleInstance = this.GetGraphicalUiElementByName("ColoredRectangleInstance") as JHP4SD.GumRuntimes.ColoredRectangleRuntime;
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
