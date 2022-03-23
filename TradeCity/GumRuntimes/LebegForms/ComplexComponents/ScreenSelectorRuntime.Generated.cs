    using System.Linq;
    namespace JHP4SD.GumRuntimes.LebegForms.ComplexComponents
    {
        public partial class ScreenSelectorRuntime : JHP4SD.GumRuntimes.ContainerRuntime
        {
            #region State Enums
            public enum VariableState
            {
                Default
            }
            public enum Selection
            {
                CitySelected,
                MapSelected,
                MarketSelected
            }
            #endregion
            #region State Fields
            VariableState mCurrentVariableState;
            Selection? mCurrentSelectionState;
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
                            CityTab.Parent = this.GetGraphicalUiElementByName("TabContainer") ?? this;
                            MapTab.Parent = this.GetGraphicalUiElementByName("TabContainer") ?? this;
                            MarketTab.Parent = this.GetGraphicalUiElementByName("TabContainer") ?? this;
                            ColoredFrameInstance.CurrentColorCategoryState = JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.TransparentBlack;
                            ChildrenLayout = Gum.Managers.ChildrenLayout.Regular;
                            Height = 108f;
                            HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                            Width = 50f;
                            WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            X = 0f;
                            XUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                            YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Bottom;
                            YUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                            ColoredFrameInstance.Height = 90f;
                            ColoredFrameInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            ColoredFrameInstance.Width = 100f;
                            ColoredFrameInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            ColoredFrameInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Bottom;
                            ColoredFrameInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                            TabContainer.ChildrenLayout = Gum.Managers.ChildrenLayout.LeftToRightStack;
                            TabContainer.Height = 0f;
                            TabContainer.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                            TabContainer.Width = 0f;
                            TabContainer.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                            TabContainer.X = 0f;
                            TabContainer.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                            TabContainer.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            TabContainer.Y = 0f;
                            TabContainer.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            TabContainer.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            CityTab.Height = 120f;
                            CityTab.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            CityTab.Text = "City";
                            CityTab.Width = 32f;
                            CityTab.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            CityTab.X = 1f;
                            CityTab.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                            CityTab.Y = 0f;
                            MapTab.Height = 120f;
                            MapTab.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            MapTab.Text = "Map";
                            MapTab.Width = 32f;
                            MapTab.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            MapTab.X = 1f;
                            MapTab.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                            MapTab.Y = 0f;
                            MarketTab.Height = 120f;
                            MarketTab.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            MarketTab.Text = "Market";
                            MarketTab.Width = 32f;
                            MarketTab.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            MarketTab.X = 1f;
                            MarketTab.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                            MarketTab.Y = 0f;
                            break;
                    }
                }
            }
            public Selection? CurrentSelectionState
            {
                get
                {
                    return mCurrentSelectionState;
                }
                set
                {
                    if (value != null)
                    {
                        mCurrentSelectionState = value;
                        switch(mCurrentSelectionState)
                        {
                            case  Selection.CitySelected:
                                break;
                            case  Selection.MapSelected:
                                break;
                            case  Selection.MarketSelected:
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
                bool setCityTabHeightFirstValue = false;
                bool setCityTabHeightSecondValue = false;
                float CityTabHeightFirstValue= 0;
                float CityTabHeightSecondValue= 0;
                bool setCityTabWidthFirstValue = false;
                bool setCityTabWidthSecondValue = false;
                float CityTabWidthFirstValue= 0;
                float CityTabWidthSecondValue= 0;
                bool setCityTabXFirstValue = false;
                bool setCityTabXSecondValue = false;
                float CityTabXFirstValue= 0;
                float CityTabXSecondValue= 0;
                bool setCityTabYFirstValue = false;
                bool setCityTabYSecondValue = false;
                float CityTabYFirstValue= 0;
                float CityTabYSecondValue= 0;
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
                bool setHeightFirstValue = false;
                bool setHeightSecondValue = false;
                float HeightFirstValue= 0;
                float HeightSecondValue= 0;
                bool setMapTabHeightFirstValue = false;
                bool setMapTabHeightSecondValue = false;
                float MapTabHeightFirstValue= 0;
                float MapTabHeightSecondValue= 0;
                bool setMapTabWidthFirstValue = false;
                bool setMapTabWidthSecondValue = false;
                float MapTabWidthFirstValue= 0;
                float MapTabWidthSecondValue= 0;
                bool setMapTabXFirstValue = false;
                bool setMapTabXSecondValue = false;
                float MapTabXFirstValue= 0;
                float MapTabXSecondValue= 0;
                bool setMapTabYFirstValue = false;
                bool setMapTabYSecondValue = false;
                float MapTabYFirstValue= 0;
                float MapTabYSecondValue= 0;
                bool setMarketTabHeightFirstValue = false;
                bool setMarketTabHeightSecondValue = false;
                float MarketTabHeightFirstValue= 0;
                float MarketTabHeightSecondValue= 0;
                bool setMarketTabWidthFirstValue = false;
                bool setMarketTabWidthSecondValue = false;
                float MarketTabWidthFirstValue= 0;
                float MarketTabWidthSecondValue= 0;
                bool setMarketTabXFirstValue = false;
                bool setMarketTabXSecondValue = false;
                float MarketTabXFirstValue= 0;
                float MarketTabXSecondValue= 0;
                bool setMarketTabYFirstValue = false;
                bool setMarketTabYSecondValue = false;
                float MarketTabYFirstValue= 0;
                float MarketTabYSecondValue= 0;
                bool setTabContainerHeightFirstValue = false;
                bool setTabContainerHeightSecondValue = false;
                float TabContainerHeightFirstValue= 0;
                float TabContainerHeightSecondValue= 0;
                bool setTabContainerWidthFirstValue = false;
                bool setTabContainerWidthSecondValue = false;
                float TabContainerWidthFirstValue= 0;
                float TabContainerWidthSecondValue= 0;
                bool setTabContainerXFirstValue = false;
                bool setTabContainerXSecondValue = false;
                float TabContainerXFirstValue= 0;
                float TabContainerXSecondValue= 0;
                bool setTabContainerYFirstValue = false;
                bool setTabContainerYSecondValue = false;
                float TabContainerYFirstValue= 0;
                float TabContainerYSecondValue= 0;
                bool setWidthFirstValue = false;
                bool setWidthSecondValue = false;
                float WidthFirstValue= 0;
                float WidthSecondValue= 0;
                bool setXFirstValue = false;
                bool setXSecondValue = false;
                float XFirstValue= 0;
                float XSecondValue= 0;
                switch(firstState)
                {
                    case  VariableState.Default:
                        if (interpolationValue < 1)
                        {
                            this.ChildrenLayout = Gum.Managers.ChildrenLayout.Regular;
                        }
                        setCityTabHeightFirstValue = true;
                        CityTabHeightFirstValue = 120f;
                        if (interpolationValue < 1)
                        {
                            this.CityTab.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.CityTab.Parent = this.GetGraphicalUiElementByName("TabContainer") ?? this;
                        }
                        if (interpolationValue < 1)
                        {
                            this.CityTab.Text = "City";
                        }
                        setCityTabWidthFirstValue = true;
                        CityTabWidthFirstValue = 32f;
                        if (interpolationValue < 1)
                        {
                            this.CityTab.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setCityTabXFirstValue = true;
                        CityTabXFirstValue = 1f;
                        if (interpolationValue < 1)
                        {
                            this.CityTab.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setCityTabYFirstValue = true;
                        CityTabYFirstValue = 0f;
                        setColoredFrameInstanceCurrentColorCategoryStateFirstValue = true;
                        ColoredFrameInstanceCurrentColorCategoryStateFirstValue = JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.TransparentBlack;
                        setColoredFrameInstanceHeightFirstValue = true;
                        ColoredFrameInstanceHeightFirstValue = 90f;
                        if (interpolationValue < 1)
                        {
                            this.ColoredFrameInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setColoredFrameInstanceWidthFirstValue = true;
                        ColoredFrameInstanceWidthFirstValue = 100f;
                        if (interpolationValue < 1)
                        {
                            this.ColoredFrameInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.ColoredFrameInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Bottom;
                        }
                        if (interpolationValue < 1)
                        {
                            this.ColoredFrameInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                        }
                        setHeightFirstValue = true;
                        HeightFirstValue = 108f;
                        if (interpolationValue < 1)
                        {
                            this.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        setMapTabHeightFirstValue = true;
                        MapTabHeightFirstValue = 120f;
                        if (interpolationValue < 1)
                        {
                            this.MapTab.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.MapTab.Parent = this.GetGraphicalUiElementByName("TabContainer") ?? this;
                        }
                        if (interpolationValue < 1)
                        {
                            this.MapTab.Text = "Map";
                        }
                        setMapTabWidthFirstValue = true;
                        MapTabWidthFirstValue = 32f;
                        if (interpolationValue < 1)
                        {
                            this.MapTab.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setMapTabXFirstValue = true;
                        MapTabXFirstValue = 1f;
                        if (interpolationValue < 1)
                        {
                            this.MapTab.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setMapTabYFirstValue = true;
                        MapTabYFirstValue = 0f;
                        setMarketTabHeightFirstValue = true;
                        MarketTabHeightFirstValue = 120f;
                        if (interpolationValue < 1)
                        {
                            this.MarketTab.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.MarketTab.Parent = this.GetGraphicalUiElementByName("TabContainer") ?? this;
                        }
                        if (interpolationValue < 1)
                        {
                            this.MarketTab.Text = "Market";
                        }
                        setMarketTabWidthFirstValue = true;
                        MarketTabWidthFirstValue = 32f;
                        if (interpolationValue < 1)
                        {
                            this.MarketTab.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setMarketTabXFirstValue = true;
                        MarketTabXFirstValue = 1f;
                        if (interpolationValue < 1)
                        {
                            this.MarketTab.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setMarketTabYFirstValue = true;
                        MarketTabYFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.TabContainer.ChildrenLayout = Gum.Managers.ChildrenLayout.LeftToRightStack;
                        }
                        setTabContainerHeightFirstValue = true;
                        TabContainerHeightFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.TabContainer.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        setTabContainerWidthFirstValue = true;
                        TabContainerWidthFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.TabContainer.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        setTabContainerXFirstValue = true;
                        TabContainerXFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.TabContainer.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.TabContainer.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setTabContainerYFirstValue = true;
                        TabContainerYFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.TabContainer.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.TabContainer.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setWidthFirstValue = true;
                        WidthFirstValue = 50f;
                        if (interpolationValue < 1)
                        {
                            this.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setXFirstValue = true;
                        XFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.XUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                        }
                        if (interpolationValue < 1)
                        {
                            this.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Bottom;
                        }
                        if (interpolationValue < 1)
                        {
                            this.YUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                        }
                        break;
                }
                switch(secondState)
                {
                    case  VariableState.Default:
                        if (interpolationValue >= 1)
                        {
                            this.ChildrenLayout = Gum.Managers.ChildrenLayout.Regular;
                        }
                        setCityTabHeightSecondValue = true;
                        CityTabHeightSecondValue = 120f;
                        if (interpolationValue >= 1)
                        {
                            this.CityTab.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.CityTab.Parent = this.GetGraphicalUiElementByName("TabContainer") ?? this;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.CityTab.Text = "City";
                        }
                        setCityTabWidthSecondValue = true;
                        CityTabWidthSecondValue = 32f;
                        if (interpolationValue >= 1)
                        {
                            this.CityTab.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setCityTabXSecondValue = true;
                        CityTabXSecondValue = 1f;
                        if (interpolationValue >= 1)
                        {
                            this.CityTab.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setCityTabYSecondValue = true;
                        CityTabYSecondValue = 0f;
                        setColoredFrameInstanceCurrentColorCategoryStateSecondValue = true;
                        ColoredFrameInstanceCurrentColorCategoryStateSecondValue = JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.TransparentBlack;
                        setColoredFrameInstanceHeightSecondValue = true;
                        ColoredFrameInstanceHeightSecondValue = 90f;
                        if (interpolationValue >= 1)
                        {
                            this.ColoredFrameInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setColoredFrameInstanceWidthSecondValue = true;
                        ColoredFrameInstanceWidthSecondValue = 100f;
                        if (interpolationValue >= 1)
                        {
                            this.ColoredFrameInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.ColoredFrameInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Bottom;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.ColoredFrameInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                        }
                        setHeightSecondValue = true;
                        HeightSecondValue = 108f;
                        if (interpolationValue >= 1)
                        {
                            this.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        setMapTabHeightSecondValue = true;
                        MapTabHeightSecondValue = 120f;
                        if (interpolationValue >= 1)
                        {
                            this.MapTab.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.MapTab.Parent = this.GetGraphicalUiElementByName("TabContainer") ?? this;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.MapTab.Text = "Map";
                        }
                        setMapTabWidthSecondValue = true;
                        MapTabWidthSecondValue = 32f;
                        if (interpolationValue >= 1)
                        {
                            this.MapTab.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setMapTabXSecondValue = true;
                        MapTabXSecondValue = 1f;
                        if (interpolationValue >= 1)
                        {
                            this.MapTab.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setMapTabYSecondValue = true;
                        MapTabYSecondValue = 0f;
                        setMarketTabHeightSecondValue = true;
                        MarketTabHeightSecondValue = 120f;
                        if (interpolationValue >= 1)
                        {
                            this.MarketTab.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.MarketTab.Parent = this.GetGraphicalUiElementByName("TabContainer") ?? this;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.MarketTab.Text = "Market";
                        }
                        setMarketTabWidthSecondValue = true;
                        MarketTabWidthSecondValue = 32f;
                        if (interpolationValue >= 1)
                        {
                            this.MarketTab.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setMarketTabXSecondValue = true;
                        MarketTabXSecondValue = 1f;
                        if (interpolationValue >= 1)
                        {
                            this.MarketTab.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setMarketTabYSecondValue = true;
                        MarketTabYSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.TabContainer.ChildrenLayout = Gum.Managers.ChildrenLayout.LeftToRightStack;
                        }
                        setTabContainerHeightSecondValue = true;
                        TabContainerHeightSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.TabContainer.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        setTabContainerWidthSecondValue = true;
                        TabContainerWidthSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.TabContainer.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        setTabContainerXSecondValue = true;
                        TabContainerXSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.TabContainer.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.TabContainer.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setTabContainerYSecondValue = true;
                        TabContainerYSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.TabContainer.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.TabContainer.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setWidthSecondValue = true;
                        WidthSecondValue = 50f;
                        if (interpolationValue >= 1)
                        {
                            this.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setXSecondValue = true;
                        XSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.XUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Bottom;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.YUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                        }
                        break;
                }
                var wasSuppressed = mIsLayoutSuspended;
                if (wasSuppressed == false)
                {
                    SuspendLayout(true);
                }
                if (setCityTabHeightFirstValue && setCityTabHeightSecondValue)
                {
                    CityTab.Height = CityTabHeightFirstValue * (1 - interpolationValue) + CityTabHeightSecondValue * interpolationValue;
                }
                if (setCityTabWidthFirstValue && setCityTabWidthSecondValue)
                {
                    CityTab.Width = CityTabWidthFirstValue * (1 - interpolationValue) + CityTabWidthSecondValue * interpolationValue;
                }
                if (setCityTabXFirstValue && setCityTabXSecondValue)
                {
                    CityTab.X = CityTabXFirstValue * (1 - interpolationValue) + CityTabXSecondValue * interpolationValue;
                }
                if (setCityTabYFirstValue && setCityTabYSecondValue)
                {
                    CityTab.Y = CityTabYFirstValue * (1 - interpolationValue) + CityTabYSecondValue * interpolationValue;
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
                if (setHeightFirstValue && setHeightSecondValue)
                {
                    Height = HeightFirstValue * (1 - interpolationValue) + HeightSecondValue * interpolationValue;
                }
                if (setMapTabHeightFirstValue && setMapTabHeightSecondValue)
                {
                    MapTab.Height = MapTabHeightFirstValue * (1 - interpolationValue) + MapTabHeightSecondValue * interpolationValue;
                }
                if (setMapTabWidthFirstValue && setMapTabWidthSecondValue)
                {
                    MapTab.Width = MapTabWidthFirstValue * (1 - interpolationValue) + MapTabWidthSecondValue * interpolationValue;
                }
                if (setMapTabXFirstValue && setMapTabXSecondValue)
                {
                    MapTab.X = MapTabXFirstValue * (1 - interpolationValue) + MapTabXSecondValue * interpolationValue;
                }
                if (setMapTabYFirstValue && setMapTabYSecondValue)
                {
                    MapTab.Y = MapTabYFirstValue * (1 - interpolationValue) + MapTabYSecondValue * interpolationValue;
                }
                if (setMarketTabHeightFirstValue && setMarketTabHeightSecondValue)
                {
                    MarketTab.Height = MarketTabHeightFirstValue * (1 - interpolationValue) + MarketTabHeightSecondValue * interpolationValue;
                }
                if (setMarketTabWidthFirstValue && setMarketTabWidthSecondValue)
                {
                    MarketTab.Width = MarketTabWidthFirstValue * (1 - interpolationValue) + MarketTabWidthSecondValue * interpolationValue;
                }
                if (setMarketTabXFirstValue && setMarketTabXSecondValue)
                {
                    MarketTab.X = MarketTabXFirstValue * (1 - interpolationValue) + MarketTabXSecondValue * interpolationValue;
                }
                if (setMarketTabYFirstValue && setMarketTabYSecondValue)
                {
                    MarketTab.Y = MarketTabYFirstValue * (1 - interpolationValue) + MarketTabYSecondValue * interpolationValue;
                }
                if (setTabContainerHeightFirstValue && setTabContainerHeightSecondValue)
                {
                    TabContainer.Height = TabContainerHeightFirstValue * (1 - interpolationValue) + TabContainerHeightSecondValue * interpolationValue;
                }
                if (setTabContainerWidthFirstValue && setTabContainerWidthSecondValue)
                {
                    TabContainer.Width = TabContainerWidthFirstValue * (1 - interpolationValue) + TabContainerWidthSecondValue * interpolationValue;
                }
                if (setTabContainerXFirstValue && setTabContainerXSecondValue)
                {
                    TabContainer.X = TabContainerXFirstValue * (1 - interpolationValue) + TabContainerXSecondValue * interpolationValue;
                }
                if (setTabContainerYFirstValue && setTabContainerYSecondValue)
                {
                    TabContainer.Y = TabContainerYFirstValue * (1 - interpolationValue) + TabContainerYSecondValue * interpolationValue;
                }
                if (setWidthFirstValue && setWidthSecondValue)
                {
                    Width = WidthFirstValue * (1 - interpolationValue) + WidthSecondValue * interpolationValue;
                }
                if (setXFirstValue && setXSecondValue)
                {
                    X = XFirstValue * (1 - interpolationValue) + XSecondValue * interpolationValue;
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
            public void InterpolateBetween (Selection firstState, Selection secondState, float interpolationValue) 
            {
                #if DEBUG
                if (float.IsNaN(interpolationValue))
                {
                    throw new System.Exception("interpolationValue cannot be NaN");
                }
                #endif
                switch(firstState)
                {
                    case  Selection.CitySelected:
                        break;
                    case  Selection.MapSelected:
                        break;
                    case  Selection.MarketSelected:
                        break;
                }
                switch(secondState)
                {
                    case  Selection.CitySelected:
                        break;
                    case  Selection.MapSelected:
                        break;
                    case  Selection.MarketSelected:
                        break;
                }
                var wasSuppressed = mIsLayoutSuspended;
                if (wasSuppressed == false)
                {
                    SuspendLayout(true);
                }
                if (interpolationValue < 1)
                {
                    mCurrentSelectionState = firstState;
                }
                else
                {
                    mCurrentSelectionState = secondState;
                }
                if (!wasSuppressed)
                {
                    ResumeLayout(true);
                }
            }
            #endregion
            #region State Interpolate To
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (JHP4SD.GumRuntimes.LebegForms.ComplexComponents.ScreenSelectorRuntime.VariableState fromState,JHP4SD.GumRuntimes.LebegForms.ComplexComponents.ScreenSelectorRuntime.VariableState toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null) 
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
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (JHP4SD.GumRuntimes.LebegForms.ComplexComponents.ScreenSelectorRuntime.Selection fromState,JHP4SD.GumRuntimes.LebegForms.ComplexComponents.ScreenSelectorRuntime.Selection toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null) 
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
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (Selection toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null ) 
            {
                Gum.DataTypes.Variables.StateSave current = GetCurrentValuesOnState(toState);
                Gum.DataTypes.Variables.StateSave toAsStateSave = this.ElementSave.Categories.First(item => item.Name == "Selection").States.First(item => item.Name == toState.ToString());
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
                tweener.Ended += ()=> this.CurrentSelectionState = toState;
                tweener.Start();
                StateInterpolationPlugin.TweenerManager.Self.Add(tweener);
                return tweener;
            }
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateToRelative (Selection toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null ) 
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
                tweener.Ended += ()=> this.CurrentSelectionState = toState;
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
                CityTab.StopAnimations();
                MapTab.StopAnimations();
                MarketTab.StopAnimations();
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
                            Name = "Children Layout",
                            Type = "ChildrenLayout",
                            Value = ChildrenLayout
                        }
                        );
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
                            Name = "Y Origin",
                            Type = "VerticalAlignment",
                            Value = YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Y Units",
                            Type = "PositionUnitType",
                            Value = YUnits
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
                            Name = "TabContainer.Children Layout",
                            Type = "ChildrenLayout",
                            Value = TabContainer.ChildrenLayout
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TabContainer.Height",
                            Type = "float",
                            Value = TabContainer.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TabContainer.Height Units",
                            Type = "DimensionUnitType",
                            Value = TabContainer.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TabContainer.Width",
                            Type = "float",
                            Value = TabContainer.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TabContainer.Width Units",
                            Type = "DimensionUnitType",
                            Value = TabContainer.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TabContainer.X",
                            Type = "float",
                            Value = TabContainer.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TabContainer.X Origin",
                            Type = "HorizontalAlignment",
                            Value = TabContainer.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TabContainer.X Units",
                            Type = "PositionUnitType",
                            Value = TabContainer.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TabContainer.Y",
                            Type = "float",
                            Value = TabContainer.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TabContainer.Y Origin",
                            Type = "VerticalAlignment",
                            Value = TabContainer.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TabContainer.Y Units",
                            Type = "PositionUnitType",
                            Value = TabContainer.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CityTab.Height",
                            Type = "float",
                            Value = CityTab.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CityTab.Height Units",
                            Type = "DimensionUnitType",
                            Value = CityTab.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CityTab.Parent",
                            Type = "string",
                            Value = CityTab.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CityTab.Text",
                            Type = "string",
                            Value = CityTab.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CityTab.Width",
                            Type = "float",
                            Value = CityTab.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CityTab.Width Units",
                            Type = "DimensionUnitType",
                            Value = CityTab.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CityTab.X",
                            Type = "float",
                            Value = CityTab.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CityTab.X Units",
                            Type = "PositionUnitType",
                            Value = CityTab.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CityTab.Y",
                            Type = "float",
                            Value = CityTab.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MapTab.Height",
                            Type = "float",
                            Value = MapTab.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MapTab.Height Units",
                            Type = "DimensionUnitType",
                            Value = MapTab.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MapTab.Parent",
                            Type = "string",
                            Value = MapTab.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MapTab.Text",
                            Type = "string",
                            Value = MapTab.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MapTab.Width",
                            Type = "float",
                            Value = MapTab.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MapTab.Width Units",
                            Type = "DimensionUnitType",
                            Value = MapTab.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MapTab.X",
                            Type = "float",
                            Value = MapTab.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MapTab.X Units",
                            Type = "PositionUnitType",
                            Value = MapTab.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MapTab.Y",
                            Type = "float",
                            Value = MapTab.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MarketTab.Height",
                            Type = "float",
                            Value = MarketTab.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MarketTab.Height Units",
                            Type = "DimensionUnitType",
                            Value = MarketTab.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MarketTab.Parent",
                            Type = "string",
                            Value = MarketTab.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MarketTab.Text",
                            Type = "string",
                            Value = MarketTab.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MarketTab.Width",
                            Type = "float",
                            Value = MarketTab.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MarketTab.Width Units",
                            Type = "DimensionUnitType",
                            Value = MarketTab.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MarketTab.X",
                            Type = "float",
                            Value = MarketTab.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MarketTab.X Units",
                            Type = "PositionUnitType",
                            Value = MarketTab.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MarketTab.Y",
                            Type = "float",
                            Value = MarketTab.Y
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
                            Name = "Children Layout",
                            Type = "ChildrenLayout",
                            Value = ChildrenLayout
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Height",
                            Type = "float",
                            Value = Height + 108f
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
                            Value = Width + 50f
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
                            Value = X + 0f
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
                            Name = "Y Origin",
                            Type = "VerticalAlignment",
                            Value = YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Y Units",
                            Type = "PositionUnitType",
                            Value = YUnits
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
                            Value = ColoredFrameInstance.Height + 90f
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
                            Value = ColoredFrameInstance.Width + 100f
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
                            Name = "TabContainer.Children Layout",
                            Type = "ChildrenLayout",
                            Value = TabContainer.ChildrenLayout
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TabContainer.Height",
                            Type = "float",
                            Value = TabContainer.Height + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TabContainer.Height Units",
                            Type = "DimensionUnitType",
                            Value = TabContainer.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TabContainer.Width",
                            Type = "float",
                            Value = TabContainer.Width + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TabContainer.Width Units",
                            Type = "DimensionUnitType",
                            Value = TabContainer.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TabContainer.X",
                            Type = "float",
                            Value = TabContainer.X + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TabContainer.X Origin",
                            Type = "HorizontalAlignment",
                            Value = TabContainer.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TabContainer.X Units",
                            Type = "PositionUnitType",
                            Value = TabContainer.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TabContainer.Y",
                            Type = "float",
                            Value = TabContainer.Y + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TabContainer.Y Origin",
                            Type = "VerticalAlignment",
                            Value = TabContainer.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TabContainer.Y Units",
                            Type = "PositionUnitType",
                            Value = TabContainer.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CityTab.Height",
                            Type = "float",
                            Value = CityTab.Height + 120f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CityTab.Height Units",
                            Type = "DimensionUnitType",
                            Value = CityTab.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CityTab.Parent",
                            Type = "string",
                            Value = CityTab.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CityTab.Text",
                            Type = "string",
                            Value = CityTab.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CityTab.Width",
                            Type = "float",
                            Value = CityTab.Width + 32f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CityTab.Width Units",
                            Type = "DimensionUnitType",
                            Value = CityTab.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CityTab.X",
                            Type = "float",
                            Value = CityTab.X + 1f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CityTab.X Units",
                            Type = "PositionUnitType",
                            Value = CityTab.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CityTab.Y",
                            Type = "float",
                            Value = CityTab.Y + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MapTab.Height",
                            Type = "float",
                            Value = MapTab.Height + 120f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MapTab.Height Units",
                            Type = "DimensionUnitType",
                            Value = MapTab.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MapTab.Parent",
                            Type = "string",
                            Value = MapTab.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MapTab.Text",
                            Type = "string",
                            Value = MapTab.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MapTab.Width",
                            Type = "float",
                            Value = MapTab.Width + 32f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MapTab.Width Units",
                            Type = "DimensionUnitType",
                            Value = MapTab.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MapTab.X",
                            Type = "float",
                            Value = MapTab.X + 1f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MapTab.X Units",
                            Type = "PositionUnitType",
                            Value = MapTab.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MapTab.Y",
                            Type = "float",
                            Value = MapTab.Y + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MarketTab.Height",
                            Type = "float",
                            Value = MarketTab.Height + 120f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MarketTab.Height Units",
                            Type = "DimensionUnitType",
                            Value = MarketTab.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MarketTab.Parent",
                            Type = "string",
                            Value = MarketTab.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MarketTab.Text",
                            Type = "string",
                            Value = MarketTab.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MarketTab.Width",
                            Type = "float",
                            Value = MarketTab.Width + 32f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MarketTab.Width Units",
                            Type = "DimensionUnitType",
                            Value = MarketTab.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MarketTab.X",
                            Type = "float",
                            Value = MarketTab.X + 1f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MarketTab.X Units",
                            Type = "PositionUnitType",
                            Value = MarketTab.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MarketTab.Y",
                            Type = "float",
                            Value = MarketTab.Y + 0f
                        }
                        );
                        break;
                }
                return newState;
            }
            private Gum.DataTypes.Variables.StateSave GetCurrentValuesOnState (Selection state) 
            {
                Gum.DataTypes.Variables.StateSave newState = new Gum.DataTypes.Variables.StateSave();
                switch(state)
                {
                    case  Selection.CitySelected:
                        break;
                    case  Selection.MapSelected:
                        break;
                    case  Selection.MarketSelected:
                        break;
                }
                return newState;
            }
            private Gum.DataTypes.Variables.StateSave AddToCurrentValuesWithState (Selection state) 
            {
                Gum.DataTypes.Variables.StateSave newState = new Gum.DataTypes.Variables.StateSave();
                switch(state)
                {
                    case  Selection.CitySelected:
                        break;
                    case  Selection.MapSelected:
                        break;
                    case  Selection.MarketSelected:
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
                    else if (category.Name == "Selection")
                    {
                        if(state.Name == "CitySelected") this.mCurrentSelectionState = Selection.CitySelected;
                        if(state.Name == "MapSelected") this.mCurrentSelectionState = Selection.MapSelected;
                        if(state.Name == "MarketSelected") this.mCurrentSelectionState = Selection.MarketSelected;
                    }
                }
                base.ApplyState(state);
            }
            private bool tryCreateFormsObject;
            public JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime ColoredFrameInstance { get; set; }
            public JHP4SD.GumRuntimes.ContainerRuntime TabContainer { get; set; }
            public JHP4SD.GumRuntimes.LebegForms.BasicComponents.TabButtonRuntime CityTab { get; set; }
            public JHP4SD.GumRuntimes.LebegForms.BasicComponents.TabButtonRuntime MapTab { get; set; }
            public JHP4SD.GumRuntimes.LebegForms.BasicComponents.TabButtonRuntime MarketTab { get; set; }
            public event FlatRedBall.Gui.WindowEvent CityTabClick;
            public event FlatRedBall.Gui.WindowEvent MapTabClick;
            public event FlatRedBall.Gui.WindowEvent MarketTabClick;
            public ScreenSelectorRuntime (bool fullInstantiation = true, bool tryCreateFormsObject = true) 
            	: base(false, tryCreateFormsObject)
            {
                this.tryCreateFormsObject = tryCreateFormsObject;
                if (fullInstantiation)
                {
                    Gum.DataTypes.ElementSave elementSave = Gum.Managers.ObjectFinder.Self.GumProjectSave.Components.First(item => item.Name == "LebegForms/ComplexComponents/ScreenSelector");
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
                TabContainer = this.GetGraphicalUiElementByName("TabContainer") as JHP4SD.GumRuntimes.ContainerRuntime;
                CityTab = this.GetGraphicalUiElementByName("CityTab") as JHP4SD.GumRuntimes.LebegForms.BasicComponents.TabButtonRuntime;
                MapTab = this.GetGraphicalUiElementByName("MapTab") as JHP4SD.GumRuntimes.LebegForms.BasicComponents.TabButtonRuntime;
                MarketTab = this.GetGraphicalUiElementByName("MarketTab") as JHP4SD.GumRuntimes.LebegForms.BasicComponents.TabButtonRuntime;
                CityTab.Click += (unused) => CityTabClick?.Invoke(this);
                MapTab.Click += (unused) => MapTabClick?.Invoke(this);
                MarketTab.Click += (unused) => MarketTabClick?.Invoke(this);
                if (tryCreateFormsObject)
                {
                    FormsControlAsObject = new JHP4SD.FormsControls.Components.LebegForms.ComplexComponents.ScreenSelectorForms(this);
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
            public JHP4SD.FormsControls.Components.LebegForms.ComplexComponents.ScreenSelectorForms FormsControl {get => (JHP4SD.FormsControls.Components.LebegForms.ComplexComponents.ScreenSelectorForms) FormsControlAsObject;}
        }
    }
