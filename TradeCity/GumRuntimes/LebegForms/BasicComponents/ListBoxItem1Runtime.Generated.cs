    using System.Linq;
    namespace JHP4SD.GumRuntimes.LebegForms.BasicComponents
    {
        public partial class ListBoxItem1Runtime : JHP4SD.GumRuntimes.ContainerRuntime
        {
            #region State Enums
            public enum VariableState
            {
                Default
            }
            public enum ListBoxItemCategory
            {
                Enabled,
                Highlighted,
                Selected,
                Focused
            }
            #endregion
            #region State Fields
            VariableState mCurrentVariableState;
            ListBoxItemCategory? mCurrentListBoxItemCategoryState;
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
                            TextInstance.CurrentColorCategoryState = JHP4SD.GumRuntimes.TextRuntime.ColorCategory.Black;
                            Height = 32f;
                            Width = 0f;
                            WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
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
                            TextInstance.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                            TextInstance.VerticalAlignment = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            TextInstance.Width = 0f;
                            TextInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                            TextInstance.X = 8f;
                            TextInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                            TextInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                            TextInstance.Y = 0f;
                            TextInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            TextInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            RectangleInstance.Height = 0f;
                            RectangleInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                            RectangleInstance.Visible = false;
                            RectangleInstance.Width = 0f;
                            RectangleInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                            RectangleInstance.X = 0f;
                            RectangleInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                            RectangleInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            RectangleInstance.Y = 0f;
                            RectangleInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            RectangleInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            break;
                    }
                }
            }
            public ListBoxItemCategory? CurrentListBoxItemCategoryState
            {
                get
                {
                    return mCurrentListBoxItemCategoryState;
                }
                set
                {
                    if (value != null)
                    {
                        mCurrentListBoxItemCategoryState = value;
                        switch(mCurrentListBoxItemCategoryState)
                        {
                            case  ListBoxItemCategory.Enabled:
                                BackgroundInstance.CurrentColorCategoryState = JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Gray;
                                RectangleInstance.Visible = false;
                                break;
                            case  ListBoxItemCategory.Highlighted:
                                BackgroundInstance.CurrentColorCategoryState = JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Yellow;
                                BackgroundInstance.X = 0f;
                                BackgroundInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                                BackgroundInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                                BackgroundInstance.Y = 0f;
                                BackgroundInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                                BackgroundInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                                RectangleInstance.Visible = false;
                                break;
                            case  ListBoxItemCategory.Selected:
                                BackgroundInstance.CurrentColorCategoryState = JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Green;
                                RectangleInstance.Visible = false;
                                break;
                            case  ListBoxItemCategory.Focused:
                                BackgroundInstance.CurrentColorCategoryState = JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Gray;
                                RectangleInstance.Visible = true;
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
                bool setHeightFirstValue = false;
                bool setHeightSecondValue = false;
                float HeightFirstValue= 0;
                float HeightSecondValue= 0;
                bool setRectangleInstanceHeightFirstValue = false;
                bool setRectangleInstanceHeightSecondValue = false;
                float RectangleInstanceHeightFirstValue= 0;
                float RectangleInstanceHeightSecondValue= 0;
                bool setRectangleInstanceWidthFirstValue = false;
                bool setRectangleInstanceWidthSecondValue = false;
                float RectangleInstanceWidthFirstValue= 0;
                float RectangleInstanceWidthSecondValue= 0;
                bool setRectangleInstanceXFirstValue = false;
                bool setRectangleInstanceXSecondValue = false;
                float RectangleInstanceXFirstValue= 0;
                float RectangleInstanceXSecondValue= 0;
                bool setRectangleInstanceYFirstValue = false;
                bool setRectangleInstanceYSecondValue = false;
                float RectangleInstanceYFirstValue= 0;
                float RectangleInstanceYSecondValue= 0;
                bool setTextInstanceCurrentColorCategoryStateFirstValue = false;
                bool setTextInstanceCurrentColorCategoryStateSecondValue = false;
                JHP4SD.GumRuntimes.TextRuntime.ColorCategory TextInstanceCurrentColorCategoryStateFirstValue= JHP4SD.GumRuntimes.TextRuntime.ColorCategory.Gray;
                JHP4SD.GumRuntimes.TextRuntime.ColorCategory TextInstanceCurrentColorCategoryStateSecondValue= JHP4SD.GumRuntimes.TextRuntime.ColorCategory.Gray;
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
                        setHeightFirstValue = true;
                        HeightFirstValue = 32f;
                        setRectangleInstanceHeightFirstValue = true;
                        RectangleInstanceHeightFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.RectangleInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        if (interpolationValue < 1)
                        {
                            this.RectangleInstance.Visible = false;
                        }
                        setRectangleInstanceWidthFirstValue = true;
                        RectangleInstanceWidthFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.RectangleInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        setRectangleInstanceXFirstValue = true;
                        RectangleInstanceXFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.RectangleInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.RectangleInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setRectangleInstanceYFirstValue = true;
                        RectangleInstanceYFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.RectangleInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.RectangleInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setTextInstanceCurrentColorCategoryStateFirstValue = true;
                        TextInstanceCurrentColorCategoryStateFirstValue = JHP4SD.GumRuntimes.TextRuntime.ColorCategory.Black;
                        if (interpolationValue < 1)
                        {
                            this.TextInstance.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Left;
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
                        TextInstanceXFirstValue = 8f;
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
                        setHeightSecondValue = true;
                        HeightSecondValue = 32f;
                        setRectangleInstanceHeightSecondValue = true;
                        RectangleInstanceHeightSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.RectangleInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.RectangleInstance.Visible = false;
                        }
                        setRectangleInstanceWidthSecondValue = true;
                        RectangleInstanceWidthSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.RectangleInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        setRectangleInstanceXSecondValue = true;
                        RectangleInstanceXSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.RectangleInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.RectangleInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setRectangleInstanceYSecondValue = true;
                        RectangleInstanceYSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.RectangleInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.RectangleInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setTextInstanceCurrentColorCategoryStateSecondValue = true;
                        TextInstanceCurrentColorCategoryStateSecondValue = JHP4SD.GumRuntimes.TextRuntime.ColorCategory.Black;
                        if (interpolationValue >= 1)
                        {
                            this.TextInstance.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Left;
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
                        TextInstanceXSecondValue = 8f;
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
                if (setHeightFirstValue && setHeightSecondValue)
                {
                    Height = HeightFirstValue * (1 - interpolationValue) + HeightSecondValue * interpolationValue;
                }
                if (setRectangleInstanceHeightFirstValue && setRectangleInstanceHeightSecondValue)
                {
                    RectangleInstance.Height = RectangleInstanceHeightFirstValue * (1 - interpolationValue) + RectangleInstanceHeightSecondValue * interpolationValue;
                }
                if (setRectangleInstanceWidthFirstValue && setRectangleInstanceWidthSecondValue)
                {
                    RectangleInstance.Width = RectangleInstanceWidthFirstValue * (1 - interpolationValue) + RectangleInstanceWidthSecondValue * interpolationValue;
                }
                if (setRectangleInstanceXFirstValue && setRectangleInstanceXSecondValue)
                {
                    RectangleInstance.X = RectangleInstanceXFirstValue * (1 - interpolationValue) + RectangleInstanceXSecondValue * interpolationValue;
                }
                if (setRectangleInstanceYFirstValue && setRectangleInstanceYSecondValue)
                {
                    RectangleInstance.Y = RectangleInstanceYFirstValue * (1 - interpolationValue) + RectangleInstanceYSecondValue * interpolationValue;
                }
                if (setTextInstanceCurrentColorCategoryStateFirstValue && setTextInstanceCurrentColorCategoryStateSecondValue)
                {
                    TextInstance.InterpolateBetween(TextInstanceCurrentColorCategoryStateFirstValue, TextInstanceCurrentColorCategoryStateSecondValue, interpolationValue);
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
            public void InterpolateBetween (ListBoxItemCategory firstState, ListBoxItemCategory secondState, float interpolationValue) 
            {
                #if DEBUG
                if (float.IsNaN(interpolationValue))
                {
                    throw new System.Exception("interpolationValue cannot be NaN");
                }
                #endif
                bool setBackgroundInstanceCurrentColorCategoryStateFirstValue = false;
                bool setBackgroundInstanceCurrentColorCategoryStateSecondValue = false;
                JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory BackgroundInstanceCurrentColorCategoryStateFirstValue= JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Gray;
                JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory BackgroundInstanceCurrentColorCategoryStateSecondValue= JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Gray;
                bool setBackgroundInstanceXFirstValue = false;
                bool setBackgroundInstanceXSecondValue = false;
                float BackgroundInstanceXFirstValue= 0;
                float BackgroundInstanceXSecondValue= 0;
                bool setBackgroundInstanceYFirstValue = false;
                bool setBackgroundInstanceYSecondValue = false;
                float BackgroundInstanceYFirstValue= 0;
                float BackgroundInstanceYSecondValue= 0;
                switch(firstState)
                {
                    case  ListBoxItemCategory.Enabled:
                        setBackgroundInstanceCurrentColorCategoryStateFirstValue = true;
                        BackgroundInstanceCurrentColorCategoryStateFirstValue = JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Gray;
                        if (interpolationValue < 1)
                        {
                            this.RectangleInstance.Visible = false;
                        }
                        break;
                    case  ListBoxItemCategory.Highlighted:
                        setBackgroundInstanceCurrentColorCategoryStateFirstValue = true;
                        BackgroundInstanceCurrentColorCategoryStateFirstValue = JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Yellow;
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
                        if (interpolationValue < 1)
                        {
                            this.RectangleInstance.Visible = false;
                        }
                        break;
                    case  ListBoxItemCategory.Selected:
                        setBackgroundInstanceCurrentColorCategoryStateFirstValue = true;
                        BackgroundInstanceCurrentColorCategoryStateFirstValue = JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Green;
                        if (interpolationValue < 1)
                        {
                            this.RectangleInstance.Visible = false;
                        }
                        break;
                    case  ListBoxItemCategory.Focused:
                        setBackgroundInstanceCurrentColorCategoryStateFirstValue = true;
                        BackgroundInstanceCurrentColorCategoryStateFirstValue = JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Gray;
                        if (interpolationValue < 1)
                        {
                            this.RectangleInstance.Visible = true;
                        }
                        break;
                }
                switch(secondState)
                {
                    case  ListBoxItemCategory.Enabled:
                        setBackgroundInstanceCurrentColorCategoryStateSecondValue = true;
                        BackgroundInstanceCurrentColorCategoryStateSecondValue = JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Gray;
                        if (interpolationValue >= 1)
                        {
                            this.RectangleInstance.Visible = false;
                        }
                        break;
                    case  ListBoxItemCategory.Highlighted:
                        setBackgroundInstanceCurrentColorCategoryStateSecondValue = true;
                        BackgroundInstanceCurrentColorCategoryStateSecondValue = JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Yellow;
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
                        if (interpolationValue >= 1)
                        {
                            this.RectangleInstance.Visible = false;
                        }
                        break;
                    case  ListBoxItemCategory.Selected:
                        setBackgroundInstanceCurrentColorCategoryStateSecondValue = true;
                        BackgroundInstanceCurrentColorCategoryStateSecondValue = JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Green;
                        if (interpolationValue >= 1)
                        {
                            this.RectangleInstance.Visible = false;
                        }
                        break;
                    case  ListBoxItemCategory.Focused:
                        setBackgroundInstanceCurrentColorCategoryStateSecondValue = true;
                        BackgroundInstanceCurrentColorCategoryStateSecondValue = JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Gray;
                        if (interpolationValue >= 1)
                        {
                            this.RectangleInstance.Visible = true;
                        }
                        break;
                }
                var wasSuppressed = mIsLayoutSuspended;
                if (wasSuppressed == false)
                {
                    SuspendLayout(true);
                }
                if (setBackgroundInstanceCurrentColorCategoryStateFirstValue && setBackgroundInstanceCurrentColorCategoryStateSecondValue)
                {
                    BackgroundInstance.InterpolateBetween(BackgroundInstanceCurrentColorCategoryStateFirstValue, BackgroundInstanceCurrentColorCategoryStateSecondValue, interpolationValue);
                }
                if (setBackgroundInstanceXFirstValue && setBackgroundInstanceXSecondValue)
                {
                    BackgroundInstance.X = BackgroundInstanceXFirstValue * (1 - interpolationValue) + BackgroundInstanceXSecondValue * interpolationValue;
                }
                if (setBackgroundInstanceYFirstValue && setBackgroundInstanceYSecondValue)
                {
                    BackgroundInstance.Y = BackgroundInstanceYFirstValue * (1 - interpolationValue) + BackgroundInstanceYSecondValue * interpolationValue;
                }
                if (interpolationValue < 1)
                {
                    mCurrentListBoxItemCategoryState = firstState;
                }
                else
                {
                    mCurrentListBoxItemCategoryState = secondState;
                }
                if (!wasSuppressed)
                {
                    ResumeLayout(true);
                }
            }
            #endregion
            #region State Interpolate To
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (JHP4SD.GumRuntimes.LebegForms.BasicComponents.ListBoxItem1Runtime.VariableState fromState,JHP4SD.GumRuntimes.LebegForms.BasicComponents.ListBoxItem1Runtime.VariableState toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null) 
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
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (JHP4SD.GumRuntimes.LebegForms.BasicComponents.ListBoxItem1Runtime.ListBoxItemCategory fromState,JHP4SD.GumRuntimes.LebegForms.BasicComponents.ListBoxItem1Runtime.ListBoxItemCategory toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null) 
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
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (ListBoxItemCategory toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null ) 
            {
                Gum.DataTypes.Variables.StateSave current = GetCurrentValuesOnState(toState);
                Gum.DataTypes.Variables.StateSave toAsStateSave = this.ElementSave.Categories.First(item => item.Name == "ListBoxItemCategory").States.First(item => item.Name == toState.ToString());
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
                tweener.Ended += ()=> this.CurrentListBoxItemCategoryState = toState;
                tweener.Start();
                StateInterpolationPlugin.TweenerManager.Self.Add(tweener);
                return tweener;
            }
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateToRelative (ListBoxItemCategory toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null ) 
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
                tweener.Ended += ()=> this.CurrentListBoxItemCategoryState = toState;
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
                            Name = "Width Units",
                            Type = "DimensionUnitType",
                            Value = WidthUnits
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
                            Name = "TextInstance.ColorCategoryState",
                            Type = "ColorCategoryState",
                            Value = TextInstance.CurrentColorCategoryState
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
                            Name = "RectangleInstance.Height",
                            Type = "float",
                            Value = RectangleInstance.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RectangleInstance.Height Units",
                            Type = "DimensionUnitType",
                            Value = RectangleInstance.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RectangleInstance.Visible",
                            Type = "bool",
                            Value = RectangleInstance.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RectangleInstance.Width",
                            Type = "float",
                            Value = RectangleInstance.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RectangleInstance.Width Units",
                            Type = "DimensionUnitType",
                            Value = RectangleInstance.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RectangleInstance.X",
                            Type = "float",
                            Value = RectangleInstance.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RectangleInstance.X Origin",
                            Type = "HorizontalAlignment",
                            Value = RectangleInstance.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RectangleInstance.X Units",
                            Type = "PositionUnitType",
                            Value = RectangleInstance.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RectangleInstance.Y",
                            Type = "float",
                            Value = RectangleInstance.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RectangleInstance.Y Origin",
                            Type = "VerticalAlignment",
                            Value = RectangleInstance.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RectangleInstance.Y Units",
                            Type = "PositionUnitType",
                            Value = RectangleInstance.YUnits
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
                            Value = Height + 32f
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
                            Name = "TextInstance.ColorCategoryState",
                            Type = "ColorCategoryState",
                            Value = TextInstance.CurrentColorCategoryState
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
                            Value = TextInstance.X + 8f
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
                            Name = "RectangleInstance.Height",
                            Type = "float",
                            Value = RectangleInstance.Height + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RectangleInstance.Height Units",
                            Type = "DimensionUnitType",
                            Value = RectangleInstance.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RectangleInstance.Visible",
                            Type = "bool",
                            Value = RectangleInstance.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RectangleInstance.Width",
                            Type = "float",
                            Value = RectangleInstance.Width + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RectangleInstance.Width Units",
                            Type = "DimensionUnitType",
                            Value = RectangleInstance.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RectangleInstance.X",
                            Type = "float",
                            Value = RectangleInstance.X + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RectangleInstance.X Origin",
                            Type = "HorizontalAlignment",
                            Value = RectangleInstance.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RectangleInstance.X Units",
                            Type = "PositionUnitType",
                            Value = RectangleInstance.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RectangleInstance.Y",
                            Type = "float",
                            Value = RectangleInstance.Y + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RectangleInstance.Y Origin",
                            Type = "VerticalAlignment",
                            Value = RectangleInstance.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RectangleInstance.Y Units",
                            Type = "PositionUnitType",
                            Value = RectangleInstance.YUnits
                        }
                        );
                        break;
                }
                return newState;
            }
            private Gum.DataTypes.Variables.StateSave GetCurrentValuesOnState (ListBoxItemCategory state) 
            {
                Gum.DataTypes.Variables.StateSave newState = new Gum.DataTypes.Variables.StateSave();
                switch(state)
                {
                    case  ListBoxItemCategory.Enabled:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackgroundInstance.ColorCategoryState",
                            Type = "ColorCategoryState",
                            Value = BackgroundInstance.CurrentColorCategoryState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RectangleInstance.Visible",
                            Type = "bool",
                            Value = RectangleInstance.Visible
                        }
                        );
                        break;
                    case  ListBoxItemCategory.Highlighted:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackgroundInstance.ColorCategoryState",
                            Type = "ColorCategoryState",
                            Value = BackgroundInstance.CurrentColorCategoryState
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
                            Name = "RectangleInstance.Visible",
                            Type = "bool",
                            Value = RectangleInstance.Visible
                        }
                        );
                        break;
                    case  ListBoxItemCategory.Selected:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackgroundInstance.ColorCategoryState",
                            Type = "ColorCategoryState",
                            Value = BackgroundInstance.CurrentColorCategoryState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RectangleInstance.Visible",
                            Type = "bool",
                            Value = RectangleInstance.Visible
                        }
                        );
                        break;
                    case  ListBoxItemCategory.Focused:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackgroundInstance.ColorCategoryState",
                            Type = "ColorCategoryState",
                            Value = BackgroundInstance.CurrentColorCategoryState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RectangleInstance.Visible",
                            Type = "bool",
                            Value = RectangleInstance.Visible
                        }
                        );
                        break;
                }
                return newState;
            }
            private Gum.DataTypes.Variables.StateSave AddToCurrentValuesWithState (ListBoxItemCategory state) 
            {
                Gum.DataTypes.Variables.StateSave newState = new Gum.DataTypes.Variables.StateSave();
                switch(state)
                {
                    case  ListBoxItemCategory.Enabled:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackgroundInstance.ColorCategoryState",
                            Type = "ColorCategoryState",
                            Value = BackgroundInstance.CurrentColorCategoryState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RectangleInstance.Visible",
                            Type = "bool",
                            Value = RectangleInstance.Visible
                        }
                        );
                        break;
                    case  ListBoxItemCategory.Highlighted:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackgroundInstance.ColorCategoryState",
                            Type = "ColorCategoryState",
                            Value = BackgroundInstance.CurrentColorCategoryState
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
                            Name = "RectangleInstance.Visible",
                            Type = "bool",
                            Value = RectangleInstance.Visible
                        }
                        );
                        break;
                    case  ListBoxItemCategory.Selected:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackgroundInstance.ColorCategoryState",
                            Type = "ColorCategoryState",
                            Value = BackgroundInstance.CurrentColorCategoryState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RectangleInstance.Visible",
                            Type = "bool",
                            Value = RectangleInstance.Visible
                        }
                        );
                        break;
                    case  ListBoxItemCategory.Focused:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackgroundInstance.ColorCategoryState",
                            Type = "ColorCategoryState",
                            Value = BackgroundInstance.CurrentColorCategoryState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RectangleInstance.Visible",
                            Type = "bool",
                            Value = RectangleInstance.Visible
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
                    else if (category.Name == "ListBoxItemCategory")
                    {
                        if(state.Name == "Enabled") this.mCurrentListBoxItemCategoryState = ListBoxItemCategory.Enabled;
                        if(state.Name == "Highlighted") this.mCurrentListBoxItemCategoryState = ListBoxItemCategory.Highlighted;
                        if(state.Name == "Selected") this.mCurrentListBoxItemCategoryState = ListBoxItemCategory.Selected;
                        if(state.Name == "Focused") this.mCurrentListBoxItemCategoryState = ListBoxItemCategory.Focused;
                    }
                }
                base.ApplyState(state);
            }
            private bool tryCreateFormsObject;
            public JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime BackgroundInstance { get; set; }
            public JHP4SD.GumRuntimes.TextRuntime TextInstance { get; set; }
            public JHP4SD.GumRuntimes.RectangleRuntime RectangleInstance { get; set; }
            public ListBoxItem1Runtime (bool fullInstantiation = true, bool tryCreateFormsObject = true) 
            	: base(false, tryCreateFormsObject)
            {
                this.tryCreateFormsObject = tryCreateFormsObject;
                if (fullInstantiation)
                {
                    Gum.DataTypes.ElementSave elementSave = Gum.Managers.ObjectFinder.Self.GumProjectSave.Components.First(item => item.Name == "LebegForms/BasicComponents/ListBoxItem1");
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
                TextInstance = this.GetGraphicalUiElementByName("TextInstance") as JHP4SD.GumRuntimes.TextRuntime;
                RectangleInstance = this.GetGraphicalUiElementByName("RectangleInstance") as JHP4SD.GumRuntimes.RectangleRuntime;
                if (tryCreateFormsObject)
                {
                    FormsControlAsObject = new FlatRedBall.Forms.Controls.ListBoxItem(this);
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
            public FlatRedBall.Forms.Controls.ListBoxItem FormsControl {get => (FlatRedBall.Forms.Controls.ListBoxItem) FormsControlAsObject;}
        }
    }
