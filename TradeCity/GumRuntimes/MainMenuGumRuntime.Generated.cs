    using System.Linq;
    namespace JHP4SD.GumRuntimes
    {
        public partial class MainMenuGumRuntime : Gum.Wireframe.GraphicalUiElement
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
                            ButtonInstance.Height = 50f;
                            ButtonInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                            ButtonInstance.Width = 50f;
                            ButtonInstance.X = 0f;
                            ButtonInstance.Y = 0f;
                            ButtonInstance2.Height = 50f;
                            ButtonInstance2.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                            ButtonInstance2.Width = 50f;
                            ButtonInstance2.X = 910f;
                            ButtonInstance2.Y = 490f;
                            ButtonInstance3.Height = 50f;
                            ButtonInstance3.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                            ButtonInstance3.Width = 50f;
                            ButtonInstance3.X = -910f;
                            ButtonInstance3.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                            ButtonInstance3.XUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                            ButtonInstance3.Y = -490f;
                            ButtonInstance3.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Bottom;
                            ButtonInstance3.YUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                            ButtonInstance1.Height = 50f;
                            ButtonInstance1.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                            ButtonInstance1.Width = 50f;
                            ButtonInstance1.X = 0f;
                            ButtonInstance1.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                            ButtonInstance1.XUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                            ButtonInstance1.Y = 0f;
                            ButtonInstance1.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Bottom;
                            ButtonInstance1.YUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
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
                bool setButtonInstanceHeightFirstValue = false;
                bool setButtonInstanceHeightSecondValue = false;
                float ButtonInstanceHeightFirstValue= 0;
                float ButtonInstanceHeightSecondValue= 0;
                bool setButtonInstanceWidthFirstValue = false;
                bool setButtonInstanceWidthSecondValue = false;
                float ButtonInstanceWidthFirstValue= 0;
                float ButtonInstanceWidthSecondValue= 0;
                bool setButtonInstanceXFirstValue = false;
                bool setButtonInstanceXSecondValue = false;
                float ButtonInstanceXFirstValue= 0;
                float ButtonInstanceXSecondValue= 0;
                bool setButtonInstanceYFirstValue = false;
                bool setButtonInstanceYSecondValue = false;
                float ButtonInstanceYFirstValue= 0;
                float ButtonInstanceYSecondValue= 0;
                bool setButtonInstance1HeightFirstValue = false;
                bool setButtonInstance1HeightSecondValue = false;
                float ButtonInstance1HeightFirstValue= 0;
                float ButtonInstance1HeightSecondValue= 0;
                bool setButtonInstance1WidthFirstValue = false;
                bool setButtonInstance1WidthSecondValue = false;
                float ButtonInstance1WidthFirstValue= 0;
                float ButtonInstance1WidthSecondValue= 0;
                bool setButtonInstance1XFirstValue = false;
                bool setButtonInstance1XSecondValue = false;
                float ButtonInstance1XFirstValue= 0;
                float ButtonInstance1XSecondValue= 0;
                bool setButtonInstance1YFirstValue = false;
                bool setButtonInstance1YSecondValue = false;
                float ButtonInstance1YFirstValue= 0;
                float ButtonInstance1YSecondValue= 0;
                bool setButtonInstance2HeightFirstValue = false;
                bool setButtonInstance2HeightSecondValue = false;
                float ButtonInstance2HeightFirstValue= 0;
                float ButtonInstance2HeightSecondValue= 0;
                bool setButtonInstance2WidthFirstValue = false;
                bool setButtonInstance2WidthSecondValue = false;
                float ButtonInstance2WidthFirstValue= 0;
                float ButtonInstance2WidthSecondValue= 0;
                bool setButtonInstance2XFirstValue = false;
                bool setButtonInstance2XSecondValue = false;
                float ButtonInstance2XFirstValue= 0;
                float ButtonInstance2XSecondValue= 0;
                bool setButtonInstance2YFirstValue = false;
                bool setButtonInstance2YSecondValue = false;
                float ButtonInstance2YFirstValue= 0;
                float ButtonInstance2YSecondValue= 0;
                bool setButtonInstance3HeightFirstValue = false;
                bool setButtonInstance3HeightSecondValue = false;
                float ButtonInstance3HeightFirstValue= 0;
                float ButtonInstance3HeightSecondValue= 0;
                bool setButtonInstance3WidthFirstValue = false;
                bool setButtonInstance3WidthSecondValue = false;
                float ButtonInstance3WidthFirstValue= 0;
                float ButtonInstance3WidthSecondValue= 0;
                bool setButtonInstance3XFirstValue = false;
                bool setButtonInstance3XSecondValue = false;
                float ButtonInstance3XFirstValue= 0;
                float ButtonInstance3XSecondValue= 0;
                bool setButtonInstance3YFirstValue = false;
                bool setButtonInstance3YSecondValue = false;
                float ButtonInstance3YFirstValue= 0;
                float ButtonInstance3YSecondValue= 0;
                switch(firstState)
                {
                    case  VariableState.Default:
                        setButtonInstanceHeightFirstValue = true;
                        ButtonInstanceHeightFirstValue = 50f;
                        if (interpolationValue < 1)
                        {
                            this.ButtonInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        setButtonInstanceWidthFirstValue = true;
                        ButtonInstanceWidthFirstValue = 50f;
                        setButtonInstanceXFirstValue = true;
                        ButtonInstanceXFirstValue = 0f;
                        setButtonInstanceYFirstValue = true;
                        ButtonInstanceYFirstValue = 0f;
                        setButtonInstance1HeightFirstValue = true;
                        ButtonInstance1HeightFirstValue = 50f;
                        if (interpolationValue < 1)
                        {
                            this.ButtonInstance1.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        setButtonInstance1WidthFirstValue = true;
                        ButtonInstance1WidthFirstValue = 50f;
                        setButtonInstance1XFirstValue = true;
                        ButtonInstance1XFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.ButtonInstance1.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                        }
                        if (interpolationValue < 1)
                        {
                            this.ButtonInstance1.XUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                        }
                        setButtonInstance1YFirstValue = true;
                        ButtonInstance1YFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.ButtonInstance1.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Bottom;
                        }
                        if (interpolationValue < 1)
                        {
                            this.ButtonInstance1.YUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                        }
                        setButtonInstance2HeightFirstValue = true;
                        ButtonInstance2HeightFirstValue = 50f;
                        if (interpolationValue < 1)
                        {
                            this.ButtonInstance2.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        setButtonInstance2WidthFirstValue = true;
                        ButtonInstance2WidthFirstValue = 50f;
                        setButtonInstance2XFirstValue = true;
                        ButtonInstance2XFirstValue = 910f;
                        setButtonInstance2YFirstValue = true;
                        ButtonInstance2YFirstValue = 490f;
                        setButtonInstance3HeightFirstValue = true;
                        ButtonInstance3HeightFirstValue = 50f;
                        if (interpolationValue < 1)
                        {
                            this.ButtonInstance3.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        setButtonInstance3WidthFirstValue = true;
                        ButtonInstance3WidthFirstValue = 50f;
                        setButtonInstance3XFirstValue = true;
                        ButtonInstance3XFirstValue = -910f;
                        if (interpolationValue < 1)
                        {
                            this.ButtonInstance3.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                        }
                        if (interpolationValue < 1)
                        {
                            this.ButtonInstance3.XUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                        }
                        setButtonInstance3YFirstValue = true;
                        ButtonInstance3YFirstValue = -490f;
                        if (interpolationValue < 1)
                        {
                            this.ButtonInstance3.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Bottom;
                        }
                        if (interpolationValue < 1)
                        {
                            this.ButtonInstance3.YUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                        }
                        break;
                }
                switch(secondState)
                {
                    case  VariableState.Default:
                        setButtonInstanceHeightSecondValue = true;
                        ButtonInstanceHeightSecondValue = 50f;
                        if (interpolationValue >= 1)
                        {
                            this.ButtonInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        setButtonInstanceWidthSecondValue = true;
                        ButtonInstanceWidthSecondValue = 50f;
                        setButtonInstanceXSecondValue = true;
                        ButtonInstanceXSecondValue = 0f;
                        setButtonInstanceYSecondValue = true;
                        ButtonInstanceYSecondValue = 0f;
                        setButtonInstance1HeightSecondValue = true;
                        ButtonInstance1HeightSecondValue = 50f;
                        if (interpolationValue >= 1)
                        {
                            this.ButtonInstance1.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        setButtonInstance1WidthSecondValue = true;
                        ButtonInstance1WidthSecondValue = 50f;
                        setButtonInstance1XSecondValue = true;
                        ButtonInstance1XSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.ButtonInstance1.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.ButtonInstance1.XUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                        }
                        setButtonInstance1YSecondValue = true;
                        ButtonInstance1YSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.ButtonInstance1.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Bottom;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.ButtonInstance1.YUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                        }
                        setButtonInstance2HeightSecondValue = true;
                        ButtonInstance2HeightSecondValue = 50f;
                        if (interpolationValue >= 1)
                        {
                            this.ButtonInstance2.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        setButtonInstance2WidthSecondValue = true;
                        ButtonInstance2WidthSecondValue = 50f;
                        setButtonInstance2XSecondValue = true;
                        ButtonInstance2XSecondValue = 910f;
                        setButtonInstance2YSecondValue = true;
                        ButtonInstance2YSecondValue = 490f;
                        setButtonInstance3HeightSecondValue = true;
                        ButtonInstance3HeightSecondValue = 50f;
                        if (interpolationValue >= 1)
                        {
                            this.ButtonInstance3.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        setButtonInstance3WidthSecondValue = true;
                        ButtonInstance3WidthSecondValue = 50f;
                        setButtonInstance3XSecondValue = true;
                        ButtonInstance3XSecondValue = -910f;
                        if (interpolationValue >= 1)
                        {
                            this.ButtonInstance3.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.ButtonInstance3.XUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                        }
                        setButtonInstance3YSecondValue = true;
                        ButtonInstance3YSecondValue = -490f;
                        if (interpolationValue >= 1)
                        {
                            this.ButtonInstance3.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Bottom;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.ButtonInstance3.YUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                        }
                        break;
                }
                var wasSuppressed = mIsLayoutSuspended;
                if (wasSuppressed == false)
                {
                    SuspendLayout(true);
                }
                if (setButtonInstanceHeightFirstValue && setButtonInstanceHeightSecondValue)
                {
                    ButtonInstance.Height = ButtonInstanceHeightFirstValue * (1 - interpolationValue) + ButtonInstanceHeightSecondValue * interpolationValue;
                }
                if (setButtonInstanceWidthFirstValue && setButtonInstanceWidthSecondValue)
                {
                    ButtonInstance.Width = ButtonInstanceWidthFirstValue * (1 - interpolationValue) + ButtonInstanceWidthSecondValue * interpolationValue;
                }
                if (setButtonInstanceXFirstValue && setButtonInstanceXSecondValue)
                {
                    ButtonInstance.X = ButtonInstanceXFirstValue * (1 - interpolationValue) + ButtonInstanceXSecondValue * interpolationValue;
                }
                if (setButtonInstanceYFirstValue && setButtonInstanceYSecondValue)
                {
                    ButtonInstance.Y = ButtonInstanceYFirstValue * (1 - interpolationValue) + ButtonInstanceYSecondValue * interpolationValue;
                }
                if (setButtonInstance1HeightFirstValue && setButtonInstance1HeightSecondValue)
                {
                    ButtonInstance1.Height = ButtonInstance1HeightFirstValue * (1 - interpolationValue) + ButtonInstance1HeightSecondValue * interpolationValue;
                }
                if (setButtonInstance1WidthFirstValue && setButtonInstance1WidthSecondValue)
                {
                    ButtonInstance1.Width = ButtonInstance1WidthFirstValue * (1 - interpolationValue) + ButtonInstance1WidthSecondValue * interpolationValue;
                }
                if (setButtonInstance1XFirstValue && setButtonInstance1XSecondValue)
                {
                    ButtonInstance1.X = ButtonInstance1XFirstValue * (1 - interpolationValue) + ButtonInstance1XSecondValue * interpolationValue;
                }
                if (setButtonInstance1YFirstValue && setButtonInstance1YSecondValue)
                {
                    ButtonInstance1.Y = ButtonInstance1YFirstValue * (1 - interpolationValue) + ButtonInstance1YSecondValue * interpolationValue;
                }
                if (setButtonInstance2HeightFirstValue && setButtonInstance2HeightSecondValue)
                {
                    ButtonInstance2.Height = ButtonInstance2HeightFirstValue * (1 - interpolationValue) + ButtonInstance2HeightSecondValue * interpolationValue;
                }
                if (setButtonInstance2WidthFirstValue && setButtonInstance2WidthSecondValue)
                {
                    ButtonInstance2.Width = ButtonInstance2WidthFirstValue * (1 - interpolationValue) + ButtonInstance2WidthSecondValue * interpolationValue;
                }
                if (setButtonInstance2XFirstValue && setButtonInstance2XSecondValue)
                {
                    ButtonInstance2.X = ButtonInstance2XFirstValue * (1 - interpolationValue) + ButtonInstance2XSecondValue * interpolationValue;
                }
                if (setButtonInstance2YFirstValue && setButtonInstance2YSecondValue)
                {
                    ButtonInstance2.Y = ButtonInstance2YFirstValue * (1 - interpolationValue) + ButtonInstance2YSecondValue * interpolationValue;
                }
                if (setButtonInstance3HeightFirstValue && setButtonInstance3HeightSecondValue)
                {
                    ButtonInstance3.Height = ButtonInstance3HeightFirstValue * (1 - interpolationValue) + ButtonInstance3HeightSecondValue * interpolationValue;
                }
                if (setButtonInstance3WidthFirstValue && setButtonInstance3WidthSecondValue)
                {
                    ButtonInstance3.Width = ButtonInstance3WidthFirstValue * (1 - interpolationValue) + ButtonInstance3WidthSecondValue * interpolationValue;
                }
                if (setButtonInstance3XFirstValue && setButtonInstance3XSecondValue)
                {
                    ButtonInstance3.X = ButtonInstance3XFirstValue * (1 - interpolationValue) + ButtonInstance3XSecondValue * interpolationValue;
                }
                if (setButtonInstance3YFirstValue && setButtonInstance3YSecondValue)
                {
                    ButtonInstance3.Y = ButtonInstance3YFirstValue * (1 - interpolationValue) + ButtonInstance3YSecondValue * interpolationValue;
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
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (JHP4SD.GumRuntimes.MainMenuGumRuntime.VariableState fromState,JHP4SD.GumRuntimes.MainMenuGumRuntime.VariableState toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null) 
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
                ButtonInstance.StopAnimations();
                ButtonInstance2.StopAnimations();
                ButtonInstance3.StopAnimations();
                ButtonInstance1.StopAnimations();
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
                            Name = "ButtonInstance.Height",
                            Type = "float",
                            Value = ButtonInstance.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonInstance.Height Units",
                            Type = "DimensionUnitType",
                            Value = ButtonInstance.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonInstance.Width",
                            Type = "float",
                            Value = ButtonInstance.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonInstance.X",
                            Type = "float",
                            Value = ButtonInstance.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonInstance.Y",
                            Type = "float",
                            Value = ButtonInstance.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonInstance2.Height",
                            Type = "float",
                            Value = ButtonInstance2.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonInstance2.Height Units",
                            Type = "DimensionUnitType",
                            Value = ButtonInstance2.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonInstance2.Width",
                            Type = "float",
                            Value = ButtonInstance2.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonInstance2.X",
                            Type = "float",
                            Value = ButtonInstance2.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonInstance2.Y",
                            Type = "float",
                            Value = ButtonInstance2.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonInstance3.Height",
                            Type = "float",
                            Value = ButtonInstance3.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonInstance3.Height Units",
                            Type = "DimensionUnitType",
                            Value = ButtonInstance3.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonInstance3.Width",
                            Type = "float",
                            Value = ButtonInstance3.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonInstance3.X",
                            Type = "float",
                            Value = ButtonInstance3.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonInstance3.X Origin",
                            Type = "HorizontalAlignment",
                            Value = ButtonInstance3.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonInstance3.X Units",
                            Type = "PositionUnitType",
                            Value = ButtonInstance3.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonInstance3.Y",
                            Type = "float",
                            Value = ButtonInstance3.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonInstance3.Y Origin",
                            Type = "VerticalAlignment",
                            Value = ButtonInstance3.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonInstance3.Y Units",
                            Type = "PositionUnitType",
                            Value = ButtonInstance3.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonInstance1.Height",
                            Type = "float",
                            Value = ButtonInstance1.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonInstance1.Height Units",
                            Type = "DimensionUnitType",
                            Value = ButtonInstance1.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonInstance1.Width",
                            Type = "float",
                            Value = ButtonInstance1.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonInstance1.X",
                            Type = "float",
                            Value = ButtonInstance1.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonInstance1.X Origin",
                            Type = "HorizontalAlignment",
                            Value = ButtonInstance1.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonInstance1.X Units",
                            Type = "PositionUnitType",
                            Value = ButtonInstance1.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonInstance1.Y",
                            Type = "float",
                            Value = ButtonInstance1.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonInstance1.Y Origin",
                            Type = "VerticalAlignment",
                            Value = ButtonInstance1.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonInstance1.Y Units",
                            Type = "PositionUnitType",
                            Value = ButtonInstance1.YUnits
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
                            Name = "ButtonInstance.Height",
                            Type = "float",
                            Value = ButtonInstance.Height + 50f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonInstance.Height Units",
                            Type = "DimensionUnitType",
                            Value = ButtonInstance.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonInstance.Width",
                            Type = "float",
                            Value = ButtonInstance.Width + 50f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonInstance.X",
                            Type = "float",
                            Value = ButtonInstance.X + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonInstance.Y",
                            Type = "float",
                            Value = ButtonInstance.Y + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonInstance2.Height",
                            Type = "float",
                            Value = ButtonInstance2.Height + 50f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonInstance2.Height Units",
                            Type = "DimensionUnitType",
                            Value = ButtonInstance2.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonInstance2.Width",
                            Type = "float",
                            Value = ButtonInstance2.Width + 50f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonInstance2.X",
                            Type = "float",
                            Value = ButtonInstance2.X + 910f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonInstance2.Y",
                            Type = "float",
                            Value = ButtonInstance2.Y + 490f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonInstance3.Height",
                            Type = "float",
                            Value = ButtonInstance3.Height + 50f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonInstance3.Height Units",
                            Type = "DimensionUnitType",
                            Value = ButtonInstance3.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonInstance3.Width",
                            Type = "float",
                            Value = ButtonInstance3.Width + 50f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonInstance3.X",
                            Type = "float",
                            Value = ButtonInstance3.X + -910f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonInstance3.X Origin",
                            Type = "HorizontalAlignment",
                            Value = ButtonInstance3.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonInstance3.X Units",
                            Type = "PositionUnitType",
                            Value = ButtonInstance3.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonInstance3.Y",
                            Type = "float",
                            Value = ButtonInstance3.Y + -490f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonInstance3.Y Origin",
                            Type = "VerticalAlignment",
                            Value = ButtonInstance3.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonInstance3.Y Units",
                            Type = "PositionUnitType",
                            Value = ButtonInstance3.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonInstance1.Height",
                            Type = "float",
                            Value = ButtonInstance1.Height + 50f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonInstance1.Height Units",
                            Type = "DimensionUnitType",
                            Value = ButtonInstance1.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonInstance1.Width",
                            Type = "float",
                            Value = ButtonInstance1.Width + 50f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonInstance1.X",
                            Type = "float",
                            Value = ButtonInstance1.X + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonInstance1.X Origin",
                            Type = "HorizontalAlignment",
                            Value = ButtonInstance1.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonInstance1.X Units",
                            Type = "PositionUnitType",
                            Value = ButtonInstance1.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonInstance1.Y",
                            Type = "float",
                            Value = ButtonInstance1.Y + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonInstance1.Y Origin",
                            Type = "VerticalAlignment",
                            Value = ButtonInstance1.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonInstance1.Y Units",
                            Type = "PositionUnitType",
                            Value = ButtonInstance1.YUnits
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
            public JHP4SD.GumRuntimes.DefaultForms.ButtonRuntime ButtonInstance { get; set; }
            public JHP4SD.GumRuntimes.DefaultForms.ButtonRuntime ButtonInstance2 { get; set; }
            public JHP4SD.GumRuntimes.DefaultForms.ButtonRuntime ButtonInstance3 { get; set; }
            public JHP4SD.GumRuntimes.DefaultForms.ButtonRuntime ButtonInstance1 { get; set; }
            public MainMenuGumRuntime (bool fullInstantiation = true, bool tryCreateFormsObject = true) 
            {
                this.tryCreateFormsObject = tryCreateFormsObject;
                if (fullInstantiation)
                {
                    Gum.DataTypes.ElementSave elementSave = Gum.Managers.ObjectFinder.Self.GumProjectSave.Screens.First(item => item.Name == "MainMenuGum");
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
                ButtonInstance = this.GetGraphicalUiElementByName("ButtonInstance") as JHP4SD.GumRuntimes.DefaultForms.ButtonRuntime;
                ButtonInstance2 = this.GetGraphicalUiElementByName("ButtonInstance2") as JHP4SD.GumRuntimes.DefaultForms.ButtonRuntime;
                ButtonInstance3 = this.GetGraphicalUiElementByName("ButtonInstance3") as JHP4SD.GumRuntimes.DefaultForms.ButtonRuntime;
                ButtonInstance1 = this.GetGraphicalUiElementByName("ButtonInstance1") as JHP4SD.GumRuntimes.DefaultForms.ButtonRuntime;
                if (tryCreateFormsObject)
                {
                    FormsControlAsObject = new JHP4SD.FormsControls.Screens.MainMenuGumForms(this);
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
            public JHP4SD.FormsControls.Screens.MainMenuGumForms FormsControl {get => (JHP4SD.FormsControls.Screens.MainMenuGumForms) FormsControlAsObject;}
        }
    }
