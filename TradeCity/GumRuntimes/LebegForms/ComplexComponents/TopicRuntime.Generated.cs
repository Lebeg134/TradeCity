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
                            TopText.Parent = this.GetGraphicalUiElementByName("TopColoredFrameInstance") ?? this;
                            TopColoredFrameInstance.CurrentColorCategoryState = JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Black;
                            ChildrenLayout = Gum.Managers.ChildrenLayout.TopToBottomStack;
                            ClipsChildren = false;
                            Height = 0f;
                            HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                            Width = 250f;
                            WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                            WrapsChildren = false;
                            TopText.Blue = 255;
                            TopText.Font = "Arial";
                            TopText.FontSize = 24;
                            TopText.Green = 255;
                            TopText.Height = 0f;
                            TopText.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                            TopText.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                            TopText.Red = 255;
                            TopText.Text = "TopicName";
                            TopText.VerticalAlignment = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            TopText.Visible = true;
                            TopText.Width = 95f;
                            TopText.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            TopText.X = 5f;
                            TopText.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                            TopText.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                            TopText.Y = 0f;
                            TopText.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            TopText.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            TopColoredFrameInstance.Height = 6f;
                            TopColoredFrameInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                            TopColoredFrameInstance.Width = 100f;
                            TopColoredFrameInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            TopColoredFrameInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                            ColoredFrameInstance.Height = -22f;
                            ColoredFrameInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                            ColoredFrameInstance.Width = 100f;
                            ColoredFrameInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            ColoredFrameInstance.Y = 10f;
                            ColoredFrameInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Bottom;
                            ColoredFrameInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
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
                bool setColoredFrameInstanceHeightFirstValue = false;
                bool setColoredFrameInstanceHeightSecondValue = false;
                float ColoredFrameInstanceHeightFirstValue= 0;
                float ColoredFrameInstanceHeightSecondValue= 0;
                bool setColoredFrameInstanceWidthFirstValue = false;
                bool setColoredFrameInstanceWidthSecondValue = false;
                float ColoredFrameInstanceWidthFirstValue= 0;
                float ColoredFrameInstanceWidthSecondValue= 0;
                bool setColoredFrameInstanceYFirstValue = false;
                bool setColoredFrameInstanceYSecondValue = false;
                float ColoredFrameInstanceYFirstValue= 0;
                float ColoredFrameInstanceYSecondValue= 0;
                bool setHeightFirstValue = false;
                bool setHeightSecondValue = false;
                float HeightFirstValue= 0;
                float HeightSecondValue= 0;
                bool setTopColoredFrameInstanceCurrentColorCategoryStateFirstValue = false;
                bool setTopColoredFrameInstanceCurrentColorCategoryStateSecondValue = false;
                JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory TopColoredFrameInstanceCurrentColorCategoryStateFirstValue= JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Gray;
                JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory TopColoredFrameInstanceCurrentColorCategoryStateSecondValue= JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Gray;
                bool setTopColoredFrameInstanceHeightFirstValue = false;
                bool setTopColoredFrameInstanceHeightSecondValue = false;
                float TopColoredFrameInstanceHeightFirstValue= 0;
                float TopColoredFrameInstanceHeightSecondValue= 0;
                bool setTopColoredFrameInstanceWidthFirstValue = false;
                bool setTopColoredFrameInstanceWidthSecondValue = false;
                float TopColoredFrameInstanceWidthFirstValue= 0;
                float TopColoredFrameInstanceWidthSecondValue= 0;
                bool setTopTextBlueFirstValue = false;
                bool setTopTextBlueSecondValue = false;
                int TopTextBlueFirstValue= 0;
                int TopTextBlueSecondValue= 0;
                bool setTopTextFontSizeFirstValue = false;
                bool setTopTextFontSizeSecondValue = false;
                int TopTextFontSizeFirstValue= 0;
                int TopTextFontSizeSecondValue= 0;
                bool setTopTextGreenFirstValue = false;
                bool setTopTextGreenSecondValue = false;
                int TopTextGreenFirstValue= 0;
                int TopTextGreenSecondValue= 0;
                bool setTopTextHeightFirstValue = false;
                bool setTopTextHeightSecondValue = false;
                float TopTextHeightFirstValue= 0;
                float TopTextHeightSecondValue= 0;
                bool setTopTextRedFirstValue = false;
                bool setTopTextRedSecondValue = false;
                int TopTextRedFirstValue= 0;
                int TopTextRedSecondValue= 0;
                bool setTopTextWidthFirstValue = false;
                bool setTopTextWidthSecondValue = false;
                float TopTextWidthFirstValue= 0;
                float TopTextWidthSecondValue= 0;
                bool setTopTextXFirstValue = false;
                bool setTopTextXSecondValue = false;
                float TopTextXFirstValue= 0;
                float TopTextXSecondValue= 0;
                bool setTopTextYFirstValue = false;
                bool setTopTextYSecondValue = false;
                float TopTextYFirstValue= 0;
                float TopTextYSecondValue= 0;
                bool setWidthFirstValue = false;
                bool setWidthSecondValue = false;
                float WidthFirstValue= 0;
                float WidthSecondValue= 0;
                switch(firstState)
                {
                    case  VariableState.Default:
                        if (interpolationValue < 1)
                        {
                            this.ChildrenLayout = Gum.Managers.ChildrenLayout.TopToBottomStack;
                        }
                        if (interpolationValue < 1)
                        {
                            this.ClipsChildren = false;
                        }
                        setColoredFrameInstanceHeightFirstValue = true;
                        ColoredFrameInstanceHeightFirstValue = -22f;
                        if (interpolationValue < 1)
                        {
                            this.ColoredFrameInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        setColoredFrameInstanceWidthFirstValue = true;
                        ColoredFrameInstanceWidthFirstValue = 100f;
                        if (interpolationValue < 1)
                        {
                            this.ColoredFrameInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setColoredFrameInstanceYFirstValue = true;
                        ColoredFrameInstanceYFirstValue = 10f;
                        if (interpolationValue < 1)
                        {
                            this.ColoredFrameInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Bottom;
                        }
                        if (interpolationValue < 1)
                        {
                            this.ColoredFrameInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                        }
                        setHeightFirstValue = true;
                        HeightFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                        }
                        setTopColoredFrameInstanceCurrentColorCategoryStateFirstValue = true;
                        TopColoredFrameInstanceCurrentColorCategoryStateFirstValue = JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Black;
                        setTopColoredFrameInstanceHeightFirstValue = true;
                        TopColoredFrameInstanceHeightFirstValue = 6f;
                        if (interpolationValue < 1)
                        {
                            this.TopColoredFrameInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                        }
                        setTopColoredFrameInstanceWidthFirstValue = true;
                        TopColoredFrameInstanceWidthFirstValue = 100f;
                        if (interpolationValue < 1)
                        {
                            this.TopColoredFrameInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.TopColoredFrameInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                        }
                        setTopTextBlueFirstValue = true;
                        TopTextBlueFirstValue = 255;
                        if (interpolationValue < 1)
                        {
                            this.TopText.Font = "Arial";
                        }
                        setTopTextFontSizeFirstValue = true;
                        TopTextFontSizeFirstValue = 24;
                        setTopTextGreenFirstValue = true;
                        TopTextGreenFirstValue = 255;
                        setTopTextHeightFirstValue = true;
                        TopTextHeightFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.TopText.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                        }
                        if (interpolationValue < 1)
                        {
                            this.TopText.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                        }
                        if (interpolationValue < 1)
                        {
                            this.TopText.Parent = this.GetGraphicalUiElementByName("TopColoredFrameInstance") ?? this;
                        }
                        setTopTextRedFirstValue = true;
                        TopTextRedFirstValue = 255;
                        if (interpolationValue < 1)
                        {
                            this.TopText.Text = "TopicName";
                        }
                        if (interpolationValue < 1)
                        {
                            this.TopText.VerticalAlignment = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.TopText.Visible = true;
                        }
                        setTopTextWidthFirstValue = true;
                        TopTextWidthFirstValue = 95f;
                        if (interpolationValue < 1)
                        {
                            this.TopText.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setTopTextXFirstValue = true;
                        TopTextXFirstValue = 5f;
                        if (interpolationValue < 1)
                        {
                            this.TopText.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                        }
                        if (interpolationValue < 1)
                        {
                            this.TopText.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setTopTextYFirstValue = true;
                        TopTextYFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.TopText.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.TopText.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setWidthFirstValue = true;
                        WidthFirstValue = 250f;
                        if (interpolationValue < 1)
                        {
                            this.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        if (interpolationValue < 1)
                        {
                            this.WrapsChildren = false;
                        }
                        break;
                }
                switch(secondState)
                {
                    case  VariableState.Default:
                        if (interpolationValue >= 1)
                        {
                            this.ChildrenLayout = Gum.Managers.ChildrenLayout.TopToBottomStack;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.ClipsChildren = false;
                        }
                        setColoredFrameInstanceHeightSecondValue = true;
                        ColoredFrameInstanceHeightSecondValue = -22f;
                        if (interpolationValue >= 1)
                        {
                            this.ColoredFrameInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        setColoredFrameInstanceWidthSecondValue = true;
                        ColoredFrameInstanceWidthSecondValue = 100f;
                        if (interpolationValue >= 1)
                        {
                            this.ColoredFrameInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setColoredFrameInstanceYSecondValue = true;
                        ColoredFrameInstanceYSecondValue = 10f;
                        if (interpolationValue >= 1)
                        {
                            this.ColoredFrameInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Bottom;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.ColoredFrameInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                        }
                        setHeightSecondValue = true;
                        HeightSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                        }
                        setTopColoredFrameInstanceCurrentColorCategoryStateSecondValue = true;
                        TopColoredFrameInstanceCurrentColorCategoryStateSecondValue = JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Black;
                        setTopColoredFrameInstanceHeightSecondValue = true;
                        TopColoredFrameInstanceHeightSecondValue = 6f;
                        if (interpolationValue >= 1)
                        {
                            this.TopColoredFrameInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                        }
                        setTopColoredFrameInstanceWidthSecondValue = true;
                        TopColoredFrameInstanceWidthSecondValue = 100f;
                        if (interpolationValue >= 1)
                        {
                            this.TopColoredFrameInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.TopColoredFrameInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                        }
                        setTopTextBlueSecondValue = true;
                        TopTextBlueSecondValue = 255;
                        if (interpolationValue >= 1)
                        {
                            this.TopText.Font = "Arial";
                        }
                        setTopTextFontSizeSecondValue = true;
                        TopTextFontSizeSecondValue = 24;
                        setTopTextGreenSecondValue = true;
                        TopTextGreenSecondValue = 255;
                        setTopTextHeightSecondValue = true;
                        TopTextHeightSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.TopText.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.TopText.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.TopText.Parent = this.GetGraphicalUiElementByName("TopColoredFrameInstance") ?? this;
                        }
                        setTopTextRedSecondValue = true;
                        TopTextRedSecondValue = 255;
                        if (interpolationValue >= 1)
                        {
                            this.TopText.Text = "TopicName";
                        }
                        if (interpolationValue >= 1)
                        {
                            this.TopText.VerticalAlignment = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.TopText.Visible = true;
                        }
                        setTopTextWidthSecondValue = true;
                        TopTextWidthSecondValue = 95f;
                        if (interpolationValue >= 1)
                        {
                            this.TopText.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setTopTextXSecondValue = true;
                        TopTextXSecondValue = 5f;
                        if (interpolationValue >= 1)
                        {
                            this.TopText.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.TopText.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setTopTextYSecondValue = true;
                        TopTextYSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.TopText.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.TopText.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setWidthSecondValue = true;
                        WidthSecondValue = 250f;
                        if (interpolationValue >= 1)
                        {
                            this.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.WrapsChildren = false;
                        }
                        break;
                }
                var wasSuppressed = mIsLayoutSuspended;
                if (wasSuppressed == false)
                {
                    SuspendLayout(true);
                }
                if (setColoredFrameInstanceHeightFirstValue && setColoredFrameInstanceHeightSecondValue)
                {
                    ColoredFrameInstance.Height = ColoredFrameInstanceHeightFirstValue * (1 - interpolationValue) + ColoredFrameInstanceHeightSecondValue * interpolationValue;
                }
                if (setColoredFrameInstanceWidthFirstValue && setColoredFrameInstanceWidthSecondValue)
                {
                    ColoredFrameInstance.Width = ColoredFrameInstanceWidthFirstValue * (1 - interpolationValue) + ColoredFrameInstanceWidthSecondValue * interpolationValue;
                }
                if (setColoredFrameInstanceYFirstValue && setColoredFrameInstanceYSecondValue)
                {
                    ColoredFrameInstance.Y = ColoredFrameInstanceYFirstValue * (1 - interpolationValue) + ColoredFrameInstanceYSecondValue * interpolationValue;
                }
                if (setHeightFirstValue && setHeightSecondValue)
                {
                    Height = HeightFirstValue * (1 - interpolationValue) + HeightSecondValue * interpolationValue;
                }
                if (setTopColoredFrameInstanceCurrentColorCategoryStateFirstValue && setTopColoredFrameInstanceCurrentColorCategoryStateSecondValue)
                {
                    TopColoredFrameInstance.InterpolateBetween(TopColoredFrameInstanceCurrentColorCategoryStateFirstValue, TopColoredFrameInstanceCurrentColorCategoryStateSecondValue, interpolationValue);
                }
                if (setTopColoredFrameInstanceHeightFirstValue && setTopColoredFrameInstanceHeightSecondValue)
                {
                    TopColoredFrameInstance.Height = TopColoredFrameInstanceHeightFirstValue * (1 - interpolationValue) + TopColoredFrameInstanceHeightSecondValue * interpolationValue;
                }
                if (setTopColoredFrameInstanceWidthFirstValue && setTopColoredFrameInstanceWidthSecondValue)
                {
                    TopColoredFrameInstance.Width = TopColoredFrameInstanceWidthFirstValue * (1 - interpolationValue) + TopColoredFrameInstanceWidthSecondValue * interpolationValue;
                }
                if (setTopTextBlueFirstValue && setTopTextBlueSecondValue)
                {
                    TopText.Blue = FlatRedBall.Math.MathFunctions.RoundToInt(TopTextBlueFirstValue* (1 - interpolationValue) + TopTextBlueSecondValue * interpolationValue);
                }
                if (setTopTextFontSizeFirstValue && setTopTextFontSizeSecondValue)
                {
                    TopText.FontSize = FlatRedBall.Math.MathFunctions.RoundToInt(TopTextFontSizeFirstValue* (1 - interpolationValue) + TopTextFontSizeSecondValue * interpolationValue);
                }
                if (setTopTextGreenFirstValue && setTopTextGreenSecondValue)
                {
                    TopText.Green = FlatRedBall.Math.MathFunctions.RoundToInt(TopTextGreenFirstValue* (1 - interpolationValue) + TopTextGreenSecondValue * interpolationValue);
                }
                if (setTopTextHeightFirstValue && setTopTextHeightSecondValue)
                {
                    TopText.Height = TopTextHeightFirstValue * (1 - interpolationValue) + TopTextHeightSecondValue * interpolationValue;
                }
                if (setTopTextRedFirstValue && setTopTextRedSecondValue)
                {
                    TopText.Red = FlatRedBall.Math.MathFunctions.RoundToInt(TopTextRedFirstValue* (1 - interpolationValue) + TopTextRedSecondValue * interpolationValue);
                }
                if (setTopTextWidthFirstValue && setTopTextWidthSecondValue)
                {
                    TopText.Width = TopTextWidthFirstValue * (1 - interpolationValue) + TopTextWidthSecondValue * interpolationValue;
                }
                if (setTopTextXFirstValue && setTopTextXSecondValue)
                {
                    TopText.X = TopTextXFirstValue * (1 - interpolationValue) + TopTextXSecondValue * interpolationValue;
                }
                if (setTopTextYFirstValue && setTopTextYSecondValue)
                {
                    TopText.Y = TopTextYFirstValue * (1 - interpolationValue) + TopTextYSecondValue * interpolationValue;
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
                TopColoredFrameInstance.StopAnimations();
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
                            Name = "Children Layout",
                            Type = "ChildrenLayout",
                            Value = ChildrenLayout
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Clips Children",
                            Type = "bool",
                            Value = ClipsChildren
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
                            Name = "Wraps Children",
                            Type = "bool",
                            Value = WrapsChildren
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopText.Blue",
                            Type = "int",
                            Value = TopText.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopText.Font",
                            Type = "string",
                            Value = TopText.Font
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopText.FontSize",
                            Type = "int",
                            Value = TopText.FontSize
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopText.Green",
                            Type = "int",
                            Value = TopText.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopText.Height",
                            Type = "float",
                            Value = TopText.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopText.Height Units",
                            Type = "DimensionUnitType",
                            Value = TopText.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopText.HorizontalAlignment",
                            Type = "HorizontalAlignment",
                            Value = TopText.HorizontalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopText.Parent",
                            Type = "string",
                            Value = TopText.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopText.Red",
                            Type = "int",
                            Value = TopText.Red
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopText.Text",
                            Type = "string",
                            Value = TopText.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopText.VerticalAlignment",
                            Type = "VerticalAlignment",
                            Value = TopText.VerticalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopText.Visible",
                            Type = "bool",
                            Value = TopText.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopText.Width",
                            Type = "float",
                            Value = TopText.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopText.Width Units",
                            Type = "DimensionUnitType",
                            Value = TopText.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopText.X",
                            Type = "float",
                            Value = TopText.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopText.X Origin",
                            Type = "HorizontalAlignment",
                            Value = TopText.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopText.X Units",
                            Type = "PositionUnitType",
                            Value = TopText.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopText.Y",
                            Type = "float",
                            Value = TopText.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopText.Y Origin",
                            Type = "VerticalAlignment",
                            Value = TopText.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopText.Y Units",
                            Type = "PositionUnitType",
                            Value = TopText.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopColoredFrameInstance.ColorCategoryState",
                            Type = "ColorCategoryState",
                            Value = TopColoredFrameInstance.CurrentColorCategoryState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopColoredFrameInstance.Height",
                            Type = "float",
                            Value = TopColoredFrameInstance.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopColoredFrameInstance.Height Units",
                            Type = "DimensionUnitType",
                            Value = TopColoredFrameInstance.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopColoredFrameInstance.Width",
                            Type = "float",
                            Value = TopColoredFrameInstance.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopColoredFrameInstance.Width Units",
                            Type = "DimensionUnitType",
                            Value = TopColoredFrameInstance.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopColoredFrameInstance.X Units",
                            Type = "PositionUnitType",
                            Value = TopColoredFrameInstance.XUnits
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
                            Name = "Clips Children",
                            Type = "bool",
                            Value = ClipsChildren
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Height",
                            Type = "float",
                            Value = Height + 0f
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
                            Value = Width + 250f
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
                            Name = "Wraps Children",
                            Type = "bool",
                            Value = WrapsChildren
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopText.Blue",
                            Type = "int",
                            Value = TopText.Blue + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopText.Font",
                            Type = "string",
                            Value = TopText.Font
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopText.FontSize",
                            Type = "int",
                            Value = TopText.FontSize + 24
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopText.Green",
                            Type = "int",
                            Value = TopText.Green + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopText.Height",
                            Type = "float",
                            Value = TopText.Height + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopText.Height Units",
                            Type = "DimensionUnitType",
                            Value = TopText.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopText.HorizontalAlignment",
                            Type = "HorizontalAlignment",
                            Value = TopText.HorizontalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopText.Parent",
                            Type = "string",
                            Value = TopText.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopText.Red",
                            Type = "int",
                            Value = TopText.Red + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopText.Text",
                            Type = "string",
                            Value = TopText.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopText.VerticalAlignment",
                            Type = "VerticalAlignment",
                            Value = TopText.VerticalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopText.Visible",
                            Type = "bool",
                            Value = TopText.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopText.Width",
                            Type = "float",
                            Value = TopText.Width + 95f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopText.Width Units",
                            Type = "DimensionUnitType",
                            Value = TopText.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopText.X",
                            Type = "float",
                            Value = TopText.X + 5f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopText.X Origin",
                            Type = "HorizontalAlignment",
                            Value = TopText.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopText.X Units",
                            Type = "PositionUnitType",
                            Value = TopText.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopText.Y",
                            Type = "float",
                            Value = TopText.Y + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopText.Y Origin",
                            Type = "VerticalAlignment",
                            Value = TopText.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopText.Y Units",
                            Type = "PositionUnitType",
                            Value = TopText.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopColoredFrameInstance.ColorCategoryState",
                            Type = "ColorCategoryState",
                            Value = TopColoredFrameInstance.CurrentColorCategoryState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopColoredFrameInstance.Height",
                            Type = "float",
                            Value = TopColoredFrameInstance.Height + 6f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopColoredFrameInstance.Height Units",
                            Type = "DimensionUnitType",
                            Value = TopColoredFrameInstance.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopColoredFrameInstance.Width",
                            Type = "float",
                            Value = TopColoredFrameInstance.Width + 100f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopColoredFrameInstance.Width Units",
                            Type = "DimensionUnitType",
                            Value = TopColoredFrameInstance.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopColoredFrameInstance.X Units",
                            Type = "PositionUnitType",
                            Value = TopColoredFrameInstance.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredFrameInstance.Height",
                            Type = "float",
                            Value = ColoredFrameInstance.Height + -22f
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
                            Name = "ColoredFrameInstance.Y",
                            Type = "float",
                            Value = ColoredFrameInstance.Y + 10f
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
            public JHP4SD.GumRuntimes.TextRuntime TopText { get; set; }
            public JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime TopColoredFrameInstance { get; set; }
            public JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime ColoredFrameInstance { get; set; }
            public int TopicFontSize
            {
                get
                {
                    return TopText.FontSize;
                }
                set
                {
                    if (TopText.FontSize != value)
                    {
                        TopText.FontSize = value;
                        TopicFontSizeChanged?.Invoke(this, null);
                    }
                }
            }
            public string TopicName
            {
                get
                {
                    return TopText.Text;
                }
                set
                {
                    if (TopText.Text != value)
                    {
                        TopText.Text = value;
                        TopicNameChanged?.Invoke(this, null);
                    }
                }
            }
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
                TopText = this.GetGraphicalUiElementByName("TopText") as JHP4SD.GumRuntimes.TextRuntime;
                TopColoredFrameInstance = this.GetGraphicalUiElementByName("TopColoredFrameInstance") as JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime;
                ColoredFrameInstance = this.GetGraphicalUiElementByName("ColoredFrameInstance") as JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime;
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
