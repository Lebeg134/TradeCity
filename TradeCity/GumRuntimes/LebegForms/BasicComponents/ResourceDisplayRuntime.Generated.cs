    using System.Linq;
    namespace JHP4SD.GumRuntimes.LebegForms.BasicComponents
    {
        public partial class ResourceDisplayRuntime : JHP4SD.GumRuntimes.ContainerRuntime
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
                            Height = 40f;
                            Width = 180f;
                            XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                            XUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                            LabelInstance.Height = 40f;
                            LabelInstance.Width = 100f;
                            LabelInstance.X = 0f;
                            LabelInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                            LabelInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                            LabelInstance.Y = 0f;
                            SpriteInstance.Height = 40f;
                            SpriteInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                            SpriteInstance.TextureAddress = Gum.Managers.TextureAddress.EntireTexture;
                            SpriteInstance.Width = 40f;
                            SpriteInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                            ChangeIndicatorUp.Blue = 34;
                            ChangeIndicatorUp.Green = 139;
                            ChangeIndicatorUp.Height = 40f;
                            ChangeIndicatorUp.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                            ChangeIndicatorUp.Red = 34;
                            SetProperty("ChangeIndicatorUp.SourceFile", "../GlobalContent/Gameicons/PNG/White/1x/up.png");
                            ChangeIndicatorUp.Visible = false;
                            ChangeIndicatorUp.Width = 40f;
                            ChangeIndicatorUp.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                            ChangeIndicatorUp.X = 40f;
                            ChangeIndicatorUp.Y = 0f;
                            ChangeIndicatorDown.Blue = 0;
                            ChangeIndicatorDown.Green = 0;
                            ChangeIndicatorDown.Height = 40f;
                            ChangeIndicatorDown.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                            ChangeIndicatorDown.Red = 255;
                            SetProperty("ChangeIndicatorDown.SourceFile", "../GlobalContent/Gameicons/PNG/White/1x/down.png");
                            ChangeIndicatorDown.Visible = false;
                            ChangeIndicatorDown.Width = 40f;
                            ChangeIndicatorDown.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                            ChangeIndicatorDown.X = 40f;
                            ChangeIndicatorDown.Y = 0f;
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
                bool setChangeIndicatorDownBlueFirstValue = false;
                bool setChangeIndicatorDownBlueSecondValue = false;
                int ChangeIndicatorDownBlueFirstValue= 0;
                int ChangeIndicatorDownBlueSecondValue= 0;
                bool setChangeIndicatorDownGreenFirstValue = false;
                bool setChangeIndicatorDownGreenSecondValue = false;
                int ChangeIndicatorDownGreenFirstValue= 0;
                int ChangeIndicatorDownGreenSecondValue= 0;
                bool setChangeIndicatorDownHeightFirstValue = false;
                bool setChangeIndicatorDownHeightSecondValue = false;
                float ChangeIndicatorDownHeightFirstValue= 0;
                float ChangeIndicatorDownHeightSecondValue= 0;
                bool setChangeIndicatorDownRedFirstValue = false;
                bool setChangeIndicatorDownRedSecondValue = false;
                int ChangeIndicatorDownRedFirstValue= 0;
                int ChangeIndicatorDownRedSecondValue= 0;
                bool setChangeIndicatorDownWidthFirstValue = false;
                bool setChangeIndicatorDownWidthSecondValue = false;
                float ChangeIndicatorDownWidthFirstValue= 0;
                float ChangeIndicatorDownWidthSecondValue= 0;
                bool setChangeIndicatorDownXFirstValue = false;
                bool setChangeIndicatorDownXSecondValue = false;
                float ChangeIndicatorDownXFirstValue= 0;
                float ChangeIndicatorDownXSecondValue= 0;
                bool setChangeIndicatorDownYFirstValue = false;
                bool setChangeIndicatorDownYSecondValue = false;
                float ChangeIndicatorDownYFirstValue= 0;
                float ChangeIndicatorDownYSecondValue= 0;
                bool setChangeIndicatorUpBlueFirstValue = false;
                bool setChangeIndicatorUpBlueSecondValue = false;
                int ChangeIndicatorUpBlueFirstValue= 0;
                int ChangeIndicatorUpBlueSecondValue= 0;
                bool setChangeIndicatorUpGreenFirstValue = false;
                bool setChangeIndicatorUpGreenSecondValue = false;
                int ChangeIndicatorUpGreenFirstValue= 0;
                int ChangeIndicatorUpGreenSecondValue= 0;
                bool setChangeIndicatorUpHeightFirstValue = false;
                bool setChangeIndicatorUpHeightSecondValue = false;
                float ChangeIndicatorUpHeightFirstValue= 0;
                float ChangeIndicatorUpHeightSecondValue= 0;
                bool setChangeIndicatorUpRedFirstValue = false;
                bool setChangeIndicatorUpRedSecondValue = false;
                int ChangeIndicatorUpRedFirstValue= 0;
                int ChangeIndicatorUpRedSecondValue= 0;
                bool setChangeIndicatorUpWidthFirstValue = false;
                bool setChangeIndicatorUpWidthSecondValue = false;
                float ChangeIndicatorUpWidthFirstValue= 0;
                float ChangeIndicatorUpWidthSecondValue= 0;
                bool setChangeIndicatorUpXFirstValue = false;
                bool setChangeIndicatorUpXSecondValue = false;
                float ChangeIndicatorUpXFirstValue= 0;
                float ChangeIndicatorUpXSecondValue= 0;
                bool setChangeIndicatorUpYFirstValue = false;
                bool setChangeIndicatorUpYSecondValue = false;
                float ChangeIndicatorUpYFirstValue= 0;
                float ChangeIndicatorUpYSecondValue= 0;
                bool setHeightFirstValue = false;
                bool setHeightSecondValue = false;
                float HeightFirstValue= 0;
                float HeightSecondValue= 0;
                bool setLabelInstanceHeightFirstValue = false;
                bool setLabelInstanceHeightSecondValue = false;
                float LabelInstanceHeightFirstValue= 0;
                float LabelInstanceHeightSecondValue= 0;
                bool setLabelInstanceWidthFirstValue = false;
                bool setLabelInstanceWidthSecondValue = false;
                float LabelInstanceWidthFirstValue= 0;
                float LabelInstanceWidthSecondValue= 0;
                bool setLabelInstanceXFirstValue = false;
                bool setLabelInstanceXSecondValue = false;
                float LabelInstanceXFirstValue= 0;
                float LabelInstanceXSecondValue= 0;
                bool setLabelInstanceYFirstValue = false;
                bool setLabelInstanceYSecondValue = false;
                float LabelInstanceYFirstValue= 0;
                float LabelInstanceYSecondValue= 0;
                bool setSpriteInstanceHeightFirstValue = false;
                bool setSpriteInstanceHeightSecondValue = false;
                float SpriteInstanceHeightFirstValue= 0;
                float SpriteInstanceHeightSecondValue= 0;
                bool setSpriteInstanceWidthFirstValue = false;
                bool setSpriteInstanceWidthSecondValue = false;
                float SpriteInstanceWidthFirstValue= 0;
                float SpriteInstanceWidthSecondValue= 0;
                bool setWidthFirstValue = false;
                bool setWidthSecondValue = false;
                float WidthFirstValue= 0;
                float WidthSecondValue= 0;
                switch(firstState)
                {
                    case  VariableState.Default:
                        setChangeIndicatorDownBlueFirstValue = true;
                        ChangeIndicatorDownBlueFirstValue = 0;
                        setChangeIndicatorDownGreenFirstValue = true;
                        ChangeIndicatorDownGreenFirstValue = 0;
                        setChangeIndicatorDownHeightFirstValue = true;
                        ChangeIndicatorDownHeightFirstValue = 40f;
                        if (interpolationValue < 1)
                        {
                            this.ChangeIndicatorDown.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        setChangeIndicatorDownRedFirstValue = true;
                        ChangeIndicatorDownRedFirstValue = 255;
                        if (interpolationValue < 1)
                        {
                            SetProperty("ChangeIndicatorDown.SourceFile", "../GlobalContent/Gameicons/PNG/White/1x/down.png");
                        }
                        if (interpolationValue < 1)
                        {
                            this.ChangeIndicatorDown.Visible = false;
                        }
                        setChangeIndicatorDownWidthFirstValue = true;
                        ChangeIndicatorDownWidthFirstValue = 40f;
                        if (interpolationValue < 1)
                        {
                            this.ChangeIndicatorDown.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        setChangeIndicatorDownXFirstValue = true;
                        ChangeIndicatorDownXFirstValue = 40f;
                        setChangeIndicatorDownYFirstValue = true;
                        ChangeIndicatorDownYFirstValue = 0f;
                        setChangeIndicatorUpBlueFirstValue = true;
                        ChangeIndicatorUpBlueFirstValue = 34;
                        setChangeIndicatorUpGreenFirstValue = true;
                        ChangeIndicatorUpGreenFirstValue = 139;
                        setChangeIndicatorUpHeightFirstValue = true;
                        ChangeIndicatorUpHeightFirstValue = 40f;
                        if (interpolationValue < 1)
                        {
                            this.ChangeIndicatorUp.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        setChangeIndicatorUpRedFirstValue = true;
                        ChangeIndicatorUpRedFirstValue = 34;
                        if (interpolationValue < 1)
                        {
                            SetProperty("ChangeIndicatorUp.SourceFile", "../GlobalContent/Gameicons/PNG/White/1x/up.png");
                        }
                        if (interpolationValue < 1)
                        {
                            this.ChangeIndicatorUp.Visible = false;
                        }
                        setChangeIndicatorUpWidthFirstValue = true;
                        ChangeIndicatorUpWidthFirstValue = 40f;
                        if (interpolationValue < 1)
                        {
                            this.ChangeIndicatorUp.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        setChangeIndicatorUpXFirstValue = true;
                        ChangeIndicatorUpXFirstValue = 40f;
                        setChangeIndicatorUpYFirstValue = true;
                        ChangeIndicatorUpYFirstValue = 0f;
                        setHeightFirstValue = true;
                        HeightFirstValue = 40f;
                        setLabelInstanceHeightFirstValue = true;
                        LabelInstanceHeightFirstValue = 40f;
                        setLabelInstanceWidthFirstValue = true;
                        LabelInstanceWidthFirstValue = 100f;
                        setLabelInstanceXFirstValue = true;
                        LabelInstanceXFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.LabelInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                        }
                        if (interpolationValue < 1)
                        {
                            this.LabelInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                        }
                        setLabelInstanceYFirstValue = true;
                        LabelInstanceYFirstValue = 0f;
                        setSpriteInstanceHeightFirstValue = true;
                        SpriteInstanceHeightFirstValue = 40f;
                        if (interpolationValue < 1)
                        {
                            this.SpriteInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        if (interpolationValue < 1)
                        {
                            this.SpriteInstance.TextureAddress = Gum.Managers.TextureAddress.EntireTexture;
                        }
                        setSpriteInstanceWidthFirstValue = true;
                        SpriteInstanceWidthFirstValue = 40f;
                        if (interpolationValue < 1)
                        {
                            this.SpriteInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        setWidthFirstValue = true;
                        WidthFirstValue = 180f;
                        if (interpolationValue < 1)
                        {
                            this.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                        }
                        if (interpolationValue < 1)
                        {
                            this.XUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                        }
                        break;
                }
                switch(secondState)
                {
                    case  VariableState.Default:
                        setChangeIndicatorDownBlueSecondValue = true;
                        ChangeIndicatorDownBlueSecondValue = 0;
                        setChangeIndicatorDownGreenSecondValue = true;
                        ChangeIndicatorDownGreenSecondValue = 0;
                        setChangeIndicatorDownHeightSecondValue = true;
                        ChangeIndicatorDownHeightSecondValue = 40f;
                        if (interpolationValue >= 1)
                        {
                            this.ChangeIndicatorDown.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        setChangeIndicatorDownRedSecondValue = true;
                        ChangeIndicatorDownRedSecondValue = 255;
                        if (interpolationValue >= 1)
                        {
                            SetProperty("ChangeIndicatorDown.SourceFile", "../GlobalContent/Gameicons/PNG/White/1x/down.png");
                        }
                        if (interpolationValue >= 1)
                        {
                            this.ChangeIndicatorDown.Visible = false;
                        }
                        setChangeIndicatorDownWidthSecondValue = true;
                        ChangeIndicatorDownWidthSecondValue = 40f;
                        if (interpolationValue >= 1)
                        {
                            this.ChangeIndicatorDown.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        setChangeIndicatorDownXSecondValue = true;
                        ChangeIndicatorDownXSecondValue = 40f;
                        setChangeIndicatorDownYSecondValue = true;
                        ChangeIndicatorDownYSecondValue = 0f;
                        setChangeIndicatorUpBlueSecondValue = true;
                        ChangeIndicatorUpBlueSecondValue = 34;
                        setChangeIndicatorUpGreenSecondValue = true;
                        ChangeIndicatorUpGreenSecondValue = 139;
                        setChangeIndicatorUpHeightSecondValue = true;
                        ChangeIndicatorUpHeightSecondValue = 40f;
                        if (interpolationValue >= 1)
                        {
                            this.ChangeIndicatorUp.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        setChangeIndicatorUpRedSecondValue = true;
                        ChangeIndicatorUpRedSecondValue = 34;
                        if (interpolationValue >= 1)
                        {
                            SetProperty("ChangeIndicatorUp.SourceFile", "../GlobalContent/Gameicons/PNG/White/1x/up.png");
                        }
                        if (interpolationValue >= 1)
                        {
                            this.ChangeIndicatorUp.Visible = false;
                        }
                        setChangeIndicatorUpWidthSecondValue = true;
                        ChangeIndicatorUpWidthSecondValue = 40f;
                        if (interpolationValue >= 1)
                        {
                            this.ChangeIndicatorUp.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        setChangeIndicatorUpXSecondValue = true;
                        ChangeIndicatorUpXSecondValue = 40f;
                        setChangeIndicatorUpYSecondValue = true;
                        ChangeIndicatorUpYSecondValue = 0f;
                        setHeightSecondValue = true;
                        HeightSecondValue = 40f;
                        setLabelInstanceHeightSecondValue = true;
                        LabelInstanceHeightSecondValue = 40f;
                        setLabelInstanceWidthSecondValue = true;
                        LabelInstanceWidthSecondValue = 100f;
                        setLabelInstanceXSecondValue = true;
                        LabelInstanceXSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.LabelInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.LabelInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                        }
                        setLabelInstanceYSecondValue = true;
                        LabelInstanceYSecondValue = 0f;
                        setSpriteInstanceHeightSecondValue = true;
                        SpriteInstanceHeightSecondValue = 40f;
                        if (interpolationValue >= 1)
                        {
                            this.SpriteInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.SpriteInstance.TextureAddress = Gum.Managers.TextureAddress.EntireTexture;
                        }
                        setSpriteInstanceWidthSecondValue = true;
                        SpriteInstanceWidthSecondValue = 40f;
                        if (interpolationValue >= 1)
                        {
                            this.SpriteInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        setWidthSecondValue = true;
                        WidthSecondValue = 180f;
                        if (interpolationValue >= 1)
                        {
                            this.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.XUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                        }
                        break;
                }
                var wasSuppressed = mIsLayoutSuspended;
                if (wasSuppressed == false)
                {
                    SuspendLayout(true);
                }
                if (setChangeIndicatorDownBlueFirstValue && setChangeIndicatorDownBlueSecondValue)
                {
                    ChangeIndicatorDown.Blue = FlatRedBall.Math.MathFunctions.RoundToInt(ChangeIndicatorDownBlueFirstValue* (1 - interpolationValue) + ChangeIndicatorDownBlueSecondValue * interpolationValue);
                }
                if (setChangeIndicatorDownGreenFirstValue && setChangeIndicatorDownGreenSecondValue)
                {
                    ChangeIndicatorDown.Green = FlatRedBall.Math.MathFunctions.RoundToInt(ChangeIndicatorDownGreenFirstValue* (1 - interpolationValue) + ChangeIndicatorDownGreenSecondValue * interpolationValue);
                }
                if (setChangeIndicatorDownHeightFirstValue && setChangeIndicatorDownHeightSecondValue)
                {
                    ChangeIndicatorDown.Height = ChangeIndicatorDownHeightFirstValue * (1 - interpolationValue) + ChangeIndicatorDownHeightSecondValue * interpolationValue;
                }
                if (setChangeIndicatorDownRedFirstValue && setChangeIndicatorDownRedSecondValue)
                {
                    ChangeIndicatorDown.Red = FlatRedBall.Math.MathFunctions.RoundToInt(ChangeIndicatorDownRedFirstValue* (1 - interpolationValue) + ChangeIndicatorDownRedSecondValue * interpolationValue);
                }
                if (setChangeIndicatorDownWidthFirstValue && setChangeIndicatorDownWidthSecondValue)
                {
                    ChangeIndicatorDown.Width = ChangeIndicatorDownWidthFirstValue * (1 - interpolationValue) + ChangeIndicatorDownWidthSecondValue * interpolationValue;
                }
                if (setChangeIndicatorDownXFirstValue && setChangeIndicatorDownXSecondValue)
                {
                    ChangeIndicatorDown.X = ChangeIndicatorDownXFirstValue * (1 - interpolationValue) + ChangeIndicatorDownXSecondValue * interpolationValue;
                }
                if (setChangeIndicatorDownYFirstValue && setChangeIndicatorDownYSecondValue)
                {
                    ChangeIndicatorDown.Y = ChangeIndicatorDownYFirstValue * (1 - interpolationValue) + ChangeIndicatorDownYSecondValue * interpolationValue;
                }
                if (setChangeIndicatorUpBlueFirstValue && setChangeIndicatorUpBlueSecondValue)
                {
                    ChangeIndicatorUp.Blue = FlatRedBall.Math.MathFunctions.RoundToInt(ChangeIndicatorUpBlueFirstValue* (1 - interpolationValue) + ChangeIndicatorUpBlueSecondValue * interpolationValue);
                }
                if (setChangeIndicatorUpGreenFirstValue && setChangeIndicatorUpGreenSecondValue)
                {
                    ChangeIndicatorUp.Green = FlatRedBall.Math.MathFunctions.RoundToInt(ChangeIndicatorUpGreenFirstValue* (1 - interpolationValue) + ChangeIndicatorUpGreenSecondValue * interpolationValue);
                }
                if (setChangeIndicatorUpHeightFirstValue && setChangeIndicatorUpHeightSecondValue)
                {
                    ChangeIndicatorUp.Height = ChangeIndicatorUpHeightFirstValue * (1 - interpolationValue) + ChangeIndicatorUpHeightSecondValue * interpolationValue;
                }
                if (setChangeIndicatorUpRedFirstValue && setChangeIndicatorUpRedSecondValue)
                {
                    ChangeIndicatorUp.Red = FlatRedBall.Math.MathFunctions.RoundToInt(ChangeIndicatorUpRedFirstValue* (1 - interpolationValue) + ChangeIndicatorUpRedSecondValue * interpolationValue);
                }
                if (setChangeIndicatorUpWidthFirstValue && setChangeIndicatorUpWidthSecondValue)
                {
                    ChangeIndicatorUp.Width = ChangeIndicatorUpWidthFirstValue * (1 - interpolationValue) + ChangeIndicatorUpWidthSecondValue * interpolationValue;
                }
                if (setChangeIndicatorUpXFirstValue && setChangeIndicatorUpXSecondValue)
                {
                    ChangeIndicatorUp.X = ChangeIndicatorUpXFirstValue * (1 - interpolationValue) + ChangeIndicatorUpXSecondValue * interpolationValue;
                }
                if (setChangeIndicatorUpYFirstValue && setChangeIndicatorUpYSecondValue)
                {
                    ChangeIndicatorUp.Y = ChangeIndicatorUpYFirstValue * (1 - interpolationValue) + ChangeIndicatorUpYSecondValue * interpolationValue;
                }
                if (setHeightFirstValue && setHeightSecondValue)
                {
                    Height = HeightFirstValue * (1 - interpolationValue) + HeightSecondValue * interpolationValue;
                }
                if (setLabelInstanceHeightFirstValue && setLabelInstanceHeightSecondValue)
                {
                    LabelInstance.Height = LabelInstanceHeightFirstValue * (1 - interpolationValue) + LabelInstanceHeightSecondValue * interpolationValue;
                }
                if (setLabelInstanceWidthFirstValue && setLabelInstanceWidthSecondValue)
                {
                    LabelInstance.Width = LabelInstanceWidthFirstValue * (1 - interpolationValue) + LabelInstanceWidthSecondValue * interpolationValue;
                }
                if (setLabelInstanceXFirstValue && setLabelInstanceXSecondValue)
                {
                    LabelInstance.X = LabelInstanceXFirstValue * (1 - interpolationValue) + LabelInstanceXSecondValue * interpolationValue;
                }
                if (setLabelInstanceYFirstValue && setLabelInstanceYSecondValue)
                {
                    LabelInstance.Y = LabelInstanceYFirstValue * (1 - interpolationValue) + LabelInstanceYSecondValue * interpolationValue;
                }
                if (setSpriteInstanceHeightFirstValue && setSpriteInstanceHeightSecondValue)
                {
                    SpriteInstance.Height = SpriteInstanceHeightFirstValue * (1 - interpolationValue) + SpriteInstanceHeightSecondValue * interpolationValue;
                }
                if (setSpriteInstanceWidthFirstValue && setSpriteInstanceWidthSecondValue)
                {
                    SpriteInstance.Width = SpriteInstanceWidthFirstValue * (1 - interpolationValue) + SpriteInstanceWidthSecondValue * interpolationValue;
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
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (JHP4SD.GumRuntimes.LebegForms.BasicComponents.ResourceDisplayRuntime.VariableState fromState,JHP4SD.GumRuntimes.LebegForms.BasicComponents.ResourceDisplayRuntime.VariableState toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null) 
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
                LabelInstance.StopAnimations();
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
                            Name = "LabelInstance.Height",
                            Type = "float",
                            Value = LabelInstance.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LabelInstance.Width",
                            Type = "float",
                            Value = LabelInstance.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LabelInstance.X",
                            Type = "float",
                            Value = LabelInstance.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LabelInstance.X Origin",
                            Type = "HorizontalAlignment",
                            Value = LabelInstance.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LabelInstance.X Units",
                            Type = "PositionUnitType",
                            Value = LabelInstance.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LabelInstance.Y",
                            Type = "float",
                            Value = LabelInstance.Y
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
                            Name = "SpriteInstance.Texture Address",
                            Type = "TextureAddress",
                            Value = SpriteInstance.TextureAddress
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
                            Name = "ChangeIndicatorUp.Blue",
                            Type = "int",
                            Value = ChangeIndicatorUp.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChangeIndicatorUp.Green",
                            Type = "int",
                            Value = ChangeIndicatorUp.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChangeIndicatorUp.Height",
                            Type = "float",
                            Value = ChangeIndicatorUp.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChangeIndicatorUp.Height Units",
                            Type = "DimensionUnitType",
                            Value = ChangeIndicatorUp.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChangeIndicatorUp.Red",
                            Type = "int",
                            Value = ChangeIndicatorUp.Red
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChangeIndicatorUp.SourceFile",
                            Type = "string",
                            Value = ChangeIndicatorUp.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChangeIndicatorUp.Visible",
                            Type = "bool",
                            Value = ChangeIndicatorUp.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChangeIndicatorUp.Width",
                            Type = "float",
                            Value = ChangeIndicatorUp.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChangeIndicatorUp.Width Units",
                            Type = "DimensionUnitType",
                            Value = ChangeIndicatorUp.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChangeIndicatorUp.X",
                            Type = "float",
                            Value = ChangeIndicatorUp.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChangeIndicatorUp.Y",
                            Type = "float",
                            Value = ChangeIndicatorUp.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChangeIndicatorDown.Blue",
                            Type = "int",
                            Value = ChangeIndicatorDown.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChangeIndicatorDown.Green",
                            Type = "int",
                            Value = ChangeIndicatorDown.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChangeIndicatorDown.Height",
                            Type = "float",
                            Value = ChangeIndicatorDown.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChangeIndicatorDown.Height Units",
                            Type = "DimensionUnitType",
                            Value = ChangeIndicatorDown.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChangeIndicatorDown.Red",
                            Type = "int",
                            Value = ChangeIndicatorDown.Red
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChangeIndicatorDown.SourceFile",
                            Type = "string",
                            Value = ChangeIndicatorDown.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChangeIndicatorDown.Visible",
                            Type = "bool",
                            Value = ChangeIndicatorDown.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChangeIndicatorDown.Width",
                            Type = "float",
                            Value = ChangeIndicatorDown.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChangeIndicatorDown.Width Units",
                            Type = "DimensionUnitType",
                            Value = ChangeIndicatorDown.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChangeIndicatorDown.X",
                            Type = "float",
                            Value = ChangeIndicatorDown.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChangeIndicatorDown.Y",
                            Type = "float",
                            Value = ChangeIndicatorDown.Y
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
                            Value = Height + 40f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Width",
                            Type = "float",
                            Value = Width + 180f
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
                            Name = "LabelInstance.Height",
                            Type = "float",
                            Value = LabelInstance.Height + 40f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LabelInstance.Width",
                            Type = "float",
                            Value = LabelInstance.Width + 100f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LabelInstance.X",
                            Type = "float",
                            Value = LabelInstance.X + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LabelInstance.X Origin",
                            Type = "HorizontalAlignment",
                            Value = LabelInstance.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LabelInstance.X Units",
                            Type = "PositionUnitType",
                            Value = LabelInstance.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LabelInstance.Y",
                            Type = "float",
                            Value = LabelInstance.Y + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Height",
                            Type = "float",
                            Value = SpriteInstance.Height + 40f
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
                            Name = "SpriteInstance.Texture Address",
                            Type = "TextureAddress",
                            Value = SpriteInstance.TextureAddress
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Width",
                            Type = "float",
                            Value = SpriteInstance.Width + 40f
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
                            Name = "ChangeIndicatorUp.Blue",
                            Type = "int",
                            Value = ChangeIndicatorUp.Blue + 34
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChangeIndicatorUp.Green",
                            Type = "int",
                            Value = ChangeIndicatorUp.Green + 139
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChangeIndicatorUp.Height",
                            Type = "float",
                            Value = ChangeIndicatorUp.Height + 40f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChangeIndicatorUp.Height Units",
                            Type = "DimensionUnitType",
                            Value = ChangeIndicatorUp.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChangeIndicatorUp.Red",
                            Type = "int",
                            Value = ChangeIndicatorUp.Red + 34
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChangeIndicatorUp.SourceFile",
                            Type = "string",
                            Value = ChangeIndicatorUp.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChangeIndicatorUp.Visible",
                            Type = "bool",
                            Value = ChangeIndicatorUp.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChangeIndicatorUp.Width",
                            Type = "float",
                            Value = ChangeIndicatorUp.Width + 40f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChangeIndicatorUp.Width Units",
                            Type = "DimensionUnitType",
                            Value = ChangeIndicatorUp.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChangeIndicatorUp.X",
                            Type = "float",
                            Value = ChangeIndicatorUp.X + 40f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChangeIndicatorUp.Y",
                            Type = "float",
                            Value = ChangeIndicatorUp.Y + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChangeIndicatorDown.Blue",
                            Type = "int",
                            Value = ChangeIndicatorDown.Blue + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChangeIndicatorDown.Green",
                            Type = "int",
                            Value = ChangeIndicatorDown.Green + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChangeIndicatorDown.Height",
                            Type = "float",
                            Value = ChangeIndicatorDown.Height + 40f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChangeIndicatorDown.Height Units",
                            Type = "DimensionUnitType",
                            Value = ChangeIndicatorDown.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChangeIndicatorDown.Red",
                            Type = "int",
                            Value = ChangeIndicatorDown.Red + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChangeIndicatorDown.SourceFile",
                            Type = "string",
                            Value = ChangeIndicatorDown.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChangeIndicatorDown.Visible",
                            Type = "bool",
                            Value = ChangeIndicatorDown.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChangeIndicatorDown.Width",
                            Type = "float",
                            Value = ChangeIndicatorDown.Width + 40f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChangeIndicatorDown.Width Units",
                            Type = "DimensionUnitType",
                            Value = ChangeIndicatorDown.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChangeIndicatorDown.X",
                            Type = "float",
                            Value = ChangeIndicatorDown.X + 40f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChangeIndicatorDown.Y",
                            Type = "float",
                            Value = ChangeIndicatorDown.Y + 0f
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
            public JHP4SD.GumRuntimes.DefaultForms.LabelRuntime LabelInstance { get; set; }
            public JHP4SD.GumRuntimes.SpriteRuntime SpriteInstance { get; set; }
            public JHP4SD.GumRuntimes.SpriteRuntime ChangeIndicatorUp { get; set; }
            public JHP4SD.GumRuntimes.SpriteRuntime ChangeIndicatorDown { get; set; }
            public Microsoft.Xna.Framework.Graphics.Texture2D SpriteInstanceSourceFile
            {
                get
                {
                    return SpriteInstance.SourceFile;
                }
                set
                {
                    if (SpriteInstance.SourceFile != value)
                    {
                        SpriteInstance.SourceFile = value;
                        SpriteInstanceSourceFileChanged?.Invoke(this, null);
                    }
                }
            }
            public Gum.Managers.TextureAddress ResourceIcon
            {
                get
                {
                    return SpriteInstance.TextureAddress;
                }
                set
                {
                    if (SpriteInstance.TextureAddress != value)
                    {
                        SpriteInstance.TextureAddress = value;
                        ResourceIconChanged?.Invoke(this, null);
                    }
                }
            }
            public event FlatRedBall.Gui.WindowEvent LabelInstanceClick;
            public event System.EventHandler SpriteInstanceSourceFileChanged;
            public event System.EventHandler ResourceIconChanged;
            public ResourceDisplayRuntime (bool fullInstantiation = true, bool tryCreateFormsObject = true) 
            	: base(false, tryCreateFormsObject)
            {
                this.tryCreateFormsObject = tryCreateFormsObject;
                if (fullInstantiation)
                {
                    Gum.DataTypes.ElementSave elementSave = Gum.Managers.ObjectFinder.Self.GumProjectSave.Components.First(item => item.Name == "LebegForms/BasicComponents/ResourceDisplay");
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
                LabelInstance = this.GetGraphicalUiElementByName("LabelInstance") as JHP4SD.GumRuntimes.DefaultForms.LabelRuntime;
                SpriteInstance = this.GetGraphicalUiElementByName("SpriteInstance") as JHP4SD.GumRuntimes.SpriteRuntime;
                ChangeIndicatorUp = this.GetGraphicalUiElementByName("ChangeIndicatorUp") as JHP4SD.GumRuntimes.SpriteRuntime;
                ChangeIndicatorDown = this.GetGraphicalUiElementByName("ChangeIndicatorDown") as JHP4SD.GumRuntimes.SpriteRuntime;
                LabelInstance.Click += (unused) => LabelInstanceClick?.Invoke(this);
                if (tryCreateFormsObject)
                {
                    FormsControlAsObject = new JHP4SD.FormsControls.Components.LebegForms.BasicComponents.ResourceDisplayForms(this);
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
            public JHP4SD.FormsControls.Components.LebegForms.BasicComponents.ResourceDisplayForms FormsControl {get => (JHP4SD.FormsControls.Components.LebegForms.BasicComponents.ResourceDisplayForms) FormsControlAsObject;}
        }
    }
