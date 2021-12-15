    using System.Linq;
    namespace JHP4SD.GumRuntimes
    {
        public partial class MapGumRuntime : Gum.Wireframe.GraphicalUiElement
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
                            MyLandsTextInstance.Parent = this.GetGraphicalUiElementByName("MyLandsLabelBackground");
                            LandsShopTextInstance.Parent = this.GetGraphicalUiElementByName("LandsShopLabelBackground");
                            BuyableLands.ListBoxBackgroundColorCategoryState = JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.TransparentBlack;
                            BuyableLands.CurrentListBoxCategoryState = JHP4SD.GumRuntimes.DefaultForms.ListBoxRuntime.ListBoxCategory.Enabled;
                            MyLandsLabelBackground.CurrentColorCategoryState = JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Black;
                            LandsShopLabelBackground.CurrentColorCategoryState = JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Black;
                            SpriteInstance.Height = 0f;
                            SpriteInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                            SetProperty("SpriteInstance.SourceFile", "../GlobalContent/Screen/Europe-Map-Poster.jpg");
                            SpriteInstance.Width = 0f;
                            SpriteInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                            SpriteInstance.X = 0f;
                            SpriteInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                            SpriteInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            SpriteInstance.Y = 0f;
                            SpriteInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            SpriteInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            OwnedLands.Height = -216f;
                            OwnedLands.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                            OwnedLands.Width = 500f;
                            OwnedLands.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                            OwnedLands.XUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                            OwnedLands.Y = 144f;
                            BuyableLands.ChildrenLayout = Gum.Managers.ChildrenLayout.Regular;
                            BuyableLands.ColoredFrameInstanceAlpha = 128;
                            BuyableLands.Height = -272f;
                            BuyableLands.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                            BuyableLands.InnerPanelInstanceChildren_Layout = Gum.Managers.ChildrenLayout.LeftToRightStack;
                            BuyableLands.InnerPanelInstanceWraps_Children = true;
                            BuyableLands.Width = -760f;
                            BuyableLands.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                            BuyableLands.WrapsChildren = false;
                            BuyableLands.X = -520f;
                            BuyableLands.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                            BuyableLands.XUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                            BuyableLands.Y = 144f;
                            MyLandsLabelBackground.Height = 72f;
                            MyLandsLabelBackground.Width = 500f;
                            MyLandsLabelBackground.X = 0f;
                            MyLandsLabelBackground.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                            MyLandsLabelBackground.XUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                            MyLandsLabelBackground.Y = 72f;
                            LandsShopLabelBackground.Height = 72f;
                            LandsShopLabelBackground.Width = -760f;
                            LandsShopLabelBackground.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                            LandsShopLabelBackground.X = -520f;
                            LandsShopLabelBackground.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                            LandsShopLabelBackground.XUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                            LandsShopLabelBackground.Y = 72f;
                            MyLandsTextInstance.FontSize = 48;
                            MyLandsTextInstance.Height = 0f;
                            MyLandsTextInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                            MyLandsTextInstance.Text = "My Lands";
                            MyLandsTextInstance.Width = 0f;
                            MyLandsTextInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                            MyLandsTextInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                            MyLandsTextInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            MyLandsTextInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            MyLandsTextInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            LandsShopTextInstance.FontSize = 48;
                            LandsShopTextInstance.Height = 0f;
                            LandsShopTextInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                            LandsShopTextInstance.Text = "Lands Shop";
                            LandsShopTextInstance.Width = 0f;
                            LandsShopTextInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                            LandsShopTextInstance.X = 20f;
                            LandsShopTextInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                            LandsShopTextInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                            LandsShopTextInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            LandsShopTextInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
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
                bool setBuyableLandsColoredFrameInstanceAlphaFirstValue = false;
                bool setBuyableLandsColoredFrameInstanceAlphaSecondValue = false;
                int BuyableLandsColoredFrameInstanceAlphaFirstValue= 0;
                int BuyableLandsColoredFrameInstanceAlphaSecondValue= 0;
                bool setBuyableLandsHeightFirstValue = false;
                bool setBuyableLandsHeightSecondValue = false;
                float BuyableLandsHeightFirstValue= 0;
                float BuyableLandsHeightSecondValue= 0;
                bool setBuyableLandsCurrentListBoxCategoryStateFirstValue = false;
                bool setBuyableLandsCurrentListBoxCategoryStateSecondValue = false;
                JHP4SD.GumRuntimes.DefaultForms.ListBoxRuntime.ListBoxCategory BuyableLandsCurrentListBoxCategoryStateFirstValue= JHP4SD.GumRuntimes.DefaultForms.ListBoxRuntime.ListBoxCategory.Enabled;
                JHP4SD.GumRuntimes.DefaultForms.ListBoxRuntime.ListBoxCategory BuyableLandsCurrentListBoxCategoryStateSecondValue= JHP4SD.GumRuntimes.DefaultForms.ListBoxRuntime.ListBoxCategory.Enabled;
                bool setBuyableLandsWidthFirstValue = false;
                bool setBuyableLandsWidthSecondValue = false;
                float BuyableLandsWidthFirstValue= 0;
                float BuyableLandsWidthSecondValue= 0;
                bool setBuyableLandsXFirstValue = false;
                bool setBuyableLandsXSecondValue = false;
                float BuyableLandsXFirstValue= 0;
                float BuyableLandsXSecondValue= 0;
                bool setBuyableLandsYFirstValue = false;
                bool setBuyableLandsYSecondValue = false;
                float BuyableLandsYFirstValue= 0;
                float BuyableLandsYSecondValue= 0;
                bool setLandsShopLabelBackgroundCurrentColorCategoryStateFirstValue = false;
                bool setLandsShopLabelBackgroundCurrentColorCategoryStateSecondValue = false;
                JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory LandsShopLabelBackgroundCurrentColorCategoryStateFirstValue= JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Gray;
                JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory LandsShopLabelBackgroundCurrentColorCategoryStateSecondValue= JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Gray;
                bool setLandsShopLabelBackgroundHeightFirstValue = false;
                bool setLandsShopLabelBackgroundHeightSecondValue = false;
                float LandsShopLabelBackgroundHeightFirstValue= 0;
                float LandsShopLabelBackgroundHeightSecondValue= 0;
                bool setLandsShopLabelBackgroundWidthFirstValue = false;
                bool setLandsShopLabelBackgroundWidthSecondValue = false;
                float LandsShopLabelBackgroundWidthFirstValue= 0;
                float LandsShopLabelBackgroundWidthSecondValue= 0;
                bool setLandsShopLabelBackgroundXFirstValue = false;
                bool setLandsShopLabelBackgroundXSecondValue = false;
                float LandsShopLabelBackgroundXFirstValue= 0;
                float LandsShopLabelBackgroundXSecondValue= 0;
                bool setLandsShopLabelBackgroundYFirstValue = false;
                bool setLandsShopLabelBackgroundYSecondValue = false;
                float LandsShopLabelBackgroundYFirstValue= 0;
                float LandsShopLabelBackgroundYSecondValue= 0;
                bool setLandsShopTextInstanceFontSizeFirstValue = false;
                bool setLandsShopTextInstanceFontSizeSecondValue = false;
                int LandsShopTextInstanceFontSizeFirstValue= 0;
                int LandsShopTextInstanceFontSizeSecondValue= 0;
                bool setLandsShopTextInstanceHeightFirstValue = false;
                bool setLandsShopTextInstanceHeightSecondValue = false;
                float LandsShopTextInstanceHeightFirstValue= 0;
                float LandsShopTextInstanceHeightSecondValue= 0;
                bool setLandsShopTextInstanceWidthFirstValue = false;
                bool setLandsShopTextInstanceWidthSecondValue = false;
                float LandsShopTextInstanceWidthFirstValue= 0;
                float LandsShopTextInstanceWidthSecondValue= 0;
                bool setLandsShopTextInstanceXFirstValue = false;
                bool setLandsShopTextInstanceXSecondValue = false;
                float LandsShopTextInstanceXFirstValue= 0;
                float LandsShopTextInstanceXSecondValue= 0;
                bool setMyLandsLabelBackgroundCurrentColorCategoryStateFirstValue = false;
                bool setMyLandsLabelBackgroundCurrentColorCategoryStateSecondValue = false;
                JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory MyLandsLabelBackgroundCurrentColorCategoryStateFirstValue= JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Gray;
                JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory MyLandsLabelBackgroundCurrentColorCategoryStateSecondValue= JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Gray;
                bool setMyLandsLabelBackgroundHeightFirstValue = false;
                bool setMyLandsLabelBackgroundHeightSecondValue = false;
                float MyLandsLabelBackgroundHeightFirstValue= 0;
                float MyLandsLabelBackgroundHeightSecondValue= 0;
                bool setMyLandsLabelBackgroundWidthFirstValue = false;
                bool setMyLandsLabelBackgroundWidthSecondValue = false;
                float MyLandsLabelBackgroundWidthFirstValue= 0;
                float MyLandsLabelBackgroundWidthSecondValue= 0;
                bool setMyLandsLabelBackgroundXFirstValue = false;
                bool setMyLandsLabelBackgroundXSecondValue = false;
                float MyLandsLabelBackgroundXFirstValue= 0;
                float MyLandsLabelBackgroundXSecondValue= 0;
                bool setMyLandsLabelBackgroundYFirstValue = false;
                bool setMyLandsLabelBackgroundYSecondValue = false;
                float MyLandsLabelBackgroundYFirstValue= 0;
                float MyLandsLabelBackgroundYSecondValue= 0;
                bool setMyLandsTextInstanceFontSizeFirstValue = false;
                bool setMyLandsTextInstanceFontSizeSecondValue = false;
                int MyLandsTextInstanceFontSizeFirstValue= 0;
                int MyLandsTextInstanceFontSizeSecondValue= 0;
                bool setMyLandsTextInstanceHeightFirstValue = false;
                bool setMyLandsTextInstanceHeightSecondValue = false;
                float MyLandsTextInstanceHeightFirstValue= 0;
                float MyLandsTextInstanceHeightSecondValue= 0;
                bool setMyLandsTextInstanceWidthFirstValue = false;
                bool setMyLandsTextInstanceWidthSecondValue = false;
                float MyLandsTextInstanceWidthFirstValue= 0;
                float MyLandsTextInstanceWidthSecondValue= 0;
                bool setOwnedLandsHeightFirstValue = false;
                bool setOwnedLandsHeightSecondValue = false;
                float OwnedLandsHeightFirstValue= 0;
                float OwnedLandsHeightSecondValue= 0;
                bool setOwnedLandsWidthFirstValue = false;
                bool setOwnedLandsWidthSecondValue = false;
                float OwnedLandsWidthFirstValue= 0;
                float OwnedLandsWidthSecondValue= 0;
                bool setOwnedLandsYFirstValue = false;
                bool setOwnedLandsYSecondValue = false;
                float OwnedLandsYFirstValue= 0;
                float OwnedLandsYSecondValue= 0;
                bool setSpriteInstanceHeightFirstValue = false;
                bool setSpriteInstanceHeightSecondValue = false;
                float SpriteInstanceHeightFirstValue= 0;
                float SpriteInstanceHeightSecondValue= 0;
                bool setSpriteInstanceWidthFirstValue = false;
                bool setSpriteInstanceWidthSecondValue = false;
                float SpriteInstanceWidthFirstValue= 0;
                float SpriteInstanceWidthSecondValue= 0;
                bool setSpriteInstanceXFirstValue = false;
                bool setSpriteInstanceXSecondValue = false;
                float SpriteInstanceXFirstValue= 0;
                float SpriteInstanceXSecondValue= 0;
                bool setSpriteInstanceYFirstValue = false;
                bool setSpriteInstanceYSecondValue = false;
                float SpriteInstanceYFirstValue= 0;
                float SpriteInstanceYSecondValue= 0;
                switch(firstState)
                {
                    case  VariableState.Default:
                        if (interpolationValue < 1)
                        {
                            this.BuyableLands.ChildrenLayout = Gum.Managers.ChildrenLayout.Regular;
                        }
                        setBuyableLandsColoredFrameInstanceAlphaFirstValue = true;
                        BuyableLandsColoredFrameInstanceAlphaFirstValue = 128;
                        setBuyableLandsHeightFirstValue = true;
                        BuyableLandsHeightFirstValue = -272f;
                        if (interpolationValue < 1)
                        {
                            this.BuyableLands.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        if (interpolationValue < 1)
                        {
                            this.BuyableLands.InnerPanelInstanceChildren_Layout = Gum.Managers.ChildrenLayout.LeftToRightStack;
                        }
                        if (interpolationValue < 1)
                        {
                            this.BuyableLands.InnerPanelInstanceWraps_Children = true;
                        }
                        if (interpolationValue < 1)
                        {
                            this.BuyableLands.ListBoxBackgroundColorCategoryState = JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.TransparentBlack;
                        }
                        setBuyableLandsCurrentListBoxCategoryStateFirstValue = true;
                        BuyableLandsCurrentListBoxCategoryStateFirstValue = JHP4SD.GumRuntimes.DefaultForms.ListBoxRuntime.ListBoxCategory.Enabled;
                        setBuyableLandsWidthFirstValue = true;
                        BuyableLandsWidthFirstValue = -760f;
                        if (interpolationValue < 1)
                        {
                            this.BuyableLands.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        if (interpolationValue < 1)
                        {
                            this.BuyableLands.WrapsChildren = false;
                        }
                        setBuyableLandsXFirstValue = true;
                        BuyableLandsXFirstValue = -520f;
                        if (interpolationValue < 1)
                        {
                            this.BuyableLands.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                        }
                        if (interpolationValue < 1)
                        {
                            this.BuyableLands.XUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                        }
                        setBuyableLandsYFirstValue = true;
                        BuyableLandsYFirstValue = 144f;
                        setLandsShopLabelBackgroundCurrentColorCategoryStateFirstValue = true;
                        LandsShopLabelBackgroundCurrentColorCategoryStateFirstValue = JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Black;
                        setLandsShopLabelBackgroundHeightFirstValue = true;
                        LandsShopLabelBackgroundHeightFirstValue = 72f;
                        setLandsShopLabelBackgroundWidthFirstValue = true;
                        LandsShopLabelBackgroundWidthFirstValue = -760f;
                        if (interpolationValue < 1)
                        {
                            this.LandsShopLabelBackground.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        setLandsShopLabelBackgroundXFirstValue = true;
                        LandsShopLabelBackgroundXFirstValue = -520f;
                        if (interpolationValue < 1)
                        {
                            this.LandsShopLabelBackground.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                        }
                        if (interpolationValue < 1)
                        {
                            this.LandsShopLabelBackground.XUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                        }
                        setLandsShopLabelBackgroundYFirstValue = true;
                        LandsShopLabelBackgroundYFirstValue = 72f;
                        setLandsShopTextInstanceFontSizeFirstValue = true;
                        LandsShopTextInstanceFontSizeFirstValue = 48;
                        setLandsShopTextInstanceHeightFirstValue = true;
                        LandsShopTextInstanceHeightFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.LandsShopTextInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                        }
                        if (interpolationValue < 1)
                        {
                            this.LandsShopTextInstance.Parent = this.GetGraphicalUiElementByName("LandsShopLabelBackground");
                        }
                        if (interpolationValue < 1)
                        {
                            this.LandsShopTextInstance.Text = "Lands Shop";
                        }
                        setLandsShopTextInstanceWidthFirstValue = true;
                        LandsShopTextInstanceWidthFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.LandsShopTextInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                        }
                        setLandsShopTextInstanceXFirstValue = true;
                        LandsShopTextInstanceXFirstValue = 20f;
                        if (interpolationValue < 1)
                        {
                            this.LandsShopTextInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                        }
                        if (interpolationValue < 1)
                        {
                            this.LandsShopTextInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                        }
                        if (interpolationValue < 1)
                        {
                            this.LandsShopTextInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.LandsShopTextInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setMyLandsLabelBackgroundCurrentColorCategoryStateFirstValue = true;
                        MyLandsLabelBackgroundCurrentColorCategoryStateFirstValue = JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Black;
                        setMyLandsLabelBackgroundHeightFirstValue = true;
                        MyLandsLabelBackgroundHeightFirstValue = 72f;
                        setMyLandsLabelBackgroundWidthFirstValue = true;
                        MyLandsLabelBackgroundWidthFirstValue = 500f;
                        setMyLandsLabelBackgroundXFirstValue = true;
                        MyLandsLabelBackgroundXFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.MyLandsLabelBackground.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                        }
                        if (interpolationValue < 1)
                        {
                            this.MyLandsLabelBackground.XUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                        }
                        setMyLandsLabelBackgroundYFirstValue = true;
                        MyLandsLabelBackgroundYFirstValue = 72f;
                        setMyLandsTextInstanceFontSizeFirstValue = true;
                        MyLandsTextInstanceFontSizeFirstValue = 48;
                        setMyLandsTextInstanceHeightFirstValue = true;
                        MyLandsTextInstanceHeightFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.MyLandsTextInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                        }
                        if (interpolationValue < 1)
                        {
                            this.MyLandsTextInstance.Parent = this.GetGraphicalUiElementByName("MyLandsLabelBackground");
                        }
                        if (interpolationValue < 1)
                        {
                            this.MyLandsTextInstance.Text = "My Lands";
                        }
                        setMyLandsTextInstanceWidthFirstValue = true;
                        MyLandsTextInstanceWidthFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.MyLandsTextInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                        }
                        if (interpolationValue < 1)
                        {
                            this.MyLandsTextInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.MyLandsTextInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        if (interpolationValue < 1)
                        {
                            this.MyLandsTextInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.MyLandsTextInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setOwnedLandsHeightFirstValue = true;
                        OwnedLandsHeightFirstValue = -216f;
                        if (interpolationValue < 1)
                        {
                            this.OwnedLands.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        setOwnedLandsWidthFirstValue = true;
                        OwnedLandsWidthFirstValue = 500f;
                        if (interpolationValue < 1)
                        {
                            this.OwnedLands.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                        }
                        if (interpolationValue < 1)
                        {
                            this.OwnedLands.XUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                        }
                        setOwnedLandsYFirstValue = true;
                        OwnedLandsYFirstValue = 144f;
                        setSpriteInstanceHeightFirstValue = true;
                        SpriteInstanceHeightFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.SpriteInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        if (interpolationValue < 1)
                        {
                            SetProperty("SpriteInstance.SourceFile", "../GlobalContent/Screen/Europe-Map-Poster.jpg");
                        }
                        setSpriteInstanceWidthFirstValue = true;
                        SpriteInstanceWidthFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.SpriteInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        setSpriteInstanceXFirstValue = true;
                        SpriteInstanceXFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.SpriteInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.SpriteInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
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
                        break;
                }
                switch(secondState)
                {
                    case  VariableState.Default:
                        if (interpolationValue >= 1)
                        {
                            this.BuyableLands.ChildrenLayout = Gum.Managers.ChildrenLayout.Regular;
                        }
                        setBuyableLandsColoredFrameInstanceAlphaSecondValue = true;
                        BuyableLandsColoredFrameInstanceAlphaSecondValue = 128;
                        setBuyableLandsHeightSecondValue = true;
                        BuyableLandsHeightSecondValue = -272f;
                        if (interpolationValue >= 1)
                        {
                            this.BuyableLands.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.BuyableLands.InnerPanelInstanceChildren_Layout = Gum.Managers.ChildrenLayout.LeftToRightStack;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.BuyableLands.InnerPanelInstanceWraps_Children = true;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.BuyableLands.ListBoxBackgroundColorCategoryState = JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.TransparentBlack;
                        }
                        setBuyableLandsCurrentListBoxCategoryStateSecondValue = true;
                        BuyableLandsCurrentListBoxCategoryStateSecondValue = JHP4SD.GumRuntimes.DefaultForms.ListBoxRuntime.ListBoxCategory.Enabled;
                        setBuyableLandsWidthSecondValue = true;
                        BuyableLandsWidthSecondValue = -760f;
                        if (interpolationValue >= 1)
                        {
                            this.BuyableLands.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.BuyableLands.WrapsChildren = false;
                        }
                        setBuyableLandsXSecondValue = true;
                        BuyableLandsXSecondValue = -520f;
                        if (interpolationValue >= 1)
                        {
                            this.BuyableLands.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.BuyableLands.XUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                        }
                        setBuyableLandsYSecondValue = true;
                        BuyableLandsYSecondValue = 144f;
                        setLandsShopLabelBackgroundCurrentColorCategoryStateSecondValue = true;
                        LandsShopLabelBackgroundCurrentColorCategoryStateSecondValue = JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Black;
                        setLandsShopLabelBackgroundHeightSecondValue = true;
                        LandsShopLabelBackgroundHeightSecondValue = 72f;
                        setLandsShopLabelBackgroundWidthSecondValue = true;
                        LandsShopLabelBackgroundWidthSecondValue = -760f;
                        if (interpolationValue >= 1)
                        {
                            this.LandsShopLabelBackground.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        setLandsShopLabelBackgroundXSecondValue = true;
                        LandsShopLabelBackgroundXSecondValue = -520f;
                        if (interpolationValue >= 1)
                        {
                            this.LandsShopLabelBackground.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.LandsShopLabelBackground.XUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                        }
                        setLandsShopLabelBackgroundYSecondValue = true;
                        LandsShopLabelBackgroundYSecondValue = 72f;
                        setLandsShopTextInstanceFontSizeSecondValue = true;
                        LandsShopTextInstanceFontSizeSecondValue = 48;
                        setLandsShopTextInstanceHeightSecondValue = true;
                        LandsShopTextInstanceHeightSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.LandsShopTextInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.LandsShopTextInstance.Parent = this.GetGraphicalUiElementByName("LandsShopLabelBackground");
                        }
                        if (interpolationValue >= 1)
                        {
                            this.LandsShopTextInstance.Text = "Lands Shop";
                        }
                        setLandsShopTextInstanceWidthSecondValue = true;
                        LandsShopTextInstanceWidthSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.LandsShopTextInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                        }
                        setLandsShopTextInstanceXSecondValue = true;
                        LandsShopTextInstanceXSecondValue = 20f;
                        if (interpolationValue >= 1)
                        {
                            this.LandsShopTextInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.LandsShopTextInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.LandsShopTextInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.LandsShopTextInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setMyLandsLabelBackgroundCurrentColorCategoryStateSecondValue = true;
                        MyLandsLabelBackgroundCurrentColorCategoryStateSecondValue = JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Black;
                        setMyLandsLabelBackgroundHeightSecondValue = true;
                        MyLandsLabelBackgroundHeightSecondValue = 72f;
                        setMyLandsLabelBackgroundWidthSecondValue = true;
                        MyLandsLabelBackgroundWidthSecondValue = 500f;
                        setMyLandsLabelBackgroundXSecondValue = true;
                        MyLandsLabelBackgroundXSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.MyLandsLabelBackground.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.MyLandsLabelBackground.XUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                        }
                        setMyLandsLabelBackgroundYSecondValue = true;
                        MyLandsLabelBackgroundYSecondValue = 72f;
                        setMyLandsTextInstanceFontSizeSecondValue = true;
                        MyLandsTextInstanceFontSizeSecondValue = 48;
                        setMyLandsTextInstanceHeightSecondValue = true;
                        MyLandsTextInstanceHeightSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.MyLandsTextInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.MyLandsTextInstance.Parent = this.GetGraphicalUiElementByName("MyLandsLabelBackground");
                        }
                        if (interpolationValue >= 1)
                        {
                            this.MyLandsTextInstance.Text = "My Lands";
                        }
                        setMyLandsTextInstanceWidthSecondValue = true;
                        MyLandsTextInstanceWidthSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.MyLandsTextInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.MyLandsTextInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.MyLandsTextInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.MyLandsTextInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.MyLandsTextInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setOwnedLandsHeightSecondValue = true;
                        OwnedLandsHeightSecondValue = -216f;
                        if (interpolationValue >= 1)
                        {
                            this.OwnedLands.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        setOwnedLandsWidthSecondValue = true;
                        OwnedLandsWidthSecondValue = 500f;
                        if (interpolationValue >= 1)
                        {
                            this.OwnedLands.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.OwnedLands.XUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                        }
                        setOwnedLandsYSecondValue = true;
                        OwnedLandsYSecondValue = 144f;
                        setSpriteInstanceHeightSecondValue = true;
                        SpriteInstanceHeightSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.SpriteInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        if (interpolationValue >= 1)
                        {
                            SetProperty("SpriteInstance.SourceFile", "../GlobalContent/Screen/Europe-Map-Poster.jpg");
                        }
                        setSpriteInstanceWidthSecondValue = true;
                        SpriteInstanceWidthSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.SpriteInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        setSpriteInstanceXSecondValue = true;
                        SpriteInstanceXSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.SpriteInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.SpriteInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
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
                        break;
                }
                var wasSuppressed = mIsLayoutSuspended;
                if (wasSuppressed == false)
                {
                    SuspendLayout(true);
                }
                if (setBuyableLandsColoredFrameInstanceAlphaFirstValue && setBuyableLandsColoredFrameInstanceAlphaSecondValue)
                {
                    BuyableLands.ColoredFrameInstanceAlpha = FlatRedBall.Math.MathFunctions.RoundToInt(BuyableLandsColoredFrameInstanceAlphaFirstValue* (1 - interpolationValue) + BuyableLandsColoredFrameInstanceAlphaSecondValue * interpolationValue);
                }
                if (setBuyableLandsHeightFirstValue && setBuyableLandsHeightSecondValue)
                {
                    BuyableLands.Height = BuyableLandsHeightFirstValue * (1 - interpolationValue) + BuyableLandsHeightSecondValue * interpolationValue;
                }
                if (setBuyableLandsCurrentListBoxCategoryStateFirstValue && setBuyableLandsCurrentListBoxCategoryStateSecondValue)
                {
                    BuyableLands.InterpolateBetween(BuyableLandsCurrentListBoxCategoryStateFirstValue, BuyableLandsCurrentListBoxCategoryStateSecondValue, interpolationValue);
                }
                if (setBuyableLandsWidthFirstValue && setBuyableLandsWidthSecondValue)
                {
                    BuyableLands.Width = BuyableLandsWidthFirstValue * (1 - interpolationValue) + BuyableLandsWidthSecondValue * interpolationValue;
                }
                if (setBuyableLandsXFirstValue && setBuyableLandsXSecondValue)
                {
                    BuyableLands.X = BuyableLandsXFirstValue * (1 - interpolationValue) + BuyableLandsXSecondValue * interpolationValue;
                }
                if (setBuyableLandsYFirstValue && setBuyableLandsYSecondValue)
                {
                    BuyableLands.Y = BuyableLandsYFirstValue * (1 - interpolationValue) + BuyableLandsYSecondValue * interpolationValue;
                }
                if (setLandsShopLabelBackgroundCurrentColorCategoryStateFirstValue && setLandsShopLabelBackgroundCurrentColorCategoryStateSecondValue)
                {
                    LandsShopLabelBackground.InterpolateBetween(LandsShopLabelBackgroundCurrentColorCategoryStateFirstValue, LandsShopLabelBackgroundCurrentColorCategoryStateSecondValue, interpolationValue);
                }
                if (setLandsShopLabelBackgroundHeightFirstValue && setLandsShopLabelBackgroundHeightSecondValue)
                {
                    LandsShopLabelBackground.Height = LandsShopLabelBackgroundHeightFirstValue * (1 - interpolationValue) + LandsShopLabelBackgroundHeightSecondValue * interpolationValue;
                }
                if (setLandsShopLabelBackgroundWidthFirstValue && setLandsShopLabelBackgroundWidthSecondValue)
                {
                    LandsShopLabelBackground.Width = LandsShopLabelBackgroundWidthFirstValue * (1 - interpolationValue) + LandsShopLabelBackgroundWidthSecondValue * interpolationValue;
                }
                if (setLandsShopLabelBackgroundXFirstValue && setLandsShopLabelBackgroundXSecondValue)
                {
                    LandsShopLabelBackground.X = LandsShopLabelBackgroundXFirstValue * (1 - interpolationValue) + LandsShopLabelBackgroundXSecondValue * interpolationValue;
                }
                if (setLandsShopLabelBackgroundYFirstValue && setLandsShopLabelBackgroundYSecondValue)
                {
                    LandsShopLabelBackground.Y = LandsShopLabelBackgroundYFirstValue * (1 - interpolationValue) + LandsShopLabelBackgroundYSecondValue * interpolationValue;
                }
                if (setLandsShopTextInstanceFontSizeFirstValue && setLandsShopTextInstanceFontSizeSecondValue)
                {
                    LandsShopTextInstance.FontSize = FlatRedBall.Math.MathFunctions.RoundToInt(LandsShopTextInstanceFontSizeFirstValue* (1 - interpolationValue) + LandsShopTextInstanceFontSizeSecondValue * interpolationValue);
                }
                if (setLandsShopTextInstanceHeightFirstValue && setLandsShopTextInstanceHeightSecondValue)
                {
                    LandsShopTextInstance.Height = LandsShopTextInstanceHeightFirstValue * (1 - interpolationValue) + LandsShopTextInstanceHeightSecondValue * interpolationValue;
                }
                if (setLandsShopTextInstanceWidthFirstValue && setLandsShopTextInstanceWidthSecondValue)
                {
                    LandsShopTextInstance.Width = LandsShopTextInstanceWidthFirstValue * (1 - interpolationValue) + LandsShopTextInstanceWidthSecondValue * interpolationValue;
                }
                if (setLandsShopTextInstanceXFirstValue && setLandsShopTextInstanceXSecondValue)
                {
                    LandsShopTextInstance.X = LandsShopTextInstanceXFirstValue * (1 - interpolationValue) + LandsShopTextInstanceXSecondValue * interpolationValue;
                }
                if (setMyLandsLabelBackgroundCurrentColorCategoryStateFirstValue && setMyLandsLabelBackgroundCurrentColorCategoryStateSecondValue)
                {
                    MyLandsLabelBackground.InterpolateBetween(MyLandsLabelBackgroundCurrentColorCategoryStateFirstValue, MyLandsLabelBackgroundCurrentColorCategoryStateSecondValue, interpolationValue);
                }
                if (setMyLandsLabelBackgroundHeightFirstValue && setMyLandsLabelBackgroundHeightSecondValue)
                {
                    MyLandsLabelBackground.Height = MyLandsLabelBackgroundHeightFirstValue * (1 - interpolationValue) + MyLandsLabelBackgroundHeightSecondValue * interpolationValue;
                }
                if (setMyLandsLabelBackgroundWidthFirstValue && setMyLandsLabelBackgroundWidthSecondValue)
                {
                    MyLandsLabelBackground.Width = MyLandsLabelBackgroundWidthFirstValue * (1 - interpolationValue) + MyLandsLabelBackgroundWidthSecondValue * interpolationValue;
                }
                if (setMyLandsLabelBackgroundXFirstValue && setMyLandsLabelBackgroundXSecondValue)
                {
                    MyLandsLabelBackground.X = MyLandsLabelBackgroundXFirstValue * (1 - interpolationValue) + MyLandsLabelBackgroundXSecondValue * interpolationValue;
                }
                if (setMyLandsLabelBackgroundYFirstValue && setMyLandsLabelBackgroundYSecondValue)
                {
                    MyLandsLabelBackground.Y = MyLandsLabelBackgroundYFirstValue * (1 - interpolationValue) + MyLandsLabelBackgroundYSecondValue * interpolationValue;
                }
                if (setMyLandsTextInstanceFontSizeFirstValue && setMyLandsTextInstanceFontSizeSecondValue)
                {
                    MyLandsTextInstance.FontSize = FlatRedBall.Math.MathFunctions.RoundToInt(MyLandsTextInstanceFontSizeFirstValue* (1 - interpolationValue) + MyLandsTextInstanceFontSizeSecondValue * interpolationValue);
                }
                if (setMyLandsTextInstanceHeightFirstValue && setMyLandsTextInstanceHeightSecondValue)
                {
                    MyLandsTextInstance.Height = MyLandsTextInstanceHeightFirstValue * (1 - interpolationValue) + MyLandsTextInstanceHeightSecondValue * interpolationValue;
                }
                if (setMyLandsTextInstanceWidthFirstValue && setMyLandsTextInstanceWidthSecondValue)
                {
                    MyLandsTextInstance.Width = MyLandsTextInstanceWidthFirstValue * (1 - interpolationValue) + MyLandsTextInstanceWidthSecondValue * interpolationValue;
                }
                if (setOwnedLandsHeightFirstValue && setOwnedLandsHeightSecondValue)
                {
                    OwnedLands.Height = OwnedLandsHeightFirstValue * (1 - interpolationValue) + OwnedLandsHeightSecondValue * interpolationValue;
                }
                if (setOwnedLandsWidthFirstValue && setOwnedLandsWidthSecondValue)
                {
                    OwnedLands.Width = OwnedLandsWidthFirstValue * (1 - interpolationValue) + OwnedLandsWidthSecondValue * interpolationValue;
                }
                if (setOwnedLandsYFirstValue && setOwnedLandsYSecondValue)
                {
                    OwnedLands.Y = OwnedLandsYFirstValue * (1 - interpolationValue) + OwnedLandsYSecondValue * interpolationValue;
                }
                if (setSpriteInstanceHeightFirstValue && setSpriteInstanceHeightSecondValue)
                {
                    SpriteInstance.Height = SpriteInstanceHeightFirstValue * (1 - interpolationValue) + SpriteInstanceHeightSecondValue * interpolationValue;
                }
                if (setSpriteInstanceWidthFirstValue && setSpriteInstanceWidthSecondValue)
                {
                    SpriteInstance.Width = SpriteInstanceWidthFirstValue * (1 - interpolationValue) + SpriteInstanceWidthSecondValue * interpolationValue;
                }
                if (setSpriteInstanceXFirstValue && setSpriteInstanceXSecondValue)
                {
                    SpriteInstance.X = SpriteInstanceXFirstValue * (1 - interpolationValue) + SpriteInstanceXSecondValue * interpolationValue;
                }
                if (setSpriteInstanceYFirstValue && setSpriteInstanceYSecondValue)
                {
                    SpriteInstance.Y = SpriteInstanceYFirstValue * (1 - interpolationValue) + SpriteInstanceYSecondValue * interpolationValue;
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
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (JHP4SD.GumRuntimes.MapGumRuntime.VariableState fromState,JHP4SD.GumRuntimes.MapGumRuntime.VariableState toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null) 
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
                OwnedLands.StopAnimations();
                BuyableLands.StopAnimations();
                MyLandsLabelBackground.StopAnimations();
                LandsShopLabelBackground.StopAnimations();
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
                            Name = "SpriteInstance.Height",
                            Type = "float",
                            Value = SpriteInstance.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Height Units",
                            Type = "DimensionUnitType",
                            Value = SpriteInstance.HeightUnits
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
                            Name = "SpriteInstance.Width",
                            Type = "float",
                            Value = SpriteInstance.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Width Units",
                            Type = "DimensionUnitType",
                            Value = SpriteInstance.WidthUnits
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
                            Name = "OwnedLands.Height",
                            Type = "float",
                            Value = OwnedLands.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "OwnedLands.Height Units",
                            Type = "DimensionUnitType",
                            Value = OwnedLands.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "OwnedLands.Width",
                            Type = "float",
                            Value = OwnedLands.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "OwnedLands.X Origin",
                            Type = "HorizontalAlignment",
                            Value = OwnedLands.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "OwnedLands.X Units",
                            Type = "PositionUnitType",
                            Value = OwnedLands.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "OwnedLands.Y",
                            Type = "float",
                            Value = OwnedLands.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuyableLands.Children Layout",
                            Type = "ChildrenLayout",
                            Value = BuyableLands.ChildrenLayout
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuyableLands.ColoredFrameInstanceAlpha",
                            Type = "int",
                            Value = BuyableLands.ColoredFrameInstanceAlpha
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuyableLands.Height",
                            Type = "float",
                            Value = BuyableLands.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuyableLands.Height Units",
                            Type = "DimensionUnitType",
                            Value = BuyableLands.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuyableLands.InnerPanelInstanceChildren Layout",
                            Type = "ChildrenLayout",
                            Value = BuyableLands.InnerPanelInstanceChildren_Layout
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuyableLands.InnerPanelInstanceWraps Children",
                            Type = "bool",
                            Value = BuyableLands.InnerPanelInstanceWraps_Children
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuyableLands.ListBoxBackgroundColorCategoryState",
                            Type = "ColorCategoryState",
                            Value = BuyableLands.ListBoxBackgroundColorCategoryState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuyableLands.ListBoxCategoryState",
                            Type = "ListBoxCategory",
                            Value = BuyableLands.CurrentListBoxCategoryState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuyableLands.Width",
                            Type = "float",
                            Value = BuyableLands.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuyableLands.Width Units",
                            Type = "DimensionUnitType",
                            Value = BuyableLands.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuyableLands.Wraps Children",
                            Type = "bool",
                            Value = BuyableLands.WrapsChildren
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuyableLands.X",
                            Type = "float",
                            Value = BuyableLands.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuyableLands.X Origin",
                            Type = "HorizontalAlignment",
                            Value = BuyableLands.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuyableLands.X Units",
                            Type = "PositionUnitType",
                            Value = BuyableLands.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuyableLands.Y",
                            Type = "float",
                            Value = BuyableLands.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MyLandsLabelBackground.ColorCategoryState",
                            Type = "ColorCategoryState",
                            Value = MyLandsLabelBackground.CurrentColorCategoryState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MyLandsLabelBackground.Height",
                            Type = "float",
                            Value = MyLandsLabelBackground.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MyLandsLabelBackground.Width",
                            Type = "float",
                            Value = MyLandsLabelBackground.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MyLandsLabelBackground.X",
                            Type = "float",
                            Value = MyLandsLabelBackground.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MyLandsLabelBackground.X Origin",
                            Type = "HorizontalAlignment",
                            Value = MyLandsLabelBackground.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MyLandsLabelBackground.X Units",
                            Type = "PositionUnitType",
                            Value = MyLandsLabelBackground.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MyLandsLabelBackground.Y",
                            Type = "float",
                            Value = MyLandsLabelBackground.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LandsShopLabelBackground.ColorCategoryState",
                            Type = "ColorCategoryState",
                            Value = LandsShopLabelBackground.CurrentColorCategoryState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LandsShopLabelBackground.Height",
                            Type = "float",
                            Value = LandsShopLabelBackground.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LandsShopLabelBackground.Width",
                            Type = "float",
                            Value = LandsShopLabelBackground.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LandsShopLabelBackground.Width Units",
                            Type = "DimensionUnitType",
                            Value = LandsShopLabelBackground.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LandsShopLabelBackground.X",
                            Type = "float",
                            Value = LandsShopLabelBackground.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LandsShopLabelBackground.X Origin",
                            Type = "HorizontalAlignment",
                            Value = LandsShopLabelBackground.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LandsShopLabelBackground.X Units",
                            Type = "PositionUnitType",
                            Value = LandsShopLabelBackground.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LandsShopLabelBackground.Y",
                            Type = "float",
                            Value = LandsShopLabelBackground.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MyLandsTextInstance.FontSize",
                            Type = "int",
                            Value = MyLandsTextInstance.FontSize
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MyLandsTextInstance.Height",
                            Type = "float",
                            Value = MyLandsTextInstance.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MyLandsTextInstance.Height Units",
                            Type = "DimensionUnitType",
                            Value = MyLandsTextInstance.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MyLandsTextInstance.Parent",
                            Type = "string",
                            Value = MyLandsTextInstance.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MyLandsTextInstance.Text",
                            Type = "string",
                            Value = MyLandsTextInstance.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MyLandsTextInstance.Width",
                            Type = "float",
                            Value = MyLandsTextInstance.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MyLandsTextInstance.Width Units",
                            Type = "DimensionUnitType",
                            Value = MyLandsTextInstance.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MyLandsTextInstance.X Origin",
                            Type = "HorizontalAlignment",
                            Value = MyLandsTextInstance.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MyLandsTextInstance.X Units",
                            Type = "PositionUnitType",
                            Value = MyLandsTextInstance.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MyLandsTextInstance.Y Origin",
                            Type = "VerticalAlignment",
                            Value = MyLandsTextInstance.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MyLandsTextInstance.Y Units",
                            Type = "PositionUnitType",
                            Value = MyLandsTextInstance.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LandsShopTextInstance.FontSize",
                            Type = "int",
                            Value = LandsShopTextInstance.FontSize
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LandsShopTextInstance.Height",
                            Type = "float",
                            Value = LandsShopTextInstance.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LandsShopTextInstance.Height Units",
                            Type = "DimensionUnitType",
                            Value = LandsShopTextInstance.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LandsShopTextInstance.Parent",
                            Type = "string",
                            Value = LandsShopTextInstance.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LandsShopTextInstance.Text",
                            Type = "string",
                            Value = LandsShopTextInstance.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LandsShopTextInstance.Width",
                            Type = "float",
                            Value = LandsShopTextInstance.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LandsShopTextInstance.Width Units",
                            Type = "DimensionUnitType",
                            Value = LandsShopTextInstance.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LandsShopTextInstance.X",
                            Type = "float",
                            Value = LandsShopTextInstance.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LandsShopTextInstance.X Origin",
                            Type = "HorizontalAlignment",
                            Value = LandsShopTextInstance.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LandsShopTextInstance.X Units",
                            Type = "PositionUnitType",
                            Value = LandsShopTextInstance.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LandsShopTextInstance.Y Origin",
                            Type = "VerticalAlignment",
                            Value = LandsShopTextInstance.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LandsShopTextInstance.Y Units",
                            Type = "PositionUnitType",
                            Value = LandsShopTextInstance.YUnits
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
                            Name = "SpriteInstance.Height",
                            Type = "float",
                            Value = SpriteInstance.Height + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Height Units",
                            Type = "DimensionUnitType",
                            Value = SpriteInstance.HeightUnits
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
                            Name = "SpriteInstance.Width",
                            Type = "float",
                            Value = SpriteInstance.Width + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Width Units",
                            Type = "DimensionUnitType",
                            Value = SpriteInstance.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.X",
                            Type = "float",
                            Value = SpriteInstance.X + 0f
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
                            Name = "OwnedLands.Height",
                            Type = "float",
                            Value = OwnedLands.Height + -216f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "OwnedLands.Height Units",
                            Type = "DimensionUnitType",
                            Value = OwnedLands.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "OwnedLands.Width",
                            Type = "float",
                            Value = OwnedLands.Width + 500f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "OwnedLands.X Origin",
                            Type = "HorizontalAlignment",
                            Value = OwnedLands.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "OwnedLands.X Units",
                            Type = "PositionUnitType",
                            Value = OwnedLands.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "OwnedLands.Y",
                            Type = "float",
                            Value = OwnedLands.Y + 144f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuyableLands.Children Layout",
                            Type = "ChildrenLayout",
                            Value = BuyableLands.ChildrenLayout
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuyableLands.ColoredFrameInstanceAlpha",
                            Type = "int",
                            Value = BuyableLands.ColoredFrameInstanceAlpha + 128
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuyableLands.Height",
                            Type = "float",
                            Value = BuyableLands.Height + -272f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuyableLands.Height Units",
                            Type = "DimensionUnitType",
                            Value = BuyableLands.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuyableLands.InnerPanelInstanceChildren Layout",
                            Type = "ChildrenLayout",
                            Value = BuyableLands.InnerPanelInstanceChildren_Layout
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuyableLands.InnerPanelInstanceWraps Children",
                            Type = "bool",
                            Value = BuyableLands.InnerPanelInstanceWraps_Children
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuyableLands.ListBoxBackgroundColorCategoryState",
                            Type = "ColorCategoryState",
                            Value = BuyableLands.ListBoxBackgroundColorCategoryState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuyableLands.ListBoxCategoryState",
                            Type = "ListBoxCategory",
                            Value = BuyableLands.CurrentListBoxCategoryState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuyableLands.Width",
                            Type = "float",
                            Value = BuyableLands.Width + -760f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuyableLands.Width Units",
                            Type = "DimensionUnitType",
                            Value = BuyableLands.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuyableLands.Wraps Children",
                            Type = "bool",
                            Value = BuyableLands.WrapsChildren
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuyableLands.X",
                            Type = "float",
                            Value = BuyableLands.X + -520f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuyableLands.X Origin",
                            Type = "HorizontalAlignment",
                            Value = BuyableLands.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuyableLands.X Units",
                            Type = "PositionUnitType",
                            Value = BuyableLands.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuyableLands.Y",
                            Type = "float",
                            Value = BuyableLands.Y + 144f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MyLandsLabelBackground.ColorCategoryState",
                            Type = "ColorCategoryState",
                            Value = MyLandsLabelBackground.CurrentColorCategoryState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MyLandsLabelBackground.Height",
                            Type = "float",
                            Value = MyLandsLabelBackground.Height + 72f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MyLandsLabelBackground.Width",
                            Type = "float",
                            Value = MyLandsLabelBackground.Width + 500f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MyLandsLabelBackground.X",
                            Type = "float",
                            Value = MyLandsLabelBackground.X + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MyLandsLabelBackground.X Origin",
                            Type = "HorizontalAlignment",
                            Value = MyLandsLabelBackground.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MyLandsLabelBackground.X Units",
                            Type = "PositionUnitType",
                            Value = MyLandsLabelBackground.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MyLandsLabelBackground.Y",
                            Type = "float",
                            Value = MyLandsLabelBackground.Y + 72f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LandsShopLabelBackground.ColorCategoryState",
                            Type = "ColorCategoryState",
                            Value = LandsShopLabelBackground.CurrentColorCategoryState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LandsShopLabelBackground.Height",
                            Type = "float",
                            Value = LandsShopLabelBackground.Height + 72f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LandsShopLabelBackground.Width",
                            Type = "float",
                            Value = LandsShopLabelBackground.Width + -760f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LandsShopLabelBackground.Width Units",
                            Type = "DimensionUnitType",
                            Value = LandsShopLabelBackground.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LandsShopLabelBackground.X",
                            Type = "float",
                            Value = LandsShopLabelBackground.X + -520f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LandsShopLabelBackground.X Origin",
                            Type = "HorizontalAlignment",
                            Value = LandsShopLabelBackground.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LandsShopLabelBackground.X Units",
                            Type = "PositionUnitType",
                            Value = LandsShopLabelBackground.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LandsShopLabelBackground.Y",
                            Type = "float",
                            Value = LandsShopLabelBackground.Y + 72f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MyLandsTextInstance.FontSize",
                            Type = "int",
                            Value = MyLandsTextInstance.FontSize + 48
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MyLandsTextInstance.Height",
                            Type = "float",
                            Value = MyLandsTextInstance.Height + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MyLandsTextInstance.Height Units",
                            Type = "DimensionUnitType",
                            Value = MyLandsTextInstance.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MyLandsTextInstance.Parent",
                            Type = "string",
                            Value = MyLandsTextInstance.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MyLandsTextInstance.Text",
                            Type = "string",
                            Value = MyLandsTextInstance.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MyLandsTextInstance.Width",
                            Type = "float",
                            Value = MyLandsTextInstance.Width + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MyLandsTextInstance.Width Units",
                            Type = "DimensionUnitType",
                            Value = MyLandsTextInstance.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MyLandsTextInstance.X Origin",
                            Type = "HorizontalAlignment",
                            Value = MyLandsTextInstance.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MyLandsTextInstance.X Units",
                            Type = "PositionUnitType",
                            Value = MyLandsTextInstance.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MyLandsTextInstance.Y Origin",
                            Type = "VerticalAlignment",
                            Value = MyLandsTextInstance.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MyLandsTextInstance.Y Units",
                            Type = "PositionUnitType",
                            Value = MyLandsTextInstance.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LandsShopTextInstance.FontSize",
                            Type = "int",
                            Value = LandsShopTextInstance.FontSize + 48
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LandsShopTextInstance.Height",
                            Type = "float",
                            Value = LandsShopTextInstance.Height + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LandsShopTextInstance.Height Units",
                            Type = "DimensionUnitType",
                            Value = LandsShopTextInstance.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LandsShopTextInstance.Parent",
                            Type = "string",
                            Value = LandsShopTextInstance.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LandsShopTextInstance.Text",
                            Type = "string",
                            Value = LandsShopTextInstance.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LandsShopTextInstance.Width",
                            Type = "float",
                            Value = LandsShopTextInstance.Width + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LandsShopTextInstance.Width Units",
                            Type = "DimensionUnitType",
                            Value = LandsShopTextInstance.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LandsShopTextInstance.X",
                            Type = "float",
                            Value = LandsShopTextInstance.X + 20f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LandsShopTextInstance.X Origin",
                            Type = "HorizontalAlignment",
                            Value = LandsShopTextInstance.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LandsShopTextInstance.X Units",
                            Type = "PositionUnitType",
                            Value = LandsShopTextInstance.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LandsShopTextInstance.Y Origin",
                            Type = "VerticalAlignment",
                            Value = LandsShopTextInstance.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LandsShopTextInstance.Y Units",
                            Type = "PositionUnitType",
                            Value = LandsShopTextInstance.YUnits
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
            public JHP4SD.GumRuntimes.SpriteRuntime SpriteInstance { get; set; }
            public JHP4SD.GumRuntimes.DefaultForms.ListBoxRuntime OwnedLands { get; set; }
            public JHP4SD.GumRuntimes.DefaultForms.ListBoxRuntime BuyableLands { get; set; }
            public JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime MyLandsLabelBackground { get; set; }
            public JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime LandsShopLabelBackground { get; set; }
            public JHP4SD.GumRuntimes.TextRuntime MyLandsTextInstance { get; set; }
            public JHP4SD.GumRuntimes.TextRuntime LandsShopTextInstance { get; set; }
            public MapGumRuntime (bool fullInstantiation = true, bool tryCreateFormsObject = true) 
            {
                this.tryCreateFormsObject = tryCreateFormsObject;
                if (fullInstantiation)
                {
                    Gum.DataTypes.ElementSave elementSave = Gum.Managers.ObjectFinder.Self.GumProjectSave.Screens.First(item => item.Name == "MapGum");
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
                SpriteInstance = this.GetGraphicalUiElementByName("SpriteInstance") as JHP4SD.GumRuntimes.SpriteRuntime;
                OwnedLands = this.GetGraphicalUiElementByName("OwnedLands") as JHP4SD.GumRuntimes.DefaultForms.ListBoxRuntime;
                BuyableLands = this.GetGraphicalUiElementByName("BuyableLands") as JHP4SD.GumRuntimes.DefaultForms.ListBoxRuntime;
                MyLandsLabelBackground = this.GetGraphicalUiElementByName("MyLandsLabelBackground") as JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime;
                LandsShopLabelBackground = this.GetGraphicalUiElementByName("LandsShopLabelBackground") as JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime;
                MyLandsTextInstance = this.GetGraphicalUiElementByName("MyLandsTextInstance") as JHP4SD.GumRuntimes.TextRuntime;
                LandsShopTextInstance = this.GetGraphicalUiElementByName("LandsShopTextInstance") as JHP4SD.GumRuntimes.TextRuntime;
                if (tryCreateFormsObject)
                {
                    FormsControlAsObject = new JHP4SD.FormsControls.Screens.MapGumForms(this);
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
            public JHP4SD.FormsControls.Screens.MapGumForms FormsControl {get => (JHP4SD.FormsControls.Screens.MapGumForms) FormsControlAsObject;}
        }
    }
