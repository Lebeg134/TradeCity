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
                            DialogBoxInstance.Parent = this.GetGraphicalUiElementByName("InfoBar");
                            ResourceBar.CurrentColorCategoryState = JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Gray;
                            InfoBar.CurrentColorCategoryState = JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.TransparentBlack;
                            PlayButtonInstance.Height = 100f;
                            PlayButtonInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.PercentageOfOtherDimension;
                            PlayButtonInstance.Width = 80f;
                            PlayButtonInstance.X = 10f;
                            PlayButtonInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                            PlayButtonInstance.Y = -118f;
                            PlayButtonInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Bottom;
                            PlayButtonInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                            ResourceBar.Blue = 170;
                            ResourceBar.Green = 205;
                            ResourceBar.Height = 72f;
                            ResourceBar.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                            ResourceBar.Red = 102;
                            ResourceBar.Width = 0f;
                            ResourceBar.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                            ResourceBar.X = 0f;
                            ResourceBar.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                            ResourceBar.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            ResourceBar.Y = 0f;
                            ResourceBar.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Top;
                            ResourceBar.YUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                            InfoBar.Blue = 255;
                            InfoBar.Green = 255;
                            InfoBar.Height = 72f;
                            InfoBar.Red = 255;
                            InfoBar.Width = 50f;
                            InfoBar.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            InfoBar.X = 0f;
                            InfoBar.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                            InfoBar.XUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                            InfoBar.Y = 0f;
                            InfoBar.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Bottom;
                            InfoBar.YUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                            BackButtonInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                            BackButtonInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                            BackButtonInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Bottom;
                            BackButtonInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                            DialogBoxInstance.Height = -10f;
                            DialogBoxInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                            DialogBoxInstance.Width = 50f;
                            DialogBoxInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            DialogBoxInstance.X = 5f;
                            DialogBoxInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                            DialogBoxInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                            DialogBoxInstance.Y = 0f;
                            DialogBoxInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            DialogBoxInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            ListBoxInstance.Height = -280f;
                            ListBoxInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                            ListBoxInstance.X = 0f;
                            ListBoxInstance.Y = 72f;
                            ListBoxInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
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
                bool setDialogBoxInstanceHeightFirstValue = false;
                bool setDialogBoxInstanceHeightSecondValue = false;
                float DialogBoxInstanceHeightFirstValue= 0;
                float DialogBoxInstanceHeightSecondValue= 0;
                bool setDialogBoxInstanceWidthFirstValue = false;
                bool setDialogBoxInstanceWidthSecondValue = false;
                float DialogBoxInstanceWidthFirstValue= 0;
                float DialogBoxInstanceWidthSecondValue= 0;
                bool setDialogBoxInstanceXFirstValue = false;
                bool setDialogBoxInstanceXSecondValue = false;
                float DialogBoxInstanceXFirstValue= 0;
                float DialogBoxInstanceXSecondValue= 0;
                bool setDialogBoxInstanceYFirstValue = false;
                bool setDialogBoxInstanceYSecondValue = false;
                float DialogBoxInstanceYFirstValue= 0;
                float DialogBoxInstanceYSecondValue= 0;
                bool setInfoBarBlueFirstValue = false;
                bool setInfoBarBlueSecondValue = false;
                int InfoBarBlueFirstValue= 0;
                int InfoBarBlueSecondValue= 0;
                bool setInfoBarCurrentColorCategoryStateFirstValue = false;
                bool setInfoBarCurrentColorCategoryStateSecondValue = false;
                JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory InfoBarCurrentColorCategoryStateFirstValue= JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Gray;
                JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory InfoBarCurrentColorCategoryStateSecondValue= JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Gray;
                bool setInfoBarGreenFirstValue = false;
                bool setInfoBarGreenSecondValue = false;
                int InfoBarGreenFirstValue= 0;
                int InfoBarGreenSecondValue= 0;
                bool setInfoBarHeightFirstValue = false;
                bool setInfoBarHeightSecondValue = false;
                float InfoBarHeightFirstValue= 0;
                float InfoBarHeightSecondValue= 0;
                bool setInfoBarRedFirstValue = false;
                bool setInfoBarRedSecondValue = false;
                int InfoBarRedFirstValue= 0;
                int InfoBarRedSecondValue= 0;
                bool setInfoBarWidthFirstValue = false;
                bool setInfoBarWidthSecondValue = false;
                float InfoBarWidthFirstValue= 0;
                float InfoBarWidthSecondValue= 0;
                bool setInfoBarXFirstValue = false;
                bool setInfoBarXSecondValue = false;
                float InfoBarXFirstValue= 0;
                float InfoBarXSecondValue= 0;
                bool setInfoBarYFirstValue = false;
                bool setInfoBarYSecondValue = false;
                float InfoBarYFirstValue= 0;
                float InfoBarYSecondValue= 0;
                bool setListBoxInstanceHeightFirstValue = false;
                bool setListBoxInstanceHeightSecondValue = false;
                float ListBoxInstanceHeightFirstValue= 0;
                float ListBoxInstanceHeightSecondValue= 0;
                bool setListBoxInstanceXFirstValue = false;
                bool setListBoxInstanceXSecondValue = false;
                float ListBoxInstanceXFirstValue= 0;
                float ListBoxInstanceXSecondValue= 0;
                bool setListBoxInstanceYFirstValue = false;
                bool setListBoxInstanceYSecondValue = false;
                float ListBoxInstanceYFirstValue= 0;
                float ListBoxInstanceYSecondValue= 0;
                bool setPlayButtonInstanceHeightFirstValue = false;
                bool setPlayButtonInstanceHeightSecondValue = false;
                float PlayButtonInstanceHeightFirstValue= 0;
                float PlayButtonInstanceHeightSecondValue= 0;
                bool setPlayButtonInstanceWidthFirstValue = false;
                bool setPlayButtonInstanceWidthSecondValue = false;
                float PlayButtonInstanceWidthFirstValue= 0;
                float PlayButtonInstanceWidthSecondValue= 0;
                bool setPlayButtonInstanceXFirstValue = false;
                bool setPlayButtonInstanceXSecondValue = false;
                float PlayButtonInstanceXFirstValue= 0;
                float PlayButtonInstanceXSecondValue= 0;
                bool setPlayButtonInstanceYFirstValue = false;
                bool setPlayButtonInstanceYSecondValue = false;
                float PlayButtonInstanceYFirstValue= 0;
                float PlayButtonInstanceYSecondValue= 0;
                bool setResourceBarBlueFirstValue = false;
                bool setResourceBarBlueSecondValue = false;
                int ResourceBarBlueFirstValue= 0;
                int ResourceBarBlueSecondValue= 0;
                bool setResourceBarCurrentColorCategoryStateFirstValue = false;
                bool setResourceBarCurrentColorCategoryStateSecondValue = false;
                JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory ResourceBarCurrentColorCategoryStateFirstValue= JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Gray;
                JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory ResourceBarCurrentColorCategoryStateSecondValue= JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Gray;
                bool setResourceBarGreenFirstValue = false;
                bool setResourceBarGreenSecondValue = false;
                int ResourceBarGreenFirstValue= 0;
                int ResourceBarGreenSecondValue= 0;
                bool setResourceBarHeightFirstValue = false;
                bool setResourceBarHeightSecondValue = false;
                float ResourceBarHeightFirstValue= 0;
                float ResourceBarHeightSecondValue= 0;
                bool setResourceBarRedFirstValue = false;
                bool setResourceBarRedSecondValue = false;
                int ResourceBarRedFirstValue= 0;
                int ResourceBarRedSecondValue= 0;
                bool setResourceBarWidthFirstValue = false;
                bool setResourceBarWidthSecondValue = false;
                float ResourceBarWidthFirstValue= 0;
                float ResourceBarWidthSecondValue= 0;
                bool setResourceBarXFirstValue = false;
                bool setResourceBarXSecondValue = false;
                float ResourceBarXFirstValue= 0;
                float ResourceBarXSecondValue= 0;
                bool setResourceBarYFirstValue = false;
                bool setResourceBarYSecondValue = false;
                float ResourceBarYFirstValue= 0;
                float ResourceBarYSecondValue= 0;
                switch(firstState)
                {
                    case  VariableState.Default:
                        if (interpolationValue < 1)
                        {
                            this.BackButtonInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                        }
                        if (interpolationValue < 1)
                        {
                            this.BackButtonInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                        }
                        if (interpolationValue < 1)
                        {
                            this.BackButtonInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Bottom;
                        }
                        if (interpolationValue < 1)
                        {
                            this.BackButtonInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                        }
                        setDialogBoxInstanceHeightFirstValue = true;
                        DialogBoxInstanceHeightFirstValue = -10f;
                        if (interpolationValue < 1)
                        {
                            this.DialogBoxInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        if (interpolationValue < 1)
                        {
                            this.DialogBoxInstance.Parent = this.GetGraphicalUiElementByName("InfoBar");
                        }
                        setDialogBoxInstanceWidthFirstValue = true;
                        DialogBoxInstanceWidthFirstValue = 50f;
                        if (interpolationValue < 1)
                        {
                            this.DialogBoxInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setDialogBoxInstanceXFirstValue = true;
                        DialogBoxInstanceXFirstValue = 5f;
                        if (interpolationValue < 1)
                        {
                            this.DialogBoxInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                        }
                        if (interpolationValue < 1)
                        {
                            this.DialogBoxInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                        }
                        setDialogBoxInstanceYFirstValue = true;
                        DialogBoxInstanceYFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.DialogBoxInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.DialogBoxInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setInfoBarBlueFirstValue = true;
                        InfoBarBlueFirstValue = 255;
                        setInfoBarCurrentColorCategoryStateFirstValue = true;
                        InfoBarCurrentColorCategoryStateFirstValue = JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.TransparentBlack;
                        setInfoBarGreenFirstValue = true;
                        InfoBarGreenFirstValue = 255;
                        setInfoBarHeightFirstValue = true;
                        InfoBarHeightFirstValue = 72f;
                        setInfoBarRedFirstValue = true;
                        InfoBarRedFirstValue = 255;
                        setInfoBarWidthFirstValue = true;
                        InfoBarWidthFirstValue = 50f;
                        if (interpolationValue < 1)
                        {
                            this.InfoBar.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setInfoBarXFirstValue = true;
                        InfoBarXFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.InfoBar.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                        }
                        if (interpolationValue < 1)
                        {
                            this.InfoBar.XUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                        }
                        setInfoBarYFirstValue = true;
                        InfoBarYFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.InfoBar.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Bottom;
                        }
                        if (interpolationValue < 1)
                        {
                            this.InfoBar.YUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                        }
                        setListBoxInstanceHeightFirstValue = true;
                        ListBoxInstanceHeightFirstValue = -280f;
                        if (interpolationValue < 1)
                        {
                            this.ListBoxInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        setListBoxInstanceXFirstValue = true;
                        ListBoxInstanceXFirstValue = 0f;
                        setListBoxInstanceYFirstValue = true;
                        ListBoxInstanceYFirstValue = 72f;
                        if (interpolationValue < 1)
                        {
                            this.ListBoxInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                        }
                        setPlayButtonInstanceHeightFirstValue = true;
                        PlayButtonInstanceHeightFirstValue = 100f;
                        if (interpolationValue < 1)
                        {
                            this.PlayButtonInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.PercentageOfOtherDimension;
                        }
                        setPlayButtonInstanceWidthFirstValue = true;
                        PlayButtonInstanceWidthFirstValue = 80f;
                        setPlayButtonInstanceXFirstValue = true;
                        PlayButtonInstanceXFirstValue = 10f;
                        if (interpolationValue < 1)
                        {
                            this.PlayButtonInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                        }
                        setPlayButtonInstanceYFirstValue = true;
                        PlayButtonInstanceYFirstValue = -118f;
                        if (interpolationValue < 1)
                        {
                            this.PlayButtonInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Bottom;
                        }
                        if (interpolationValue < 1)
                        {
                            this.PlayButtonInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                        }
                        setResourceBarBlueFirstValue = true;
                        ResourceBarBlueFirstValue = 170;
                        setResourceBarCurrentColorCategoryStateFirstValue = true;
                        ResourceBarCurrentColorCategoryStateFirstValue = JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Gray;
                        setResourceBarGreenFirstValue = true;
                        ResourceBarGreenFirstValue = 205;
                        setResourceBarHeightFirstValue = true;
                        ResourceBarHeightFirstValue = 72f;
                        if (interpolationValue < 1)
                        {
                            this.ResourceBar.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        setResourceBarRedFirstValue = true;
                        ResourceBarRedFirstValue = 102;
                        setResourceBarWidthFirstValue = true;
                        ResourceBarWidthFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.ResourceBar.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        setResourceBarXFirstValue = true;
                        ResourceBarXFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.ResourceBar.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.ResourceBar.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setResourceBarYFirstValue = true;
                        ResourceBarYFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.ResourceBar.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Top;
                        }
                        if (interpolationValue < 1)
                        {
                            this.ResourceBar.YUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                        }
                        break;
                }
                switch(secondState)
                {
                    case  VariableState.Default:
                        if (interpolationValue >= 1)
                        {
                            this.BackButtonInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.BackButtonInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.BackButtonInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Bottom;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.BackButtonInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                        }
                        setDialogBoxInstanceHeightSecondValue = true;
                        DialogBoxInstanceHeightSecondValue = -10f;
                        if (interpolationValue >= 1)
                        {
                            this.DialogBoxInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.DialogBoxInstance.Parent = this.GetGraphicalUiElementByName("InfoBar");
                        }
                        setDialogBoxInstanceWidthSecondValue = true;
                        DialogBoxInstanceWidthSecondValue = 50f;
                        if (interpolationValue >= 1)
                        {
                            this.DialogBoxInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setDialogBoxInstanceXSecondValue = true;
                        DialogBoxInstanceXSecondValue = 5f;
                        if (interpolationValue >= 1)
                        {
                            this.DialogBoxInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.DialogBoxInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                        }
                        setDialogBoxInstanceYSecondValue = true;
                        DialogBoxInstanceYSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.DialogBoxInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.DialogBoxInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setInfoBarBlueSecondValue = true;
                        InfoBarBlueSecondValue = 255;
                        setInfoBarCurrentColorCategoryStateSecondValue = true;
                        InfoBarCurrentColorCategoryStateSecondValue = JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.TransparentBlack;
                        setInfoBarGreenSecondValue = true;
                        InfoBarGreenSecondValue = 255;
                        setInfoBarHeightSecondValue = true;
                        InfoBarHeightSecondValue = 72f;
                        setInfoBarRedSecondValue = true;
                        InfoBarRedSecondValue = 255;
                        setInfoBarWidthSecondValue = true;
                        InfoBarWidthSecondValue = 50f;
                        if (interpolationValue >= 1)
                        {
                            this.InfoBar.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setInfoBarXSecondValue = true;
                        InfoBarXSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.InfoBar.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.InfoBar.XUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                        }
                        setInfoBarYSecondValue = true;
                        InfoBarYSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.InfoBar.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Bottom;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.InfoBar.YUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                        }
                        setListBoxInstanceHeightSecondValue = true;
                        ListBoxInstanceHeightSecondValue = -280f;
                        if (interpolationValue >= 1)
                        {
                            this.ListBoxInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        setListBoxInstanceXSecondValue = true;
                        ListBoxInstanceXSecondValue = 0f;
                        setListBoxInstanceYSecondValue = true;
                        ListBoxInstanceYSecondValue = 72f;
                        if (interpolationValue >= 1)
                        {
                            this.ListBoxInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                        }
                        setPlayButtonInstanceHeightSecondValue = true;
                        PlayButtonInstanceHeightSecondValue = 100f;
                        if (interpolationValue >= 1)
                        {
                            this.PlayButtonInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.PercentageOfOtherDimension;
                        }
                        setPlayButtonInstanceWidthSecondValue = true;
                        PlayButtonInstanceWidthSecondValue = 80f;
                        setPlayButtonInstanceXSecondValue = true;
                        PlayButtonInstanceXSecondValue = 10f;
                        if (interpolationValue >= 1)
                        {
                            this.PlayButtonInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                        }
                        setPlayButtonInstanceYSecondValue = true;
                        PlayButtonInstanceYSecondValue = -118f;
                        if (interpolationValue >= 1)
                        {
                            this.PlayButtonInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Bottom;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.PlayButtonInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                        }
                        setResourceBarBlueSecondValue = true;
                        ResourceBarBlueSecondValue = 170;
                        setResourceBarCurrentColorCategoryStateSecondValue = true;
                        ResourceBarCurrentColorCategoryStateSecondValue = JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Gray;
                        setResourceBarGreenSecondValue = true;
                        ResourceBarGreenSecondValue = 205;
                        setResourceBarHeightSecondValue = true;
                        ResourceBarHeightSecondValue = 72f;
                        if (interpolationValue >= 1)
                        {
                            this.ResourceBar.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        setResourceBarRedSecondValue = true;
                        ResourceBarRedSecondValue = 102;
                        setResourceBarWidthSecondValue = true;
                        ResourceBarWidthSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.ResourceBar.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        setResourceBarXSecondValue = true;
                        ResourceBarXSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.ResourceBar.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.ResourceBar.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setResourceBarYSecondValue = true;
                        ResourceBarYSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.ResourceBar.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Top;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.ResourceBar.YUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                        }
                        break;
                }
                var wasSuppressed = mIsLayoutSuspended;
                if (wasSuppressed == false)
                {
                    SuspendLayout(true);
                }
                if (setDialogBoxInstanceHeightFirstValue && setDialogBoxInstanceHeightSecondValue)
                {
                    DialogBoxInstance.Height = DialogBoxInstanceHeightFirstValue * (1 - interpolationValue) + DialogBoxInstanceHeightSecondValue * interpolationValue;
                }
                if (setDialogBoxInstanceWidthFirstValue && setDialogBoxInstanceWidthSecondValue)
                {
                    DialogBoxInstance.Width = DialogBoxInstanceWidthFirstValue * (1 - interpolationValue) + DialogBoxInstanceWidthSecondValue * interpolationValue;
                }
                if (setDialogBoxInstanceXFirstValue && setDialogBoxInstanceXSecondValue)
                {
                    DialogBoxInstance.X = DialogBoxInstanceXFirstValue * (1 - interpolationValue) + DialogBoxInstanceXSecondValue * interpolationValue;
                }
                if (setDialogBoxInstanceYFirstValue && setDialogBoxInstanceYSecondValue)
                {
                    DialogBoxInstance.Y = DialogBoxInstanceYFirstValue * (1 - interpolationValue) + DialogBoxInstanceYSecondValue * interpolationValue;
                }
                if (setInfoBarBlueFirstValue && setInfoBarBlueSecondValue)
                {
                    InfoBar.Blue = FlatRedBall.Math.MathFunctions.RoundToInt(InfoBarBlueFirstValue* (1 - interpolationValue) + InfoBarBlueSecondValue * interpolationValue);
                }
                if (setInfoBarCurrentColorCategoryStateFirstValue && setInfoBarCurrentColorCategoryStateSecondValue)
                {
                    InfoBar.InterpolateBetween(InfoBarCurrentColorCategoryStateFirstValue, InfoBarCurrentColorCategoryStateSecondValue, interpolationValue);
                }
                if (setInfoBarGreenFirstValue && setInfoBarGreenSecondValue)
                {
                    InfoBar.Green = FlatRedBall.Math.MathFunctions.RoundToInt(InfoBarGreenFirstValue* (1 - interpolationValue) + InfoBarGreenSecondValue * interpolationValue);
                }
                if (setInfoBarHeightFirstValue && setInfoBarHeightSecondValue)
                {
                    InfoBar.Height = InfoBarHeightFirstValue * (1 - interpolationValue) + InfoBarHeightSecondValue * interpolationValue;
                }
                if (setInfoBarRedFirstValue && setInfoBarRedSecondValue)
                {
                    InfoBar.Red = FlatRedBall.Math.MathFunctions.RoundToInt(InfoBarRedFirstValue* (1 - interpolationValue) + InfoBarRedSecondValue * interpolationValue);
                }
                if (setInfoBarWidthFirstValue && setInfoBarWidthSecondValue)
                {
                    InfoBar.Width = InfoBarWidthFirstValue * (1 - interpolationValue) + InfoBarWidthSecondValue * interpolationValue;
                }
                if (setInfoBarXFirstValue && setInfoBarXSecondValue)
                {
                    InfoBar.X = InfoBarXFirstValue * (1 - interpolationValue) + InfoBarXSecondValue * interpolationValue;
                }
                if (setInfoBarYFirstValue && setInfoBarYSecondValue)
                {
                    InfoBar.Y = InfoBarYFirstValue * (1 - interpolationValue) + InfoBarYSecondValue * interpolationValue;
                }
                if (setListBoxInstanceHeightFirstValue && setListBoxInstanceHeightSecondValue)
                {
                    ListBoxInstance.Height = ListBoxInstanceHeightFirstValue * (1 - interpolationValue) + ListBoxInstanceHeightSecondValue * interpolationValue;
                }
                if (setListBoxInstanceXFirstValue && setListBoxInstanceXSecondValue)
                {
                    ListBoxInstance.X = ListBoxInstanceXFirstValue * (1 - interpolationValue) + ListBoxInstanceXSecondValue * interpolationValue;
                }
                if (setListBoxInstanceYFirstValue && setListBoxInstanceYSecondValue)
                {
                    ListBoxInstance.Y = ListBoxInstanceYFirstValue * (1 - interpolationValue) + ListBoxInstanceYSecondValue * interpolationValue;
                }
                if (setPlayButtonInstanceHeightFirstValue && setPlayButtonInstanceHeightSecondValue)
                {
                    PlayButtonInstance.Height = PlayButtonInstanceHeightFirstValue * (1 - interpolationValue) + PlayButtonInstanceHeightSecondValue * interpolationValue;
                }
                if (setPlayButtonInstanceWidthFirstValue && setPlayButtonInstanceWidthSecondValue)
                {
                    PlayButtonInstance.Width = PlayButtonInstanceWidthFirstValue * (1 - interpolationValue) + PlayButtonInstanceWidthSecondValue * interpolationValue;
                }
                if (setPlayButtonInstanceXFirstValue && setPlayButtonInstanceXSecondValue)
                {
                    PlayButtonInstance.X = PlayButtonInstanceXFirstValue * (1 - interpolationValue) + PlayButtonInstanceXSecondValue * interpolationValue;
                }
                if (setPlayButtonInstanceYFirstValue && setPlayButtonInstanceYSecondValue)
                {
                    PlayButtonInstance.Y = PlayButtonInstanceYFirstValue * (1 - interpolationValue) + PlayButtonInstanceYSecondValue * interpolationValue;
                }
                if (setResourceBarBlueFirstValue && setResourceBarBlueSecondValue)
                {
                    ResourceBar.Blue = FlatRedBall.Math.MathFunctions.RoundToInt(ResourceBarBlueFirstValue* (1 - interpolationValue) + ResourceBarBlueSecondValue * interpolationValue);
                }
                if (setResourceBarCurrentColorCategoryStateFirstValue && setResourceBarCurrentColorCategoryStateSecondValue)
                {
                    ResourceBar.InterpolateBetween(ResourceBarCurrentColorCategoryStateFirstValue, ResourceBarCurrentColorCategoryStateSecondValue, interpolationValue);
                }
                if (setResourceBarGreenFirstValue && setResourceBarGreenSecondValue)
                {
                    ResourceBar.Green = FlatRedBall.Math.MathFunctions.RoundToInt(ResourceBarGreenFirstValue* (1 - interpolationValue) + ResourceBarGreenSecondValue * interpolationValue);
                }
                if (setResourceBarHeightFirstValue && setResourceBarHeightSecondValue)
                {
                    ResourceBar.Height = ResourceBarHeightFirstValue * (1 - interpolationValue) + ResourceBarHeightSecondValue * interpolationValue;
                }
                if (setResourceBarRedFirstValue && setResourceBarRedSecondValue)
                {
                    ResourceBar.Red = FlatRedBall.Math.MathFunctions.RoundToInt(ResourceBarRedFirstValue* (1 - interpolationValue) + ResourceBarRedSecondValue * interpolationValue);
                }
                if (setResourceBarWidthFirstValue && setResourceBarWidthSecondValue)
                {
                    ResourceBar.Width = ResourceBarWidthFirstValue * (1 - interpolationValue) + ResourceBarWidthSecondValue * interpolationValue;
                }
                if (setResourceBarXFirstValue && setResourceBarXSecondValue)
                {
                    ResourceBar.X = ResourceBarXFirstValue * (1 - interpolationValue) + ResourceBarXSecondValue * interpolationValue;
                }
                if (setResourceBarYFirstValue && setResourceBarYSecondValue)
                {
                    ResourceBar.Y = ResourceBarYFirstValue * (1 - interpolationValue) + ResourceBarYSecondValue * interpolationValue;
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
                PlayButtonInstance.StopAnimations();
                ScreenSelectorInstance.StopAnimations();
                ResourceBar.StopAnimations();
                InfoBar.StopAnimations();
                BackButtonInstance.StopAnimations();
                DialogBoxInstance.StopAnimations();
                ListBoxInstance.StopAnimations();
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
                            Name = "PlayButtonInstance.Height",
                            Type = "float",
                            Value = PlayButtonInstance.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PlayButtonInstance.Height Units",
                            Type = "DimensionUnitType",
                            Value = PlayButtonInstance.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PlayButtonInstance.Width",
                            Type = "float",
                            Value = PlayButtonInstance.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PlayButtonInstance.X",
                            Type = "float",
                            Value = PlayButtonInstance.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PlayButtonInstance.X Units",
                            Type = "PositionUnitType",
                            Value = PlayButtonInstance.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PlayButtonInstance.Y",
                            Type = "float",
                            Value = PlayButtonInstance.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PlayButtonInstance.Y Origin",
                            Type = "VerticalAlignment",
                            Value = PlayButtonInstance.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PlayButtonInstance.Y Units",
                            Type = "PositionUnitType",
                            Value = PlayButtonInstance.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResourceBar.Blue",
                            Type = "int",
                            Value = ResourceBar.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResourceBar.ColorCategoryState",
                            Type = "ColorCategoryState",
                            Value = ResourceBar.CurrentColorCategoryState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResourceBar.Green",
                            Type = "int",
                            Value = ResourceBar.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResourceBar.Height",
                            Type = "float",
                            Value = ResourceBar.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResourceBar.Height Units",
                            Type = "DimensionUnitType",
                            Value = ResourceBar.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResourceBar.Red",
                            Type = "int",
                            Value = ResourceBar.Red
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResourceBar.Width",
                            Type = "float",
                            Value = ResourceBar.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResourceBar.Width Units",
                            Type = "DimensionUnitType",
                            Value = ResourceBar.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResourceBar.X",
                            Type = "float",
                            Value = ResourceBar.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResourceBar.X Origin",
                            Type = "HorizontalAlignment",
                            Value = ResourceBar.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResourceBar.X Units",
                            Type = "PositionUnitType",
                            Value = ResourceBar.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResourceBar.Y",
                            Type = "float",
                            Value = ResourceBar.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResourceBar.Y Origin",
                            Type = "VerticalAlignment",
                            Value = ResourceBar.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResourceBar.Y Units",
                            Type = "PositionUnitType",
                            Value = ResourceBar.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "InfoBar.Blue",
                            Type = "int",
                            Value = InfoBar.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "InfoBar.ColorCategoryState",
                            Type = "ColorCategoryState",
                            Value = InfoBar.CurrentColorCategoryState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "InfoBar.Green",
                            Type = "int",
                            Value = InfoBar.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "InfoBar.Height",
                            Type = "float",
                            Value = InfoBar.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "InfoBar.Red",
                            Type = "int",
                            Value = InfoBar.Red
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "InfoBar.Width",
                            Type = "float",
                            Value = InfoBar.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "InfoBar.Width Units",
                            Type = "DimensionUnitType",
                            Value = InfoBar.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "InfoBar.X",
                            Type = "float",
                            Value = InfoBar.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "InfoBar.X Origin",
                            Type = "HorizontalAlignment",
                            Value = InfoBar.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "InfoBar.X Units",
                            Type = "PositionUnitType",
                            Value = InfoBar.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "InfoBar.Y",
                            Type = "float",
                            Value = InfoBar.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "InfoBar.Y Origin",
                            Type = "VerticalAlignment",
                            Value = InfoBar.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "InfoBar.Y Units",
                            Type = "PositionUnitType",
                            Value = InfoBar.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackButtonInstance.X Origin",
                            Type = "HorizontalAlignment",
                            Value = BackButtonInstance.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackButtonInstance.X Units",
                            Type = "PositionUnitType",
                            Value = BackButtonInstance.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackButtonInstance.Y Origin",
                            Type = "VerticalAlignment",
                            Value = BackButtonInstance.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackButtonInstance.Y Units",
                            Type = "PositionUnitType",
                            Value = BackButtonInstance.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "DialogBoxInstance.Height",
                            Type = "float",
                            Value = DialogBoxInstance.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "DialogBoxInstance.Height Units",
                            Type = "DimensionUnitType",
                            Value = DialogBoxInstance.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "DialogBoxInstance.Parent",
                            Type = "string",
                            Value = DialogBoxInstance.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "DialogBoxInstance.Width",
                            Type = "float",
                            Value = DialogBoxInstance.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "DialogBoxInstance.Width Units",
                            Type = "DimensionUnitType",
                            Value = DialogBoxInstance.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "DialogBoxInstance.X",
                            Type = "float",
                            Value = DialogBoxInstance.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "DialogBoxInstance.X Origin",
                            Type = "HorizontalAlignment",
                            Value = DialogBoxInstance.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "DialogBoxInstance.X Units",
                            Type = "PositionUnitType",
                            Value = DialogBoxInstance.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "DialogBoxInstance.Y",
                            Type = "float",
                            Value = DialogBoxInstance.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "DialogBoxInstance.Y Origin",
                            Type = "VerticalAlignment",
                            Value = DialogBoxInstance.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "DialogBoxInstance.Y Units",
                            Type = "PositionUnitType",
                            Value = DialogBoxInstance.YUnits
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
                            Name = "ListBoxInstance.Height Units",
                            Type = "DimensionUnitType",
                            Value = ListBoxInstance.HeightUnits
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
                            Name = "PlayButtonInstance.Height",
                            Type = "float",
                            Value = PlayButtonInstance.Height + 100f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PlayButtonInstance.Height Units",
                            Type = "DimensionUnitType",
                            Value = PlayButtonInstance.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PlayButtonInstance.Width",
                            Type = "float",
                            Value = PlayButtonInstance.Width + 80f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PlayButtonInstance.X",
                            Type = "float",
                            Value = PlayButtonInstance.X + 10f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PlayButtonInstance.X Units",
                            Type = "PositionUnitType",
                            Value = PlayButtonInstance.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PlayButtonInstance.Y",
                            Type = "float",
                            Value = PlayButtonInstance.Y + -118f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PlayButtonInstance.Y Origin",
                            Type = "VerticalAlignment",
                            Value = PlayButtonInstance.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PlayButtonInstance.Y Units",
                            Type = "PositionUnitType",
                            Value = PlayButtonInstance.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResourceBar.Blue",
                            Type = "int",
                            Value = ResourceBar.Blue + 170
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResourceBar.ColorCategoryState",
                            Type = "ColorCategoryState",
                            Value = ResourceBar.CurrentColorCategoryState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResourceBar.Green",
                            Type = "int",
                            Value = ResourceBar.Green + 205
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResourceBar.Height",
                            Type = "float",
                            Value = ResourceBar.Height + 72f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResourceBar.Height Units",
                            Type = "DimensionUnitType",
                            Value = ResourceBar.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResourceBar.Red",
                            Type = "int",
                            Value = ResourceBar.Red + 102
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResourceBar.Width",
                            Type = "float",
                            Value = ResourceBar.Width + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResourceBar.Width Units",
                            Type = "DimensionUnitType",
                            Value = ResourceBar.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResourceBar.X",
                            Type = "float",
                            Value = ResourceBar.X + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResourceBar.X Origin",
                            Type = "HorizontalAlignment",
                            Value = ResourceBar.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResourceBar.X Units",
                            Type = "PositionUnitType",
                            Value = ResourceBar.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResourceBar.Y",
                            Type = "float",
                            Value = ResourceBar.Y + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResourceBar.Y Origin",
                            Type = "VerticalAlignment",
                            Value = ResourceBar.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResourceBar.Y Units",
                            Type = "PositionUnitType",
                            Value = ResourceBar.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "InfoBar.Blue",
                            Type = "int",
                            Value = InfoBar.Blue + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "InfoBar.ColorCategoryState",
                            Type = "ColorCategoryState",
                            Value = InfoBar.CurrentColorCategoryState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "InfoBar.Green",
                            Type = "int",
                            Value = InfoBar.Green + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "InfoBar.Height",
                            Type = "float",
                            Value = InfoBar.Height + 72f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "InfoBar.Red",
                            Type = "int",
                            Value = InfoBar.Red + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "InfoBar.Width",
                            Type = "float",
                            Value = InfoBar.Width + 50f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "InfoBar.Width Units",
                            Type = "DimensionUnitType",
                            Value = InfoBar.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "InfoBar.X",
                            Type = "float",
                            Value = InfoBar.X + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "InfoBar.X Origin",
                            Type = "HorizontalAlignment",
                            Value = InfoBar.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "InfoBar.X Units",
                            Type = "PositionUnitType",
                            Value = InfoBar.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "InfoBar.Y",
                            Type = "float",
                            Value = InfoBar.Y + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "InfoBar.Y Origin",
                            Type = "VerticalAlignment",
                            Value = InfoBar.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "InfoBar.Y Units",
                            Type = "PositionUnitType",
                            Value = InfoBar.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackButtonInstance.X Origin",
                            Type = "HorizontalAlignment",
                            Value = BackButtonInstance.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackButtonInstance.X Units",
                            Type = "PositionUnitType",
                            Value = BackButtonInstance.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackButtonInstance.Y Origin",
                            Type = "VerticalAlignment",
                            Value = BackButtonInstance.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackButtonInstance.Y Units",
                            Type = "PositionUnitType",
                            Value = BackButtonInstance.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "DialogBoxInstance.Height",
                            Type = "float",
                            Value = DialogBoxInstance.Height + -10f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "DialogBoxInstance.Height Units",
                            Type = "DimensionUnitType",
                            Value = DialogBoxInstance.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "DialogBoxInstance.Parent",
                            Type = "string",
                            Value = DialogBoxInstance.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "DialogBoxInstance.Width",
                            Type = "float",
                            Value = DialogBoxInstance.Width + 50f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "DialogBoxInstance.Width Units",
                            Type = "DimensionUnitType",
                            Value = DialogBoxInstance.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "DialogBoxInstance.X",
                            Type = "float",
                            Value = DialogBoxInstance.X + 5f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "DialogBoxInstance.X Origin",
                            Type = "HorizontalAlignment",
                            Value = DialogBoxInstance.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "DialogBoxInstance.X Units",
                            Type = "PositionUnitType",
                            Value = DialogBoxInstance.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "DialogBoxInstance.Y",
                            Type = "float",
                            Value = DialogBoxInstance.Y + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "DialogBoxInstance.Y Origin",
                            Type = "VerticalAlignment",
                            Value = DialogBoxInstance.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "DialogBoxInstance.Y Units",
                            Type = "PositionUnitType",
                            Value = DialogBoxInstance.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ListBoxInstance.Height",
                            Type = "float",
                            Value = ListBoxInstance.Height + -280f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ListBoxInstance.Height Units",
                            Type = "DimensionUnitType",
                            Value = ListBoxInstance.HeightUnits
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
                            Value = ListBoxInstance.Y + 72f
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
            public JHP4SD.GumRuntimes.LebegForms.BasicComponents.PlayButtonRuntime PlayButtonInstance { get; set; }
            public JHP4SD.GumRuntimes.LebegForms.ComplexComponents.ScreenSelectorRuntime ScreenSelectorInstance { get; set; }
            public JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime ResourceBar { get; set; }
            public JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime InfoBar { get; set; }
            public JHP4SD.GumRuntimes.LebegForms.BasicComponents.BackButtonRuntime BackButtonInstance { get; set; }
            public JHP4SD.GumRuntimes.DefaultForms.DialogBoxRuntime DialogBoxInstance { get; set; }
            public JHP4SD.GumRuntimes.DefaultForms.ListBoxRuntime ListBoxInstance { get; set; }
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
                PlayButtonInstance = this.GetGraphicalUiElementByName("PlayButtonInstance") as JHP4SD.GumRuntimes.LebegForms.BasicComponents.PlayButtonRuntime;
                ScreenSelectorInstance = this.GetGraphicalUiElementByName("ScreenSelectorInstance") as JHP4SD.GumRuntimes.LebegForms.ComplexComponents.ScreenSelectorRuntime;
                ResourceBar = this.GetGraphicalUiElementByName("ResourceBar") as JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime;
                InfoBar = this.GetGraphicalUiElementByName("InfoBar") as JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime;
                BackButtonInstance = this.GetGraphicalUiElementByName("BackButtonInstance") as JHP4SD.GumRuntimes.LebegForms.BasicComponents.BackButtonRuntime;
                DialogBoxInstance = this.GetGraphicalUiElementByName("DialogBoxInstance") as JHP4SD.GumRuntimes.DefaultForms.DialogBoxRuntime;
                ListBoxInstance = this.GetGraphicalUiElementByName("ListBoxInstance") as JHP4SD.GumRuntimes.DefaultForms.ListBoxRuntime;
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
