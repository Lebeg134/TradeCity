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
                            CommonTab.Parent = this.GetGraphicalUiElementByName("ContainerInstance") ?? this;
                            ConstructionTab.Parent = this.GetGraphicalUiElementByName("ContainerInstance") ?? this;
                            EnergyTab.Parent = this.GetGraphicalUiElementByName("ContainerInstance") ?? this;
                            OilTab.Parent = this.GetGraphicalUiElementByName("ContainerInstance") ?? this;
                            WorkforceTab.Parent = this.GetGraphicalUiElementByName("ContainerInstance") ?? this;
                            HeaderPanel.CurrentColorCategoryState = JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Black;
                            ConstructionTab.CurrentButtonCategoryState = JHP4SD.GumRuntimes.LebegForms.BasicComponents.CityMenuTabRuntime.ButtonCategory.Disabled;
                            OilTab.CurrentButtonCategoryState = JHP4SD.GumRuntimes.LebegForms.BasicComponents.CityMenuTabRuntime.ButtonCategory.Disabled;
                            WorkforceTab.CurrentButtonCategoryState = JHP4SD.GumRuntimes.LebegForms.BasicComponents.CityMenuTabRuntime.ButtonCategory.Disabled;
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
                            CommonList.Height = -72f;
                            CommonList.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                            CommonList.Width = 100f;
                            CommonList.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            CommonList.Y = 72f;
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
                bool setCommonListYFirstValue = false;
                bool setCommonListYSecondValue = false;
                float CommonListYFirstValue= 0;
                float CommonListYSecondValue= 0;
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
                bool setOilTabCurrentButtonCategoryStateFirstValue = false;
                bool setOilTabCurrentButtonCategoryStateSecondValue = false;
                JHP4SD.GumRuntimes.LebegForms.BasicComponents.CityMenuTabRuntime.ButtonCategory OilTabCurrentButtonCategoryStateFirstValue= JHP4SD.GumRuntimes.LebegForms.BasicComponents.CityMenuTabRuntime.ButtonCategory.Enabled;
                JHP4SD.GumRuntimes.LebegForms.BasicComponents.CityMenuTabRuntime.ButtonCategory OilTabCurrentButtonCategoryStateSecondValue= JHP4SD.GumRuntimes.LebegForms.BasicComponents.CityMenuTabRuntime.ButtonCategory.Enabled;
                bool setWidthFirstValue = false;
                bool setWidthSecondValue = false;
                float WidthFirstValue= 0;
                float WidthSecondValue= 0;
                bool setWorkforceTabCurrentButtonCategoryStateFirstValue = false;
                bool setWorkforceTabCurrentButtonCategoryStateSecondValue = false;
                JHP4SD.GumRuntimes.LebegForms.BasicComponents.CityMenuTabRuntime.ButtonCategory WorkforceTabCurrentButtonCategoryStateFirstValue= JHP4SD.GumRuntimes.LebegForms.BasicComponents.CityMenuTabRuntime.ButtonCategory.Enabled;
                JHP4SD.GumRuntimes.LebegForms.BasicComponents.CityMenuTabRuntime.ButtonCategory WorkforceTabCurrentButtonCategoryStateSecondValue= JHP4SD.GumRuntimes.LebegForms.BasicComponents.CityMenuTabRuntime.ButtonCategory.Enabled;
                bool setYFirstValue = false;
                bool setYSecondValue = false;
                float YFirstValue= 0;
                float YSecondValue= 0;
                switch(firstState)
                {
                    case  VariableState.Default:
                        setCommonListHeightFirstValue = true;
                        CommonListHeightFirstValue = -72f;
                        if (interpolationValue < 1)
                        {
                            this.CommonList.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        setCommonListWidthFirstValue = true;
                        CommonListWidthFirstValue = 100f;
                        if (interpolationValue < 1)
                        {
                            this.CommonList.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setCommonListYFirstValue = true;
                        CommonListYFirstValue = 72f;
                        if (interpolationValue < 1)
                        {
                            SetProperty("CommonTab.MenuIcon", "../GlobalContent/Resources/CategoryIcons/factory.png");
                        }
                        if (interpolationValue < 1)
                        {
                            this.CommonTab.Parent = this.GetGraphicalUiElementByName("ContainerInstance") ?? this;
                        }
                        setConstructionTabCurrentButtonCategoryStateFirstValue = true;
                        ConstructionTabCurrentButtonCategoryStateFirstValue = JHP4SD.GumRuntimes.LebegForms.BasicComponents.CityMenuTabRuntime.ButtonCategory.Disabled;
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
                        setOilTabCurrentButtonCategoryStateFirstValue = true;
                        OilTabCurrentButtonCategoryStateFirstValue = JHP4SD.GumRuntimes.LebegForms.BasicComponents.CityMenuTabRuntime.ButtonCategory.Disabled;
                        if (interpolationValue < 1)
                        {
                            SetProperty("OilTab.MenuIcon", "../GlobalContent/Resources/CategoryIcons/oil-pump.png");
                        }
                        if (interpolationValue < 1)
                        {
                            this.OilTab.Parent = this.GetGraphicalUiElementByName("ContainerInstance") ?? this;
                        }
                        setWidthFirstValue = true;
                        WidthFirstValue = 500f;
                        setWorkforceTabCurrentButtonCategoryStateFirstValue = true;
                        WorkforceTabCurrentButtonCategoryStateFirstValue = JHP4SD.GumRuntimes.LebegForms.BasicComponents.CityMenuTabRuntime.ButtonCategory.Disabled;
                        if (interpolationValue < 1)
                        {
                            SetProperty("WorkforceTab.MenuIcon", "../GlobalContent/Resources/CategoryIcons/modern-city.png");
                        }
                        if (interpolationValue < 1)
                        {
                            this.WorkforceTab.Parent = this.GetGraphicalUiElementByName("ContainerInstance") ?? this;
                        }
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
                        CommonListHeightSecondValue = -72f;
                        if (interpolationValue >= 1)
                        {
                            this.CommonList.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        setCommonListWidthSecondValue = true;
                        CommonListWidthSecondValue = 100f;
                        if (interpolationValue >= 1)
                        {
                            this.CommonList.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setCommonListYSecondValue = true;
                        CommonListYSecondValue = 72f;
                        if (interpolationValue >= 1)
                        {
                            SetProperty("CommonTab.MenuIcon", "../GlobalContent/Resources/CategoryIcons/factory.png");
                        }
                        if (interpolationValue >= 1)
                        {
                            this.CommonTab.Parent = this.GetGraphicalUiElementByName("ContainerInstance") ?? this;
                        }
                        setConstructionTabCurrentButtonCategoryStateSecondValue = true;
                        ConstructionTabCurrentButtonCategoryStateSecondValue = JHP4SD.GumRuntimes.LebegForms.BasicComponents.CityMenuTabRuntime.ButtonCategory.Disabled;
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
                        setOilTabCurrentButtonCategoryStateSecondValue = true;
                        OilTabCurrentButtonCategoryStateSecondValue = JHP4SD.GumRuntimes.LebegForms.BasicComponents.CityMenuTabRuntime.ButtonCategory.Disabled;
                        if (interpolationValue >= 1)
                        {
                            SetProperty("OilTab.MenuIcon", "../GlobalContent/Resources/CategoryIcons/oil-pump.png");
                        }
                        if (interpolationValue >= 1)
                        {
                            this.OilTab.Parent = this.GetGraphicalUiElementByName("ContainerInstance") ?? this;
                        }
                        setWidthSecondValue = true;
                        WidthSecondValue = 500f;
                        setWorkforceTabCurrentButtonCategoryStateSecondValue = true;
                        WorkforceTabCurrentButtonCategoryStateSecondValue = JHP4SD.GumRuntimes.LebegForms.BasicComponents.CityMenuTabRuntime.ButtonCategory.Disabled;
                        if (interpolationValue >= 1)
                        {
                            SetProperty("WorkforceTab.MenuIcon", "../GlobalContent/Resources/CategoryIcons/modern-city.png");
                        }
                        if (interpolationValue >= 1)
                        {
                            this.WorkforceTab.Parent = this.GetGraphicalUiElementByName("ContainerInstance") ?? this;
                        }
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
                if (setCommonListYFirstValue && setCommonListYSecondValue)
                {
                    CommonList.Y = CommonListYFirstValue * (1 - interpolationValue) + CommonListYSecondValue * interpolationValue;
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
                if (setOilTabCurrentButtonCategoryStateFirstValue && setOilTabCurrentButtonCategoryStateSecondValue)
                {
                    OilTab.InterpolateBetween(OilTabCurrentButtonCategoryStateFirstValue, OilTabCurrentButtonCategoryStateSecondValue, interpolationValue);
                }
                if (setWidthFirstValue && setWidthSecondValue)
                {
                    Width = WidthFirstValue * (1 - interpolationValue) + WidthSecondValue * interpolationValue;
                }
                if (setWorkforceTabCurrentButtonCategoryStateFirstValue && setWorkforceTabCurrentButtonCategoryStateSecondValue)
                {
                    WorkforceTab.InterpolateBetween(WorkforceTabCurrentButtonCategoryStateFirstValue, WorkforceTabCurrentButtonCategoryStateSecondValue, interpolationValue);
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
                CommonTab.StopAnimations();
                ConstructionTab.StopAnimations();
                EnergyTab.StopAnimations();
                OilTab.StopAnimations();
                WorkforceTab.StopAnimations();
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
                            Name = "CommonList.Y",
                            Type = "float",
                            Value = CommonList.Y
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
                            Value = CommonList.Height + -72f
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
                            Name = "CommonList.Width",
                            Type = "float",
                            Value = CommonList.Width + 100f
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
                            Name = "CommonList.Y",
                            Type = "float",
                            Value = CommonList.Y + 72f
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
            public JHP4SD.GumRuntimes.ContainerRuntime ContainerInstance { get; set; }
            public JHP4SD.GumRuntimes.LebegForms.BasicComponents.CityMenuTabRuntime CommonTab { get; set; }
            public JHP4SD.GumRuntimes.LebegForms.BasicComponents.CityMenuTabRuntime ConstructionTab { get; set; }
            public JHP4SD.GumRuntimes.LebegForms.BasicComponents.CityMenuTabRuntime EnergyTab { get; set; }
            public JHP4SD.GumRuntimes.LebegForms.BasicComponents.CityMenuTabRuntime OilTab { get; set; }
            public JHP4SD.GumRuntimes.LebegForms.BasicComponents.CityMenuTabRuntime WorkforceTab { get; set; }
            public event FlatRedBall.Gui.WindowEvent CommonListClick;
            public event FlatRedBall.Gui.WindowEvent CommonTabClick;
            public event FlatRedBall.Gui.WindowEvent ConstructionTabClick;
            public event FlatRedBall.Gui.WindowEvent EnergyTabClick;
            public event FlatRedBall.Gui.WindowEvent OilTabClick;
            public event FlatRedBall.Gui.WindowEvent WorkforceTabClick;
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
                ContainerInstance = this.GetGraphicalUiElementByName("ContainerInstance") as JHP4SD.GumRuntimes.ContainerRuntime;
                CommonTab = this.GetGraphicalUiElementByName("CommonTab") as JHP4SD.GumRuntimes.LebegForms.BasicComponents.CityMenuTabRuntime;
                ConstructionTab = this.GetGraphicalUiElementByName("ConstructionTab") as JHP4SD.GumRuntimes.LebegForms.BasicComponents.CityMenuTabRuntime;
                EnergyTab = this.GetGraphicalUiElementByName("EnergyTab") as JHP4SD.GumRuntimes.LebegForms.BasicComponents.CityMenuTabRuntime;
                OilTab = this.GetGraphicalUiElementByName("OilTab") as JHP4SD.GumRuntimes.LebegForms.BasicComponents.CityMenuTabRuntime;
                WorkforceTab = this.GetGraphicalUiElementByName("WorkforceTab") as JHP4SD.GumRuntimes.LebegForms.BasicComponents.CityMenuTabRuntime;
                CommonList.Click += (unused) => CommonListClick?.Invoke(this);
                CommonTab.Click += (unused) => CommonTabClick?.Invoke(this);
                ConstructionTab.Click += (unused) => ConstructionTabClick?.Invoke(this);
                EnergyTab.Click += (unused) => EnergyTabClick?.Invoke(this);
                OilTab.Click += (unused) => OilTabClick?.Invoke(this);
                WorkforceTab.Click += (unused) => WorkforceTabClick?.Invoke(this);
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
