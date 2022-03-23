    using System.Linq;
    namespace JHP4SD.GumRuntimes.DefaultForms
    {
        public partial class UserControlRuntime : JHP4SD.GumRuntimes.ContainerRuntime
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
                            ColoredFrameInstance.CurrentColorCategoryState = JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.TransparentBlack;
                            Height = 300f;
                            Width = 300f;
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
                bool setWidthFirstValue = false;
                bool setWidthSecondValue = false;
                float WidthFirstValue= 0;
                float WidthSecondValue= 0;
                switch(firstState)
                {
                    case  VariableState.Default:
                        setColoredFrameInstanceCurrentColorCategoryStateFirstValue = true;
                        ColoredFrameInstanceCurrentColorCategoryStateFirstValue = JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.TransparentBlack;
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
                        HeightFirstValue = 300f;
                        setWidthFirstValue = true;
                        WidthFirstValue = 300f;
                        break;
                }
                switch(secondState)
                {
                    case  VariableState.Default:
                        setColoredFrameInstanceCurrentColorCategoryStateSecondValue = true;
                        ColoredFrameInstanceCurrentColorCategoryStateSecondValue = JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.TransparentBlack;
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
                        HeightSecondValue = 300f;
                        setWidthSecondValue = true;
                        WidthSecondValue = 300f;
                        break;
                }
                var wasSuppressed = mIsLayoutSuspended;
                if (wasSuppressed == false)
                {
                    SuspendLayout(true);
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
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (JHP4SD.GumRuntimes.DefaultForms.UserControlRuntime.VariableState fromState,JHP4SD.GumRuntimes.DefaultForms.UserControlRuntime.VariableState toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null) 
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
                            Value = Height + 300f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Width",
                            Type = "float",
                            Value = Width + 300f
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
            public JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime ColoredFrameInstance { get; set; }
            public UserControlRuntime (bool fullInstantiation = true, bool tryCreateFormsObject = true) 
            	: base(false, tryCreateFormsObject)
            {
                this.tryCreateFormsObject = tryCreateFormsObject;
                if (fullInstantiation)
                {
                    Gum.DataTypes.ElementSave elementSave = Gum.Managers.ObjectFinder.Self.GumProjectSave.Components.First(item => item.Name == "DefaultForms/UserControl");
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
                if (tryCreateFormsObject)
                {
                    FormsControlAsObject = new FlatRedBall.Forms.Controls.UserControl(this);
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
            public FlatRedBall.Forms.Controls.UserControl FormsControl {get => (FlatRedBall.Forms.Controls.UserControl) FormsControlAsObject;}
        }
    }
