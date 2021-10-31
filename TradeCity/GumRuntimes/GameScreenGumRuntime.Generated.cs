    using System.Linq;
    namespace JHP4SD.GumRuntimes
    {
        public partial class GameScreenGumRuntime : Gum.Wireframe.GraphicalUiElement
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
                            CircleInstance.X = 555f;
                            CircleInstance.Y = 338f;
                            ButtonInstance.X = 69f;
                            ButtonInstance.Y = 88f;
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
                bool setButtonInstanceXFirstValue = false;
                bool setButtonInstanceXSecondValue = false;
                float ButtonInstanceXFirstValue= 0;
                float ButtonInstanceXSecondValue= 0;
                bool setButtonInstanceYFirstValue = false;
                bool setButtonInstanceYSecondValue = false;
                float ButtonInstanceYFirstValue= 0;
                float ButtonInstanceYSecondValue= 0;
                bool setCircleInstanceXFirstValue = false;
                bool setCircleInstanceXSecondValue = false;
                float CircleInstanceXFirstValue= 0;
                float CircleInstanceXSecondValue= 0;
                bool setCircleInstanceYFirstValue = false;
                bool setCircleInstanceYSecondValue = false;
                float CircleInstanceYFirstValue= 0;
                float CircleInstanceYSecondValue= 0;
                switch(firstState)
                {
                    case  VariableState.Default:
                        setButtonInstanceXFirstValue = true;
                        ButtonInstanceXFirstValue = 69f;
                        setButtonInstanceYFirstValue = true;
                        ButtonInstanceYFirstValue = 88f;
                        setCircleInstanceXFirstValue = true;
                        CircleInstanceXFirstValue = 555f;
                        setCircleInstanceYFirstValue = true;
                        CircleInstanceYFirstValue = 338f;
                        break;
                }
                switch(secondState)
                {
                    case  VariableState.Default:
                        setButtonInstanceXSecondValue = true;
                        ButtonInstanceXSecondValue = 69f;
                        setButtonInstanceYSecondValue = true;
                        ButtonInstanceYSecondValue = 88f;
                        setCircleInstanceXSecondValue = true;
                        CircleInstanceXSecondValue = 555f;
                        setCircleInstanceYSecondValue = true;
                        CircleInstanceYSecondValue = 338f;
                        break;
                }
                var wasSuppressed = mIsLayoutSuspended;
                if (wasSuppressed == false)
                {
                    SuspendLayout(true);
                }
                if (setButtonInstanceXFirstValue && setButtonInstanceXSecondValue)
                {
                    ButtonInstance.X = ButtonInstanceXFirstValue * (1 - interpolationValue) + ButtonInstanceXSecondValue * interpolationValue;
                }
                if (setButtonInstanceYFirstValue && setButtonInstanceYSecondValue)
                {
                    ButtonInstance.Y = ButtonInstanceYFirstValue * (1 - interpolationValue) + ButtonInstanceYSecondValue * interpolationValue;
                }
                if (setCircleInstanceXFirstValue && setCircleInstanceXSecondValue)
                {
                    CircleInstance.X = CircleInstanceXFirstValue * (1 - interpolationValue) + CircleInstanceXSecondValue * interpolationValue;
                }
                if (setCircleInstanceYFirstValue && setCircleInstanceYSecondValue)
                {
                    CircleInstance.Y = CircleInstanceYFirstValue * (1 - interpolationValue) + CircleInstanceYSecondValue * interpolationValue;
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
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (JHP4SD.GumRuntimes.GameScreenGumRuntime.VariableState fromState,JHP4SD.GumRuntimes.GameScreenGumRuntime.VariableState toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null) 
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
                            Name = "CircleInstance.X",
                            Type = "float",
                            Value = CircleInstance.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CircleInstance.Y",
                            Type = "float",
                            Value = CircleInstance.Y
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
                            Name = "CircleInstance.X",
                            Type = "float",
                            Value = CircleInstance.X + 555f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CircleInstance.Y",
                            Type = "float",
                            Value = CircleInstance.Y + 338f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonInstance.X",
                            Type = "float",
                            Value = ButtonInstance.X + 69f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonInstance.Y",
                            Type = "float",
                            Value = ButtonInstance.Y + 88f
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
            public JHP4SD.GumRuntimes.CircleRuntime CircleInstance { get; set; }
            public JHP4SD.GumRuntimes.DefaultForms.ButtonRuntime ButtonInstance { get; set; }
            public GameScreenGumRuntime (bool fullInstantiation = true, bool tryCreateFormsObject = true) 
            {
                this.tryCreateFormsObject = tryCreateFormsObject;
                if (fullInstantiation)
                {
                    Gum.DataTypes.ElementSave elementSave = Gum.Managers.ObjectFinder.Self.GumProjectSave.Screens.First(item => item.Name == "GameScreenGum");
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
                CircleInstance = this.GetGraphicalUiElementByName("CircleInstance") as JHP4SD.GumRuntimes.CircleRuntime;
                ButtonInstance = this.GetGraphicalUiElementByName("ButtonInstance") as JHP4SD.GumRuntimes.DefaultForms.ButtonRuntime;
                if (tryCreateFormsObject)
                {
                    FormsControlAsObject = new JHP4SD.FormsControls.Screens.GameScreenGumForms(this);
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
            public JHP4SD.FormsControls.Screens.GameScreenGumForms FormsControl {get => (JHP4SD.FormsControls.Screens.GameScreenGumForms) FormsControlAsObject;}
        }
    }
