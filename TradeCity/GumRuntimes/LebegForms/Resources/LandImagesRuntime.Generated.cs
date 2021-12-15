    using System.Linq;
    namespace JHP4SD.GumRuntimes.LebegForms.Resources
    {
        public partial class LandImagesRuntime : JHP4SD.GumRuntimes.ContainerRuntime
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
                            ForestSprite.Height = 150f;
                            ForestSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                            SetProperty("ForestSprite.SourceFile", "../GlobalContent/Lands/Forest.png");
                            ForestSprite.Width = 292f;
                            ForestSprite.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                            ForestSprite.X = 4f;
                            ForestSprite.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                            ForestSprite.XUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                            ForestSprite.Y = 3f;
                            IronMineSprite.Height = 150f;
                            IronMineSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                            SetProperty("IronMineSprite.SourceFile", "../GlobalContent/Lands/IronMine.png");
                            IronMineSprite.Width = 292f;
                            IronMineSprite.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                            IronMineSprite.X = 4f;
                            IronMineSprite.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                            IronMineSprite.XUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                            IronMineSprite.Y = 3f;
                            CoalMineSprite.Height = 150f;
                            CoalMineSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                            SetProperty("CoalMineSprite.SourceFile", "../GlobalContent/Lands/CoalMine.png");
                            CoalMineSprite.Width = 292f;
                            CoalMineSprite.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                            CoalMineSprite.X = 4f;
                            CoalMineSprite.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                            CoalMineSprite.XUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                            CoalMineSprite.Y = 3f;
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
                bool setCoalMineSpriteHeightFirstValue = false;
                bool setCoalMineSpriteHeightSecondValue = false;
                float CoalMineSpriteHeightFirstValue= 0;
                float CoalMineSpriteHeightSecondValue= 0;
                bool setCoalMineSpriteWidthFirstValue = false;
                bool setCoalMineSpriteWidthSecondValue = false;
                float CoalMineSpriteWidthFirstValue= 0;
                float CoalMineSpriteWidthSecondValue= 0;
                bool setCoalMineSpriteXFirstValue = false;
                bool setCoalMineSpriteXSecondValue = false;
                float CoalMineSpriteXFirstValue= 0;
                float CoalMineSpriteXSecondValue= 0;
                bool setCoalMineSpriteYFirstValue = false;
                bool setCoalMineSpriteYSecondValue = false;
                float CoalMineSpriteYFirstValue= 0;
                float CoalMineSpriteYSecondValue= 0;
                bool setForestSpriteHeightFirstValue = false;
                bool setForestSpriteHeightSecondValue = false;
                float ForestSpriteHeightFirstValue= 0;
                float ForestSpriteHeightSecondValue= 0;
                bool setForestSpriteWidthFirstValue = false;
                bool setForestSpriteWidthSecondValue = false;
                float ForestSpriteWidthFirstValue= 0;
                float ForestSpriteWidthSecondValue= 0;
                bool setForestSpriteXFirstValue = false;
                bool setForestSpriteXSecondValue = false;
                float ForestSpriteXFirstValue= 0;
                float ForestSpriteXSecondValue= 0;
                bool setForestSpriteYFirstValue = false;
                bool setForestSpriteYSecondValue = false;
                float ForestSpriteYFirstValue= 0;
                float ForestSpriteYSecondValue= 0;
                bool setIronMineSpriteHeightFirstValue = false;
                bool setIronMineSpriteHeightSecondValue = false;
                float IronMineSpriteHeightFirstValue= 0;
                float IronMineSpriteHeightSecondValue= 0;
                bool setIronMineSpriteWidthFirstValue = false;
                bool setIronMineSpriteWidthSecondValue = false;
                float IronMineSpriteWidthFirstValue= 0;
                float IronMineSpriteWidthSecondValue= 0;
                bool setIronMineSpriteXFirstValue = false;
                bool setIronMineSpriteXSecondValue = false;
                float IronMineSpriteXFirstValue= 0;
                float IronMineSpriteXSecondValue= 0;
                bool setIronMineSpriteYFirstValue = false;
                bool setIronMineSpriteYSecondValue = false;
                float IronMineSpriteYFirstValue= 0;
                float IronMineSpriteYSecondValue= 0;
                switch(firstState)
                {
                    case  VariableState.Default:
                        setCoalMineSpriteHeightFirstValue = true;
                        CoalMineSpriteHeightFirstValue = 150f;
                        if (interpolationValue < 1)
                        {
                            this.CoalMineSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        if (interpolationValue < 1)
                        {
                            SetProperty("CoalMineSprite.SourceFile", "../GlobalContent/Lands/CoalMine.png");
                        }
                        setCoalMineSpriteWidthFirstValue = true;
                        CoalMineSpriteWidthFirstValue = 292f;
                        if (interpolationValue < 1)
                        {
                            this.CoalMineSprite.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        setCoalMineSpriteXFirstValue = true;
                        CoalMineSpriteXFirstValue = 4f;
                        if (interpolationValue < 1)
                        {
                            this.CoalMineSprite.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                        }
                        if (interpolationValue < 1)
                        {
                            this.CoalMineSprite.XUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                        }
                        setCoalMineSpriteYFirstValue = true;
                        CoalMineSpriteYFirstValue = 3f;
                        setForestSpriteHeightFirstValue = true;
                        ForestSpriteHeightFirstValue = 150f;
                        if (interpolationValue < 1)
                        {
                            this.ForestSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        if (interpolationValue < 1)
                        {
                            SetProperty("ForestSprite.SourceFile", "../GlobalContent/Lands/Forest.png");
                        }
                        setForestSpriteWidthFirstValue = true;
                        ForestSpriteWidthFirstValue = 292f;
                        if (interpolationValue < 1)
                        {
                            this.ForestSprite.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        setForestSpriteXFirstValue = true;
                        ForestSpriteXFirstValue = 4f;
                        if (interpolationValue < 1)
                        {
                            this.ForestSprite.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                        }
                        if (interpolationValue < 1)
                        {
                            this.ForestSprite.XUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                        }
                        setForestSpriteYFirstValue = true;
                        ForestSpriteYFirstValue = 3f;
                        setIronMineSpriteHeightFirstValue = true;
                        IronMineSpriteHeightFirstValue = 150f;
                        if (interpolationValue < 1)
                        {
                            this.IronMineSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        if (interpolationValue < 1)
                        {
                            SetProperty("IronMineSprite.SourceFile", "../GlobalContent/Lands/IronMine.png");
                        }
                        setIronMineSpriteWidthFirstValue = true;
                        IronMineSpriteWidthFirstValue = 292f;
                        if (interpolationValue < 1)
                        {
                            this.IronMineSprite.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        setIronMineSpriteXFirstValue = true;
                        IronMineSpriteXFirstValue = 4f;
                        if (interpolationValue < 1)
                        {
                            this.IronMineSprite.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                        }
                        if (interpolationValue < 1)
                        {
                            this.IronMineSprite.XUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                        }
                        setIronMineSpriteYFirstValue = true;
                        IronMineSpriteYFirstValue = 3f;
                        break;
                }
                switch(secondState)
                {
                    case  VariableState.Default:
                        setCoalMineSpriteHeightSecondValue = true;
                        CoalMineSpriteHeightSecondValue = 150f;
                        if (interpolationValue >= 1)
                        {
                            this.CoalMineSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        if (interpolationValue >= 1)
                        {
                            SetProperty("CoalMineSprite.SourceFile", "../GlobalContent/Lands/CoalMine.png");
                        }
                        setCoalMineSpriteWidthSecondValue = true;
                        CoalMineSpriteWidthSecondValue = 292f;
                        if (interpolationValue >= 1)
                        {
                            this.CoalMineSprite.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        setCoalMineSpriteXSecondValue = true;
                        CoalMineSpriteXSecondValue = 4f;
                        if (interpolationValue >= 1)
                        {
                            this.CoalMineSprite.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.CoalMineSprite.XUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                        }
                        setCoalMineSpriteYSecondValue = true;
                        CoalMineSpriteYSecondValue = 3f;
                        setForestSpriteHeightSecondValue = true;
                        ForestSpriteHeightSecondValue = 150f;
                        if (interpolationValue >= 1)
                        {
                            this.ForestSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        if (interpolationValue >= 1)
                        {
                            SetProperty("ForestSprite.SourceFile", "../GlobalContent/Lands/Forest.png");
                        }
                        setForestSpriteWidthSecondValue = true;
                        ForestSpriteWidthSecondValue = 292f;
                        if (interpolationValue >= 1)
                        {
                            this.ForestSprite.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        setForestSpriteXSecondValue = true;
                        ForestSpriteXSecondValue = 4f;
                        if (interpolationValue >= 1)
                        {
                            this.ForestSprite.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.ForestSprite.XUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                        }
                        setForestSpriteYSecondValue = true;
                        ForestSpriteYSecondValue = 3f;
                        setIronMineSpriteHeightSecondValue = true;
                        IronMineSpriteHeightSecondValue = 150f;
                        if (interpolationValue >= 1)
                        {
                            this.IronMineSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        if (interpolationValue >= 1)
                        {
                            SetProperty("IronMineSprite.SourceFile", "../GlobalContent/Lands/IronMine.png");
                        }
                        setIronMineSpriteWidthSecondValue = true;
                        IronMineSpriteWidthSecondValue = 292f;
                        if (interpolationValue >= 1)
                        {
                            this.IronMineSprite.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        setIronMineSpriteXSecondValue = true;
                        IronMineSpriteXSecondValue = 4f;
                        if (interpolationValue >= 1)
                        {
                            this.IronMineSprite.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.IronMineSprite.XUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                        }
                        setIronMineSpriteYSecondValue = true;
                        IronMineSpriteYSecondValue = 3f;
                        break;
                }
                var wasSuppressed = mIsLayoutSuspended;
                if (wasSuppressed == false)
                {
                    SuspendLayout(true);
                }
                if (setCoalMineSpriteHeightFirstValue && setCoalMineSpriteHeightSecondValue)
                {
                    CoalMineSprite.Height = CoalMineSpriteHeightFirstValue * (1 - interpolationValue) + CoalMineSpriteHeightSecondValue * interpolationValue;
                }
                if (setCoalMineSpriteWidthFirstValue && setCoalMineSpriteWidthSecondValue)
                {
                    CoalMineSprite.Width = CoalMineSpriteWidthFirstValue * (1 - interpolationValue) + CoalMineSpriteWidthSecondValue * interpolationValue;
                }
                if (setCoalMineSpriteXFirstValue && setCoalMineSpriteXSecondValue)
                {
                    CoalMineSprite.X = CoalMineSpriteXFirstValue * (1 - interpolationValue) + CoalMineSpriteXSecondValue * interpolationValue;
                }
                if (setCoalMineSpriteYFirstValue && setCoalMineSpriteYSecondValue)
                {
                    CoalMineSprite.Y = CoalMineSpriteYFirstValue * (1 - interpolationValue) + CoalMineSpriteYSecondValue * interpolationValue;
                }
                if (setForestSpriteHeightFirstValue && setForestSpriteHeightSecondValue)
                {
                    ForestSprite.Height = ForestSpriteHeightFirstValue * (1 - interpolationValue) + ForestSpriteHeightSecondValue * interpolationValue;
                }
                if (setForestSpriteWidthFirstValue && setForestSpriteWidthSecondValue)
                {
                    ForestSprite.Width = ForestSpriteWidthFirstValue * (1 - interpolationValue) + ForestSpriteWidthSecondValue * interpolationValue;
                }
                if (setForestSpriteXFirstValue && setForestSpriteXSecondValue)
                {
                    ForestSprite.X = ForestSpriteXFirstValue * (1 - interpolationValue) + ForestSpriteXSecondValue * interpolationValue;
                }
                if (setForestSpriteYFirstValue && setForestSpriteYSecondValue)
                {
                    ForestSprite.Y = ForestSpriteYFirstValue * (1 - interpolationValue) + ForestSpriteYSecondValue * interpolationValue;
                }
                if (setIronMineSpriteHeightFirstValue && setIronMineSpriteHeightSecondValue)
                {
                    IronMineSprite.Height = IronMineSpriteHeightFirstValue * (1 - interpolationValue) + IronMineSpriteHeightSecondValue * interpolationValue;
                }
                if (setIronMineSpriteWidthFirstValue && setIronMineSpriteWidthSecondValue)
                {
                    IronMineSprite.Width = IronMineSpriteWidthFirstValue * (1 - interpolationValue) + IronMineSpriteWidthSecondValue * interpolationValue;
                }
                if (setIronMineSpriteXFirstValue && setIronMineSpriteXSecondValue)
                {
                    IronMineSprite.X = IronMineSpriteXFirstValue * (1 - interpolationValue) + IronMineSpriteXSecondValue * interpolationValue;
                }
                if (setIronMineSpriteYFirstValue && setIronMineSpriteYSecondValue)
                {
                    IronMineSprite.Y = IronMineSpriteYFirstValue * (1 - interpolationValue) + IronMineSpriteYSecondValue * interpolationValue;
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
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (JHP4SD.GumRuntimes.LebegForms.Resources.LandImagesRuntime.VariableState fromState,JHP4SD.GumRuntimes.LebegForms.Resources.LandImagesRuntime.VariableState toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null) 
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
                            Name = "ForestSprite.Height",
                            Type = "float",
                            Value = ForestSprite.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ForestSprite.Height Units",
                            Type = "DimensionUnitType",
                            Value = ForestSprite.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ForestSprite.SourceFile",
                            Type = "string",
                            Value = ForestSprite.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ForestSprite.Width",
                            Type = "float",
                            Value = ForestSprite.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ForestSprite.Width Units",
                            Type = "DimensionUnitType",
                            Value = ForestSprite.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ForestSprite.X",
                            Type = "float",
                            Value = ForestSprite.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ForestSprite.X Origin",
                            Type = "HorizontalAlignment",
                            Value = ForestSprite.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ForestSprite.X Units",
                            Type = "PositionUnitType",
                            Value = ForestSprite.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ForestSprite.Y",
                            Type = "float",
                            Value = ForestSprite.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "IronMineSprite.Height",
                            Type = "float",
                            Value = IronMineSprite.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "IronMineSprite.Height Units",
                            Type = "DimensionUnitType",
                            Value = IronMineSprite.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "IronMineSprite.SourceFile",
                            Type = "string",
                            Value = IronMineSprite.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "IronMineSprite.Width",
                            Type = "float",
                            Value = IronMineSprite.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "IronMineSprite.Width Units",
                            Type = "DimensionUnitType",
                            Value = IronMineSprite.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "IronMineSprite.X",
                            Type = "float",
                            Value = IronMineSprite.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "IronMineSprite.X Origin",
                            Type = "HorizontalAlignment",
                            Value = IronMineSprite.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "IronMineSprite.X Units",
                            Type = "PositionUnitType",
                            Value = IronMineSprite.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "IronMineSprite.Y",
                            Type = "float",
                            Value = IronMineSprite.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CoalMineSprite.Height",
                            Type = "float",
                            Value = CoalMineSprite.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CoalMineSprite.Height Units",
                            Type = "DimensionUnitType",
                            Value = CoalMineSprite.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CoalMineSprite.SourceFile",
                            Type = "string",
                            Value = CoalMineSprite.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CoalMineSprite.Width",
                            Type = "float",
                            Value = CoalMineSprite.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CoalMineSprite.Width Units",
                            Type = "DimensionUnitType",
                            Value = CoalMineSprite.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CoalMineSprite.X",
                            Type = "float",
                            Value = CoalMineSprite.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CoalMineSprite.X Origin",
                            Type = "HorizontalAlignment",
                            Value = CoalMineSprite.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CoalMineSprite.X Units",
                            Type = "PositionUnitType",
                            Value = CoalMineSprite.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CoalMineSprite.Y",
                            Type = "float",
                            Value = CoalMineSprite.Y
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
                            Name = "ForestSprite.Height",
                            Type = "float",
                            Value = ForestSprite.Height + 150f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ForestSprite.Height Units",
                            Type = "DimensionUnitType",
                            Value = ForestSprite.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ForestSprite.SourceFile",
                            Type = "string",
                            Value = ForestSprite.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ForestSprite.Width",
                            Type = "float",
                            Value = ForestSprite.Width + 292f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ForestSprite.Width Units",
                            Type = "DimensionUnitType",
                            Value = ForestSprite.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ForestSprite.X",
                            Type = "float",
                            Value = ForestSprite.X + 4f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ForestSprite.X Origin",
                            Type = "HorizontalAlignment",
                            Value = ForestSprite.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ForestSprite.X Units",
                            Type = "PositionUnitType",
                            Value = ForestSprite.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ForestSprite.Y",
                            Type = "float",
                            Value = ForestSprite.Y + 3f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "IronMineSprite.Height",
                            Type = "float",
                            Value = IronMineSprite.Height + 150f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "IronMineSprite.Height Units",
                            Type = "DimensionUnitType",
                            Value = IronMineSprite.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "IronMineSprite.SourceFile",
                            Type = "string",
                            Value = IronMineSprite.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "IronMineSprite.Width",
                            Type = "float",
                            Value = IronMineSprite.Width + 292f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "IronMineSprite.Width Units",
                            Type = "DimensionUnitType",
                            Value = IronMineSprite.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "IronMineSprite.X",
                            Type = "float",
                            Value = IronMineSprite.X + 4f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "IronMineSprite.X Origin",
                            Type = "HorizontalAlignment",
                            Value = IronMineSprite.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "IronMineSprite.X Units",
                            Type = "PositionUnitType",
                            Value = IronMineSprite.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "IronMineSprite.Y",
                            Type = "float",
                            Value = IronMineSprite.Y + 3f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CoalMineSprite.Height",
                            Type = "float",
                            Value = CoalMineSprite.Height + 150f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CoalMineSprite.Height Units",
                            Type = "DimensionUnitType",
                            Value = CoalMineSprite.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CoalMineSprite.SourceFile",
                            Type = "string",
                            Value = CoalMineSprite.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CoalMineSprite.Width",
                            Type = "float",
                            Value = CoalMineSprite.Width + 292f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CoalMineSprite.Width Units",
                            Type = "DimensionUnitType",
                            Value = CoalMineSprite.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CoalMineSprite.X",
                            Type = "float",
                            Value = CoalMineSprite.X + 4f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CoalMineSprite.X Origin",
                            Type = "HorizontalAlignment",
                            Value = CoalMineSprite.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CoalMineSprite.X Units",
                            Type = "PositionUnitType",
                            Value = CoalMineSprite.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CoalMineSprite.Y",
                            Type = "float",
                            Value = CoalMineSprite.Y + 3f
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
            public JHP4SD.GumRuntimes.SpriteRuntime ForestSprite { get; set; }
            public JHP4SD.GumRuntimes.SpriteRuntime IronMineSprite { get; set; }
            public JHP4SD.GumRuntimes.SpriteRuntime CoalMineSprite { get; set; }
            public LandImagesRuntime (bool fullInstantiation = true, bool tryCreateFormsObject = true) 
            	: base(false, tryCreateFormsObject)
            {
                if (fullInstantiation)
                {
                    Gum.DataTypes.ElementSave elementSave = Gum.Managers.ObjectFinder.Self.GumProjectSave.Components.First(item => item.Name == "LebegForms/Resources/LandImages");
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
                ForestSprite = this.GetGraphicalUiElementByName("ForestSprite") as JHP4SD.GumRuntimes.SpriteRuntime;
                IronMineSprite = this.GetGraphicalUiElementByName("IronMineSprite") as JHP4SD.GumRuntimes.SpriteRuntime;
                CoalMineSprite = this.GetGraphicalUiElementByName("CoalMineSprite") as JHP4SD.GumRuntimes.SpriteRuntime;
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
