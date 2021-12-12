    using System.Linq;
    namespace JHP4SD.GumRuntimes.LebegForms.ComplexComponents
    {
        public partial class TabMenuRuntime : JHP4SD.GumRuntimes.ContainerRuntime
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
                            CommonList.Parent = this.GetGraphicalUiElementByName("ScrollContainer") ?? this;
                            ConstructionList.Parent = this.GetGraphicalUiElementByName("ScrollContainer") ?? this;
                            CommonTab.Parent = this.GetGraphicalUiElementByName("ContainerInstance") ?? this;
                            ConstructionTab.Parent = this.GetGraphicalUiElementByName("ContainerInstance") ?? this;
                            EnergyTab.Parent = this.GetGraphicalUiElementByName("ContainerInstance") ?? this;
                            OilTab.Parent = this.GetGraphicalUiElementByName("ContainerInstance") ?? this;
                            WorkforceTab.Parent = this.GetGraphicalUiElementByName("ContainerInstance") ?? this;
                            EnergyList.Parent = this.GetGraphicalUiElementByName("ScrollContainer") ?? this;
                            OilList.Parent = this.GetGraphicalUiElementByName("ScrollContainer") ?? this;
                            WorkforceList.Parent = this.GetGraphicalUiElementByName("ScrollContainer") ?? this;
                            HeaderPanel.CurrentColorCategoryState = JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Black;
                            CommonTab.CurrentButtonCategoryState = JHP4SD.GumRuntimes.LebegForms.BasicComponents.CityMenuTabRuntime.ButtonCategory.Disabled;
                            ConstructionTab.CurrentButtonCategoryState = JHP4SD.GumRuntimes.LebegForms.BasicComponents.CityMenuTabRuntime.ButtonCategory.Enabled;
                            EnergyTab.CurrentButtonCategoryState = JHP4SD.GumRuntimes.LebegForms.BasicComponents.CityMenuTabRuntime.ButtonCategory.Enabled;
                            OilTab.CurrentButtonCategoryState = JHP4SD.GumRuntimes.LebegForms.BasicComponents.CityMenuTabRuntime.ButtonCategory.Enabled;
                            WorkforceTab.CurrentButtonCategoryState = JHP4SD.GumRuntimes.LebegForms.BasicComponents.CityMenuTabRuntime.ButtonCategory.Enabled;
                            WorkforceTab.CurrentVariableState = JHP4SD.GumRuntimes.LebegForms.BasicComponents.CityMenuTabRuntime.VariableState.Default;
                            Height = -144f;
                            HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                            Width = 500f;
                            XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                            XUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                            Y = 72f;
                            YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Top;
                            YUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                            HeaderPanel.Height = 72f;
                            HeaderPanel.Width = 100f;
                            HeaderPanel.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            CommonList.Height = 0f;
                            CommonList.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                            CommonList.Width = 0f;
                            CommonList.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                            CommonList.X = 0f;
                            CommonList.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                            CommonList.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            CommonList.Y = 0f;
                            CommonList.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            CommonList.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            ConstructionList.Height = 0f;
                            ConstructionList.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                            ConstructionList.Visible = false;
                            ConstructionList.Width = 0f;
                            ConstructionList.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                            ConstructionList.X = 0f;
                            ConstructionList.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                            ConstructionList.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            ConstructionList.Y = 0f;
                            ConstructionList.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            ConstructionList.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            ContainerInstance.ChildrenLayout = Gum.Managers.ChildrenLayout.LeftToRightStack;
                            ContainerInstance.Height = 56f;
                            ContainerInstance.Width = -16f;
                            ContainerInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                            ContainerInstance.X = 8f;
                            ContainerInstance.Y = 8f;
                            SetProperty("CommonTab.MenuIcon", "../GlobalContent/Resources/CategoryIcons/factory.png");
                            SetProperty("ConstructionTab.MenuIcon", "../GlobalContent/Resources/CategoryIcons/crane.png");
                            SetProperty("EnergyTab.MenuIcon", "../GlobalContent/Resources/CategoryIcons/pylon.png");
                            SetProperty("OilTab.MenuIcon", "../GlobalContent/Resources/CategoryIcons/oil-pump.png");
                            SetProperty("WorkforceTab.MenuIcon", "../GlobalContent/Resources/CategoryIcons/modern-city.png");
                            ScrollContainer.Height = -72f;
                            ScrollContainer.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                            ScrollContainer.Width = 100f;
                            ScrollContainer.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            ScrollContainer.Y = 72f;
                            EnergyList.Height = 0f;
                            EnergyList.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                            EnergyList.Visible = false;
                            EnergyList.Width = 0f;
                            EnergyList.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                            EnergyList.X = 0f;
                            EnergyList.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                            EnergyList.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            EnergyList.Y = 0f;
                            EnergyList.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            EnergyList.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            OilList.Height = 0f;
                            OilList.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                            OilList.Visible = false;
                            OilList.Width = 0f;
                            OilList.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                            OilList.X = 0f;
                            OilList.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                            OilList.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            OilList.Y = 0f;
                            OilList.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            OilList.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            WorkforceList.Height = 0f;
                            WorkforceList.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                            WorkforceList.Visible = false;
                            WorkforceList.Width = 0f;
                            WorkforceList.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                            WorkforceList.X = 0f;
                            WorkforceList.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                            WorkforceList.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            WorkforceList.Y = 0f;
                            WorkforceList.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            WorkforceList.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
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
                bool setCommonListHeightFirstValue = false;
                bool setCommonListHeightSecondValue = false;
                float CommonListHeightFirstValue= 0;
                float CommonListHeightSecondValue= 0;
                bool setCommonListWidthFirstValue = false;
                bool setCommonListWidthSecondValue = false;
                float CommonListWidthFirstValue= 0;
                float CommonListWidthSecondValue= 0;
                bool setCommonListXFirstValue = false;
                bool setCommonListXSecondValue = false;
                float CommonListXFirstValue= 0;
                float CommonListXSecondValue= 0;
                bool setCommonListYFirstValue = false;
                bool setCommonListYSecondValue = false;
                float CommonListYFirstValue= 0;
                float CommonListYSecondValue= 0;
                bool setCommonTabCurrentButtonCategoryStateFirstValue = false;
                bool setCommonTabCurrentButtonCategoryStateSecondValue = false;
                JHP4SD.GumRuntimes.LebegForms.BasicComponents.CityMenuTabRuntime.ButtonCategory CommonTabCurrentButtonCategoryStateFirstValue= JHP4SD.GumRuntimes.LebegForms.BasicComponents.CityMenuTabRuntime.ButtonCategory.Enabled;
                JHP4SD.GumRuntimes.LebegForms.BasicComponents.CityMenuTabRuntime.ButtonCategory CommonTabCurrentButtonCategoryStateSecondValue= JHP4SD.GumRuntimes.LebegForms.BasicComponents.CityMenuTabRuntime.ButtonCategory.Enabled;
                bool setConstructionListHeightFirstValue = false;
                bool setConstructionListHeightSecondValue = false;
                float ConstructionListHeightFirstValue= 0;
                float ConstructionListHeightSecondValue= 0;
                bool setConstructionListWidthFirstValue = false;
                bool setConstructionListWidthSecondValue = false;
                float ConstructionListWidthFirstValue= 0;
                float ConstructionListWidthSecondValue= 0;
                bool setConstructionListXFirstValue = false;
                bool setConstructionListXSecondValue = false;
                float ConstructionListXFirstValue= 0;
                float ConstructionListXSecondValue= 0;
                bool setConstructionListYFirstValue = false;
                bool setConstructionListYSecondValue = false;
                float ConstructionListYFirstValue= 0;
                float ConstructionListYSecondValue= 0;
                bool setConstructionTabCurrentButtonCategoryStateFirstValue = false;
                bool setConstructionTabCurrentButtonCategoryStateSecondValue = false;
                JHP4SD.GumRuntimes.LebegForms.BasicComponents.CityMenuTabRuntime.ButtonCategory ConstructionTabCurrentButtonCategoryStateFirstValue= JHP4SD.GumRuntimes.LebegForms.BasicComponents.CityMenuTabRuntime.ButtonCategory.Enabled;
                JHP4SD.GumRuntimes.LebegForms.BasicComponents.CityMenuTabRuntime.ButtonCategory ConstructionTabCurrentButtonCategoryStateSecondValue= JHP4SD.GumRuntimes.LebegForms.BasicComponents.CityMenuTabRuntime.ButtonCategory.Enabled;
                bool setContainerInstanceHeightFirstValue = false;
                bool setContainerInstanceHeightSecondValue = false;
                float ContainerInstanceHeightFirstValue= 0;
                float ContainerInstanceHeightSecondValue= 0;
                bool setContainerInstanceWidthFirstValue = false;
                bool setContainerInstanceWidthSecondValue = false;
                float ContainerInstanceWidthFirstValue= 0;
                float ContainerInstanceWidthSecondValue= 0;
                bool setContainerInstanceXFirstValue = false;
                bool setContainerInstanceXSecondValue = false;
                float ContainerInstanceXFirstValue= 0;
                float ContainerInstanceXSecondValue= 0;
                bool setContainerInstanceYFirstValue = false;
                bool setContainerInstanceYSecondValue = false;
                float ContainerInstanceYFirstValue= 0;
                float ContainerInstanceYSecondValue= 0;
                bool setEnergyListHeightFirstValue = false;
                bool setEnergyListHeightSecondValue = false;
                float EnergyListHeightFirstValue= 0;
                float EnergyListHeightSecondValue= 0;
                bool setEnergyListWidthFirstValue = false;
                bool setEnergyListWidthSecondValue = false;
                float EnergyListWidthFirstValue= 0;
                float EnergyListWidthSecondValue= 0;
                bool setEnergyListXFirstValue = false;
                bool setEnergyListXSecondValue = false;
                float EnergyListXFirstValue= 0;
                float EnergyListXSecondValue= 0;
                bool setEnergyListYFirstValue = false;
                bool setEnergyListYSecondValue = false;
                float EnergyListYFirstValue= 0;
                float EnergyListYSecondValue= 0;
                bool setEnergyTabCurrentButtonCategoryStateFirstValue = false;
                bool setEnergyTabCurrentButtonCategoryStateSecondValue = false;
                JHP4SD.GumRuntimes.LebegForms.BasicComponents.CityMenuTabRuntime.ButtonCategory EnergyTabCurrentButtonCategoryStateFirstValue= JHP4SD.GumRuntimes.LebegForms.BasicComponents.CityMenuTabRuntime.ButtonCategory.Enabled;
                JHP4SD.GumRuntimes.LebegForms.BasicComponents.CityMenuTabRuntime.ButtonCategory EnergyTabCurrentButtonCategoryStateSecondValue= JHP4SD.GumRuntimes.LebegForms.BasicComponents.CityMenuTabRuntime.ButtonCategory.Enabled;
                bool setHeaderPanelCurrentColorCategoryStateFirstValue = false;
                bool setHeaderPanelCurrentColorCategoryStateSecondValue = false;
                JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory HeaderPanelCurrentColorCategoryStateFirstValue= JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Gray;
                JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory HeaderPanelCurrentColorCategoryStateSecondValue= JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Gray;
                bool setHeaderPanelHeightFirstValue = false;
                bool setHeaderPanelHeightSecondValue = false;
                float HeaderPanelHeightFirstValue= 0;
                float HeaderPanelHeightSecondValue= 0;
                bool setHeaderPanelWidthFirstValue = false;
                bool setHeaderPanelWidthSecondValue = false;
                float HeaderPanelWidthFirstValue= 0;
                float HeaderPanelWidthSecondValue= 0;
                bool setHeightFirstValue = false;
                bool setHeightSecondValue = false;
                float HeightFirstValue= 0;
                float HeightSecondValue= 0;
                bool setOilListHeightFirstValue = false;
                bool setOilListHeightSecondValue = false;
                float OilListHeightFirstValue= 0;
                float OilListHeightSecondValue= 0;
                bool setOilListWidthFirstValue = false;
                bool setOilListWidthSecondValue = false;
                float OilListWidthFirstValue= 0;
                float OilListWidthSecondValue= 0;
                bool setOilListXFirstValue = false;
                bool setOilListXSecondValue = false;
                float OilListXFirstValue= 0;
                float OilListXSecondValue= 0;
                bool setOilListYFirstValue = false;
                bool setOilListYSecondValue = false;
                float OilListYFirstValue= 0;
                float OilListYSecondValue= 0;
                bool setOilTabCurrentButtonCategoryStateFirstValue = false;
                bool setOilTabCurrentButtonCategoryStateSecondValue = false;
                JHP4SD.GumRuntimes.LebegForms.BasicComponents.CityMenuTabRuntime.ButtonCategory OilTabCurrentButtonCategoryStateFirstValue= JHP4SD.GumRuntimes.LebegForms.BasicComponents.CityMenuTabRuntime.ButtonCategory.Enabled;
                JHP4SD.GumRuntimes.LebegForms.BasicComponents.CityMenuTabRuntime.ButtonCategory OilTabCurrentButtonCategoryStateSecondValue= JHP4SD.GumRuntimes.LebegForms.BasicComponents.CityMenuTabRuntime.ButtonCategory.Enabled;
                bool setScrollContainerHeightFirstValue = false;
                bool setScrollContainerHeightSecondValue = false;
                float ScrollContainerHeightFirstValue= 0;
                float ScrollContainerHeightSecondValue= 0;
                bool setScrollContainerWidthFirstValue = false;
                bool setScrollContainerWidthSecondValue = false;
                float ScrollContainerWidthFirstValue= 0;
                float ScrollContainerWidthSecondValue= 0;
                bool setScrollContainerYFirstValue = false;
                bool setScrollContainerYSecondValue = false;
                float ScrollContainerYFirstValue= 0;
                float ScrollContainerYSecondValue= 0;
                bool setWidthFirstValue = false;
                bool setWidthSecondValue = false;
                float WidthFirstValue= 0;
                float WidthSecondValue= 0;
                bool setWorkforceListHeightFirstValue = false;
                bool setWorkforceListHeightSecondValue = false;
                float WorkforceListHeightFirstValue= 0;
                float WorkforceListHeightSecondValue= 0;
                bool setWorkforceListWidthFirstValue = false;
                bool setWorkforceListWidthSecondValue = false;
                float WorkforceListWidthFirstValue= 0;
                float WorkforceListWidthSecondValue= 0;
                bool setWorkforceListXFirstValue = false;
                bool setWorkforceListXSecondValue = false;
                float WorkforceListXFirstValue= 0;
                float WorkforceListXSecondValue= 0;
                bool setWorkforceListYFirstValue = false;
                bool setWorkforceListYSecondValue = false;
                float WorkforceListYFirstValue= 0;
                float WorkforceListYSecondValue= 0;
                bool setWorkforceTabCurrentButtonCategoryStateFirstValue = false;
                bool setWorkforceTabCurrentButtonCategoryStateSecondValue = false;
                JHP4SD.GumRuntimes.LebegForms.BasicComponents.CityMenuTabRuntime.ButtonCategory WorkforceTabCurrentButtonCategoryStateFirstValue= JHP4SD.GumRuntimes.LebegForms.BasicComponents.CityMenuTabRuntime.ButtonCategory.Enabled;
                JHP4SD.GumRuntimes.LebegForms.BasicComponents.CityMenuTabRuntime.ButtonCategory WorkforceTabCurrentButtonCategoryStateSecondValue= JHP4SD.GumRuntimes.LebegForms.BasicComponents.CityMenuTabRuntime.ButtonCategory.Enabled;
                bool setWorkforceTabCurrentVariableStateFirstValue = false;
                bool setWorkforceTabCurrentVariableStateSecondValue = false;
                JHP4SD.GumRuntimes.LebegForms.BasicComponents.CityMenuTabRuntime.VariableState WorkforceTabCurrentVariableStateFirstValue= JHP4SD.GumRuntimes.LebegForms.BasicComponents.CityMenuTabRuntime.VariableState.Default;
                JHP4SD.GumRuntimes.LebegForms.BasicComponents.CityMenuTabRuntime.VariableState WorkforceTabCurrentVariableStateSecondValue= JHP4SD.GumRuntimes.LebegForms.BasicComponents.CityMenuTabRuntime.VariableState.Default;
                bool setYFirstValue = false;
                bool setYSecondValue = false;
                float YFirstValue= 0;
                float YSecondValue= 0;
                switch(firstState)
                {
                    case  VariableState.Default:
                        setCommonListHeightFirstValue = true;
                        CommonListHeightFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.CommonList.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        if (interpolationValue < 1)
                        {
                            this.CommonList.Parent = this.GetGraphicalUiElementByName("ScrollContainer") ?? this;
                        }
                        setCommonListWidthFirstValue = true;
                        CommonListWidthFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.CommonList.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        setCommonListXFirstValue = true;
                        CommonListXFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.CommonList.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.CommonList.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setCommonListYFirstValue = true;
                        CommonListYFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.CommonList.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.CommonList.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setCommonTabCurrentButtonCategoryStateFirstValue = true;
                        CommonTabCurrentButtonCategoryStateFirstValue = JHP4SD.GumRuntimes.LebegForms.BasicComponents.CityMenuTabRuntime.ButtonCategory.Disabled;
                        if (interpolationValue < 1)
                        {
                            SetProperty("CommonTab.MenuIcon", "../GlobalContent/Resources/CategoryIcons/factory.png");
                        }
                        if (interpolationValue < 1)
                        {
                            this.CommonTab.Parent = this.GetGraphicalUiElementByName("ContainerInstance") ?? this;
                        }
                        setConstructionListHeightFirstValue = true;
                        ConstructionListHeightFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.ConstructionList.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        if (interpolationValue < 1)
                        {
                            this.ConstructionList.Parent = this.GetGraphicalUiElementByName("ScrollContainer") ?? this;
                        }
                        if (interpolationValue < 1)
                        {
                            this.ConstructionList.Visible = false;
                        }
                        setConstructionListWidthFirstValue = true;
                        ConstructionListWidthFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.ConstructionList.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        setConstructionListXFirstValue = true;
                        ConstructionListXFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.ConstructionList.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.ConstructionList.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setConstructionListYFirstValue = true;
                        ConstructionListYFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.ConstructionList.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.ConstructionList.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setConstructionTabCurrentButtonCategoryStateFirstValue = true;
                        ConstructionTabCurrentButtonCategoryStateFirstValue = JHP4SD.GumRuntimes.LebegForms.BasicComponents.CityMenuTabRuntime.ButtonCategory.Enabled;
                        if (interpolationValue < 1)
                        {
                            SetProperty("ConstructionTab.MenuIcon", "../GlobalContent/Resources/CategoryIcons/crane.png");
                        }
                        if (interpolationValue < 1)
                        {
                            this.ConstructionTab.Parent = this.GetGraphicalUiElementByName("ContainerInstance") ?? this;
                        }
                        if (interpolationValue < 1)
                        {
                            this.ContainerInstance.ChildrenLayout = Gum.Managers.ChildrenLayout.LeftToRightStack;
                        }
                        setContainerInstanceHeightFirstValue = true;
                        ContainerInstanceHeightFirstValue = 56f;
                        setContainerInstanceWidthFirstValue = true;
                        ContainerInstanceWidthFirstValue = -16f;
                        if (interpolationValue < 1)
                        {
                            this.ContainerInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        setContainerInstanceXFirstValue = true;
                        ContainerInstanceXFirstValue = 8f;
                        setContainerInstanceYFirstValue = true;
                        ContainerInstanceYFirstValue = 8f;
                        setEnergyListHeightFirstValue = true;
                        EnergyListHeightFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.EnergyList.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        if (interpolationValue < 1)
                        {
                            this.EnergyList.Parent = this.GetGraphicalUiElementByName("ScrollContainer") ?? this;
                        }
                        if (interpolationValue < 1)
                        {
                            this.EnergyList.Visible = false;
                        }
                        setEnergyListWidthFirstValue = true;
                        EnergyListWidthFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.EnergyList.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        setEnergyListXFirstValue = true;
                        EnergyListXFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.EnergyList.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.EnergyList.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setEnergyListYFirstValue = true;
                        EnergyListYFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.EnergyList.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.EnergyList.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setEnergyTabCurrentButtonCategoryStateFirstValue = true;
                        EnergyTabCurrentButtonCategoryStateFirstValue = JHP4SD.GumRuntimes.LebegForms.BasicComponents.CityMenuTabRuntime.ButtonCategory.Enabled;
                        if (interpolationValue < 1)
                        {
                            SetProperty("EnergyTab.MenuIcon", "../GlobalContent/Resources/CategoryIcons/pylon.png");
                        }
                        if (interpolationValue < 1)
                        {
                            this.EnergyTab.Parent = this.GetGraphicalUiElementByName("ContainerInstance") ?? this;
                        }
                        setHeaderPanelCurrentColorCategoryStateFirstValue = true;
                        HeaderPanelCurrentColorCategoryStateFirstValue = JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Black;
                        setHeaderPanelHeightFirstValue = true;
                        HeaderPanelHeightFirstValue = 72f;
                        setHeaderPanelWidthFirstValue = true;
                        HeaderPanelWidthFirstValue = 100f;
                        if (interpolationValue < 1)
                        {
                            this.HeaderPanel.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setHeightFirstValue = true;
                        HeightFirstValue = -144f;
                        if (interpolationValue < 1)
                        {
                            this.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        setOilListHeightFirstValue = true;
                        OilListHeightFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.OilList.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        if (interpolationValue < 1)
                        {
                            this.OilList.Parent = this.GetGraphicalUiElementByName("ScrollContainer") ?? this;
                        }
                        if (interpolationValue < 1)
                        {
                            this.OilList.Visible = false;
                        }
                        setOilListWidthFirstValue = true;
                        OilListWidthFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.OilList.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        setOilListXFirstValue = true;
                        OilListXFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.OilList.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.OilList.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setOilListYFirstValue = true;
                        OilListYFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.OilList.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.OilList.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setOilTabCurrentButtonCategoryStateFirstValue = true;
                        OilTabCurrentButtonCategoryStateFirstValue = JHP4SD.GumRuntimes.LebegForms.BasicComponents.CityMenuTabRuntime.ButtonCategory.Enabled;
                        if (interpolationValue < 1)
                        {
                            SetProperty("OilTab.MenuIcon", "../GlobalContent/Resources/CategoryIcons/oil-pump.png");
                        }
                        if (interpolationValue < 1)
                        {
                            this.OilTab.Parent = this.GetGraphicalUiElementByName("ContainerInstance") ?? this;
                        }
                        setScrollContainerHeightFirstValue = true;
                        ScrollContainerHeightFirstValue = -72f;
                        if (interpolationValue < 1)
                        {
                            this.ScrollContainer.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        setScrollContainerWidthFirstValue = true;
                        ScrollContainerWidthFirstValue = 100f;
                        if (interpolationValue < 1)
                        {
                            this.ScrollContainer.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setScrollContainerYFirstValue = true;
                        ScrollContainerYFirstValue = 72f;
                        setWidthFirstValue = true;
                        WidthFirstValue = 500f;
                        setWorkforceListHeightFirstValue = true;
                        WorkforceListHeightFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.WorkforceList.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        if (interpolationValue < 1)
                        {
                            this.WorkforceList.Parent = this.GetGraphicalUiElementByName("ScrollContainer") ?? this;
                        }
                        if (interpolationValue < 1)
                        {
                            this.WorkforceList.Visible = false;
                        }
                        setWorkforceListWidthFirstValue = true;
                        WorkforceListWidthFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.WorkforceList.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        setWorkforceListXFirstValue = true;
                        WorkforceListXFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.WorkforceList.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.WorkforceList.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setWorkforceListYFirstValue = true;
                        WorkforceListYFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.WorkforceList.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.WorkforceList.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setWorkforceTabCurrentButtonCategoryStateFirstValue = true;
                        WorkforceTabCurrentButtonCategoryStateFirstValue = JHP4SD.GumRuntimes.LebegForms.BasicComponents.CityMenuTabRuntime.ButtonCategory.Enabled;
                        if (interpolationValue < 1)
                        {
                            SetProperty("WorkforceTab.MenuIcon", "../GlobalContent/Resources/CategoryIcons/modern-city.png");
                        }
                        if (interpolationValue < 1)
                        {
                            this.WorkforceTab.Parent = this.GetGraphicalUiElementByName("ContainerInstance") ?? this;
                        }
                        setWorkforceTabCurrentVariableStateFirstValue = true;
                        WorkforceTabCurrentVariableStateFirstValue = JHP4SD.GumRuntimes.LebegForms.BasicComponents.CityMenuTabRuntime.VariableState.Default;
                        if (interpolationValue < 1)
                        {
                            this.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                        }
                        if (interpolationValue < 1)
                        {
                            this.XUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                        }
                        setYFirstValue = true;
                        YFirstValue = 72f;
                        if (interpolationValue < 1)
                        {
                            this.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Top;
                        }
                        if (interpolationValue < 1)
                        {
                            this.YUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                        }
                        break;
                }
                switch(secondState)
                {
                    case  VariableState.Default:
                        setCommonListHeightSecondValue = true;
                        CommonListHeightSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.CommonList.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.CommonList.Parent = this.GetGraphicalUiElementByName("ScrollContainer") ?? this;
                        }
                        setCommonListWidthSecondValue = true;
                        CommonListWidthSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.CommonList.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        setCommonListXSecondValue = true;
                        CommonListXSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.CommonList.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.CommonList.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setCommonListYSecondValue = true;
                        CommonListYSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.CommonList.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.CommonList.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setCommonTabCurrentButtonCategoryStateSecondValue = true;
                        CommonTabCurrentButtonCategoryStateSecondValue = JHP4SD.GumRuntimes.LebegForms.BasicComponents.CityMenuTabRuntime.ButtonCategory.Disabled;
                        if (interpolationValue >= 1)
                        {
                            SetProperty("CommonTab.MenuIcon", "../GlobalContent/Resources/CategoryIcons/factory.png");
                        }
                        if (interpolationValue >= 1)
                        {
                            this.CommonTab.Parent = this.GetGraphicalUiElementByName("ContainerInstance") ?? this;
                        }
                        setConstructionListHeightSecondValue = true;
                        ConstructionListHeightSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.ConstructionList.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.ConstructionList.Parent = this.GetGraphicalUiElementByName("ScrollContainer") ?? this;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.ConstructionList.Visible = false;
                        }
                        setConstructionListWidthSecondValue = true;
                        ConstructionListWidthSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.ConstructionList.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        setConstructionListXSecondValue = true;
                        ConstructionListXSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.ConstructionList.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.ConstructionList.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setConstructionListYSecondValue = true;
                        ConstructionListYSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.ConstructionList.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.ConstructionList.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setConstructionTabCurrentButtonCategoryStateSecondValue = true;
                        ConstructionTabCurrentButtonCategoryStateSecondValue = JHP4SD.GumRuntimes.LebegForms.BasicComponents.CityMenuTabRuntime.ButtonCategory.Enabled;
                        if (interpolationValue >= 1)
                        {
                            SetProperty("ConstructionTab.MenuIcon", "../GlobalContent/Resources/CategoryIcons/crane.png");
                        }
                        if (interpolationValue >= 1)
                        {
                            this.ConstructionTab.Parent = this.GetGraphicalUiElementByName("ContainerInstance") ?? this;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.ContainerInstance.ChildrenLayout = Gum.Managers.ChildrenLayout.LeftToRightStack;
                        }
                        setContainerInstanceHeightSecondValue = true;
                        ContainerInstanceHeightSecondValue = 56f;
                        setContainerInstanceWidthSecondValue = true;
                        ContainerInstanceWidthSecondValue = -16f;
                        if (interpolationValue >= 1)
                        {
                            this.ContainerInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        setContainerInstanceXSecondValue = true;
                        ContainerInstanceXSecondValue = 8f;
                        setContainerInstanceYSecondValue = true;
                        ContainerInstanceYSecondValue = 8f;
                        setEnergyListHeightSecondValue = true;
                        EnergyListHeightSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.EnergyList.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.EnergyList.Parent = this.GetGraphicalUiElementByName("ScrollContainer") ?? this;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.EnergyList.Visible = false;
                        }
                        setEnergyListWidthSecondValue = true;
                        EnergyListWidthSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.EnergyList.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        setEnergyListXSecondValue = true;
                        EnergyListXSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.EnergyList.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.EnergyList.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setEnergyListYSecondValue = true;
                        EnergyListYSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.EnergyList.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.EnergyList.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setEnergyTabCurrentButtonCategoryStateSecondValue = true;
                        EnergyTabCurrentButtonCategoryStateSecondValue = JHP4SD.GumRuntimes.LebegForms.BasicComponents.CityMenuTabRuntime.ButtonCategory.Enabled;
                        if (interpolationValue >= 1)
                        {
                            SetProperty("EnergyTab.MenuIcon", "../GlobalContent/Resources/CategoryIcons/pylon.png");
                        }
                        if (interpolationValue >= 1)
                        {
                            this.EnergyTab.Parent = this.GetGraphicalUiElementByName("ContainerInstance") ?? this;
                        }
                        setHeaderPanelCurrentColorCategoryStateSecondValue = true;
                        HeaderPanelCurrentColorCategoryStateSecondValue = JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Black;
                        setHeaderPanelHeightSecondValue = true;
                        HeaderPanelHeightSecondValue = 72f;
                        setHeaderPanelWidthSecondValue = true;
                        HeaderPanelWidthSecondValue = 100f;
                        if (interpolationValue >= 1)
                        {
                            this.HeaderPanel.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setHeightSecondValue = true;
                        HeightSecondValue = -144f;
                        if (interpolationValue >= 1)
                        {
                            this.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        setOilListHeightSecondValue = true;
                        OilListHeightSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.OilList.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.OilList.Parent = this.GetGraphicalUiElementByName("ScrollContainer") ?? this;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.OilList.Visible = false;
                        }
                        setOilListWidthSecondValue = true;
                        OilListWidthSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.OilList.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        setOilListXSecondValue = true;
                        OilListXSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.OilList.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.OilList.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setOilListYSecondValue = true;
                        OilListYSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.OilList.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.OilList.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setOilTabCurrentButtonCategoryStateSecondValue = true;
                        OilTabCurrentButtonCategoryStateSecondValue = JHP4SD.GumRuntimes.LebegForms.BasicComponents.CityMenuTabRuntime.ButtonCategory.Enabled;
                        if (interpolationValue >= 1)
                        {
                            SetProperty("OilTab.MenuIcon", "../GlobalContent/Resources/CategoryIcons/oil-pump.png");
                        }
                        if (interpolationValue >= 1)
                        {
                            this.OilTab.Parent = this.GetGraphicalUiElementByName("ContainerInstance") ?? this;
                        }
                        setScrollContainerHeightSecondValue = true;
                        ScrollContainerHeightSecondValue = -72f;
                        if (interpolationValue >= 1)
                        {
                            this.ScrollContainer.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        setScrollContainerWidthSecondValue = true;
                        ScrollContainerWidthSecondValue = 100f;
                        if (interpolationValue >= 1)
                        {
                            this.ScrollContainer.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setScrollContainerYSecondValue = true;
                        ScrollContainerYSecondValue = 72f;
                        setWidthSecondValue = true;
                        WidthSecondValue = 500f;
                        setWorkforceListHeightSecondValue = true;
                        WorkforceListHeightSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.WorkforceList.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.WorkforceList.Parent = this.GetGraphicalUiElementByName("ScrollContainer") ?? this;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.WorkforceList.Visible = false;
                        }
                        setWorkforceListWidthSecondValue = true;
                        WorkforceListWidthSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.WorkforceList.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        setWorkforceListXSecondValue = true;
                        WorkforceListXSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.WorkforceList.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.WorkforceList.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setWorkforceListYSecondValue = true;
                        WorkforceListYSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.WorkforceList.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.WorkforceList.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setWorkforceTabCurrentButtonCategoryStateSecondValue = true;
                        WorkforceTabCurrentButtonCategoryStateSecondValue = JHP4SD.GumRuntimes.LebegForms.BasicComponents.CityMenuTabRuntime.ButtonCategory.Enabled;
                        if (interpolationValue >= 1)
                        {
                            SetProperty("WorkforceTab.MenuIcon", "../GlobalContent/Resources/CategoryIcons/modern-city.png");
                        }
                        if (interpolationValue >= 1)
                        {
                            this.WorkforceTab.Parent = this.GetGraphicalUiElementByName("ContainerInstance") ?? this;
                        }
                        setWorkforceTabCurrentVariableStateSecondValue = true;
                        WorkforceTabCurrentVariableStateSecondValue = JHP4SD.GumRuntimes.LebegForms.BasicComponents.CityMenuTabRuntime.VariableState.Default;
                        if (interpolationValue >= 1)
                        {
                            this.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.XUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                        }
                        setYSecondValue = true;
                        YSecondValue = 72f;
                        if (interpolationValue >= 1)
                        {
                            this.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Top;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.YUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                        }
                        break;
                }
                var wasSuppressed = mIsLayoutSuspended;
                if (wasSuppressed == false)
                {
                    SuspendLayout(true);
                }
                if (setCommonListHeightFirstValue && setCommonListHeightSecondValue)
                {
                    CommonList.Height = CommonListHeightFirstValue * (1 - interpolationValue) + CommonListHeightSecondValue * interpolationValue;
                }
                if (setCommonListWidthFirstValue && setCommonListWidthSecondValue)
                {
                    CommonList.Width = CommonListWidthFirstValue * (1 - interpolationValue) + CommonListWidthSecondValue * interpolationValue;
                }
                if (setCommonListXFirstValue && setCommonListXSecondValue)
                {
                    CommonList.X = CommonListXFirstValue * (1 - interpolationValue) + CommonListXSecondValue * interpolationValue;
                }
                if (setCommonListYFirstValue && setCommonListYSecondValue)
                {
                    CommonList.Y = CommonListYFirstValue * (1 - interpolationValue) + CommonListYSecondValue * interpolationValue;
                }
                if (setCommonTabCurrentButtonCategoryStateFirstValue && setCommonTabCurrentButtonCategoryStateSecondValue)
                {
                    CommonTab.InterpolateBetween(CommonTabCurrentButtonCategoryStateFirstValue, CommonTabCurrentButtonCategoryStateSecondValue, interpolationValue);
                }
                if (setConstructionListHeightFirstValue && setConstructionListHeightSecondValue)
                {
                    ConstructionList.Height = ConstructionListHeightFirstValue * (1 - interpolationValue) + ConstructionListHeightSecondValue * interpolationValue;
                }
                if (setConstructionListWidthFirstValue && setConstructionListWidthSecondValue)
                {
                    ConstructionList.Width = ConstructionListWidthFirstValue * (1 - interpolationValue) + ConstructionListWidthSecondValue * interpolationValue;
                }
                if (setConstructionListXFirstValue && setConstructionListXSecondValue)
                {
                    ConstructionList.X = ConstructionListXFirstValue * (1 - interpolationValue) + ConstructionListXSecondValue * interpolationValue;
                }
                if (setConstructionListYFirstValue && setConstructionListYSecondValue)
                {
                    ConstructionList.Y = ConstructionListYFirstValue * (1 - interpolationValue) + ConstructionListYSecondValue * interpolationValue;
                }
                if (setConstructionTabCurrentButtonCategoryStateFirstValue && setConstructionTabCurrentButtonCategoryStateSecondValue)
                {
                    ConstructionTab.InterpolateBetween(ConstructionTabCurrentButtonCategoryStateFirstValue, ConstructionTabCurrentButtonCategoryStateSecondValue, interpolationValue);
                }
                if (setContainerInstanceHeightFirstValue && setContainerInstanceHeightSecondValue)
                {
                    ContainerInstance.Height = ContainerInstanceHeightFirstValue * (1 - interpolationValue) + ContainerInstanceHeightSecondValue * interpolationValue;
                }
                if (setContainerInstanceWidthFirstValue && setContainerInstanceWidthSecondValue)
                {
                    ContainerInstance.Width = ContainerInstanceWidthFirstValue * (1 - interpolationValue) + ContainerInstanceWidthSecondValue * interpolationValue;
                }
                if (setContainerInstanceXFirstValue && setContainerInstanceXSecondValue)
                {
                    ContainerInstance.X = ContainerInstanceXFirstValue * (1 - interpolationValue) + ContainerInstanceXSecondValue * interpolationValue;
                }
                if (setContainerInstanceYFirstValue && setContainerInstanceYSecondValue)
                {
                    ContainerInstance.Y = ContainerInstanceYFirstValue * (1 - interpolationValue) + ContainerInstanceYSecondValue * interpolationValue;
                }
                if (setEnergyListHeightFirstValue && setEnergyListHeightSecondValue)
                {
                    EnergyList.Height = EnergyListHeightFirstValue * (1 - interpolationValue) + EnergyListHeightSecondValue * interpolationValue;
                }
                if (setEnergyListWidthFirstValue && setEnergyListWidthSecondValue)
                {
                    EnergyList.Width = EnergyListWidthFirstValue * (1 - interpolationValue) + EnergyListWidthSecondValue * interpolationValue;
                }
                if (setEnergyListXFirstValue && setEnergyListXSecondValue)
                {
                    EnergyList.X = EnergyListXFirstValue * (1 - interpolationValue) + EnergyListXSecondValue * interpolationValue;
                }
                if (setEnergyListYFirstValue && setEnergyListYSecondValue)
                {
                    EnergyList.Y = EnergyListYFirstValue * (1 - interpolationValue) + EnergyListYSecondValue * interpolationValue;
                }
                if (setEnergyTabCurrentButtonCategoryStateFirstValue && setEnergyTabCurrentButtonCategoryStateSecondValue)
                {
                    EnergyTab.InterpolateBetween(EnergyTabCurrentButtonCategoryStateFirstValue, EnergyTabCurrentButtonCategoryStateSecondValue, interpolationValue);
                }
                if (setHeaderPanelCurrentColorCategoryStateFirstValue && setHeaderPanelCurrentColorCategoryStateSecondValue)
                {
                    HeaderPanel.InterpolateBetween(HeaderPanelCurrentColorCategoryStateFirstValue, HeaderPanelCurrentColorCategoryStateSecondValue, interpolationValue);
                }
                if (setHeaderPanelHeightFirstValue && setHeaderPanelHeightSecondValue)
                {
                    HeaderPanel.Height = HeaderPanelHeightFirstValue * (1 - interpolationValue) + HeaderPanelHeightSecondValue * interpolationValue;
                }
                if (setHeaderPanelWidthFirstValue && setHeaderPanelWidthSecondValue)
                {
                    HeaderPanel.Width = HeaderPanelWidthFirstValue * (1 - interpolationValue) + HeaderPanelWidthSecondValue * interpolationValue;
                }
                if (setHeightFirstValue && setHeightSecondValue)
                {
                    Height = HeightFirstValue * (1 - interpolationValue) + HeightSecondValue * interpolationValue;
                }
                if (setOilListHeightFirstValue && setOilListHeightSecondValue)
                {
                    OilList.Height = OilListHeightFirstValue * (1 - interpolationValue) + OilListHeightSecondValue * interpolationValue;
                }
                if (setOilListWidthFirstValue && setOilListWidthSecondValue)
                {
                    OilList.Width = OilListWidthFirstValue * (1 - interpolationValue) + OilListWidthSecondValue * interpolationValue;
                }
                if (setOilListXFirstValue && setOilListXSecondValue)
                {
                    OilList.X = OilListXFirstValue * (1 - interpolationValue) + OilListXSecondValue * interpolationValue;
                }
                if (setOilListYFirstValue && setOilListYSecondValue)
                {
                    OilList.Y = OilListYFirstValue * (1 - interpolationValue) + OilListYSecondValue * interpolationValue;
                }
                if (setOilTabCurrentButtonCategoryStateFirstValue && setOilTabCurrentButtonCategoryStateSecondValue)
                {
                    OilTab.InterpolateBetween(OilTabCurrentButtonCategoryStateFirstValue, OilTabCurrentButtonCategoryStateSecondValue, interpolationValue);
                }
                if (setScrollContainerHeightFirstValue && setScrollContainerHeightSecondValue)
                {
                    ScrollContainer.Height = ScrollContainerHeightFirstValue * (1 - interpolationValue) + ScrollContainerHeightSecondValue * interpolationValue;
                }
                if (setScrollContainerWidthFirstValue && setScrollContainerWidthSecondValue)
                {
                    ScrollContainer.Width = ScrollContainerWidthFirstValue * (1 - interpolationValue) + ScrollContainerWidthSecondValue * interpolationValue;
                }
                if (setScrollContainerYFirstValue && setScrollContainerYSecondValue)
                {
                    ScrollContainer.Y = ScrollContainerYFirstValue * (1 - interpolationValue) + ScrollContainerYSecondValue * interpolationValue;
                }
                if (setWidthFirstValue && setWidthSecondValue)
                {
                    Width = WidthFirstValue * (1 - interpolationValue) + WidthSecondValue * interpolationValue;
                }
                if (setWorkforceListHeightFirstValue && setWorkforceListHeightSecondValue)
                {
                    WorkforceList.Height = WorkforceListHeightFirstValue * (1 - interpolationValue) + WorkforceListHeightSecondValue * interpolationValue;
                }
                if (setWorkforceListWidthFirstValue && setWorkforceListWidthSecondValue)
                {
                    WorkforceList.Width = WorkforceListWidthFirstValue * (1 - interpolationValue) + WorkforceListWidthSecondValue * interpolationValue;
                }
                if (setWorkforceListXFirstValue && setWorkforceListXSecondValue)
                {
                    WorkforceList.X = WorkforceListXFirstValue * (1 - interpolationValue) + WorkforceListXSecondValue * interpolationValue;
                }
                if (setWorkforceListYFirstValue && setWorkforceListYSecondValue)
                {
                    WorkforceList.Y = WorkforceListYFirstValue * (1 - interpolationValue) + WorkforceListYSecondValue * interpolationValue;
                }
                if (setWorkforceTabCurrentButtonCategoryStateFirstValue && setWorkforceTabCurrentButtonCategoryStateSecondValue)
                {
                    WorkforceTab.InterpolateBetween(WorkforceTabCurrentButtonCategoryStateFirstValue, WorkforceTabCurrentButtonCategoryStateSecondValue, interpolationValue);
                }
                if (setWorkforceTabCurrentVariableStateFirstValue && setWorkforceTabCurrentVariableStateSecondValue)
                {
                    WorkforceTab.InterpolateBetween(WorkforceTabCurrentVariableStateFirstValue, WorkforceTabCurrentVariableStateSecondValue, interpolationValue);
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
            #endregion
            #region State Interpolate To
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (JHP4SD.GumRuntimes.LebegForms.ComplexComponents.TabMenuRuntime.VariableState fromState,JHP4SD.GumRuntimes.LebegForms.ComplexComponents.TabMenuRuntime.VariableState toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null) 
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
                HeaderPanel.StopAnimations();
                CommonList.StopAnimations();
                ConstructionList.StopAnimations();
                CommonTab.StopAnimations();
                ConstructionTab.StopAnimations();
                EnergyTab.StopAnimations();
                OilTab.StopAnimations();
                WorkforceTab.StopAnimations();
                EnergyList.StopAnimations();
                OilList.StopAnimations();
                WorkforceList.StopAnimations();
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
                            Name = "X Origin",
                            Type = "HorizontalAlignment",
                            Value = XOrigin
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
                            Name = "HeaderPanel.ColorCategoryState",
                            Type = "ColorCategoryState",
                            Value = HeaderPanel.CurrentColorCategoryState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HeaderPanel.Height",
                            Type = "float",
                            Value = HeaderPanel.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HeaderPanel.Width",
                            Type = "float",
                            Value = HeaderPanel.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HeaderPanel.Width Units",
                            Type = "DimensionUnitType",
                            Value = HeaderPanel.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CommonList.Height",
                            Type = "float",
                            Value = CommonList.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CommonList.Height Units",
                            Type = "DimensionUnitType",
                            Value = CommonList.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CommonList.Parent",
                            Type = "string",
                            Value = CommonList.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CommonList.Width",
                            Type = "float",
                            Value = CommonList.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CommonList.Width Units",
                            Type = "DimensionUnitType",
                            Value = CommonList.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CommonList.X",
                            Type = "float",
                            Value = CommonList.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CommonList.X Origin",
                            Type = "HorizontalAlignment",
                            Value = CommonList.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CommonList.X Units",
                            Type = "PositionUnitType",
                            Value = CommonList.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CommonList.Y",
                            Type = "float",
                            Value = CommonList.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CommonList.Y Origin",
                            Type = "VerticalAlignment",
                            Value = CommonList.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CommonList.Y Units",
                            Type = "PositionUnitType",
                            Value = CommonList.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ConstructionList.Height",
                            Type = "float",
                            Value = ConstructionList.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ConstructionList.Height Units",
                            Type = "DimensionUnitType",
                            Value = ConstructionList.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ConstructionList.Parent",
                            Type = "string",
                            Value = ConstructionList.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ConstructionList.Visible",
                            Type = "bool",
                            Value = ConstructionList.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ConstructionList.Width",
                            Type = "float",
                            Value = ConstructionList.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ConstructionList.Width Units",
                            Type = "DimensionUnitType",
                            Value = ConstructionList.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ConstructionList.X",
                            Type = "float",
                            Value = ConstructionList.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ConstructionList.X Origin",
                            Type = "HorizontalAlignment",
                            Value = ConstructionList.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ConstructionList.X Units",
                            Type = "PositionUnitType",
                            Value = ConstructionList.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ConstructionList.Y",
                            Type = "float",
                            Value = ConstructionList.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ConstructionList.Y Origin",
                            Type = "VerticalAlignment",
                            Value = ConstructionList.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ConstructionList.Y Units",
                            Type = "PositionUnitType",
                            Value = ConstructionList.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ContainerInstance.Children Layout",
                            Type = "ChildrenLayout",
                            Value = ContainerInstance.ChildrenLayout
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ContainerInstance.Height",
                            Type = "float",
                            Value = ContainerInstance.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ContainerInstance.Width",
                            Type = "float",
                            Value = ContainerInstance.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ContainerInstance.Width Units",
                            Type = "DimensionUnitType",
                            Value = ContainerInstance.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ContainerInstance.X",
                            Type = "float",
                            Value = ContainerInstance.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ContainerInstance.Y",
                            Type = "float",
                            Value = ContainerInstance.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CommonTab.ButtonCategoryState",
                            Type = "ButtonCategory",
                            Value = CommonTab.CurrentButtonCategoryState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CommonTab.MenuIcon",
                            Type = "string",
                            Value = CommonTab.MenuIcon
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CommonTab.Parent",
                            Type = "string",
                            Value = CommonTab.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ConstructionTab.ButtonCategoryState",
                            Type = "ButtonCategory",
                            Value = ConstructionTab.CurrentButtonCategoryState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ConstructionTab.MenuIcon",
                            Type = "string",
                            Value = ConstructionTab.MenuIcon
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ConstructionTab.Parent",
                            Type = "string",
                            Value = ConstructionTab.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "EnergyTab.ButtonCategoryState",
                            Type = "ButtonCategory",
                            Value = EnergyTab.CurrentButtonCategoryState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "EnergyTab.MenuIcon",
                            Type = "string",
                            Value = EnergyTab.MenuIcon
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "EnergyTab.Parent",
                            Type = "string",
                            Value = EnergyTab.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "OilTab.ButtonCategoryState",
                            Type = "ButtonCategory",
                            Value = OilTab.CurrentButtonCategoryState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "OilTab.MenuIcon",
                            Type = "string",
                            Value = OilTab.MenuIcon
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "OilTab.Parent",
                            Type = "string",
                            Value = OilTab.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WorkforceTab.ButtonCategoryState",
                            Type = "ButtonCategory",
                            Value = WorkforceTab.CurrentButtonCategoryState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WorkforceTab.MenuIcon",
                            Type = "string",
                            Value = WorkforceTab.MenuIcon
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WorkforceTab.Parent",
                            Type = "string",
                            Value = WorkforceTab.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WorkforceTab.State",
                            Type = "State",
                            Value = WorkforceTab.CurrentVariableState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ScrollContainer.Height",
                            Type = "float",
                            Value = ScrollContainer.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ScrollContainer.Height Units",
                            Type = "DimensionUnitType",
                            Value = ScrollContainer.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ScrollContainer.Width",
                            Type = "float",
                            Value = ScrollContainer.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ScrollContainer.Width Units",
                            Type = "DimensionUnitType",
                            Value = ScrollContainer.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ScrollContainer.Y",
                            Type = "float",
                            Value = ScrollContainer.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "EnergyList.Height",
                            Type = "float",
                            Value = EnergyList.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "EnergyList.Height Units",
                            Type = "DimensionUnitType",
                            Value = EnergyList.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "EnergyList.Parent",
                            Type = "string",
                            Value = EnergyList.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "EnergyList.Visible",
                            Type = "bool",
                            Value = EnergyList.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "EnergyList.Width",
                            Type = "float",
                            Value = EnergyList.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "EnergyList.Width Units",
                            Type = "DimensionUnitType",
                            Value = EnergyList.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "EnergyList.X",
                            Type = "float",
                            Value = EnergyList.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "EnergyList.X Origin",
                            Type = "HorizontalAlignment",
                            Value = EnergyList.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "EnergyList.X Units",
                            Type = "PositionUnitType",
                            Value = EnergyList.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "EnergyList.Y",
                            Type = "float",
                            Value = EnergyList.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "EnergyList.Y Origin",
                            Type = "VerticalAlignment",
                            Value = EnergyList.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "EnergyList.Y Units",
                            Type = "PositionUnitType",
                            Value = EnergyList.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "OilList.Height",
                            Type = "float",
                            Value = OilList.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "OilList.Height Units",
                            Type = "DimensionUnitType",
                            Value = OilList.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "OilList.Parent",
                            Type = "string",
                            Value = OilList.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "OilList.Visible",
                            Type = "bool",
                            Value = OilList.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "OilList.Width",
                            Type = "float",
                            Value = OilList.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "OilList.Width Units",
                            Type = "DimensionUnitType",
                            Value = OilList.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "OilList.X",
                            Type = "float",
                            Value = OilList.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "OilList.X Origin",
                            Type = "HorizontalAlignment",
                            Value = OilList.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "OilList.X Units",
                            Type = "PositionUnitType",
                            Value = OilList.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "OilList.Y",
                            Type = "float",
                            Value = OilList.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "OilList.Y Origin",
                            Type = "VerticalAlignment",
                            Value = OilList.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "OilList.Y Units",
                            Type = "PositionUnitType",
                            Value = OilList.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WorkforceList.Height",
                            Type = "float",
                            Value = WorkforceList.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WorkforceList.Height Units",
                            Type = "DimensionUnitType",
                            Value = WorkforceList.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WorkforceList.Parent",
                            Type = "string",
                            Value = WorkforceList.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WorkforceList.Visible",
                            Type = "bool",
                            Value = WorkforceList.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WorkforceList.Width",
                            Type = "float",
                            Value = WorkforceList.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WorkforceList.Width Units",
                            Type = "DimensionUnitType",
                            Value = WorkforceList.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WorkforceList.X",
                            Type = "float",
                            Value = WorkforceList.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WorkforceList.X Origin",
                            Type = "HorizontalAlignment",
                            Value = WorkforceList.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WorkforceList.X Units",
                            Type = "PositionUnitType",
                            Value = WorkforceList.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WorkforceList.Y",
                            Type = "float",
                            Value = WorkforceList.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WorkforceList.Y Origin",
                            Type = "VerticalAlignment",
                            Value = WorkforceList.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WorkforceList.Y Units",
                            Type = "PositionUnitType",
                            Value = WorkforceList.YUnits
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
                            Value = Height + -144f
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
                            Value = Width + 500f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "X Origin",
                            Type = "HorizontalAlignment",
                            Value = XOrigin
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
                            Value = Y + 72f
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
                            Name = "HeaderPanel.ColorCategoryState",
                            Type = "ColorCategoryState",
                            Value = HeaderPanel.CurrentColorCategoryState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HeaderPanel.Height",
                            Type = "float",
                            Value = HeaderPanel.Height + 72f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HeaderPanel.Width",
                            Type = "float",
                            Value = HeaderPanel.Width + 100f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HeaderPanel.Width Units",
                            Type = "DimensionUnitType",
                            Value = HeaderPanel.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CommonList.Height",
                            Type = "float",
                            Value = CommonList.Height + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CommonList.Height Units",
                            Type = "DimensionUnitType",
                            Value = CommonList.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CommonList.Parent",
                            Type = "string",
                            Value = CommonList.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CommonList.Width",
                            Type = "float",
                            Value = CommonList.Width + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CommonList.Width Units",
                            Type = "DimensionUnitType",
                            Value = CommonList.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CommonList.X",
                            Type = "float",
                            Value = CommonList.X + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CommonList.X Origin",
                            Type = "HorizontalAlignment",
                            Value = CommonList.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CommonList.X Units",
                            Type = "PositionUnitType",
                            Value = CommonList.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CommonList.Y",
                            Type = "float",
                            Value = CommonList.Y + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CommonList.Y Origin",
                            Type = "VerticalAlignment",
                            Value = CommonList.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CommonList.Y Units",
                            Type = "PositionUnitType",
                            Value = CommonList.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ConstructionList.Height",
                            Type = "float",
                            Value = ConstructionList.Height + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ConstructionList.Height Units",
                            Type = "DimensionUnitType",
                            Value = ConstructionList.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ConstructionList.Parent",
                            Type = "string",
                            Value = ConstructionList.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ConstructionList.Visible",
                            Type = "bool",
                            Value = ConstructionList.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ConstructionList.Width",
                            Type = "float",
                            Value = ConstructionList.Width + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ConstructionList.Width Units",
                            Type = "DimensionUnitType",
                            Value = ConstructionList.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ConstructionList.X",
                            Type = "float",
                            Value = ConstructionList.X + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ConstructionList.X Origin",
                            Type = "HorizontalAlignment",
                            Value = ConstructionList.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ConstructionList.X Units",
                            Type = "PositionUnitType",
                            Value = ConstructionList.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ConstructionList.Y",
                            Type = "float",
                            Value = ConstructionList.Y + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ConstructionList.Y Origin",
                            Type = "VerticalAlignment",
                            Value = ConstructionList.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ConstructionList.Y Units",
                            Type = "PositionUnitType",
                            Value = ConstructionList.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ContainerInstance.Children Layout",
                            Type = "ChildrenLayout",
                            Value = ContainerInstance.ChildrenLayout
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ContainerInstance.Height",
                            Type = "float",
                            Value = ContainerInstance.Height + 56f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ContainerInstance.Width",
                            Type = "float",
                            Value = ContainerInstance.Width + -16f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ContainerInstance.Width Units",
                            Type = "DimensionUnitType",
                            Value = ContainerInstance.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ContainerInstance.X",
                            Type = "float",
                            Value = ContainerInstance.X + 8f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ContainerInstance.Y",
                            Type = "float",
                            Value = ContainerInstance.Y + 8f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CommonTab.ButtonCategoryState",
                            Type = "ButtonCategory",
                            Value = CommonTab.CurrentButtonCategoryState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CommonTab.MenuIcon",
                            Type = "string",
                            Value = CommonTab.MenuIcon
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CommonTab.Parent",
                            Type = "string",
                            Value = CommonTab.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ConstructionTab.ButtonCategoryState",
                            Type = "ButtonCategory",
                            Value = ConstructionTab.CurrentButtonCategoryState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ConstructionTab.MenuIcon",
                            Type = "string",
                            Value = ConstructionTab.MenuIcon
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ConstructionTab.Parent",
                            Type = "string",
                            Value = ConstructionTab.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "EnergyTab.ButtonCategoryState",
                            Type = "ButtonCategory",
                            Value = EnergyTab.CurrentButtonCategoryState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "EnergyTab.MenuIcon",
                            Type = "string",
                            Value = EnergyTab.MenuIcon
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "EnergyTab.Parent",
                            Type = "string",
                            Value = EnergyTab.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "OilTab.ButtonCategoryState",
                            Type = "ButtonCategory",
                            Value = OilTab.CurrentButtonCategoryState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "OilTab.MenuIcon",
                            Type = "string",
                            Value = OilTab.MenuIcon
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "OilTab.Parent",
                            Type = "string",
                            Value = OilTab.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WorkforceTab.ButtonCategoryState",
                            Type = "ButtonCategory",
                            Value = WorkforceTab.CurrentButtonCategoryState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WorkforceTab.MenuIcon",
                            Type = "string",
                            Value = WorkforceTab.MenuIcon
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WorkforceTab.Parent",
                            Type = "string",
                            Value = WorkforceTab.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WorkforceTab.State",
                            Type = "State",
                            Value = WorkforceTab.CurrentVariableState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ScrollContainer.Height",
                            Type = "float",
                            Value = ScrollContainer.Height + -72f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ScrollContainer.Height Units",
                            Type = "DimensionUnitType",
                            Value = ScrollContainer.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ScrollContainer.Width",
                            Type = "float",
                            Value = ScrollContainer.Width + 100f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ScrollContainer.Width Units",
                            Type = "DimensionUnitType",
                            Value = ScrollContainer.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ScrollContainer.Y",
                            Type = "float",
                            Value = ScrollContainer.Y + 72f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "EnergyList.Height",
                            Type = "float",
                            Value = EnergyList.Height + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "EnergyList.Height Units",
                            Type = "DimensionUnitType",
                            Value = EnergyList.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "EnergyList.Parent",
                            Type = "string",
                            Value = EnergyList.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "EnergyList.Visible",
                            Type = "bool",
                            Value = EnergyList.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "EnergyList.Width",
                            Type = "float",
                            Value = EnergyList.Width + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "EnergyList.Width Units",
                            Type = "DimensionUnitType",
                            Value = EnergyList.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "EnergyList.X",
                            Type = "float",
                            Value = EnergyList.X + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "EnergyList.X Origin",
                            Type = "HorizontalAlignment",
                            Value = EnergyList.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "EnergyList.X Units",
                            Type = "PositionUnitType",
                            Value = EnergyList.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "EnergyList.Y",
                            Type = "float",
                            Value = EnergyList.Y + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "EnergyList.Y Origin",
                            Type = "VerticalAlignment",
                            Value = EnergyList.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "EnergyList.Y Units",
                            Type = "PositionUnitType",
                            Value = EnergyList.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "OilList.Height",
                            Type = "float",
                            Value = OilList.Height + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "OilList.Height Units",
                            Type = "DimensionUnitType",
                            Value = OilList.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "OilList.Parent",
                            Type = "string",
                            Value = OilList.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "OilList.Visible",
                            Type = "bool",
                            Value = OilList.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "OilList.Width",
                            Type = "float",
                            Value = OilList.Width + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "OilList.Width Units",
                            Type = "DimensionUnitType",
                            Value = OilList.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "OilList.X",
                            Type = "float",
                            Value = OilList.X + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "OilList.X Origin",
                            Type = "HorizontalAlignment",
                            Value = OilList.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "OilList.X Units",
                            Type = "PositionUnitType",
                            Value = OilList.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "OilList.Y",
                            Type = "float",
                            Value = OilList.Y + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "OilList.Y Origin",
                            Type = "VerticalAlignment",
                            Value = OilList.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "OilList.Y Units",
                            Type = "PositionUnitType",
                            Value = OilList.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WorkforceList.Height",
                            Type = "float",
                            Value = WorkforceList.Height + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WorkforceList.Height Units",
                            Type = "DimensionUnitType",
                            Value = WorkforceList.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WorkforceList.Parent",
                            Type = "string",
                            Value = WorkforceList.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WorkforceList.Visible",
                            Type = "bool",
                            Value = WorkforceList.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WorkforceList.Width",
                            Type = "float",
                            Value = WorkforceList.Width + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WorkforceList.Width Units",
                            Type = "DimensionUnitType",
                            Value = WorkforceList.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WorkforceList.X",
                            Type = "float",
                            Value = WorkforceList.X + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WorkforceList.X Origin",
                            Type = "HorizontalAlignment",
                            Value = WorkforceList.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WorkforceList.X Units",
                            Type = "PositionUnitType",
                            Value = WorkforceList.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WorkforceList.Y",
                            Type = "float",
                            Value = WorkforceList.Y + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WorkforceList.Y Origin",
                            Type = "VerticalAlignment",
                            Value = WorkforceList.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WorkforceList.Y Units",
                            Type = "PositionUnitType",
                            Value = WorkforceList.YUnits
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
            public JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime HeaderPanel { get; set; }
            public JHP4SD.GumRuntimes.DefaultForms.ListBoxRuntime CommonList { get; set; }
            public JHP4SD.GumRuntimes.DefaultForms.ListBoxRuntime ConstructionList { get; set; }
            public JHP4SD.GumRuntimes.ContainerRuntime ContainerInstance { get; set; }
            public JHP4SD.GumRuntimes.LebegForms.BasicComponents.CityMenuTabRuntime CommonTab { get; set; }
            public JHP4SD.GumRuntimes.LebegForms.BasicComponents.CityMenuTabRuntime ConstructionTab { get; set; }
            public JHP4SD.GumRuntimes.LebegForms.BasicComponents.CityMenuTabRuntime EnergyTab { get; set; }
            public JHP4SD.GumRuntimes.LebegForms.BasicComponents.CityMenuTabRuntime OilTab { get; set; }
            public JHP4SD.GumRuntimes.LebegForms.BasicComponents.CityMenuTabRuntime WorkforceTab { get; set; }
            public JHP4SD.GumRuntimes.ContainerRuntime ScrollContainer { get; set; }
            public JHP4SD.GumRuntimes.DefaultForms.ListBoxRuntime EnergyList { get; set; }
            public JHP4SD.GumRuntimes.DefaultForms.ListBoxRuntime OilList { get; set; }
            public JHP4SD.GumRuntimes.DefaultForms.ListBoxRuntime WorkforceList { get; set; }
            public event FlatRedBall.Gui.WindowEvent CommonListClick;
            public event FlatRedBall.Gui.WindowEvent ConstructionListClick;
            public event FlatRedBall.Gui.WindowEvent CommonTabClick;
            public event FlatRedBall.Gui.WindowEvent ConstructionTabClick;
            public event FlatRedBall.Gui.WindowEvent EnergyTabClick;
            public event FlatRedBall.Gui.WindowEvent OilTabClick;
            public event FlatRedBall.Gui.WindowEvent WorkforceTabClick;
            public event FlatRedBall.Gui.WindowEvent EnergyListClick;
            public event FlatRedBall.Gui.WindowEvent OilListClick;
            public event FlatRedBall.Gui.WindowEvent WorkforceListClick;
            public TabMenuRuntime (bool fullInstantiation = true, bool tryCreateFormsObject = true) 
            	: base(false, tryCreateFormsObject)
            {
                this.tryCreateFormsObject = tryCreateFormsObject;
                if (fullInstantiation)
                {
                    Gum.DataTypes.ElementSave elementSave = Gum.Managers.ObjectFinder.Self.GumProjectSave.Components.First(item => item.Name == "LebegForms/ComplexComponents/TabMenu");
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
                HeaderPanel = this.GetGraphicalUiElementByName("HeaderPanel") as JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime;
                CommonList = this.GetGraphicalUiElementByName("CommonList") as JHP4SD.GumRuntimes.DefaultForms.ListBoxRuntime;
                ConstructionList = this.GetGraphicalUiElementByName("ConstructionList") as JHP4SD.GumRuntimes.DefaultForms.ListBoxRuntime;
                ContainerInstance = this.GetGraphicalUiElementByName("ContainerInstance") as JHP4SD.GumRuntimes.ContainerRuntime;
                CommonTab = this.GetGraphicalUiElementByName("CommonTab") as JHP4SD.GumRuntimes.LebegForms.BasicComponents.CityMenuTabRuntime;
                ConstructionTab = this.GetGraphicalUiElementByName("ConstructionTab") as JHP4SD.GumRuntimes.LebegForms.BasicComponents.CityMenuTabRuntime;
                EnergyTab = this.GetGraphicalUiElementByName("EnergyTab") as JHP4SD.GumRuntimes.LebegForms.BasicComponents.CityMenuTabRuntime;
                OilTab = this.GetGraphicalUiElementByName("OilTab") as JHP4SD.GumRuntimes.LebegForms.BasicComponents.CityMenuTabRuntime;
                WorkforceTab = this.GetGraphicalUiElementByName("WorkforceTab") as JHP4SD.GumRuntimes.LebegForms.BasicComponents.CityMenuTabRuntime;
                ScrollContainer = this.GetGraphicalUiElementByName("ScrollContainer") as JHP4SD.GumRuntimes.ContainerRuntime;
                EnergyList = this.GetGraphicalUiElementByName("EnergyList") as JHP4SD.GumRuntimes.DefaultForms.ListBoxRuntime;
                OilList = this.GetGraphicalUiElementByName("OilList") as JHP4SD.GumRuntimes.DefaultForms.ListBoxRuntime;
                WorkforceList = this.GetGraphicalUiElementByName("WorkforceList") as JHP4SD.GumRuntimes.DefaultForms.ListBoxRuntime;
                CommonList.Click += (unused) => CommonListClick?.Invoke(this);
                ConstructionList.Click += (unused) => ConstructionListClick?.Invoke(this);
                CommonTab.Click += (unused) => CommonTabClick?.Invoke(this);
                ConstructionTab.Click += (unused) => ConstructionTabClick?.Invoke(this);
                EnergyTab.Click += (unused) => EnergyTabClick?.Invoke(this);
                OilTab.Click += (unused) => OilTabClick?.Invoke(this);
                WorkforceTab.Click += (unused) => WorkforceTabClick?.Invoke(this);
                EnergyList.Click += (unused) => EnergyListClick?.Invoke(this);
                OilList.Click += (unused) => OilListClick?.Invoke(this);
                WorkforceList.Click += (unused) => WorkforceListClick?.Invoke(this);
                if (tryCreateFormsObject)
                {
                    FormsControlAsObject = new JHP4SD.FormsControls.Components.LebegForms.ComplexComponents.TabMenuForms(this);
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
            public JHP4SD.FormsControls.Components.LebegForms.ComplexComponents.TabMenuForms FormsControl {get => (JHP4SD.FormsControls.Components.LebegForms.ComplexComponents.TabMenuForms) FormsControlAsObject;}
        }
    }
