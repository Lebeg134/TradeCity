    using System.Linq;
    namespace JHP4SD.GumRuntimes.DefaultForms
    {
        public partial class TreeViewItemRuntime : JHP4SD.GumRuntimes.ContainerRuntime
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
                            Height = 0f;
                            HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                            Width = 0f;
                            WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                            ToggleButtonInstance.Y = 5f;
                            ListBoxItemInstance.Width = -32f;
                            ListBoxItemInstance.X = 32f;
                            InnerPanelInstance.ChildrenLayout = Gum.Managers.ChildrenLayout.TopToBottomStack;
                            InnerPanelInstance.Height = 0f;
                            InnerPanelInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                            InnerPanelInstance.Width = -32f;
                            InnerPanelInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                            InnerPanelInstance.X = 32f;
                            InnerPanelInstance.Y = 32f;
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
                bool setHeightFirstValue = false;
                bool setHeightSecondValue = false;
                float HeightFirstValue= 0;
                float HeightSecondValue= 0;
                bool setInnerPanelInstanceHeightFirstValue = false;
                bool setInnerPanelInstanceHeightSecondValue = false;
                float InnerPanelInstanceHeightFirstValue= 0;
                float InnerPanelInstanceHeightSecondValue= 0;
                bool setInnerPanelInstanceWidthFirstValue = false;
                bool setInnerPanelInstanceWidthSecondValue = false;
                float InnerPanelInstanceWidthFirstValue= 0;
                float InnerPanelInstanceWidthSecondValue= 0;
                bool setInnerPanelInstanceXFirstValue = false;
                bool setInnerPanelInstanceXSecondValue = false;
                float InnerPanelInstanceXFirstValue= 0;
                float InnerPanelInstanceXSecondValue= 0;
                bool setInnerPanelInstanceYFirstValue = false;
                bool setInnerPanelInstanceYSecondValue = false;
                float InnerPanelInstanceYFirstValue= 0;
                float InnerPanelInstanceYSecondValue= 0;
                bool setListBoxItemInstanceWidthFirstValue = false;
                bool setListBoxItemInstanceWidthSecondValue = false;
                float ListBoxItemInstanceWidthFirstValue= 0;
                float ListBoxItemInstanceWidthSecondValue= 0;
                bool setListBoxItemInstanceXFirstValue = false;
                bool setListBoxItemInstanceXSecondValue = false;
                float ListBoxItemInstanceXFirstValue= 0;
                float ListBoxItemInstanceXSecondValue= 0;
                bool setToggleButtonInstanceYFirstValue = false;
                bool setToggleButtonInstanceYSecondValue = false;
                float ToggleButtonInstanceYFirstValue= 0;
                float ToggleButtonInstanceYSecondValue= 0;
                bool setWidthFirstValue = false;
                bool setWidthSecondValue = false;
                float WidthFirstValue= 0;
                float WidthSecondValue= 0;
                switch(firstState)
                {
                    case  VariableState.Default:
                        setHeightFirstValue = true;
                        HeightFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                        }
                        if (interpolationValue < 1)
                        {
                            this.InnerPanelInstance.ChildrenLayout = Gum.Managers.ChildrenLayout.TopToBottomStack;
                        }
                        setInnerPanelInstanceHeightFirstValue = true;
                        InnerPanelInstanceHeightFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.InnerPanelInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                        }
                        setInnerPanelInstanceWidthFirstValue = true;
                        InnerPanelInstanceWidthFirstValue = -32f;
                        if (interpolationValue < 1)
                        {
                            this.InnerPanelInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        setInnerPanelInstanceXFirstValue = true;
                        InnerPanelInstanceXFirstValue = 32f;
                        setInnerPanelInstanceYFirstValue = true;
                        InnerPanelInstanceYFirstValue = 32f;
                        setListBoxItemInstanceWidthFirstValue = true;
                        ListBoxItemInstanceWidthFirstValue = -32f;
                        setListBoxItemInstanceXFirstValue = true;
                        ListBoxItemInstanceXFirstValue = 32f;
                        setToggleButtonInstanceYFirstValue = true;
                        ToggleButtonInstanceYFirstValue = 5f;
                        setWidthFirstValue = true;
                        WidthFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        break;
                }
                switch(secondState)
                {
                    case  VariableState.Default:
                        setHeightSecondValue = true;
                        HeightSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.InnerPanelInstance.ChildrenLayout = Gum.Managers.ChildrenLayout.TopToBottomStack;
                        }
                        setInnerPanelInstanceHeightSecondValue = true;
                        InnerPanelInstanceHeightSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.InnerPanelInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                        }
                        setInnerPanelInstanceWidthSecondValue = true;
                        InnerPanelInstanceWidthSecondValue = -32f;
                        if (interpolationValue >= 1)
                        {
                            this.InnerPanelInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        setInnerPanelInstanceXSecondValue = true;
                        InnerPanelInstanceXSecondValue = 32f;
                        setInnerPanelInstanceYSecondValue = true;
                        InnerPanelInstanceYSecondValue = 32f;
                        setListBoxItemInstanceWidthSecondValue = true;
                        ListBoxItemInstanceWidthSecondValue = -32f;
                        setListBoxItemInstanceXSecondValue = true;
                        ListBoxItemInstanceXSecondValue = 32f;
                        setToggleButtonInstanceYSecondValue = true;
                        ToggleButtonInstanceYSecondValue = 5f;
                        setWidthSecondValue = true;
                        WidthSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        break;
                }
                var wasSuppressed = mIsLayoutSuspended;
                if (wasSuppressed == false)
                {
                    SuspendLayout(true);
                }
                if (setHeightFirstValue && setHeightSecondValue)
                {
                    Height = HeightFirstValue * (1 - interpolationValue) + HeightSecondValue * interpolationValue;
                }
                if (setInnerPanelInstanceHeightFirstValue && setInnerPanelInstanceHeightSecondValue)
                {
                    InnerPanelInstance.Height = InnerPanelInstanceHeightFirstValue * (1 - interpolationValue) + InnerPanelInstanceHeightSecondValue * interpolationValue;
                }
                if (setInnerPanelInstanceWidthFirstValue && setInnerPanelInstanceWidthSecondValue)
                {
                    InnerPanelInstance.Width = InnerPanelInstanceWidthFirstValue * (1 - interpolationValue) + InnerPanelInstanceWidthSecondValue * interpolationValue;
                }
                if (setInnerPanelInstanceXFirstValue && setInnerPanelInstanceXSecondValue)
                {
                    InnerPanelInstance.X = InnerPanelInstanceXFirstValue * (1 - interpolationValue) + InnerPanelInstanceXSecondValue * interpolationValue;
                }
                if (setInnerPanelInstanceYFirstValue && setInnerPanelInstanceYSecondValue)
                {
                    InnerPanelInstance.Y = InnerPanelInstanceYFirstValue * (1 - interpolationValue) + InnerPanelInstanceYSecondValue * interpolationValue;
                }
                if (setListBoxItemInstanceWidthFirstValue && setListBoxItemInstanceWidthSecondValue)
                {
                    ListBoxItemInstance.Width = ListBoxItemInstanceWidthFirstValue * (1 - interpolationValue) + ListBoxItemInstanceWidthSecondValue * interpolationValue;
                }
                if (setListBoxItemInstanceXFirstValue && setListBoxItemInstanceXSecondValue)
                {
                    ListBoxItemInstance.X = ListBoxItemInstanceXFirstValue * (1 - interpolationValue) + ListBoxItemInstanceXSecondValue * interpolationValue;
                }
                if (setToggleButtonInstanceYFirstValue && setToggleButtonInstanceYSecondValue)
                {
                    ToggleButtonInstance.Y = ToggleButtonInstanceYFirstValue * (1 - interpolationValue) + ToggleButtonInstanceYSecondValue * interpolationValue;
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
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (JHP4SD.GumRuntimes.DefaultForms.TreeViewItemRuntime.VariableState fromState,JHP4SD.GumRuntimes.DefaultForms.TreeViewItemRuntime.VariableState toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null) 
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
                ToggleButtonInstance.StopAnimations();
                ListBoxItemInstance.StopAnimations();
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
                            Name = "Width Units",
                            Type = "DimensionUnitType",
                            Value = WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ToggleButtonInstance.Y",
                            Type = "float",
                            Value = ToggleButtonInstance.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ListBoxItemInstance.Width",
                            Type = "float",
                            Value = ListBoxItemInstance.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ListBoxItemInstance.X",
                            Type = "float",
                            Value = ListBoxItemInstance.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "InnerPanelInstance.Children Layout",
                            Type = "ChildrenLayout",
                            Value = InnerPanelInstance.ChildrenLayout
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "InnerPanelInstance.Height",
                            Type = "float",
                            Value = InnerPanelInstance.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "InnerPanelInstance.Height Units",
                            Type = "DimensionUnitType",
                            Value = InnerPanelInstance.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "InnerPanelInstance.Width",
                            Type = "float",
                            Value = InnerPanelInstance.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "InnerPanelInstance.Width Units",
                            Type = "DimensionUnitType",
                            Value = InnerPanelInstance.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "InnerPanelInstance.X",
                            Type = "float",
                            Value = InnerPanelInstance.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "InnerPanelInstance.Y",
                            Type = "float",
                            Value = InnerPanelInstance.Y
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
                            Value = Width + 0f
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
                            Name = "ToggleButtonInstance.Y",
                            Type = "float",
                            Value = ToggleButtonInstance.Y + 5f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ListBoxItemInstance.Width",
                            Type = "float",
                            Value = ListBoxItemInstance.Width + -32f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ListBoxItemInstance.X",
                            Type = "float",
                            Value = ListBoxItemInstance.X + 32f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "InnerPanelInstance.Children Layout",
                            Type = "ChildrenLayout",
                            Value = InnerPanelInstance.ChildrenLayout
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "InnerPanelInstance.Height",
                            Type = "float",
                            Value = InnerPanelInstance.Height + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "InnerPanelInstance.Height Units",
                            Type = "DimensionUnitType",
                            Value = InnerPanelInstance.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "InnerPanelInstance.Width",
                            Type = "float",
                            Value = InnerPanelInstance.Width + -32f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "InnerPanelInstance.Width Units",
                            Type = "DimensionUnitType",
                            Value = InnerPanelInstance.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "InnerPanelInstance.X",
                            Type = "float",
                            Value = InnerPanelInstance.X + 32f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "InnerPanelInstance.Y",
                            Type = "float",
                            Value = InnerPanelInstance.Y + 32f
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
            public JHP4SD.GumRuntimes.DefaultForms.TreeViewToggleButtonRuntime ToggleButtonInstance { get; set; }
            public JHP4SD.GumRuntimes.DefaultForms.ListBoxItemRuntime ListBoxItemInstance { get; set; }
            public JHP4SD.GumRuntimes.ContainerRuntime InnerPanelInstance { get; set; }
            public event FlatRedBall.Gui.WindowEvent ToggleButtonInstanceClick;
            public event FlatRedBall.Gui.WindowEvent ListBoxItemInstanceClick;
            public TreeViewItemRuntime (bool fullInstantiation = true, bool tryCreateFormsObject = true) 
            	: base(false, tryCreateFormsObject)
            {
                this.tryCreateFormsObject = tryCreateFormsObject;
                if (fullInstantiation)
                {
                    Gum.DataTypes.ElementSave elementSave = Gum.Managers.ObjectFinder.Self.GumProjectSave.Components.First(item => item.Name == "DefaultForms/TreeViewItem");
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
                ToggleButtonInstance = this.GetGraphicalUiElementByName("ToggleButtonInstance") as JHP4SD.GumRuntimes.DefaultForms.TreeViewToggleButtonRuntime;
                ListBoxItemInstance = this.GetGraphicalUiElementByName("ListBoxItemInstance") as JHP4SD.GumRuntimes.DefaultForms.ListBoxItemRuntime;
                InnerPanelInstance = this.GetGraphicalUiElementByName("InnerPanelInstance") as JHP4SD.GumRuntimes.ContainerRuntime;
                ToggleButtonInstance.Click += (unused) => ToggleButtonInstanceClick?.Invoke(this);
                ListBoxItemInstance.Click += (unused) => ListBoxItemInstanceClick?.Invoke(this);
                if (tryCreateFormsObject)
                {
                    FormsControlAsObject = new FlatRedBall.Forms.Controls.TreeViewItem(this);
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
            public FlatRedBall.Forms.Controls.TreeViewItem FormsControl {get => (FlatRedBall.Forms.Controls.TreeViewItem) FormsControlAsObject;}
        }
    }
