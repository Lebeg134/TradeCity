    using System.Linq;
    namespace JHP4SD.GumRuntimes.LebegForms.BasicComponents
    {
        public partial class TabButtonRuntime : JHP4SD.GumRuntimes.ContainerRuntime
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
                            TextInstance.Parent = this.GetGraphicalUiElementByName("NineSliceInstance") ?? this;
                            HighlightRectangle.Parent = this.GetGraphicalUiElementByName("NineSliceInstance") ?? this;
                            NineSliceInstance.CurrentColorCategoryState = JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Gray;
                            TextInstance.CurrentColorCategoryState = JHP4SD.GumRuntimes.TextRuntime.ColorCategory.Gray;
                            Height = 110f;
                            HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            Width = 32f;
                            WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            X = 1f;
                            XUnits = Gum.Converters.GeneralUnitType.Percentage;
                            Y = 0f;
                            NineSliceInstance.Blue = 128;
                            NineSliceInstance.Green = 128;
                            NineSliceInstance.Height = 0f;
                            NineSliceInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                            NineSliceInstance.Red = 128;
                            NineSliceInstance.Width = 0f;
                            NineSliceInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                            NineSliceInstance.X = 0f;
                            NineSliceInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                            NineSliceInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            NineSliceInstance.Y = 0f;
                            NineSliceInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            NineSliceInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            TextInstance.Blue = 0;
                            TextInstance.FontSize = 24;
                            TextInstance.Green = 0;
                            TextInstance.Height = 0f;
                            TextInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                            TextInstance.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                            TextInstance.Red = 0;
                            TextInstance.Text = "Tab";
                            TextInstance.VerticalAlignment = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            TextInstance.Width = 0f;
                            TextInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                            TextInstance.X = 0f;
                            TextInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                            TextInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            TextInstance.Y = 0f;
                            TextInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            TextInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
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
                                HighlightRectangle.Parent = this.GetGraphicalUiElementByName("NineSliceInstance") ?? this;
                                NineSliceInstance.CurrentColorCategoryState = JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Gray;
                                TextInstance.CurrentColorCategoryState = JHP4SD.GumRuntimes.TextRuntime.ColorCategory.Black;
                                NineSliceInstance.Alpha = 255;
                                NineSliceInstance.Blend = Gum.RenderingLibrary.Blend.Normal;
                                NineSliceInstance.Blue = 128;
                                NineSliceInstance.Green = 128;
                                NineSliceInstance.Red = 128;
                                NineSliceInstance.Y = 0f;
                                NineSliceInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                                NineSliceInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                                TextInstance.Blue = 0;
                                TextInstance.Green = 0;
                                TextInstance.Height = 0f;
                                TextInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                                TextInstance.Red = 0;
                                TextInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                                HighlightRectangle.Visible = false;
                                HighlightRectangle.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                                HighlightRectangle.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                                break;
                            case  ButtonCategory.Disabled:
                                HighlightRectangle.Parent = this.GetGraphicalUiElementByName("NineSliceInstance") ?? this;
                                NineSliceInstance.CurrentColorCategoryState = JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Gray;
                                TextInstance.CurrentColorCategoryState = JHP4SD.GumRuntimes.TextRuntime.ColorCategory.Gray;
                                NineSliceInstance.Alpha = 255;
                                NineSliceInstance.Blend = Gum.RenderingLibrary.Blend.Normal;
                                NineSliceInstance.Blue = 255;
                                NineSliceInstance.Green = 255;
                                NineSliceInstance.Red = 255;
                                NineSliceInstance.Y = -5f;
                                NineSliceInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Top;
                                NineSliceInstance.YUnits = Gum.Converters.GeneralUnitType.Percentage;
                                TextInstance.Blue = 0;
                                TextInstance.Green = 0;
                                TextInstance.Height = 0f;
                                TextInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                                TextInstance.Red = 0;
                                TextInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                                HighlightRectangle.Visible = false;
                                HighlightRectangle.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                                HighlightRectangle.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                                break;
                            case  ButtonCategory.Highlighted:
                                HighlightRectangle.Parent = this.GetGraphicalUiElementByName("NineSliceInstance") ?? this;
                                NineSliceInstance.CurrentColorCategoryState = JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Gray;
                                TextInstance.CurrentColorCategoryState = JHP4SD.GumRuntimes.TextRuntime.ColorCategory.Black;
                                NineSliceInstance.Alpha = 255;
                                NineSliceInstance.Blue = 255;
                                NineSliceInstance.Green = 255;
                                NineSliceInstance.Red = 208;
                                NineSliceInstance.Y = -5f;
                                NineSliceInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Top;
                                NineSliceInstance.YUnits = Gum.Converters.GeneralUnitType.Percentage;
                                TextInstance.Blue = 0;
                                TextInstance.Green = 0;
                                TextInstance.Height = 0f;
                                TextInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                                TextInstance.Red = 0;
                                TextInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                                HighlightRectangle.Visible = false;
                                HighlightRectangle.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                                HighlightRectangle.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                                break;
                            case  ButtonCategory.Pushed:
                                HighlightRectangle.Parent = this.GetGraphicalUiElementByName("NineSliceInstance") ?? this;
                                NineSliceInstance.CurrentColorCategoryState = JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Gray;
                                TextInstance.CurrentColorCategoryState = JHP4SD.GumRuntimes.TextRuntime.ColorCategory.Black;
                                NineSliceInstance.Alpha = 255;
                                NineSliceInstance.Blend = Gum.RenderingLibrary.Blend.Normal;
                                NineSliceInstance.Blue = 200;
                                NineSliceInstance.Green = 200;
                                NineSliceInstance.Red = 200;
                                NineSliceInstance.Y = -2f;
                                NineSliceInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Top;
                                NineSliceInstance.YUnits = Gum.Converters.GeneralUnitType.Percentage;
                                TextInstance.Blue = 0;
                                TextInstance.Green = 0;
                                TextInstance.Height = 0f;
                                TextInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                                TextInstance.Red = 0;
                                TextInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                                HighlightRectangle.Visible = false;
                                HighlightRectangle.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                                HighlightRectangle.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                                break;
                            case  ButtonCategory.HighlightedFocused:
                                HighlightRectangle.Parent = this.GetGraphicalUiElementByName("NineSliceInstance") ?? this;
                                NineSliceInstance.CurrentColorCategoryState = JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Gray;
                                TextInstance.CurrentColorCategoryState = JHP4SD.GumRuntimes.TextRuntime.ColorCategory.Black;
                                NineSliceInstance.Alpha = 255;
                                NineSliceInstance.Blend = Gum.RenderingLibrary.Blend.Normal;
                                NineSliceInstance.Blue = 255;
                                NineSliceInstance.Green = 255;
                                NineSliceInstance.Red = 208;
                                NineSliceInstance.Y = -5f;
                                NineSliceInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Top;
                                NineSliceInstance.YUnits = Gum.Converters.GeneralUnitType.Percentage;
                                TextInstance.Blue = 0;
                                TextInstance.Green = 0;
                                TextInstance.Height = 0f;
                                TextInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                                TextInstance.Red = 0;
                                TextInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                                HighlightRectangle.Visible = true;
                                HighlightRectangle.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                                HighlightRectangle.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                                break;
                            case  ButtonCategory.Focused:
                                HighlightRectangle.Parent = this.GetGraphicalUiElementByName("NineSliceInstance") ?? this;
                                NineSliceInstance.CurrentColorCategoryState = JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Gray;
                                TextInstance.CurrentColorCategoryState = JHP4SD.GumRuntimes.TextRuntime.ColorCategory.Gray;
                                NineSliceInstance.Alpha = 255;
                                NineSliceInstance.Blend = Gum.RenderingLibrary.Blend.Normal;
                                NineSliceInstance.Blue = 128;
                                NineSliceInstance.Green = 128;
                                NineSliceInstance.Red = 128;
                                NineSliceInstance.Y = 0f;
                                NineSliceInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                                NineSliceInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                                TextInstance.Blue = 0;
                                TextInstance.Green = 0;
                                TextInstance.Height = 0f;
                                TextInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                                TextInstance.Red = 0;
                                TextInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                                HighlightRectangle.Visible = true;
                                HighlightRectangle.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                                HighlightRectangle.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                                break;
                            case  ButtonCategory.DisabledFocused:
                                HighlightRectangle.Parent = this.GetGraphicalUiElementByName("NineSliceInstance") ?? this;
                                NineSliceInstance.CurrentColorCategoryState = JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Gray;
                                TextInstance.CurrentColorCategoryState = JHP4SD.GumRuntimes.TextRuntime.ColorCategory.Gray;
                                NineSliceInstance.Alpha = 255;
                                NineSliceInstance.Blend = Gum.RenderingLibrary.Blend.Normal;
                                NineSliceInstance.Blue = 201;
                                NineSliceInstance.Green = 201;
                                NineSliceInstance.Red = 201;
                                NineSliceInstance.Y = -5f;
                                NineSliceInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Top;
                                NineSliceInstance.YUnits = Gum.Converters.GeneralUnitType.Percentage;
                                TextInstance.Blue = 0;
                                TextInstance.Green = 0;
                                TextInstance.Height = 0f;
                                TextInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                                TextInstance.Red = 0;
                                TextInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                                HighlightRectangle.Visible = true;
                                HighlightRectangle.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                                HighlightRectangle.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
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
                bool setTextInstanceBlueFirstValue = false;
                bool setTextInstanceBlueSecondValue = false;
                int TextInstanceBlueFirstValue= 0;
                int TextInstanceBlueSecondValue= 0;
                bool setTextInstanceCurrentColorCategoryStateFirstValue = false;
                bool setTextInstanceCurrentColorCategoryStateSecondValue = false;
                JHP4SD.GumRuntimes.TextRuntime.ColorCategory TextInstanceCurrentColorCategoryStateFirstValue= JHP4SD.GumRuntimes.TextRuntime.ColorCategory.Gray;
                JHP4SD.GumRuntimes.TextRuntime.ColorCategory TextInstanceCurrentColorCategoryStateSecondValue= JHP4SD.GumRuntimes.TextRuntime.ColorCategory.Gray;
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
                        HeightFirstValue = 110f;
                        if (interpolationValue < 1)
                        {
                            this.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setHighlightRectangleHeightFirstValue = true;
                        HighlightRectangleHeightFirstValue = -6f;
                        if (interpolationValue < 1)
                        {
                            this.HighlightRectangle.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        if (interpolationValue < 1)
                        {
                            this.HighlightRectangle.Parent = this.GetGraphicalUiElementByName("NineSliceInstance") ?? this;
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
                        NineSliceInstanceBlueFirstValue = 128;
                        setNineSliceInstanceCurrentColorCategoryStateFirstValue = true;
                        NineSliceInstanceCurrentColorCategoryStateFirstValue = JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Gray;
                        setNineSliceInstanceGreenFirstValue = true;
                        NineSliceInstanceGreenFirstValue = 128;
                        setNineSliceInstanceHeightFirstValue = true;
                        NineSliceInstanceHeightFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.NineSliceInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        setNineSliceInstanceRedFirstValue = true;
                        NineSliceInstanceRedFirstValue = 128;
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
                        setTextInstanceBlueFirstValue = true;
                        TextInstanceBlueFirstValue = 0;
                        setTextInstanceCurrentColorCategoryStateFirstValue = true;
                        TextInstanceCurrentColorCategoryStateFirstValue = JHP4SD.GumRuntimes.TextRuntime.ColorCategory.Gray;
                        setTextInstanceFontSizeFirstValue = true;
                        TextInstanceFontSizeFirstValue = 24;
                        setTextInstanceGreenFirstValue = true;
                        TextInstanceGreenFirstValue = 0;
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
                            this.TextInstance.Parent = this.GetGraphicalUiElementByName("NineSliceInstance") ?? this;
                        }
                        setTextInstanceRedFirstValue = true;
                        TextInstanceRedFirstValue = 0;
                        if (interpolationValue < 1)
                        {
                            this.TextInstance.Text = "Tab";
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
                        WidthFirstValue = 32f;
                        if (interpolationValue < 1)
                        {
                            this.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setXFirstValue = true;
                        XFirstValue = 1f;
                        if (interpolationValue < 1)
                        {
                            this.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setYFirstValue = true;
                        YFirstValue = 0f;
                        break;
                }
                switch(secondState)
                {
                    case  VariableState.Default:
                        setHeightSecondValue = true;
                        HeightSecondValue = 110f;
                        if (interpolationValue >= 1)
                        {
                            this.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setHighlightRectangleHeightSecondValue = true;
                        HighlightRectangleHeightSecondValue = -6f;
                        if (interpolationValue >= 1)
                        {
                            this.HighlightRectangle.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.HighlightRectangle.Parent = this.GetGraphicalUiElementByName("NineSliceInstance") ?? this;
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
                        NineSliceInstanceBlueSecondValue = 128;
                        setNineSliceInstanceCurrentColorCategoryStateSecondValue = true;
                        NineSliceInstanceCurrentColorCategoryStateSecondValue = JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Gray;
                        setNineSliceInstanceGreenSecondValue = true;
                        NineSliceInstanceGreenSecondValue = 128;
                        setNineSliceInstanceHeightSecondValue = true;
                        NineSliceInstanceHeightSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.NineSliceInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        setNineSliceInstanceRedSecondValue = true;
                        NineSliceInstanceRedSecondValue = 128;
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
                        setTextInstanceBlueSecondValue = true;
                        TextInstanceBlueSecondValue = 0;
                        setTextInstanceCurrentColorCategoryStateSecondValue = true;
                        TextInstanceCurrentColorCategoryStateSecondValue = JHP4SD.GumRuntimes.TextRuntime.ColorCategory.Gray;
                        setTextInstanceFontSizeSecondValue = true;
                        TextInstanceFontSizeSecondValue = 24;
                        setTextInstanceGreenSecondValue = true;
                        TextInstanceGreenSecondValue = 0;
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
                            this.TextInstance.Parent = this.GetGraphicalUiElementByName("NineSliceInstance") ?? this;
                        }
                        setTextInstanceRedSecondValue = true;
                        TextInstanceRedSecondValue = 0;
                        if (interpolationValue >= 1)
                        {
                            this.TextInstance.Text = "Tab";
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
                        WidthSecondValue = 32f;
                        if (interpolationValue >= 1)
                        {
                            this.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setXSecondValue = true;
                        XSecondValue = 1f;
                        if (interpolationValue >= 1)
                        {
                            this.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
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
                if (setTextInstanceBlueFirstValue && setTextInstanceBlueSecondValue)
                {
                    TextInstance.Blue = FlatRedBall.Math.MathFunctions.RoundToInt(TextInstanceBlueFirstValue* (1 - interpolationValue) + TextInstanceBlueSecondValue * interpolationValue);
                }
                if (setTextInstanceCurrentColorCategoryStateFirstValue && setTextInstanceCurrentColorCategoryStateSecondValue)
                {
                    TextInstance.InterpolateBetween(TextInstanceCurrentColorCategoryStateFirstValue, TextInstanceCurrentColorCategoryStateSecondValue, interpolationValue);
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
                bool setNineSliceInstanceAlphaFirstValue = false;
                bool setNineSliceInstanceAlphaSecondValue = false;
                int NineSliceInstanceAlphaFirstValue= 0;
                int NineSliceInstanceAlphaSecondValue= 0;
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
                bool setNineSliceInstanceYFirstValue = false;
                bool setNineSliceInstanceYSecondValue = false;
                float NineSliceInstanceYFirstValue= 0;
                float NineSliceInstanceYSecondValue= 0;
                bool setTextInstanceBlueFirstValue = false;
                bool setTextInstanceBlueSecondValue = false;
                int TextInstanceBlueFirstValue= 0;
                int TextInstanceBlueSecondValue= 0;
                bool setTextInstanceCurrentColorCategoryStateFirstValue = false;
                bool setTextInstanceCurrentColorCategoryStateSecondValue = false;
                JHP4SD.GumRuntimes.TextRuntime.ColorCategory TextInstanceCurrentColorCategoryStateFirstValue= JHP4SD.GumRuntimes.TextRuntime.ColorCategory.Gray;
                JHP4SD.GumRuntimes.TextRuntime.ColorCategory TextInstanceCurrentColorCategoryStateSecondValue= JHP4SD.GumRuntimes.TextRuntime.ColorCategory.Gray;
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
                switch(firstState)
                {
                    case  ButtonCategory.Enabled:
                        if (interpolationValue < 1)
                        {
                            this.HighlightRectangle.Parent = this.GetGraphicalUiElementByName("NineSliceInstance") ?? this;
                        }
                        if (interpolationValue < 1)
                        {
                            this.HighlightRectangle.Visible = false;
                        }
                        if (interpolationValue < 1)
                        {
                            this.HighlightRectangle.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.HighlightRectangle.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setNineSliceInstanceAlphaFirstValue = true;
                        NineSliceInstanceAlphaFirstValue = 255;
                        if (interpolationValue < 1)
                        {
                            this.NineSliceInstance.Blend = Gum.RenderingLibrary.Blend.Normal;
                        }
                        setNineSliceInstanceBlueFirstValue = true;
                        NineSliceInstanceBlueFirstValue = 128;
                        setNineSliceInstanceCurrentColorCategoryStateFirstValue = true;
                        NineSliceInstanceCurrentColorCategoryStateFirstValue = JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Gray;
                        setNineSliceInstanceGreenFirstValue = true;
                        NineSliceInstanceGreenFirstValue = 128;
                        setNineSliceInstanceRedFirstValue = true;
                        NineSliceInstanceRedFirstValue = 128;
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
                        setTextInstanceBlueFirstValue = true;
                        TextInstanceBlueFirstValue = 0;
                        setTextInstanceCurrentColorCategoryStateFirstValue = true;
                        TextInstanceCurrentColorCategoryStateFirstValue = JHP4SD.GumRuntimes.TextRuntime.ColorCategory.Black;
                        setTextInstanceGreenFirstValue = true;
                        TextInstanceGreenFirstValue = 0;
                        setTextInstanceHeightFirstValue = true;
                        TextInstanceHeightFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.TextInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                        }
                        setTextInstanceRedFirstValue = true;
                        TextInstanceRedFirstValue = 0;
                        if (interpolationValue < 1)
                        {
                            this.TextInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                        }
                        break;
                    case  ButtonCategory.Disabled:
                        if (interpolationValue < 1)
                        {
                            this.HighlightRectangle.Parent = this.GetGraphicalUiElementByName("NineSliceInstance") ?? this;
                        }
                        if (interpolationValue < 1)
                        {
                            this.HighlightRectangle.Visible = false;
                        }
                        if (interpolationValue < 1)
                        {
                            this.HighlightRectangle.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.HighlightRectangle.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setNineSliceInstanceAlphaFirstValue = true;
                        NineSliceInstanceAlphaFirstValue = 255;
                        if (interpolationValue < 1)
                        {
                            this.NineSliceInstance.Blend = Gum.RenderingLibrary.Blend.Normal;
                        }
                        setNineSliceInstanceBlueFirstValue = true;
                        NineSliceInstanceBlueFirstValue = 255;
                        setNineSliceInstanceCurrentColorCategoryStateFirstValue = true;
                        NineSliceInstanceCurrentColorCategoryStateFirstValue = JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Gray;
                        setNineSliceInstanceGreenFirstValue = true;
                        NineSliceInstanceGreenFirstValue = 255;
                        setNineSliceInstanceRedFirstValue = true;
                        NineSliceInstanceRedFirstValue = 255;
                        setNineSliceInstanceYFirstValue = true;
                        NineSliceInstanceYFirstValue = -5f;
                        if (interpolationValue < 1)
                        {
                            this.NineSliceInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Top;
                        }
                        if (interpolationValue < 1)
                        {
                            this.NineSliceInstance.YUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setTextInstanceBlueFirstValue = true;
                        TextInstanceBlueFirstValue = 0;
                        setTextInstanceCurrentColorCategoryStateFirstValue = true;
                        TextInstanceCurrentColorCategoryStateFirstValue = JHP4SD.GumRuntimes.TextRuntime.ColorCategory.Gray;
                        setTextInstanceGreenFirstValue = true;
                        TextInstanceGreenFirstValue = 0;
                        setTextInstanceHeightFirstValue = true;
                        TextInstanceHeightFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.TextInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                        }
                        setTextInstanceRedFirstValue = true;
                        TextInstanceRedFirstValue = 0;
                        if (interpolationValue < 1)
                        {
                            this.TextInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                        }
                        break;
                    case  ButtonCategory.Highlighted:
                        if (interpolationValue < 1)
                        {
                            this.HighlightRectangle.Parent = this.GetGraphicalUiElementByName("NineSliceInstance") ?? this;
                        }
                        if (interpolationValue < 1)
                        {
                            this.HighlightRectangle.Visible = false;
                        }
                        if (interpolationValue < 1)
                        {
                            this.HighlightRectangle.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.HighlightRectangle.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setNineSliceInstanceAlphaFirstValue = true;
                        NineSliceInstanceAlphaFirstValue = 255;
                        setNineSliceInstanceBlueFirstValue = true;
                        NineSliceInstanceBlueFirstValue = 255;
                        setNineSliceInstanceCurrentColorCategoryStateFirstValue = true;
                        NineSliceInstanceCurrentColorCategoryStateFirstValue = JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Gray;
                        setNineSliceInstanceGreenFirstValue = true;
                        NineSliceInstanceGreenFirstValue = 255;
                        setNineSliceInstanceRedFirstValue = true;
                        NineSliceInstanceRedFirstValue = 208;
                        setNineSliceInstanceYFirstValue = true;
                        NineSliceInstanceYFirstValue = -5f;
                        if (interpolationValue < 1)
                        {
                            this.NineSliceInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Top;
                        }
                        if (interpolationValue < 1)
                        {
                            this.NineSliceInstance.YUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setTextInstanceBlueFirstValue = true;
                        TextInstanceBlueFirstValue = 0;
                        setTextInstanceCurrentColorCategoryStateFirstValue = true;
                        TextInstanceCurrentColorCategoryStateFirstValue = JHP4SD.GumRuntimes.TextRuntime.ColorCategory.Black;
                        setTextInstanceGreenFirstValue = true;
                        TextInstanceGreenFirstValue = 0;
                        setTextInstanceHeightFirstValue = true;
                        TextInstanceHeightFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.TextInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                        }
                        setTextInstanceRedFirstValue = true;
                        TextInstanceRedFirstValue = 0;
                        if (interpolationValue < 1)
                        {
                            this.TextInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                        }
                        break;
                    case  ButtonCategory.Pushed:
                        if (interpolationValue < 1)
                        {
                            this.HighlightRectangle.Parent = this.GetGraphicalUiElementByName("NineSliceInstance") ?? this;
                        }
                        if (interpolationValue < 1)
                        {
                            this.HighlightRectangle.Visible = false;
                        }
                        if (interpolationValue < 1)
                        {
                            this.HighlightRectangle.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.HighlightRectangle.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setNineSliceInstanceAlphaFirstValue = true;
                        NineSliceInstanceAlphaFirstValue = 255;
                        if (interpolationValue < 1)
                        {
                            this.NineSliceInstance.Blend = Gum.RenderingLibrary.Blend.Normal;
                        }
                        setNineSliceInstanceBlueFirstValue = true;
                        NineSliceInstanceBlueFirstValue = 200;
                        setNineSliceInstanceCurrentColorCategoryStateFirstValue = true;
                        NineSliceInstanceCurrentColorCategoryStateFirstValue = JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Gray;
                        setNineSliceInstanceGreenFirstValue = true;
                        NineSliceInstanceGreenFirstValue = 200;
                        setNineSliceInstanceRedFirstValue = true;
                        NineSliceInstanceRedFirstValue = 200;
                        setNineSliceInstanceYFirstValue = true;
                        NineSliceInstanceYFirstValue = -2f;
                        if (interpolationValue < 1)
                        {
                            this.NineSliceInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Top;
                        }
                        if (interpolationValue < 1)
                        {
                            this.NineSliceInstance.YUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setTextInstanceBlueFirstValue = true;
                        TextInstanceBlueFirstValue = 0;
                        setTextInstanceCurrentColorCategoryStateFirstValue = true;
                        TextInstanceCurrentColorCategoryStateFirstValue = JHP4SD.GumRuntimes.TextRuntime.ColorCategory.Black;
                        setTextInstanceGreenFirstValue = true;
                        TextInstanceGreenFirstValue = 0;
                        setTextInstanceHeightFirstValue = true;
                        TextInstanceHeightFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.TextInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                        }
                        setTextInstanceRedFirstValue = true;
                        TextInstanceRedFirstValue = 0;
                        if (interpolationValue < 1)
                        {
                            this.TextInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                        }
                        break;
                    case  ButtonCategory.HighlightedFocused:
                        if (interpolationValue < 1)
                        {
                            this.HighlightRectangle.Parent = this.GetGraphicalUiElementByName("NineSliceInstance") ?? this;
                        }
                        if (interpolationValue < 1)
                        {
                            this.HighlightRectangle.Visible = true;
                        }
                        if (interpolationValue < 1)
                        {
                            this.HighlightRectangle.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.HighlightRectangle.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setNineSliceInstanceAlphaFirstValue = true;
                        NineSliceInstanceAlphaFirstValue = 255;
                        if (interpolationValue < 1)
                        {
                            this.NineSliceInstance.Blend = Gum.RenderingLibrary.Blend.Normal;
                        }
                        setNineSliceInstanceBlueFirstValue = true;
                        NineSliceInstanceBlueFirstValue = 255;
                        setNineSliceInstanceCurrentColorCategoryStateFirstValue = true;
                        NineSliceInstanceCurrentColorCategoryStateFirstValue = JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Gray;
                        setNineSliceInstanceGreenFirstValue = true;
                        NineSliceInstanceGreenFirstValue = 255;
                        setNineSliceInstanceRedFirstValue = true;
                        NineSliceInstanceRedFirstValue = 208;
                        setNineSliceInstanceYFirstValue = true;
                        NineSliceInstanceYFirstValue = -5f;
                        if (interpolationValue < 1)
                        {
                            this.NineSliceInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Top;
                        }
                        if (interpolationValue < 1)
                        {
                            this.NineSliceInstance.YUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setTextInstanceBlueFirstValue = true;
                        TextInstanceBlueFirstValue = 0;
                        setTextInstanceCurrentColorCategoryStateFirstValue = true;
                        TextInstanceCurrentColorCategoryStateFirstValue = JHP4SD.GumRuntimes.TextRuntime.ColorCategory.Black;
                        setTextInstanceGreenFirstValue = true;
                        TextInstanceGreenFirstValue = 0;
                        setTextInstanceHeightFirstValue = true;
                        TextInstanceHeightFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.TextInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                        }
                        setTextInstanceRedFirstValue = true;
                        TextInstanceRedFirstValue = 0;
                        if (interpolationValue < 1)
                        {
                            this.TextInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                        }
                        break;
                    case  ButtonCategory.Focused:
                        if (interpolationValue < 1)
                        {
                            this.HighlightRectangle.Parent = this.GetGraphicalUiElementByName("NineSliceInstance") ?? this;
                        }
                        if (interpolationValue < 1)
                        {
                            this.HighlightRectangle.Visible = true;
                        }
                        if (interpolationValue < 1)
                        {
                            this.HighlightRectangle.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.HighlightRectangle.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setNineSliceInstanceAlphaFirstValue = true;
                        NineSliceInstanceAlphaFirstValue = 255;
                        if (interpolationValue < 1)
                        {
                            this.NineSliceInstance.Blend = Gum.RenderingLibrary.Blend.Normal;
                        }
                        setNineSliceInstanceBlueFirstValue = true;
                        NineSliceInstanceBlueFirstValue = 128;
                        setNineSliceInstanceCurrentColorCategoryStateFirstValue = true;
                        NineSliceInstanceCurrentColorCategoryStateFirstValue = JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Gray;
                        setNineSliceInstanceGreenFirstValue = true;
                        NineSliceInstanceGreenFirstValue = 128;
                        setNineSliceInstanceRedFirstValue = true;
                        NineSliceInstanceRedFirstValue = 128;
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
                        setTextInstanceBlueFirstValue = true;
                        TextInstanceBlueFirstValue = 0;
                        setTextInstanceCurrentColorCategoryStateFirstValue = true;
                        TextInstanceCurrentColorCategoryStateFirstValue = JHP4SD.GumRuntimes.TextRuntime.ColorCategory.Gray;
                        setTextInstanceGreenFirstValue = true;
                        TextInstanceGreenFirstValue = 0;
                        setTextInstanceHeightFirstValue = true;
                        TextInstanceHeightFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.TextInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                        }
                        setTextInstanceRedFirstValue = true;
                        TextInstanceRedFirstValue = 0;
                        if (interpolationValue < 1)
                        {
                            this.TextInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                        }
                        break;
                    case  ButtonCategory.DisabledFocused:
                        if (interpolationValue < 1)
                        {
                            this.HighlightRectangle.Parent = this.GetGraphicalUiElementByName("NineSliceInstance") ?? this;
                        }
                        if (interpolationValue < 1)
                        {
                            this.HighlightRectangle.Visible = true;
                        }
                        if (interpolationValue < 1)
                        {
                            this.HighlightRectangle.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.HighlightRectangle.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setNineSliceInstanceAlphaFirstValue = true;
                        NineSliceInstanceAlphaFirstValue = 255;
                        if (interpolationValue < 1)
                        {
                            this.NineSliceInstance.Blend = Gum.RenderingLibrary.Blend.Normal;
                        }
                        setNineSliceInstanceBlueFirstValue = true;
                        NineSliceInstanceBlueFirstValue = 201;
                        setNineSliceInstanceCurrentColorCategoryStateFirstValue = true;
                        NineSliceInstanceCurrentColorCategoryStateFirstValue = JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Gray;
                        setNineSliceInstanceGreenFirstValue = true;
                        NineSliceInstanceGreenFirstValue = 201;
                        setNineSliceInstanceRedFirstValue = true;
                        NineSliceInstanceRedFirstValue = 201;
                        setNineSliceInstanceYFirstValue = true;
                        NineSliceInstanceYFirstValue = -5f;
                        if (interpolationValue < 1)
                        {
                            this.NineSliceInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Top;
                        }
                        if (interpolationValue < 1)
                        {
                            this.NineSliceInstance.YUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setTextInstanceBlueFirstValue = true;
                        TextInstanceBlueFirstValue = 0;
                        setTextInstanceCurrentColorCategoryStateFirstValue = true;
                        TextInstanceCurrentColorCategoryStateFirstValue = JHP4SD.GumRuntimes.TextRuntime.ColorCategory.Gray;
                        setTextInstanceGreenFirstValue = true;
                        TextInstanceGreenFirstValue = 0;
                        setTextInstanceHeightFirstValue = true;
                        TextInstanceHeightFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.TextInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                        }
                        setTextInstanceRedFirstValue = true;
                        TextInstanceRedFirstValue = 0;
                        if (interpolationValue < 1)
                        {
                            this.TextInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                        }
                        break;
                }
                switch(secondState)
                {
                    case  ButtonCategory.Enabled:
                        if (interpolationValue >= 1)
                        {
                            this.HighlightRectangle.Parent = this.GetGraphicalUiElementByName("NineSliceInstance") ?? this;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.HighlightRectangle.Visible = false;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.HighlightRectangle.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.HighlightRectangle.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setNineSliceInstanceAlphaSecondValue = true;
                        NineSliceInstanceAlphaSecondValue = 255;
                        if (interpolationValue >= 1)
                        {
                            this.NineSliceInstance.Blend = Gum.RenderingLibrary.Blend.Normal;
                        }
                        setNineSliceInstanceBlueSecondValue = true;
                        NineSliceInstanceBlueSecondValue = 128;
                        setNineSliceInstanceCurrentColorCategoryStateSecondValue = true;
                        NineSliceInstanceCurrentColorCategoryStateSecondValue = JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Gray;
                        setNineSliceInstanceGreenSecondValue = true;
                        NineSliceInstanceGreenSecondValue = 128;
                        setNineSliceInstanceRedSecondValue = true;
                        NineSliceInstanceRedSecondValue = 128;
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
                        setTextInstanceBlueSecondValue = true;
                        TextInstanceBlueSecondValue = 0;
                        setTextInstanceCurrentColorCategoryStateSecondValue = true;
                        TextInstanceCurrentColorCategoryStateSecondValue = JHP4SD.GumRuntimes.TextRuntime.ColorCategory.Black;
                        setTextInstanceGreenSecondValue = true;
                        TextInstanceGreenSecondValue = 0;
                        setTextInstanceHeightSecondValue = true;
                        TextInstanceHeightSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.TextInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                        }
                        setTextInstanceRedSecondValue = true;
                        TextInstanceRedSecondValue = 0;
                        if (interpolationValue >= 1)
                        {
                            this.TextInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                        }
                        break;
                    case  ButtonCategory.Disabled:
                        if (interpolationValue >= 1)
                        {
                            this.HighlightRectangle.Parent = this.GetGraphicalUiElementByName("NineSliceInstance") ?? this;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.HighlightRectangle.Visible = false;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.HighlightRectangle.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.HighlightRectangle.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setNineSliceInstanceAlphaSecondValue = true;
                        NineSliceInstanceAlphaSecondValue = 255;
                        if (interpolationValue >= 1)
                        {
                            this.NineSliceInstance.Blend = Gum.RenderingLibrary.Blend.Normal;
                        }
                        setNineSliceInstanceBlueSecondValue = true;
                        NineSliceInstanceBlueSecondValue = 255;
                        setNineSliceInstanceCurrentColorCategoryStateSecondValue = true;
                        NineSliceInstanceCurrentColorCategoryStateSecondValue = JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Gray;
                        setNineSliceInstanceGreenSecondValue = true;
                        NineSliceInstanceGreenSecondValue = 255;
                        setNineSliceInstanceRedSecondValue = true;
                        NineSliceInstanceRedSecondValue = 255;
                        setNineSliceInstanceYSecondValue = true;
                        NineSliceInstanceYSecondValue = -5f;
                        if (interpolationValue >= 1)
                        {
                            this.NineSliceInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Top;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.NineSliceInstance.YUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setTextInstanceBlueSecondValue = true;
                        TextInstanceBlueSecondValue = 0;
                        setTextInstanceCurrentColorCategoryStateSecondValue = true;
                        TextInstanceCurrentColorCategoryStateSecondValue = JHP4SD.GumRuntimes.TextRuntime.ColorCategory.Gray;
                        setTextInstanceGreenSecondValue = true;
                        TextInstanceGreenSecondValue = 0;
                        setTextInstanceHeightSecondValue = true;
                        TextInstanceHeightSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.TextInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                        }
                        setTextInstanceRedSecondValue = true;
                        TextInstanceRedSecondValue = 0;
                        if (interpolationValue >= 1)
                        {
                            this.TextInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                        }
                        break;
                    case  ButtonCategory.Highlighted:
                        if (interpolationValue >= 1)
                        {
                            this.HighlightRectangle.Parent = this.GetGraphicalUiElementByName("NineSliceInstance") ?? this;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.HighlightRectangle.Visible = false;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.HighlightRectangle.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.HighlightRectangle.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setNineSliceInstanceAlphaSecondValue = true;
                        NineSliceInstanceAlphaSecondValue = 255;
                        setNineSliceInstanceBlueSecondValue = true;
                        NineSliceInstanceBlueSecondValue = 255;
                        setNineSliceInstanceCurrentColorCategoryStateSecondValue = true;
                        NineSliceInstanceCurrentColorCategoryStateSecondValue = JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Gray;
                        setNineSliceInstanceGreenSecondValue = true;
                        NineSliceInstanceGreenSecondValue = 255;
                        setNineSliceInstanceRedSecondValue = true;
                        NineSliceInstanceRedSecondValue = 208;
                        setNineSliceInstanceYSecondValue = true;
                        NineSliceInstanceYSecondValue = -5f;
                        if (interpolationValue >= 1)
                        {
                            this.NineSliceInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Top;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.NineSliceInstance.YUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setTextInstanceBlueSecondValue = true;
                        TextInstanceBlueSecondValue = 0;
                        setTextInstanceCurrentColorCategoryStateSecondValue = true;
                        TextInstanceCurrentColorCategoryStateSecondValue = JHP4SD.GumRuntimes.TextRuntime.ColorCategory.Black;
                        setTextInstanceGreenSecondValue = true;
                        TextInstanceGreenSecondValue = 0;
                        setTextInstanceHeightSecondValue = true;
                        TextInstanceHeightSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.TextInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                        }
                        setTextInstanceRedSecondValue = true;
                        TextInstanceRedSecondValue = 0;
                        if (interpolationValue >= 1)
                        {
                            this.TextInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                        }
                        break;
                    case  ButtonCategory.Pushed:
                        if (interpolationValue >= 1)
                        {
                            this.HighlightRectangle.Parent = this.GetGraphicalUiElementByName("NineSliceInstance") ?? this;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.HighlightRectangle.Visible = false;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.HighlightRectangle.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.HighlightRectangle.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setNineSliceInstanceAlphaSecondValue = true;
                        NineSliceInstanceAlphaSecondValue = 255;
                        if (interpolationValue >= 1)
                        {
                            this.NineSliceInstance.Blend = Gum.RenderingLibrary.Blend.Normal;
                        }
                        setNineSliceInstanceBlueSecondValue = true;
                        NineSliceInstanceBlueSecondValue = 200;
                        setNineSliceInstanceCurrentColorCategoryStateSecondValue = true;
                        NineSliceInstanceCurrentColorCategoryStateSecondValue = JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Gray;
                        setNineSliceInstanceGreenSecondValue = true;
                        NineSliceInstanceGreenSecondValue = 200;
                        setNineSliceInstanceRedSecondValue = true;
                        NineSliceInstanceRedSecondValue = 200;
                        setNineSliceInstanceYSecondValue = true;
                        NineSliceInstanceYSecondValue = -2f;
                        if (interpolationValue >= 1)
                        {
                            this.NineSliceInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Top;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.NineSliceInstance.YUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setTextInstanceBlueSecondValue = true;
                        TextInstanceBlueSecondValue = 0;
                        setTextInstanceCurrentColorCategoryStateSecondValue = true;
                        TextInstanceCurrentColorCategoryStateSecondValue = JHP4SD.GumRuntimes.TextRuntime.ColorCategory.Black;
                        setTextInstanceGreenSecondValue = true;
                        TextInstanceGreenSecondValue = 0;
                        setTextInstanceHeightSecondValue = true;
                        TextInstanceHeightSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.TextInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                        }
                        setTextInstanceRedSecondValue = true;
                        TextInstanceRedSecondValue = 0;
                        if (interpolationValue >= 1)
                        {
                            this.TextInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                        }
                        break;
                    case  ButtonCategory.HighlightedFocused:
                        if (interpolationValue >= 1)
                        {
                            this.HighlightRectangle.Parent = this.GetGraphicalUiElementByName("NineSliceInstance") ?? this;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.HighlightRectangle.Visible = true;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.HighlightRectangle.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.HighlightRectangle.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setNineSliceInstanceAlphaSecondValue = true;
                        NineSliceInstanceAlphaSecondValue = 255;
                        if (interpolationValue >= 1)
                        {
                            this.NineSliceInstance.Blend = Gum.RenderingLibrary.Blend.Normal;
                        }
                        setNineSliceInstanceBlueSecondValue = true;
                        NineSliceInstanceBlueSecondValue = 255;
                        setNineSliceInstanceCurrentColorCategoryStateSecondValue = true;
                        NineSliceInstanceCurrentColorCategoryStateSecondValue = JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Gray;
                        setNineSliceInstanceGreenSecondValue = true;
                        NineSliceInstanceGreenSecondValue = 255;
                        setNineSliceInstanceRedSecondValue = true;
                        NineSliceInstanceRedSecondValue = 208;
                        setNineSliceInstanceYSecondValue = true;
                        NineSliceInstanceYSecondValue = -5f;
                        if (interpolationValue >= 1)
                        {
                            this.NineSliceInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Top;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.NineSliceInstance.YUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setTextInstanceBlueSecondValue = true;
                        TextInstanceBlueSecondValue = 0;
                        setTextInstanceCurrentColorCategoryStateSecondValue = true;
                        TextInstanceCurrentColorCategoryStateSecondValue = JHP4SD.GumRuntimes.TextRuntime.ColorCategory.Black;
                        setTextInstanceGreenSecondValue = true;
                        TextInstanceGreenSecondValue = 0;
                        setTextInstanceHeightSecondValue = true;
                        TextInstanceHeightSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.TextInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                        }
                        setTextInstanceRedSecondValue = true;
                        TextInstanceRedSecondValue = 0;
                        if (interpolationValue >= 1)
                        {
                            this.TextInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                        }
                        break;
                    case  ButtonCategory.Focused:
                        if (interpolationValue >= 1)
                        {
                            this.HighlightRectangle.Parent = this.GetGraphicalUiElementByName("NineSliceInstance") ?? this;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.HighlightRectangle.Visible = true;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.HighlightRectangle.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.HighlightRectangle.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setNineSliceInstanceAlphaSecondValue = true;
                        NineSliceInstanceAlphaSecondValue = 255;
                        if (interpolationValue >= 1)
                        {
                            this.NineSliceInstance.Blend = Gum.RenderingLibrary.Blend.Normal;
                        }
                        setNineSliceInstanceBlueSecondValue = true;
                        NineSliceInstanceBlueSecondValue = 128;
                        setNineSliceInstanceCurrentColorCategoryStateSecondValue = true;
                        NineSliceInstanceCurrentColorCategoryStateSecondValue = JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Gray;
                        setNineSliceInstanceGreenSecondValue = true;
                        NineSliceInstanceGreenSecondValue = 128;
                        setNineSliceInstanceRedSecondValue = true;
                        NineSliceInstanceRedSecondValue = 128;
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
                        setTextInstanceBlueSecondValue = true;
                        TextInstanceBlueSecondValue = 0;
                        setTextInstanceCurrentColorCategoryStateSecondValue = true;
                        TextInstanceCurrentColorCategoryStateSecondValue = JHP4SD.GumRuntimes.TextRuntime.ColorCategory.Gray;
                        setTextInstanceGreenSecondValue = true;
                        TextInstanceGreenSecondValue = 0;
                        setTextInstanceHeightSecondValue = true;
                        TextInstanceHeightSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.TextInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                        }
                        setTextInstanceRedSecondValue = true;
                        TextInstanceRedSecondValue = 0;
                        if (interpolationValue >= 1)
                        {
                            this.TextInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                        }
                        break;
                    case  ButtonCategory.DisabledFocused:
                        if (interpolationValue >= 1)
                        {
                            this.HighlightRectangle.Parent = this.GetGraphicalUiElementByName("NineSliceInstance") ?? this;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.HighlightRectangle.Visible = true;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.HighlightRectangle.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.HighlightRectangle.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setNineSliceInstanceAlphaSecondValue = true;
                        NineSliceInstanceAlphaSecondValue = 255;
                        if (interpolationValue >= 1)
                        {
                            this.NineSliceInstance.Blend = Gum.RenderingLibrary.Blend.Normal;
                        }
                        setNineSliceInstanceBlueSecondValue = true;
                        NineSliceInstanceBlueSecondValue = 201;
                        setNineSliceInstanceCurrentColorCategoryStateSecondValue = true;
                        NineSliceInstanceCurrentColorCategoryStateSecondValue = JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Gray;
                        setNineSliceInstanceGreenSecondValue = true;
                        NineSliceInstanceGreenSecondValue = 201;
                        setNineSliceInstanceRedSecondValue = true;
                        NineSliceInstanceRedSecondValue = 201;
                        setNineSliceInstanceYSecondValue = true;
                        NineSliceInstanceYSecondValue = -5f;
                        if (interpolationValue >= 1)
                        {
                            this.NineSliceInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Top;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.NineSliceInstance.YUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setTextInstanceBlueSecondValue = true;
                        TextInstanceBlueSecondValue = 0;
                        setTextInstanceCurrentColorCategoryStateSecondValue = true;
                        TextInstanceCurrentColorCategoryStateSecondValue = JHP4SD.GumRuntimes.TextRuntime.ColorCategory.Gray;
                        setTextInstanceGreenSecondValue = true;
                        TextInstanceGreenSecondValue = 0;
                        setTextInstanceHeightSecondValue = true;
                        TextInstanceHeightSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.TextInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                        }
                        setTextInstanceRedSecondValue = true;
                        TextInstanceRedSecondValue = 0;
                        if (interpolationValue >= 1)
                        {
                            this.TextInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                        }
                        break;
                }
                var wasSuppressed = mIsLayoutSuspended;
                if (wasSuppressed == false)
                {
                    SuspendLayout(true);
                }
                if (setNineSliceInstanceAlphaFirstValue && setNineSliceInstanceAlphaSecondValue)
                {
                    NineSliceInstance.Alpha = FlatRedBall.Math.MathFunctions.RoundToInt(NineSliceInstanceAlphaFirstValue* (1 - interpolationValue) + NineSliceInstanceAlphaSecondValue * interpolationValue);
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
                if (setNineSliceInstanceYFirstValue && setNineSliceInstanceYSecondValue)
                {
                    NineSliceInstance.Y = NineSliceInstanceYFirstValue * (1 - interpolationValue) + NineSliceInstanceYSecondValue * interpolationValue;
                }
                if (setTextInstanceBlueFirstValue && setTextInstanceBlueSecondValue)
                {
                    TextInstance.Blue = FlatRedBall.Math.MathFunctions.RoundToInt(TextInstanceBlueFirstValue* (1 - interpolationValue) + TextInstanceBlueSecondValue * interpolationValue);
                }
                if (setTextInstanceCurrentColorCategoryStateFirstValue && setTextInstanceCurrentColorCategoryStateSecondValue)
                {
                    TextInstance.InterpolateBetween(TextInstanceCurrentColorCategoryStateFirstValue, TextInstanceCurrentColorCategoryStateSecondValue, interpolationValue);
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
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (JHP4SD.GumRuntimes.LebegForms.BasicComponents.TabButtonRuntime.VariableState fromState,JHP4SD.GumRuntimes.LebegForms.BasicComponents.TabButtonRuntime.VariableState toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null) 
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
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (JHP4SD.GumRuntimes.LebegForms.BasicComponents.TabButtonRuntime.ButtonCategory fromState,JHP4SD.GumRuntimes.LebegForms.BasicComponents.TabButtonRuntime.ButtonCategory toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null) 
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
                            Name = "Height Units",
                            Type = "DimensionUnitType",
                            Value = HeightUnits
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
                            Name = "Width Units",
                            Type = "DimensionUnitType",
                            Value = WidthUnits
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
                            Name = "X Units",
                            Type = "PositionUnitType",
                            Value = XUnits
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
                            Name = "TextInstance.Blue",
                            Type = "int",
                            Value = TextInstance.Blue
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
                            Value = Height + 110f
                        }
                        );
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
                            Name = "Width",
                            Type = "float",
                            Value = Width + 32f
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
                            Name = "X",
                            Type = "float",
                            Value = X + 1f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "X Units",
                            Type = "PositionUnitType",
                            Value = XUnits
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
                            Value = NineSliceInstance.Blue + 128
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
                            Value = NineSliceInstance.Green + 128
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
                            Value = NineSliceInstance.Red + 128
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
                            Name = "TextInstance.Blue",
                            Type = "int",
                            Value = TextInstance.Blue + 0
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
                            Name = "HighlightRectangle.Parent",
                            Type = "string",
                            Value = HighlightRectangle.Parent
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
                            Name = "NineSliceInstance.Alpha",
                            Type = "int",
                            Value = NineSliceInstance.Alpha
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NineSliceInstance.Blend",
                            Type = "Blend",
                            Value = NineSliceInstance.Blend
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
                            Name = "NineSliceInstance.Red",
                            Type = "int",
                            Value = NineSliceInstance.Red
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
                            Name = "TextInstance.Blue",
                            Type = "int",
                            Value = TextInstance.Blue
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
                            Name = "TextInstance.Red",
                            Type = "int",
                            Value = TextInstance.Red
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
                            Name = "HighlightRectangle.Parent",
                            Type = "string",
                            Value = HighlightRectangle.Parent
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
                    case  ButtonCategory.Disabled:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NineSliceInstance.Alpha",
                            Type = "int",
                            Value = NineSliceInstance.Alpha
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NineSliceInstance.Blend",
                            Type = "Blend",
                            Value = NineSliceInstance.Blend
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
                            Name = "NineSliceInstance.Red",
                            Type = "int",
                            Value = NineSliceInstance.Red
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
                            Name = "TextInstance.Blue",
                            Type = "int",
                            Value = TextInstance.Blue
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
                            Name = "TextInstance.Red",
                            Type = "int",
                            Value = TextInstance.Red
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
                            Name = "HighlightRectangle.Parent",
                            Type = "string",
                            Value = HighlightRectangle.Parent
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
                    case  ButtonCategory.Highlighted:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NineSliceInstance.Alpha",
                            Type = "int",
                            Value = NineSliceInstance.Alpha
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
                            Name = "NineSliceInstance.Red",
                            Type = "int",
                            Value = NineSliceInstance.Red
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
                            Name = "TextInstance.Blue",
                            Type = "int",
                            Value = TextInstance.Blue
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
                            Name = "TextInstance.Red",
                            Type = "int",
                            Value = TextInstance.Red
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
                            Name = "HighlightRectangle.Parent",
                            Type = "string",
                            Value = HighlightRectangle.Parent
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
                    case  ButtonCategory.Pushed:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NineSliceInstance.Alpha",
                            Type = "int",
                            Value = NineSliceInstance.Alpha
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NineSliceInstance.Blend",
                            Type = "Blend",
                            Value = NineSliceInstance.Blend
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
                            Name = "NineSliceInstance.Red",
                            Type = "int",
                            Value = NineSliceInstance.Red
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
                            Name = "TextInstance.Blue",
                            Type = "int",
                            Value = TextInstance.Blue
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
                            Name = "TextInstance.Red",
                            Type = "int",
                            Value = TextInstance.Red
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
                            Name = "HighlightRectangle.Parent",
                            Type = "string",
                            Value = HighlightRectangle.Parent
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
                    case  ButtonCategory.HighlightedFocused:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NineSliceInstance.Alpha",
                            Type = "int",
                            Value = NineSliceInstance.Alpha
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NineSliceInstance.Blend",
                            Type = "Blend",
                            Value = NineSliceInstance.Blend
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
                            Name = "NineSliceInstance.Red",
                            Type = "int",
                            Value = NineSliceInstance.Red
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
                            Name = "TextInstance.Blue",
                            Type = "int",
                            Value = TextInstance.Blue
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
                            Name = "TextInstance.Red",
                            Type = "int",
                            Value = TextInstance.Red
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
                            Name = "HighlightRectangle.Parent",
                            Type = "string",
                            Value = HighlightRectangle.Parent
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
                    case  ButtonCategory.Focused:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NineSliceInstance.Alpha",
                            Type = "int",
                            Value = NineSliceInstance.Alpha
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NineSliceInstance.Blend",
                            Type = "Blend",
                            Value = NineSliceInstance.Blend
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
                            Name = "NineSliceInstance.Red",
                            Type = "int",
                            Value = NineSliceInstance.Red
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
                            Name = "TextInstance.Blue",
                            Type = "int",
                            Value = TextInstance.Blue
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
                            Name = "TextInstance.Red",
                            Type = "int",
                            Value = TextInstance.Red
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
                            Name = "HighlightRectangle.Parent",
                            Type = "string",
                            Value = HighlightRectangle.Parent
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
                    case  ButtonCategory.DisabledFocused:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NineSliceInstance.Alpha",
                            Type = "int",
                            Value = NineSliceInstance.Alpha
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NineSliceInstance.Blend",
                            Type = "Blend",
                            Value = NineSliceInstance.Blend
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
                            Name = "NineSliceInstance.Red",
                            Type = "int",
                            Value = NineSliceInstance.Red
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
                            Name = "TextInstance.Blue",
                            Type = "int",
                            Value = TextInstance.Blue
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
                            Name = "TextInstance.Red",
                            Type = "int",
                            Value = TextInstance.Red
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
                            Name = "HighlightRectangle.Parent",
                            Type = "string",
                            Value = HighlightRectangle.Parent
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
            private Gum.DataTypes.Variables.StateSave AddToCurrentValuesWithState (ButtonCategory state) 
            {
                Gum.DataTypes.Variables.StateSave newState = new Gum.DataTypes.Variables.StateSave();
                switch(state)
                {
                    case  ButtonCategory.Enabled:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NineSliceInstance.Alpha",
                            Type = "int",
                            Value = NineSliceInstance.Alpha + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NineSliceInstance.Blend",
                            Type = "Blend",
                            Value = NineSliceInstance.Blend
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NineSliceInstance.Blue",
                            Type = "int",
                            Value = NineSliceInstance.Blue + 128
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
                            Value = NineSliceInstance.Green + 128
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NineSliceInstance.Red",
                            Type = "int",
                            Value = NineSliceInstance.Red + 128
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
                            Name = "TextInstance.Blue",
                            Type = "int",
                            Value = TextInstance.Blue + 0
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
                            Name = "TextInstance.Red",
                            Type = "int",
                            Value = TextInstance.Red + 0
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
                            Name = "HighlightRectangle.Parent",
                            Type = "string",
                            Value = HighlightRectangle.Parent
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
                    case  ButtonCategory.Disabled:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NineSliceInstance.Alpha",
                            Type = "int",
                            Value = NineSliceInstance.Alpha + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NineSliceInstance.Blend",
                            Type = "Blend",
                            Value = NineSliceInstance.Blend
                        }
                        );
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
                            Name = "NineSliceInstance.Y",
                            Type = "float",
                            Value = NineSliceInstance.Y + -5f
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
                            Name = "TextInstance.Blue",
                            Type = "int",
                            Value = TextInstance.Blue + 0
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
                            Name = "TextInstance.Red",
                            Type = "int",
                            Value = TextInstance.Red + 0
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
                            Name = "HighlightRectangle.Parent",
                            Type = "string",
                            Value = HighlightRectangle.Parent
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
                    case  ButtonCategory.Highlighted:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NineSliceInstance.Alpha",
                            Type = "int",
                            Value = NineSliceInstance.Alpha + 255
                        }
                        );
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
                            Value = NineSliceInstance.Red + 208
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NineSliceInstance.Y",
                            Type = "float",
                            Value = NineSliceInstance.Y + -5f
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
                            Name = "TextInstance.Blue",
                            Type = "int",
                            Value = TextInstance.Blue + 0
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
                            Name = "TextInstance.Red",
                            Type = "int",
                            Value = TextInstance.Red + 0
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
                            Name = "HighlightRectangle.Parent",
                            Type = "string",
                            Value = HighlightRectangle.Parent
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
                    case  ButtonCategory.Pushed:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NineSliceInstance.Alpha",
                            Type = "int",
                            Value = NineSliceInstance.Alpha + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NineSliceInstance.Blend",
                            Type = "Blend",
                            Value = NineSliceInstance.Blend
                        }
                        );
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
                            Name = "NineSliceInstance.Y",
                            Type = "float",
                            Value = NineSliceInstance.Y + -2f
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
                            Name = "TextInstance.Blue",
                            Type = "int",
                            Value = TextInstance.Blue + 0
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
                            Name = "TextInstance.Red",
                            Type = "int",
                            Value = TextInstance.Red + 0
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
                            Name = "HighlightRectangle.Parent",
                            Type = "string",
                            Value = HighlightRectangle.Parent
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
                    case  ButtonCategory.HighlightedFocused:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NineSliceInstance.Alpha",
                            Type = "int",
                            Value = NineSliceInstance.Alpha + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NineSliceInstance.Blend",
                            Type = "Blend",
                            Value = NineSliceInstance.Blend
                        }
                        );
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
                            Value = NineSliceInstance.Red + 208
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NineSliceInstance.Y",
                            Type = "float",
                            Value = NineSliceInstance.Y + -5f
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
                            Name = "TextInstance.Blue",
                            Type = "int",
                            Value = TextInstance.Blue + 0
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
                            Name = "TextInstance.Red",
                            Type = "int",
                            Value = TextInstance.Red + 0
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
                            Name = "HighlightRectangle.Parent",
                            Type = "string",
                            Value = HighlightRectangle.Parent
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
                    case  ButtonCategory.Focused:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NineSliceInstance.Alpha",
                            Type = "int",
                            Value = NineSliceInstance.Alpha + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NineSliceInstance.Blend",
                            Type = "Blend",
                            Value = NineSliceInstance.Blend
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NineSliceInstance.Blue",
                            Type = "int",
                            Value = NineSliceInstance.Blue + 128
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
                            Value = NineSliceInstance.Green + 128
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NineSliceInstance.Red",
                            Type = "int",
                            Value = NineSliceInstance.Red + 128
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
                            Name = "TextInstance.Blue",
                            Type = "int",
                            Value = TextInstance.Blue + 0
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
                            Name = "TextInstance.Red",
                            Type = "int",
                            Value = TextInstance.Red + 0
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
                            Name = "HighlightRectangle.Parent",
                            Type = "string",
                            Value = HighlightRectangle.Parent
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
                    case  ButtonCategory.DisabledFocused:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NineSliceInstance.Alpha",
                            Type = "int",
                            Value = NineSliceInstance.Alpha + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NineSliceInstance.Blend",
                            Type = "Blend",
                            Value = NineSliceInstance.Blend
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NineSliceInstance.Blue",
                            Type = "int",
                            Value = NineSliceInstance.Blue + 201
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
                            Value = NineSliceInstance.Green + 201
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NineSliceInstance.Red",
                            Type = "int",
                            Value = NineSliceInstance.Red + 201
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NineSliceInstance.Y",
                            Type = "float",
                            Value = NineSliceInstance.Y + -5f
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
                            Name = "TextInstance.Blue",
                            Type = "int",
                            Value = TextInstance.Blue + 0
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
                            Name = "TextInstance.Red",
                            Type = "int",
                            Value = TextInstance.Red + 0
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
                            Name = "HighlightRectangle.Parent",
                            Type = "string",
                            Value = HighlightRectangle.Parent
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
            public JHP4SD.GumRuntimes.TextRuntime TextInstance { get; set; }
            public JHP4SD.GumRuntimes.RectangleRuntime HighlightRectangle { get; set; }
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
            public TabButtonRuntime (bool fullInstantiation = true, bool tryCreateFormsObject = true) 
            	: base(false, tryCreateFormsObject)
            {
                this.tryCreateFormsObject = tryCreateFormsObject;
                this.ExposeChildrenEvents = false;
                if (fullInstantiation)
                {
                    Gum.DataTypes.ElementSave elementSave = Gum.Managers.ObjectFinder.Self.GumProjectSave.Components.First(item => item.Name == "LebegForms/BasicComponents/TabButton");
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
