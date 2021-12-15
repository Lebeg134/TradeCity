    using System.Linq;
    namespace JHP4SD.GumRuntimes
    {
        public partial class MarketGumRuntime : Gum.Wireframe.GraphicalUiElement
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
                            MyListingsTextInstance.Parent = this.GetGraphicalUiElementByName("MyListingsLabelBackground");
                            NewLsitingUIContainer.Parent = this.GetGraphicalUiElementByName("NewListingBackground");
                            TextInstance.Parent = this.GetGraphicalUiElementByName("NewLsitingUIContainer");
                            ComboBoxInstance.Parent = this.GetGraphicalUiElementByName("NewLsitingUIContainer");
                            ToSellAmountTextBoxInstance.Parent = this.GetGraphicalUiElementByName("AmountContainerInstance");
                            AmountContainerInstance.Parent = this.GetGraphicalUiElementByName("NewLsitingUIContainer");
                            vauleContainerInstance.Parent = this.GetGraphicalUiElementByName("NewLsitingUIContainer");
                            AmountText.Parent = this.GetGraphicalUiElementByName("AmountContainerInstance");
                            ValueText.Parent = this.GetGraphicalUiElementByName("vauleContainerInstance");
                            ResourceDisplayInstance.Parent = this.GetGraphicalUiElementByName("vauleContainerInstance");
                            ContainerInstance.Parent = this.GetGraphicalUiElementByName("NewLsitingUIContainer");
                            SellOneButtonInstance.Parent = this.GetGraphicalUiElementByName("ContainerInstance");
                            SellAllButtonInstance.Parent = this.GetGraphicalUiElementByName("ContainerInstance");
                            Listing.Parent = this.GetGraphicalUiElementByName("NewLsitingUIContainer");
                            AutoAmountContainerInstance.Parent = this.GetGraphicalUiElementByName("NewLsitingUIContainer");
                            AmountText1.Parent = this.GetGraphicalUiElementByName("AutoAmountContainerInstance");
                            AutoSellAmountTextBoxInstance.Parent = this.GetGraphicalUiElementByName("AutoAmountContainerInstance");
                            AutoSellButtonInstance.Parent = this.GetGraphicalUiElementByName("NewLsitingUIContainer");
                            MyListingsLabelBackground.CurrentColorCategoryState = JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Black;
                            MyListingsList.ListBoxBackgroundColorCategoryState = JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Gray;
                            NewListingBackground.CurrentColorCategoryState = JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Gray;
                            SpriteInstance.Height = 0f;
                            SpriteInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                            SetProperty("SpriteInstance.SourceFile", "../GlobalContent/Screen/stockmarket.jpg");
                            SpriteInstance.Width = 0f;
                            SpriteInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                            SpriteInstance.X = 0f;
                            SpriteInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                            SpriteInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            SpriteInstance.Y = 0f;
                            SpriteInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            SpriteInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            MyListingsLabelBackground.Height = 72f;
                            MyListingsLabelBackground.Width = 750f;
                            MyListingsLabelBackground.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                            MyListingsLabelBackground.X = 0f;
                            MyListingsLabelBackground.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                            MyListingsLabelBackground.XUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                            MyListingsLabelBackground.Y = 72f;
                            MyListingsTextInstance.FontSize = 48;
                            MyListingsTextInstance.Height = 0f;
                            MyListingsTextInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                            MyListingsTextInstance.Text = "MyListings";
                            MyListingsTextInstance.Width = 0f;
                            MyListingsTextInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                            MyListingsTextInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                            MyListingsTextInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            MyListingsTextInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            MyListingsTextInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            MyListingsList.ColoredFrameInstanceAlpha = 255;
                            MyListingsList.Height = -216f;
                            MyListingsList.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                            MyListingsList.Width = 750f;
                            MyListingsList.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                            MyListingsList.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                            MyListingsList.XUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                            MyListingsList.Y = 144f;
                            NewListingBackground.Alpha = 128;
                            NewListingBackground.Height = -272f;
                            NewListingBackground.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                            NewListingBackground.Width = 400f;
                            NewListingBackground.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                            NewListingBackground.X = -760f;
                            NewListingBackground.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                            NewListingBackground.XUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                            NewListingBackground.Y = 72f;
                            NewLsitingUIContainer.ChildrenLayout = Gum.Managers.ChildrenLayout.TopToBottomStack;
                            NewLsitingUIContainer.Height = -40f;
                            NewLsitingUIContainer.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                            NewLsitingUIContainer.Width = -40f;
                            NewLsitingUIContainer.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                            NewLsitingUIContainer.X = 0f;
                            NewLsitingUIContainer.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                            NewLsitingUIContainer.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            NewLsitingUIContainer.Y = 0f;
                            NewLsitingUIContainer.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            NewLsitingUIContainer.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            TextInstance.Blue = 0;
                            TextInstance.FontSize = 24;
                            TextInstance.Green = 0;
                            TextInstance.Height = 10f;
                            TextInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                            TextInstance.Red = 0;
                            TextInstance.Text = "To sell:";
                            TextInstance.Width = 0f;
                            TextInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                            TextInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                            TextInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                            ComboBoxInstance.Width = 100f;
                            ComboBoxInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            ToSellAmountTextBoxInstance.Text = "Amount";
                            ToSellAmountTextBoxInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                            ToSellAmountTextBoxInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                            AmountContainerInstance.Height = 0f;
                            AmountContainerInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                            AmountContainerInstance.Width = 100f;
                            AmountContainerInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            vauleContainerInstance.Height = 0f;
                            vauleContainerInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                            vauleContainerInstance.Width = 100f;
                            vauleContainerInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            AmountText.Blue = 0;
                            AmountText.Green = 0;
                            AmountText.Height = 30f;
                            AmountText.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                            AmountText.Red = 0;
                            AmountText.Text = "Amount:";
                            AmountText.VerticalAlignment = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            ValueText.Blue = 0;
                            ValueText.Green = 0;
                            ValueText.Height = 40f;
                            ValueText.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                            ValueText.Red = 0;
                            ValueText.Text = "Value:";
                            ValueText.VerticalAlignment = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            SetProperty("ResourceDisplayInstance.SpriteInstanceSourceFile", "../GlobalContent/Resources/ResourceIcons/money-stack.png");
                            ResourceDisplayInstance.Width = 220f;
                            ResourceDisplayInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                            ResourceDisplayInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                            ContainerInstance.Height = 0f;
                            ContainerInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                            ContainerInstance.Width = 100f;
                            ContainerInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            ContainerInstance.X = 0f;
                            ContainerInstance.Y = 10f;
                            SellOneButtonInstance.Text = "Sell one";
                            SellOneButtonInstance.Width = 50f;
                            SellOneButtonInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            SellOneButtonInstance.X = 0f;
                            SellOneButtonInstance.Y = 0f;
                            SellAllButtonInstance.Text = "Sell All";
                            SellAllButtonInstance.Width = 50f;
                            SellAllButtonInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            SellAllButtonInstance.X = 0f;
                            SellAllButtonInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                            SellAllButtonInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                            SellAllButtonInstance.Y = 0f;
                            Listing.Blue = 0;
                            Listing.FontSize = 24;
                            Listing.Green = 0;
                            Listing.Height = 10f;
                            Listing.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                            Listing.Red = 0;
                            Listing.Text = "Auto sell above:";
                            Listing.Width = 0f;
                            Listing.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                            Listing.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                            Listing.XUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                            AutoAmountContainerInstance.Height = 0f;
                            AutoAmountContainerInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                            AutoAmountContainerInstance.Width = 100f;
                            AutoAmountContainerInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            AmountText1.Blue = 0;
                            AmountText1.Green = 0;
                            AmountText1.Height = 30f;
                            AmountText1.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                            AmountText1.Red = 0;
                            AmountText1.Text = "Amount:";
                            AmountText1.VerticalAlignment = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            AutoSellAmountTextBoxInstance.Text = "Amount";
                            AutoSellAmountTextBoxInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                            AutoSellAmountTextBoxInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                            AutoSellButtonInstance.Text = "Create Listing";
                            AutoSellButtonInstance.Width = 100f;
                            AutoSellButtonInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            AutoSellButtonInstance.X = 0f;
                            AutoSellButtonInstance.Y = 0f;
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
                bool setAmountContainerInstanceHeightFirstValue = false;
                bool setAmountContainerInstanceHeightSecondValue = false;
                float AmountContainerInstanceHeightFirstValue= 0;
                float AmountContainerInstanceHeightSecondValue= 0;
                bool setAmountContainerInstanceWidthFirstValue = false;
                bool setAmountContainerInstanceWidthSecondValue = false;
                float AmountContainerInstanceWidthFirstValue= 0;
                float AmountContainerInstanceWidthSecondValue= 0;
                bool setAmountTextBlueFirstValue = false;
                bool setAmountTextBlueSecondValue = false;
                int AmountTextBlueFirstValue= 0;
                int AmountTextBlueSecondValue= 0;
                bool setAmountTextGreenFirstValue = false;
                bool setAmountTextGreenSecondValue = false;
                int AmountTextGreenFirstValue= 0;
                int AmountTextGreenSecondValue= 0;
                bool setAmountTextHeightFirstValue = false;
                bool setAmountTextHeightSecondValue = false;
                float AmountTextHeightFirstValue= 0;
                float AmountTextHeightSecondValue= 0;
                bool setAmountTextRedFirstValue = false;
                bool setAmountTextRedSecondValue = false;
                int AmountTextRedFirstValue= 0;
                int AmountTextRedSecondValue= 0;
                bool setAmountText1BlueFirstValue = false;
                bool setAmountText1BlueSecondValue = false;
                int AmountText1BlueFirstValue= 0;
                int AmountText1BlueSecondValue= 0;
                bool setAmountText1GreenFirstValue = false;
                bool setAmountText1GreenSecondValue = false;
                int AmountText1GreenFirstValue= 0;
                int AmountText1GreenSecondValue= 0;
                bool setAmountText1HeightFirstValue = false;
                bool setAmountText1HeightSecondValue = false;
                float AmountText1HeightFirstValue= 0;
                float AmountText1HeightSecondValue= 0;
                bool setAmountText1RedFirstValue = false;
                bool setAmountText1RedSecondValue = false;
                int AmountText1RedFirstValue= 0;
                int AmountText1RedSecondValue= 0;
                bool setAutoAmountContainerInstanceHeightFirstValue = false;
                bool setAutoAmountContainerInstanceHeightSecondValue = false;
                float AutoAmountContainerInstanceHeightFirstValue= 0;
                float AutoAmountContainerInstanceHeightSecondValue= 0;
                bool setAutoAmountContainerInstanceWidthFirstValue = false;
                bool setAutoAmountContainerInstanceWidthSecondValue = false;
                float AutoAmountContainerInstanceWidthFirstValue= 0;
                float AutoAmountContainerInstanceWidthSecondValue= 0;
                bool setAutoSellButtonInstanceWidthFirstValue = false;
                bool setAutoSellButtonInstanceWidthSecondValue = false;
                float AutoSellButtonInstanceWidthFirstValue= 0;
                float AutoSellButtonInstanceWidthSecondValue= 0;
                bool setAutoSellButtonInstanceXFirstValue = false;
                bool setAutoSellButtonInstanceXSecondValue = false;
                float AutoSellButtonInstanceXFirstValue= 0;
                float AutoSellButtonInstanceXSecondValue= 0;
                bool setAutoSellButtonInstanceYFirstValue = false;
                bool setAutoSellButtonInstanceYSecondValue = false;
                float AutoSellButtonInstanceYFirstValue= 0;
                float AutoSellButtonInstanceYSecondValue= 0;
                bool setComboBoxInstanceWidthFirstValue = false;
                bool setComboBoxInstanceWidthSecondValue = false;
                float ComboBoxInstanceWidthFirstValue= 0;
                float ComboBoxInstanceWidthSecondValue= 0;
                bool setContainerInstanceHeightFirstValue = false;
                bool setContainerInstanceHeightSecondValue = false;
                float ContainerInstanceHeightFirstValue= 0;
                float ContainerInstanceHeightSecondValue= 0;
                bool setContainerInstanceWidthFirstValue = false;
                bool setContainerInstanceWidthSecondValue = false;
                float ContainerInstanceWidthFirstValue= 0;
                float ContainerInstanceWidthSecondValue= 0;
                bool setContainerInstanceXFirstValue = false;
                bool setContainerInstanceXSecondValue = false;
                float ContainerInstanceXFirstValue= 0;
                float ContainerInstanceXSecondValue= 0;
                bool setContainerInstanceYFirstValue = false;
                bool setContainerInstanceYSecondValue = false;
                float ContainerInstanceYFirstValue= 0;
                float ContainerInstanceYSecondValue= 0;
                bool setListingBlueFirstValue = false;
                bool setListingBlueSecondValue = false;
                int ListingBlueFirstValue= 0;
                int ListingBlueSecondValue= 0;
                bool setListingFontSizeFirstValue = false;
                bool setListingFontSizeSecondValue = false;
                int ListingFontSizeFirstValue= 0;
                int ListingFontSizeSecondValue= 0;
                bool setListingGreenFirstValue = false;
                bool setListingGreenSecondValue = false;
                int ListingGreenFirstValue= 0;
                int ListingGreenSecondValue= 0;
                bool setListingHeightFirstValue = false;
                bool setListingHeightSecondValue = false;
                float ListingHeightFirstValue= 0;
                float ListingHeightSecondValue= 0;
                bool setListingRedFirstValue = false;
                bool setListingRedSecondValue = false;
                int ListingRedFirstValue= 0;
                int ListingRedSecondValue= 0;
                bool setListingWidthFirstValue = false;
                bool setListingWidthSecondValue = false;
                float ListingWidthFirstValue= 0;
                float ListingWidthSecondValue= 0;
                bool setMyListingsLabelBackgroundCurrentColorCategoryStateFirstValue = false;
                bool setMyListingsLabelBackgroundCurrentColorCategoryStateSecondValue = false;
                JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory MyListingsLabelBackgroundCurrentColorCategoryStateFirstValue= JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Gray;
                JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory MyListingsLabelBackgroundCurrentColorCategoryStateSecondValue= JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Gray;
                bool setMyListingsLabelBackgroundHeightFirstValue = false;
                bool setMyListingsLabelBackgroundHeightSecondValue = false;
                float MyListingsLabelBackgroundHeightFirstValue= 0;
                float MyListingsLabelBackgroundHeightSecondValue= 0;
                bool setMyListingsLabelBackgroundWidthFirstValue = false;
                bool setMyListingsLabelBackgroundWidthSecondValue = false;
                float MyListingsLabelBackgroundWidthFirstValue= 0;
                float MyListingsLabelBackgroundWidthSecondValue= 0;
                bool setMyListingsLabelBackgroundXFirstValue = false;
                bool setMyListingsLabelBackgroundXSecondValue = false;
                float MyListingsLabelBackgroundXFirstValue= 0;
                float MyListingsLabelBackgroundXSecondValue= 0;
                bool setMyListingsLabelBackgroundYFirstValue = false;
                bool setMyListingsLabelBackgroundYSecondValue = false;
                float MyListingsLabelBackgroundYFirstValue= 0;
                float MyListingsLabelBackgroundYSecondValue= 0;
                bool setMyListingsListColoredFrameInstanceAlphaFirstValue = false;
                bool setMyListingsListColoredFrameInstanceAlphaSecondValue = false;
                int MyListingsListColoredFrameInstanceAlphaFirstValue= 0;
                int MyListingsListColoredFrameInstanceAlphaSecondValue= 0;
                bool setMyListingsListHeightFirstValue = false;
                bool setMyListingsListHeightSecondValue = false;
                float MyListingsListHeightFirstValue= 0;
                float MyListingsListHeightSecondValue= 0;
                bool setMyListingsListWidthFirstValue = false;
                bool setMyListingsListWidthSecondValue = false;
                float MyListingsListWidthFirstValue= 0;
                float MyListingsListWidthSecondValue= 0;
                bool setMyListingsListYFirstValue = false;
                bool setMyListingsListYSecondValue = false;
                float MyListingsListYFirstValue= 0;
                float MyListingsListYSecondValue= 0;
                bool setMyListingsTextInstanceFontSizeFirstValue = false;
                bool setMyListingsTextInstanceFontSizeSecondValue = false;
                int MyListingsTextInstanceFontSizeFirstValue= 0;
                int MyListingsTextInstanceFontSizeSecondValue= 0;
                bool setMyListingsTextInstanceHeightFirstValue = false;
                bool setMyListingsTextInstanceHeightSecondValue = false;
                float MyListingsTextInstanceHeightFirstValue= 0;
                float MyListingsTextInstanceHeightSecondValue= 0;
                bool setMyListingsTextInstanceWidthFirstValue = false;
                bool setMyListingsTextInstanceWidthSecondValue = false;
                float MyListingsTextInstanceWidthFirstValue= 0;
                float MyListingsTextInstanceWidthSecondValue= 0;
                bool setNewListingBackgroundAlphaFirstValue = false;
                bool setNewListingBackgroundAlphaSecondValue = false;
                int NewListingBackgroundAlphaFirstValue= 0;
                int NewListingBackgroundAlphaSecondValue= 0;
                bool setNewListingBackgroundCurrentColorCategoryStateFirstValue = false;
                bool setNewListingBackgroundCurrentColorCategoryStateSecondValue = false;
                JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory NewListingBackgroundCurrentColorCategoryStateFirstValue= JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Gray;
                JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory NewListingBackgroundCurrentColorCategoryStateSecondValue= JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Gray;
                bool setNewListingBackgroundHeightFirstValue = false;
                bool setNewListingBackgroundHeightSecondValue = false;
                float NewListingBackgroundHeightFirstValue= 0;
                float NewListingBackgroundHeightSecondValue= 0;
                bool setNewListingBackgroundWidthFirstValue = false;
                bool setNewListingBackgroundWidthSecondValue = false;
                float NewListingBackgroundWidthFirstValue= 0;
                float NewListingBackgroundWidthSecondValue= 0;
                bool setNewListingBackgroundXFirstValue = false;
                bool setNewListingBackgroundXSecondValue = false;
                float NewListingBackgroundXFirstValue= 0;
                float NewListingBackgroundXSecondValue= 0;
                bool setNewListingBackgroundYFirstValue = false;
                bool setNewListingBackgroundYSecondValue = false;
                float NewListingBackgroundYFirstValue= 0;
                float NewListingBackgroundYSecondValue= 0;
                bool setNewLsitingUIContainerHeightFirstValue = false;
                bool setNewLsitingUIContainerHeightSecondValue = false;
                float NewLsitingUIContainerHeightFirstValue= 0;
                float NewLsitingUIContainerHeightSecondValue= 0;
                bool setNewLsitingUIContainerWidthFirstValue = false;
                bool setNewLsitingUIContainerWidthSecondValue = false;
                float NewLsitingUIContainerWidthFirstValue= 0;
                float NewLsitingUIContainerWidthSecondValue= 0;
                bool setNewLsitingUIContainerXFirstValue = false;
                bool setNewLsitingUIContainerXSecondValue = false;
                float NewLsitingUIContainerXFirstValue= 0;
                float NewLsitingUIContainerXSecondValue= 0;
                bool setNewLsitingUIContainerYFirstValue = false;
                bool setNewLsitingUIContainerYSecondValue = false;
                float NewLsitingUIContainerYFirstValue= 0;
                float NewLsitingUIContainerYSecondValue= 0;
                bool setResourceDisplayInstanceWidthFirstValue = false;
                bool setResourceDisplayInstanceWidthSecondValue = false;
                float ResourceDisplayInstanceWidthFirstValue= 0;
                float ResourceDisplayInstanceWidthSecondValue= 0;
                bool setSellAllButtonInstanceWidthFirstValue = false;
                bool setSellAllButtonInstanceWidthSecondValue = false;
                float SellAllButtonInstanceWidthFirstValue= 0;
                float SellAllButtonInstanceWidthSecondValue= 0;
                bool setSellAllButtonInstanceXFirstValue = false;
                bool setSellAllButtonInstanceXSecondValue = false;
                float SellAllButtonInstanceXFirstValue= 0;
                float SellAllButtonInstanceXSecondValue= 0;
                bool setSellAllButtonInstanceYFirstValue = false;
                bool setSellAllButtonInstanceYSecondValue = false;
                float SellAllButtonInstanceYFirstValue= 0;
                float SellAllButtonInstanceYSecondValue= 0;
                bool setSellOneButtonInstanceWidthFirstValue = false;
                bool setSellOneButtonInstanceWidthSecondValue = false;
                float SellOneButtonInstanceWidthFirstValue= 0;
                float SellOneButtonInstanceWidthSecondValue= 0;
                bool setSellOneButtonInstanceXFirstValue = false;
                bool setSellOneButtonInstanceXSecondValue = false;
                float SellOneButtonInstanceXFirstValue= 0;
                float SellOneButtonInstanceXSecondValue= 0;
                bool setSellOneButtonInstanceYFirstValue = false;
                bool setSellOneButtonInstanceYSecondValue = false;
                float SellOneButtonInstanceYFirstValue= 0;
                float SellOneButtonInstanceYSecondValue= 0;
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
                bool setTextInstanceBlueFirstValue = false;
                bool setTextInstanceBlueSecondValue = false;
                int TextInstanceBlueFirstValue= 0;
                int TextInstanceBlueSecondValue= 0;
                bool setTextInstanceFontSizeFirstValue = false;
                bool setTextInstanceFontSizeSecondValue = false;
                int TextInstanceFontSizeFirstValue= 0;
                int TextInstanceFontSizeSecondValue= 0;
                bool setTextInstanceGreenFirstValue = false;
                bool setTextInstanceGreenSecondValue = false;
                int TextInstanceGreenFirstValue= 0;
                int TextInstanceGreenSecondValue= 0;
                bool setTextInstanceHeightFirstValue = false;
                bool setTextInstanceHeightSecondValue = false;
                float TextInstanceHeightFirstValue= 0;
                float TextInstanceHeightSecondValue= 0;
                bool setTextInstanceRedFirstValue = false;
                bool setTextInstanceRedSecondValue = false;
                int TextInstanceRedFirstValue= 0;
                int TextInstanceRedSecondValue= 0;
                bool setTextInstanceWidthFirstValue = false;
                bool setTextInstanceWidthSecondValue = false;
                float TextInstanceWidthFirstValue= 0;
                float TextInstanceWidthSecondValue= 0;
                bool setValueTextBlueFirstValue = false;
                bool setValueTextBlueSecondValue = false;
                int ValueTextBlueFirstValue= 0;
                int ValueTextBlueSecondValue= 0;
                bool setValueTextGreenFirstValue = false;
                bool setValueTextGreenSecondValue = false;
                int ValueTextGreenFirstValue= 0;
                int ValueTextGreenSecondValue= 0;
                bool setValueTextHeightFirstValue = false;
                bool setValueTextHeightSecondValue = false;
                float ValueTextHeightFirstValue= 0;
                float ValueTextHeightSecondValue= 0;
                bool setValueTextRedFirstValue = false;
                bool setValueTextRedSecondValue = false;
                int ValueTextRedFirstValue= 0;
                int ValueTextRedSecondValue= 0;
                bool setvauleContainerInstanceHeightFirstValue = false;
                bool setvauleContainerInstanceHeightSecondValue = false;
                float vauleContainerInstanceHeightFirstValue= 0;
                float vauleContainerInstanceHeightSecondValue= 0;
                bool setvauleContainerInstanceWidthFirstValue = false;
                bool setvauleContainerInstanceWidthSecondValue = false;
                float vauleContainerInstanceWidthFirstValue= 0;
                float vauleContainerInstanceWidthSecondValue= 0;
                switch(firstState)
                {
                    case  VariableState.Default:
                        setAmountContainerInstanceHeightFirstValue = true;
                        AmountContainerInstanceHeightFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.AmountContainerInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                        }
                        if (interpolationValue < 1)
                        {
                            this.AmountContainerInstance.Parent = this.GetGraphicalUiElementByName("NewLsitingUIContainer");
                        }
                        setAmountContainerInstanceWidthFirstValue = true;
                        AmountContainerInstanceWidthFirstValue = 100f;
                        if (interpolationValue < 1)
                        {
                            this.AmountContainerInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setAmountTextBlueFirstValue = true;
                        AmountTextBlueFirstValue = 0;
                        setAmountTextGreenFirstValue = true;
                        AmountTextGreenFirstValue = 0;
                        setAmountTextHeightFirstValue = true;
                        AmountTextHeightFirstValue = 30f;
                        if (interpolationValue < 1)
                        {
                            this.AmountText.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        if (interpolationValue < 1)
                        {
                            this.AmountText.Parent = this.GetGraphicalUiElementByName("AmountContainerInstance");
                        }
                        setAmountTextRedFirstValue = true;
                        AmountTextRedFirstValue = 0;
                        if (interpolationValue < 1)
                        {
                            this.AmountText.Text = "Amount:";
                        }
                        if (interpolationValue < 1)
                        {
                            this.AmountText.VerticalAlignment = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        setAmountText1BlueFirstValue = true;
                        AmountText1BlueFirstValue = 0;
                        setAmountText1GreenFirstValue = true;
                        AmountText1GreenFirstValue = 0;
                        setAmountText1HeightFirstValue = true;
                        AmountText1HeightFirstValue = 30f;
                        if (interpolationValue < 1)
                        {
                            this.AmountText1.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        if (interpolationValue < 1)
                        {
                            this.AmountText1.Parent = this.GetGraphicalUiElementByName("AutoAmountContainerInstance");
                        }
                        setAmountText1RedFirstValue = true;
                        AmountText1RedFirstValue = 0;
                        if (interpolationValue < 1)
                        {
                            this.AmountText1.Text = "Amount:";
                        }
                        if (interpolationValue < 1)
                        {
                            this.AmountText1.VerticalAlignment = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        setAutoAmountContainerInstanceHeightFirstValue = true;
                        AutoAmountContainerInstanceHeightFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.AutoAmountContainerInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                        }
                        if (interpolationValue < 1)
                        {
                            this.AutoAmountContainerInstance.Parent = this.GetGraphicalUiElementByName("NewLsitingUIContainer");
                        }
                        setAutoAmountContainerInstanceWidthFirstValue = true;
                        AutoAmountContainerInstanceWidthFirstValue = 100f;
                        if (interpolationValue < 1)
                        {
                            this.AutoAmountContainerInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.AutoSellAmountTextBoxInstance.Parent = this.GetGraphicalUiElementByName("AutoAmountContainerInstance");
                        }
                        if (interpolationValue < 1)
                        {
                            this.AutoSellAmountTextBoxInstance.Text = "Amount";
                        }
                        if (interpolationValue < 1)
                        {
                            this.AutoSellAmountTextBoxInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                        }
                        if (interpolationValue < 1)
                        {
                            this.AutoSellAmountTextBoxInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                        }
                        if (interpolationValue < 1)
                        {
                            this.AutoSellButtonInstance.Parent = this.GetGraphicalUiElementByName("NewLsitingUIContainer");
                        }
                        if (interpolationValue < 1)
                        {
                            this.AutoSellButtonInstance.Text = "Create Listing";
                        }
                        setAutoSellButtonInstanceWidthFirstValue = true;
                        AutoSellButtonInstanceWidthFirstValue = 100f;
                        if (interpolationValue < 1)
                        {
                            this.AutoSellButtonInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setAutoSellButtonInstanceXFirstValue = true;
                        AutoSellButtonInstanceXFirstValue = 0f;
                        setAutoSellButtonInstanceYFirstValue = true;
                        AutoSellButtonInstanceYFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.ComboBoxInstance.Parent = this.GetGraphicalUiElementByName("NewLsitingUIContainer");
                        }
                        setComboBoxInstanceWidthFirstValue = true;
                        ComboBoxInstanceWidthFirstValue = 100f;
                        if (interpolationValue < 1)
                        {
                            this.ComboBoxInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setContainerInstanceHeightFirstValue = true;
                        ContainerInstanceHeightFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.ContainerInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                        }
                        if (interpolationValue < 1)
                        {
                            this.ContainerInstance.Parent = this.GetGraphicalUiElementByName("NewLsitingUIContainer");
                        }
                        setContainerInstanceWidthFirstValue = true;
                        ContainerInstanceWidthFirstValue = 100f;
                        if (interpolationValue < 1)
                        {
                            this.ContainerInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setContainerInstanceXFirstValue = true;
                        ContainerInstanceXFirstValue = 0f;
                        setContainerInstanceYFirstValue = true;
                        ContainerInstanceYFirstValue = 10f;
                        setListingBlueFirstValue = true;
                        ListingBlueFirstValue = 0;
                        setListingFontSizeFirstValue = true;
                        ListingFontSizeFirstValue = 24;
                        setListingGreenFirstValue = true;
                        ListingGreenFirstValue = 0;
                        setListingHeightFirstValue = true;
                        ListingHeightFirstValue = 10f;
                        if (interpolationValue < 1)
                        {
                            this.Listing.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                        }
                        if (interpolationValue < 1)
                        {
                            this.Listing.Parent = this.GetGraphicalUiElementByName("NewLsitingUIContainer");
                        }
                        setListingRedFirstValue = true;
                        ListingRedFirstValue = 0;
                        if (interpolationValue < 1)
                        {
                            this.Listing.Text = "Auto sell above:";
                        }
                        setListingWidthFirstValue = true;
                        ListingWidthFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.Listing.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                        }
                        if (interpolationValue < 1)
                        {
                            this.Listing.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                        }
                        if (interpolationValue < 1)
                        {
                            this.Listing.XUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                        }
                        setMyListingsLabelBackgroundCurrentColorCategoryStateFirstValue = true;
                        MyListingsLabelBackgroundCurrentColorCategoryStateFirstValue = JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Black;
                        setMyListingsLabelBackgroundHeightFirstValue = true;
                        MyListingsLabelBackgroundHeightFirstValue = 72f;
                        setMyListingsLabelBackgroundWidthFirstValue = true;
                        MyListingsLabelBackgroundWidthFirstValue = 750f;
                        if (interpolationValue < 1)
                        {
                            this.MyListingsLabelBackground.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        setMyListingsLabelBackgroundXFirstValue = true;
                        MyListingsLabelBackgroundXFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.MyListingsLabelBackground.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                        }
                        if (interpolationValue < 1)
                        {
                            this.MyListingsLabelBackground.XUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                        }
                        setMyListingsLabelBackgroundYFirstValue = true;
                        MyListingsLabelBackgroundYFirstValue = 72f;
                        setMyListingsListColoredFrameInstanceAlphaFirstValue = true;
                        MyListingsListColoredFrameInstanceAlphaFirstValue = 255;
                        setMyListingsListHeightFirstValue = true;
                        MyListingsListHeightFirstValue = -216f;
                        if (interpolationValue < 1)
                        {
                            this.MyListingsList.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        if (interpolationValue < 1)
                        {
                            this.MyListingsList.ListBoxBackgroundColorCategoryState = JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Gray;
                        }
                        setMyListingsListWidthFirstValue = true;
                        MyListingsListWidthFirstValue = 750f;
                        if (interpolationValue < 1)
                        {
                            this.MyListingsList.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        if (interpolationValue < 1)
                        {
                            this.MyListingsList.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                        }
                        if (interpolationValue < 1)
                        {
                            this.MyListingsList.XUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                        }
                        setMyListingsListYFirstValue = true;
                        MyListingsListYFirstValue = 144f;
                        setMyListingsTextInstanceFontSizeFirstValue = true;
                        MyListingsTextInstanceFontSizeFirstValue = 48;
                        setMyListingsTextInstanceHeightFirstValue = true;
                        MyListingsTextInstanceHeightFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.MyListingsTextInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                        }
                        if (interpolationValue < 1)
                        {
                            this.MyListingsTextInstance.Parent = this.GetGraphicalUiElementByName("MyListingsLabelBackground");
                        }
                        if (interpolationValue < 1)
                        {
                            this.MyListingsTextInstance.Text = "MyListings";
                        }
                        setMyListingsTextInstanceWidthFirstValue = true;
                        MyListingsTextInstanceWidthFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.MyListingsTextInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                        }
                        if (interpolationValue < 1)
                        {
                            this.MyListingsTextInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.MyListingsTextInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        if (interpolationValue < 1)
                        {
                            this.MyListingsTextInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.MyListingsTextInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setNewListingBackgroundAlphaFirstValue = true;
                        NewListingBackgroundAlphaFirstValue = 128;
                        setNewListingBackgroundCurrentColorCategoryStateFirstValue = true;
                        NewListingBackgroundCurrentColorCategoryStateFirstValue = JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Gray;
                        setNewListingBackgroundHeightFirstValue = true;
                        NewListingBackgroundHeightFirstValue = -272f;
                        if (interpolationValue < 1)
                        {
                            this.NewListingBackground.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        setNewListingBackgroundWidthFirstValue = true;
                        NewListingBackgroundWidthFirstValue = 400f;
                        if (interpolationValue < 1)
                        {
                            this.NewListingBackground.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        setNewListingBackgroundXFirstValue = true;
                        NewListingBackgroundXFirstValue = -760f;
                        if (interpolationValue < 1)
                        {
                            this.NewListingBackground.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                        }
                        if (interpolationValue < 1)
                        {
                            this.NewListingBackground.XUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                        }
                        setNewListingBackgroundYFirstValue = true;
                        NewListingBackgroundYFirstValue = 72f;
                        if (interpolationValue < 1)
                        {
                            this.NewLsitingUIContainer.ChildrenLayout = Gum.Managers.ChildrenLayout.TopToBottomStack;
                        }
                        setNewLsitingUIContainerHeightFirstValue = true;
                        NewLsitingUIContainerHeightFirstValue = -40f;
                        if (interpolationValue < 1)
                        {
                            this.NewLsitingUIContainer.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        if (interpolationValue < 1)
                        {
                            this.NewLsitingUIContainer.Parent = this.GetGraphicalUiElementByName("NewListingBackground");
                        }
                        setNewLsitingUIContainerWidthFirstValue = true;
                        NewLsitingUIContainerWidthFirstValue = -40f;
                        if (interpolationValue < 1)
                        {
                            this.NewLsitingUIContainer.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        setNewLsitingUIContainerXFirstValue = true;
                        NewLsitingUIContainerXFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.NewLsitingUIContainer.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.NewLsitingUIContainer.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setNewLsitingUIContainerYFirstValue = true;
                        NewLsitingUIContainerYFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.NewLsitingUIContainer.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.NewLsitingUIContainer.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        if (interpolationValue < 1)
                        {
                            this.ResourceDisplayInstance.Parent = this.GetGraphicalUiElementByName("vauleContainerInstance");
                        }
                        if (interpolationValue < 1)
                        {
                            SetProperty("ResourceDisplayInstance.SpriteInstanceSourceFile", "../GlobalContent/Resources/ResourceIcons/money-stack.png");
                        }
                        setResourceDisplayInstanceWidthFirstValue = true;
                        ResourceDisplayInstanceWidthFirstValue = 220f;
                        if (interpolationValue < 1)
                        {
                            this.ResourceDisplayInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                        }
                        if (interpolationValue < 1)
                        {
                            this.ResourceDisplayInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                        }
                        if (interpolationValue < 1)
                        {
                            this.SellAllButtonInstance.Parent = this.GetGraphicalUiElementByName("ContainerInstance");
                        }
                        if (interpolationValue < 1)
                        {
                            this.SellAllButtonInstance.Text = "Sell All";
                        }
                        setSellAllButtonInstanceWidthFirstValue = true;
                        SellAllButtonInstanceWidthFirstValue = 50f;
                        if (interpolationValue < 1)
                        {
                            this.SellAllButtonInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setSellAllButtonInstanceXFirstValue = true;
                        SellAllButtonInstanceXFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.SellAllButtonInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                        }
                        if (interpolationValue < 1)
                        {
                            this.SellAllButtonInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                        }
                        setSellAllButtonInstanceYFirstValue = true;
                        SellAllButtonInstanceYFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.SellOneButtonInstance.Parent = this.GetGraphicalUiElementByName("ContainerInstance");
                        }
                        if (interpolationValue < 1)
                        {
                            this.SellOneButtonInstance.Text = "Sell one";
                        }
                        setSellOneButtonInstanceWidthFirstValue = true;
                        SellOneButtonInstanceWidthFirstValue = 50f;
                        if (interpolationValue < 1)
                        {
                            this.SellOneButtonInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setSellOneButtonInstanceXFirstValue = true;
                        SellOneButtonInstanceXFirstValue = 0f;
                        setSellOneButtonInstanceYFirstValue = true;
                        SellOneButtonInstanceYFirstValue = 0f;
                        setSpriteInstanceHeightFirstValue = true;
                        SpriteInstanceHeightFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.SpriteInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        if (interpolationValue < 1)
                        {
                            SetProperty("SpriteInstance.SourceFile", "../GlobalContent/Screen/stockmarket.jpg");
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
                        setTextInstanceBlueFirstValue = true;
                        TextInstanceBlueFirstValue = 0;
                        setTextInstanceFontSizeFirstValue = true;
                        TextInstanceFontSizeFirstValue = 24;
                        setTextInstanceGreenFirstValue = true;
                        TextInstanceGreenFirstValue = 0;
                        setTextInstanceHeightFirstValue = true;
                        TextInstanceHeightFirstValue = 10f;
                        if (interpolationValue < 1)
                        {
                            this.TextInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                        }
                        if (interpolationValue < 1)
                        {
                            this.TextInstance.Parent = this.GetGraphicalUiElementByName("NewLsitingUIContainer");
                        }
                        setTextInstanceRedFirstValue = true;
                        TextInstanceRedFirstValue = 0;
                        if (interpolationValue < 1)
                        {
                            this.TextInstance.Text = "To sell:";
                        }
                        setTextInstanceWidthFirstValue = true;
                        TextInstanceWidthFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.TextInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                        }
                        if (interpolationValue < 1)
                        {
                            this.TextInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                        }
                        if (interpolationValue < 1)
                        {
                            this.TextInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                        }
                        if (interpolationValue < 1)
                        {
                            this.ToSellAmountTextBoxInstance.Parent = this.GetGraphicalUiElementByName("AmountContainerInstance");
                        }
                        if (interpolationValue < 1)
                        {
                            this.ToSellAmountTextBoxInstance.Text = "Amount";
                        }
                        if (interpolationValue < 1)
                        {
                            this.ToSellAmountTextBoxInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                        }
                        if (interpolationValue < 1)
                        {
                            this.ToSellAmountTextBoxInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                        }
                        setValueTextBlueFirstValue = true;
                        ValueTextBlueFirstValue = 0;
                        setValueTextGreenFirstValue = true;
                        ValueTextGreenFirstValue = 0;
                        setValueTextHeightFirstValue = true;
                        ValueTextHeightFirstValue = 40f;
                        if (interpolationValue < 1)
                        {
                            this.ValueText.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                        }
                        if (interpolationValue < 1)
                        {
                            this.ValueText.Parent = this.GetGraphicalUiElementByName("vauleContainerInstance");
                        }
                        setValueTextRedFirstValue = true;
                        ValueTextRedFirstValue = 0;
                        if (interpolationValue < 1)
                        {
                            this.ValueText.Text = "Value:";
                        }
                        if (interpolationValue < 1)
                        {
                            this.ValueText.VerticalAlignment = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        setvauleContainerInstanceHeightFirstValue = true;
                        vauleContainerInstanceHeightFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.vauleContainerInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                        }
                        if (interpolationValue < 1)
                        {
                            this.vauleContainerInstance.Parent = this.GetGraphicalUiElementByName("NewLsitingUIContainer");
                        }
                        setvauleContainerInstanceWidthFirstValue = true;
                        vauleContainerInstanceWidthFirstValue = 100f;
                        if (interpolationValue < 1)
                        {
                            this.vauleContainerInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        break;
                }
                switch(secondState)
                {
                    case  VariableState.Default:
                        setAmountContainerInstanceHeightSecondValue = true;
                        AmountContainerInstanceHeightSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.AmountContainerInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.AmountContainerInstance.Parent = this.GetGraphicalUiElementByName("NewLsitingUIContainer");
                        }
                        setAmountContainerInstanceWidthSecondValue = true;
                        AmountContainerInstanceWidthSecondValue = 100f;
                        if (interpolationValue >= 1)
                        {
                            this.AmountContainerInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setAmountTextBlueSecondValue = true;
                        AmountTextBlueSecondValue = 0;
                        setAmountTextGreenSecondValue = true;
                        AmountTextGreenSecondValue = 0;
                        setAmountTextHeightSecondValue = true;
                        AmountTextHeightSecondValue = 30f;
                        if (interpolationValue >= 1)
                        {
                            this.AmountText.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.AmountText.Parent = this.GetGraphicalUiElementByName("AmountContainerInstance");
                        }
                        setAmountTextRedSecondValue = true;
                        AmountTextRedSecondValue = 0;
                        if (interpolationValue >= 1)
                        {
                            this.AmountText.Text = "Amount:";
                        }
                        if (interpolationValue >= 1)
                        {
                            this.AmountText.VerticalAlignment = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        setAmountText1BlueSecondValue = true;
                        AmountText1BlueSecondValue = 0;
                        setAmountText1GreenSecondValue = true;
                        AmountText1GreenSecondValue = 0;
                        setAmountText1HeightSecondValue = true;
                        AmountText1HeightSecondValue = 30f;
                        if (interpolationValue >= 1)
                        {
                            this.AmountText1.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.AmountText1.Parent = this.GetGraphicalUiElementByName("AutoAmountContainerInstance");
                        }
                        setAmountText1RedSecondValue = true;
                        AmountText1RedSecondValue = 0;
                        if (interpolationValue >= 1)
                        {
                            this.AmountText1.Text = "Amount:";
                        }
                        if (interpolationValue >= 1)
                        {
                            this.AmountText1.VerticalAlignment = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        setAutoAmountContainerInstanceHeightSecondValue = true;
                        AutoAmountContainerInstanceHeightSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.AutoAmountContainerInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.AutoAmountContainerInstance.Parent = this.GetGraphicalUiElementByName("NewLsitingUIContainer");
                        }
                        setAutoAmountContainerInstanceWidthSecondValue = true;
                        AutoAmountContainerInstanceWidthSecondValue = 100f;
                        if (interpolationValue >= 1)
                        {
                            this.AutoAmountContainerInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.AutoSellAmountTextBoxInstance.Parent = this.GetGraphicalUiElementByName("AutoAmountContainerInstance");
                        }
                        if (interpolationValue >= 1)
                        {
                            this.AutoSellAmountTextBoxInstance.Text = "Amount";
                        }
                        if (interpolationValue >= 1)
                        {
                            this.AutoSellAmountTextBoxInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.AutoSellAmountTextBoxInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.AutoSellButtonInstance.Parent = this.GetGraphicalUiElementByName("NewLsitingUIContainer");
                        }
                        if (interpolationValue >= 1)
                        {
                            this.AutoSellButtonInstance.Text = "Create Listing";
                        }
                        setAutoSellButtonInstanceWidthSecondValue = true;
                        AutoSellButtonInstanceWidthSecondValue = 100f;
                        if (interpolationValue >= 1)
                        {
                            this.AutoSellButtonInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setAutoSellButtonInstanceXSecondValue = true;
                        AutoSellButtonInstanceXSecondValue = 0f;
                        setAutoSellButtonInstanceYSecondValue = true;
                        AutoSellButtonInstanceYSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.ComboBoxInstance.Parent = this.GetGraphicalUiElementByName("NewLsitingUIContainer");
                        }
                        setComboBoxInstanceWidthSecondValue = true;
                        ComboBoxInstanceWidthSecondValue = 100f;
                        if (interpolationValue >= 1)
                        {
                            this.ComboBoxInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setContainerInstanceHeightSecondValue = true;
                        ContainerInstanceHeightSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.ContainerInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.ContainerInstance.Parent = this.GetGraphicalUiElementByName("NewLsitingUIContainer");
                        }
                        setContainerInstanceWidthSecondValue = true;
                        ContainerInstanceWidthSecondValue = 100f;
                        if (interpolationValue >= 1)
                        {
                            this.ContainerInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setContainerInstanceXSecondValue = true;
                        ContainerInstanceXSecondValue = 0f;
                        setContainerInstanceYSecondValue = true;
                        ContainerInstanceYSecondValue = 10f;
                        setListingBlueSecondValue = true;
                        ListingBlueSecondValue = 0;
                        setListingFontSizeSecondValue = true;
                        ListingFontSizeSecondValue = 24;
                        setListingGreenSecondValue = true;
                        ListingGreenSecondValue = 0;
                        setListingHeightSecondValue = true;
                        ListingHeightSecondValue = 10f;
                        if (interpolationValue >= 1)
                        {
                            this.Listing.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.Listing.Parent = this.GetGraphicalUiElementByName("NewLsitingUIContainer");
                        }
                        setListingRedSecondValue = true;
                        ListingRedSecondValue = 0;
                        if (interpolationValue >= 1)
                        {
                            this.Listing.Text = "Auto sell above:";
                        }
                        setListingWidthSecondValue = true;
                        ListingWidthSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.Listing.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.Listing.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.Listing.XUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                        }
                        setMyListingsLabelBackgroundCurrentColorCategoryStateSecondValue = true;
                        MyListingsLabelBackgroundCurrentColorCategoryStateSecondValue = JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Black;
                        setMyListingsLabelBackgroundHeightSecondValue = true;
                        MyListingsLabelBackgroundHeightSecondValue = 72f;
                        setMyListingsLabelBackgroundWidthSecondValue = true;
                        MyListingsLabelBackgroundWidthSecondValue = 750f;
                        if (interpolationValue >= 1)
                        {
                            this.MyListingsLabelBackground.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        setMyListingsLabelBackgroundXSecondValue = true;
                        MyListingsLabelBackgroundXSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.MyListingsLabelBackground.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.MyListingsLabelBackground.XUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                        }
                        setMyListingsLabelBackgroundYSecondValue = true;
                        MyListingsLabelBackgroundYSecondValue = 72f;
                        setMyListingsListColoredFrameInstanceAlphaSecondValue = true;
                        MyListingsListColoredFrameInstanceAlphaSecondValue = 255;
                        setMyListingsListHeightSecondValue = true;
                        MyListingsListHeightSecondValue = -216f;
                        if (interpolationValue >= 1)
                        {
                            this.MyListingsList.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.MyListingsList.ListBoxBackgroundColorCategoryState = JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Gray;
                        }
                        setMyListingsListWidthSecondValue = true;
                        MyListingsListWidthSecondValue = 750f;
                        if (interpolationValue >= 1)
                        {
                            this.MyListingsList.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.MyListingsList.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.MyListingsList.XUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                        }
                        setMyListingsListYSecondValue = true;
                        MyListingsListYSecondValue = 144f;
                        setMyListingsTextInstanceFontSizeSecondValue = true;
                        MyListingsTextInstanceFontSizeSecondValue = 48;
                        setMyListingsTextInstanceHeightSecondValue = true;
                        MyListingsTextInstanceHeightSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.MyListingsTextInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.MyListingsTextInstance.Parent = this.GetGraphicalUiElementByName("MyListingsLabelBackground");
                        }
                        if (interpolationValue >= 1)
                        {
                            this.MyListingsTextInstance.Text = "MyListings";
                        }
                        setMyListingsTextInstanceWidthSecondValue = true;
                        MyListingsTextInstanceWidthSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.MyListingsTextInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.MyListingsTextInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.MyListingsTextInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.MyListingsTextInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.MyListingsTextInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setNewListingBackgroundAlphaSecondValue = true;
                        NewListingBackgroundAlphaSecondValue = 128;
                        setNewListingBackgroundCurrentColorCategoryStateSecondValue = true;
                        NewListingBackgroundCurrentColorCategoryStateSecondValue = JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Gray;
                        setNewListingBackgroundHeightSecondValue = true;
                        NewListingBackgroundHeightSecondValue = -272f;
                        if (interpolationValue >= 1)
                        {
                            this.NewListingBackground.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        setNewListingBackgroundWidthSecondValue = true;
                        NewListingBackgroundWidthSecondValue = 400f;
                        if (interpolationValue >= 1)
                        {
                            this.NewListingBackground.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        setNewListingBackgroundXSecondValue = true;
                        NewListingBackgroundXSecondValue = -760f;
                        if (interpolationValue >= 1)
                        {
                            this.NewListingBackground.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.NewListingBackground.XUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                        }
                        setNewListingBackgroundYSecondValue = true;
                        NewListingBackgroundYSecondValue = 72f;
                        if (interpolationValue >= 1)
                        {
                            this.NewLsitingUIContainer.ChildrenLayout = Gum.Managers.ChildrenLayout.TopToBottomStack;
                        }
                        setNewLsitingUIContainerHeightSecondValue = true;
                        NewLsitingUIContainerHeightSecondValue = -40f;
                        if (interpolationValue >= 1)
                        {
                            this.NewLsitingUIContainer.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.NewLsitingUIContainer.Parent = this.GetGraphicalUiElementByName("NewListingBackground");
                        }
                        setNewLsitingUIContainerWidthSecondValue = true;
                        NewLsitingUIContainerWidthSecondValue = -40f;
                        if (interpolationValue >= 1)
                        {
                            this.NewLsitingUIContainer.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        setNewLsitingUIContainerXSecondValue = true;
                        NewLsitingUIContainerXSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.NewLsitingUIContainer.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.NewLsitingUIContainer.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setNewLsitingUIContainerYSecondValue = true;
                        NewLsitingUIContainerYSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.NewLsitingUIContainer.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.NewLsitingUIContainer.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.ResourceDisplayInstance.Parent = this.GetGraphicalUiElementByName("vauleContainerInstance");
                        }
                        if (interpolationValue >= 1)
                        {
                            SetProperty("ResourceDisplayInstance.SpriteInstanceSourceFile", "../GlobalContent/Resources/ResourceIcons/money-stack.png");
                        }
                        setResourceDisplayInstanceWidthSecondValue = true;
                        ResourceDisplayInstanceWidthSecondValue = 220f;
                        if (interpolationValue >= 1)
                        {
                            this.ResourceDisplayInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.ResourceDisplayInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.SellAllButtonInstance.Parent = this.GetGraphicalUiElementByName("ContainerInstance");
                        }
                        if (interpolationValue >= 1)
                        {
                            this.SellAllButtonInstance.Text = "Sell All";
                        }
                        setSellAllButtonInstanceWidthSecondValue = true;
                        SellAllButtonInstanceWidthSecondValue = 50f;
                        if (interpolationValue >= 1)
                        {
                            this.SellAllButtonInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setSellAllButtonInstanceXSecondValue = true;
                        SellAllButtonInstanceXSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.SellAllButtonInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.SellAllButtonInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                        }
                        setSellAllButtonInstanceYSecondValue = true;
                        SellAllButtonInstanceYSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.SellOneButtonInstance.Parent = this.GetGraphicalUiElementByName("ContainerInstance");
                        }
                        if (interpolationValue >= 1)
                        {
                            this.SellOneButtonInstance.Text = "Sell one";
                        }
                        setSellOneButtonInstanceWidthSecondValue = true;
                        SellOneButtonInstanceWidthSecondValue = 50f;
                        if (interpolationValue >= 1)
                        {
                            this.SellOneButtonInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setSellOneButtonInstanceXSecondValue = true;
                        SellOneButtonInstanceXSecondValue = 0f;
                        setSellOneButtonInstanceYSecondValue = true;
                        SellOneButtonInstanceYSecondValue = 0f;
                        setSpriteInstanceHeightSecondValue = true;
                        SpriteInstanceHeightSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.SpriteInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        if (interpolationValue >= 1)
                        {
                            SetProperty("SpriteInstance.SourceFile", "../GlobalContent/Screen/stockmarket.jpg");
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
                        setTextInstanceBlueSecondValue = true;
                        TextInstanceBlueSecondValue = 0;
                        setTextInstanceFontSizeSecondValue = true;
                        TextInstanceFontSizeSecondValue = 24;
                        setTextInstanceGreenSecondValue = true;
                        TextInstanceGreenSecondValue = 0;
                        setTextInstanceHeightSecondValue = true;
                        TextInstanceHeightSecondValue = 10f;
                        if (interpolationValue >= 1)
                        {
                            this.TextInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.TextInstance.Parent = this.GetGraphicalUiElementByName("NewLsitingUIContainer");
                        }
                        setTextInstanceRedSecondValue = true;
                        TextInstanceRedSecondValue = 0;
                        if (interpolationValue >= 1)
                        {
                            this.TextInstance.Text = "To sell:";
                        }
                        setTextInstanceWidthSecondValue = true;
                        TextInstanceWidthSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.TextInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.TextInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.TextInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.ToSellAmountTextBoxInstance.Parent = this.GetGraphicalUiElementByName("AmountContainerInstance");
                        }
                        if (interpolationValue >= 1)
                        {
                            this.ToSellAmountTextBoxInstance.Text = "Amount";
                        }
                        if (interpolationValue >= 1)
                        {
                            this.ToSellAmountTextBoxInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.ToSellAmountTextBoxInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                        }
                        setValueTextBlueSecondValue = true;
                        ValueTextBlueSecondValue = 0;
                        setValueTextGreenSecondValue = true;
                        ValueTextGreenSecondValue = 0;
                        setValueTextHeightSecondValue = true;
                        ValueTextHeightSecondValue = 40f;
                        if (interpolationValue >= 1)
                        {
                            this.ValueText.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.ValueText.Parent = this.GetGraphicalUiElementByName("vauleContainerInstance");
                        }
                        setValueTextRedSecondValue = true;
                        ValueTextRedSecondValue = 0;
                        if (interpolationValue >= 1)
                        {
                            this.ValueText.Text = "Value:";
                        }
                        if (interpolationValue >= 1)
                        {
                            this.ValueText.VerticalAlignment = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        setvauleContainerInstanceHeightSecondValue = true;
                        vauleContainerInstanceHeightSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.vauleContainerInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.vauleContainerInstance.Parent = this.GetGraphicalUiElementByName("NewLsitingUIContainer");
                        }
                        setvauleContainerInstanceWidthSecondValue = true;
                        vauleContainerInstanceWidthSecondValue = 100f;
                        if (interpolationValue >= 1)
                        {
                            this.vauleContainerInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        break;
                }
                var wasSuppressed = mIsLayoutSuspended;
                if (wasSuppressed == false)
                {
                    SuspendLayout(true);
                }
                if (setAmountContainerInstanceHeightFirstValue && setAmountContainerInstanceHeightSecondValue)
                {
                    AmountContainerInstance.Height = AmountContainerInstanceHeightFirstValue * (1 - interpolationValue) + AmountContainerInstanceHeightSecondValue * interpolationValue;
                }
                if (setAmountContainerInstanceWidthFirstValue && setAmountContainerInstanceWidthSecondValue)
                {
                    AmountContainerInstance.Width = AmountContainerInstanceWidthFirstValue * (1 - interpolationValue) + AmountContainerInstanceWidthSecondValue * interpolationValue;
                }
                if (setAmountTextBlueFirstValue && setAmountTextBlueSecondValue)
                {
                    AmountText.Blue = FlatRedBall.Math.MathFunctions.RoundToInt(AmountTextBlueFirstValue* (1 - interpolationValue) + AmountTextBlueSecondValue * interpolationValue);
                }
                if (setAmountTextGreenFirstValue && setAmountTextGreenSecondValue)
                {
                    AmountText.Green = FlatRedBall.Math.MathFunctions.RoundToInt(AmountTextGreenFirstValue* (1 - interpolationValue) + AmountTextGreenSecondValue * interpolationValue);
                }
                if (setAmountTextHeightFirstValue && setAmountTextHeightSecondValue)
                {
                    AmountText.Height = AmountTextHeightFirstValue * (1 - interpolationValue) + AmountTextHeightSecondValue * interpolationValue;
                }
                if (setAmountTextRedFirstValue && setAmountTextRedSecondValue)
                {
                    AmountText.Red = FlatRedBall.Math.MathFunctions.RoundToInt(AmountTextRedFirstValue* (1 - interpolationValue) + AmountTextRedSecondValue * interpolationValue);
                }
                if (setAmountText1BlueFirstValue && setAmountText1BlueSecondValue)
                {
                    AmountText1.Blue = FlatRedBall.Math.MathFunctions.RoundToInt(AmountText1BlueFirstValue* (1 - interpolationValue) + AmountText1BlueSecondValue * interpolationValue);
                }
                if (setAmountText1GreenFirstValue && setAmountText1GreenSecondValue)
                {
                    AmountText1.Green = FlatRedBall.Math.MathFunctions.RoundToInt(AmountText1GreenFirstValue* (1 - interpolationValue) + AmountText1GreenSecondValue * interpolationValue);
                }
                if (setAmountText1HeightFirstValue && setAmountText1HeightSecondValue)
                {
                    AmountText1.Height = AmountText1HeightFirstValue * (1 - interpolationValue) + AmountText1HeightSecondValue * interpolationValue;
                }
                if (setAmountText1RedFirstValue && setAmountText1RedSecondValue)
                {
                    AmountText1.Red = FlatRedBall.Math.MathFunctions.RoundToInt(AmountText1RedFirstValue* (1 - interpolationValue) + AmountText1RedSecondValue * interpolationValue);
                }
                if (setAutoAmountContainerInstanceHeightFirstValue && setAutoAmountContainerInstanceHeightSecondValue)
                {
                    AutoAmountContainerInstance.Height = AutoAmountContainerInstanceHeightFirstValue * (1 - interpolationValue) + AutoAmountContainerInstanceHeightSecondValue * interpolationValue;
                }
                if (setAutoAmountContainerInstanceWidthFirstValue && setAutoAmountContainerInstanceWidthSecondValue)
                {
                    AutoAmountContainerInstance.Width = AutoAmountContainerInstanceWidthFirstValue * (1 - interpolationValue) + AutoAmountContainerInstanceWidthSecondValue * interpolationValue;
                }
                if (setAutoSellButtonInstanceWidthFirstValue && setAutoSellButtonInstanceWidthSecondValue)
                {
                    AutoSellButtonInstance.Width = AutoSellButtonInstanceWidthFirstValue * (1 - interpolationValue) + AutoSellButtonInstanceWidthSecondValue * interpolationValue;
                }
                if (setAutoSellButtonInstanceXFirstValue && setAutoSellButtonInstanceXSecondValue)
                {
                    AutoSellButtonInstance.X = AutoSellButtonInstanceXFirstValue * (1 - interpolationValue) + AutoSellButtonInstanceXSecondValue * interpolationValue;
                }
                if (setAutoSellButtonInstanceYFirstValue && setAutoSellButtonInstanceYSecondValue)
                {
                    AutoSellButtonInstance.Y = AutoSellButtonInstanceYFirstValue * (1 - interpolationValue) + AutoSellButtonInstanceYSecondValue * interpolationValue;
                }
                if (setComboBoxInstanceWidthFirstValue && setComboBoxInstanceWidthSecondValue)
                {
                    ComboBoxInstance.Width = ComboBoxInstanceWidthFirstValue * (1 - interpolationValue) + ComboBoxInstanceWidthSecondValue * interpolationValue;
                }
                if (setContainerInstanceHeightFirstValue && setContainerInstanceHeightSecondValue)
                {
                    ContainerInstance.Height = ContainerInstanceHeightFirstValue * (1 - interpolationValue) + ContainerInstanceHeightSecondValue * interpolationValue;
                }
                if (setContainerInstanceWidthFirstValue && setContainerInstanceWidthSecondValue)
                {
                    ContainerInstance.Width = ContainerInstanceWidthFirstValue * (1 - interpolationValue) + ContainerInstanceWidthSecondValue * interpolationValue;
                }
                if (setContainerInstanceXFirstValue && setContainerInstanceXSecondValue)
                {
                    ContainerInstance.X = ContainerInstanceXFirstValue * (1 - interpolationValue) + ContainerInstanceXSecondValue * interpolationValue;
                }
                if (setContainerInstanceYFirstValue && setContainerInstanceYSecondValue)
                {
                    ContainerInstance.Y = ContainerInstanceYFirstValue * (1 - interpolationValue) + ContainerInstanceYSecondValue * interpolationValue;
                }
                if (setListingBlueFirstValue && setListingBlueSecondValue)
                {
                    Listing.Blue = FlatRedBall.Math.MathFunctions.RoundToInt(ListingBlueFirstValue* (1 - interpolationValue) + ListingBlueSecondValue * interpolationValue);
                }
                if (setListingFontSizeFirstValue && setListingFontSizeSecondValue)
                {
                    Listing.FontSize = FlatRedBall.Math.MathFunctions.RoundToInt(ListingFontSizeFirstValue* (1 - interpolationValue) + ListingFontSizeSecondValue * interpolationValue);
                }
                if (setListingGreenFirstValue && setListingGreenSecondValue)
                {
                    Listing.Green = FlatRedBall.Math.MathFunctions.RoundToInt(ListingGreenFirstValue* (1 - interpolationValue) + ListingGreenSecondValue * interpolationValue);
                }
                if (setListingHeightFirstValue && setListingHeightSecondValue)
                {
                    Listing.Height = ListingHeightFirstValue * (1 - interpolationValue) + ListingHeightSecondValue * interpolationValue;
                }
                if (setListingRedFirstValue && setListingRedSecondValue)
                {
                    Listing.Red = FlatRedBall.Math.MathFunctions.RoundToInt(ListingRedFirstValue* (1 - interpolationValue) + ListingRedSecondValue * interpolationValue);
                }
                if (setListingWidthFirstValue && setListingWidthSecondValue)
                {
                    Listing.Width = ListingWidthFirstValue * (1 - interpolationValue) + ListingWidthSecondValue * interpolationValue;
                }
                if (setMyListingsLabelBackgroundCurrentColorCategoryStateFirstValue && setMyListingsLabelBackgroundCurrentColorCategoryStateSecondValue)
                {
                    MyListingsLabelBackground.InterpolateBetween(MyListingsLabelBackgroundCurrentColorCategoryStateFirstValue, MyListingsLabelBackgroundCurrentColorCategoryStateSecondValue, interpolationValue);
                }
                if (setMyListingsLabelBackgroundHeightFirstValue && setMyListingsLabelBackgroundHeightSecondValue)
                {
                    MyListingsLabelBackground.Height = MyListingsLabelBackgroundHeightFirstValue * (1 - interpolationValue) + MyListingsLabelBackgroundHeightSecondValue * interpolationValue;
                }
                if (setMyListingsLabelBackgroundWidthFirstValue && setMyListingsLabelBackgroundWidthSecondValue)
                {
                    MyListingsLabelBackground.Width = MyListingsLabelBackgroundWidthFirstValue * (1 - interpolationValue) + MyListingsLabelBackgroundWidthSecondValue * interpolationValue;
                }
                if (setMyListingsLabelBackgroundXFirstValue && setMyListingsLabelBackgroundXSecondValue)
                {
                    MyListingsLabelBackground.X = MyListingsLabelBackgroundXFirstValue * (1 - interpolationValue) + MyListingsLabelBackgroundXSecondValue * interpolationValue;
                }
                if (setMyListingsLabelBackgroundYFirstValue && setMyListingsLabelBackgroundYSecondValue)
                {
                    MyListingsLabelBackground.Y = MyListingsLabelBackgroundYFirstValue * (1 - interpolationValue) + MyListingsLabelBackgroundYSecondValue * interpolationValue;
                }
                if (setMyListingsListColoredFrameInstanceAlphaFirstValue && setMyListingsListColoredFrameInstanceAlphaSecondValue)
                {
                    MyListingsList.ColoredFrameInstanceAlpha = FlatRedBall.Math.MathFunctions.RoundToInt(MyListingsListColoredFrameInstanceAlphaFirstValue* (1 - interpolationValue) + MyListingsListColoredFrameInstanceAlphaSecondValue * interpolationValue);
                }
                if (setMyListingsListHeightFirstValue && setMyListingsListHeightSecondValue)
                {
                    MyListingsList.Height = MyListingsListHeightFirstValue * (1 - interpolationValue) + MyListingsListHeightSecondValue * interpolationValue;
                }
                if (setMyListingsListWidthFirstValue && setMyListingsListWidthSecondValue)
                {
                    MyListingsList.Width = MyListingsListWidthFirstValue * (1 - interpolationValue) + MyListingsListWidthSecondValue * interpolationValue;
                }
                if (setMyListingsListYFirstValue && setMyListingsListYSecondValue)
                {
                    MyListingsList.Y = MyListingsListYFirstValue * (1 - interpolationValue) + MyListingsListYSecondValue * interpolationValue;
                }
                if (setMyListingsTextInstanceFontSizeFirstValue && setMyListingsTextInstanceFontSizeSecondValue)
                {
                    MyListingsTextInstance.FontSize = FlatRedBall.Math.MathFunctions.RoundToInt(MyListingsTextInstanceFontSizeFirstValue* (1 - interpolationValue) + MyListingsTextInstanceFontSizeSecondValue * interpolationValue);
                }
                if (setMyListingsTextInstanceHeightFirstValue && setMyListingsTextInstanceHeightSecondValue)
                {
                    MyListingsTextInstance.Height = MyListingsTextInstanceHeightFirstValue * (1 - interpolationValue) + MyListingsTextInstanceHeightSecondValue * interpolationValue;
                }
                if (setMyListingsTextInstanceWidthFirstValue && setMyListingsTextInstanceWidthSecondValue)
                {
                    MyListingsTextInstance.Width = MyListingsTextInstanceWidthFirstValue * (1 - interpolationValue) + MyListingsTextInstanceWidthSecondValue * interpolationValue;
                }
                if (setNewListingBackgroundAlphaFirstValue && setNewListingBackgroundAlphaSecondValue)
                {
                    NewListingBackground.Alpha = FlatRedBall.Math.MathFunctions.RoundToInt(NewListingBackgroundAlphaFirstValue* (1 - interpolationValue) + NewListingBackgroundAlphaSecondValue * interpolationValue);
                }
                if (setNewListingBackgroundCurrentColorCategoryStateFirstValue && setNewListingBackgroundCurrentColorCategoryStateSecondValue)
                {
                    NewListingBackground.InterpolateBetween(NewListingBackgroundCurrentColorCategoryStateFirstValue, NewListingBackgroundCurrentColorCategoryStateSecondValue, interpolationValue);
                }
                if (setNewListingBackgroundHeightFirstValue && setNewListingBackgroundHeightSecondValue)
                {
                    NewListingBackground.Height = NewListingBackgroundHeightFirstValue * (1 - interpolationValue) + NewListingBackgroundHeightSecondValue * interpolationValue;
                }
                if (setNewListingBackgroundWidthFirstValue && setNewListingBackgroundWidthSecondValue)
                {
                    NewListingBackground.Width = NewListingBackgroundWidthFirstValue * (1 - interpolationValue) + NewListingBackgroundWidthSecondValue * interpolationValue;
                }
                if (setNewListingBackgroundXFirstValue && setNewListingBackgroundXSecondValue)
                {
                    NewListingBackground.X = NewListingBackgroundXFirstValue * (1 - interpolationValue) + NewListingBackgroundXSecondValue * interpolationValue;
                }
                if (setNewListingBackgroundYFirstValue && setNewListingBackgroundYSecondValue)
                {
                    NewListingBackground.Y = NewListingBackgroundYFirstValue * (1 - interpolationValue) + NewListingBackgroundYSecondValue * interpolationValue;
                }
                if (setNewLsitingUIContainerHeightFirstValue && setNewLsitingUIContainerHeightSecondValue)
                {
                    NewLsitingUIContainer.Height = NewLsitingUIContainerHeightFirstValue * (1 - interpolationValue) + NewLsitingUIContainerHeightSecondValue * interpolationValue;
                }
                if (setNewLsitingUIContainerWidthFirstValue && setNewLsitingUIContainerWidthSecondValue)
                {
                    NewLsitingUIContainer.Width = NewLsitingUIContainerWidthFirstValue * (1 - interpolationValue) + NewLsitingUIContainerWidthSecondValue * interpolationValue;
                }
                if (setNewLsitingUIContainerXFirstValue && setNewLsitingUIContainerXSecondValue)
                {
                    NewLsitingUIContainer.X = NewLsitingUIContainerXFirstValue * (1 - interpolationValue) + NewLsitingUIContainerXSecondValue * interpolationValue;
                }
                if (setNewLsitingUIContainerYFirstValue && setNewLsitingUIContainerYSecondValue)
                {
                    NewLsitingUIContainer.Y = NewLsitingUIContainerYFirstValue * (1 - interpolationValue) + NewLsitingUIContainerYSecondValue * interpolationValue;
                }
                if (setResourceDisplayInstanceWidthFirstValue && setResourceDisplayInstanceWidthSecondValue)
                {
                    ResourceDisplayInstance.Width = ResourceDisplayInstanceWidthFirstValue * (1 - interpolationValue) + ResourceDisplayInstanceWidthSecondValue * interpolationValue;
                }
                if (setSellAllButtonInstanceWidthFirstValue && setSellAllButtonInstanceWidthSecondValue)
                {
                    SellAllButtonInstance.Width = SellAllButtonInstanceWidthFirstValue * (1 - interpolationValue) + SellAllButtonInstanceWidthSecondValue * interpolationValue;
                }
                if (setSellAllButtonInstanceXFirstValue && setSellAllButtonInstanceXSecondValue)
                {
                    SellAllButtonInstance.X = SellAllButtonInstanceXFirstValue * (1 - interpolationValue) + SellAllButtonInstanceXSecondValue * interpolationValue;
                }
                if (setSellAllButtonInstanceYFirstValue && setSellAllButtonInstanceYSecondValue)
                {
                    SellAllButtonInstance.Y = SellAllButtonInstanceYFirstValue * (1 - interpolationValue) + SellAllButtonInstanceYSecondValue * interpolationValue;
                }
                if (setSellOneButtonInstanceWidthFirstValue && setSellOneButtonInstanceWidthSecondValue)
                {
                    SellOneButtonInstance.Width = SellOneButtonInstanceWidthFirstValue * (1 - interpolationValue) + SellOneButtonInstanceWidthSecondValue * interpolationValue;
                }
                if (setSellOneButtonInstanceXFirstValue && setSellOneButtonInstanceXSecondValue)
                {
                    SellOneButtonInstance.X = SellOneButtonInstanceXFirstValue * (1 - interpolationValue) + SellOneButtonInstanceXSecondValue * interpolationValue;
                }
                if (setSellOneButtonInstanceYFirstValue && setSellOneButtonInstanceYSecondValue)
                {
                    SellOneButtonInstance.Y = SellOneButtonInstanceYFirstValue * (1 - interpolationValue) + SellOneButtonInstanceYSecondValue * interpolationValue;
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
                if (setTextInstanceBlueFirstValue && setTextInstanceBlueSecondValue)
                {
                    TextInstance.Blue = FlatRedBall.Math.MathFunctions.RoundToInt(TextInstanceBlueFirstValue* (1 - interpolationValue) + TextInstanceBlueSecondValue * interpolationValue);
                }
                if (setTextInstanceFontSizeFirstValue && setTextInstanceFontSizeSecondValue)
                {
                    TextInstance.FontSize = FlatRedBall.Math.MathFunctions.RoundToInt(TextInstanceFontSizeFirstValue* (1 - interpolationValue) + TextInstanceFontSizeSecondValue * interpolationValue);
                }
                if (setTextInstanceGreenFirstValue && setTextInstanceGreenSecondValue)
                {
                    TextInstance.Green = FlatRedBall.Math.MathFunctions.RoundToInt(TextInstanceGreenFirstValue* (1 - interpolationValue) + TextInstanceGreenSecondValue * interpolationValue);
                }
                if (setTextInstanceHeightFirstValue && setTextInstanceHeightSecondValue)
                {
                    TextInstance.Height = TextInstanceHeightFirstValue * (1 - interpolationValue) + TextInstanceHeightSecondValue * interpolationValue;
                }
                if (setTextInstanceRedFirstValue && setTextInstanceRedSecondValue)
                {
                    TextInstance.Red = FlatRedBall.Math.MathFunctions.RoundToInt(TextInstanceRedFirstValue* (1 - interpolationValue) + TextInstanceRedSecondValue * interpolationValue);
                }
                if (setTextInstanceWidthFirstValue && setTextInstanceWidthSecondValue)
                {
                    TextInstance.Width = TextInstanceWidthFirstValue * (1 - interpolationValue) + TextInstanceWidthSecondValue * interpolationValue;
                }
                if (setValueTextBlueFirstValue && setValueTextBlueSecondValue)
                {
                    ValueText.Blue = FlatRedBall.Math.MathFunctions.RoundToInt(ValueTextBlueFirstValue* (1 - interpolationValue) + ValueTextBlueSecondValue * interpolationValue);
                }
                if (setValueTextGreenFirstValue && setValueTextGreenSecondValue)
                {
                    ValueText.Green = FlatRedBall.Math.MathFunctions.RoundToInt(ValueTextGreenFirstValue* (1 - interpolationValue) + ValueTextGreenSecondValue * interpolationValue);
                }
                if (setValueTextHeightFirstValue && setValueTextHeightSecondValue)
                {
                    ValueText.Height = ValueTextHeightFirstValue * (1 - interpolationValue) + ValueTextHeightSecondValue * interpolationValue;
                }
                if (setValueTextRedFirstValue && setValueTextRedSecondValue)
                {
                    ValueText.Red = FlatRedBall.Math.MathFunctions.RoundToInt(ValueTextRedFirstValue* (1 - interpolationValue) + ValueTextRedSecondValue * interpolationValue);
                }
                if (setvauleContainerInstanceHeightFirstValue && setvauleContainerInstanceHeightSecondValue)
                {
                    vauleContainerInstance.Height = vauleContainerInstanceHeightFirstValue * (1 - interpolationValue) + vauleContainerInstanceHeightSecondValue * interpolationValue;
                }
                if (setvauleContainerInstanceWidthFirstValue && setvauleContainerInstanceWidthSecondValue)
                {
                    vauleContainerInstance.Width = vauleContainerInstanceWidthFirstValue * (1 - interpolationValue) + vauleContainerInstanceWidthSecondValue * interpolationValue;
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
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (JHP4SD.GumRuntimes.MarketGumRuntime.VariableState fromState,JHP4SD.GumRuntimes.MarketGumRuntime.VariableState toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null) 
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
                MyListingsLabelBackground.StopAnimations();
                MyListingsList.StopAnimations();
                NewListingBackground.StopAnimations();
                ComboBoxInstance.StopAnimations();
                ToSellAmountTextBoxInstance.StopAnimations();
                ResourceDisplayInstance.StopAnimations();
                SellOneButtonInstance.StopAnimations();
                SellAllButtonInstance.StopAnimations();
                AutoSellAmountTextBoxInstance.StopAnimations();
                AutoSellButtonInstance.StopAnimations();
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
                            Name = "MyListingsLabelBackground.ColorCategoryState",
                            Type = "ColorCategoryState",
                            Value = MyListingsLabelBackground.CurrentColorCategoryState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MyListingsLabelBackground.Height",
                            Type = "float",
                            Value = MyListingsLabelBackground.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MyListingsLabelBackground.Width",
                            Type = "float",
                            Value = MyListingsLabelBackground.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MyListingsLabelBackground.Width Units",
                            Type = "DimensionUnitType",
                            Value = MyListingsLabelBackground.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MyListingsLabelBackground.X",
                            Type = "float",
                            Value = MyListingsLabelBackground.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MyListingsLabelBackground.X Origin",
                            Type = "HorizontalAlignment",
                            Value = MyListingsLabelBackground.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MyListingsLabelBackground.X Units",
                            Type = "PositionUnitType",
                            Value = MyListingsLabelBackground.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MyListingsLabelBackground.Y",
                            Type = "float",
                            Value = MyListingsLabelBackground.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MyListingsTextInstance.FontSize",
                            Type = "int",
                            Value = MyListingsTextInstance.FontSize
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MyListingsTextInstance.Height",
                            Type = "float",
                            Value = MyListingsTextInstance.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MyListingsTextInstance.Height Units",
                            Type = "DimensionUnitType",
                            Value = MyListingsTextInstance.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MyListingsTextInstance.Parent",
                            Type = "string",
                            Value = MyListingsTextInstance.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MyListingsTextInstance.Text",
                            Type = "string",
                            Value = MyListingsTextInstance.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MyListingsTextInstance.Width",
                            Type = "float",
                            Value = MyListingsTextInstance.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MyListingsTextInstance.Width Units",
                            Type = "DimensionUnitType",
                            Value = MyListingsTextInstance.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MyListingsTextInstance.X Origin",
                            Type = "HorizontalAlignment",
                            Value = MyListingsTextInstance.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MyListingsTextInstance.X Units",
                            Type = "PositionUnitType",
                            Value = MyListingsTextInstance.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MyListingsTextInstance.Y Origin",
                            Type = "VerticalAlignment",
                            Value = MyListingsTextInstance.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MyListingsTextInstance.Y Units",
                            Type = "PositionUnitType",
                            Value = MyListingsTextInstance.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MyListingsList.ColoredFrameInstanceAlpha",
                            Type = "int",
                            Value = MyListingsList.ColoredFrameInstanceAlpha
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MyListingsList.Height",
                            Type = "float",
                            Value = MyListingsList.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MyListingsList.Height Units",
                            Type = "DimensionUnitType",
                            Value = MyListingsList.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MyListingsList.ListBoxBackgroundColorCategoryState",
                            Type = "ColorCategoryState",
                            Value = MyListingsList.ListBoxBackgroundColorCategoryState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MyListingsList.Width",
                            Type = "float",
                            Value = MyListingsList.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MyListingsList.Width Units",
                            Type = "DimensionUnitType",
                            Value = MyListingsList.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MyListingsList.X Origin",
                            Type = "HorizontalAlignment",
                            Value = MyListingsList.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MyListingsList.X Units",
                            Type = "PositionUnitType",
                            Value = MyListingsList.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MyListingsList.Y",
                            Type = "float",
                            Value = MyListingsList.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NewListingBackground.Alpha",
                            Type = "int",
                            Value = NewListingBackground.Alpha
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NewListingBackground.ColorCategoryState",
                            Type = "ColorCategoryState",
                            Value = NewListingBackground.CurrentColorCategoryState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NewListingBackground.Height",
                            Type = "float",
                            Value = NewListingBackground.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NewListingBackground.Height Units",
                            Type = "DimensionUnitType",
                            Value = NewListingBackground.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NewListingBackground.Width",
                            Type = "float",
                            Value = NewListingBackground.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NewListingBackground.Width Units",
                            Type = "DimensionUnitType",
                            Value = NewListingBackground.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NewListingBackground.X",
                            Type = "float",
                            Value = NewListingBackground.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NewListingBackground.X Origin",
                            Type = "HorizontalAlignment",
                            Value = NewListingBackground.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NewListingBackground.X Units",
                            Type = "PositionUnitType",
                            Value = NewListingBackground.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NewListingBackground.Y",
                            Type = "float",
                            Value = NewListingBackground.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NewLsitingUIContainer.Children Layout",
                            Type = "ChildrenLayout",
                            Value = NewLsitingUIContainer.ChildrenLayout
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NewLsitingUIContainer.Height",
                            Type = "float",
                            Value = NewLsitingUIContainer.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NewLsitingUIContainer.Height Units",
                            Type = "DimensionUnitType",
                            Value = NewLsitingUIContainer.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NewLsitingUIContainer.Parent",
                            Type = "string",
                            Value = NewLsitingUIContainer.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NewLsitingUIContainer.Width",
                            Type = "float",
                            Value = NewLsitingUIContainer.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NewLsitingUIContainer.Width Units",
                            Type = "DimensionUnitType",
                            Value = NewLsitingUIContainer.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NewLsitingUIContainer.X",
                            Type = "float",
                            Value = NewLsitingUIContainer.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NewLsitingUIContainer.X Origin",
                            Type = "HorizontalAlignment",
                            Value = NewLsitingUIContainer.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NewLsitingUIContainer.X Units",
                            Type = "PositionUnitType",
                            Value = NewLsitingUIContainer.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NewLsitingUIContainer.Y",
                            Type = "float",
                            Value = NewLsitingUIContainer.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NewLsitingUIContainer.Y Origin",
                            Type = "VerticalAlignment",
                            Value = NewLsitingUIContainer.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NewLsitingUIContainer.Y Units",
                            Type = "PositionUnitType",
                            Value = NewLsitingUIContainer.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Blue",
                            Type = "int",
                            Value = TextInstance.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.FontSize",
                            Type = "int",
                            Value = TextInstance.FontSize
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Green",
                            Type = "int",
                            Value = TextInstance.Green
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
                            Name = "TextInstance.Parent",
                            Type = "string",
                            Value = TextInstance.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Red",
                            Type = "int",
                            Value = TextInstance.Red
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
                            Name = "ComboBoxInstance.Parent",
                            Type = "string",
                            Value = ComboBoxInstance.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ComboBoxInstance.Width",
                            Type = "float",
                            Value = ComboBoxInstance.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ComboBoxInstance.Width Units",
                            Type = "DimensionUnitType",
                            Value = ComboBoxInstance.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ToSellAmountTextBoxInstance.Parent",
                            Type = "string",
                            Value = ToSellAmountTextBoxInstance.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ToSellAmountTextBoxInstance.Text",
                            Type = "string",
                            Value = ToSellAmountTextBoxInstance.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ToSellAmountTextBoxInstance.X Origin",
                            Type = "HorizontalAlignment",
                            Value = ToSellAmountTextBoxInstance.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ToSellAmountTextBoxInstance.X Units",
                            Type = "PositionUnitType",
                            Value = ToSellAmountTextBoxInstance.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AmountContainerInstance.Height",
                            Type = "float",
                            Value = AmountContainerInstance.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AmountContainerInstance.Height Units",
                            Type = "DimensionUnitType",
                            Value = AmountContainerInstance.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AmountContainerInstance.Parent",
                            Type = "string",
                            Value = AmountContainerInstance.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AmountContainerInstance.Width",
                            Type = "float",
                            Value = AmountContainerInstance.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AmountContainerInstance.Width Units",
                            Type = "DimensionUnitType",
                            Value = AmountContainerInstance.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "vauleContainerInstance.Height",
                            Type = "float",
                            Value = vauleContainerInstance.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "vauleContainerInstance.Height Units",
                            Type = "DimensionUnitType",
                            Value = vauleContainerInstance.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "vauleContainerInstance.Parent",
                            Type = "string",
                            Value = vauleContainerInstance.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "vauleContainerInstance.Width",
                            Type = "float",
                            Value = vauleContainerInstance.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "vauleContainerInstance.Width Units",
                            Type = "DimensionUnitType",
                            Value = vauleContainerInstance.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AmountText.Blue",
                            Type = "int",
                            Value = AmountText.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AmountText.Green",
                            Type = "int",
                            Value = AmountText.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AmountText.Height",
                            Type = "float",
                            Value = AmountText.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AmountText.Height Units",
                            Type = "DimensionUnitType",
                            Value = AmountText.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AmountText.Parent",
                            Type = "string",
                            Value = AmountText.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AmountText.Red",
                            Type = "int",
                            Value = AmountText.Red
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AmountText.Text",
                            Type = "string",
                            Value = AmountText.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AmountText.VerticalAlignment",
                            Type = "VerticalAlignment",
                            Value = AmountText.VerticalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ValueText.Blue",
                            Type = "int",
                            Value = ValueText.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ValueText.Green",
                            Type = "int",
                            Value = ValueText.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ValueText.Height",
                            Type = "float",
                            Value = ValueText.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ValueText.HorizontalAlignment",
                            Type = "HorizontalAlignment",
                            Value = ValueText.HorizontalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ValueText.Parent",
                            Type = "string",
                            Value = ValueText.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ValueText.Red",
                            Type = "int",
                            Value = ValueText.Red
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ValueText.Text",
                            Type = "string",
                            Value = ValueText.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ValueText.VerticalAlignment",
                            Type = "VerticalAlignment",
                            Value = ValueText.VerticalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResourceDisplayInstance.Parent",
                            Type = "string",
                            Value = ResourceDisplayInstance.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResourceDisplayInstance.SpriteInstanceSourceFile",
                            Type = "string",
                            Value = ResourceDisplayInstance.SpriteInstanceSourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResourceDisplayInstance.Width",
                            Type = "float",
                            Value = ResourceDisplayInstance.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResourceDisplayInstance.X Origin",
                            Type = "HorizontalAlignment",
                            Value = ResourceDisplayInstance.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResourceDisplayInstance.X Units",
                            Type = "PositionUnitType",
                            Value = ResourceDisplayInstance.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ContainerInstance.Height",
                            Type = "float",
                            Value = ContainerInstance.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ContainerInstance.Height Units",
                            Type = "DimensionUnitType",
                            Value = ContainerInstance.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ContainerInstance.Parent",
                            Type = "string",
                            Value = ContainerInstance.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ContainerInstance.Width",
                            Type = "float",
                            Value = ContainerInstance.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ContainerInstance.Width Units",
                            Type = "DimensionUnitType",
                            Value = ContainerInstance.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ContainerInstance.X",
                            Type = "float",
                            Value = ContainerInstance.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ContainerInstance.Y",
                            Type = "float",
                            Value = ContainerInstance.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SellOneButtonInstance.Parent",
                            Type = "string",
                            Value = SellOneButtonInstance.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SellOneButtonInstance.Text",
                            Type = "string",
                            Value = SellOneButtonInstance.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SellOneButtonInstance.Width",
                            Type = "float",
                            Value = SellOneButtonInstance.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SellOneButtonInstance.Width Units",
                            Type = "DimensionUnitType",
                            Value = SellOneButtonInstance.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SellOneButtonInstance.X",
                            Type = "float",
                            Value = SellOneButtonInstance.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SellOneButtonInstance.Y",
                            Type = "float",
                            Value = SellOneButtonInstance.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SellAllButtonInstance.Parent",
                            Type = "string",
                            Value = SellAllButtonInstance.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SellAllButtonInstance.Text",
                            Type = "string",
                            Value = SellAllButtonInstance.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SellAllButtonInstance.Width",
                            Type = "float",
                            Value = SellAllButtonInstance.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SellAllButtonInstance.Width Units",
                            Type = "DimensionUnitType",
                            Value = SellAllButtonInstance.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SellAllButtonInstance.X",
                            Type = "float",
                            Value = SellAllButtonInstance.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SellAllButtonInstance.X Origin",
                            Type = "HorizontalAlignment",
                            Value = SellAllButtonInstance.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SellAllButtonInstance.X Units",
                            Type = "PositionUnitType",
                            Value = SellAllButtonInstance.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SellAllButtonInstance.Y",
                            Type = "float",
                            Value = SellAllButtonInstance.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Listing.Blue",
                            Type = "int",
                            Value = Listing.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Listing.FontSize",
                            Type = "int",
                            Value = Listing.FontSize
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Listing.Green",
                            Type = "int",
                            Value = Listing.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Listing.Height",
                            Type = "float",
                            Value = Listing.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Listing.Height Units",
                            Type = "DimensionUnitType",
                            Value = Listing.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Listing.Parent",
                            Type = "string",
                            Value = Listing.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Listing.Red",
                            Type = "int",
                            Value = Listing.Red
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Listing.Text",
                            Type = "string",
                            Value = Listing.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Listing.Width",
                            Type = "float",
                            Value = Listing.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Listing.Width Units",
                            Type = "DimensionUnitType",
                            Value = Listing.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Listing.X Origin",
                            Type = "HorizontalAlignment",
                            Value = Listing.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Listing.X Units",
                            Type = "PositionUnitType",
                            Value = Listing.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AutoAmountContainerInstance.Height",
                            Type = "float",
                            Value = AutoAmountContainerInstance.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AutoAmountContainerInstance.Height Units",
                            Type = "DimensionUnitType",
                            Value = AutoAmountContainerInstance.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AutoAmountContainerInstance.Parent",
                            Type = "string",
                            Value = AutoAmountContainerInstance.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AutoAmountContainerInstance.Width",
                            Type = "float",
                            Value = AutoAmountContainerInstance.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AutoAmountContainerInstance.Width Units",
                            Type = "DimensionUnitType",
                            Value = AutoAmountContainerInstance.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AmountText1.Blue",
                            Type = "int",
                            Value = AmountText1.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AmountText1.Green",
                            Type = "int",
                            Value = AmountText1.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AmountText1.Height",
                            Type = "float",
                            Value = AmountText1.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AmountText1.Height Units",
                            Type = "DimensionUnitType",
                            Value = AmountText1.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AmountText1.Parent",
                            Type = "string",
                            Value = AmountText1.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AmountText1.Red",
                            Type = "int",
                            Value = AmountText1.Red
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AmountText1.Text",
                            Type = "string",
                            Value = AmountText1.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AmountText1.VerticalAlignment",
                            Type = "VerticalAlignment",
                            Value = AmountText1.VerticalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AutoSellAmountTextBoxInstance.Parent",
                            Type = "string",
                            Value = AutoSellAmountTextBoxInstance.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AutoSellAmountTextBoxInstance.Text",
                            Type = "string",
                            Value = AutoSellAmountTextBoxInstance.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AutoSellAmountTextBoxInstance.X Origin",
                            Type = "HorizontalAlignment",
                            Value = AutoSellAmountTextBoxInstance.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AutoSellAmountTextBoxInstance.X Units",
                            Type = "PositionUnitType",
                            Value = AutoSellAmountTextBoxInstance.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AutoSellButtonInstance.Parent",
                            Type = "string",
                            Value = AutoSellButtonInstance.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AutoSellButtonInstance.Text",
                            Type = "string",
                            Value = AutoSellButtonInstance.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AutoSellButtonInstance.Width",
                            Type = "float",
                            Value = AutoSellButtonInstance.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AutoSellButtonInstance.Width Units",
                            Type = "DimensionUnitType",
                            Value = AutoSellButtonInstance.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AutoSellButtonInstance.X",
                            Type = "float",
                            Value = AutoSellButtonInstance.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AutoSellButtonInstance.Y",
                            Type = "float",
                            Value = AutoSellButtonInstance.Y
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
                            Name = "MyListingsLabelBackground.ColorCategoryState",
                            Type = "ColorCategoryState",
                            Value = MyListingsLabelBackground.CurrentColorCategoryState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MyListingsLabelBackground.Height",
                            Type = "float",
                            Value = MyListingsLabelBackground.Height + 72f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MyListingsLabelBackground.Width",
                            Type = "float",
                            Value = MyListingsLabelBackground.Width + 750f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MyListingsLabelBackground.Width Units",
                            Type = "DimensionUnitType",
                            Value = MyListingsLabelBackground.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MyListingsLabelBackground.X",
                            Type = "float",
                            Value = MyListingsLabelBackground.X + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MyListingsLabelBackground.X Origin",
                            Type = "HorizontalAlignment",
                            Value = MyListingsLabelBackground.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MyListingsLabelBackground.X Units",
                            Type = "PositionUnitType",
                            Value = MyListingsLabelBackground.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MyListingsLabelBackground.Y",
                            Type = "float",
                            Value = MyListingsLabelBackground.Y + 72f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MyListingsTextInstance.FontSize",
                            Type = "int",
                            Value = MyListingsTextInstance.FontSize + 48
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MyListingsTextInstance.Height",
                            Type = "float",
                            Value = MyListingsTextInstance.Height + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MyListingsTextInstance.Height Units",
                            Type = "DimensionUnitType",
                            Value = MyListingsTextInstance.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MyListingsTextInstance.Parent",
                            Type = "string",
                            Value = MyListingsTextInstance.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MyListingsTextInstance.Text",
                            Type = "string",
                            Value = MyListingsTextInstance.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MyListingsTextInstance.Width",
                            Type = "float",
                            Value = MyListingsTextInstance.Width + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MyListingsTextInstance.Width Units",
                            Type = "DimensionUnitType",
                            Value = MyListingsTextInstance.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MyListingsTextInstance.X Origin",
                            Type = "HorizontalAlignment",
                            Value = MyListingsTextInstance.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MyListingsTextInstance.X Units",
                            Type = "PositionUnitType",
                            Value = MyListingsTextInstance.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MyListingsTextInstance.Y Origin",
                            Type = "VerticalAlignment",
                            Value = MyListingsTextInstance.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MyListingsTextInstance.Y Units",
                            Type = "PositionUnitType",
                            Value = MyListingsTextInstance.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MyListingsList.ColoredFrameInstanceAlpha",
                            Type = "int",
                            Value = MyListingsList.ColoredFrameInstanceAlpha + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MyListingsList.Height",
                            Type = "float",
                            Value = MyListingsList.Height + -216f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MyListingsList.Height Units",
                            Type = "DimensionUnitType",
                            Value = MyListingsList.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MyListingsList.ListBoxBackgroundColorCategoryState",
                            Type = "ColorCategoryState",
                            Value = MyListingsList.ListBoxBackgroundColorCategoryState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MyListingsList.Width",
                            Type = "float",
                            Value = MyListingsList.Width + 750f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MyListingsList.Width Units",
                            Type = "DimensionUnitType",
                            Value = MyListingsList.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MyListingsList.X Origin",
                            Type = "HorizontalAlignment",
                            Value = MyListingsList.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MyListingsList.X Units",
                            Type = "PositionUnitType",
                            Value = MyListingsList.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MyListingsList.Y",
                            Type = "float",
                            Value = MyListingsList.Y + 144f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NewListingBackground.Alpha",
                            Type = "int",
                            Value = NewListingBackground.Alpha + 128
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NewListingBackground.ColorCategoryState",
                            Type = "ColorCategoryState",
                            Value = NewListingBackground.CurrentColorCategoryState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NewListingBackground.Height",
                            Type = "float",
                            Value = NewListingBackground.Height + -272f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NewListingBackground.Height Units",
                            Type = "DimensionUnitType",
                            Value = NewListingBackground.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NewListingBackground.Width",
                            Type = "float",
                            Value = NewListingBackground.Width + 400f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NewListingBackground.Width Units",
                            Type = "DimensionUnitType",
                            Value = NewListingBackground.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NewListingBackground.X",
                            Type = "float",
                            Value = NewListingBackground.X + -760f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NewListingBackground.X Origin",
                            Type = "HorizontalAlignment",
                            Value = NewListingBackground.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NewListingBackground.X Units",
                            Type = "PositionUnitType",
                            Value = NewListingBackground.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NewListingBackground.Y",
                            Type = "float",
                            Value = NewListingBackground.Y + 72f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NewLsitingUIContainer.Children Layout",
                            Type = "ChildrenLayout",
                            Value = NewLsitingUIContainer.ChildrenLayout
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NewLsitingUIContainer.Height",
                            Type = "float",
                            Value = NewLsitingUIContainer.Height + -40f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NewLsitingUIContainer.Height Units",
                            Type = "DimensionUnitType",
                            Value = NewLsitingUIContainer.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NewLsitingUIContainer.Parent",
                            Type = "string",
                            Value = NewLsitingUIContainer.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NewLsitingUIContainer.Width",
                            Type = "float",
                            Value = NewLsitingUIContainer.Width + -40f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NewLsitingUIContainer.Width Units",
                            Type = "DimensionUnitType",
                            Value = NewLsitingUIContainer.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NewLsitingUIContainer.X",
                            Type = "float",
                            Value = NewLsitingUIContainer.X + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NewLsitingUIContainer.X Origin",
                            Type = "HorizontalAlignment",
                            Value = NewLsitingUIContainer.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NewLsitingUIContainer.X Units",
                            Type = "PositionUnitType",
                            Value = NewLsitingUIContainer.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NewLsitingUIContainer.Y",
                            Type = "float",
                            Value = NewLsitingUIContainer.Y + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NewLsitingUIContainer.Y Origin",
                            Type = "VerticalAlignment",
                            Value = NewLsitingUIContainer.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NewLsitingUIContainer.Y Units",
                            Type = "PositionUnitType",
                            Value = NewLsitingUIContainer.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Blue",
                            Type = "int",
                            Value = TextInstance.Blue + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.FontSize",
                            Type = "int",
                            Value = TextInstance.FontSize + 24
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Green",
                            Type = "int",
                            Value = TextInstance.Green + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Height",
                            Type = "float",
                            Value = TextInstance.Height + 10f
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
                            Name = "TextInstance.Parent",
                            Type = "string",
                            Value = TextInstance.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Red",
                            Type = "int",
                            Value = TextInstance.Red + 0
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
                            Name = "ComboBoxInstance.Parent",
                            Type = "string",
                            Value = ComboBoxInstance.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ComboBoxInstance.Width",
                            Type = "float",
                            Value = ComboBoxInstance.Width + 100f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ComboBoxInstance.Width Units",
                            Type = "DimensionUnitType",
                            Value = ComboBoxInstance.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ToSellAmountTextBoxInstance.Parent",
                            Type = "string",
                            Value = ToSellAmountTextBoxInstance.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ToSellAmountTextBoxInstance.Text",
                            Type = "string",
                            Value = ToSellAmountTextBoxInstance.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ToSellAmountTextBoxInstance.X Origin",
                            Type = "HorizontalAlignment",
                            Value = ToSellAmountTextBoxInstance.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ToSellAmountTextBoxInstance.X Units",
                            Type = "PositionUnitType",
                            Value = ToSellAmountTextBoxInstance.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AmountContainerInstance.Height",
                            Type = "float",
                            Value = AmountContainerInstance.Height + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AmountContainerInstance.Height Units",
                            Type = "DimensionUnitType",
                            Value = AmountContainerInstance.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AmountContainerInstance.Parent",
                            Type = "string",
                            Value = AmountContainerInstance.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AmountContainerInstance.Width",
                            Type = "float",
                            Value = AmountContainerInstance.Width + 100f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AmountContainerInstance.Width Units",
                            Type = "DimensionUnitType",
                            Value = AmountContainerInstance.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "vauleContainerInstance.Height",
                            Type = "float",
                            Value = vauleContainerInstance.Height + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "vauleContainerInstance.Height Units",
                            Type = "DimensionUnitType",
                            Value = vauleContainerInstance.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "vauleContainerInstance.Parent",
                            Type = "string",
                            Value = vauleContainerInstance.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "vauleContainerInstance.Width",
                            Type = "float",
                            Value = vauleContainerInstance.Width + 100f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "vauleContainerInstance.Width Units",
                            Type = "DimensionUnitType",
                            Value = vauleContainerInstance.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AmountText.Blue",
                            Type = "int",
                            Value = AmountText.Blue + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AmountText.Green",
                            Type = "int",
                            Value = AmountText.Green + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AmountText.Height",
                            Type = "float",
                            Value = AmountText.Height + 30f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AmountText.Height Units",
                            Type = "DimensionUnitType",
                            Value = AmountText.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AmountText.Parent",
                            Type = "string",
                            Value = AmountText.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AmountText.Red",
                            Type = "int",
                            Value = AmountText.Red + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AmountText.Text",
                            Type = "string",
                            Value = AmountText.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AmountText.VerticalAlignment",
                            Type = "VerticalAlignment",
                            Value = AmountText.VerticalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ValueText.Blue",
                            Type = "int",
                            Value = ValueText.Blue + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ValueText.Green",
                            Type = "int",
                            Value = ValueText.Green + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ValueText.Height",
                            Type = "float",
                            Value = ValueText.Height + 40f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ValueText.HorizontalAlignment",
                            Type = "HorizontalAlignment",
                            Value = ValueText.HorizontalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ValueText.Parent",
                            Type = "string",
                            Value = ValueText.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ValueText.Red",
                            Type = "int",
                            Value = ValueText.Red + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ValueText.Text",
                            Type = "string",
                            Value = ValueText.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ValueText.VerticalAlignment",
                            Type = "VerticalAlignment",
                            Value = ValueText.VerticalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResourceDisplayInstance.Parent",
                            Type = "string",
                            Value = ResourceDisplayInstance.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResourceDisplayInstance.SpriteInstanceSourceFile",
                            Type = "string",
                            Value = ResourceDisplayInstance.SpriteInstanceSourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResourceDisplayInstance.Width",
                            Type = "float",
                            Value = ResourceDisplayInstance.Width + 220f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResourceDisplayInstance.X Origin",
                            Type = "HorizontalAlignment",
                            Value = ResourceDisplayInstance.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResourceDisplayInstance.X Units",
                            Type = "PositionUnitType",
                            Value = ResourceDisplayInstance.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ContainerInstance.Height",
                            Type = "float",
                            Value = ContainerInstance.Height + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ContainerInstance.Height Units",
                            Type = "DimensionUnitType",
                            Value = ContainerInstance.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ContainerInstance.Parent",
                            Type = "string",
                            Value = ContainerInstance.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ContainerInstance.Width",
                            Type = "float",
                            Value = ContainerInstance.Width + 100f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ContainerInstance.Width Units",
                            Type = "DimensionUnitType",
                            Value = ContainerInstance.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ContainerInstance.X",
                            Type = "float",
                            Value = ContainerInstance.X + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ContainerInstance.Y",
                            Type = "float",
                            Value = ContainerInstance.Y + 10f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SellOneButtonInstance.Parent",
                            Type = "string",
                            Value = SellOneButtonInstance.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SellOneButtonInstance.Text",
                            Type = "string",
                            Value = SellOneButtonInstance.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SellOneButtonInstance.Width",
                            Type = "float",
                            Value = SellOneButtonInstance.Width + 50f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SellOneButtonInstance.Width Units",
                            Type = "DimensionUnitType",
                            Value = SellOneButtonInstance.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SellOneButtonInstance.X",
                            Type = "float",
                            Value = SellOneButtonInstance.X + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SellOneButtonInstance.Y",
                            Type = "float",
                            Value = SellOneButtonInstance.Y + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SellAllButtonInstance.Parent",
                            Type = "string",
                            Value = SellAllButtonInstance.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SellAllButtonInstance.Text",
                            Type = "string",
                            Value = SellAllButtonInstance.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SellAllButtonInstance.Width",
                            Type = "float",
                            Value = SellAllButtonInstance.Width + 50f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SellAllButtonInstance.Width Units",
                            Type = "DimensionUnitType",
                            Value = SellAllButtonInstance.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SellAllButtonInstance.X",
                            Type = "float",
                            Value = SellAllButtonInstance.X + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SellAllButtonInstance.X Origin",
                            Type = "HorizontalAlignment",
                            Value = SellAllButtonInstance.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SellAllButtonInstance.X Units",
                            Type = "PositionUnitType",
                            Value = SellAllButtonInstance.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SellAllButtonInstance.Y",
                            Type = "float",
                            Value = SellAllButtonInstance.Y + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Listing.Blue",
                            Type = "int",
                            Value = Listing.Blue + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Listing.FontSize",
                            Type = "int",
                            Value = Listing.FontSize + 24
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Listing.Green",
                            Type = "int",
                            Value = Listing.Green + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Listing.Height",
                            Type = "float",
                            Value = Listing.Height + 10f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Listing.Height Units",
                            Type = "DimensionUnitType",
                            Value = Listing.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Listing.Parent",
                            Type = "string",
                            Value = Listing.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Listing.Red",
                            Type = "int",
                            Value = Listing.Red + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Listing.Text",
                            Type = "string",
                            Value = Listing.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Listing.Width",
                            Type = "float",
                            Value = Listing.Width + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Listing.Width Units",
                            Type = "DimensionUnitType",
                            Value = Listing.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Listing.X Origin",
                            Type = "HorizontalAlignment",
                            Value = Listing.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Listing.X Units",
                            Type = "PositionUnitType",
                            Value = Listing.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AutoAmountContainerInstance.Height",
                            Type = "float",
                            Value = AutoAmountContainerInstance.Height + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AutoAmountContainerInstance.Height Units",
                            Type = "DimensionUnitType",
                            Value = AutoAmountContainerInstance.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AutoAmountContainerInstance.Parent",
                            Type = "string",
                            Value = AutoAmountContainerInstance.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AutoAmountContainerInstance.Width",
                            Type = "float",
                            Value = AutoAmountContainerInstance.Width + 100f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AutoAmountContainerInstance.Width Units",
                            Type = "DimensionUnitType",
                            Value = AutoAmountContainerInstance.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AmountText1.Blue",
                            Type = "int",
                            Value = AmountText1.Blue + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AmountText1.Green",
                            Type = "int",
                            Value = AmountText1.Green + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AmountText1.Height",
                            Type = "float",
                            Value = AmountText1.Height + 30f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AmountText1.Height Units",
                            Type = "DimensionUnitType",
                            Value = AmountText1.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AmountText1.Parent",
                            Type = "string",
                            Value = AmountText1.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AmountText1.Red",
                            Type = "int",
                            Value = AmountText1.Red + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AmountText1.Text",
                            Type = "string",
                            Value = AmountText1.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AmountText1.VerticalAlignment",
                            Type = "VerticalAlignment",
                            Value = AmountText1.VerticalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AutoSellAmountTextBoxInstance.Parent",
                            Type = "string",
                            Value = AutoSellAmountTextBoxInstance.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AutoSellAmountTextBoxInstance.Text",
                            Type = "string",
                            Value = AutoSellAmountTextBoxInstance.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AutoSellAmountTextBoxInstance.X Origin",
                            Type = "HorizontalAlignment",
                            Value = AutoSellAmountTextBoxInstance.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AutoSellAmountTextBoxInstance.X Units",
                            Type = "PositionUnitType",
                            Value = AutoSellAmountTextBoxInstance.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AutoSellButtonInstance.Parent",
                            Type = "string",
                            Value = AutoSellButtonInstance.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AutoSellButtonInstance.Text",
                            Type = "string",
                            Value = AutoSellButtonInstance.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AutoSellButtonInstance.Width",
                            Type = "float",
                            Value = AutoSellButtonInstance.Width + 100f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AutoSellButtonInstance.Width Units",
                            Type = "DimensionUnitType",
                            Value = AutoSellButtonInstance.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AutoSellButtonInstance.X",
                            Type = "float",
                            Value = AutoSellButtonInstance.X + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AutoSellButtonInstance.Y",
                            Type = "float",
                            Value = AutoSellButtonInstance.Y + 0f
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
            public JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime MyListingsLabelBackground { get; set; }
            public JHP4SD.GumRuntimes.TextRuntime MyListingsTextInstance { get; set; }
            public JHP4SD.GumRuntimes.DefaultForms.ListBoxRuntime MyListingsList { get; set; }
            public JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime NewListingBackground { get; set; }
            public JHP4SD.GumRuntimes.ContainerRuntime NewLsitingUIContainer { get; set; }
            public JHP4SD.GumRuntimes.TextRuntime TextInstance { get; set; }
            public JHP4SD.GumRuntimes.DefaultForms.ComboBoxRuntime ComboBoxInstance { get; set; }
            public JHP4SD.GumRuntimes.DefaultForms.TextBoxRuntime ToSellAmountTextBoxInstance { get; set; }
            public JHP4SD.GumRuntimes.ContainerRuntime AmountContainerInstance { get; set; }
            public JHP4SD.GumRuntimes.ContainerRuntime vauleContainerInstance { get; set; }
            public JHP4SD.GumRuntimes.TextRuntime AmountText { get; set; }
            public JHP4SD.GumRuntimes.TextRuntime ValueText { get; set; }
            public JHP4SD.GumRuntimes.LebegForms.BasicComponents.ResourceDisplayRuntime ResourceDisplayInstance { get; set; }
            public JHP4SD.GumRuntimes.ContainerRuntime ContainerInstance { get; set; }
            public JHP4SD.GumRuntimes.DefaultForms.ButtonRuntime SellOneButtonInstance { get; set; }
            public JHP4SD.GumRuntimes.DefaultForms.ButtonRuntime SellAllButtonInstance { get; set; }
            public JHP4SD.GumRuntimes.TextRuntime Listing { get; set; }
            public JHP4SD.GumRuntimes.ContainerRuntime AutoAmountContainerInstance { get; set; }
            public JHP4SD.GumRuntimes.TextRuntime AmountText1 { get; set; }
            public JHP4SD.GumRuntimes.DefaultForms.TextBoxRuntime AutoSellAmountTextBoxInstance { get; set; }
            public JHP4SD.GumRuntimes.DefaultForms.ButtonRuntime AutoSellButtonInstance { get; set; }
            public MarketGumRuntime (bool fullInstantiation = true, bool tryCreateFormsObject = true) 
            {
                this.tryCreateFormsObject = tryCreateFormsObject;
                if (fullInstantiation)
                {
                    Gum.DataTypes.ElementSave elementSave = Gum.Managers.ObjectFinder.Self.GumProjectSave.Screens.First(item => item.Name == "MarketGum");
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
                MyListingsLabelBackground = this.GetGraphicalUiElementByName("MyListingsLabelBackground") as JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime;
                MyListingsTextInstance = this.GetGraphicalUiElementByName("MyListingsTextInstance") as JHP4SD.GumRuntimes.TextRuntime;
                MyListingsList = this.GetGraphicalUiElementByName("MyListingsList") as JHP4SD.GumRuntimes.DefaultForms.ListBoxRuntime;
                NewListingBackground = this.GetGraphicalUiElementByName("NewListingBackground") as JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime;
                NewLsitingUIContainer = this.GetGraphicalUiElementByName("NewLsitingUIContainer") as JHP4SD.GumRuntimes.ContainerRuntime;
                TextInstance = this.GetGraphicalUiElementByName("TextInstance") as JHP4SD.GumRuntimes.TextRuntime;
                ComboBoxInstance = this.GetGraphicalUiElementByName("ComboBoxInstance") as JHP4SD.GumRuntimes.DefaultForms.ComboBoxRuntime;
                ToSellAmountTextBoxInstance = this.GetGraphicalUiElementByName("ToSellAmountTextBoxInstance") as JHP4SD.GumRuntimes.DefaultForms.TextBoxRuntime;
                AmountContainerInstance = this.GetGraphicalUiElementByName("AmountContainerInstance") as JHP4SD.GumRuntimes.ContainerRuntime;
                vauleContainerInstance = this.GetGraphicalUiElementByName("vauleContainerInstance") as JHP4SD.GumRuntimes.ContainerRuntime;
                AmountText = this.GetGraphicalUiElementByName("AmountText") as JHP4SD.GumRuntimes.TextRuntime;
                ValueText = this.GetGraphicalUiElementByName("ValueText") as JHP4SD.GumRuntimes.TextRuntime;
                ResourceDisplayInstance = this.GetGraphicalUiElementByName("ResourceDisplayInstance") as JHP4SD.GumRuntimes.LebegForms.BasicComponents.ResourceDisplayRuntime;
                ContainerInstance = this.GetGraphicalUiElementByName("ContainerInstance") as JHP4SD.GumRuntimes.ContainerRuntime;
                SellOneButtonInstance = this.GetGraphicalUiElementByName("SellOneButtonInstance") as JHP4SD.GumRuntimes.DefaultForms.ButtonRuntime;
                SellAllButtonInstance = this.GetGraphicalUiElementByName("SellAllButtonInstance") as JHP4SD.GumRuntimes.DefaultForms.ButtonRuntime;
                Listing = this.GetGraphicalUiElementByName("Listing") as JHP4SD.GumRuntimes.TextRuntime;
                AutoAmountContainerInstance = this.GetGraphicalUiElementByName("AutoAmountContainerInstance") as JHP4SD.GumRuntimes.ContainerRuntime;
                AmountText1 = this.GetGraphicalUiElementByName("AmountText1") as JHP4SD.GumRuntimes.TextRuntime;
                AutoSellAmountTextBoxInstance = this.GetGraphicalUiElementByName("AutoSellAmountTextBoxInstance") as JHP4SD.GumRuntimes.DefaultForms.TextBoxRuntime;
                AutoSellButtonInstance = this.GetGraphicalUiElementByName("AutoSellButtonInstance") as JHP4SD.GumRuntimes.DefaultForms.ButtonRuntime;
                if (tryCreateFormsObject)
                {
                    FormsControlAsObject = new JHP4SD.FormsControls.Screens.MarketGumForms(this);
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
            public JHP4SD.FormsControls.Screens.MarketGumForms FormsControl {get => (JHP4SD.FormsControls.Screens.MarketGumForms) FormsControlAsObject;}
        }
    }
