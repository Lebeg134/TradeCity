    using System.Linq;
    namespace JHP4SD.GumRuntimes.DefaultForms
    {
        public partial class ListBoxRuntime : JHP4SD.GumRuntimes.ContainerRuntime
        {
            #region State Enums
            public enum VariableState
            {
                Default
            }
            public enum ListBoxCategory
            {
                Enabled,
                Focused,
                Disabled
            }
            public enum ScrollBarVisibility
            {
                NoScrollBar,
                VerticalScrollVisible
            }
            #endregion
            #region State Fields
            VariableState mCurrentVariableState;
            ListBoxCategory? mCurrentListBoxCategoryState;
            ScrollBarVisibility? mCurrentScrollBarVisibilityState;
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
                            InnerPanelInstance.Parent = this.GetGraphicalUiElementByName("ClipContainerInstance") ?? this;
                            Height = 260f;
                            Width = 243f;
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
                            VerticalScrollBarInstance.Height = 0f;
                            VerticalScrollBarInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                            VerticalScrollBarInstance.X = 0f;
                            VerticalScrollBarInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                            VerticalScrollBarInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                            VerticalScrollBarInstance.Y = 0f;
                            VerticalScrollBarInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            VerticalScrollBarInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            ClipContainerInstance.ClipsChildren = true;
                            ClipContainerInstance.Height = 0f;
                            ClipContainerInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                            ClipContainerInstance.Width = -36f;
                            ClipContainerInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                            ClipContainerInstance.X = 0f;
                            ClipContainerInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                            ClipContainerInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                            ClipContainerInstance.Y = 0f;
                            ClipContainerInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            ClipContainerInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            InnerPanelInstance.ChildrenLayout = Gum.Managers.ChildrenLayout.TopToBottomStack;
                            InnerPanelInstance.Height = 0f;
                            InnerPanelInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                            InnerPanelInstance.Width = 0f;
                            InnerPanelInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                            InnerPanelInstance.X = 0f;
                            InnerPanelInstance.Y = 0f;
                            InnerPanelInstance.YUnits = Gum.Converters.GeneralUnitType.Percentage;
                            HighlightRectangle.Blue = 0;
                            HighlightRectangle.Green = 255;
                            HighlightRectangle.Height = 0f;
                            HighlightRectangle.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                            HighlightRectangle.Red = 255;
                            HighlightRectangle.Visible = false;
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
            public ListBoxCategory? CurrentListBoxCategoryState
            {
                get
                {
                    return mCurrentListBoxCategoryState;
                }
                set
                {
                    if (value != null)
                    {
                        mCurrentListBoxCategoryState = value;
                        switch(mCurrentListBoxCategoryState)
                        {
                            case  ListBoxCategory.Enabled:
                                ColoredFrameInstance.Alpha = 255;
                                ColoredFrameInstance.Visible = true;
                                HighlightRectangle.Visible = false;
                                break;
                            case  ListBoxCategory.Focused:
                                ColoredFrameInstance.Alpha = 255;
                                ColoredFrameInstance.Visible = true;
                                HighlightRectangle.Visible = true;
                                break;
                            case  ListBoxCategory.Disabled:
                                ColoredFrameInstance.Alpha = 128;
                                ColoredFrameInstance.Visible = true;
                                HighlightRectangle.Visible = false;
                                break;
                        }
                    }
                }
            }
            public ScrollBarVisibility? CurrentScrollBarVisibilityState
            {
                get
                {
                    return mCurrentScrollBarVisibilityState;
                }
                set
                {
                    if (value != null)
                    {
                        mCurrentScrollBarVisibilityState = value;
                        switch(mCurrentScrollBarVisibilityState)
                        {
                            case  ScrollBarVisibility.NoScrollBar:
                                VerticalScrollBarInstance.Visible = false;
                                ClipContainerInstance.Width = 0f;
                                break;
                            case  ScrollBarVisibility.VerticalScrollVisible:
                                VerticalScrollBarInstance.Visible = true;
                                ClipContainerInstance.Width = -36f;
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
                bool setClipContainerInstanceHeightFirstValue = false;
                bool setClipContainerInstanceHeightSecondValue = false;
                float ClipContainerInstanceHeightFirstValue= 0;
                float ClipContainerInstanceHeightSecondValue= 0;
                bool setClipContainerInstanceWidthFirstValue = false;
                bool setClipContainerInstanceWidthSecondValue = false;
                float ClipContainerInstanceWidthFirstValue= 0;
                float ClipContainerInstanceWidthSecondValue= 0;
                bool setClipContainerInstanceXFirstValue = false;
                bool setClipContainerInstanceXSecondValue = false;
                float ClipContainerInstanceXFirstValue= 0;
                float ClipContainerInstanceXSecondValue= 0;
                bool setClipContainerInstanceYFirstValue = false;
                bool setClipContainerInstanceYSecondValue = false;
                float ClipContainerInstanceYFirstValue= 0;
                float ClipContainerInstanceYSecondValue= 0;
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
                bool setInnerPanelInstanceHeightFirstValue = false;
                bool setInnerPanelInstanceHeightSecondValue = false;
                float InnerPanelInstanceHeightFirstValue= 0;
                float InnerPanelInstanceHeightSecondValue= 0;
                bool setInnerPanelInstanceWidthFirstValue = false;
                bool setInnerPanelInstanceWidthSecondValue = false;
                float InnerPanelInstanceWidthFirstValue= 0;
                float InnerPanelInstanceWidthSecondValue= 0;
                bool setInnerPanelInstanceXFirstValue = false;
                bool setInnerPanelInstanceXSecondValue = false;
                float InnerPanelInstanceXFirstValue= 0;
                float InnerPanelInstanceXSecondValue= 0;
                bool setInnerPanelInstanceYFirstValue = false;
                bool setInnerPanelInstanceYSecondValue = false;
                float InnerPanelInstanceYFirstValue= 0;
                float InnerPanelInstanceYSecondValue= 0;
                bool setVerticalScrollBarInstanceHeightFirstValue = false;
                bool setVerticalScrollBarInstanceHeightSecondValue = false;
                float VerticalScrollBarInstanceHeightFirstValue= 0;
                float VerticalScrollBarInstanceHeightSecondValue= 0;
                bool setVerticalScrollBarInstanceXFirstValue = false;
                bool setVerticalScrollBarInstanceXSecondValue = false;
                float VerticalScrollBarInstanceXFirstValue= 0;
                float VerticalScrollBarInstanceXSecondValue= 0;
                bool setVerticalScrollBarInstanceYFirstValue = false;
                bool setVerticalScrollBarInstanceYSecondValue = false;
                float VerticalScrollBarInstanceYFirstValue= 0;
                float VerticalScrollBarInstanceYSecondValue= 0;
                bool setWidthFirstValue = false;
                bool setWidthSecondValue = false;
                float WidthFirstValue= 0;
                float WidthSecondValue= 0;
                switch(firstState)
                {
                    case  VariableState.Default:
                        if (interpolationValue < 1)
                        {
                            this.ClipContainerInstance.ClipsChildren = true;
                        }
                        setClipContainerInstanceHeightFirstValue = true;
                        ClipContainerInstanceHeightFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.ClipContainerInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        setClipContainerInstanceWidthFirstValue = true;
                        ClipContainerInstanceWidthFirstValue = -36f;
                        if (interpolationValue < 1)
                        {
                            this.ClipContainerInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        setClipContainerInstanceXFirstValue = true;
                        ClipContainerInstanceXFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.ClipContainerInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                        }
                        if (interpolationValue < 1)
                        {
                            this.ClipContainerInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                        }
                        setClipContainerInstanceYFirstValue = true;
                        ClipContainerInstanceYFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.ClipContainerInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.ClipContainerInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
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
                        HeightFirstValue = 260f;
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
                        setHighlightRectangleRedFirstValue = true;
                        HighlightRectangleRedFirstValue = 255;
                        if (interpolationValue < 1)
                        {
                            this.HighlightRectangle.Visible = false;
                        }
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
                        if (interpolationValue < 1)
                        {
                            this.InnerPanelInstance.ChildrenLayout = Gum.Managers.ChildrenLayout.TopToBottomStack;
                        }
                        setInnerPanelInstanceHeightFirstValue = true;
                        InnerPanelInstanceHeightFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.InnerPanelInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                        }
                        if (interpolationValue < 1)
                        {
                            this.InnerPanelInstance.Parent = this.GetGraphicalUiElementByName("ClipContainerInstance") ?? this;
                        }
                        setInnerPanelInstanceWidthFirstValue = true;
                        InnerPanelInstanceWidthFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.InnerPanelInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        setInnerPanelInstanceXFirstValue = true;
                        InnerPanelInstanceXFirstValue = 0f;
                        setInnerPanelInstanceYFirstValue = true;
                        InnerPanelInstanceYFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.InnerPanelInstance.YUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setVerticalScrollBarInstanceHeightFirstValue = true;
                        VerticalScrollBarInstanceHeightFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.VerticalScrollBarInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        setVerticalScrollBarInstanceXFirstValue = true;
                        VerticalScrollBarInstanceXFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.VerticalScrollBarInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                        }
                        if (interpolationValue < 1)
                        {
                            this.VerticalScrollBarInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                        }
                        setVerticalScrollBarInstanceYFirstValue = true;
                        VerticalScrollBarInstanceYFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.VerticalScrollBarInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.VerticalScrollBarInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setWidthFirstValue = true;
                        WidthFirstValue = 243f;
                        break;
                }
                switch(secondState)
                {
                    case  VariableState.Default:
                        if (interpolationValue >= 1)
                        {
                            this.ClipContainerInstance.ClipsChildren = true;
                        }
                        setClipContainerInstanceHeightSecondValue = true;
                        ClipContainerInstanceHeightSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.ClipContainerInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        setClipContainerInstanceWidthSecondValue = true;
                        ClipContainerInstanceWidthSecondValue = -36f;
                        if (interpolationValue >= 1)
                        {
                            this.ClipContainerInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        setClipContainerInstanceXSecondValue = true;
                        ClipContainerInstanceXSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.ClipContainerInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.ClipContainerInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                        }
                        setClipContainerInstanceYSecondValue = true;
                        ClipContainerInstanceYSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.ClipContainerInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.ClipContainerInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
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
                        HeightSecondValue = 260f;
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
                        setHighlightRectangleRedSecondValue = true;
                        HighlightRectangleRedSecondValue = 255;
                        if (interpolationValue >= 1)
                        {
                            this.HighlightRectangle.Visible = false;
                        }
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
                        if (interpolationValue >= 1)
                        {
                            this.InnerPanelInstance.ChildrenLayout = Gum.Managers.ChildrenLayout.TopToBottomStack;
                        }
                        setInnerPanelInstanceHeightSecondValue = true;
                        InnerPanelInstanceHeightSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.InnerPanelInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.InnerPanelInstance.Parent = this.GetGraphicalUiElementByName("ClipContainerInstance") ?? this;
                        }
                        setInnerPanelInstanceWidthSecondValue = true;
                        InnerPanelInstanceWidthSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.InnerPanelInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        setInnerPanelInstanceXSecondValue = true;
                        InnerPanelInstanceXSecondValue = 0f;
                        setInnerPanelInstanceYSecondValue = true;
                        InnerPanelInstanceYSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.InnerPanelInstance.YUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setVerticalScrollBarInstanceHeightSecondValue = true;
                        VerticalScrollBarInstanceHeightSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.VerticalScrollBarInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        setVerticalScrollBarInstanceXSecondValue = true;
                        VerticalScrollBarInstanceXSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.VerticalScrollBarInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.VerticalScrollBarInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                        }
                        setVerticalScrollBarInstanceYSecondValue = true;
                        VerticalScrollBarInstanceYSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.VerticalScrollBarInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.VerticalScrollBarInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setWidthSecondValue = true;
                        WidthSecondValue = 243f;
                        break;
                }
                var wasSuppressed = mIsLayoutSuspended;
                if (wasSuppressed == false)
                {
                    SuspendLayout(true);
                }
                if (setClipContainerInstanceHeightFirstValue && setClipContainerInstanceHeightSecondValue)
                {
                    ClipContainerInstance.Height = ClipContainerInstanceHeightFirstValue * (1 - interpolationValue) + ClipContainerInstanceHeightSecondValue * interpolationValue;
                }
                if (setClipContainerInstanceWidthFirstValue && setClipContainerInstanceWidthSecondValue)
                {
                    ClipContainerInstance.Width = ClipContainerInstanceWidthFirstValue * (1 - interpolationValue) + ClipContainerInstanceWidthSecondValue * interpolationValue;
                }
                if (setClipContainerInstanceXFirstValue && setClipContainerInstanceXSecondValue)
                {
                    ClipContainerInstance.X = ClipContainerInstanceXFirstValue * (1 - interpolationValue) + ClipContainerInstanceXSecondValue * interpolationValue;
                }
                if (setClipContainerInstanceYFirstValue && setClipContainerInstanceYSecondValue)
                {
                    ClipContainerInstance.Y = ClipContainerInstanceYFirstValue * (1 - interpolationValue) + ClipContainerInstanceYSecondValue * interpolationValue;
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
                if (setInnerPanelInstanceHeightFirstValue && setInnerPanelInstanceHeightSecondValue)
                {
                    InnerPanelInstance.Height = InnerPanelInstanceHeightFirstValue * (1 - interpolationValue) + InnerPanelInstanceHeightSecondValue * interpolationValue;
                }
                if (setInnerPanelInstanceWidthFirstValue && setInnerPanelInstanceWidthSecondValue)
                {
                    InnerPanelInstance.Width = InnerPanelInstanceWidthFirstValue * (1 - interpolationValue) + InnerPanelInstanceWidthSecondValue * interpolationValue;
                }
                if (setInnerPanelInstanceXFirstValue && setInnerPanelInstanceXSecondValue)
                {
                    InnerPanelInstance.X = InnerPanelInstanceXFirstValue * (1 - interpolationValue) + InnerPanelInstanceXSecondValue * interpolationValue;
                }
                if (setInnerPanelInstanceYFirstValue && setInnerPanelInstanceYSecondValue)
                {
                    InnerPanelInstance.Y = InnerPanelInstanceYFirstValue * (1 - interpolationValue) + InnerPanelInstanceYSecondValue * interpolationValue;
                }
                if (setVerticalScrollBarInstanceHeightFirstValue && setVerticalScrollBarInstanceHeightSecondValue)
                {
                    VerticalScrollBarInstance.Height = VerticalScrollBarInstanceHeightFirstValue * (1 - interpolationValue) + VerticalScrollBarInstanceHeightSecondValue * interpolationValue;
                }
                if (setVerticalScrollBarInstanceXFirstValue && setVerticalScrollBarInstanceXSecondValue)
                {
                    VerticalScrollBarInstance.X = VerticalScrollBarInstanceXFirstValue * (1 - interpolationValue) + VerticalScrollBarInstanceXSecondValue * interpolationValue;
                }
                if (setVerticalScrollBarInstanceYFirstValue && setVerticalScrollBarInstanceYSecondValue)
                {
                    VerticalScrollBarInstance.Y = VerticalScrollBarInstanceYFirstValue * (1 - interpolationValue) + VerticalScrollBarInstanceYSecondValue * interpolationValue;
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
            public void InterpolateBetween (ListBoxCategory firstState, ListBoxCategory secondState, float interpolationValue) 
            {
                #if DEBUG
                if (float.IsNaN(interpolationValue))
                {
                    throw new System.Exception("interpolationValue cannot be NaN");
                }
                #endif
                bool setColoredFrameInstanceAlphaFirstValue = false;
                bool setColoredFrameInstanceAlphaSecondValue = false;
                int ColoredFrameInstanceAlphaFirstValue= 0;
                int ColoredFrameInstanceAlphaSecondValue= 0;
                switch(firstState)
                {
                    case  ListBoxCategory.Enabled:
                        setColoredFrameInstanceAlphaFirstValue = true;
                        ColoredFrameInstanceAlphaFirstValue = 255;
                        if (interpolationValue < 1)
                        {
                            this.ColoredFrameInstance.Visible = true;
                        }
                        if (interpolationValue < 1)
                        {
                            this.HighlightRectangle.Visible = false;
                        }
                        break;
                    case  ListBoxCategory.Focused:
                        setColoredFrameInstanceAlphaFirstValue = true;
                        ColoredFrameInstanceAlphaFirstValue = 255;
                        if (interpolationValue < 1)
                        {
                            this.ColoredFrameInstance.Visible = true;
                        }
                        if (interpolationValue < 1)
                        {
                            this.HighlightRectangle.Visible = true;
                        }
                        break;
                    case  ListBoxCategory.Disabled:
                        setColoredFrameInstanceAlphaFirstValue = true;
                        ColoredFrameInstanceAlphaFirstValue = 128;
                        if (interpolationValue < 1)
                        {
                            this.ColoredFrameInstance.Visible = true;
                        }
                        if (interpolationValue < 1)
                        {
                            this.HighlightRectangle.Visible = false;
                        }
                        break;
                }
                switch(secondState)
                {
                    case  ListBoxCategory.Enabled:
                        setColoredFrameInstanceAlphaSecondValue = true;
                        ColoredFrameInstanceAlphaSecondValue = 255;
                        if (interpolationValue >= 1)
                        {
                            this.ColoredFrameInstance.Visible = true;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.HighlightRectangle.Visible = false;
                        }
                        break;
                    case  ListBoxCategory.Focused:
                        setColoredFrameInstanceAlphaSecondValue = true;
                        ColoredFrameInstanceAlphaSecondValue = 255;
                        if (interpolationValue >= 1)
                        {
                            this.ColoredFrameInstance.Visible = true;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.HighlightRectangle.Visible = true;
                        }
                        break;
                    case  ListBoxCategory.Disabled:
                        setColoredFrameInstanceAlphaSecondValue = true;
                        ColoredFrameInstanceAlphaSecondValue = 128;
                        if (interpolationValue >= 1)
                        {
                            this.ColoredFrameInstance.Visible = true;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.HighlightRectangle.Visible = false;
                        }
                        break;
                }
                var wasSuppressed = mIsLayoutSuspended;
                if (wasSuppressed == false)
                {
                    SuspendLayout(true);
                }
                if (setColoredFrameInstanceAlphaFirstValue && setColoredFrameInstanceAlphaSecondValue)
                {
                    ColoredFrameInstance.Alpha = FlatRedBall.Math.MathFunctions.RoundToInt(ColoredFrameInstanceAlphaFirstValue* (1 - interpolationValue) + ColoredFrameInstanceAlphaSecondValue * interpolationValue);
                }
                if (interpolationValue < 1)
                {
                    mCurrentListBoxCategoryState = firstState;
                }
                else
                {
                    mCurrentListBoxCategoryState = secondState;
                }
                if (!wasSuppressed)
                {
                    ResumeLayout(true);
                }
            }
            public void InterpolateBetween (ScrollBarVisibility firstState, ScrollBarVisibility secondState, float interpolationValue) 
            {
                #if DEBUG
                if (float.IsNaN(interpolationValue))
                {
                    throw new System.Exception("interpolationValue cannot be NaN");
                }
                #endif
                bool setClipContainerInstanceWidthFirstValue = false;
                bool setClipContainerInstanceWidthSecondValue = false;
                float ClipContainerInstanceWidthFirstValue= 0;
                float ClipContainerInstanceWidthSecondValue= 0;
                switch(firstState)
                {
                    case  ScrollBarVisibility.NoScrollBar:
                        setClipContainerInstanceWidthFirstValue = true;
                        ClipContainerInstanceWidthFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.VerticalScrollBarInstance.Visible = false;
                        }
                        break;
                    case  ScrollBarVisibility.VerticalScrollVisible:
                        setClipContainerInstanceWidthFirstValue = true;
                        ClipContainerInstanceWidthFirstValue = -36f;
                        if (interpolationValue < 1)
                        {
                            this.VerticalScrollBarInstance.Visible = true;
                        }
                        break;
                }
                switch(secondState)
                {
                    case  ScrollBarVisibility.NoScrollBar:
                        setClipContainerInstanceWidthSecondValue = true;
                        ClipContainerInstanceWidthSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.VerticalScrollBarInstance.Visible = false;
                        }
                        break;
                    case  ScrollBarVisibility.VerticalScrollVisible:
                        setClipContainerInstanceWidthSecondValue = true;
                        ClipContainerInstanceWidthSecondValue = -36f;
                        if (interpolationValue >= 1)
                        {
                            this.VerticalScrollBarInstance.Visible = true;
                        }
                        break;
                }
                var wasSuppressed = mIsLayoutSuspended;
                if (wasSuppressed == false)
                {
                    SuspendLayout(true);
                }
                if (setClipContainerInstanceWidthFirstValue && setClipContainerInstanceWidthSecondValue)
                {
                    ClipContainerInstance.Width = ClipContainerInstanceWidthFirstValue * (1 - interpolationValue) + ClipContainerInstanceWidthSecondValue * interpolationValue;
                }
                if (interpolationValue < 1)
                {
                    mCurrentScrollBarVisibilityState = firstState;
                }
                else
                {
                    mCurrentScrollBarVisibilityState = secondState;
                }
                if (!wasSuppressed)
                {
                    ResumeLayout(true);
                }
            }
            #endregion
            #region State Interpolate To
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (JHP4SD.GumRuntimes.DefaultForms.ListBoxRuntime.VariableState fromState,JHP4SD.GumRuntimes.DefaultForms.ListBoxRuntime.VariableState toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null) 
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
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (JHP4SD.GumRuntimes.DefaultForms.ListBoxRuntime.ListBoxCategory fromState,JHP4SD.GumRuntimes.DefaultForms.ListBoxRuntime.ListBoxCategory toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null) 
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
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (ListBoxCategory toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null ) 
            {
                Gum.DataTypes.Variables.StateSave current = GetCurrentValuesOnState(toState);
                Gum.DataTypes.Variables.StateSave toAsStateSave = this.ElementSave.Categories.First(item => item.Name == "ListBoxCategory").States.First(item => item.Name == toState.ToString());
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
                tweener.Ended += ()=> this.CurrentListBoxCategoryState = toState;
                tweener.Start();
                StateInterpolationPlugin.TweenerManager.Self.Add(tweener);
                return tweener;
            }
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateToRelative (ListBoxCategory toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null ) 
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
                tweener.Ended += ()=> this.CurrentListBoxCategoryState = toState;
                tweener.Start();
                StateInterpolationPlugin.TweenerManager.Self.Add(tweener);
                return tweener;
            }
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (JHP4SD.GumRuntimes.DefaultForms.ListBoxRuntime.ScrollBarVisibility fromState,JHP4SD.GumRuntimes.DefaultForms.ListBoxRuntime.ScrollBarVisibility toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null) 
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
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (ScrollBarVisibility toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null ) 
            {
                Gum.DataTypes.Variables.StateSave current = GetCurrentValuesOnState(toState);
                Gum.DataTypes.Variables.StateSave toAsStateSave = this.ElementSave.Categories.First(item => item.Name == "ScrollBarVisibility").States.First(item => item.Name == toState.ToString());
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
                tweener.Ended += ()=> this.CurrentScrollBarVisibilityState = toState;
                tweener.Start();
                StateInterpolationPlugin.TweenerManager.Self.Add(tweener);
                return tweener;
            }
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateToRelative (ScrollBarVisibility toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null ) 
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
                tweener.Ended += ()=> this.CurrentScrollBarVisibilityState = toState;
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
                VerticalScrollBarInstance.StopAnimations();
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
                            Name = "VerticalScrollBarInstance.Height",
                            Type = "float",
                            Value = VerticalScrollBarInstance.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "VerticalScrollBarInstance.Height Units",
                            Type = "DimensionUnitType",
                            Value = VerticalScrollBarInstance.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "VerticalScrollBarInstance.X",
                            Type = "float",
                            Value = VerticalScrollBarInstance.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "VerticalScrollBarInstance.X Origin",
                            Type = "HorizontalAlignment",
                            Value = VerticalScrollBarInstance.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "VerticalScrollBarInstance.X Units",
                            Type = "PositionUnitType",
                            Value = VerticalScrollBarInstance.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "VerticalScrollBarInstance.Y",
                            Type = "float",
                            Value = VerticalScrollBarInstance.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "VerticalScrollBarInstance.Y Origin",
                            Type = "VerticalAlignment",
                            Value = VerticalScrollBarInstance.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "VerticalScrollBarInstance.Y Units",
                            Type = "PositionUnitType",
                            Value = VerticalScrollBarInstance.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ClipContainerInstance.Clips Children",
                            Type = "bool",
                            Value = ClipContainerInstance.ClipsChildren
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ClipContainerInstance.Height",
                            Type = "float",
                            Value = ClipContainerInstance.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ClipContainerInstance.Height Units",
                            Type = "DimensionUnitType",
                            Value = ClipContainerInstance.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ClipContainerInstance.Width",
                            Type = "float",
                            Value = ClipContainerInstance.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ClipContainerInstance.Width Units",
                            Type = "DimensionUnitType",
                            Value = ClipContainerInstance.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ClipContainerInstance.X",
                            Type = "float",
                            Value = ClipContainerInstance.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ClipContainerInstance.X Origin",
                            Type = "HorizontalAlignment",
                            Value = ClipContainerInstance.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ClipContainerInstance.X Units",
                            Type = "PositionUnitType",
                            Value = ClipContainerInstance.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ClipContainerInstance.Y",
                            Type = "float",
                            Value = ClipContainerInstance.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ClipContainerInstance.Y Origin",
                            Type = "VerticalAlignment",
                            Value = ClipContainerInstance.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ClipContainerInstance.Y Units",
                            Type = "PositionUnitType",
                            Value = ClipContainerInstance.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "InnerPanelInstance.Children Layout",
                            Type = "ChildrenLayout",
                            Value = InnerPanelInstance.ChildrenLayout
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "InnerPanelInstance.Height",
                            Type = "float",
                            Value = InnerPanelInstance.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "InnerPanelInstance.Height Units",
                            Type = "DimensionUnitType",
                            Value = InnerPanelInstance.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "InnerPanelInstance.Parent",
                            Type = "string",
                            Value = InnerPanelInstance.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "InnerPanelInstance.Width",
                            Type = "float",
                            Value = InnerPanelInstance.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "InnerPanelInstance.Width Units",
                            Type = "DimensionUnitType",
                            Value = InnerPanelInstance.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "InnerPanelInstance.X",
                            Type = "float",
                            Value = InnerPanelInstance.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "InnerPanelInstance.Y",
                            Type = "float",
                            Value = InnerPanelInstance.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "InnerPanelInstance.Y Units",
                            Type = "PositionUnitType",
                            Value = InnerPanelInstance.YUnits
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
                            Value = Height + 260f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Width",
                            Type = "float",
                            Value = Width + 243f
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
                            Name = "VerticalScrollBarInstance.Height",
                            Type = "float",
                            Value = VerticalScrollBarInstance.Height + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "VerticalScrollBarInstance.Height Units",
                            Type = "DimensionUnitType",
                            Value = VerticalScrollBarInstance.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "VerticalScrollBarInstance.X",
                            Type = "float",
                            Value = VerticalScrollBarInstance.X + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "VerticalScrollBarInstance.X Origin",
                            Type = "HorizontalAlignment",
                            Value = VerticalScrollBarInstance.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "VerticalScrollBarInstance.X Units",
                            Type = "PositionUnitType",
                            Value = VerticalScrollBarInstance.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "VerticalScrollBarInstance.Y",
                            Type = "float",
                            Value = VerticalScrollBarInstance.Y + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "VerticalScrollBarInstance.Y Origin",
                            Type = "VerticalAlignment",
                            Value = VerticalScrollBarInstance.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "VerticalScrollBarInstance.Y Units",
                            Type = "PositionUnitType",
                            Value = VerticalScrollBarInstance.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ClipContainerInstance.Clips Children",
                            Type = "bool",
                            Value = ClipContainerInstance.ClipsChildren
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ClipContainerInstance.Height",
                            Type = "float",
                            Value = ClipContainerInstance.Height + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ClipContainerInstance.Height Units",
                            Type = "DimensionUnitType",
                            Value = ClipContainerInstance.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ClipContainerInstance.Width",
                            Type = "float",
                            Value = ClipContainerInstance.Width + -36f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ClipContainerInstance.Width Units",
                            Type = "DimensionUnitType",
                            Value = ClipContainerInstance.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ClipContainerInstance.X",
                            Type = "float",
                            Value = ClipContainerInstance.X + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ClipContainerInstance.X Origin",
                            Type = "HorizontalAlignment",
                            Value = ClipContainerInstance.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ClipContainerInstance.X Units",
                            Type = "PositionUnitType",
                            Value = ClipContainerInstance.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ClipContainerInstance.Y",
                            Type = "float",
                            Value = ClipContainerInstance.Y + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ClipContainerInstance.Y Origin",
                            Type = "VerticalAlignment",
                            Value = ClipContainerInstance.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ClipContainerInstance.Y Units",
                            Type = "PositionUnitType",
                            Value = ClipContainerInstance.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "InnerPanelInstance.Children Layout",
                            Type = "ChildrenLayout",
                            Value = InnerPanelInstance.ChildrenLayout
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "InnerPanelInstance.Height",
                            Type = "float",
                            Value = InnerPanelInstance.Height + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "InnerPanelInstance.Height Units",
                            Type = "DimensionUnitType",
                            Value = InnerPanelInstance.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "InnerPanelInstance.Parent",
                            Type = "string",
                            Value = InnerPanelInstance.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "InnerPanelInstance.Width",
                            Type = "float",
                            Value = InnerPanelInstance.Width + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "InnerPanelInstance.Width Units",
                            Type = "DimensionUnitType",
                            Value = InnerPanelInstance.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "InnerPanelInstance.X",
                            Type = "float",
                            Value = InnerPanelInstance.X + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "InnerPanelInstance.Y",
                            Type = "float",
                            Value = InnerPanelInstance.Y + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "InnerPanelInstance.Y Units",
                            Type = "PositionUnitType",
                            Value = InnerPanelInstance.YUnits
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
            private Gum.DataTypes.Variables.StateSave GetCurrentValuesOnState (ListBoxCategory state) 
            {
                Gum.DataTypes.Variables.StateSave newState = new Gum.DataTypes.Variables.StateSave();
                switch(state)
                {
                    case  ListBoxCategory.Enabled:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredFrameInstance.Alpha",
                            Type = "int",
                            Value = ColoredFrameInstance.Alpha
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredFrameInstance.Visible",
                            Type = "bool",
                            Value = ColoredFrameInstance.Visible
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
                    case  ListBoxCategory.Focused:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredFrameInstance.Alpha",
                            Type = "int",
                            Value = ColoredFrameInstance.Alpha
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredFrameInstance.Visible",
                            Type = "bool",
                            Value = ColoredFrameInstance.Visible
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
                    case  ListBoxCategory.Disabled:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredFrameInstance.Alpha",
                            Type = "int",
                            Value = ColoredFrameInstance.Alpha
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredFrameInstance.Visible",
                            Type = "bool",
                            Value = ColoredFrameInstance.Visible
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
            private Gum.DataTypes.Variables.StateSave AddToCurrentValuesWithState (ListBoxCategory state) 
            {
                Gum.DataTypes.Variables.StateSave newState = new Gum.DataTypes.Variables.StateSave();
                switch(state)
                {
                    case  ListBoxCategory.Enabled:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredFrameInstance.Alpha",
                            Type = "int",
                            Value = ColoredFrameInstance.Alpha + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredFrameInstance.Visible",
                            Type = "bool",
                            Value = ColoredFrameInstance.Visible
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
                    case  ListBoxCategory.Focused:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredFrameInstance.Alpha",
                            Type = "int",
                            Value = ColoredFrameInstance.Alpha + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredFrameInstance.Visible",
                            Type = "bool",
                            Value = ColoredFrameInstance.Visible
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
                    case  ListBoxCategory.Disabled:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredFrameInstance.Alpha",
                            Type = "int",
                            Value = ColoredFrameInstance.Alpha + 128
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredFrameInstance.Visible",
                            Type = "bool",
                            Value = ColoredFrameInstance.Visible
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
            private Gum.DataTypes.Variables.StateSave GetCurrentValuesOnState (ScrollBarVisibility state) 
            {
                Gum.DataTypes.Variables.StateSave newState = new Gum.DataTypes.Variables.StateSave();
                switch(state)
                {
                    case  ScrollBarVisibility.NoScrollBar:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "VerticalScrollBarInstance.Visible",
                            Type = "bool",
                            Value = VerticalScrollBarInstance.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ClipContainerInstance.Width",
                            Type = "float",
                            Value = ClipContainerInstance.Width
                        }
                        );
                        break;
                    case  ScrollBarVisibility.VerticalScrollVisible:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "VerticalScrollBarInstance.Visible",
                            Type = "bool",
                            Value = VerticalScrollBarInstance.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ClipContainerInstance.Width",
                            Type = "float",
                            Value = ClipContainerInstance.Width
                        }
                        );
                        break;
                }
                return newState;
            }
            private Gum.DataTypes.Variables.StateSave AddToCurrentValuesWithState (ScrollBarVisibility state) 
            {
                Gum.DataTypes.Variables.StateSave newState = new Gum.DataTypes.Variables.StateSave();
                switch(state)
                {
                    case  ScrollBarVisibility.NoScrollBar:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "VerticalScrollBarInstance.Visible",
                            Type = "bool",
                            Value = VerticalScrollBarInstance.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ClipContainerInstance.Width",
                            Type = "float",
                            Value = ClipContainerInstance.Width + 0f
                        }
                        );
                        break;
                    case  ScrollBarVisibility.VerticalScrollVisible:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "VerticalScrollBarInstance.Visible",
                            Type = "bool",
                            Value = VerticalScrollBarInstance.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ClipContainerInstance.Width",
                            Type = "float",
                            Value = ClipContainerInstance.Width + -36f
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
                    else if (category.Name == "ListBoxCategory")
                    {
                        if(state.Name == "Enabled") this.mCurrentListBoxCategoryState = ListBoxCategory.Enabled;
                        if(state.Name == "Focused") this.mCurrentListBoxCategoryState = ListBoxCategory.Focused;
                        if(state.Name == "Disabled") this.mCurrentListBoxCategoryState = ListBoxCategory.Disabled;
                    }
                    else if (category.Name == "ScrollBarVisibility")
                    {
                        if(state.Name == "NoScrollBar") this.mCurrentScrollBarVisibilityState = ScrollBarVisibility.NoScrollBar;
                        if(state.Name == "VerticalScrollVisible") this.mCurrentScrollBarVisibilityState = ScrollBarVisibility.VerticalScrollVisible;
                    }
                }
                base.ApplyState(state);
            }
            private bool tryCreateFormsObject;
            public JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime ColoredFrameInstance { get; set; }
            public JHP4SD.GumRuntimes.DefaultForms.ScrollBarRuntime VerticalScrollBarInstance { get; set; }
            public JHP4SD.GumRuntimes.ContainerRuntime ClipContainerInstance { get; set; }
            public JHP4SD.GumRuntimes.ContainerRuntime InnerPanelInstance { get; set; }
            public JHP4SD.GumRuntimes.RectangleRuntime HighlightRectangle { get; set; }
            public int ColoredFrameInstanceAlpha
            {
                get
                {
                    return ColoredFrameInstance.Alpha;
                }
                set
                {
                    if (ColoredFrameInstance.Alpha != value)
                    {
                        ColoredFrameInstance.Alpha = value;
                        ColoredFrameInstanceAlphaChanged?.Invoke(this, null);
                    }
                }
            }
            public DefaultForms.ColoredFrameRuntime.ColorCategory? ListBoxBackgroundColorCategoryState
            {
                get
                {
                    return ColoredFrameInstance.CurrentColorCategoryState;
                }
                set
                {
                    if (ColoredFrameInstance.CurrentColorCategoryState != value)
                    {
                        ColoredFrameInstance.CurrentColorCategoryState = value;
                        ListBoxBackgroundColorCategoryStateChanged?.Invoke(this, null);
                    }
                }
            }
            public Gum.Managers.ChildrenLayout InnerPanelInstanceChildren_Layout
            {
                get
                {
                    return InnerPanelInstance.ChildrenLayout;
                }
                set
                {
                    if (InnerPanelInstance.ChildrenLayout != value)
                    {
                        InnerPanelInstance.ChildrenLayout = value;
                        InnerPanelInstanceChildrenLayoutChanged?.Invoke(this, null);
                    }
                }
            }
            public bool InnerPanelInstanceWraps_Children
            {
                get
                {
                    return InnerPanelInstance.WrapsChildren;
                }
                set
                {
                    if (InnerPanelInstance.WrapsChildren != value)
                    {
                        InnerPanelInstance.WrapsChildren = value;
                        InnerPanelInstanceWrapsChildrenChanged?.Invoke(this, null);
                    }
                }
            }
            public event FlatRedBall.Gui.WindowEvent VerticalScrollBarInstanceClick;
            public event System.EventHandler ColoredFrameInstanceAlphaChanged;
            public event System.EventHandler ListBoxBackgroundColorCategoryStateChanged;
            public event System.EventHandler InnerPanelInstanceChildrenLayoutChanged;
            public event System.EventHandler InnerPanelInstanceWrapsChildrenChanged;
            public ListBoxRuntime (bool fullInstantiation = true, bool tryCreateFormsObject = true) 
            	: base(false, tryCreateFormsObject)
            {
                this.tryCreateFormsObject = tryCreateFormsObject;
                if (fullInstantiation)
                {
                    Gum.DataTypes.ElementSave elementSave = Gum.Managers.ObjectFinder.Self.GumProjectSave.Components.First(item => item.Name == "DefaultForms/ListBox");
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
                VerticalScrollBarInstance = this.GetGraphicalUiElementByName("VerticalScrollBarInstance") as JHP4SD.GumRuntimes.DefaultForms.ScrollBarRuntime;
                ClipContainerInstance = this.GetGraphicalUiElementByName("ClipContainerInstance") as JHP4SD.GumRuntimes.ContainerRuntime;
                InnerPanelInstance = this.GetGraphicalUiElementByName("InnerPanelInstance") as JHP4SD.GumRuntimes.ContainerRuntime;
                HighlightRectangle = this.GetGraphicalUiElementByName("HighlightRectangle") as JHP4SD.GumRuntimes.RectangleRuntime;
                VerticalScrollBarInstance.Click += (unused) => VerticalScrollBarInstanceClick?.Invoke(this);
                if (tryCreateFormsObject)
                {
                    FormsControlAsObject = new FlatRedBall.Forms.Controls.ListBox(this);
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
            public FlatRedBall.Forms.Controls.ListBox FormsControl {get => (FlatRedBall.Forms.Controls.ListBox) FormsControlAsObject;}
        }
    }
