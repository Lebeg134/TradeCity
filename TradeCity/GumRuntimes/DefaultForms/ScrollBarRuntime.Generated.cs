    using System.Linq;
    namespace JHP4SD.GumRuntimes.DefaultForms
    {
        public partial class ScrollBarRuntime : JHP4SD.GumRuntimes.ContainerRuntime
        {
            #region State Enums
            public enum VariableState
            {
                Default
            }
            public enum ScrollBarCategory
            {
            }
            #endregion
            #region State Fields
            VariableState mCurrentVariableState;
            ScrollBarCategory? mCurrentScrollBarCategoryState;
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
                            ThumbInstance.Parent = this.GetGraphicalUiElementByName("ThumbContainer") ?? this;
                            SpriteInstance1.Parent = this.GetGraphicalUiElementByName("UpButtonInstance") ?? this;
                            SpriteInstance2.Parent = this.GetGraphicalUiElementByName("DownButtonInstance") ?? this;
                            BackgroundInstance.CurrentColorCategoryState = JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Black;
                            Height = 384f;
                            Width = 36f;
                            X = 0f;
                            Y = 0f;
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
                            UpButtonInstance.Height = 32f;
                            UpButtonInstance.Text = "";
                            UpButtonInstance.Width = 0f;
                            UpButtonInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                            UpButtonInstance.X = 0f;
                            UpButtonInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                            UpButtonInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            UpButtonInstance.Y = 0f;
                            UpButtonInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Top;
                            UpButtonInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                            DownButtonInstance.Height = 32f;
                            DownButtonInstance.Text = "";
                            DownButtonInstance.Width = 0f;
                            DownButtonInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                            DownButtonInstance.X = 0f;
                            DownButtonInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                            DownButtonInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            DownButtonInstance.Y = 0f;
                            DownButtonInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Bottom;
                            DownButtonInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                            ThumbInstance.Height = 40f;
                            ThumbInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            ThumbInstance.Width = 0f;
                            ThumbInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                            ThumbInstance.X = 0f;
                            ThumbInstance.Y = 30f;
                            ThumbInstance.YUnits = Gum.Converters.GeneralUnitType.Percentage;
                            SpriteInstance1.FlipVertical = true;
                            SetProperty("SpriteInstance1.SourceFile", "UISpriteSheet.png");
                            SpriteInstance1.TextureAddress = Gum.Managers.TextureAddress.Custom;
                            SpriteInstance1.TextureHeight = 18;
                            SpriteInstance1.TextureLeft = 105;
                            SpriteInstance1.TextureTop = 15;
                            SpriteInstance1.TextureWidth = 31;
                            SpriteInstance1.X = 0f;
                            SpriteInstance1.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                            SpriteInstance1.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            SpriteInstance1.Y = 0f;
                            SpriteInstance1.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            SpriteInstance1.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            SetProperty("SpriteInstance2.SourceFile", "UISpriteSheet.png");
                            SpriteInstance2.TextureAddress = Gum.Managers.TextureAddress.Custom;
                            SpriteInstance2.TextureHeight = 18;
                            SpriteInstance2.TextureLeft = 105;
                            SpriteInstance2.TextureTop = 15;
                            SpriteInstance2.TextureWidth = 31;
                            SpriteInstance2.X = 0f;
                            SpriteInstance2.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                            SpriteInstance2.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            SpriteInstance2.Y = 0f;
                            SpriteInstance2.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            SpriteInstance2.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            ThumbContainer.Height = -64f;
                            ThumbContainer.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                            ThumbContainer.Width = 0f;
                            ThumbContainer.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                            ThumbContainer.X = 0f;
                            ThumbContainer.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                            ThumbContainer.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            ThumbContainer.Y = 0f;
                            ThumbContainer.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            ThumbContainer.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            break;
                    }
                }
            }
            public ScrollBarCategory? CurrentScrollBarCategoryState
            {
                get
                {
                    return mCurrentScrollBarCategoryState;
                }
                set
                {
                    if (value != null)
                    {
                        mCurrentScrollBarCategoryState = value;
                        switch(mCurrentScrollBarCategoryState)
                        {
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
                bool setBackgroundInstanceCurrentColorCategoryStateFirstValue = false;
                bool setBackgroundInstanceCurrentColorCategoryStateSecondValue = false;
                JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory BackgroundInstanceCurrentColorCategoryStateFirstValue= JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Gray;
                JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory BackgroundInstanceCurrentColorCategoryStateSecondValue= JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Gray;
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
                bool setDownButtonInstanceHeightFirstValue = false;
                bool setDownButtonInstanceHeightSecondValue = false;
                float DownButtonInstanceHeightFirstValue= 0;
                float DownButtonInstanceHeightSecondValue= 0;
                bool setDownButtonInstanceWidthFirstValue = false;
                bool setDownButtonInstanceWidthSecondValue = false;
                float DownButtonInstanceWidthFirstValue= 0;
                float DownButtonInstanceWidthSecondValue= 0;
                bool setDownButtonInstanceXFirstValue = false;
                bool setDownButtonInstanceXSecondValue = false;
                float DownButtonInstanceXFirstValue= 0;
                float DownButtonInstanceXSecondValue= 0;
                bool setDownButtonInstanceYFirstValue = false;
                bool setDownButtonInstanceYSecondValue = false;
                float DownButtonInstanceYFirstValue= 0;
                float DownButtonInstanceYSecondValue= 0;
                bool setHeightFirstValue = false;
                bool setHeightSecondValue = false;
                float HeightFirstValue= 0;
                float HeightSecondValue= 0;
                bool setSpriteInstance1TextureHeightFirstValue = false;
                bool setSpriteInstance1TextureHeightSecondValue = false;
                int SpriteInstance1TextureHeightFirstValue= 0;
                int SpriteInstance1TextureHeightSecondValue= 0;
                bool setSpriteInstance1TextureLeftFirstValue = false;
                bool setSpriteInstance1TextureLeftSecondValue = false;
                int SpriteInstance1TextureLeftFirstValue= 0;
                int SpriteInstance1TextureLeftSecondValue= 0;
                bool setSpriteInstance1TextureTopFirstValue = false;
                bool setSpriteInstance1TextureTopSecondValue = false;
                int SpriteInstance1TextureTopFirstValue= 0;
                int SpriteInstance1TextureTopSecondValue= 0;
                bool setSpriteInstance1TextureWidthFirstValue = false;
                bool setSpriteInstance1TextureWidthSecondValue = false;
                int SpriteInstance1TextureWidthFirstValue= 0;
                int SpriteInstance1TextureWidthSecondValue= 0;
                bool setSpriteInstance1XFirstValue = false;
                bool setSpriteInstance1XSecondValue = false;
                float SpriteInstance1XFirstValue= 0;
                float SpriteInstance1XSecondValue= 0;
                bool setSpriteInstance1YFirstValue = false;
                bool setSpriteInstance1YSecondValue = false;
                float SpriteInstance1YFirstValue= 0;
                float SpriteInstance1YSecondValue= 0;
                bool setSpriteInstance2TextureHeightFirstValue = false;
                bool setSpriteInstance2TextureHeightSecondValue = false;
                int SpriteInstance2TextureHeightFirstValue= 0;
                int SpriteInstance2TextureHeightSecondValue= 0;
                bool setSpriteInstance2TextureLeftFirstValue = false;
                bool setSpriteInstance2TextureLeftSecondValue = false;
                int SpriteInstance2TextureLeftFirstValue= 0;
                int SpriteInstance2TextureLeftSecondValue= 0;
                bool setSpriteInstance2TextureTopFirstValue = false;
                bool setSpriteInstance2TextureTopSecondValue = false;
                int SpriteInstance2TextureTopFirstValue= 0;
                int SpriteInstance2TextureTopSecondValue= 0;
                bool setSpriteInstance2TextureWidthFirstValue = false;
                bool setSpriteInstance2TextureWidthSecondValue = false;
                int SpriteInstance2TextureWidthFirstValue= 0;
                int SpriteInstance2TextureWidthSecondValue= 0;
                bool setSpriteInstance2XFirstValue = false;
                bool setSpriteInstance2XSecondValue = false;
                float SpriteInstance2XFirstValue= 0;
                float SpriteInstance2XSecondValue= 0;
                bool setSpriteInstance2YFirstValue = false;
                bool setSpriteInstance2YSecondValue = false;
                float SpriteInstance2YFirstValue= 0;
                float SpriteInstance2YSecondValue= 0;
                bool setThumbContainerHeightFirstValue = false;
                bool setThumbContainerHeightSecondValue = false;
                float ThumbContainerHeightFirstValue= 0;
                float ThumbContainerHeightSecondValue= 0;
                bool setThumbContainerWidthFirstValue = false;
                bool setThumbContainerWidthSecondValue = false;
                float ThumbContainerWidthFirstValue= 0;
                float ThumbContainerWidthSecondValue= 0;
                bool setThumbContainerXFirstValue = false;
                bool setThumbContainerXSecondValue = false;
                float ThumbContainerXFirstValue= 0;
                float ThumbContainerXSecondValue= 0;
                bool setThumbContainerYFirstValue = false;
                bool setThumbContainerYSecondValue = false;
                float ThumbContainerYFirstValue= 0;
                float ThumbContainerYSecondValue= 0;
                bool setThumbInstanceHeightFirstValue = false;
                bool setThumbInstanceHeightSecondValue = false;
                float ThumbInstanceHeightFirstValue= 0;
                float ThumbInstanceHeightSecondValue= 0;
                bool setThumbInstanceWidthFirstValue = false;
                bool setThumbInstanceWidthSecondValue = false;
                float ThumbInstanceWidthFirstValue= 0;
                float ThumbInstanceWidthSecondValue= 0;
                bool setThumbInstanceXFirstValue = false;
                bool setThumbInstanceXSecondValue = false;
                float ThumbInstanceXFirstValue= 0;
                float ThumbInstanceXSecondValue= 0;
                bool setThumbInstanceYFirstValue = false;
                bool setThumbInstanceYSecondValue = false;
                float ThumbInstanceYFirstValue= 0;
                float ThumbInstanceYSecondValue= 0;
                bool setUpButtonInstanceHeightFirstValue = false;
                bool setUpButtonInstanceHeightSecondValue = false;
                float UpButtonInstanceHeightFirstValue= 0;
                float UpButtonInstanceHeightSecondValue= 0;
                bool setUpButtonInstanceWidthFirstValue = false;
                bool setUpButtonInstanceWidthSecondValue = false;
                float UpButtonInstanceWidthFirstValue= 0;
                float UpButtonInstanceWidthSecondValue= 0;
                bool setUpButtonInstanceXFirstValue = false;
                bool setUpButtonInstanceXSecondValue = false;
                float UpButtonInstanceXFirstValue= 0;
                float UpButtonInstanceXSecondValue= 0;
                bool setUpButtonInstanceYFirstValue = false;
                bool setUpButtonInstanceYSecondValue = false;
                float UpButtonInstanceYFirstValue= 0;
                float UpButtonInstanceYSecondValue= 0;
                bool setWidthFirstValue = false;
                bool setWidthSecondValue = false;
                float WidthFirstValue= 0;
                float WidthSecondValue= 0;
                bool setXFirstValue = false;
                bool setXSecondValue = false;
                float XFirstValue= 0;
                float XSecondValue= 0;
                bool setYFirstValue = false;
                bool setYSecondValue = false;
                float YFirstValue= 0;
                float YSecondValue= 0;
                switch(firstState)
                {
                    case  VariableState.Default:
                        setBackgroundInstanceCurrentColorCategoryStateFirstValue = true;
                        BackgroundInstanceCurrentColorCategoryStateFirstValue = JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Black;
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
                        setDownButtonInstanceHeightFirstValue = true;
                        DownButtonInstanceHeightFirstValue = 32f;
                        if (interpolationValue < 1)
                        {
                            this.DownButtonInstance.Text = "";
                        }
                        setDownButtonInstanceWidthFirstValue = true;
                        DownButtonInstanceWidthFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.DownButtonInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        setDownButtonInstanceXFirstValue = true;
                        DownButtonInstanceXFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.DownButtonInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.DownButtonInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setDownButtonInstanceYFirstValue = true;
                        DownButtonInstanceYFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.DownButtonInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Bottom;
                        }
                        if (interpolationValue < 1)
                        {
                            this.DownButtonInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                        }
                        setHeightFirstValue = true;
                        HeightFirstValue = 384f;
                        if (interpolationValue < 1)
                        {
                            this.SpriteInstance1.FlipVertical = true;
                        }
                        if (interpolationValue < 1)
                        {
                            this.SpriteInstance1.Parent = this.GetGraphicalUiElementByName("UpButtonInstance") ?? this;
                        }
                        if (interpolationValue < 1)
                        {
                            SetProperty("SpriteInstance1.SourceFile", "UISpriteSheet.png");
                        }
                        if (interpolationValue < 1)
                        {
                            this.SpriteInstance1.TextureAddress = Gum.Managers.TextureAddress.Custom;
                        }
                        setSpriteInstance1TextureHeightFirstValue = true;
                        SpriteInstance1TextureHeightFirstValue = 18;
                        setSpriteInstance1TextureLeftFirstValue = true;
                        SpriteInstance1TextureLeftFirstValue = 105;
                        setSpriteInstance1TextureTopFirstValue = true;
                        SpriteInstance1TextureTopFirstValue = 15;
                        setSpriteInstance1TextureWidthFirstValue = true;
                        SpriteInstance1TextureWidthFirstValue = 31;
                        setSpriteInstance1XFirstValue = true;
                        SpriteInstance1XFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.SpriteInstance1.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.SpriteInstance1.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setSpriteInstance1YFirstValue = true;
                        SpriteInstance1YFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.SpriteInstance1.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.SpriteInstance1.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        if (interpolationValue < 1)
                        {
                            this.SpriteInstance2.Parent = this.GetGraphicalUiElementByName("DownButtonInstance") ?? this;
                        }
                        if (interpolationValue < 1)
                        {
                            SetProperty("SpriteInstance2.SourceFile", "UISpriteSheet.png");
                        }
                        if (interpolationValue < 1)
                        {
                            this.SpriteInstance2.TextureAddress = Gum.Managers.TextureAddress.Custom;
                        }
                        setSpriteInstance2TextureHeightFirstValue = true;
                        SpriteInstance2TextureHeightFirstValue = 18;
                        setSpriteInstance2TextureLeftFirstValue = true;
                        SpriteInstance2TextureLeftFirstValue = 105;
                        setSpriteInstance2TextureTopFirstValue = true;
                        SpriteInstance2TextureTopFirstValue = 15;
                        setSpriteInstance2TextureWidthFirstValue = true;
                        SpriteInstance2TextureWidthFirstValue = 31;
                        setSpriteInstance2XFirstValue = true;
                        SpriteInstance2XFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.SpriteInstance2.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.SpriteInstance2.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setSpriteInstance2YFirstValue = true;
                        SpriteInstance2YFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.SpriteInstance2.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.SpriteInstance2.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setThumbContainerHeightFirstValue = true;
                        ThumbContainerHeightFirstValue = -64f;
                        if (interpolationValue < 1)
                        {
                            this.ThumbContainer.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        setThumbContainerWidthFirstValue = true;
                        ThumbContainerWidthFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.ThumbContainer.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        setThumbContainerXFirstValue = true;
                        ThumbContainerXFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.ThumbContainer.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.ThumbContainer.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setThumbContainerYFirstValue = true;
                        ThumbContainerYFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.ThumbContainer.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.ThumbContainer.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setThumbInstanceHeightFirstValue = true;
                        ThumbInstanceHeightFirstValue = 40f;
                        if (interpolationValue < 1)
                        {
                            this.ThumbInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.ThumbInstance.Parent = this.GetGraphicalUiElementByName("ThumbContainer") ?? this;
                        }
                        setThumbInstanceWidthFirstValue = true;
                        ThumbInstanceWidthFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.ThumbInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        setThumbInstanceXFirstValue = true;
                        ThumbInstanceXFirstValue = 0f;
                        setThumbInstanceYFirstValue = true;
                        ThumbInstanceYFirstValue = 30f;
                        if (interpolationValue < 1)
                        {
                            this.ThumbInstance.YUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setUpButtonInstanceHeightFirstValue = true;
                        UpButtonInstanceHeightFirstValue = 32f;
                        if (interpolationValue < 1)
                        {
                            this.UpButtonInstance.Text = "";
                        }
                        setUpButtonInstanceWidthFirstValue = true;
                        UpButtonInstanceWidthFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.UpButtonInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        setUpButtonInstanceXFirstValue = true;
                        UpButtonInstanceXFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.UpButtonInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.UpButtonInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setUpButtonInstanceYFirstValue = true;
                        UpButtonInstanceYFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.UpButtonInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Top;
                        }
                        if (interpolationValue < 1)
                        {
                            this.UpButtonInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                        }
                        setWidthFirstValue = true;
                        WidthFirstValue = 36f;
                        setXFirstValue = true;
                        XFirstValue = 0f;
                        setYFirstValue = true;
                        YFirstValue = 0f;
                        break;
                }
                switch(secondState)
                {
                    case  VariableState.Default:
                        setBackgroundInstanceCurrentColorCategoryStateSecondValue = true;
                        BackgroundInstanceCurrentColorCategoryStateSecondValue = JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Black;
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
                        setDownButtonInstanceHeightSecondValue = true;
                        DownButtonInstanceHeightSecondValue = 32f;
                        if (interpolationValue >= 1)
                        {
                            this.DownButtonInstance.Text = "";
                        }
                        setDownButtonInstanceWidthSecondValue = true;
                        DownButtonInstanceWidthSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.DownButtonInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        setDownButtonInstanceXSecondValue = true;
                        DownButtonInstanceXSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.DownButtonInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.DownButtonInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setDownButtonInstanceYSecondValue = true;
                        DownButtonInstanceYSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.DownButtonInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Bottom;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.DownButtonInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                        }
                        setHeightSecondValue = true;
                        HeightSecondValue = 384f;
                        if (interpolationValue >= 1)
                        {
                            this.SpriteInstance1.FlipVertical = true;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.SpriteInstance1.Parent = this.GetGraphicalUiElementByName("UpButtonInstance") ?? this;
                        }
                        if (interpolationValue >= 1)
                        {
                            SetProperty("SpriteInstance1.SourceFile", "UISpriteSheet.png");
                        }
                        if (interpolationValue >= 1)
                        {
                            this.SpriteInstance1.TextureAddress = Gum.Managers.TextureAddress.Custom;
                        }
                        setSpriteInstance1TextureHeightSecondValue = true;
                        SpriteInstance1TextureHeightSecondValue = 18;
                        setSpriteInstance1TextureLeftSecondValue = true;
                        SpriteInstance1TextureLeftSecondValue = 105;
                        setSpriteInstance1TextureTopSecondValue = true;
                        SpriteInstance1TextureTopSecondValue = 15;
                        setSpriteInstance1TextureWidthSecondValue = true;
                        SpriteInstance1TextureWidthSecondValue = 31;
                        setSpriteInstance1XSecondValue = true;
                        SpriteInstance1XSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.SpriteInstance1.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.SpriteInstance1.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setSpriteInstance1YSecondValue = true;
                        SpriteInstance1YSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.SpriteInstance1.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.SpriteInstance1.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.SpriteInstance2.Parent = this.GetGraphicalUiElementByName("DownButtonInstance") ?? this;
                        }
                        if (interpolationValue >= 1)
                        {
                            SetProperty("SpriteInstance2.SourceFile", "UISpriteSheet.png");
                        }
                        if (interpolationValue >= 1)
                        {
                            this.SpriteInstance2.TextureAddress = Gum.Managers.TextureAddress.Custom;
                        }
                        setSpriteInstance2TextureHeightSecondValue = true;
                        SpriteInstance2TextureHeightSecondValue = 18;
                        setSpriteInstance2TextureLeftSecondValue = true;
                        SpriteInstance2TextureLeftSecondValue = 105;
                        setSpriteInstance2TextureTopSecondValue = true;
                        SpriteInstance2TextureTopSecondValue = 15;
                        setSpriteInstance2TextureWidthSecondValue = true;
                        SpriteInstance2TextureWidthSecondValue = 31;
                        setSpriteInstance2XSecondValue = true;
                        SpriteInstance2XSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.SpriteInstance2.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.SpriteInstance2.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setSpriteInstance2YSecondValue = true;
                        SpriteInstance2YSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.SpriteInstance2.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.SpriteInstance2.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setThumbContainerHeightSecondValue = true;
                        ThumbContainerHeightSecondValue = -64f;
                        if (interpolationValue >= 1)
                        {
                            this.ThumbContainer.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        setThumbContainerWidthSecondValue = true;
                        ThumbContainerWidthSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.ThumbContainer.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        setThumbContainerXSecondValue = true;
                        ThumbContainerXSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.ThumbContainer.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.ThumbContainer.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setThumbContainerYSecondValue = true;
                        ThumbContainerYSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.ThumbContainer.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.ThumbContainer.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setThumbInstanceHeightSecondValue = true;
                        ThumbInstanceHeightSecondValue = 40f;
                        if (interpolationValue >= 1)
                        {
                            this.ThumbInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.ThumbInstance.Parent = this.GetGraphicalUiElementByName("ThumbContainer") ?? this;
                        }
                        setThumbInstanceWidthSecondValue = true;
                        ThumbInstanceWidthSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.ThumbInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        setThumbInstanceXSecondValue = true;
                        ThumbInstanceXSecondValue = 0f;
                        setThumbInstanceYSecondValue = true;
                        ThumbInstanceYSecondValue = 30f;
                        if (interpolationValue >= 1)
                        {
                            this.ThumbInstance.YUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setUpButtonInstanceHeightSecondValue = true;
                        UpButtonInstanceHeightSecondValue = 32f;
                        if (interpolationValue >= 1)
                        {
                            this.UpButtonInstance.Text = "";
                        }
                        setUpButtonInstanceWidthSecondValue = true;
                        UpButtonInstanceWidthSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.UpButtonInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        setUpButtonInstanceXSecondValue = true;
                        UpButtonInstanceXSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.UpButtonInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.UpButtonInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setUpButtonInstanceYSecondValue = true;
                        UpButtonInstanceYSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.UpButtonInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Top;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.UpButtonInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                        }
                        setWidthSecondValue = true;
                        WidthSecondValue = 36f;
                        setXSecondValue = true;
                        XSecondValue = 0f;
                        setYSecondValue = true;
                        YSecondValue = 0f;
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
                if (setDownButtonInstanceHeightFirstValue && setDownButtonInstanceHeightSecondValue)
                {
                    DownButtonInstance.Height = DownButtonInstanceHeightFirstValue * (1 - interpolationValue) + DownButtonInstanceHeightSecondValue * interpolationValue;
                }
                if (setDownButtonInstanceWidthFirstValue && setDownButtonInstanceWidthSecondValue)
                {
                    DownButtonInstance.Width = DownButtonInstanceWidthFirstValue * (1 - interpolationValue) + DownButtonInstanceWidthSecondValue * interpolationValue;
                }
                if (setDownButtonInstanceXFirstValue && setDownButtonInstanceXSecondValue)
                {
                    DownButtonInstance.X = DownButtonInstanceXFirstValue * (1 - interpolationValue) + DownButtonInstanceXSecondValue * interpolationValue;
                }
                if (setDownButtonInstanceYFirstValue && setDownButtonInstanceYSecondValue)
                {
                    DownButtonInstance.Y = DownButtonInstanceYFirstValue * (1 - interpolationValue) + DownButtonInstanceYSecondValue * interpolationValue;
                }
                if (setHeightFirstValue && setHeightSecondValue)
                {
                    Height = HeightFirstValue * (1 - interpolationValue) + HeightSecondValue * interpolationValue;
                }
                if (setSpriteInstance1TextureHeightFirstValue && setSpriteInstance1TextureHeightSecondValue)
                {
                    SpriteInstance1.TextureHeight = FlatRedBall.Math.MathFunctions.RoundToInt(SpriteInstance1TextureHeightFirstValue* (1 - interpolationValue) + SpriteInstance1TextureHeightSecondValue * interpolationValue);
                }
                if (setSpriteInstance1TextureLeftFirstValue && setSpriteInstance1TextureLeftSecondValue)
                {
                    SpriteInstance1.TextureLeft = FlatRedBall.Math.MathFunctions.RoundToInt(SpriteInstance1TextureLeftFirstValue* (1 - interpolationValue) + SpriteInstance1TextureLeftSecondValue * interpolationValue);
                }
                if (setSpriteInstance1TextureTopFirstValue && setSpriteInstance1TextureTopSecondValue)
                {
                    SpriteInstance1.TextureTop = FlatRedBall.Math.MathFunctions.RoundToInt(SpriteInstance1TextureTopFirstValue* (1 - interpolationValue) + SpriteInstance1TextureTopSecondValue * interpolationValue);
                }
                if (setSpriteInstance1TextureWidthFirstValue && setSpriteInstance1TextureWidthSecondValue)
                {
                    SpriteInstance1.TextureWidth = FlatRedBall.Math.MathFunctions.RoundToInt(SpriteInstance1TextureWidthFirstValue* (1 - interpolationValue) + SpriteInstance1TextureWidthSecondValue * interpolationValue);
                }
                if (setSpriteInstance1XFirstValue && setSpriteInstance1XSecondValue)
                {
                    SpriteInstance1.X = SpriteInstance1XFirstValue * (1 - interpolationValue) + SpriteInstance1XSecondValue * interpolationValue;
                }
                if (setSpriteInstance1YFirstValue && setSpriteInstance1YSecondValue)
                {
                    SpriteInstance1.Y = SpriteInstance1YFirstValue * (1 - interpolationValue) + SpriteInstance1YSecondValue * interpolationValue;
                }
                if (setSpriteInstance2TextureHeightFirstValue && setSpriteInstance2TextureHeightSecondValue)
                {
                    SpriteInstance2.TextureHeight = FlatRedBall.Math.MathFunctions.RoundToInt(SpriteInstance2TextureHeightFirstValue* (1 - interpolationValue) + SpriteInstance2TextureHeightSecondValue * interpolationValue);
                }
                if (setSpriteInstance2TextureLeftFirstValue && setSpriteInstance2TextureLeftSecondValue)
                {
                    SpriteInstance2.TextureLeft = FlatRedBall.Math.MathFunctions.RoundToInt(SpriteInstance2TextureLeftFirstValue* (1 - interpolationValue) + SpriteInstance2TextureLeftSecondValue * interpolationValue);
                }
                if (setSpriteInstance2TextureTopFirstValue && setSpriteInstance2TextureTopSecondValue)
                {
                    SpriteInstance2.TextureTop = FlatRedBall.Math.MathFunctions.RoundToInt(SpriteInstance2TextureTopFirstValue* (1 - interpolationValue) + SpriteInstance2TextureTopSecondValue * interpolationValue);
                }
                if (setSpriteInstance2TextureWidthFirstValue && setSpriteInstance2TextureWidthSecondValue)
                {
                    SpriteInstance2.TextureWidth = FlatRedBall.Math.MathFunctions.RoundToInt(SpriteInstance2TextureWidthFirstValue* (1 - interpolationValue) + SpriteInstance2TextureWidthSecondValue * interpolationValue);
                }
                if (setSpriteInstance2XFirstValue && setSpriteInstance2XSecondValue)
                {
                    SpriteInstance2.X = SpriteInstance2XFirstValue * (1 - interpolationValue) + SpriteInstance2XSecondValue * interpolationValue;
                }
                if (setSpriteInstance2YFirstValue && setSpriteInstance2YSecondValue)
                {
                    SpriteInstance2.Y = SpriteInstance2YFirstValue * (1 - interpolationValue) + SpriteInstance2YSecondValue * interpolationValue;
                }
                if (setThumbContainerHeightFirstValue && setThumbContainerHeightSecondValue)
                {
                    ThumbContainer.Height = ThumbContainerHeightFirstValue * (1 - interpolationValue) + ThumbContainerHeightSecondValue * interpolationValue;
                }
                if (setThumbContainerWidthFirstValue && setThumbContainerWidthSecondValue)
                {
                    ThumbContainer.Width = ThumbContainerWidthFirstValue * (1 - interpolationValue) + ThumbContainerWidthSecondValue * interpolationValue;
                }
                if (setThumbContainerXFirstValue && setThumbContainerXSecondValue)
                {
                    ThumbContainer.X = ThumbContainerXFirstValue * (1 - interpolationValue) + ThumbContainerXSecondValue * interpolationValue;
                }
                if (setThumbContainerYFirstValue && setThumbContainerYSecondValue)
                {
                    ThumbContainer.Y = ThumbContainerYFirstValue * (1 - interpolationValue) + ThumbContainerYSecondValue * interpolationValue;
                }
                if (setThumbInstanceHeightFirstValue && setThumbInstanceHeightSecondValue)
                {
                    ThumbInstance.Height = ThumbInstanceHeightFirstValue * (1 - interpolationValue) + ThumbInstanceHeightSecondValue * interpolationValue;
                }
                if (setThumbInstanceWidthFirstValue && setThumbInstanceWidthSecondValue)
                {
                    ThumbInstance.Width = ThumbInstanceWidthFirstValue * (1 - interpolationValue) + ThumbInstanceWidthSecondValue * interpolationValue;
                }
                if (setThumbInstanceXFirstValue && setThumbInstanceXSecondValue)
                {
                    ThumbInstance.X = ThumbInstanceXFirstValue * (1 - interpolationValue) + ThumbInstanceXSecondValue * interpolationValue;
                }
                if (setThumbInstanceYFirstValue && setThumbInstanceYSecondValue)
                {
                    ThumbInstance.Y = ThumbInstanceYFirstValue * (1 - interpolationValue) + ThumbInstanceYSecondValue * interpolationValue;
                }
                if (setUpButtonInstanceHeightFirstValue && setUpButtonInstanceHeightSecondValue)
                {
                    UpButtonInstance.Height = UpButtonInstanceHeightFirstValue * (1 - interpolationValue) + UpButtonInstanceHeightSecondValue * interpolationValue;
                }
                if (setUpButtonInstanceWidthFirstValue && setUpButtonInstanceWidthSecondValue)
                {
                    UpButtonInstance.Width = UpButtonInstanceWidthFirstValue * (1 - interpolationValue) + UpButtonInstanceWidthSecondValue * interpolationValue;
                }
                if (setUpButtonInstanceXFirstValue && setUpButtonInstanceXSecondValue)
                {
                    UpButtonInstance.X = UpButtonInstanceXFirstValue * (1 - interpolationValue) + UpButtonInstanceXSecondValue * interpolationValue;
                }
                if (setUpButtonInstanceYFirstValue && setUpButtonInstanceYSecondValue)
                {
                    UpButtonInstance.Y = UpButtonInstanceYFirstValue * (1 - interpolationValue) + UpButtonInstanceYSecondValue * interpolationValue;
                }
                if (setWidthFirstValue && setWidthSecondValue)
                {
                    Width = WidthFirstValue * (1 - interpolationValue) + WidthSecondValue * interpolationValue;
                }
                if (setXFirstValue && setXSecondValue)
                {
                    X = XFirstValue * (1 - interpolationValue) + XSecondValue * interpolationValue;
                }
                if (setYFirstValue && setYSecondValue)
                {
                    Y = YFirstValue * (1 - interpolationValue) + YSecondValue * interpolationValue;
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
            public void InterpolateBetween (ScrollBarCategory firstState, ScrollBarCategory secondState, float interpolationValue) 
            {
                #if DEBUG
                if (float.IsNaN(interpolationValue))
                {
                    throw new System.Exception("interpolationValue cannot be NaN");
                }
                #endif
                switch(firstState)
                {
                }
                switch(secondState)
                {
                }
                var wasSuppressed = mIsLayoutSuspended;
                if (wasSuppressed == false)
                {
                    SuspendLayout(true);
                }
                if (interpolationValue < 1)
                {
                    mCurrentScrollBarCategoryState = firstState;
                }
                else
                {
                    mCurrentScrollBarCategoryState = secondState;
                }
                if (!wasSuppressed)
                {
                    ResumeLayout(true);
                }
            }
            #endregion
            #region State Interpolate To
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (JHP4SD.GumRuntimes.DefaultForms.ScrollBarRuntime.VariableState fromState,JHP4SD.GumRuntimes.DefaultForms.ScrollBarRuntime.VariableState toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null) 
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
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (JHP4SD.GumRuntimes.DefaultForms.ScrollBarRuntime.ScrollBarCategory fromState,JHP4SD.GumRuntimes.DefaultForms.ScrollBarRuntime.ScrollBarCategory toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null) 
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
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (ScrollBarCategory toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null ) 
            {
                Gum.DataTypes.Variables.StateSave current = GetCurrentValuesOnState(toState);
                Gum.DataTypes.Variables.StateSave toAsStateSave = this.ElementSave.Categories.First(item => item.Name == "ScrollBarCategory").States.First(item => item.Name == toState.ToString());
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
                tweener.Ended += ()=> this.CurrentScrollBarCategoryState = toState;
                tweener.Start();
                StateInterpolationPlugin.TweenerManager.Self.Add(tweener);
                return tweener;
            }
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateToRelative (ScrollBarCategory toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null ) 
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
                tweener.Ended += ()=> this.CurrentScrollBarCategoryState = toState;
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
                UpButtonInstance.StopAnimations();
                DownButtonInstance.StopAnimations();
                ThumbInstance.StopAnimations();
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
                            Name = "X",
                            Type = "float",
                            Value = X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Y",
                            Type = "float",
                            Value = Y
                        }
                        );
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
                            Name = "UpButtonInstance.Height",
                            Type = "float",
                            Value = UpButtonInstance.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "UpButtonInstance.Text",
                            Type = "string",
                            Value = UpButtonInstance.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "UpButtonInstance.Width",
                            Type = "float",
                            Value = UpButtonInstance.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "UpButtonInstance.Width Units",
                            Type = "DimensionUnitType",
                            Value = UpButtonInstance.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "UpButtonInstance.X",
                            Type = "float",
                            Value = UpButtonInstance.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "UpButtonInstance.X Origin",
                            Type = "HorizontalAlignment",
                            Value = UpButtonInstance.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "UpButtonInstance.X Units",
                            Type = "PositionUnitType",
                            Value = UpButtonInstance.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "UpButtonInstance.Y",
                            Type = "float",
                            Value = UpButtonInstance.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "UpButtonInstance.Y Origin",
                            Type = "VerticalAlignment",
                            Value = UpButtonInstance.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "UpButtonInstance.Y Units",
                            Type = "PositionUnitType",
                            Value = UpButtonInstance.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "DownButtonInstance.Height",
                            Type = "float",
                            Value = DownButtonInstance.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "DownButtonInstance.Text",
                            Type = "string",
                            Value = DownButtonInstance.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "DownButtonInstance.Width",
                            Type = "float",
                            Value = DownButtonInstance.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "DownButtonInstance.Width Units",
                            Type = "DimensionUnitType",
                            Value = DownButtonInstance.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "DownButtonInstance.X",
                            Type = "float",
                            Value = DownButtonInstance.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "DownButtonInstance.X Origin",
                            Type = "HorizontalAlignment",
                            Value = DownButtonInstance.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "DownButtonInstance.X Units",
                            Type = "PositionUnitType",
                            Value = DownButtonInstance.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "DownButtonInstance.Y",
                            Type = "float",
                            Value = DownButtonInstance.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "DownButtonInstance.Y Origin",
                            Type = "VerticalAlignment",
                            Value = DownButtonInstance.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "DownButtonInstance.Y Units",
                            Type = "PositionUnitType",
                            Value = DownButtonInstance.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ThumbInstance.Height",
                            Type = "float",
                            Value = ThumbInstance.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ThumbInstance.Height Units",
                            Type = "DimensionUnitType",
                            Value = ThumbInstance.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ThumbInstance.Parent",
                            Type = "string",
                            Value = ThumbInstance.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ThumbInstance.Width",
                            Type = "float",
                            Value = ThumbInstance.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ThumbInstance.Width Units",
                            Type = "DimensionUnitType",
                            Value = ThumbInstance.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ThumbInstance.X",
                            Type = "float",
                            Value = ThumbInstance.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ThumbInstance.Y",
                            Type = "float",
                            Value = ThumbInstance.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ThumbInstance.Y Units",
                            Type = "PositionUnitType",
                            Value = ThumbInstance.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance1.FlipVertical",
                            Type = "bool",
                            Value = SpriteInstance1.FlipVertical
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance1.Parent",
                            Type = "string",
                            Value = SpriteInstance1.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance1.SourceFile",
                            Type = "string",
                            Value = SpriteInstance1.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance1.Texture Address",
                            Type = "TextureAddress",
                            Value = SpriteInstance1.TextureAddress
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance1.Texture Height",
                            Type = "int",
                            Value = SpriteInstance1.TextureHeight
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance1.Texture Left",
                            Type = "int",
                            Value = SpriteInstance1.TextureLeft
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance1.Texture Top",
                            Type = "int",
                            Value = SpriteInstance1.TextureTop
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance1.Texture Width",
                            Type = "int",
                            Value = SpriteInstance1.TextureWidth
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance1.X",
                            Type = "float",
                            Value = SpriteInstance1.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance1.X Origin",
                            Type = "HorizontalAlignment",
                            Value = SpriteInstance1.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance1.X Units",
                            Type = "PositionUnitType",
                            Value = SpriteInstance1.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance1.Y",
                            Type = "float",
                            Value = SpriteInstance1.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance1.Y Origin",
                            Type = "VerticalAlignment",
                            Value = SpriteInstance1.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance1.Y Units",
                            Type = "PositionUnitType",
                            Value = SpriteInstance1.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance2.Parent",
                            Type = "string",
                            Value = SpriteInstance2.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance2.SourceFile",
                            Type = "string",
                            Value = SpriteInstance2.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance2.Texture Address",
                            Type = "TextureAddress",
                            Value = SpriteInstance2.TextureAddress
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance2.Texture Height",
                            Type = "int",
                            Value = SpriteInstance2.TextureHeight
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance2.Texture Left",
                            Type = "int",
                            Value = SpriteInstance2.TextureLeft
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance2.Texture Top",
                            Type = "int",
                            Value = SpriteInstance2.TextureTop
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance2.Texture Width",
                            Type = "int",
                            Value = SpriteInstance2.TextureWidth
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance2.X",
                            Type = "float",
                            Value = SpriteInstance2.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance2.X Origin",
                            Type = "HorizontalAlignment",
                            Value = SpriteInstance2.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance2.X Units",
                            Type = "PositionUnitType",
                            Value = SpriteInstance2.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance2.Y",
                            Type = "float",
                            Value = SpriteInstance2.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance2.Y Origin",
                            Type = "VerticalAlignment",
                            Value = SpriteInstance2.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance2.Y Units",
                            Type = "PositionUnitType",
                            Value = SpriteInstance2.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ThumbContainer.Height",
                            Type = "float",
                            Value = ThumbContainer.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ThumbContainer.Height Units",
                            Type = "DimensionUnitType",
                            Value = ThumbContainer.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ThumbContainer.Width",
                            Type = "float",
                            Value = ThumbContainer.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ThumbContainer.Width Units",
                            Type = "DimensionUnitType",
                            Value = ThumbContainer.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ThumbContainer.X",
                            Type = "float",
                            Value = ThumbContainer.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ThumbContainer.X Origin",
                            Type = "HorizontalAlignment",
                            Value = ThumbContainer.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ThumbContainer.X Units",
                            Type = "PositionUnitType",
                            Value = ThumbContainer.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ThumbContainer.Y",
                            Type = "float",
                            Value = ThumbContainer.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ThumbContainer.Y Origin",
                            Type = "VerticalAlignment",
                            Value = ThumbContainer.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ThumbContainer.Y Units",
                            Type = "PositionUnitType",
                            Value = ThumbContainer.YUnits
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
                            Value = Height + 384f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Width",
                            Type = "float",
                            Value = Width + 36f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "X",
                            Type = "float",
                            Value = X + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Y",
                            Type = "float",
                            Value = Y + 0f
                        }
                        );
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
                            Name = "UpButtonInstance.Height",
                            Type = "float",
                            Value = UpButtonInstance.Height + 32f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "UpButtonInstance.Text",
                            Type = "string",
                            Value = UpButtonInstance.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "UpButtonInstance.Width",
                            Type = "float",
                            Value = UpButtonInstance.Width + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "UpButtonInstance.Width Units",
                            Type = "DimensionUnitType",
                            Value = UpButtonInstance.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "UpButtonInstance.X",
                            Type = "float",
                            Value = UpButtonInstance.X + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "UpButtonInstance.X Origin",
                            Type = "HorizontalAlignment",
                            Value = UpButtonInstance.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "UpButtonInstance.X Units",
                            Type = "PositionUnitType",
                            Value = UpButtonInstance.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "UpButtonInstance.Y",
                            Type = "float",
                            Value = UpButtonInstance.Y + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "UpButtonInstance.Y Origin",
                            Type = "VerticalAlignment",
                            Value = UpButtonInstance.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "UpButtonInstance.Y Units",
                            Type = "PositionUnitType",
                            Value = UpButtonInstance.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "DownButtonInstance.Height",
                            Type = "float",
                            Value = DownButtonInstance.Height + 32f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "DownButtonInstance.Text",
                            Type = "string",
                            Value = DownButtonInstance.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "DownButtonInstance.Width",
                            Type = "float",
                            Value = DownButtonInstance.Width + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "DownButtonInstance.Width Units",
                            Type = "DimensionUnitType",
                            Value = DownButtonInstance.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "DownButtonInstance.X",
                            Type = "float",
                            Value = DownButtonInstance.X + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "DownButtonInstance.X Origin",
                            Type = "HorizontalAlignment",
                            Value = DownButtonInstance.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "DownButtonInstance.X Units",
                            Type = "PositionUnitType",
                            Value = DownButtonInstance.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "DownButtonInstance.Y",
                            Type = "float",
                            Value = DownButtonInstance.Y + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "DownButtonInstance.Y Origin",
                            Type = "VerticalAlignment",
                            Value = DownButtonInstance.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "DownButtonInstance.Y Units",
                            Type = "PositionUnitType",
                            Value = DownButtonInstance.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ThumbInstance.Height",
                            Type = "float",
                            Value = ThumbInstance.Height + 40f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ThumbInstance.Height Units",
                            Type = "DimensionUnitType",
                            Value = ThumbInstance.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ThumbInstance.Parent",
                            Type = "string",
                            Value = ThumbInstance.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ThumbInstance.Width",
                            Type = "float",
                            Value = ThumbInstance.Width + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ThumbInstance.Width Units",
                            Type = "DimensionUnitType",
                            Value = ThumbInstance.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ThumbInstance.X",
                            Type = "float",
                            Value = ThumbInstance.X + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ThumbInstance.Y",
                            Type = "float",
                            Value = ThumbInstance.Y + 30f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ThumbInstance.Y Units",
                            Type = "PositionUnitType",
                            Value = ThumbInstance.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance1.FlipVertical",
                            Type = "bool",
                            Value = SpriteInstance1.FlipVertical
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance1.Parent",
                            Type = "string",
                            Value = SpriteInstance1.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance1.SourceFile",
                            Type = "string",
                            Value = SpriteInstance1.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance1.Texture Address",
                            Type = "TextureAddress",
                            Value = SpriteInstance1.TextureAddress
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance1.Texture Height",
                            Type = "int",
                            Value = SpriteInstance1.TextureHeight + 18
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance1.Texture Left",
                            Type = "int",
                            Value = SpriteInstance1.TextureLeft + 105
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance1.Texture Top",
                            Type = "int",
                            Value = SpriteInstance1.TextureTop + 15
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance1.Texture Width",
                            Type = "int",
                            Value = SpriteInstance1.TextureWidth + 31
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance1.X",
                            Type = "float",
                            Value = SpriteInstance1.X + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance1.X Origin",
                            Type = "HorizontalAlignment",
                            Value = SpriteInstance1.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance1.X Units",
                            Type = "PositionUnitType",
                            Value = SpriteInstance1.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance1.Y",
                            Type = "float",
                            Value = SpriteInstance1.Y + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance1.Y Origin",
                            Type = "VerticalAlignment",
                            Value = SpriteInstance1.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance1.Y Units",
                            Type = "PositionUnitType",
                            Value = SpriteInstance1.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance2.Parent",
                            Type = "string",
                            Value = SpriteInstance2.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance2.SourceFile",
                            Type = "string",
                            Value = SpriteInstance2.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance2.Texture Address",
                            Type = "TextureAddress",
                            Value = SpriteInstance2.TextureAddress
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance2.Texture Height",
                            Type = "int",
                            Value = SpriteInstance2.TextureHeight + 18
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance2.Texture Left",
                            Type = "int",
                            Value = SpriteInstance2.TextureLeft + 105
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance2.Texture Top",
                            Type = "int",
                            Value = SpriteInstance2.TextureTop + 15
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance2.Texture Width",
                            Type = "int",
                            Value = SpriteInstance2.TextureWidth + 31
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance2.X",
                            Type = "float",
                            Value = SpriteInstance2.X + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance2.X Origin",
                            Type = "HorizontalAlignment",
                            Value = SpriteInstance2.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance2.X Units",
                            Type = "PositionUnitType",
                            Value = SpriteInstance2.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance2.Y",
                            Type = "float",
                            Value = SpriteInstance2.Y + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance2.Y Origin",
                            Type = "VerticalAlignment",
                            Value = SpriteInstance2.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance2.Y Units",
                            Type = "PositionUnitType",
                            Value = SpriteInstance2.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ThumbContainer.Height",
                            Type = "float",
                            Value = ThumbContainer.Height + -64f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ThumbContainer.Height Units",
                            Type = "DimensionUnitType",
                            Value = ThumbContainer.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ThumbContainer.Width",
                            Type = "float",
                            Value = ThumbContainer.Width + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ThumbContainer.Width Units",
                            Type = "DimensionUnitType",
                            Value = ThumbContainer.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ThumbContainer.X",
                            Type = "float",
                            Value = ThumbContainer.X + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ThumbContainer.X Origin",
                            Type = "HorizontalAlignment",
                            Value = ThumbContainer.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ThumbContainer.X Units",
                            Type = "PositionUnitType",
                            Value = ThumbContainer.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ThumbContainer.Y",
                            Type = "float",
                            Value = ThumbContainer.Y + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ThumbContainer.Y Origin",
                            Type = "VerticalAlignment",
                            Value = ThumbContainer.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ThumbContainer.Y Units",
                            Type = "PositionUnitType",
                            Value = ThumbContainer.YUnits
                        }
                        );
                        break;
                }
                return newState;
            }
            private Gum.DataTypes.Variables.StateSave GetCurrentValuesOnState (ScrollBarCategory state) 
            {
                Gum.DataTypes.Variables.StateSave newState = new Gum.DataTypes.Variables.StateSave();
                switch(state)
                {
                }
                return newState;
            }
            private Gum.DataTypes.Variables.StateSave AddToCurrentValuesWithState (ScrollBarCategory state) 
            {
                Gum.DataTypes.Variables.StateSave newState = new Gum.DataTypes.Variables.StateSave();
                switch(state)
                {
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
                    else if (category.Name == "ScrollBarCategory")
                    {
                    }
                }
                base.ApplyState(state);
            }
            private bool tryCreateFormsObject;
            public JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime BackgroundInstance { get; set; }
            public JHP4SD.GumRuntimes.DefaultForms.ButtonRuntime UpButtonInstance { get; set; }
            public JHP4SD.GumRuntimes.DefaultForms.ButtonRuntime DownButtonInstance { get; set; }
            public JHP4SD.GumRuntimes.DefaultForms.ScrollBarThumbRuntime ThumbInstance { get; set; }
            public JHP4SD.GumRuntimes.SpriteRuntime SpriteInstance1 { get; set; }
            public JHP4SD.GumRuntimes.SpriteRuntime SpriteInstance2 { get; set; }
            public JHP4SD.GumRuntimes.ContainerRuntime ThumbContainer { get; set; }
            public event FlatRedBall.Gui.WindowEvent UpButtonInstanceClick;
            public event FlatRedBall.Gui.WindowEvent DownButtonInstanceClick;
            public event FlatRedBall.Gui.WindowEvent ThumbInstanceClick;
            public ScrollBarRuntime (bool fullInstantiation = true, bool tryCreateFormsObject = true) 
            	: base(false, tryCreateFormsObject)
            {
                this.tryCreateFormsObject = tryCreateFormsObject;
                if (fullInstantiation)
                {
                    Gum.DataTypes.ElementSave elementSave = Gum.Managers.ObjectFinder.Self.GumProjectSave.Components.First(item => item.Name == "DefaultForms/ScrollBar");
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
                UpButtonInstance = this.GetGraphicalUiElementByName("UpButtonInstance") as JHP4SD.GumRuntimes.DefaultForms.ButtonRuntime;
                DownButtonInstance = this.GetGraphicalUiElementByName("DownButtonInstance") as JHP4SD.GumRuntimes.DefaultForms.ButtonRuntime;
                ThumbInstance = this.GetGraphicalUiElementByName("ThumbInstance") as JHP4SD.GumRuntimes.DefaultForms.ScrollBarThumbRuntime;
                SpriteInstance1 = this.GetGraphicalUiElementByName("SpriteInstance1") as JHP4SD.GumRuntimes.SpriteRuntime;
                SpriteInstance2 = this.GetGraphicalUiElementByName("SpriteInstance2") as JHP4SD.GumRuntimes.SpriteRuntime;
                ThumbContainer = this.GetGraphicalUiElementByName("ThumbContainer") as JHP4SD.GumRuntimes.ContainerRuntime;
                UpButtonInstance.Click += (unused) => UpButtonInstanceClick?.Invoke(this);
                DownButtonInstance.Click += (unused) => DownButtonInstanceClick?.Invoke(this);
                ThumbInstance.Click += (unused) => ThumbInstanceClick?.Invoke(this);
                if (tryCreateFormsObject)
                {
                    FormsControlAsObject = new FlatRedBall.Forms.Controls.ScrollBar(this);
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
            public FlatRedBall.Forms.Controls.ScrollBar FormsControl {get => (FlatRedBall.Forms.Controls.ScrollBar) FormsControlAsObject;}
        }
    }
