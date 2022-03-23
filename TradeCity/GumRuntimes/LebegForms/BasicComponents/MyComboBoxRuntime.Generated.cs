    using System.Linq;
    namespace JHP4SD.GumRuntimes.LebegForms.BasicComponents
    {
        public partial class MyComboBoxRuntime : JHP4SD.GumRuntimes.ContainerRuntime
        {
            #region State Enums
            public enum VariableState
            {
                Default
            }
            public enum ComboBoxCategory
            {
                Enabled,
                Disabled,
                Highlighted,
                Pushed
            }
            #endregion
            #region State Fields
            VariableState mCurrentVariableState;
            ComboBoxCategory? mCurrentComboBoxCategoryState;
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
                            SpriteInstance.Parent = this.GetGraphicalUiElementByName("NineSliceInstance") ?? this;
                            PaceholderText.Parent = this.GetGraphicalUiElementByName("NineSliceInstance") ?? this;
                            NineSliceInstance.CurrentColorCategoryState = JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Gray;
                            TextInstance.CurrentColorCategoryState = JHP4SD.GumRuntimes.TextRuntime.ColorCategory.Gray;
                            Height = 48f;
                            Width = 250f;
                            ListBoxInstance.Height = 180f;
                            ListBoxInstance.Width = 0f;
                            ListBoxInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                            ListBoxInstance.X = 0f;
                            ListBoxInstance.Y = 0f;
                            ListBoxInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                            NineSliceInstance.Blue = 128;
                            NineSliceInstance.Green = 128;
                            NineSliceInstance.Height = 0f;
                            NineSliceInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                            NineSliceInstance.Red = 128;
                            NineSliceInstance.Width = 0f;
                            NineSliceInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                            NineSliceInstance.X = 0f;
                            NineSliceInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                            NineSliceInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            NineSliceInstance.Y = 0f;
                            NineSliceInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            NineSliceInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            TextInstance.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                            TextInstance.VerticalAlignment = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            TextInstance.Width = 0f;
                            TextInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                            TextInstance.X = 16f;
                            TextInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                            TextInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                            TextInstance.Y = 0f;
                            TextInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            TextInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            SetProperty("SpriteInstance.SourceFile", "UISpriteSheet.png");
                            SpriteInstance.TextureAddress = Gum.Managers.TextureAddress.Custom;
                            SpriteInstance.TextureHeight = 18;
                            SpriteInstance.TextureLeft = 105;
                            SpriteInstance.TextureTop = 15;
                            SpriteInstance.TextureWidth = 31;
                            SpriteInstance.X = -6f;
                            SpriteInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                            SpriteInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                            SpriteInstance.Y = 0f;
                            SpriteInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            SpriteInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            PaceholderText.Alpha = 150;
                            PaceholderText.Blue = 0;
                            PaceholderText.FontSize = 16;
                            PaceholderText.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            PaceholderText.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                            PaceholderText.IsItalic = false;
                            PaceholderText.Rotation = -20f;
                            PaceholderText.Text = "PLACEHOLDER";
                            PaceholderText.VerticalAlignment = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            PaceholderText.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            PaceholderText.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                            PaceholderText.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            PaceholderText.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            PaceholderText.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            break;
                    }
                }
            }
            public ComboBoxCategory? CurrentComboBoxCategoryState
            {
                get
                {
                    return mCurrentComboBoxCategoryState;
                }
                set
                {
                    if (value != null)
                    {
                        mCurrentComboBoxCategoryState = value;
                        switch(mCurrentComboBoxCategoryState)
                        {
                            case  ComboBoxCategory.Enabled:
                                NineSliceInstance.CurrentColorCategoryState = JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Black;
                                TextInstance.CurrentColorCategoryState = JHP4SD.GumRuntimes.TextRuntime.ColorCategory.Gray;
                                NineSliceInstance.Blue = 255;
                                NineSliceInstance.Green = 255;
                                NineSliceInstance.Red = 255;
                                break;
                            case  ComboBoxCategory.Disabled:
                                NineSliceInstance.CurrentColorCategoryState = JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Red;
                                TextInstance.CurrentColorCategoryState = JHP4SD.GumRuntimes.TextRuntime.ColorCategory.Gray;
                                NineSliceInstance.Blue = 255;
                                NineSliceInstance.Green = 255;
                                NineSliceInstance.Red = 255;
                                break;
                            case  ComboBoxCategory.Highlighted:
                                NineSliceInstance.CurrentColorCategoryState = JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Green;
                                TextInstance.CurrentColorCategoryState = JHP4SD.GumRuntimes.TextRuntime.ColorCategory.Black;
                                NineSliceInstance.Blue = 255;
                                NineSliceInstance.Green = 255;
                                NineSliceInstance.Red = 255;
                                break;
                            case  ComboBoxCategory.Pushed:
                                NineSliceInstance.CurrentColorCategoryState = JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Green;
                                TextInstance.CurrentColorCategoryState = JHP4SD.GumRuntimes.TextRuntime.ColorCategory.Black;
                                NineSliceInstance.Blue = 200;
                                NineSliceInstance.Green = 200;
                                NineSliceInstance.Red = 200;
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
                bool setHeightFirstValue = false;
                bool setHeightSecondValue = false;
                float HeightFirstValue= 0;
                float HeightSecondValue= 0;
                bool setListBoxInstanceHeightFirstValue = false;
                bool setListBoxInstanceHeightSecondValue = false;
                float ListBoxInstanceHeightFirstValue= 0;
                float ListBoxInstanceHeightSecondValue= 0;
                bool setListBoxInstanceWidthFirstValue = false;
                bool setListBoxInstanceWidthSecondValue = false;
                float ListBoxInstanceWidthFirstValue= 0;
                float ListBoxInstanceWidthSecondValue= 0;
                bool setListBoxInstanceXFirstValue = false;
                bool setListBoxInstanceXSecondValue = false;
                float ListBoxInstanceXFirstValue= 0;
                float ListBoxInstanceXSecondValue= 0;
                bool setListBoxInstanceYFirstValue = false;
                bool setListBoxInstanceYSecondValue = false;
                float ListBoxInstanceYFirstValue= 0;
                float ListBoxInstanceYSecondValue= 0;
                bool setNineSliceInstanceBlueFirstValue = false;
                bool setNineSliceInstanceBlueSecondValue = false;
                int NineSliceInstanceBlueFirstValue= 0;
                int NineSliceInstanceBlueSecondValue= 0;
                bool setNineSliceInstanceCurrentColorCategoryStateFirstValue = false;
                bool setNineSliceInstanceCurrentColorCategoryStateSecondValue = false;
                JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory NineSliceInstanceCurrentColorCategoryStateFirstValue= JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Gray;
                JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory NineSliceInstanceCurrentColorCategoryStateSecondValue= JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Gray;
                bool setNineSliceInstanceGreenFirstValue = false;
                bool setNineSliceInstanceGreenSecondValue = false;
                int NineSliceInstanceGreenFirstValue= 0;
                int NineSliceInstanceGreenSecondValue= 0;
                bool setNineSliceInstanceHeightFirstValue = false;
                bool setNineSliceInstanceHeightSecondValue = false;
                float NineSliceInstanceHeightFirstValue= 0;
                float NineSliceInstanceHeightSecondValue= 0;
                bool setNineSliceInstanceRedFirstValue = false;
                bool setNineSliceInstanceRedSecondValue = false;
                int NineSliceInstanceRedFirstValue= 0;
                int NineSliceInstanceRedSecondValue= 0;
                bool setNineSliceInstanceWidthFirstValue = false;
                bool setNineSliceInstanceWidthSecondValue = false;
                float NineSliceInstanceWidthFirstValue= 0;
                float NineSliceInstanceWidthSecondValue= 0;
                bool setNineSliceInstanceXFirstValue = false;
                bool setNineSliceInstanceXSecondValue = false;
                float NineSliceInstanceXFirstValue= 0;
                float NineSliceInstanceXSecondValue= 0;
                bool setNineSliceInstanceYFirstValue = false;
                bool setNineSliceInstanceYSecondValue = false;
                float NineSliceInstanceYFirstValue= 0;
                float NineSliceInstanceYSecondValue= 0;
                bool setPaceholderTextAlphaFirstValue = false;
                bool setPaceholderTextAlphaSecondValue = false;
                int PaceholderTextAlphaFirstValue= 0;
                int PaceholderTextAlphaSecondValue= 0;
                bool setPaceholderTextBlueFirstValue = false;
                bool setPaceholderTextBlueSecondValue = false;
                int PaceholderTextBlueFirstValue= 0;
                int PaceholderTextBlueSecondValue= 0;
                bool setPaceholderTextFontSizeFirstValue = false;
                bool setPaceholderTextFontSizeSecondValue = false;
                int PaceholderTextFontSizeFirstValue= 0;
                int PaceholderTextFontSizeSecondValue= 0;
                bool setPaceholderTextRotationFirstValue = false;
                bool setPaceholderTextRotationSecondValue = false;
                float PaceholderTextRotationFirstValue= 0;
                float PaceholderTextRotationSecondValue= 0;
                bool setSpriteInstanceTextureHeightFirstValue = false;
                bool setSpriteInstanceTextureHeightSecondValue = false;
                int SpriteInstanceTextureHeightFirstValue= 0;
                int SpriteInstanceTextureHeightSecondValue= 0;
                bool setSpriteInstanceTextureLeftFirstValue = false;
                bool setSpriteInstanceTextureLeftSecondValue = false;
                int SpriteInstanceTextureLeftFirstValue= 0;
                int SpriteInstanceTextureLeftSecondValue= 0;
                bool setSpriteInstanceTextureTopFirstValue = false;
                bool setSpriteInstanceTextureTopSecondValue = false;
                int SpriteInstanceTextureTopFirstValue= 0;
                int SpriteInstanceTextureTopSecondValue= 0;
                bool setSpriteInstanceTextureWidthFirstValue = false;
                bool setSpriteInstanceTextureWidthSecondValue = false;
                int SpriteInstanceTextureWidthFirstValue= 0;
                int SpriteInstanceTextureWidthSecondValue= 0;
                bool setSpriteInstanceXFirstValue = false;
                bool setSpriteInstanceXSecondValue = false;
                float SpriteInstanceXFirstValue= 0;
                float SpriteInstanceXSecondValue= 0;
                bool setSpriteInstanceYFirstValue = false;
                bool setSpriteInstanceYSecondValue = false;
                float SpriteInstanceYFirstValue= 0;
                float SpriteInstanceYSecondValue= 0;
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
                        setHeightFirstValue = true;
                        HeightFirstValue = 48f;
                        setListBoxInstanceHeightFirstValue = true;
                        ListBoxInstanceHeightFirstValue = 180f;
                        setListBoxInstanceWidthFirstValue = true;
                        ListBoxInstanceWidthFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.ListBoxInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        setListBoxInstanceXFirstValue = true;
                        ListBoxInstanceXFirstValue = 0f;
                        setListBoxInstanceYFirstValue = true;
                        ListBoxInstanceYFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.ListBoxInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                        }
                        setNineSliceInstanceBlueFirstValue = true;
                        NineSliceInstanceBlueFirstValue = 128;
                        setNineSliceInstanceCurrentColorCategoryStateFirstValue = true;
                        NineSliceInstanceCurrentColorCategoryStateFirstValue = JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Gray;
                        setNineSliceInstanceGreenFirstValue = true;
                        NineSliceInstanceGreenFirstValue = 128;
                        setNineSliceInstanceHeightFirstValue = true;
                        NineSliceInstanceHeightFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.NineSliceInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        setNineSliceInstanceRedFirstValue = true;
                        NineSliceInstanceRedFirstValue = 128;
                        setNineSliceInstanceWidthFirstValue = true;
                        NineSliceInstanceWidthFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.NineSliceInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        setNineSliceInstanceXFirstValue = true;
                        NineSliceInstanceXFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.NineSliceInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.NineSliceInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setNineSliceInstanceYFirstValue = true;
                        NineSliceInstanceYFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.NineSliceInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.NineSliceInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setPaceholderTextAlphaFirstValue = true;
                        PaceholderTextAlphaFirstValue = 150;
                        setPaceholderTextBlueFirstValue = true;
                        PaceholderTextBlueFirstValue = 0;
                        setPaceholderTextFontSizeFirstValue = true;
                        PaceholderTextFontSizeFirstValue = 16;
                        if (interpolationValue < 1)
                        {
                            this.PaceholderText.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.PaceholderText.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.PaceholderText.IsItalic = false;
                        }
                        if (interpolationValue < 1)
                        {
                            this.PaceholderText.Parent = this.GetGraphicalUiElementByName("NineSliceInstance") ?? this;
                        }
                        setPaceholderTextRotationFirstValue = true;
                        PaceholderTextRotationFirstValue = -20f;
                        if (interpolationValue < 1)
                        {
                            this.PaceholderText.Text = "PLACEHOLDER";
                        }
                        if (interpolationValue < 1)
                        {
                            this.PaceholderText.VerticalAlignment = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.PaceholderText.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.PaceholderText.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.PaceholderText.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        if (interpolationValue < 1)
                        {
                            this.PaceholderText.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.PaceholderText.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        if (interpolationValue < 1)
                        {
                            this.SpriteInstance.Parent = this.GetGraphicalUiElementByName("NineSliceInstance") ?? this;
                        }
                        if (interpolationValue < 1)
                        {
                            SetProperty("SpriteInstance.SourceFile", "UISpriteSheet.png");
                        }
                        if (interpolationValue < 1)
                        {
                            this.SpriteInstance.TextureAddress = Gum.Managers.TextureAddress.Custom;
                        }
                        setSpriteInstanceTextureHeightFirstValue = true;
                        SpriteInstanceTextureHeightFirstValue = 18;
                        setSpriteInstanceTextureLeftFirstValue = true;
                        SpriteInstanceTextureLeftFirstValue = 105;
                        setSpriteInstanceTextureTopFirstValue = true;
                        SpriteInstanceTextureTopFirstValue = 15;
                        setSpriteInstanceTextureWidthFirstValue = true;
                        SpriteInstanceTextureWidthFirstValue = 31;
                        setSpriteInstanceXFirstValue = true;
                        SpriteInstanceXFirstValue = -6f;
                        if (interpolationValue < 1)
                        {
                            this.SpriteInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                        }
                        if (interpolationValue < 1)
                        {
                            this.SpriteInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                        }
                        setSpriteInstanceYFirstValue = true;
                        SpriteInstanceYFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.SpriteInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.SpriteInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setTextInstanceCurrentColorCategoryStateFirstValue = true;
                        TextInstanceCurrentColorCategoryStateFirstValue = JHP4SD.GumRuntimes.TextRuntime.ColorCategory.Gray;
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
                        TextInstanceXFirstValue = 16f;
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
                        WidthFirstValue = 250f;
                        break;
                }
                switch(secondState)
                {
                    case  VariableState.Default:
                        setHeightSecondValue = true;
                        HeightSecondValue = 48f;
                        setListBoxInstanceHeightSecondValue = true;
                        ListBoxInstanceHeightSecondValue = 180f;
                        setListBoxInstanceWidthSecondValue = true;
                        ListBoxInstanceWidthSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.ListBoxInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        setListBoxInstanceXSecondValue = true;
                        ListBoxInstanceXSecondValue = 0f;
                        setListBoxInstanceYSecondValue = true;
                        ListBoxInstanceYSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.ListBoxInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                        }
                        setNineSliceInstanceBlueSecondValue = true;
                        NineSliceInstanceBlueSecondValue = 128;
                        setNineSliceInstanceCurrentColorCategoryStateSecondValue = true;
                        NineSliceInstanceCurrentColorCategoryStateSecondValue = JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Gray;
                        setNineSliceInstanceGreenSecondValue = true;
                        NineSliceInstanceGreenSecondValue = 128;
                        setNineSliceInstanceHeightSecondValue = true;
                        NineSliceInstanceHeightSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.NineSliceInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        setNineSliceInstanceRedSecondValue = true;
                        NineSliceInstanceRedSecondValue = 128;
                        setNineSliceInstanceWidthSecondValue = true;
                        NineSliceInstanceWidthSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.NineSliceInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        setNineSliceInstanceXSecondValue = true;
                        NineSliceInstanceXSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.NineSliceInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.NineSliceInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setNineSliceInstanceYSecondValue = true;
                        NineSliceInstanceYSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.NineSliceInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.NineSliceInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setPaceholderTextAlphaSecondValue = true;
                        PaceholderTextAlphaSecondValue = 150;
                        setPaceholderTextBlueSecondValue = true;
                        PaceholderTextBlueSecondValue = 0;
                        setPaceholderTextFontSizeSecondValue = true;
                        PaceholderTextFontSizeSecondValue = 16;
                        if (interpolationValue >= 1)
                        {
                            this.PaceholderText.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.PaceholderText.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.PaceholderText.IsItalic = false;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.PaceholderText.Parent = this.GetGraphicalUiElementByName("NineSliceInstance") ?? this;
                        }
                        setPaceholderTextRotationSecondValue = true;
                        PaceholderTextRotationSecondValue = -20f;
                        if (interpolationValue >= 1)
                        {
                            this.PaceholderText.Text = "PLACEHOLDER";
                        }
                        if (interpolationValue >= 1)
                        {
                            this.PaceholderText.VerticalAlignment = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.PaceholderText.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.PaceholderText.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.PaceholderText.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.PaceholderText.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.PaceholderText.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.SpriteInstance.Parent = this.GetGraphicalUiElementByName("NineSliceInstance") ?? this;
                        }
                        if (interpolationValue >= 1)
                        {
                            SetProperty("SpriteInstance.SourceFile", "UISpriteSheet.png");
                        }
                        if (interpolationValue >= 1)
                        {
                            this.SpriteInstance.TextureAddress = Gum.Managers.TextureAddress.Custom;
                        }
                        setSpriteInstanceTextureHeightSecondValue = true;
                        SpriteInstanceTextureHeightSecondValue = 18;
                        setSpriteInstanceTextureLeftSecondValue = true;
                        SpriteInstanceTextureLeftSecondValue = 105;
                        setSpriteInstanceTextureTopSecondValue = true;
                        SpriteInstanceTextureTopSecondValue = 15;
                        setSpriteInstanceTextureWidthSecondValue = true;
                        SpriteInstanceTextureWidthSecondValue = 31;
                        setSpriteInstanceXSecondValue = true;
                        SpriteInstanceXSecondValue = -6f;
                        if (interpolationValue >= 1)
                        {
                            this.SpriteInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.SpriteInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                        }
                        setSpriteInstanceYSecondValue = true;
                        SpriteInstanceYSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.SpriteInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.SpriteInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setTextInstanceCurrentColorCategoryStateSecondValue = true;
                        TextInstanceCurrentColorCategoryStateSecondValue = JHP4SD.GumRuntimes.TextRuntime.ColorCategory.Gray;
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
                        TextInstanceXSecondValue = 16f;
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
                        WidthSecondValue = 250f;
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
                if (setListBoxInstanceHeightFirstValue && setListBoxInstanceHeightSecondValue)
                {
                    ListBoxInstance.Height = ListBoxInstanceHeightFirstValue * (1 - interpolationValue) + ListBoxInstanceHeightSecondValue * interpolationValue;
                }
                if (setListBoxInstanceWidthFirstValue && setListBoxInstanceWidthSecondValue)
                {
                    ListBoxInstance.Width = ListBoxInstanceWidthFirstValue * (1 - interpolationValue) + ListBoxInstanceWidthSecondValue * interpolationValue;
                }
                if (setListBoxInstanceXFirstValue && setListBoxInstanceXSecondValue)
                {
                    ListBoxInstance.X = ListBoxInstanceXFirstValue * (1 - interpolationValue) + ListBoxInstanceXSecondValue * interpolationValue;
                }
                if (setListBoxInstanceYFirstValue && setListBoxInstanceYSecondValue)
                {
                    ListBoxInstance.Y = ListBoxInstanceYFirstValue * (1 - interpolationValue) + ListBoxInstanceYSecondValue * interpolationValue;
                }
                if (setNineSliceInstanceBlueFirstValue && setNineSliceInstanceBlueSecondValue)
                {
                    NineSliceInstance.Blue = FlatRedBall.Math.MathFunctions.RoundToInt(NineSliceInstanceBlueFirstValue* (1 - interpolationValue) + NineSliceInstanceBlueSecondValue * interpolationValue);
                }
                if (setNineSliceInstanceCurrentColorCategoryStateFirstValue && setNineSliceInstanceCurrentColorCategoryStateSecondValue)
                {
                    NineSliceInstance.InterpolateBetween(NineSliceInstanceCurrentColorCategoryStateFirstValue, NineSliceInstanceCurrentColorCategoryStateSecondValue, interpolationValue);
                }
                if (setNineSliceInstanceGreenFirstValue && setNineSliceInstanceGreenSecondValue)
                {
                    NineSliceInstance.Green = FlatRedBall.Math.MathFunctions.RoundToInt(NineSliceInstanceGreenFirstValue* (1 - interpolationValue) + NineSliceInstanceGreenSecondValue * interpolationValue);
                }
                if (setNineSliceInstanceHeightFirstValue && setNineSliceInstanceHeightSecondValue)
                {
                    NineSliceInstance.Height = NineSliceInstanceHeightFirstValue * (1 - interpolationValue) + NineSliceInstanceHeightSecondValue * interpolationValue;
                }
                if (setNineSliceInstanceRedFirstValue && setNineSliceInstanceRedSecondValue)
                {
                    NineSliceInstance.Red = FlatRedBall.Math.MathFunctions.RoundToInt(NineSliceInstanceRedFirstValue* (1 - interpolationValue) + NineSliceInstanceRedSecondValue * interpolationValue);
                }
                if (setNineSliceInstanceWidthFirstValue && setNineSliceInstanceWidthSecondValue)
                {
                    NineSliceInstance.Width = NineSliceInstanceWidthFirstValue * (1 - interpolationValue) + NineSliceInstanceWidthSecondValue * interpolationValue;
                }
                if (setNineSliceInstanceXFirstValue && setNineSliceInstanceXSecondValue)
                {
                    NineSliceInstance.X = NineSliceInstanceXFirstValue * (1 - interpolationValue) + NineSliceInstanceXSecondValue * interpolationValue;
                }
                if (setNineSliceInstanceYFirstValue && setNineSliceInstanceYSecondValue)
                {
                    NineSliceInstance.Y = NineSliceInstanceYFirstValue * (1 - interpolationValue) + NineSliceInstanceYSecondValue * interpolationValue;
                }
                if (setPaceholderTextAlphaFirstValue && setPaceholderTextAlphaSecondValue)
                {
                    PaceholderText.Alpha = FlatRedBall.Math.MathFunctions.RoundToInt(PaceholderTextAlphaFirstValue* (1 - interpolationValue) + PaceholderTextAlphaSecondValue * interpolationValue);
                }
                if (setPaceholderTextBlueFirstValue && setPaceholderTextBlueSecondValue)
                {
                    PaceholderText.Blue = FlatRedBall.Math.MathFunctions.RoundToInt(PaceholderTextBlueFirstValue* (1 - interpolationValue) + PaceholderTextBlueSecondValue * interpolationValue);
                }
                if (setPaceholderTextFontSizeFirstValue && setPaceholderTextFontSizeSecondValue)
                {
                    PaceholderText.FontSize = FlatRedBall.Math.MathFunctions.RoundToInt(PaceholderTextFontSizeFirstValue* (1 - interpolationValue) + PaceholderTextFontSizeSecondValue * interpolationValue);
                }
                if (setPaceholderTextRotationFirstValue && setPaceholderTextRotationSecondValue)
                {
                    PaceholderText.Rotation = PaceholderTextRotationFirstValue * (1 - interpolationValue) + PaceholderTextRotationSecondValue * interpolationValue;
                }
                if (setSpriteInstanceTextureHeightFirstValue && setSpriteInstanceTextureHeightSecondValue)
                {
                    SpriteInstance.TextureHeight = FlatRedBall.Math.MathFunctions.RoundToInt(SpriteInstanceTextureHeightFirstValue* (1 - interpolationValue) + SpriteInstanceTextureHeightSecondValue * interpolationValue);
                }
                if (setSpriteInstanceTextureLeftFirstValue && setSpriteInstanceTextureLeftSecondValue)
                {
                    SpriteInstance.TextureLeft = FlatRedBall.Math.MathFunctions.RoundToInt(SpriteInstanceTextureLeftFirstValue* (1 - interpolationValue) + SpriteInstanceTextureLeftSecondValue * interpolationValue);
                }
                if (setSpriteInstanceTextureTopFirstValue && setSpriteInstanceTextureTopSecondValue)
                {
                    SpriteInstance.TextureTop = FlatRedBall.Math.MathFunctions.RoundToInt(SpriteInstanceTextureTopFirstValue* (1 - interpolationValue) + SpriteInstanceTextureTopSecondValue * interpolationValue);
                }
                if (setSpriteInstanceTextureWidthFirstValue && setSpriteInstanceTextureWidthSecondValue)
                {
                    SpriteInstance.TextureWidth = FlatRedBall.Math.MathFunctions.RoundToInt(SpriteInstanceTextureWidthFirstValue* (1 - interpolationValue) + SpriteInstanceTextureWidthSecondValue * interpolationValue);
                }
                if (setSpriteInstanceXFirstValue && setSpriteInstanceXSecondValue)
                {
                    SpriteInstance.X = SpriteInstanceXFirstValue * (1 - interpolationValue) + SpriteInstanceXSecondValue * interpolationValue;
                }
                if (setSpriteInstanceYFirstValue && setSpriteInstanceYSecondValue)
                {
                    SpriteInstance.Y = SpriteInstanceYFirstValue * (1 - interpolationValue) + SpriteInstanceYSecondValue * interpolationValue;
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
            public void InterpolateBetween (ComboBoxCategory firstState, ComboBoxCategory secondState, float interpolationValue) 
            {
                #if DEBUG
                if (float.IsNaN(interpolationValue))
                {
                    throw new System.Exception("interpolationValue cannot be NaN");
                }
                #endif
                bool setNineSliceInstanceBlueFirstValue = false;
                bool setNineSliceInstanceBlueSecondValue = false;
                int NineSliceInstanceBlueFirstValue= 0;
                int NineSliceInstanceBlueSecondValue= 0;
                bool setNineSliceInstanceCurrentColorCategoryStateFirstValue = false;
                bool setNineSliceInstanceCurrentColorCategoryStateSecondValue = false;
                JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory NineSliceInstanceCurrentColorCategoryStateFirstValue= JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Gray;
                JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory NineSliceInstanceCurrentColorCategoryStateSecondValue= JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Gray;
                bool setNineSliceInstanceGreenFirstValue = false;
                bool setNineSliceInstanceGreenSecondValue = false;
                int NineSliceInstanceGreenFirstValue= 0;
                int NineSliceInstanceGreenSecondValue= 0;
                bool setNineSliceInstanceRedFirstValue = false;
                bool setNineSliceInstanceRedSecondValue = false;
                int NineSliceInstanceRedFirstValue= 0;
                int NineSliceInstanceRedSecondValue= 0;
                bool setTextInstanceCurrentColorCategoryStateFirstValue = false;
                bool setTextInstanceCurrentColorCategoryStateSecondValue = false;
                JHP4SD.GumRuntimes.TextRuntime.ColorCategory TextInstanceCurrentColorCategoryStateFirstValue= JHP4SD.GumRuntimes.TextRuntime.ColorCategory.Gray;
                JHP4SD.GumRuntimes.TextRuntime.ColorCategory TextInstanceCurrentColorCategoryStateSecondValue= JHP4SD.GumRuntimes.TextRuntime.ColorCategory.Gray;
                switch(firstState)
                {
                    case  ComboBoxCategory.Enabled:
                        setNineSliceInstanceBlueFirstValue = true;
                        NineSliceInstanceBlueFirstValue = 255;
                        setNineSliceInstanceCurrentColorCategoryStateFirstValue = true;
                        NineSliceInstanceCurrentColorCategoryStateFirstValue = JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Black;
                        setNineSliceInstanceGreenFirstValue = true;
                        NineSliceInstanceGreenFirstValue = 255;
                        setNineSliceInstanceRedFirstValue = true;
                        NineSliceInstanceRedFirstValue = 255;
                        setTextInstanceCurrentColorCategoryStateFirstValue = true;
                        TextInstanceCurrentColorCategoryStateFirstValue = JHP4SD.GumRuntimes.TextRuntime.ColorCategory.Gray;
                        break;
                    case  ComboBoxCategory.Disabled:
                        setNineSliceInstanceBlueFirstValue = true;
                        NineSliceInstanceBlueFirstValue = 255;
                        setNineSliceInstanceCurrentColorCategoryStateFirstValue = true;
                        NineSliceInstanceCurrentColorCategoryStateFirstValue = JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Red;
                        setNineSliceInstanceGreenFirstValue = true;
                        NineSliceInstanceGreenFirstValue = 255;
                        setNineSliceInstanceRedFirstValue = true;
                        NineSliceInstanceRedFirstValue = 255;
                        setTextInstanceCurrentColorCategoryStateFirstValue = true;
                        TextInstanceCurrentColorCategoryStateFirstValue = JHP4SD.GumRuntimes.TextRuntime.ColorCategory.Gray;
                        break;
                    case  ComboBoxCategory.Highlighted:
                        setNineSliceInstanceBlueFirstValue = true;
                        NineSliceInstanceBlueFirstValue = 255;
                        setNineSliceInstanceCurrentColorCategoryStateFirstValue = true;
                        NineSliceInstanceCurrentColorCategoryStateFirstValue = JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Green;
                        setNineSliceInstanceGreenFirstValue = true;
                        NineSliceInstanceGreenFirstValue = 255;
                        setNineSliceInstanceRedFirstValue = true;
                        NineSliceInstanceRedFirstValue = 255;
                        setTextInstanceCurrentColorCategoryStateFirstValue = true;
                        TextInstanceCurrentColorCategoryStateFirstValue = JHP4SD.GumRuntimes.TextRuntime.ColorCategory.Black;
                        break;
                    case  ComboBoxCategory.Pushed:
                        setNineSliceInstanceBlueFirstValue = true;
                        NineSliceInstanceBlueFirstValue = 200;
                        setNineSliceInstanceCurrentColorCategoryStateFirstValue = true;
                        NineSliceInstanceCurrentColorCategoryStateFirstValue = JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Green;
                        setNineSliceInstanceGreenFirstValue = true;
                        NineSliceInstanceGreenFirstValue = 200;
                        setNineSliceInstanceRedFirstValue = true;
                        NineSliceInstanceRedFirstValue = 200;
                        setTextInstanceCurrentColorCategoryStateFirstValue = true;
                        TextInstanceCurrentColorCategoryStateFirstValue = JHP4SD.GumRuntimes.TextRuntime.ColorCategory.Black;
                        break;
                }
                switch(secondState)
                {
                    case  ComboBoxCategory.Enabled:
                        setNineSliceInstanceBlueSecondValue = true;
                        NineSliceInstanceBlueSecondValue = 255;
                        setNineSliceInstanceCurrentColorCategoryStateSecondValue = true;
                        NineSliceInstanceCurrentColorCategoryStateSecondValue = JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Black;
                        setNineSliceInstanceGreenSecondValue = true;
                        NineSliceInstanceGreenSecondValue = 255;
                        setNineSliceInstanceRedSecondValue = true;
                        NineSliceInstanceRedSecondValue = 255;
                        setTextInstanceCurrentColorCategoryStateSecondValue = true;
                        TextInstanceCurrentColorCategoryStateSecondValue = JHP4SD.GumRuntimes.TextRuntime.ColorCategory.Gray;
                        break;
                    case  ComboBoxCategory.Disabled:
                        setNineSliceInstanceBlueSecondValue = true;
                        NineSliceInstanceBlueSecondValue = 255;
                        setNineSliceInstanceCurrentColorCategoryStateSecondValue = true;
                        NineSliceInstanceCurrentColorCategoryStateSecondValue = JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Red;
                        setNineSliceInstanceGreenSecondValue = true;
                        NineSliceInstanceGreenSecondValue = 255;
                        setNineSliceInstanceRedSecondValue = true;
                        NineSliceInstanceRedSecondValue = 255;
                        setTextInstanceCurrentColorCategoryStateSecondValue = true;
                        TextInstanceCurrentColorCategoryStateSecondValue = JHP4SD.GumRuntimes.TextRuntime.ColorCategory.Gray;
                        break;
                    case  ComboBoxCategory.Highlighted:
                        setNineSliceInstanceBlueSecondValue = true;
                        NineSliceInstanceBlueSecondValue = 255;
                        setNineSliceInstanceCurrentColorCategoryStateSecondValue = true;
                        NineSliceInstanceCurrentColorCategoryStateSecondValue = JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Green;
                        setNineSliceInstanceGreenSecondValue = true;
                        NineSliceInstanceGreenSecondValue = 255;
                        setNineSliceInstanceRedSecondValue = true;
                        NineSliceInstanceRedSecondValue = 255;
                        setTextInstanceCurrentColorCategoryStateSecondValue = true;
                        TextInstanceCurrentColorCategoryStateSecondValue = JHP4SD.GumRuntimes.TextRuntime.ColorCategory.Black;
                        break;
                    case  ComboBoxCategory.Pushed:
                        setNineSliceInstanceBlueSecondValue = true;
                        NineSliceInstanceBlueSecondValue = 200;
                        setNineSliceInstanceCurrentColorCategoryStateSecondValue = true;
                        NineSliceInstanceCurrentColorCategoryStateSecondValue = JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Green;
                        setNineSliceInstanceGreenSecondValue = true;
                        NineSliceInstanceGreenSecondValue = 200;
                        setNineSliceInstanceRedSecondValue = true;
                        NineSliceInstanceRedSecondValue = 200;
                        setTextInstanceCurrentColorCategoryStateSecondValue = true;
                        TextInstanceCurrentColorCategoryStateSecondValue = JHP4SD.GumRuntimes.TextRuntime.ColorCategory.Black;
                        break;
                }
                var wasSuppressed = mIsLayoutSuspended;
                if (wasSuppressed == false)
                {
                    SuspendLayout(true);
                }
                if (setNineSliceInstanceBlueFirstValue && setNineSliceInstanceBlueSecondValue)
                {
                    NineSliceInstance.Blue = FlatRedBall.Math.MathFunctions.RoundToInt(NineSliceInstanceBlueFirstValue* (1 - interpolationValue) + NineSliceInstanceBlueSecondValue * interpolationValue);
                }
                if (setNineSliceInstanceCurrentColorCategoryStateFirstValue && setNineSliceInstanceCurrentColorCategoryStateSecondValue)
                {
                    NineSliceInstance.InterpolateBetween(NineSliceInstanceCurrentColorCategoryStateFirstValue, NineSliceInstanceCurrentColorCategoryStateSecondValue, interpolationValue);
                }
                if (setNineSliceInstanceGreenFirstValue && setNineSliceInstanceGreenSecondValue)
                {
                    NineSliceInstance.Green = FlatRedBall.Math.MathFunctions.RoundToInt(NineSliceInstanceGreenFirstValue* (1 - interpolationValue) + NineSliceInstanceGreenSecondValue * interpolationValue);
                }
                if (setNineSliceInstanceRedFirstValue && setNineSliceInstanceRedSecondValue)
                {
                    NineSliceInstance.Red = FlatRedBall.Math.MathFunctions.RoundToInt(NineSliceInstanceRedFirstValue* (1 - interpolationValue) + NineSliceInstanceRedSecondValue * interpolationValue);
                }
                if (setTextInstanceCurrentColorCategoryStateFirstValue && setTextInstanceCurrentColorCategoryStateSecondValue)
                {
                    TextInstance.InterpolateBetween(TextInstanceCurrentColorCategoryStateFirstValue, TextInstanceCurrentColorCategoryStateSecondValue, interpolationValue);
                }
                if (interpolationValue < 1)
                {
                    mCurrentComboBoxCategoryState = firstState;
                }
                else
                {
                    mCurrentComboBoxCategoryState = secondState;
                }
                if (!wasSuppressed)
                {
                    ResumeLayout(true);
                }
            }
            #endregion
            #region State Interpolate To
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (JHP4SD.GumRuntimes.LebegForms.BasicComponents.MyComboBoxRuntime.VariableState fromState,JHP4SD.GumRuntimes.LebegForms.BasicComponents.MyComboBoxRuntime.VariableState toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null) 
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
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (JHP4SD.GumRuntimes.LebegForms.BasicComponents.MyComboBoxRuntime.ComboBoxCategory fromState,JHP4SD.GumRuntimes.LebegForms.BasicComponents.MyComboBoxRuntime.ComboBoxCategory toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null) 
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
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (ComboBoxCategory toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null ) 
            {
                Gum.DataTypes.Variables.StateSave current = GetCurrentValuesOnState(toState);
                Gum.DataTypes.Variables.StateSave toAsStateSave = this.ElementSave.Categories.First(item => item.Name == "ComboBoxCategory").States.First(item => item.Name == toState.ToString());
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
                tweener.Ended += ()=> this.CurrentComboBoxCategoryState = toState;
                tweener.Start();
                StateInterpolationPlugin.TweenerManager.Self.Add(tweener);
                return tweener;
            }
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateToRelative (ComboBoxCategory toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null ) 
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
                tweener.Ended += ()=> this.CurrentComboBoxCategoryState = toState;
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
                ListBoxInstance.StopAnimations();
                NineSliceInstance.StopAnimations();
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
                            Name = "ListBoxInstance.Height",
                            Type = "float",
                            Value = ListBoxInstance.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ListBoxInstance.Width",
                            Type = "float",
                            Value = ListBoxInstance.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ListBoxInstance.Width Units",
                            Type = "DimensionUnitType",
                            Value = ListBoxInstance.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ListBoxInstance.X",
                            Type = "float",
                            Value = ListBoxInstance.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ListBoxInstance.Y",
                            Type = "float",
                            Value = ListBoxInstance.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ListBoxInstance.Y Units",
                            Type = "PositionUnitType",
                            Value = ListBoxInstance.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NineSliceInstance.Blue",
                            Type = "int",
                            Value = NineSliceInstance.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NineSliceInstance.ColorCategoryState",
                            Type = "ColorCategoryState",
                            Value = NineSliceInstance.CurrentColorCategoryState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NineSliceInstance.Green",
                            Type = "int",
                            Value = NineSliceInstance.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NineSliceInstance.Height",
                            Type = "float",
                            Value = NineSliceInstance.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NineSliceInstance.Height Units",
                            Type = "DimensionUnitType",
                            Value = NineSliceInstance.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NineSliceInstance.Red",
                            Type = "int",
                            Value = NineSliceInstance.Red
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NineSliceInstance.Width",
                            Type = "float",
                            Value = NineSliceInstance.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NineSliceInstance.Width Units",
                            Type = "DimensionUnitType",
                            Value = NineSliceInstance.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NineSliceInstance.X",
                            Type = "float",
                            Value = NineSliceInstance.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NineSliceInstance.X Origin",
                            Type = "HorizontalAlignment",
                            Value = NineSliceInstance.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NineSliceInstance.X Units",
                            Type = "PositionUnitType",
                            Value = NineSliceInstance.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NineSliceInstance.Y",
                            Type = "float",
                            Value = NineSliceInstance.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NineSliceInstance.Y Origin",
                            Type = "VerticalAlignment",
                            Value = NineSliceInstance.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NineSliceInstance.Y Units",
                            Type = "PositionUnitType",
                            Value = NineSliceInstance.YUnits
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
                            Name = "SpriteInstance.Parent",
                            Type = "string",
                            Value = SpriteInstance.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.SourceFile",
                            Type = "string",
                            Value = SpriteInstance.SourceFile
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
                            Name = "SpriteInstance.Texture Height",
                            Type = "int",
                            Value = SpriteInstance.TextureHeight
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Texture Left",
                            Type = "int",
                            Value = SpriteInstance.TextureLeft
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Texture Top",
                            Type = "int",
                            Value = SpriteInstance.TextureTop
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Texture Width",
                            Type = "int",
                            Value = SpriteInstance.TextureWidth
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.X",
                            Type = "float",
                            Value = SpriteInstance.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.X Origin",
                            Type = "HorizontalAlignment",
                            Value = SpriteInstance.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.X Units",
                            Type = "PositionUnitType",
                            Value = SpriteInstance.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Y",
                            Type = "float",
                            Value = SpriteInstance.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Y Origin",
                            Type = "VerticalAlignment",
                            Value = SpriteInstance.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Y Units",
                            Type = "PositionUnitType",
                            Value = SpriteInstance.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PaceholderText.Alpha",
                            Type = "int",
                            Value = PaceholderText.Alpha
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PaceholderText.Blue",
                            Type = "int",
                            Value = PaceholderText.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PaceholderText.FontSize",
                            Type = "int",
                            Value = PaceholderText.FontSize
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PaceholderText.Height Units",
                            Type = "DimensionUnitType",
                            Value = PaceholderText.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PaceholderText.HorizontalAlignment",
                            Type = "HorizontalAlignment",
                            Value = PaceholderText.HorizontalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PaceholderText.IsItalic",
                            Type = "bool",
                            Value = PaceholderText.IsItalic
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PaceholderText.Parent",
                            Type = "string",
                            Value = PaceholderText.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PaceholderText.Rotation",
                            Type = "float",
                            Value = PaceholderText.Rotation
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PaceholderText.Text",
                            Type = "string",
                            Value = PaceholderText.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PaceholderText.VerticalAlignment",
                            Type = "VerticalAlignment",
                            Value = PaceholderText.VerticalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PaceholderText.Width Units",
                            Type = "DimensionUnitType",
                            Value = PaceholderText.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PaceholderText.X Origin",
                            Type = "HorizontalAlignment",
                            Value = PaceholderText.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PaceholderText.X Units",
                            Type = "PositionUnitType",
                            Value = PaceholderText.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PaceholderText.Y Origin",
                            Type = "VerticalAlignment",
                            Value = PaceholderText.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PaceholderText.Y Units",
                            Type = "PositionUnitType",
                            Value = PaceholderText.YUnits
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
                            Value = Height + 48f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Width",
                            Type = "float",
                            Value = Width + 250f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ListBoxInstance.Height",
                            Type = "float",
                            Value = ListBoxInstance.Height + 180f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ListBoxInstance.Width",
                            Type = "float",
                            Value = ListBoxInstance.Width + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ListBoxInstance.Width Units",
                            Type = "DimensionUnitType",
                            Value = ListBoxInstance.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ListBoxInstance.X",
                            Type = "float",
                            Value = ListBoxInstance.X + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ListBoxInstance.Y",
                            Type = "float",
                            Value = ListBoxInstance.Y + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ListBoxInstance.Y Units",
                            Type = "PositionUnitType",
                            Value = ListBoxInstance.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NineSliceInstance.Blue",
                            Type = "int",
                            Value = NineSliceInstance.Blue + 128
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NineSliceInstance.ColorCategoryState",
                            Type = "ColorCategoryState",
                            Value = NineSliceInstance.CurrentColorCategoryState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NineSliceInstance.Green",
                            Type = "int",
                            Value = NineSliceInstance.Green + 128
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NineSliceInstance.Height",
                            Type = "float",
                            Value = NineSliceInstance.Height + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NineSliceInstance.Height Units",
                            Type = "DimensionUnitType",
                            Value = NineSliceInstance.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NineSliceInstance.Red",
                            Type = "int",
                            Value = NineSliceInstance.Red + 128
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NineSliceInstance.Width",
                            Type = "float",
                            Value = NineSliceInstance.Width + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NineSliceInstance.Width Units",
                            Type = "DimensionUnitType",
                            Value = NineSliceInstance.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NineSliceInstance.X",
                            Type = "float",
                            Value = NineSliceInstance.X + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NineSliceInstance.X Origin",
                            Type = "HorizontalAlignment",
                            Value = NineSliceInstance.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NineSliceInstance.X Units",
                            Type = "PositionUnitType",
                            Value = NineSliceInstance.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NineSliceInstance.Y",
                            Type = "float",
                            Value = NineSliceInstance.Y + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NineSliceInstance.Y Origin",
                            Type = "VerticalAlignment",
                            Value = NineSliceInstance.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NineSliceInstance.Y Units",
                            Type = "PositionUnitType",
                            Value = NineSliceInstance.YUnits
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
                            Value = TextInstance.X + 16f
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
                            Name = "SpriteInstance.Parent",
                            Type = "string",
                            Value = SpriteInstance.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.SourceFile",
                            Type = "string",
                            Value = SpriteInstance.SourceFile
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
                            Name = "SpriteInstance.Texture Height",
                            Type = "int",
                            Value = SpriteInstance.TextureHeight + 18
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Texture Left",
                            Type = "int",
                            Value = SpriteInstance.TextureLeft + 105
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Texture Top",
                            Type = "int",
                            Value = SpriteInstance.TextureTop + 15
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Texture Width",
                            Type = "int",
                            Value = SpriteInstance.TextureWidth + 31
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.X",
                            Type = "float",
                            Value = SpriteInstance.X + -6f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.X Origin",
                            Type = "HorizontalAlignment",
                            Value = SpriteInstance.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.X Units",
                            Type = "PositionUnitType",
                            Value = SpriteInstance.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Y",
                            Type = "float",
                            Value = SpriteInstance.Y + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Y Origin",
                            Type = "VerticalAlignment",
                            Value = SpriteInstance.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Y Units",
                            Type = "PositionUnitType",
                            Value = SpriteInstance.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PaceholderText.Alpha",
                            Type = "int",
                            Value = PaceholderText.Alpha + 150
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PaceholderText.Blue",
                            Type = "int",
                            Value = PaceholderText.Blue + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PaceholderText.FontSize",
                            Type = "int",
                            Value = PaceholderText.FontSize + 16
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PaceholderText.Height Units",
                            Type = "DimensionUnitType",
                            Value = PaceholderText.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PaceholderText.HorizontalAlignment",
                            Type = "HorizontalAlignment",
                            Value = PaceholderText.HorizontalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PaceholderText.IsItalic",
                            Type = "bool",
                            Value = PaceholderText.IsItalic
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PaceholderText.Parent",
                            Type = "string",
                            Value = PaceholderText.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PaceholderText.Rotation",
                            Type = "float",
                            Value = PaceholderText.Rotation + -20f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PaceholderText.Text",
                            Type = "string",
                            Value = PaceholderText.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PaceholderText.VerticalAlignment",
                            Type = "VerticalAlignment",
                            Value = PaceholderText.VerticalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PaceholderText.Width Units",
                            Type = "DimensionUnitType",
                            Value = PaceholderText.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PaceholderText.X Origin",
                            Type = "HorizontalAlignment",
                            Value = PaceholderText.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PaceholderText.X Units",
                            Type = "PositionUnitType",
                            Value = PaceholderText.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PaceholderText.Y Origin",
                            Type = "VerticalAlignment",
                            Value = PaceholderText.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PaceholderText.Y Units",
                            Type = "PositionUnitType",
                            Value = PaceholderText.YUnits
                        }
                        );
                        break;
                }
                return newState;
            }
            private Gum.DataTypes.Variables.StateSave GetCurrentValuesOnState (ComboBoxCategory state) 
            {
                Gum.DataTypes.Variables.StateSave newState = new Gum.DataTypes.Variables.StateSave();
                switch(state)
                {
                    case  ComboBoxCategory.Enabled:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NineSliceInstance.Blue",
                            Type = "int",
                            Value = NineSliceInstance.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NineSliceInstance.ColorCategoryState",
                            Type = "ColorCategoryState",
                            Value = NineSliceInstance.CurrentColorCategoryState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NineSliceInstance.Green",
                            Type = "int",
                            Value = NineSliceInstance.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NineSliceInstance.Red",
                            Type = "int",
                            Value = NineSliceInstance.Red
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
                        break;
                    case  ComboBoxCategory.Disabled:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NineSliceInstance.Blue",
                            Type = "int",
                            Value = NineSliceInstance.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NineSliceInstance.ColorCategoryState",
                            Type = "ColorCategoryState",
                            Value = NineSliceInstance.CurrentColorCategoryState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NineSliceInstance.Green",
                            Type = "int",
                            Value = NineSliceInstance.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NineSliceInstance.Red",
                            Type = "int",
                            Value = NineSliceInstance.Red
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
                        break;
                    case  ComboBoxCategory.Highlighted:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NineSliceInstance.Blue",
                            Type = "int",
                            Value = NineSliceInstance.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NineSliceInstance.ColorCategoryState",
                            Type = "ColorCategoryState",
                            Value = NineSliceInstance.CurrentColorCategoryState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NineSliceInstance.Green",
                            Type = "int",
                            Value = NineSliceInstance.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NineSliceInstance.Red",
                            Type = "int",
                            Value = NineSliceInstance.Red
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
                        break;
                    case  ComboBoxCategory.Pushed:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NineSliceInstance.Blue",
                            Type = "int",
                            Value = NineSliceInstance.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NineSliceInstance.ColorCategoryState",
                            Type = "ColorCategoryState",
                            Value = NineSliceInstance.CurrentColorCategoryState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NineSliceInstance.Green",
                            Type = "int",
                            Value = NineSliceInstance.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NineSliceInstance.Red",
                            Type = "int",
                            Value = NineSliceInstance.Red
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
                        break;
                }
                return newState;
            }
            private Gum.DataTypes.Variables.StateSave AddToCurrentValuesWithState (ComboBoxCategory state) 
            {
                Gum.DataTypes.Variables.StateSave newState = new Gum.DataTypes.Variables.StateSave();
                switch(state)
                {
                    case  ComboBoxCategory.Enabled:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NineSliceInstance.Blue",
                            Type = "int",
                            Value = NineSliceInstance.Blue + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NineSliceInstance.ColorCategoryState",
                            Type = "ColorCategoryState",
                            Value = NineSliceInstance.CurrentColorCategoryState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NineSliceInstance.Green",
                            Type = "int",
                            Value = NineSliceInstance.Green + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NineSliceInstance.Red",
                            Type = "int",
                            Value = NineSliceInstance.Red + 255
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
                        break;
                    case  ComboBoxCategory.Disabled:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NineSliceInstance.Blue",
                            Type = "int",
                            Value = NineSliceInstance.Blue + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NineSliceInstance.ColorCategoryState",
                            Type = "ColorCategoryState",
                            Value = NineSliceInstance.CurrentColorCategoryState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NineSliceInstance.Green",
                            Type = "int",
                            Value = NineSliceInstance.Green + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NineSliceInstance.Red",
                            Type = "int",
                            Value = NineSliceInstance.Red + 255
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
                        break;
                    case  ComboBoxCategory.Highlighted:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NineSliceInstance.Blue",
                            Type = "int",
                            Value = NineSliceInstance.Blue + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NineSliceInstance.ColorCategoryState",
                            Type = "ColorCategoryState",
                            Value = NineSliceInstance.CurrentColorCategoryState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NineSliceInstance.Green",
                            Type = "int",
                            Value = NineSliceInstance.Green + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NineSliceInstance.Red",
                            Type = "int",
                            Value = NineSliceInstance.Red + 255
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
                        break;
                    case  ComboBoxCategory.Pushed:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NineSliceInstance.Blue",
                            Type = "int",
                            Value = NineSliceInstance.Blue + 200
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NineSliceInstance.ColorCategoryState",
                            Type = "ColorCategoryState",
                            Value = NineSliceInstance.CurrentColorCategoryState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NineSliceInstance.Green",
                            Type = "int",
                            Value = NineSliceInstance.Green + 200
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NineSliceInstance.Red",
                            Type = "int",
                            Value = NineSliceInstance.Red + 200
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
                    else if (category.Name == "ComboBoxCategory")
                    {
                        if(state.Name == "Enabled") this.mCurrentComboBoxCategoryState = ComboBoxCategory.Enabled;
                        if(state.Name == "Disabled") this.mCurrentComboBoxCategoryState = ComboBoxCategory.Disabled;
                        if(state.Name == "Highlighted") this.mCurrentComboBoxCategoryState = ComboBoxCategory.Highlighted;
                        if(state.Name == "Pushed") this.mCurrentComboBoxCategoryState = ComboBoxCategory.Pushed;
                    }
                }
                base.ApplyState(state);
            }
            private bool tryCreateFormsObject;
            public JHP4SD.GumRuntimes.LebegForms.BasicComponents.MyListBoxRuntime ListBoxInstance { get; set; }
            public JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime NineSliceInstance { get; set; }
            public JHP4SD.GumRuntimes.TextRuntime TextInstance { get; set; }
            public JHP4SD.GumRuntimes.SpriteRuntime SpriteInstance { get; set; }
            public JHP4SD.GumRuntimes.TextRuntime PaceholderText { get; set; }
            public event FlatRedBall.Gui.WindowEvent ListBoxInstanceClick;
            public MyComboBoxRuntime (bool fullInstantiation = true, bool tryCreateFormsObject = true) 
            	: base(false, tryCreateFormsObject)
            {
                this.tryCreateFormsObject = tryCreateFormsObject;
                if (fullInstantiation)
                {
                    Gum.DataTypes.ElementSave elementSave = Gum.Managers.ObjectFinder.Self.GumProjectSave.Components.First(item => item.Name == "LebegForms/BasicComponents/MyComboBox");
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
                ListBoxInstance = this.GetGraphicalUiElementByName("ListBoxInstance") as JHP4SD.GumRuntimes.LebegForms.BasicComponents.MyListBoxRuntime;
                NineSliceInstance = this.GetGraphicalUiElementByName("NineSliceInstance") as JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime;
                TextInstance = this.GetGraphicalUiElementByName("TextInstance") as JHP4SD.GumRuntimes.TextRuntime;
                SpriteInstance = this.GetGraphicalUiElementByName("SpriteInstance") as JHP4SD.GumRuntimes.SpriteRuntime;
                PaceholderText = this.GetGraphicalUiElementByName("PaceholderText") as JHP4SD.GumRuntimes.TextRuntime;
                ListBoxInstance.Click += (unused) => ListBoxInstanceClick?.Invoke(this);
                if (tryCreateFormsObject)
                {
                    FormsControlAsObject = new FlatRedBall.Forms.Controls.ComboBox(this);
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
            public FlatRedBall.Forms.Controls.ComboBox FormsControl {get => (FlatRedBall.Forms.Controls.ComboBox) FormsControlAsObject;}
        }
    }
