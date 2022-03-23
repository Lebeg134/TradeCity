    using System.Linq;
    namespace JHP4SD.GumRuntimes.LebegForms.Resources
    {
        public partial class BuildingImagesSmallRuntime : JHP4SD.GumRuntimes.ContainerRuntime
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
                            SteelForgeSprite.Parent = this.GetGraphicalUiElementByName("Common") ?? this;
                            CoalPowerplantSprite.Parent = this.GetGraphicalUiElementByName("Energy") ?? this;
                            Height = 96f;
                            SteelForgeSprite.Height = 87f;
                            SteelForgeSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                            SetProperty("SteelForgeSprite.SourceFile", "../GlobalContent/BuildingsSmall/SteelForge.png");
                            SteelForgeSprite.Width = 128f;
                            SteelForgeSprite.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                            SteelForgeSprite.X = 4f;
                            SteelForgeSprite.Y = 4f;
                            CoalPowerplantSprite.Height = 87f;
                            CoalPowerplantSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                            SetProperty("CoalPowerplantSprite.SourceFile", "../GlobalContent/BuildingsSmall/CoalPowerplant.png");
                            CoalPowerplantSprite.Width = 128f;
                            CoalPowerplantSprite.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                            CoalPowerplantSprite.X = 4f;
                            CoalPowerplantSprite.Y = 4f;
                            DefaultSprite.Height = 87f;
                            DefaultSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                            SetProperty("DefaultSprite.SourceFile", "../GlobalContent/BuildingsSmall/Default.png");
                            DefaultSprite.Width = 128f;
                            DefaultSprite.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                            DefaultSprite.X = 4f;
                            DefaultSprite.Y = 4f;
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
                bool setCoalPowerplantSpriteHeightFirstValue = false;
                bool setCoalPowerplantSpriteHeightSecondValue = false;
                float CoalPowerplantSpriteHeightFirstValue= 0;
                float CoalPowerplantSpriteHeightSecondValue= 0;
                bool setCoalPowerplantSpriteWidthFirstValue = false;
                bool setCoalPowerplantSpriteWidthSecondValue = false;
                float CoalPowerplantSpriteWidthFirstValue= 0;
                float CoalPowerplantSpriteWidthSecondValue= 0;
                bool setCoalPowerplantSpriteXFirstValue = false;
                bool setCoalPowerplantSpriteXSecondValue = false;
                float CoalPowerplantSpriteXFirstValue= 0;
                float CoalPowerplantSpriteXSecondValue= 0;
                bool setCoalPowerplantSpriteYFirstValue = false;
                bool setCoalPowerplantSpriteYSecondValue = false;
                float CoalPowerplantSpriteYFirstValue= 0;
                float CoalPowerplantSpriteYSecondValue= 0;
                bool setDefaultSpriteHeightFirstValue = false;
                bool setDefaultSpriteHeightSecondValue = false;
                float DefaultSpriteHeightFirstValue= 0;
                float DefaultSpriteHeightSecondValue= 0;
                bool setDefaultSpriteWidthFirstValue = false;
                bool setDefaultSpriteWidthSecondValue = false;
                float DefaultSpriteWidthFirstValue= 0;
                float DefaultSpriteWidthSecondValue= 0;
                bool setDefaultSpriteXFirstValue = false;
                bool setDefaultSpriteXSecondValue = false;
                float DefaultSpriteXFirstValue= 0;
                float DefaultSpriteXSecondValue= 0;
                bool setDefaultSpriteYFirstValue = false;
                bool setDefaultSpriteYSecondValue = false;
                float DefaultSpriteYFirstValue= 0;
                float DefaultSpriteYSecondValue= 0;
                bool setHeightFirstValue = false;
                bool setHeightSecondValue = false;
                float HeightFirstValue= 0;
                float HeightSecondValue= 0;
                bool setSteelForgeSpriteHeightFirstValue = false;
                bool setSteelForgeSpriteHeightSecondValue = false;
                float SteelForgeSpriteHeightFirstValue= 0;
                float SteelForgeSpriteHeightSecondValue= 0;
                bool setSteelForgeSpriteWidthFirstValue = false;
                bool setSteelForgeSpriteWidthSecondValue = false;
                float SteelForgeSpriteWidthFirstValue= 0;
                float SteelForgeSpriteWidthSecondValue= 0;
                bool setSteelForgeSpriteXFirstValue = false;
                bool setSteelForgeSpriteXSecondValue = false;
                float SteelForgeSpriteXFirstValue= 0;
                float SteelForgeSpriteXSecondValue= 0;
                bool setSteelForgeSpriteYFirstValue = false;
                bool setSteelForgeSpriteYSecondValue = false;
                float SteelForgeSpriteYFirstValue= 0;
                float SteelForgeSpriteYSecondValue= 0;
                switch(firstState)
                {
                    case  VariableState.Default:
                        setCoalPowerplantSpriteHeightFirstValue = true;
                        CoalPowerplantSpriteHeightFirstValue = 87f;
                        if (interpolationValue < 1)
                        {
                            this.CoalPowerplantSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        if (interpolationValue < 1)
                        {
                            this.CoalPowerplantSprite.Parent = this.GetGraphicalUiElementByName("Energy") ?? this;
                        }
                        if (interpolationValue < 1)
                        {
                            SetProperty("CoalPowerplantSprite.SourceFile", "../GlobalContent/BuildingsSmall/CoalPowerplant.png");
                        }
                        setCoalPowerplantSpriteWidthFirstValue = true;
                        CoalPowerplantSpriteWidthFirstValue = 128f;
                        if (interpolationValue < 1)
                        {
                            this.CoalPowerplantSprite.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        setCoalPowerplantSpriteXFirstValue = true;
                        CoalPowerplantSpriteXFirstValue = 4f;
                        setCoalPowerplantSpriteYFirstValue = true;
                        CoalPowerplantSpriteYFirstValue = 4f;
                        setDefaultSpriteHeightFirstValue = true;
                        DefaultSpriteHeightFirstValue = 87f;
                        if (interpolationValue < 1)
                        {
                            this.DefaultSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        if (interpolationValue < 1)
                        {
                            SetProperty("DefaultSprite.SourceFile", "../GlobalContent/BuildingsSmall/Default.png");
                        }
                        setDefaultSpriteWidthFirstValue = true;
                        DefaultSpriteWidthFirstValue = 128f;
                        if (interpolationValue < 1)
                        {
                            this.DefaultSprite.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        setDefaultSpriteXFirstValue = true;
                        DefaultSpriteXFirstValue = 4f;
                        setDefaultSpriteYFirstValue = true;
                        DefaultSpriteYFirstValue = 4f;
                        setHeightFirstValue = true;
                        HeightFirstValue = 96f;
                        setSteelForgeSpriteHeightFirstValue = true;
                        SteelForgeSpriteHeightFirstValue = 87f;
                        if (interpolationValue < 1)
                        {
                            this.SteelForgeSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        if (interpolationValue < 1)
                        {
                            this.SteelForgeSprite.Parent = this.GetGraphicalUiElementByName("Common") ?? this;
                        }
                        if (interpolationValue < 1)
                        {
                            SetProperty("SteelForgeSprite.SourceFile", "../GlobalContent/BuildingsSmall/SteelForge.png");
                        }
                        setSteelForgeSpriteWidthFirstValue = true;
                        SteelForgeSpriteWidthFirstValue = 128f;
                        if (interpolationValue < 1)
                        {
                            this.SteelForgeSprite.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        setSteelForgeSpriteXFirstValue = true;
                        SteelForgeSpriteXFirstValue = 4f;
                        setSteelForgeSpriteYFirstValue = true;
                        SteelForgeSpriteYFirstValue = 4f;
                        break;
                }
                switch(secondState)
                {
                    case  VariableState.Default:
                        setCoalPowerplantSpriteHeightSecondValue = true;
                        CoalPowerplantSpriteHeightSecondValue = 87f;
                        if (interpolationValue >= 1)
                        {
                            this.CoalPowerplantSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.CoalPowerplantSprite.Parent = this.GetGraphicalUiElementByName("Energy") ?? this;
                        }
                        if (interpolationValue >= 1)
                        {
                            SetProperty("CoalPowerplantSprite.SourceFile", "../GlobalContent/BuildingsSmall/CoalPowerplant.png");
                        }
                        setCoalPowerplantSpriteWidthSecondValue = true;
                        CoalPowerplantSpriteWidthSecondValue = 128f;
                        if (interpolationValue >= 1)
                        {
                            this.CoalPowerplantSprite.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        setCoalPowerplantSpriteXSecondValue = true;
                        CoalPowerplantSpriteXSecondValue = 4f;
                        setCoalPowerplantSpriteYSecondValue = true;
                        CoalPowerplantSpriteYSecondValue = 4f;
                        setDefaultSpriteHeightSecondValue = true;
                        DefaultSpriteHeightSecondValue = 87f;
                        if (interpolationValue >= 1)
                        {
                            this.DefaultSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        if (interpolationValue >= 1)
                        {
                            SetProperty("DefaultSprite.SourceFile", "../GlobalContent/BuildingsSmall/Default.png");
                        }
                        setDefaultSpriteWidthSecondValue = true;
                        DefaultSpriteWidthSecondValue = 128f;
                        if (interpolationValue >= 1)
                        {
                            this.DefaultSprite.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        setDefaultSpriteXSecondValue = true;
                        DefaultSpriteXSecondValue = 4f;
                        setDefaultSpriteYSecondValue = true;
                        DefaultSpriteYSecondValue = 4f;
                        setHeightSecondValue = true;
                        HeightSecondValue = 96f;
                        setSteelForgeSpriteHeightSecondValue = true;
                        SteelForgeSpriteHeightSecondValue = 87f;
                        if (interpolationValue >= 1)
                        {
                            this.SteelForgeSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.SteelForgeSprite.Parent = this.GetGraphicalUiElementByName("Common") ?? this;
                        }
                        if (interpolationValue >= 1)
                        {
                            SetProperty("SteelForgeSprite.SourceFile", "../GlobalContent/BuildingsSmall/SteelForge.png");
                        }
                        setSteelForgeSpriteWidthSecondValue = true;
                        SteelForgeSpriteWidthSecondValue = 128f;
                        if (interpolationValue >= 1)
                        {
                            this.SteelForgeSprite.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        setSteelForgeSpriteXSecondValue = true;
                        SteelForgeSpriteXSecondValue = 4f;
                        setSteelForgeSpriteYSecondValue = true;
                        SteelForgeSpriteYSecondValue = 4f;
                        break;
                }
                var wasSuppressed = mIsLayoutSuspended;
                if (wasSuppressed == false)
                {
                    SuspendLayout(true);
                }
                if (setCoalPowerplantSpriteHeightFirstValue && setCoalPowerplantSpriteHeightSecondValue)
                {
                    CoalPowerplantSprite.Height = CoalPowerplantSpriteHeightFirstValue * (1 - interpolationValue) + CoalPowerplantSpriteHeightSecondValue * interpolationValue;
                }
                if (setCoalPowerplantSpriteWidthFirstValue && setCoalPowerplantSpriteWidthSecondValue)
                {
                    CoalPowerplantSprite.Width = CoalPowerplantSpriteWidthFirstValue * (1 - interpolationValue) + CoalPowerplantSpriteWidthSecondValue * interpolationValue;
                }
                if (setCoalPowerplantSpriteXFirstValue && setCoalPowerplantSpriteXSecondValue)
                {
                    CoalPowerplantSprite.X = CoalPowerplantSpriteXFirstValue * (1 - interpolationValue) + CoalPowerplantSpriteXSecondValue * interpolationValue;
                }
                if (setCoalPowerplantSpriteYFirstValue && setCoalPowerplantSpriteYSecondValue)
                {
                    CoalPowerplantSprite.Y = CoalPowerplantSpriteYFirstValue * (1 - interpolationValue) + CoalPowerplantSpriteYSecondValue * interpolationValue;
                }
                if (setDefaultSpriteHeightFirstValue && setDefaultSpriteHeightSecondValue)
                {
                    DefaultSprite.Height = DefaultSpriteHeightFirstValue * (1 - interpolationValue) + DefaultSpriteHeightSecondValue * interpolationValue;
                }
                if (setDefaultSpriteWidthFirstValue && setDefaultSpriteWidthSecondValue)
                {
                    DefaultSprite.Width = DefaultSpriteWidthFirstValue * (1 - interpolationValue) + DefaultSpriteWidthSecondValue * interpolationValue;
                }
                if (setDefaultSpriteXFirstValue && setDefaultSpriteXSecondValue)
                {
                    DefaultSprite.X = DefaultSpriteXFirstValue * (1 - interpolationValue) + DefaultSpriteXSecondValue * interpolationValue;
                }
                if (setDefaultSpriteYFirstValue && setDefaultSpriteYSecondValue)
                {
                    DefaultSprite.Y = DefaultSpriteYFirstValue * (1 - interpolationValue) + DefaultSpriteYSecondValue * interpolationValue;
                }
                if (setHeightFirstValue && setHeightSecondValue)
                {
                    Height = HeightFirstValue * (1 - interpolationValue) + HeightSecondValue * interpolationValue;
                }
                if (setSteelForgeSpriteHeightFirstValue && setSteelForgeSpriteHeightSecondValue)
                {
                    SteelForgeSprite.Height = SteelForgeSpriteHeightFirstValue * (1 - interpolationValue) + SteelForgeSpriteHeightSecondValue * interpolationValue;
                }
                if (setSteelForgeSpriteWidthFirstValue && setSteelForgeSpriteWidthSecondValue)
                {
                    SteelForgeSprite.Width = SteelForgeSpriteWidthFirstValue * (1 - interpolationValue) + SteelForgeSpriteWidthSecondValue * interpolationValue;
                }
                if (setSteelForgeSpriteXFirstValue && setSteelForgeSpriteXSecondValue)
                {
                    SteelForgeSprite.X = SteelForgeSpriteXFirstValue * (1 - interpolationValue) + SteelForgeSpriteXSecondValue * interpolationValue;
                }
                if (setSteelForgeSpriteYFirstValue && setSteelForgeSpriteYSecondValue)
                {
                    SteelForgeSprite.Y = SteelForgeSpriteYFirstValue * (1 - interpolationValue) + SteelForgeSpriteYSecondValue * interpolationValue;
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
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (JHP4SD.GumRuntimes.LebegForms.Resources.BuildingImagesSmallRuntime.VariableState fromState,JHP4SD.GumRuntimes.LebegForms.Resources.BuildingImagesSmallRuntime.VariableState toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null) 
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
                            Name = "SteelForgeSprite.Height",
                            Type = "float",
                            Value = SteelForgeSprite.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SteelForgeSprite.Height Units",
                            Type = "DimensionUnitType",
                            Value = SteelForgeSprite.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SteelForgeSprite.Parent",
                            Type = "string",
                            Value = SteelForgeSprite.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SteelForgeSprite.SourceFile",
                            Type = "string",
                            Value = SteelForgeSprite.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SteelForgeSprite.Width",
                            Type = "float",
                            Value = SteelForgeSprite.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SteelForgeSprite.Width Units",
                            Type = "DimensionUnitType",
                            Value = SteelForgeSprite.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SteelForgeSprite.X",
                            Type = "float",
                            Value = SteelForgeSprite.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SteelForgeSprite.Y",
                            Type = "float",
                            Value = SteelForgeSprite.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CoalPowerplantSprite.Height",
                            Type = "float",
                            Value = CoalPowerplantSprite.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CoalPowerplantSprite.Height Units",
                            Type = "DimensionUnitType",
                            Value = CoalPowerplantSprite.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CoalPowerplantSprite.Parent",
                            Type = "string",
                            Value = CoalPowerplantSprite.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CoalPowerplantSprite.SourceFile",
                            Type = "string",
                            Value = CoalPowerplantSprite.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CoalPowerplantSprite.Width",
                            Type = "float",
                            Value = CoalPowerplantSprite.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CoalPowerplantSprite.Width Units",
                            Type = "DimensionUnitType",
                            Value = CoalPowerplantSprite.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CoalPowerplantSprite.X",
                            Type = "float",
                            Value = CoalPowerplantSprite.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CoalPowerplantSprite.Y",
                            Type = "float",
                            Value = CoalPowerplantSprite.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "DefaultSprite.Height",
                            Type = "float",
                            Value = DefaultSprite.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "DefaultSprite.Height Units",
                            Type = "DimensionUnitType",
                            Value = DefaultSprite.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "DefaultSprite.SourceFile",
                            Type = "string",
                            Value = DefaultSprite.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "DefaultSprite.Width",
                            Type = "float",
                            Value = DefaultSprite.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "DefaultSprite.Width Units",
                            Type = "DimensionUnitType",
                            Value = DefaultSprite.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "DefaultSprite.X",
                            Type = "float",
                            Value = DefaultSprite.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "DefaultSprite.Y",
                            Type = "float",
                            Value = DefaultSprite.Y
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
                            Value = Height + 96f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SteelForgeSprite.Height",
                            Type = "float",
                            Value = SteelForgeSprite.Height + 87f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SteelForgeSprite.Height Units",
                            Type = "DimensionUnitType",
                            Value = SteelForgeSprite.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SteelForgeSprite.Parent",
                            Type = "string",
                            Value = SteelForgeSprite.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SteelForgeSprite.SourceFile",
                            Type = "string",
                            Value = SteelForgeSprite.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SteelForgeSprite.Width",
                            Type = "float",
                            Value = SteelForgeSprite.Width + 128f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SteelForgeSprite.Width Units",
                            Type = "DimensionUnitType",
                            Value = SteelForgeSprite.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SteelForgeSprite.X",
                            Type = "float",
                            Value = SteelForgeSprite.X + 4f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SteelForgeSprite.Y",
                            Type = "float",
                            Value = SteelForgeSprite.Y + 4f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CoalPowerplantSprite.Height",
                            Type = "float",
                            Value = CoalPowerplantSprite.Height + 87f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CoalPowerplantSprite.Height Units",
                            Type = "DimensionUnitType",
                            Value = CoalPowerplantSprite.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CoalPowerplantSprite.Parent",
                            Type = "string",
                            Value = CoalPowerplantSprite.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CoalPowerplantSprite.SourceFile",
                            Type = "string",
                            Value = CoalPowerplantSprite.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CoalPowerplantSprite.Width",
                            Type = "float",
                            Value = CoalPowerplantSprite.Width + 128f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CoalPowerplantSprite.Width Units",
                            Type = "DimensionUnitType",
                            Value = CoalPowerplantSprite.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CoalPowerplantSprite.X",
                            Type = "float",
                            Value = CoalPowerplantSprite.X + 4f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CoalPowerplantSprite.Y",
                            Type = "float",
                            Value = CoalPowerplantSprite.Y + 4f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "DefaultSprite.Height",
                            Type = "float",
                            Value = DefaultSprite.Height + 87f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "DefaultSprite.Height Units",
                            Type = "DimensionUnitType",
                            Value = DefaultSprite.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "DefaultSprite.SourceFile",
                            Type = "string",
                            Value = DefaultSprite.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "DefaultSprite.Width",
                            Type = "float",
                            Value = DefaultSprite.Width + 128f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "DefaultSprite.Width Units",
                            Type = "DimensionUnitType",
                            Value = DefaultSprite.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "DefaultSprite.X",
                            Type = "float",
                            Value = DefaultSprite.X + 4f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "DefaultSprite.Y",
                            Type = "float",
                            Value = DefaultSprite.Y + 4f
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
            public JHP4SD.GumRuntimes.SpriteRuntime SteelForgeSprite { get; set; }
            public JHP4SD.GumRuntimes.SpriteRuntime CoalPowerplantSprite { get; set; }
            public JHP4SD.GumRuntimes.SpriteRuntime DefaultSprite { get; set; }
            public JHP4SD.GumRuntimes.ContainerRuntime Common { get; set; }
            public JHP4SD.GumRuntimes.ContainerRuntime Construction { get; set; }
            public JHP4SD.GumRuntimes.ContainerRuntime Energy { get; set; }
            public JHP4SD.GumRuntimes.ContainerRuntime Oil { get; set; }
            public JHP4SD.GumRuntimes.ContainerRuntime Workforce { get; set; }
            public BuildingImagesSmallRuntime (bool fullInstantiation = true, bool tryCreateFormsObject = true) 
            	: base(false, tryCreateFormsObject)
            {
                if (fullInstantiation)
                {
                    Gum.DataTypes.ElementSave elementSave = Gum.Managers.ObjectFinder.Self.GumProjectSave.Components.First(item => item.Name == "LebegForms/Resources/BuildingImagesSmall");
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
                SteelForgeSprite = this.GetGraphicalUiElementByName("SteelForgeSprite") as JHP4SD.GumRuntimes.SpriteRuntime;
                CoalPowerplantSprite = this.GetGraphicalUiElementByName("CoalPowerplantSprite") as JHP4SD.GumRuntimes.SpriteRuntime;
                DefaultSprite = this.GetGraphicalUiElementByName("DefaultSprite") as JHP4SD.GumRuntimes.SpriteRuntime;
                Common = this.GetGraphicalUiElementByName("Common") as JHP4SD.GumRuntimes.ContainerRuntime;
                Construction = this.GetGraphicalUiElementByName("Construction") as JHP4SD.GumRuntimes.ContainerRuntime;
                Energy = this.GetGraphicalUiElementByName("Energy") as JHP4SD.GumRuntimes.ContainerRuntime;
                Oil = this.GetGraphicalUiElementByName("Oil") as JHP4SD.GumRuntimes.ContainerRuntime;
                Workforce = this.GetGraphicalUiElementByName("Workforce") as JHP4SD.GumRuntimes.ContainerRuntime;
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
