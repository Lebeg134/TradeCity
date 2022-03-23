    using System.Linq;
    namespace JHP4SD.GumRuntimes.DefaultForms
    {
        public partial class TextBoxRuntime : JHP4SD.GumRuntimes.ContainerRuntime
        {
            #region State Enums
            public enum VariableState
            {
                Default
            }
            public enum TextBoxCategory
            {
                Enabled,
                Disabled,
                Highlighted,
                Selected
            }
            public enum LineModeCategory
            {
                Single,
                Multi
            }
            #endregion
            #region State Fields
            VariableState mCurrentVariableState;
            TextBoxCategory? mCurrentTextBoxCategoryState;
            LineModeCategory? mCurrentLineModeCategoryState;
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
                            SelectionInstance.CurrentColorCategoryState = JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Gray;
                            TextInstance.CurrentColorCategoryState = JHP4SD.GumRuntimes.TextRuntime.ColorCategory.Black;
                            ClipsChildren = true;
                            Height = 30f;
                            Width = 220f;
                            BackgroundInstance.Height = 0f;
                            BackgroundInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                            BackgroundInstance.Width = 0f;
                            BackgroundInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                            BackgroundInstance.X = 0f;
                            BackgroundInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                            BackgroundInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            BackgroundInstance.Y = 0f;
                            BackgroundInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            BackgroundInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            SelectionInstance.Blue = 170;
                            SelectionInstance.Green = 205;
                            SelectionInstance.Height = -2f;
                            SelectionInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                            SelectionInstance.Red = 102;
                            SelectionInstance.Width = 27f;
                            SelectionInstance.X = 31f;
                            SelectionInstance.Y = 1f;
                            TextInstance.Height = 20f;
                            TextInstance.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                            TextInstance.Text = "Hello";
                            TextInstance.VerticalAlignment = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            TextInstance.Width = 0f;
                            TextInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                            TextInstance.X = 5f;
                            TextInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                            TextInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                            TextInstance.Y = 0f;
                            TextInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            TextInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            CaretInstance.Blue = 49;
                            CaretInstance.Green = 49;
                            CaretInstance.Height = 22f;
                            CaretInstance.Red = 49;
                            CaretInstance.Width = 2f;
                            CaretInstance.X = 5f;
                            CaretInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                            CaretInstance.Y = 2f;
                            break;
                    }
                }
            }
            public TextBoxCategory? CurrentTextBoxCategoryState
            {
                get
                {
                    return mCurrentTextBoxCategoryState;
                }
                set
                {
                    if (value != null)
                    {
                        mCurrentTextBoxCategoryState = value;
                        switch(mCurrentTextBoxCategoryState)
                        {
                            case  TextBoxCategory.Enabled:
                                break;
                            case  TextBoxCategory.Disabled:
                                break;
                            case  TextBoxCategory.Highlighted:
                                break;
                            case  TextBoxCategory.Selected:
                                break;
                        }
                    }
                }
            }
            public LineModeCategory? CurrentLineModeCategoryState
            {
                get
                {
                    return mCurrentLineModeCategoryState;
                }
                set
                {
                    if (value != null)
                    {
                        mCurrentLineModeCategoryState = value;
                        switch(mCurrentLineModeCategoryState)
                        {
                            case  LineModeCategory.Single:
                                Height = 30f;
                                SelectionInstance.Height = -2f;
                                SelectionInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                                TextInstance.Height = 20f;
                                TextInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                                TextInstance.VerticalAlignment = RenderingLibrary.Graphics.VerticalAlignment.Center;
                                TextInstance.Width = 0f;
                                TextInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                                TextInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                                TextInstance.Y = 0f;
                                TextInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                                TextInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                                break;
                            case  LineModeCategory.Multi:
                                Height = 110f;
                                SelectionInstance.Height = 27f;
                                SelectionInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                                TextInstance.Height = -10f;
                                TextInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                                TextInstance.VerticalAlignment = RenderingLibrary.Graphics.VerticalAlignment.Top;
                                TextInstance.Width = -10f;
                                TextInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                                TextInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                                TextInstance.Y = 5f;
                                TextInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Top;
                                TextInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                                break;
                        }
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
                bool setBackgroundInstanceHeightFirstValue = false;
                bool setBackgroundInstanceHeightSecondValue = false;
                float BackgroundInstanceHeightFirstValue= 0;
                float BackgroundInstanceHeightSecondValue= 0;
                bool setBackgroundInstanceWidthFirstValue = false;
                bool setBackgroundInstanceWidthSecondValue = false;
                float BackgroundInstanceWidthFirstValue= 0;
                float BackgroundInstanceWidthSecondValue= 0;
                bool setBackgroundInstanceXFirstValue = false;
                bool setBackgroundInstanceXSecondValue = false;
                float BackgroundInstanceXFirstValue= 0;
                float BackgroundInstanceXSecondValue= 0;
                bool setBackgroundInstanceYFirstValue = false;
                bool setBackgroundInstanceYSecondValue = false;
                float BackgroundInstanceYFirstValue= 0;
                float BackgroundInstanceYSecondValue= 0;
                bool setCaretInstanceBlueFirstValue = false;
                bool setCaretInstanceBlueSecondValue = false;
                int CaretInstanceBlueFirstValue= 0;
                int CaretInstanceBlueSecondValue= 0;
                bool setCaretInstanceGreenFirstValue = false;
                bool setCaretInstanceGreenSecondValue = false;
                int CaretInstanceGreenFirstValue= 0;
                int CaretInstanceGreenSecondValue= 0;
                bool setCaretInstanceHeightFirstValue = false;
                bool setCaretInstanceHeightSecondValue = false;
                float CaretInstanceHeightFirstValue= 0;
                float CaretInstanceHeightSecondValue= 0;
                bool setCaretInstanceRedFirstValue = false;
                bool setCaretInstanceRedSecondValue = false;
                int CaretInstanceRedFirstValue= 0;
                int CaretInstanceRedSecondValue= 0;
                bool setCaretInstanceWidthFirstValue = false;
                bool setCaretInstanceWidthSecondValue = false;
                float CaretInstanceWidthFirstValue= 0;
                float CaretInstanceWidthSecondValue= 0;
                bool setCaretInstanceXFirstValue = false;
                bool setCaretInstanceXSecondValue = false;
                float CaretInstanceXFirstValue= 0;
                float CaretInstanceXSecondValue= 0;
                bool setCaretInstanceYFirstValue = false;
                bool setCaretInstanceYSecondValue = false;
                float CaretInstanceYFirstValue= 0;
                float CaretInstanceYSecondValue= 0;
                bool setHeightFirstValue = false;
                bool setHeightSecondValue = false;
                float HeightFirstValue= 0;
                float HeightSecondValue= 0;
                bool setSelectionInstanceBlueFirstValue = false;
                bool setSelectionInstanceBlueSecondValue = false;
                int SelectionInstanceBlueFirstValue= 0;
                int SelectionInstanceBlueSecondValue= 0;
                bool setSelectionInstanceCurrentColorCategoryStateFirstValue = false;
                bool setSelectionInstanceCurrentColorCategoryStateSecondValue = false;
                JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory SelectionInstanceCurrentColorCategoryStateFirstValue= JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Gray;
                JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory SelectionInstanceCurrentColorCategoryStateSecondValue= JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Gray;
                bool setSelectionInstanceGreenFirstValue = false;
                bool setSelectionInstanceGreenSecondValue = false;
                int SelectionInstanceGreenFirstValue= 0;
                int SelectionInstanceGreenSecondValue= 0;
                bool setSelectionInstanceHeightFirstValue = false;
                bool setSelectionInstanceHeightSecondValue = false;
                float SelectionInstanceHeightFirstValue= 0;
                float SelectionInstanceHeightSecondValue= 0;
                bool setSelectionInstanceRedFirstValue = false;
                bool setSelectionInstanceRedSecondValue = false;
                int SelectionInstanceRedFirstValue= 0;
                int SelectionInstanceRedSecondValue= 0;
                bool setSelectionInstanceWidthFirstValue = false;
                bool setSelectionInstanceWidthSecondValue = false;
                float SelectionInstanceWidthFirstValue= 0;
                float SelectionInstanceWidthSecondValue= 0;
                bool setSelectionInstanceXFirstValue = false;
                bool setSelectionInstanceXSecondValue = false;
                float SelectionInstanceXFirstValue= 0;
                float SelectionInstanceXSecondValue= 0;
                bool setSelectionInstanceYFirstValue = false;
                bool setSelectionInstanceYSecondValue = false;
                float SelectionInstanceYFirstValue= 0;
                float SelectionInstanceYSecondValue= 0;
                bool setTextInstanceCurrentColorCategoryStateFirstValue = false;
                bool setTextInstanceCurrentColorCategoryStateSecondValue = false;
                JHP4SD.GumRuntimes.TextRuntime.ColorCategory TextInstanceCurrentColorCategoryStateFirstValue= JHP4SD.GumRuntimes.TextRuntime.ColorCategory.Gray;
                JHP4SD.GumRuntimes.TextRuntime.ColorCategory TextInstanceCurrentColorCategoryStateSecondValue= JHP4SD.GumRuntimes.TextRuntime.ColorCategory.Gray;
                bool setTextInstanceHeightFirstValue = false;
                bool setTextInstanceHeightSecondValue = false;
                float TextInstanceHeightFirstValue= 0;
                float TextInstanceHeightSecondValue= 0;
                bool setTextInstanceWidthFirstValue = false;
                bool setTextInstanceWidthSecondValue = false;
                float TextInstanceWidthFirstValue= 0;
                float TextInstanceWidthSecondValue= 0;
                bool setTextInstanceXFirstValue = false;
                bool setTextInstanceXSecondValue = false;
                float TextInstanceXFirstValue= 0;
                float TextInstanceXSecondValue= 0;
                bool setTextInstanceYFirstValue = false;
                bool setTextInstanceYSecondValue = false;
                float TextInstanceYFirstValue= 0;
                float TextInstanceYSecondValue= 0;
                bool setWidthFirstValue = false;
                bool setWidthSecondValue = false;
                float WidthFirstValue= 0;
                float WidthSecondValue= 0;
                switch(firstState)
                {
                    case  VariableState.Default:
                        setBackgroundInstanceHeightFirstValue = true;
                        BackgroundInstanceHeightFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.BackgroundInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        setBackgroundInstanceWidthFirstValue = true;
                        BackgroundInstanceWidthFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.BackgroundInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        setBackgroundInstanceXFirstValue = true;
                        BackgroundInstanceXFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.BackgroundInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.BackgroundInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setBackgroundInstanceYFirstValue = true;
                        BackgroundInstanceYFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.BackgroundInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.BackgroundInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setCaretInstanceBlueFirstValue = true;
                        CaretInstanceBlueFirstValue = 49;
                        setCaretInstanceGreenFirstValue = true;
                        CaretInstanceGreenFirstValue = 49;
                        setCaretInstanceHeightFirstValue = true;
                        CaretInstanceHeightFirstValue = 22f;
                        setCaretInstanceRedFirstValue = true;
                        CaretInstanceRedFirstValue = 49;
                        setCaretInstanceWidthFirstValue = true;
                        CaretInstanceWidthFirstValue = 2f;
                        setCaretInstanceXFirstValue = true;
                        CaretInstanceXFirstValue = 5f;
                        if (interpolationValue < 1)
                        {
                            this.CaretInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                        }
                        setCaretInstanceYFirstValue = true;
                        CaretInstanceYFirstValue = 2f;
                        if (interpolationValue < 1)
                        {
                            this.ClipsChildren = true;
                        }
                        setHeightFirstValue = true;
                        HeightFirstValue = 30f;
                        setSelectionInstanceBlueFirstValue = true;
                        SelectionInstanceBlueFirstValue = 170;
                        setSelectionInstanceCurrentColorCategoryStateFirstValue = true;
                        SelectionInstanceCurrentColorCategoryStateFirstValue = JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Gray;
                        setSelectionInstanceGreenFirstValue = true;
                        SelectionInstanceGreenFirstValue = 205;
                        setSelectionInstanceHeightFirstValue = true;
                        SelectionInstanceHeightFirstValue = -2f;
                        if (interpolationValue < 1)
                        {
                            this.SelectionInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        setSelectionInstanceRedFirstValue = true;
                        SelectionInstanceRedFirstValue = 102;
                        setSelectionInstanceWidthFirstValue = true;
                        SelectionInstanceWidthFirstValue = 27f;
                        setSelectionInstanceXFirstValue = true;
                        SelectionInstanceXFirstValue = 31f;
                        setSelectionInstanceYFirstValue = true;
                        SelectionInstanceYFirstValue = 1f;
                        setTextInstanceCurrentColorCategoryStateFirstValue = true;
                        TextInstanceCurrentColorCategoryStateFirstValue = JHP4SD.GumRuntimes.TextRuntime.ColorCategory.Black;
                        setTextInstanceHeightFirstValue = true;
                        TextInstanceHeightFirstValue = 20f;
                        if (interpolationValue < 1)
                        {
                            this.TextInstance.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                        }
                        if (interpolationValue < 1)
                        {
                            this.TextInstance.Text = "Hello";
                        }
                        if (interpolationValue < 1)
                        {
                            this.TextInstance.VerticalAlignment = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        setTextInstanceWidthFirstValue = true;
                        TextInstanceWidthFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.TextInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                        }
                        setTextInstanceXFirstValue = true;
                        TextInstanceXFirstValue = 5f;
                        if (interpolationValue < 1)
                        {
                            this.TextInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                        }
                        if (interpolationValue < 1)
                        {
                            this.TextInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                        }
                        setTextInstanceYFirstValue = true;
                        TextInstanceYFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.TextInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.TextInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setWidthFirstValue = true;
                        WidthFirstValue = 220f;
                        break;
                }
                switch(secondState)
                {
                    case  VariableState.Default:
                        setBackgroundInstanceHeightSecondValue = true;
                        BackgroundInstanceHeightSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.BackgroundInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        setBackgroundInstanceWidthSecondValue = true;
                        BackgroundInstanceWidthSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.BackgroundInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        setBackgroundInstanceXSecondValue = true;
                        BackgroundInstanceXSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.BackgroundInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.BackgroundInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setBackgroundInstanceYSecondValue = true;
                        BackgroundInstanceYSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.BackgroundInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.BackgroundInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setCaretInstanceBlueSecondValue = true;
                        CaretInstanceBlueSecondValue = 49;
                        setCaretInstanceGreenSecondValue = true;
                        CaretInstanceGreenSecondValue = 49;
                        setCaretInstanceHeightSecondValue = true;
                        CaretInstanceHeightSecondValue = 22f;
                        setCaretInstanceRedSecondValue = true;
                        CaretInstanceRedSecondValue = 49;
                        setCaretInstanceWidthSecondValue = true;
                        CaretInstanceWidthSecondValue = 2f;
                        setCaretInstanceXSecondValue = true;
                        CaretInstanceXSecondValue = 5f;
                        if (interpolationValue >= 1)
                        {
                            this.CaretInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                        }
                        setCaretInstanceYSecondValue = true;
                        CaretInstanceYSecondValue = 2f;
                        if (interpolationValue >= 1)
                        {
                            this.ClipsChildren = true;
                        }
                        setHeightSecondValue = true;
                        HeightSecondValue = 30f;
                        setSelectionInstanceBlueSecondValue = true;
                        SelectionInstanceBlueSecondValue = 170;
                        setSelectionInstanceCurrentColorCategoryStateSecondValue = true;
                        SelectionInstanceCurrentColorCategoryStateSecondValue = JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Gray;
                        setSelectionInstanceGreenSecondValue = true;
                        SelectionInstanceGreenSecondValue = 205;
                        setSelectionInstanceHeightSecondValue = true;
                        SelectionInstanceHeightSecondValue = -2f;
                        if (interpolationValue >= 1)
                        {
                            this.SelectionInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        setSelectionInstanceRedSecondValue = true;
                        SelectionInstanceRedSecondValue = 102;
                        setSelectionInstanceWidthSecondValue = true;
                        SelectionInstanceWidthSecondValue = 27f;
                        setSelectionInstanceXSecondValue = true;
                        SelectionInstanceXSecondValue = 31f;
                        setSelectionInstanceYSecondValue = true;
                        SelectionInstanceYSecondValue = 1f;
                        setTextInstanceCurrentColorCategoryStateSecondValue = true;
                        TextInstanceCurrentColorCategoryStateSecondValue = JHP4SD.GumRuntimes.TextRuntime.ColorCategory.Black;
                        setTextInstanceHeightSecondValue = true;
                        TextInstanceHeightSecondValue = 20f;
                        if (interpolationValue >= 1)
                        {
                            this.TextInstance.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.TextInstance.Text = "Hello";
                        }
                        if (interpolationValue >= 1)
                        {
                            this.TextInstance.VerticalAlignment = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        setTextInstanceWidthSecondValue = true;
                        TextInstanceWidthSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.TextInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                        }
                        setTextInstanceXSecondValue = true;
                        TextInstanceXSecondValue = 5f;
                        if (interpolationValue >= 1)
                        {
                            this.TextInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.TextInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                        }
                        setTextInstanceYSecondValue = true;
                        TextInstanceYSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.TextInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.TextInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setWidthSecondValue = true;
                        WidthSecondValue = 220f;
                        break;
                }
                var wasSuppressed = mIsLayoutSuspended;
                if (wasSuppressed == false)
                {
                    SuspendLayout(true);
                }
                if (setBackgroundInstanceHeightFirstValue && setBackgroundInstanceHeightSecondValue)
                {
                    BackgroundInstance.Height = BackgroundInstanceHeightFirstValue * (1 - interpolationValue) + BackgroundInstanceHeightSecondValue * interpolationValue;
                }
                if (setBackgroundInstanceWidthFirstValue && setBackgroundInstanceWidthSecondValue)
                {
                    BackgroundInstance.Width = BackgroundInstanceWidthFirstValue * (1 - interpolationValue) + BackgroundInstanceWidthSecondValue * interpolationValue;
                }
                if (setBackgroundInstanceXFirstValue && setBackgroundInstanceXSecondValue)
                {
                    BackgroundInstance.X = BackgroundInstanceXFirstValue * (1 - interpolationValue) + BackgroundInstanceXSecondValue * interpolationValue;
                }
                if (setBackgroundInstanceYFirstValue && setBackgroundInstanceYSecondValue)
                {
                    BackgroundInstance.Y = BackgroundInstanceYFirstValue * (1 - interpolationValue) + BackgroundInstanceYSecondValue * interpolationValue;
                }
                if (setCaretInstanceBlueFirstValue && setCaretInstanceBlueSecondValue)
                {
                    CaretInstance.Blue = FlatRedBall.Math.MathFunctions.RoundToInt(CaretInstanceBlueFirstValue* (1 - interpolationValue) + CaretInstanceBlueSecondValue * interpolationValue);
                }
                if (setCaretInstanceGreenFirstValue && setCaretInstanceGreenSecondValue)
                {
                    CaretInstance.Green = FlatRedBall.Math.MathFunctions.RoundToInt(CaretInstanceGreenFirstValue* (1 - interpolationValue) + CaretInstanceGreenSecondValue * interpolationValue);
                }
                if (setCaretInstanceHeightFirstValue && setCaretInstanceHeightSecondValue)
                {
                    CaretInstance.Height = CaretInstanceHeightFirstValue * (1 - interpolationValue) + CaretInstanceHeightSecondValue * interpolationValue;
                }
                if (setCaretInstanceRedFirstValue && setCaretInstanceRedSecondValue)
                {
                    CaretInstance.Red = FlatRedBall.Math.MathFunctions.RoundToInt(CaretInstanceRedFirstValue* (1 - interpolationValue) + CaretInstanceRedSecondValue * interpolationValue);
                }
                if (setCaretInstanceWidthFirstValue && setCaretInstanceWidthSecondValue)
                {
                    CaretInstance.Width = CaretInstanceWidthFirstValue * (1 - interpolationValue) + CaretInstanceWidthSecondValue * interpolationValue;
                }
                if (setCaretInstanceXFirstValue && setCaretInstanceXSecondValue)
                {
                    CaretInstance.X = CaretInstanceXFirstValue * (1 - interpolationValue) + CaretInstanceXSecondValue * interpolationValue;
                }
                if (setCaretInstanceYFirstValue && setCaretInstanceYSecondValue)
                {
                    CaretInstance.Y = CaretInstanceYFirstValue * (1 - interpolationValue) + CaretInstanceYSecondValue * interpolationValue;
                }
                if (setHeightFirstValue && setHeightSecondValue)
                {
                    Height = HeightFirstValue * (1 - interpolationValue) + HeightSecondValue * interpolationValue;
                }
                if (setSelectionInstanceBlueFirstValue && setSelectionInstanceBlueSecondValue)
                {
                    SelectionInstance.Blue = FlatRedBall.Math.MathFunctions.RoundToInt(SelectionInstanceBlueFirstValue* (1 - interpolationValue) + SelectionInstanceBlueSecondValue * interpolationValue);
                }
                if (setSelectionInstanceCurrentColorCategoryStateFirstValue && setSelectionInstanceCurrentColorCategoryStateSecondValue)
                {
                    SelectionInstance.InterpolateBetween(SelectionInstanceCurrentColorCategoryStateFirstValue, SelectionInstanceCurrentColorCategoryStateSecondValue, interpolationValue);
                }
                if (setSelectionInstanceGreenFirstValue && setSelectionInstanceGreenSecondValue)
                {
                    SelectionInstance.Green = FlatRedBall.Math.MathFunctions.RoundToInt(SelectionInstanceGreenFirstValue* (1 - interpolationValue) + SelectionInstanceGreenSecondValue * interpolationValue);
                }
                if (setSelectionInstanceHeightFirstValue && setSelectionInstanceHeightSecondValue)
                {
                    SelectionInstance.Height = SelectionInstanceHeightFirstValue * (1 - interpolationValue) + SelectionInstanceHeightSecondValue * interpolationValue;
                }
                if (setSelectionInstanceRedFirstValue && setSelectionInstanceRedSecondValue)
                {
                    SelectionInstance.Red = FlatRedBall.Math.MathFunctions.RoundToInt(SelectionInstanceRedFirstValue* (1 - interpolationValue) + SelectionInstanceRedSecondValue * interpolationValue);
                }
                if (setSelectionInstanceWidthFirstValue && setSelectionInstanceWidthSecondValue)
                {
                    SelectionInstance.Width = SelectionInstanceWidthFirstValue * (1 - interpolationValue) + SelectionInstanceWidthSecondValue * interpolationValue;
                }
                if (setSelectionInstanceXFirstValue && setSelectionInstanceXSecondValue)
                {
                    SelectionInstance.X = SelectionInstanceXFirstValue * (1 - interpolationValue) + SelectionInstanceXSecondValue * interpolationValue;
                }
                if (setSelectionInstanceYFirstValue && setSelectionInstanceYSecondValue)
                {
                    SelectionInstance.Y = SelectionInstanceYFirstValue * (1 - interpolationValue) + SelectionInstanceYSecondValue * interpolationValue;
                }
                if (setTextInstanceCurrentColorCategoryStateFirstValue && setTextInstanceCurrentColorCategoryStateSecondValue)
                {
                    TextInstance.InterpolateBetween(TextInstanceCurrentColorCategoryStateFirstValue, TextInstanceCurrentColorCategoryStateSecondValue, interpolationValue);
                }
                if (setTextInstanceHeightFirstValue && setTextInstanceHeightSecondValue)
                {
                    TextInstance.Height = TextInstanceHeightFirstValue * (1 - interpolationValue) + TextInstanceHeightSecondValue * interpolationValue;
                }
                if (setTextInstanceWidthFirstValue && setTextInstanceWidthSecondValue)
                {
                    TextInstance.Width = TextInstanceWidthFirstValue * (1 - interpolationValue) + TextInstanceWidthSecondValue * interpolationValue;
                }
                if (setTextInstanceXFirstValue && setTextInstanceXSecondValue)
                {
                    TextInstance.X = TextInstanceXFirstValue * (1 - interpolationValue) + TextInstanceXSecondValue * interpolationValue;
                }
                if (setTextInstanceYFirstValue && setTextInstanceYSecondValue)
                {
                    TextInstance.Y = TextInstanceYFirstValue * (1 - interpolationValue) + TextInstanceYSecondValue * interpolationValue;
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
            public void InterpolateBetween (TextBoxCategory firstState, TextBoxCategory secondState, float interpolationValue) 
            {
                #if DEBUG
                if (float.IsNaN(interpolationValue))
                {
                    throw new System.Exception("interpolationValue cannot be NaN");
                }
                #endif
                switch(firstState)
                {
                    case  TextBoxCategory.Enabled:
                        break;
                    case  TextBoxCategory.Disabled:
                        break;
                    case  TextBoxCategory.Highlighted:
                        break;
                    case  TextBoxCategory.Selected:
                        break;
                }
                switch(secondState)
                {
                    case  TextBoxCategory.Enabled:
                        break;
                    case  TextBoxCategory.Disabled:
                        break;
                    case  TextBoxCategory.Highlighted:
                        break;
                    case  TextBoxCategory.Selected:
                        break;
                }
                var wasSuppressed = mIsLayoutSuspended;
                if (wasSuppressed == false)
                {
                    SuspendLayout(true);
                }
                if (interpolationValue < 1)
                {
                    mCurrentTextBoxCategoryState = firstState;
                }
                else
                {
                    mCurrentTextBoxCategoryState = secondState;
                }
                if (!wasSuppressed)
                {
                    ResumeLayout(true);
                }
            }
            public void InterpolateBetween (LineModeCategory firstState, LineModeCategory secondState, float interpolationValue) 
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
                bool setSelectionInstanceHeightFirstValue = false;
                bool setSelectionInstanceHeightSecondValue = false;
                float SelectionInstanceHeightFirstValue= 0;
                float SelectionInstanceHeightSecondValue= 0;
                bool setTextInstanceHeightFirstValue = false;
                bool setTextInstanceHeightSecondValue = false;
                float TextInstanceHeightFirstValue= 0;
                float TextInstanceHeightSecondValue= 0;
                bool setTextInstanceWidthFirstValue = false;
                bool setTextInstanceWidthSecondValue = false;
                float TextInstanceWidthFirstValue= 0;
                float TextInstanceWidthSecondValue= 0;
                bool setTextInstanceYFirstValue = false;
                bool setTextInstanceYSecondValue = false;
                float TextInstanceYFirstValue= 0;
                float TextInstanceYSecondValue= 0;
                switch(firstState)
                {
                    case  LineModeCategory.Single:
                        setHeightFirstValue = true;
                        HeightFirstValue = 30f;
                        setSelectionInstanceHeightFirstValue = true;
                        SelectionInstanceHeightFirstValue = -2f;
                        if (interpolationValue < 1)
                        {
                            this.SelectionInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        setTextInstanceHeightFirstValue = true;
                        TextInstanceHeightFirstValue = 20f;
                        if (interpolationValue < 1)
                        {
                            this.TextInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        if (interpolationValue < 1)
                        {
                            this.TextInstance.VerticalAlignment = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        setTextInstanceWidthFirstValue = true;
                        TextInstanceWidthFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.TextInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                        }
                        if (interpolationValue < 1)
                        {
                            this.TextInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                        }
                        setTextInstanceYFirstValue = true;
                        TextInstanceYFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.TextInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.TextInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        break;
                    case  LineModeCategory.Multi:
                        setHeightFirstValue = true;
                        HeightFirstValue = 110f;
                        setSelectionInstanceHeightFirstValue = true;
                        SelectionInstanceHeightFirstValue = 27f;
                        if (interpolationValue < 1)
                        {
                            this.SelectionInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        setTextInstanceHeightFirstValue = true;
                        TextInstanceHeightFirstValue = -10f;
                        if (interpolationValue < 1)
                        {
                            this.TextInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        if (interpolationValue < 1)
                        {
                            this.TextInstance.VerticalAlignment = RenderingLibrary.Graphics.VerticalAlignment.Top;
                        }
                        setTextInstanceWidthFirstValue = true;
                        TextInstanceWidthFirstValue = -10f;
                        if (interpolationValue < 1)
                        {
                            this.TextInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        if (interpolationValue < 1)
                        {
                            this.TextInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                        }
                        setTextInstanceYFirstValue = true;
                        TextInstanceYFirstValue = 5f;
                        if (interpolationValue < 1)
                        {
                            this.TextInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Top;
                        }
                        if (interpolationValue < 1)
                        {
                            this.TextInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                        }
                        break;
                }
                switch(secondState)
                {
                    case  LineModeCategory.Single:
                        setHeightSecondValue = true;
                        HeightSecondValue = 30f;
                        setSelectionInstanceHeightSecondValue = true;
                        SelectionInstanceHeightSecondValue = -2f;
                        if (interpolationValue >= 1)
                        {
                            this.SelectionInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        setTextInstanceHeightSecondValue = true;
                        TextInstanceHeightSecondValue = 20f;
                        if (interpolationValue >= 1)
                        {
                            this.TextInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.TextInstance.VerticalAlignment = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        setTextInstanceWidthSecondValue = true;
                        TextInstanceWidthSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.TextInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.TextInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                        }
                        setTextInstanceYSecondValue = true;
                        TextInstanceYSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.TextInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.TextInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        break;
                    case  LineModeCategory.Multi:
                        setHeightSecondValue = true;
                        HeightSecondValue = 110f;
                        setSelectionInstanceHeightSecondValue = true;
                        SelectionInstanceHeightSecondValue = 27f;
                        if (interpolationValue >= 1)
                        {
                            this.SelectionInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        setTextInstanceHeightSecondValue = true;
                        TextInstanceHeightSecondValue = -10f;
                        if (interpolationValue >= 1)
                        {
                            this.TextInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.TextInstance.VerticalAlignment = RenderingLibrary.Graphics.VerticalAlignment.Top;
                        }
                        setTextInstanceWidthSecondValue = true;
                        TextInstanceWidthSecondValue = -10f;
                        if (interpolationValue >= 1)
                        {
                            this.TextInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.TextInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                        }
                        setTextInstanceYSecondValue = true;
                        TextInstanceYSecondValue = 5f;
                        if (interpolationValue >= 1)
                        {
                            this.TextInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Top;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.TextInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
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
                if (setSelectionInstanceHeightFirstValue && setSelectionInstanceHeightSecondValue)
                {
                    SelectionInstance.Height = SelectionInstanceHeightFirstValue * (1 - interpolationValue) + SelectionInstanceHeightSecondValue * interpolationValue;
                }
                if (setTextInstanceHeightFirstValue && setTextInstanceHeightSecondValue)
                {
                    TextInstance.Height = TextInstanceHeightFirstValue * (1 - interpolationValue) + TextInstanceHeightSecondValue * interpolationValue;
                }
                if (setTextInstanceWidthFirstValue && setTextInstanceWidthSecondValue)
                {
                    TextInstance.Width = TextInstanceWidthFirstValue * (1 - interpolationValue) + TextInstanceWidthSecondValue * interpolationValue;
                }
                if (setTextInstanceYFirstValue && setTextInstanceYSecondValue)
                {
                    TextInstance.Y = TextInstanceYFirstValue * (1 - interpolationValue) + TextInstanceYSecondValue * interpolationValue;
                }
                if (interpolationValue < 1)
                {
                    mCurrentLineModeCategoryState = firstState;
                }
                else
                {
                    mCurrentLineModeCategoryState = secondState;
                }
                if (!wasSuppressed)
                {
                    ResumeLayout(true);
                }
            }
            #endregion
            #region State Interpolate To
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (JHP4SD.GumRuntimes.DefaultForms.TextBoxRuntime.VariableState fromState,JHP4SD.GumRuntimes.DefaultForms.TextBoxRuntime.VariableState toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null) 
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
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (JHP4SD.GumRuntimes.DefaultForms.TextBoxRuntime.TextBoxCategory fromState,JHP4SD.GumRuntimes.DefaultForms.TextBoxRuntime.TextBoxCategory toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null) 
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
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (TextBoxCategory toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null ) 
            {
                Gum.DataTypes.Variables.StateSave current = GetCurrentValuesOnState(toState);
                Gum.DataTypes.Variables.StateSave toAsStateSave = this.ElementSave.Categories.First(item => item.Name == "TextBoxCategory").States.First(item => item.Name == toState.ToString());
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
                tweener.Ended += ()=> this.CurrentTextBoxCategoryState = toState;
                tweener.Start();
                StateInterpolationPlugin.TweenerManager.Self.Add(tweener);
                return tweener;
            }
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateToRelative (TextBoxCategory toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null ) 
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
                tweener.Ended += ()=> this.CurrentTextBoxCategoryState = toState;
                tweener.Start();
                StateInterpolationPlugin.TweenerManager.Self.Add(tweener);
                return tweener;
            }
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (JHP4SD.GumRuntimes.DefaultForms.TextBoxRuntime.LineModeCategory fromState,JHP4SD.GumRuntimes.DefaultForms.TextBoxRuntime.LineModeCategory toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null) 
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
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (LineModeCategory toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null ) 
            {
                Gum.DataTypes.Variables.StateSave current = GetCurrentValuesOnState(toState);
                Gum.DataTypes.Variables.StateSave toAsStateSave = this.ElementSave.Categories.First(item => item.Name == "LineModeCategory").States.First(item => item.Name == toState.ToString());
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
                tweener.Ended += ()=> this.CurrentLineModeCategoryState = toState;
                tweener.Start();
                StateInterpolationPlugin.TweenerManager.Self.Add(tweener);
                return tweener;
            }
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateToRelative (LineModeCategory toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null ) 
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
                tweener.Ended += ()=> this.CurrentLineModeCategoryState = toState;
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
                BackgroundInstance.StopAnimations();
                SelectionInstance.StopAnimations();
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
                            Name = "Width",
                            Type = "float",
                            Value = Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackgroundInstance.Height",
                            Type = "float",
                            Value = BackgroundInstance.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackgroundInstance.Height Units",
                            Type = "DimensionUnitType",
                            Value = BackgroundInstance.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackgroundInstance.Width",
                            Type = "float",
                            Value = BackgroundInstance.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackgroundInstance.Width Units",
                            Type = "DimensionUnitType",
                            Value = BackgroundInstance.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackgroundInstance.X",
                            Type = "float",
                            Value = BackgroundInstance.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackgroundInstance.X Origin",
                            Type = "HorizontalAlignment",
                            Value = BackgroundInstance.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackgroundInstance.X Units",
                            Type = "PositionUnitType",
                            Value = BackgroundInstance.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackgroundInstance.Y",
                            Type = "float",
                            Value = BackgroundInstance.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackgroundInstance.Y Origin",
                            Type = "VerticalAlignment",
                            Value = BackgroundInstance.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackgroundInstance.Y Units",
                            Type = "PositionUnitType",
                            Value = BackgroundInstance.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SelectionInstance.Blue",
                            Type = "int",
                            Value = SelectionInstance.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SelectionInstance.ColorCategoryState",
                            Type = "ColorCategoryState",
                            Value = SelectionInstance.CurrentColorCategoryState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SelectionInstance.Green",
                            Type = "int",
                            Value = SelectionInstance.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SelectionInstance.Height",
                            Type = "float",
                            Value = SelectionInstance.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SelectionInstance.Height Units",
                            Type = "DimensionUnitType",
                            Value = SelectionInstance.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SelectionInstance.Red",
                            Type = "int",
                            Value = SelectionInstance.Red
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SelectionInstance.Width",
                            Type = "float",
                            Value = SelectionInstance.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SelectionInstance.X",
                            Type = "float",
                            Value = SelectionInstance.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SelectionInstance.Y",
                            Type = "float",
                            Value = SelectionInstance.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.ColorCategoryState",
                            Type = "ColorCategoryState",
                            Value = TextInstance.CurrentColorCategoryState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Height",
                            Type = "float",
                            Value = TextInstance.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.HorizontalAlignment",
                            Type = "HorizontalAlignment",
                            Value = TextInstance.HorizontalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Text",
                            Type = "string",
                            Value = TextInstance.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.VerticalAlignment",
                            Type = "VerticalAlignment",
                            Value = TextInstance.VerticalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Width",
                            Type = "float",
                            Value = TextInstance.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Width Units",
                            Type = "DimensionUnitType",
                            Value = TextInstance.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.X",
                            Type = "float",
                            Value = TextInstance.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.X Origin",
                            Type = "HorizontalAlignment",
                            Value = TextInstance.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.X Units",
                            Type = "PositionUnitType",
                            Value = TextInstance.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Y",
                            Type = "float",
                            Value = TextInstance.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Y Origin",
                            Type = "VerticalAlignment",
                            Value = TextInstance.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Y Units",
                            Type = "PositionUnitType",
                            Value = TextInstance.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CaretInstance.Blue",
                            Type = "int",
                            Value = CaretInstance.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CaretInstance.Green",
                            Type = "int",
                            Value = CaretInstance.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CaretInstance.Height",
                            Type = "float",
                            Value = CaretInstance.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CaretInstance.Red",
                            Type = "int",
                            Value = CaretInstance.Red
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CaretInstance.Width",
                            Type = "float",
                            Value = CaretInstance.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CaretInstance.X",
                            Type = "float",
                            Value = CaretInstance.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CaretInstance.X Units",
                            Type = "PositionUnitType",
                            Value = CaretInstance.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CaretInstance.Y",
                            Type = "float",
                            Value = CaretInstance.Y
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
                            Value = Height + 30f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Width",
                            Type = "float",
                            Value = Width + 220f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackgroundInstance.Height",
                            Type = "float",
                            Value = BackgroundInstance.Height + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackgroundInstance.Height Units",
                            Type = "DimensionUnitType",
                            Value = BackgroundInstance.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackgroundInstance.Width",
                            Type = "float",
                            Value = BackgroundInstance.Width + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackgroundInstance.Width Units",
                            Type = "DimensionUnitType",
                            Value = BackgroundInstance.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackgroundInstance.X",
                            Type = "float",
                            Value = BackgroundInstance.X + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackgroundInstance.X Origin",
                            Type = "HorizontalAlignment",
                            Value = BackgroundInstance.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackgroundInstance.X Units",
                            Type = "PositionUnitType",
                            Value = BackgroundInstance.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackgroundInstance.Y",
                            Type = "float",
                            Value = BackgroundInstance.Y + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackgroundInstance.Y Origin",
                            Type = "VerticalAlignment",
                            Value = BackgroundInstance.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackgroundInstance.Y Units",
                            Type = "PositionUnitType",
                            Value = BackgroundInstance.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SelectionInstance.Blue",
                            Type = "int",
                            Value = SelectionInstance.Blue + 170
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SelectionInstance.ColorCategoryState",
                            Type = "ColorCategoryState",
                            Value = SelectionInstance.CurrentColorCategoryState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SelectionInstance.Green",
                            Type = "int",
                            Value = SelectionInstance.Green + 205
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SelectionInstance.Height",
                            Type = "float",
                            Value = SelectionInstance.Height + -2f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SelectionInstance.Height Units",
                            Type = "DimensionUnitType",
                            Value = SelectionInstance.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SelectionInstance.Red",
                            Type = "int",
                            Value = SelectionInstance.Red + 102
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SelectionInstance.Width",
                            Type = "float",
                            Value = SelectionInstance.Width + 27f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SelectionInstance.X",
                            Type = "float",
                            Value = SelectionInstance.X + 31f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SelectionInstance.Y",
                            Type = "float",
                            Value = SelectionInstance.Y + 1f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.ColorCategoryState",
                            Type = "ColorCategoryState",
                            Value = TextInstance.CurrentColorCategoryState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Height",
                            Type = "float",
                            Value = TextInstance.Height + 20f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.HorizontalAlignment",
                            Type = "HorizontalAlignment",
                            Value = TextInstance.HorizontalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Text",
                            Type = "string",
                            Value = TextInstance.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.VerticalAlignment",
                            Type = "VerticalAlignment",
                            Value = TextInstance.VerticalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Width",
                            Type = "float",
                            Value = TextInstance.Width + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Width Units",
                            Type = "DimensionUnitType",
                            Value = TextInstance.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.X",
                            Type = "float",
                            Value = TextInstance.X + 5f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.X Origin",
                            Type = "HorizontalAlignment",
                            Value = TextInstance.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.X Units",
                            Type = "PositionUnitType",
                            Value = TextInstance.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Y",
                            Type = "float",
                            Value = TextInstance.Y + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Y Origin",
                            Type = "VerticalAlignment",
                            Value = TextInstance.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Y Units",
                            Type = "PositionUnitType",
                            Value = TextInstance.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CaretInstance.Blue",
                            Type = "int",
                            Value = CaretInstance.Blue + 49
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CaretInstance.Green",
                            Type = "int",
                            Value = CaretInstance.Green + 49
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CaretInstance.Height",
                            Type = "float",
                            Value = CaretInstance.Height + 22f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CaretInstance.Red",
                            Type = "int",
                            Value = CaretInstance.Red + 49
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CaretInstance.Width",
                            Type = "float",
                            Value = CaretInstance.Width + 2f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CaretInstance.X",
                            Type = "float",
                            Value = CaretInstance.X + 5f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CaretInstance.X Units",
                            Type = "PositionUnitType",
                            Value = CaretInstance.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CaretInstance.Y",
                            Type = "float",
                            Value = CaretInstance.Y + 2f
                        }
                        );
                        break;
                }
                return newState;
            }
            private Gum.DataTypes.Variables.StateSave GetCurrentValuesOnState (TextBoxCategory state) 
            {
                Gum.DataTypes.Variables.StateSave newState = new Gum.DataTypes.Variables.StateSave();
                switch(state)
                {
                    case  TextBoxCategory.Enabled:
                        break;
                    case  TextBoxCategory.Disabled:
                        break;
                    case  TextBoxCategory.Highlighted:
                        break;
                    case  TextBoxCategory.Selected:
                        break;
                }
                return newState;
            }
            private Gum.DataTypes.Variables.StateSave AddToCurrentValuesWithState (TextBoxCategory state) 
            {
                Gum.DataTypes.Variables.StateSave newState = new Gum.DataTypes.Variables.StateSave();
                switch(state)
                {
                    case  TextBoxCategory.Enabled:
                        break;
                    case  TextBoxCategory.Disabled:
                        break;
                    case  TextBoxCategory.Highlighted:
                        break;
                    case  TextBoxCategory.Selected:
                        break;
                }
                return newState;
            }
            private Gum.DataTypes.Variables.StateSave GetCurrentValuesOnState (LineModeCategory state) 
            {
                Gum.DataTypes.Variables.StateSave newState = new Gum.DataTypes.Variables.StateSave();
                switch(state)
                {
                    case  LineModeCategory.Single:
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
                            Name = "SelectionInstance.Height",
                            Type = "float",
                            Value = SelectionInstance.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SelectionInstance.Height Units",
                            Type = "DimensionUnitType",
                            Value = SelectionInstance.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Height",
                            Type = "float",
                            Value = TextInstance.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Height Units",
                            Type = "DimensionUnitType",
                            Value = TextInstance.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.VerticalAlignment",
                            Type = "VerticalAlignment",
                            Value = TextInstance.VerticalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Width",
                            Type = "float",
                            Value = TextInstance.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Width Units",
                            Type = "DimensionUnitType",
                            Value = TextInstance.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.X Units",
                            Type = "PositionUnitType",
                            Value = TextInstance.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Y",
                            Type = "float",
                            Value = TextInstance.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Y Origin",
                            Type = "VerticalAlignment",
                            Value = TextInstance.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Y Units",
                            Type = "PositionUnitType",
                            Value = TextInstance.YUnits
                        }
                        );
                        break;
                    case  LineModeCategory.Multi:
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
                            Name = "SelectionInstance.Height",
                            Type = "float",
                            Value = SelectionInstance.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SelectionInstance.Height Units",
                            Type = "DimensionUnitType",
                            Value = SelectionInstance.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Height",
                            Type = "float",
                            Value = TextInstance.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Height Units",
                            Type = "Gum.DataTypes.DimensionUnitType",
                            Value = TextInstance.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.VerticalAlignment",
                            Type = "VerticalAlignment",
                            Value = TextInstance.VerticalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Width",
                            Type = "float",
                            Value = TextInstance.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Width Units",
                            Type = "DimensionUnitType",
                            Value = TextInstance.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.X Units",
                            Type = "PositionUnitType",
                            Value = TextInstance.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Y",
                            Type = "float",
                            Value = TextInstance.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Y Origin",
                            Type = "VerticalAlignment",
                            Value = TextInstance.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Y Units",
                            Type = "PositionUnitType",
                            Value = TextInstance.YUnits
                        }
                        );
                        break;
                }
                return newState;
            }
            private Gum.DataTypes.Variables.StateSave AddToCurrentValuesWithState (LineModeCategory state) 
            {
                Gum.DataTypes.Variables.StateSave newState = new Gum.DataTypes.Variables.StateSave();
                switch(state)
                {
                    case  LineModeCategory.Single:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Height",
                            Type = "float",
                            Value = Height + 30f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SelectionInstance.Height",
                            Type = "float",
                            Value = SelectionInstance.Height + -2f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SelectionInstance.Height Units",
                            Type = "DimensionUnitType",
                            Value = SelectionInstance.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Height",
                            Type = "float",
                            Value = TextInstance.Height + 20f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Height Units",
                            Type = "DimensionUnitType",
                            Value = TextInstance.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.VerticalAlignment",
                            Type = "VerticalAlignment",
                            Value = TextInstance.VerticalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Width",
                            Type = "float",
                            Value = TextInstance.Width + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Width Units",
                            Type = "DimensionUnitType",
                            Value = TextInstance.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.X Units",
                            Type = "PositionUnitType",
                            Value = TextInstance.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Y",
                            Type = "float",
                            Value = TextInstance.Y + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Y Origin",
                            Type = "VerticalAlignment",
                            Value = TextInstance.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Y Units",
                            Type = "PositionUnitType",
                            Value = TextInstance.YUnits
                        }
                        );
                        break;
                    case  LineModeCategory.Multi:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Height",
                            Type = "float",
                            Value = Height + 110f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SelectionInstance.Height",
                            Type = "float",
                            Value = SelectionInstance.Height + 27f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SelectionInstance.Height Units",
                            Type = "DimensionUnitType",
                            Value = SelectionInstance.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Height",
                            Type = "float",
                            Value = TextInstance.Height + -10f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Height Units",
                            Type = "Gum.DataTypes.DimensionUnitType",
                            Value = TextInstance.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.VerticalAlignment",
                            Type = "VerticalAlignment",
                            Value = TextInstance.VerticalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Width",
                            Type = "float",
                            Value = TextInstance.Width + -10f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Width Units",
                            Type = "DimensionUnitType",
                            Value = TextInstance.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.X Units",
                            Type = "PositionUnitType",
                            Value = TextInstance.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Y",
                            Type = "float",
                            Value = TextInstance.Y + 5f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Y Origin",
                            Type = "VerticalAlignment",
                            Value = TextInstance.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Y Units",
                            Type = "PositionUnitType",
                            Value = TextInstance.YUnits
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
                    else if (category.Name == "TextBoxCategory")
                    {
                        if(state.Name == "Enabled") this.mCurrentTextBoxCategoryState = TextBoxCategory.Enabled;
                        if(state.Name == "Disabled") this.mCurrentTextBoxCategoryState = TextBoxCategory.Disabled;
                        if(state.Name == "Highlighted") this.mCurrentTextBoxCategoryState = TextBoxCategory.Highlighted;
                        if(state.Name == "Selected") this.mCurrentTextBoxCategoryState = TextBoxCategory.Selected;
                    }
                    else if (category.Name == "LineModeCategory")
                    {
                        if(state.Name == "Single") this.mCurrentLineModeCategoryState = LineModeCategory.Single;
                        if(state.Name == "Multi") this.mCurrentLineModeCategoryState = LineModeCategory.Multi;
                    }
                }
                base.ApplyState(state);
            }
            private bool tryCreateFormsObject;
            public JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime BackgroundInstance { get; set; }
            public JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime SelectionInstance { get; set; }
            public JHP4SD.GumRuntimes.TextRuntime TextInstance { get; set; }
            public JHP4SD.GumRuntimes.ColoredRectangleRuntime CaretInstance { get; set; }
            public string Text
            {
                get
                {
                    return TextInstance.Text;
                }
                set
                {
                    if (TextInstance.Text != value)
                    {
                        TextInstance.Text = value;
                        TextChanged?.Invoke(this, null);
                    }
                }
            }
            public event System.EventHandler TextChanged;
            public TextBoxRuntime (bool fullInstantiation = true, bool tryCreateFormsObject = true) 
            	: base(false, tryCreateFormsObject)
            {
                this.tryCreateFormsObject = tryCreateFormsObject;
                if (fullInstantiation)
                {
                    Gum.DataTypes.ElementSave elementSave = Gum.Managers.ObjectFinder.Self.GumProjectSave.Components.First(item => item.Name == "DefaultForms/TextBox");
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
                BackgroundInstance = this.GetGraphicalUiElementByName("BackgroundInstance") as JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime;
                SelectionInstance = this.GetGraphicalUiElementByName("SelectionInstance") as JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime;
                TextInstance = this.GetGraphicalUiElementByName("TextInstance") as JHP4SD.GumRuntimes.TextRuntime;
                CaretInstance = this.GetGraphicalUiElementByName("CaretInstance") as JHP4SD.GumRuntimes.ColoredRectangleRuntime;
                if (tryCreateFormsObject)
                {
                    FormsControlAsObject = new FlatRedBall.Forms.Controls.TextBox(this);
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
            public FlatRedBall.Forms.Controls.TextBox FormsControl {get => (FlatRedBall.Forms.Controls.TextBox) FormsControlAsObject;}
        }
    }
