    using System.Linq;
    namespace JHP4SD.GumRuntimes.LebegForms.BasicComponents
    {
        public partial class ListingListBoxItemRuntime : JHP4SD.GumRuntimes.ContainerRuntime
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
                            TextInstance.Parent = this.GetGraphicalUiElementByName("ContainerInstance") ?? this;
                            SellResourceDisplayInstance.Parent = this.GetGraphicalUiElementByName("ContainerInstance") ?? this;
                            TextInstance1.Parent = this.GetGraphicalUiElementByName("ContainerInstance") ?? this;
                            ForResourceDisplayInstance.Parent = this.GetGraphicalUiElementByName("ContainerInstance") ?? this;
                            TextInstance2.Parent = this.GetGraphicalUiElementByName("ContainerInstance") ?? this;
                            AboveResourceDisplayInstance.Parent = this.GetGraphicalUiElementByName("ContainerInstance") ?? this;
                            ButtonInstance.Parent = this.GetGraphicalUiElementByName("ContainerInstance") ?? this;
                            TextInstance.CurrentColorCategoryState = JHP4SD.GumRuntimes.TextRuntime.ColorCategory.Black;
                            TextInstance1.CurrentColorCategoryState = JHP4SD.GumRuntimes.TextRuntime.ColorCategory.Black;
                            TextInstance2.CurrentColorCategoryState = JHP4SD.GumRuntimes.TextRuntime.ColorCategory.Black;
                            Height = 4f;
                            HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
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
                            TextInstance.Height = 40f;
                            TextInstance.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                            TextInstance.Text = "Listing:";
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
                            ContainerInstance.ChildrenLayout = Gum.Managers.ChildrenLayout.LeftToRightStack;
                            ContainerInstance.Height = 40f;
                            ContainerInstance.Width = -8f;
                            ContainerInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                            ContainerInstance.X = 4f;
                            ContainerInstance.Y = 4f;
                            SellResourceDisplayInstance.Width = 100f;
                            SellResourceDisplayInstance.X = 10f;
                            SellResourceDisplayInstance.Y = 0f;
                            TextInstance1.Height = 40f;
                            TextInstance1.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                            TextInstance1.Text = "For:";
                            TextInstance1.VerticalAlignment = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            TextInstance1.Width = 0f;
                            TextInstance1.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                            TextInstance1.X = 8f;
                            TextInstance1.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                            TextInstance1.XUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                            TextInstance1.Y = 0f;
                            TextInstance1.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            TextInstance1.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            SetProperty("ForResourceDisplayInstance.SpriteInstanceSourceFile", "../GlobalContent/Resources/ResourceIcons/money-stack.png");
                            ForResourceDisplayInstance.Width = 150f;
                            ForResourceDisplayInstance.X = 10f;
                            ForResourceDisplayInstance.Y = 0f;
                            TextInstance2.Height = 40f;
                            TextInstance2.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                            TextInstance2.Text = "Above:";
                            TextInstance2.VerticalAlignment = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            TextInstance2.Width = 0f;
                            TextInstance2.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                            TextInstance2.X = 8f;
                            TextInstance2.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                            TextInstance2.XUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                            TextInstance2.Y = 0f;
                            TextInstance2.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            TextInstance2.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            AboveResourceDisplayInstance.Width = 150f;
                            AboveResourceDisplayInstance.X = 10f;
                            AboveResourceDisplayInstance.Y = 0f;
                            ButtonInstance.Height = 40f;
                            ButtonInstance.Text = "Cancel";
                            ButtonInstance.Width = 75f;
                            ButtonInstance.X = 0f;
                            ButtonInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                            ButtonInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                            ButtonInstance.Y = 0f;
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
                                BackgroundInstance.Blue = 255;
                                BackgroundInstance.Green = 255;
                                BackgroundInstance.Red = 255;
                                BackgroundInstance.X = 0f;
                                BackgroundInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                                BackgroundInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                                BackgroundInstance.Y = 0f;
                                BackgroundInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                                BackgroundInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                                RectangleInstance.Visible = false;
                                break;
                            case  ListBoxItemCategory.Highlighted:
                                BackgroundInstance.CurrentColorCategoryState = JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Gray;
                                BackgroundInstance.Blue = 128;
                                BackgroundInstance.Green = 128;
                                BackgroundInstance.Red = 128;
                                BackgroundInstance.X = 0f;
                                BackgroundInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                                BackgroundInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                                BackgroundInstance.Y = 0f;
                                BackgroundInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                                BackgroundInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                                RectangleInstance.Visible = false;
                                break;
                            case  ListBoxItemCategory.Selected:
                                BackgroundInstance.CurrentColorCategoryState = JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Gray;
                                BackgroundInstance.Blue = 170;
                                BackgroundInstance.Green = 205;
                                BackgroundInstance.Red = 102;
                                BackgroundInstance.X = 0f;
                                BackgroundInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                                BackgroundInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                                BackgroundInstance.Y = 0f;
                                BackgroundInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                                BackgroundInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                                RectangleInstance.Visible = false;
                                break;
                            case  ListBoxItemCategory.Focused:
                                BackgroundInstance.CurrentColorCategoryState = JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Gray;
                                BackgroundInstance.Blue = 255;
                                BackgroundInstance.Green = 255;
                                BackgroundInstance.Red = 255;
                                BackgroundInstance.X = 0f;
                                BackgroundInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                                BackgroundInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                                BackgroundInstance.Y = 0f;
                                BackgroundInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                                BackgroundInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
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
                bool setAboveResourceDisplayInstanceWidthFirstValue = false;
                bool setAboveResourceDisplayInstanceWidthSecondValue = false;
                float AboveResourceDisplayInstanceWidthFirstValue= 0;
                float AboveResourceDisplayInstanceWidthSecondValue= 0;
                bool setAboveResourceDisplayInstanceXFirstValue = false;
                bool setAboveResourceDisplayInstanceXSecondValue = false;
                float AboveResourceDisplayInstanceXFirstValue= 0;
                float AboveResourceDisplayInstanceXSecondValue= 0;
                bool setAboveResourceDisplayInstanceYFirstValue = false;
                bool setAboveResourceDisplayInstanceYSecondValue = false;
                float AboveResourceDisplayInstanceYFirstValue= 0;
                float AboveResourceDisplayInstanceYSecondValue= 0;
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
                bool setForResourceDisplayInstanceWidthFirstValue = false;
                bool setForResourceDisplayInstanceWidthSecondValue = false;
                float ForResourceDisplayInstanceWidthFirstValue= 0;
                float ForResourceDisplayInstanceWidthSecondValue= 0;
                bool setForResourceDisplayInstanceXFirstValue = false;
                bool setForResourceDisplayInstanceXSecondValue = false;
                float ForResourceDisplayInstanceXFirstValue= 0;
                float ForResourceDisplayInstanceXSecondValue= 0;
                bool setForResourceDisplayInstanceYFirstValue = false;
                bool setForResourceDisplayInstanceYSecondValue = false;
                float ForResourceDisplayInstanceYFirstValue= 0;
                float ForResourceDisplayInstanceYSecondValue= 0;
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
                bool setSellResourceDisplayInstanceWidthFirstValue = false;
                bool setSellResourceDisplayInstanceWidthSecondValue = false;
                float SellResourceDisplayInstanceWidthFirstValue= 0;
                float SellResourceDisplayInstanceWidthSecondValue= 0;
                bool setSellResourceDisplayInstanceXFirstValue = false;
                bool setSellResourceDisplayInstanceXSecondValue = false;
                float SellResourceDisplayInstanceXFirstValue= 0;
                float SellResourceDisplayInstanceXSecondValue= 0;
                bool setSellResourceDisplayInstanceYFirstValue = false;
                bool setSellResourceDisplayInstanceYSecondValue = false;
                float SellResourceDisplayInstanceYFirstValue= 0;
                float SellResourceDisplayInstanceYSecondValue= 0;
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
                bool setTextInstance1CurrentColorCategoryStateFirstValue = false;
                bool setTextInstance1CurrentColorCategoryStateSecondValue = false;
                JHP4SD.GumRuntimes.TextRuntime.ColorCategory TextInstance1CurrentColorCategoryStateFirstValue= JHP4SD.GumRuntimes.TextRuntime.ColorCategory.Gray;
                JHP4SD.GumRuntimes.TextRuntime.ColorCategory TextInstance1CurrentColorCategoryStateSecondValue= JHP4SD.GumRuntimes.TextRuntime.ColorCategory.Gray;
                bool setTextInstance1HeightFirstValue = false;
                bool setTextInstance1HeightSecondValue = false;
                float TextInstance1HeightFirstValue= 0;
                float TextInstance1HeightSecondValue= 0;
                bool setTextInstance1WidthFirstValue = false;
                bool setTextInstance1WidthSecondValue = false;
                float TextInstance1WidthFirstValue= 0;
                float TextInstance1WidthSecondValue= 0;
                bool setTextInstance1XFirstValue = false;
                bool setTextInstance1XSecondValue = false;
                float TextInstance1XFirstValue= 0;
                float TextInstance1XSecondValue= 0;
                bool setTextInstance1YFirstValue = false;
                bool setTextInstance1YSecondValue = false;
                float TextInstance1YFirstValue= 0;
                float TextInstance1YSecondValue= 0;
                bool setTextInstance2CurrentColorCategoryStateFirstValue = false;
                bool setTextInstance2CurrentColorCategoryStateSecondValue = false;
                JHP4SD.GumRuntimes.TextRuntime.ColorCategory TextInstance2CurrentColorCategoryStateFirstValue= JHP4SD.GumRuntimes.TextRuntime.ColorCategory.Gray;
                JHP4SD.GumRuntimes.TextRuntime.ColorCategory TextInstance2CurrentColorCategoryStateSecondValue= JHP4SD.GumRuntimes.TextRuntime.ColorCategory.Gray;
                bool setTextInstance2HeightFirstValue = false;
                bool setTextInstance2HeightSecondValue = false;
                float TextInstance2HeightFirstValue= 0;
                float TextInstance2HeightSecondValue= 0;
                bool setTextInstance2WidthFirstValue = false;
                bool setTextInstance2WidthSecondValue = false;
                float TextInstance2WidthFirstValue= 0;
                float TextInstance2WidthSecondValue= 0;
                bool setTextInstance2XFirstValue = false;
                bool setTextInstance2XSecondValue = false;
                float TextInstance2XFirstValue= 0;
                float TextInstance2XSecondValue= 0;
                bool setTextInstance2YFirstValue = false;
                bool setTextInstance2YSecondValue = false;
                float TextInstance2YFirstValue= 0;
                float TextInstance2YSecondValue= 0;
                bool setWidthFirstValue = false;
                bool setWidthSecondValue = false;
                float WidthFirstValue= 0;
                float WidthSecondValue= 0;
                switch(firstState)
                {
                    case  VariableState.Default:
                        if (interpolationValue < 1)
                        {
                            this.AboveResourceDisplayInstance.Parent = this.GetGraphicalUiElementByName("ContainerInstance") ?? this;
                        }
                        setAboveResourceDisplayInstanceWidthFirstValue = true;
                        AboveResourceDisplayInstanceWidthFirstValue = 150f;
                        setAboveResourceDisplayInstanceXFirstValue = true;
                        AboveResourceDisplayInstanceXFirstValue = 10f;
                        setAboveResourceDisplayInstanceYFirstValue = true;
                        AboveResourceDisplayInstanceYFirstValue = 0f;
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
                        setButtonInstanceHeightFirstValue = true;
                        ButtonInstanceHeightFirstValue = 40f;
                        if (interpolationValue < 1)
                        {
                            this.ButtonInstance.Parent = this.GetGraphicalUiElementByName("ContainerInstance") ?? this;
                        }
                        if (interpolationValue < 1)
                        {
                            this.ButtonInstance.Text = "Cancel";
                        }
                        setButtonInstanceWidthFirstValue = true;
                        ButtonInstanceWidthFirstValue = 75f;
                        setButtonInstanceXFirstValue = true;
                        ButtonInstanceXFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.ButtonInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                        }
                        if (interpolationValue < 1)
                        {
                            this.ButtonInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                        }
                        setButtonInstanceYFirstValue = true;
                        ButtonInstanceYFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.ContainerInstance.ChildrenLayout = Gum.Managers.ChildrenLayout.LeftToRightStack;
                        }
                        setContainerInstanceHeightFirstValue = true;
                        ContainerInstanceHeightFirstValue = 40f;
                        setContainerInstanceWidthFirstValue = true;
                        ContainerInstanceWidthFirstValue = -8f;
                        if (interpolationValue < 1)
                        {
                            this.ContainerInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        setContainerInstanceXFirstValue = true;
                        ContainerInstanceXFirstValue = 4f;
                        setContainerInstanceYFirstValue = true;
                        ContainerInstanceYFirstValue = 4f;
                        if (interpolationValue < 1)
                        {
                            this.ForResourceDisplayInstance.Parent = this.GetGraphicalUiElementByName("ContainerInstance") ?? this;
                        }
                        if (interpolationValue < 1)
                        {
                            SetProperty("ForResourceDisplayInstance.SpriteInstanceSourceFile", "../GlobalContent/Resources/ResourceIcons/money-stack.png");
                        }
                        setForResourceDisplayInstanceWidthFirstValue = true;
                        ForResourceDisplayInstanceWidthFirstValue = 150f;
                        setForResourceDisplayInstanceXFirstValue = true;
                        ForResourceDisplayInstanceXFirstValue = 10f;
                        setForResourceDisplayInstanceYFirstValue = true;
                        ForResourceDisplayInstanceYFirstValue = 0f;
                        setHeightFirstValue = true;
                        HeightFirstValue = 4f;
                        if (interpolationValue < 1)
                        {
                            this.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                        }
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
                        if (interpolationValue < 1)
                        {
                            this.SellResourceDisplayInstance.Parent = this.GetGraphicalUiElementByName("ContainerInstance") ?? this;
                        }
                        setSellResourceDisplayInstanceWidthFirstValue = true;
                        SellResourceDisplayInstanceWidthFirstValue = 100f;
                        setSellResourceDisplayInstanceXFirstValue = true;
                        SellResourceDisplayInstanceXFirstValue = 10f;
                        setSellResourceDisplayInstanceYFirstValue = true;
                        SellResourceDisplayInstanceYFirstValue = 0f;
                        setTextInstanceCurrentColorCategoryStateFirstValue = true;
                        TextInstanceCurrentColorCategoryStateFirstValue = JHP4SD.GumRuntimes.TextRuntime.ColorCategory.Black;
                        setTextInstanceHeightFirstValue = true;
                        TextInstanceHeightFirstValue = 40f;
                        if (interpolationValue < 1)
                        {
                            this.TextInstance.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                        }
                        if (interpolationValue < 1)
                        {
                            this.TextInstance.Parent = this.GetGraphicalUiElementByName("ContainerInstance") ?? this;
                        }
                        if (interpolationValue < 1)
                        {
                            this.TextInstance.Text = "Listing:";
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
                        setTextInstance1CurrentColorCategoryStateFirstValue = true;
                        TextInstance1CurrentColorCategoryStateFirstValue = JHP4SD.GumRuntimes.TextRuntime.ColorCategory.Black;
                        setTextInstance1HeightFirstValue = true;
                        TextInstance1HeightFirstValue = 40f;
                        if (interpolationValue < 1)
                        {
                            this.TextInstance1.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                        }
                        if (interpolationValue < 1)
                        {
                            this.TextInstance1.Parent = this.GetGraphicalUiElementByName("ContainerInstance") ?? this;
                        }
                        if (interpolationValue < 1)
                        {
                            this.TextInstance1.Text = "For:";
                        }
                        if (interpolationValue < 1)
                        {
                            this.TextInstance1.VerticalAlignment = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        setTextInstance1WidthFirstValue = true;
                        TextInstance1WidthFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.TextInstance1.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                        }
                        setTextInstance1XFirstValue = true;
                        TextInstance1XFirstValue = 8f;
                        if (interpolationValue < 1)
                        {
                            this.TextInstance1.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                        }
                        if (interpolationValue < 1)
                        {
                            this.TextInstance1.XUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                        }
                        setTextInstance1YFirstValue = true;
                        TextInstance1YFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.TextInstance1.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.TextInstance1.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setTextInstance2CurrentColorCategoryStateFirstValue = true;
                        TextInstance2CurrentColorCategoryStateFirstValue = JHP4SD.GumRuntimes.TextRuntime.ColorCategory.Black;
                        setTextInstance2HeightFirstValue = true;
                        TextInstance2HeightFirstValue = 40f;
                        if (interpolationValue < 1)
                        {
                            this.TextInstance2.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                        }
                        if (interpolationValue < 1)
                        {
                            this.TextInstance2.Parent = this.GetGraphicalUiElementByName("ContainerInstance") ?? this;
                        }
                        if (interpolationValue < 1)
                        {
                            this.TextInstance2.Text = "Above:";
                        }
                        if (interpolationValue < 1)
                        {
                            this.TextInstance2.VerticalAlignment = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        setTextInstance2WidthFirstValue = true;
                        TextInstance2WidthFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.TextInstance2.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                        }
                        setTextInstance2XFirstValue = true;
                        TextInstance2XFirstValue = 8f;
                        if (interpolationValue < 1)
                        {
                            this.TextInstance2.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                        }
                        if (interpolationValue < 1)
                        {
                            this.TextInstance2.XUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                        }
                        setTextInstance2YFirstValue = true;
                        TextInstance2YFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.TextInstance2.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.TextInstance2.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
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
                        if (interpolationValue >= 1)
                        {
                            this.AboveResourceDisplayInstance.Parent = this.GetGraphicalUiElementByName("ContainerInstance") ?? this;
                        }
                        setAboveResourceDisplayInstanceWidthSecondValue = true;
                        AboveResourceDisplayInstanceWidthSecondValue = 150f;
                        setAboveResourceDisplayInstanceXSecondValue = true;
                        AboveResourceDisplayInstanceXSecondValue = 10f;
                        setAboveResourceDisplayInstanceYSecondValue = true;
                        AboveResourceDisplayInstanceYSecondValue = 0f;
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
                        setButtonInstanceHeightSecondValue = true;
                        ButtonInstanceHeightSecondValue = 40f;
                        if (interpolationValue >= 1)
                        {
                            this.ButtonInstance.Parent = this.GetGraphicalUiElementByName("ContainerInstance") ?? this;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.ButtonInstance.Text = "Cancel";
                        }
                        setButtonInstanceWidthSecondValue = true;
                        ButtonInstanceWidthSecondValue = 75f;
                        setButtonInstanceXSecondValue = true;
                        ButtonInstanceXSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.ButtonInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.ButtonInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                        }
                        setButtonInstanceYSecondValue = true;
                        ButtonInstanceYSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.ContainerInstance.ChildrenLayout = Gum.Managers.ChildrenLayout.LeftToRightStack;
                        }
                        setContainerInstanceHeightSecondValue = true;
                        ContainerInstanceHeightSecondValue = 40f;
                        setContainerInstanceWidthSecondValue = true;
                        ContainerInstanceWidthSecondValue = -8f;
                        if (interpolationValue >= 1)
                        {
                            this.ContainerInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        setContainerInstanceXSecondValue = true;
                        ContainerInstanceXSecondValue = 4f;
                        setContainerInstanceYSecondValue = true;
                        ContainerInstanceYSecondValue = 4f;
                        if (interpolationValue >= 1)
                        {
                            this.ForResourceDisplayInstance.Parent = this.GetGraphicalUiElementByName("ContainerInstance") ?? this;
                        }
                        if (interpolationValue >= 1)
                        {
                            SetProperty("ForResourceDisplayInstance.SpriteInstanceSourceFile", "../GlobalContent/Resources/ResourceIcons/money-stack.png");
                        }
                        setForResourceDisplayInstanceWidthSecondValue = true;
                        ForResourceDisplayInstanceWidthSecondValue = 150f;
                        setForResourceDisplayInstanceXSecondValue = true;
                        ForResourceDisplayInstanceXSecondValue = 10f;
                        setForResourceDisplayInstanceYSecondValue = true;
                        ForResourceDisplayInstanceYSecondValue = 0f;
                        setHeightSecondValue = true;
                        HeightSecondValue = 4f;
                        if (interpolationValue >= 1)
                        {
                            this.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                        }
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
                        if (interpolationValue >= 1)
                        {
                            this.SellResourceDisplayInstance.Parent = this.GetGraphicalUiElementByName("ContainerInstance") ?? this;
                        }
                        setSellResourceDisplayInstanceWidthSecondValue = true;
                        SellResourceDisplayInstanceWidthSecondValue = 100f;
                        setSellResourceDisplayInstanceXSecondValue = true;
                        SellResourceDisplayInstanceXSecondValue = 10f;
                        setSellResourceDisplayInstanceYSecondValue = true;
                        SellResourceDisplayInstanceYSecondValue = 0f;
                        setTextInstanceCurrentColorCategoryStateSecondValue = true;
                        TextInstanceCurrentColorCategoryStateSecondValue = JHP4SD.GumRuntimes.TextRuntime.ColorCategory.Black;
                        setTextInstanceHeightSecondValue = true;
                        TextInstanceHeightSecondValue = 40f;
                        if (interpolationValue >= 1)
                        {
                            this.TextInstance.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.TextInstance.Parent = this.GetGraphicalUiElementByName("ContainerInstance") ?? this;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.TextInstance.Text = "Listing:";
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
                        setTextInstance1CurrentColorCategoryStateSecondValue = true;
                        TextInstance1CurrentColorCategoryStateSecondValue = JHP4SD.GumRuntimes.TextRuntime.ColorCategory.Black;
                        setTextInstance1HeightSecondValue = true;
                        TextInstance1HeightSecondValue = 40f;
                        if (interpolationValue >= 1)
                        {
                            this.TextInstance1.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.TextInstance1.Parent = this.GetGraphicalUiElementByName("ContainerInstance") ?? this;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.TextInstance1.Text = "For:";
                        }
                        if (interpolationValue >= 1)
                        {
                            this.TextInstance1.VerticalAlignment = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        setTextInstance1WidthSecondValue = true;
                        TextInstance1WidthSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.TextInstance1.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                        }
                        setTextInstance1XSecondValue = true;
                        TextInstance1XSecondValue = 8f;
                        if (interpolationValue >= 1)
                        {
                            this.TextInstance1.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.TextInstance1.XUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                        }
                        setTextInstance1YSecondValue = true;
                        TextInstance1YSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.TextInstance1.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.TextInstance1.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setTextInstance2CurrentColorCategoryStateSecondValue = true;
                        TextInstance2CurrentColorCategoryStateSecondValue = JHP4SD.GumRuntimes.TextRuntime.ColorCategory.Black;
                        setTextInstance2HeightSecondValue = true;
                        TextInstance2HeightSecondValue = 40f;
                        if (interpolationValue >= 1)
                        {
                            this.TextInstance2.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.TextInstance2.Parent = this.GetGraphicalUiElementByName("ContainerInstance") ?? this;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.TextInstance2.Text = "Above:";
                        }
                        if (interpolationValue >= 1)
                        {
                            this.TextInstance2.VerticalAlignment = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        setTextInstance2WidthSecondValue = true;
                        TextInstance2WidthSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.TextInstance2.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                        }
                        setTextInstance2XSecondValue = true;
                        TextInstance2XSecondValue = 8f;
                        if (interpolationValue >= 1)
                        {
                            this.TextInstance2.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.TextInstance2.XUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                        }
                        setTextInstance2YSecondValue = true;
                        TextInstance2YSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.TextInstance2.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.TextInstance2.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
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
                if (setAboveResourceDisplayInstanceWidthFirstValue && setAboveResourceDisplayInstanceWidthSecondValue)
                {
                    AboveResourceDisplayInstance.Width = AboveResourceDisplayInstanceWidthFirstValue * (1 - interpolationValue) + AboveResourceDisplayInstanceWidthSecondValue * interpolationValue;
                }
                if (setAboveResourceDisplayInstanceXFirstValue && setAboveResourceDisplayInstanceXSecondValue)
                {
                    AboveResourceDisplayInstance.X = AboveResourceDisplayInstanceXFirstValue * (1 - interpolationValue) + AboveResourceDisplayInstanceXSecondValue * interpolationValue;
                }
                if (setAboveResourceDisplayInstanceYFirstValue && setAboveResourceDisplayInstanceYSecondValue)
                {
                    AboveResourceDisplayInstance.Y = AboveResourceDisplayInstanceYFirstValue * (1 - interpolationValue) + AboveResourceDisplayInstanceYSecondValue * interpolationValue;
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
                if (setForResourceDisplayInstanceWidthFirstValue && setForResourceDisplayInstanceWidthSecondValue)
                {
                    ForResourceDisplayInstance.Width = ForResourceDisplayInstanceWidthFirstValue * (1 - interpolationValue) + ForResourceDisplayInstanceWidthSecondValue * interpolationValue;
                }
                if (setForResourceDisplayInstanceXFirstValue && setForResourceDisplayInstanceXSecondValue)
                {
                    ForResourceDisplayInstance.X = ForResourceDisplayInstanceXFirstValue * (1 - interpolationValue) + ForResourceDisplayInstanceXSecondValue * interpolationValue;
                }
                if (setForResourceDisplayInstanceYFirstValue && setForResourceDisplayInstanceYSecondValue)
                {
                    ForResourceDisplayInstance.Y = ForResourceDisplayInstanceYFirstValue * (1 - interpolationValue) + ForResourceDisplayInstanceYSecondValue * interpolationValue;
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
                if (setSellResourceDisplayInstanceWidthFirstValue && setSellResourceDisplayInstanceWidthSecondValue)
                {
                    SellResourceDisplayInstance.Width = SellResourceDisplayInstanceWidthFirstValue * (1 - interpolationValue) + SellResourceDisplayInstanceWidthSecondValue * interpolationValue;
                }
                if (setSellResourceDisplayInstanceXFirstValue && setSellResourceDisplayInstanceXSecondValue)
                {
                    SellResourceDisplayInstance.X = SellResourceDisplayInstanceXFirstValue * (1 - interpolationValue) + SellResourceDisplayInstanceXSecondValue * interpolationValue;
                }
                if (setSellResourceDisplayInstanceYFirstValue && setSellResourceDisplayInstanceYSecondValue)
                {
                    SellResourceDisplayInstance.Y = SellResourceDisplayInstanceYFirstValue * (1 - interpolationValue) + SellResourceDisplayInstanceYSecondValue * interpolationValue;
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
                if (setTextInstance1CurrentColorCategoryStateFirstValue && setTextInstance1CurrentColorCategoryStateSecondValue)
                {
                    TextInstance1.InterpolateBetween(TextInstance1CurrentColorCategoryStateFirstValue, TextInstance1CurrentColorCategoryStateSecondValue, interpolationValue);
                }
                if (setTextInstance1HeightFirstValue && setTextInstance1HeightSecondValue)
                {
                    TextInstance1.Height = TextInstance1HeightFirstValue * (1 - interpolationValue) + TextInstance1HeightSecondValue * interpolationValue;
                }
                if (setTextInstance1WidthFirstValue && setTextInstance1WidthSecondValue)
                {
                    TextInstance1.Width = TextInstance1WidthFirstValue * (1 - interpolationValue) + TextInstance1WidthSecondValue * interpolationValue;
                }
                if (setTextInstance1XFirstValue && setTextInstance1XSecondValue)
                {
                    TextInstance1.X = TextInstance1XFirstValue * (1 - interpolationValue) + TextInstance1XSecondValue * interpolationValue;
                }
                if (setTextInstance1YFirstValue && setTextInstance1YSecondValue)
                {
                    TextInstance1.Y = TextInstance1YFirstValue * (1 - interpolationValue) + TextInstance1YSecondValue * interpolationValue;
                }
                if (setTextInstance2CurrentColorCategoryStateFirstValue && setTextInstance2CurrentColorCategoryStateSecondValue)
                {
                    TextInstance2.InterpolateBetween(TextInstance2CurrentColorCategoryStateFirstValue, TextInstance2CurrentColorCategoryStateSecondValue, interpolationValue);
                }
                if (setTextInstance2HeightFirstValue && setTextInstance2HeightSecondValue)
                {
                    TextInstance2.Height = TextInstance2HeightFirstValue * (1 - interpolationValue) + TextInstance2HeightSecondValue * interpolationValue;
                }
                if (setTextInstance2WidthFirstValue && setTextInstance2WidthSecondValue)
                {
                    TextInstance2.Width = TextInstance2WidthFirstValue * (1 - interpolationValue) + TextInstance2WidthSecondValue * interpolationValue;
                }
                if (setTextInstance2XFirstValue && setTextInstance2XSecondValue)
                {
                    TextInstance2.X = TextInstance2XFirstValue * (1 - interpolationValue) + TextInstance2XSecondValue * interpolationValue;
                }
                if (setTextInstance2YFirstValue && setTextInstance2YSecondValue)
                {
                    TextInstance2.Y = TextInstance2YFirstValue * (1 - interpolationValue) + TextInstance2YSecondValue * interpolationValue;
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
                bool setBackgroundInstanceBlueFirstValue = false;
                bool setBackgroundInstanceBlueSecondValue = false;
                int BackgroundInstanceBlueFirstValue= 0;
                int BackgroundInstanceBlueSecondValue= 0;
                bool setBackgroundInstanceCurrentColorCategoryStateFirstValue = false;
                bool setBackgroundInstanceCurrentColorCategoryStateSecondValue = false;
                JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory BackgroundInstanceCurrentColorCategoryStateFirstValue= JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Gray;
                JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory BackgroundInstanceCurrentColorCategoryStateSecondValue= JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Gray;
                bool setBackgroundInstanceGreenFirstValue = false;
                bool setBackgroundInstanceGreenSecondValue = false;
                int BackgroundInstanceGreenFirstValue= 0;
                int BackgroundInstanceGreenSecondValue= 0;
                bool setBackgroundInstanceRedFirstValue = false;
                bool setBackgroundInstanceRedSecondValue = false;
                int BackgroundInstanceRedFirstValue= 0;
                int BackgroundInstanceRedSecondValue= 0;
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
                        setBackgroundInstanceBlueFirstValue = true;
                        BackgroundInstanceBlueFirstValue = 255;
                        setBackgroundInstanceCurrentColorCategoryStateFirstValue = true;
                        BackgroundInstanceCurrentColorCategoryStateFirstValue = JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Gray;
                        setBackgroundInstanceGreenFirstValue = true;
                        BackgroundInstanceGreenFirstValue = 255;
                        setBackgroundInstanceRedFirstValue = true;
                        BackgroundInstanceRedFirstValue = 255;
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
                    case  ListBoxItemCategory.Highlighted:
                        setBackgroundInstanceBlueFirstValue = true;
                        BackgroundInstanceBlueFirstValue = 128;
                        setBackgroundInstanceCurrentColorCategoryStateFirstValue = true;
                        BackgroundInstanceCurrentColorCategoryStateFirstValue = JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Gray;
                        setBackgroundInstanceGreenFirstValue = true;
                        BackgroundInstanceGreenFirstValue = 128;
                        setBackgroundInstanceRedFirstValue = true;
                        BackgroundInstanceRedFirstValue = 128;
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
                        setBackgroundInstanceBlueFirstValue = true;
                        BackgroundInstanceBlueFirstValue = 170;
                        setBackgroundInstanceCurrentColorCategoryStateFirstValue = true;
                        BackgroundInstanceCurrentColorCategoryStateFirstValue = JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Gray;
                        setBackgroundInstanceGreenFirstValue = true;
                        BackgroundInstanceGreenFirstValue = 205;
                        setBackgroundInstanceRedFirstValue = true;
                        BackgroundInstanceRedFirstValue = 102;
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
                    case  ListBoxItemCategory.Focused:
                        setBackgroundInstanceBlueFirstValue = true;
                        BackgroundInstanceBlueFirstValue = 255;
                        setBackgroundInstanceCurrentColorCategoryStateFirstValue = true;
                        BackgroundInstanceCurrentColorCategoryStateFirstValue = JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Gray;
                        setBackgroundInstanceGreenFirstValue = true;
                        BackgroundInstanceGreenFirstValue = 255;
                        setBackgroundInstanceRedFirstValue = true;
                        BackgroundInstanceRedFirstValue = 255;
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
                            this.RectangleInstance.Visible = true;
                        }
                        break;
                }
                switch(secondState)
                {
                    case  ListBoxItemCategory.Enabled:
                        setBackgroundInstanceBlueSecondValue = true;
                        BackgroundInstanceBlueSecondValue = 255;
                        setBackgroundInstanceCurrentColorCategoryStateSecondValue = true;
                        BackgroundInstanceCurrentColorCategoryStateSecondValue = JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Gray;
                        setBackgroundInstanceGreenSecondValue = true;
                        BackgroundInstanceGreenSecondValue = 255;
                        setBackgroundInstanceRedSecondValue = true;
                        BackgroundInstanceRedSecondValue = 255;
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
                    case  ListBoxItemCategory.Highlighted:
                        setBackgroundInstanceBlueSecondValue = true;
                        BackgroundInstanceBlueSecondValue = 128;
                        setBackgroundInstanceCurrentColorCategoryStateSecondValue = true;
                        BackgroundInstanceCurrentColorCategoryStateSecondValue = JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Gray;
                        setBackgroundInstanceGreenSecondValue = true;
                        BackgroundInstanceGreenSecondValue = 128;
                        setBackgroundInstanceRedSecondValue = true;
                        BackgroundInstanceRedSecondValue = 128;
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
                        setBackgroundInstanceBlueSecondValue = true;
                        BackgroundInstanceBlueSecondValue = 170;
                        setBackgroundInstanceCurrentColorCategoryStateSecondValue = true;
                        BackgroundInstanceCurrentColorCategoryStateSecondValue = JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Gray;
                        setBackgroundInstanceGreenSecondValue = true;
                        BackgroundInstanceGreenSecondValue = 205;
                        setBackgroundInstanceRedSecondValue = true;
                        BackgroundInstanceRedSecondValue = 102;
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
                    case  ListBoxItemCategory.Focused:
                        setBackgroundInstanceBlueSecondValue = true;
                        BackgroundInstanceBlueSecondValue = 255;
                        setBackgroundInstanceCurrentColorCategoryStateSecondValue = true;
                        BackgroundInstanceCurrentColorCategoryStateSecondValue = JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Gray;
                        setBackgroundInstanceGreenSecondValue = true;
                        BackgroundInstanceGreenSecondValue = 255;
                        setBackgroundInstanceRedSecondValue = true;
                        BackgroundInstanceRedSecondValue = 255;
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
                            this.RectangleInstance.Visible = true;
                        }
                        break;
                }
                var wasSuppressed = mIsLayoutSuspended;
                if (wasSuppressed == false)
                {
                    SuspendLayout(true);
                }
                if (setBackgroundInstanceBlueFirstValue && setBackgroundInstanceBlueSecondValue)
                {
                    BackgroundInstance.Blue = FlatRedBall.Math.MathFunctions.RoundToInt(BackgroundInstanceBlueFirstValue* (1 - interpolationValue) + BackgroundInstanceBlueSecondValue * interpolationValue);
                }
                if (setBackgroundInstanceCurrentColorCategoryStateFirstValue && setBackgroundInstanceCurrentColorCategoryStateSecondValue)
                {
                    BackgroundInstance.InterpolateBetween(BackgroundInstanceCurrentColorCategoryStateFirstValue, BackgroundInstanceCurrentColorCategoryStateSecondValue, interpolationValue);
                }
                if (setBackgroundInstanceGreenFirstValue && setBackgroundInstanceGreenSecondValue)
                {
                    BackgroundInstance.Green = FlatRedBall.Math.MathFunctions.RoundToInt(BackgroundInstanceGreenFirstValue* (1 - interpolationValue) + BackgroundInstanceGreenSecondValue * interpolationValue);
                }
                if (setBackgroundInstanceRedFirstValue && setBackgroundInstanceRedSecondValue)
                {
                    BackgroundInstance.Red = FlatRedBall.Math.MathFunctions.RoundToInt(BackgroundInstanceRedFirstValue* (1 - interpolationValue) + BackgroundInstanceRedSecondValue * interpolationValue);
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
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (JHP4SD.GumRuntimes.LebegForms.BasicComponents.ListingListBoxItemRuntime.VariableState fromState,JHP4SD.GumRuntimes.LebegForms.BasicComponents.ListingListBoxItemRuntime.VariableState toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null) 
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
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (JHP4SD.GumRuntimes.LebegForms.BasicComponents.ListingListBoxItemRuntime.ListBoxItemCategory fromState,JHP4SD.GumRuntimes.LebegForms.BasicComponents.ListingListBoxItemRuntime.ListBoxItemCategory toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null) 
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
                SellResourceDisplayInstance.StopAnimations();
                ForResourceDisplayInstance.StopAnimations();
                AboveResourceDisplayInstance.StopAnimations();
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
                            Name = "TextInstance.Parent",
                            Type = "string",
                            Value = TextInstance.Parent
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
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ContainerInstance.Children Layout",
                            Type = "ChildrenLayout",
                            Value = ContainerInstance.ChildrenLayout
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
                            Name = "SellResourceDisplayInstance.Parent",
                            Type = "string",
                            Value = SellResourceDisplayInstance.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SellResourceDisplayInstance.Width",
                            Type = "float",
                            Value = SellResourceDisplayInstance.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SellResourceDisplayInstance.X",
                            Type = "float",
                            Value = SellResourceDisplayInstance.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SellResourceDisplayInstance.Y",
                            Type = "float",
                            Value = SellResourceDisplayInstance.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance1.ColorCategoryState",
                            Type = "ColorCategoryState",
                            Value = TextInstance1.CurrentColorCategoryState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance1.Height",
                            Type = "float",
                            Value = TextInstance1.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance1.HorizontalAlignment",
                            Type = "HorizontalAlignment",
                            Value = TextInstance1.HorizontalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance1.Parent",
                            Type = "string",
                            Value = TextInstance1.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance1.Text",
                            Type = "string",
                            Value = TextInstance1.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance1.VerticalAlignment",
                            Type = "VerticalAlignment",
                            Value = TextInstance1.VerticalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance1.Width",
                            Type = "float",
                            Value = TextInstance1.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance1.Width Units",
                            Type = "DimensionUnitType",
                            Value = TextInstance1.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance1.X",
                            Type = "float",
                            Value = TextInstance1.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance1.X Origin",
                            Type = "HorizontalAlignment",
                            Value = TextInstance1.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance1.X Units",
                            Type = "PositionUnitType",
                            Value = TextInstance1.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance1.Y",
                            Type = "float",
                            Value = TextInstance1.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance1.Y Origin",
                            Type = "VerticalAlignment",
                            Value = TextInstance1.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance1.Y Units",
                            Type = "PositionUnitType",
                            Value = TextInstance1.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ForResourceDisplayInstance.Parent",
                            Type = "string",
                            Value = ForResourceDisplayInstance.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ForResourceDisplayInstance.SpriteInstanceSourceFile",
                            Type = "string",
                            Value = ForResourceDisplayInstance.SpriteInstanceSourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ForResourceDisplayInstance.Width",
                            Type = "float",
                            Value = ForResourceDisplayInstance.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ForResourceDisplayInstance.X",
                            Type = "float",
                            Value = ForResourceDisplayInstance.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ForResourceDisplayInstance.Y",
                            Type = "float",
                            Value = ForResourceDisplayInstance.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance2.ColorCategoryState",
                            Type = "ColorCategoryState",
                            Value = TextInstance2.CurrentColorCategoryState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance2.Height",
                            Type = "float",
                            Value = TextInstance2.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance2.HorizontalAlignment",
                            Type = "HorizontalAlignment",
                            Value = TextInstance2.HorizontalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance2.Parent",
                            Type = "string",
                            Value = TextInstance2.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance2.Text",
                            Type = "string",
                            Value = TextInstance2.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance2.VerticalAlignment",
                            Type = "VerticalAlignment",
                            Value = TextInstance2.VerticalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance2.Width",
                            Type = "float",
                            Value = TextInstance2.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance2.Width Units",
                            Type = "DimensionUnitType",
                            Value = TextInstance2.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance2.X",
                            Type = "float",
                            Value = TextInstance2.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance2.X Origin",
                            Type = "HorizontalAlignment",
                            Value = TextInstance2.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance2.X Units",
                            Type = "PositionUnitType",
                            Value = TextInstance2.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance2.Y",
                            Type = "float",
                            Value = TextInstance2.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance2.Y Origin",
                            Type = "VerticalAlignment",
                            Value = TextInstance2.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance2.Y Units",
                            Type = "PositionUnitType",
                            Value = TextInstance2.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AboveResourceDisplayInstance.Parent",
                            Type = "string",
                            Value = AboveResourceDisplayInstance.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AboveResourceDisplayInstance.Width",
                            Type = "float",
                            Value = AboveResourceDisplayInstance.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AboveResourceDisplayInstance.X",
                            Type = "float",
                            Value = AboveResourceDisplayInstance.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AboveResourceDisplayInstance.Y",
                            Type = "float",
                            Value = AboveResourceDisplayInstance.Y
                        }
                        );
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
                            Name = "ButtonInstance.Parent",
                            Type = "string",
                            Value = ButtonInstance.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonInstance.Text",
                            Type = "string",
                            Value = ButtonInstance.Text
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
                            Name = "ButtonInstance.X Origin",
                            Type = "HorizontalAlignment",
                            Value = ButtonInstance.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonInstance.X Units",
                            Type = "PositionUnitType",
                            Value = ButtonInstance.XUnits
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
                            Name = "Height",
                            Type = "float",
                            Value = Height + 4f
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
                            Name = "TextInstance.Height",
                            Type = "float",
                            Value = TextInstance.Height + 40f
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
                            Name = "TextInstance.Parent",
                            Type = "string",
                            Value = TextInstance.Parent
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
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ContainerInstance.Children Layout",
                            Type = "ChildrenLayout",
                            Value = ContainerInstance.ChildrenLayout
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ContainerInstance.Height",
                            Type = "float",
                            Value = ContainerInstance.Height + 40f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ContainerInstance.Width",
                            Type = "float",
                            Value = ContainerInstance.Width + -8f
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
                            Value = ContainerInstance.X + 4f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ContainerInstance.Y",
                            Type = "float",
                            Value = ContainerInstance.Y + 4f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SellResourceDisplayInstance.Parent",
                            Type = "string",
                            Value = SellResourceDisplayInstance.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SellResourceDisplayInstance.Width",
                            Type = "float",
                            Value = SellResourceDisplayInstance.Width + 100f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SellResourceDisplayInstance.X",
                            Type = "float",
                            Value = SellResourceDisplayInstance.X + 10f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SellResourceDisplayInstance.Y",
                            Type = "float",
                            Value = SellResourceDisplayInstance.Y + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance1.ColorCategoryState",
                            Type = "ColorCategoryState",
                            Value = TextInstance1.CurrentColorCategoryState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance1.Height",
                            Type = "float",
                            Value = TextInstance1.Height + 40f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance1.HorizontalAlignment",
                            Type = "HorizontalAlignment",
                            Value = TextInstance1.HorizontalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance1.Parent",
                            Type = "string",
                            Value = TextInstance1.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance1.Text",
                            Type = "string",
                            Value = TextInstance1.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance1.VerticalAlignment",
                            Type = "VerticalAlignment",
                            Value = TextInstance1.VerticalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance1.Width",
                            Type = "float",
                            Value = TextInstance1.Width + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance1.Width Units",
                            Type = "DimensionUnitType",
                            Value = TextInstance1.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance1.X",
                            Type = "float",
                            Value = TextInstance1.X + 8f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance1.X Origin",
                            Type = "HorizontalAlignment",
                            Value = TextInstance1.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance1.X Units",
                            Type = "PositionUnitType",
                            Value = TextInstance1.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance1.Y",
                            Type = "float",
                            Value = TextInstance1.Y + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance1.Y Origin",
                            Type = "VerticalAlignment",
                            Value = TextInstance1.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance1.Y Units",
                            Type = "PositionUnitType",
                            Value = TextInstance1.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ForResourceDisplayInstance.Parent",
                            Type = "string",
                            Value = ForResourceDisplayInstance.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ForResourceDisplayInstance.SpriteInstanceSourceFile",
                            Type = "string",
                            Value = ForResourceDisplayInstance.SpriteInstanceSourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ForResourceDisplayInstance.Width",
                            Type = "float",
                            Value = ForResourceDisplayInstance.Width + 150f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ForResourceDisplayInstance.X",
                            Type = "float",
                            Value = ForResourceDisplayInstance.X + 10f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ForResourceDisplayInstance.Y",
                            Type = "float",
                            Value = ForResourceDisplayInstance.Y + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance2.ColorCategoryState",
                            Type = "ColorCategoryState",
                            Value = TextInstance2.CurrentColorCategoryState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance2.Height",
                            Type = "float",
                            Value = TextInstance2.Height + 40f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance2.HorizontalAlignment",
                            Type = "HorizontalAlignment",
                            Value = TextInstance2.HorizontalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance2.Parent",
                            Type = "string",
                            Value = TextInstance2.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance2.Text",
                            Type = "string",
                            Value = TextInstance2.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance2.VerticalAlignment",
                            Type = "VerticalAlignment",
                            Value = TextInstance2.VerticalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance2.Width",
                            Type = "float",
                            Value = TextInstance2.Width + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance2.Width Units",
                            Type = "DimensionUnitType",
                            Value = TextInstance2.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance2.X",
                            Type = "float",
                            Value = TextInstance2.X + 8f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance2.X Origin",
                            Type = "HorizontalAlignment",
                            Value = TextInstance2.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance2.X Units",
                            Type = "PositionUnitType",
                            Value = TextInstance2.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance2.Y",
                            Type = "float",
                            Value = TextInstance2.Y + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance2.Y Origin",
                            Type = "VerticalAlignment",
                            Value = TextInstance2.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance2.Y Units",
                            Type = "PositionUnitType",
                            Value = TextInstance2.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AboveResourceDisplayInstance.Parent",
                            Type = "string",
                            Value = AboveResourceDisplayInstance.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AboveResourceDisplayInstance.Width",
                            Type = "float",
                            Value = AboveResourceDisplayInstance.Width + 150f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AboveResourceDisplayInstance.X",
                            Type = "float",
                            Value = AboveResourceDisplayInstance.X + 10f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AboveResourceDisplayInstance.Y",
                            Type = "float",
                            Value = AboveResourceDisplayInstance.Y + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonInstance.Height",
                            Type = "float",
                            Value = ButtonInstance.Height + 40f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonInstance.Parent",
                            Type = "string",
                            Value = ButtonInstance.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonInstance.Text",
                            Type = "string",
                            Value = ButtonInstance.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonInstance.Width",
                            Type = "float",
                            Value = ButtonInstance.Width + 75f
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
                            Name = "ButtonInstance.X Origin",
                            Type = "HorizontalAlignment",
                            Value = ButtonInstance.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonInstance.X Units",
                            Type = "PositionUnitType",
                            Value = ButtonInstance.XUnits
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
                            Name = "BackgroundInstance.Blue",
                            Type = "int",
                            Value = BackgroundInstance.Blue
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
                            Name = "BackgroundInstance.Green",
                            Type = "int",
                            Value = BackgroundInstance.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackgroundInstance.Red",
                            Type = "int",
                            Value = BackgroundInstance.Red
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
                    case  ListBoxItemCategory.Highlighted:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackgroundInstance.Blue",
                            Type = "int",
                            Value = BackgroundInstance.Blue
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
                            Name = "BackgroundInstance.Green",
                            Type = "int",
                            Value = BackgroundInstance.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackgroundInstance.Red",
                            Type = "int",
                            Value = BackgroundInstance.Red
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
                            Name = "BackgroundInstance.Blue",
                            Type = "int",
                            Value = BackgroundInstance.Blue
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
                            Name = "BackgroundInstance.Green",
                            Type = "int",
                            Value = BackgroundInstance.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackgroundInstance.Red",
                            Type = "int",
                            Value = BackgroundInstance.Red
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
                    case  ListBoxItemCategory.Focused:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackgroundInstance.Blue",
                            Type = "int",
                            Value = BackgroundInstance.Blue
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
                            Name = "BackgroundInstance.Green",
                            Type = "int",
                            Value = BackgroundInstance.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackgroundInstance.Red",
                            Type = "int",
                            Value = BackgroundInstance.Red
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
                            Name = "BackgroundInstance.Blue",
                            Type = "int",
                            Value = BackgroundInstance.Blue + 255
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
                            Name = "BackgroundInstance.Green",
                            Type = "int",
                            Value = BackgroundInstance.Green + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackgroundInstance.Red",
                            Type = "int",
                            Value = BackgroundInstance.Red + 255
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
                    case  ListBoxItemCategory.Highlighted:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackgroundInstance.Blue",
                            Type = "int",
                            Value = BackgroundInstance.Blue + 128
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
                            Name = "BackgroundInstance.Green",
                            Type = "int",
                            Value = BackgroundInstance.Green + 128
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackgroundInstance.Red",
                            Type = "int",
                            Value = BackgroundInstance.Red + 128
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
                            Name = "BackgroundInstance.Blue",
                            Type = "int",
                            Value = BackgroundInstance.Blue + 170
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
                            Name = "BackgroundInstance.Green",
                            Type = "int",
                            Value = BackgroundInstance.Green + 205
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackgroundInstance.Red",
                            Type = "int",
                            Value = BackgroundInstance.Red + 102
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
                    case  ListBoxItemCategory.Focused:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackgroundInstance.Blue",
                            Type = "int",
                            Value = BackgroundInstance.Blue + 255
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
                            Name = "BackgroundInstance.Green",
                            Type = "int",
                            Value = BackgroundInstance.Green + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackgroundInstance.Red",
                            Type = "int",
                            Value = BackgroundInstance.Red + 255
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
            public JHP4SD.GumRuntimes.ContainerRuntime ContainerInstance { get; set; }
            public JHP4SD.GumRuntimes.LebegForms.BasicComponents.ResourceDisplayRuntime SellResourceDisplayInstance { get; set; }
            public JHP4SD.GumRuntimes.TextRuntime TextInstance1 { get; set; }
            public JHP4SD.GumRuntimes.LebegForms.BasicComponents.ResourceDisplayRuntime ForResourceDisplayInstance { get; set; }
            public JHP4SD.GumRuntimes.TextRuntime TextInstance2 { get; set; }
            public JHP4SD.GumRuntimes.LebegForms.BasicComponents.ResourceDisplayRuntime AboveResourceDisplayInstance { get; set; }
            public JHP4SD.GumRuntimes.DefaultForms.ButtonRuntime ButtonInstance { get; set; }
            public event FlatRedBall.Gui.WindowEvent SellResourceDisplayInstanceClick;
            public event FlatRedBall.Gui.WindowEvent ForResourceDisplayInstanceClick;
            public event FlatRedBall.Gui.WindowEvent AboveResourceDisplayInstanceClick;
            public event FlatRedBall.Gui.WindowEvent ButtonInstanceClick;
            public ListingListBoxItemRuntime (bool fullInstantiation = true, bool tryCreateFormsObject = true) 
            	: base(false, tryCreateFormsObject)
            {
                this.tryCreateFormsObject = tryCreateFormsObject;
                if (fullInstantiation)
                {
                    Gum.DataTypes.ElementSave elementSave = Gum.Managers.ObjectFinder.Self.GumProjectSave.Components.First(item => item.Name == "LebegForms/BasicComponents/ListingListBoxItem");
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
                ContainerInstance = this.GetGraphicalUiElementByName("ContainerInstance") as JHP4SD.GumRuntimes.ContainerRuntime;
                SellResourceDisplayInstance = this.GetGraphicalUiElementByName("SellResourceDisplayInstance") as JHP4SD.GumRuntimes.LebegForms.BasicComponents.ResourceDisplayRuntime;
                TextInstance1 = this.GetGraphicalUiElementByName("TextInstance1") as JHP4SD.GumRuntimes.TextRuntime;
                ForResourceDisplayInstance = this.GetGraphicalUiElementByName("ForResourceDisplayInstance") as JHP4SD.GumRuntimes.LebegForms.BasicComponents.ResourceDisplayRuntime;
                TextInstance2 = this.GetGraphicalUiElementByName("TextInstance2") as JHP4SD.GumRuntimes.TextRuntime;
                AboveResourceDisplayInstance = this.GetGraphicalUiElementByName("AboveResourceDisplayInstance") as JHP4SD.GumRuntimes.LebegForms.BasicComponents.ResourceDisplayRuntime;
                ButtonInstance = this.GetGraphicalUiElementByName("ButtonInstance") as JHP4SD.GumRuntimes.DefaultForms.ButtonRuntime;
                SellResourceDisplayInstance.Click += (unused) => SellResourceDisplayInstanceClick?.Invoke(this);
                ForResourceDisplayInstance.Click += (unused) => ForResourceDisplayInstanceClick?.Invoke(this);
                AboveResourceDisplayInstance.Click += (unused) => AboveResourceDisplayInstanceClick?.Invoke(this);
                ButtonInstance.Click += (unused) => ButtonInstanceClick?.Invoke(this);
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
