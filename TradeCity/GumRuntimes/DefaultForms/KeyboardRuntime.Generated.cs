    using System.Linq;
    namespace JHP4SD.GumRuntimes.DefaultForms
    {
        public partial class KeyboardRuntime : JHP4SD.GumRuntimes.ContainerRuntime
        {
            #region State Enums
            public enum VariableState
            {
                Default
            }
            public enum CursorMoveCategory
            {
                LeftRightMoveSupported,
                NoMovement
            }
            #endregion
            #region State Fields
            VariableState mCurrentVariableState;
            CursorMoveCategory? mCurrentCursorMoveCategoryState;
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
                            Row1Keys.Parent = this.GetGraphicalUiElementByName("KeyRows") ?? this;
                            Key1.Parent = this.GetGraphicalUiElementByName("Row1Keys") ?? this;
                            KeyQ.Parent = this.GetGraphicalUiElementByName("Row2Keys") ?? this;
                            KeyA.Parent = this.GetGraphicalUiElementByName("Row3Keys") ?? this;
                            KeyZ.Parent = this.GetGraphicalUiElementByName("Row4Keys") ?? this;
                            KeyParenLeft.Parent = this.GetGraphicalUiElementByName("Row5Keys") ?? this;
                            KeyW.Parent = this.GetGraphicalUiElementByName("Row2Keys") ?? this;
                            KeyS.Parent = this.GetGraphicalUiElementByName("Row3Keys") ?? this;
                            KeyX.Parent = this.GetGraphicalUiElementByName("Row4Keys") ?? this;
                            KeyParenRight.Parent = this.GetGraphicalUiElementByName("Row5Keys") ?? this;
                            KeyE.Parent = this.GetGraphicalUiElementByName("Row2Keys") ?? this;
                            KeyD.Parent = this.GetGraphicalUiElementByName("Row3Keys") ?? this;
                            KeyC.Parent = this.GetGraphicalUiElementByName("Row4Keys") ?? this;
                            KeySpace.Parent = this.GetGraphicalUiElementByName("Row5Keys") ?? this;
                            KeyR.Parent = this.GetGraphicalUiElementByName("Row2Keys") ?? this;
                            KeyF.Parent = this.GetGraphicalUiElementByName("Row3Keys") ?? this;
                            KeyV.Parent = this.GetGraphicalUiElementByName("Row4Keys") ?? this;
                            KeyT.Parent = this.GetGraphicalUiElementByName("Row2Keys") ?? this;
                            KeyG.Parent = this.GetGraphicalUiElementByName("Row3Keys") ?? this;
                            KeyB.Parent = this.GetGraphicalUiElementByName("Row4Keys") ?? this;
                            KeyY.Parent = this.GetGraphicalUiElementByName("Row2Keys") ?? this;
                            KeyH.Parent = this.GetGraphicalUiElementByName("Row3Keys") ?? this;
                            KeyN.Parent = this.GetGraphicalUiElementByName("Row4Keys") ?? this;
                            KeyU.Parent = this.GetGraphicalUiElementByName("Row2Keys") ?? this;
                            KeyJ.Parent = this.GetGraphicalUiElementByName("Row3Keys") ?? this;
                            KeyM.Parent = this.GetGraphicalUiElementByName("Row4Keys") ?? this;
                            KeyI.Parent = this.GetGraphicalUiElementByName("Row2Keys") ?? this;
                            KeyK.Parent = this.GetGraphicalUiElementByName("Row3Keys") ?? this;
                            KeyComma.Parent = this.GetGraphicalUiElementByName("Row4Keys") ?? this;
                            KeyQuestion.Parent = this.GetGraphicalUiElementByName("Row5Keys") ?? this;
                            KeyO.Parent = this.GetGraphicalUiElementByName("Row2Keys") ?? this;
                            KeyL.Parent = this.GetGraphicalUiElementByName("Row3Keys") ?? this;
                            KeyPeriod.Parent = this.GetGraphicalUiElementByName("Row4Keys") ?? this;
                            KeyBang.Parent = this.GetGraphicalUiElementByName("Row5Keys") ?? this;
                            KeyP.Parent = this.GetGraphicalUiElementByName("Row2Keys") ?? this;
                            KeyUnderscore.Parent = this.GetGraphicalUiElementByName("Row3Keys") ?? this;
                            KeyHyphen.Parent = this.GetGraphicalUiElementByName("Row4Keys") ?? this;
                            KeyAmpersand.Parent = this.GetGraphicalUiElementByName("Row5Keys") ?? this;
                            Key2.Parent = this.GetGraphicalUiElementByName("Row1Keys") ?? this;
                            Key3.Parent = this.GetGraphicalUiElementByName("Row1Keys") ?? this;
                            Key4.Parent = this.GetGraphicalUiElementByName("Row1Keys") ?? this;
                            Key5.Parent = this.GetGraphicalUiElementByName("Row1Keys") ?? this;
                            Key6.Parent = this.GetGraphicalUiElementByName("Row1Keys") ?? this;
                            Key7.Parent = this.GetGraphicalUiElementByName("Row1Keys") ?? this;
                            Key8.Parent = this.GetGraphicalUiElementByName("Row1Keys") ?? this;
                            Key9.Parent = this.GetGraphicalUiElementByName("Row1Keys") ?? this;
                            Key0.Parent = this.GetGraphicalUiElementByName("Row1Keys") ?? this;
                            Row2Keys.Parent = this.GetGraphicalUiElementByName("KeyRows") ?? this;
                            Row3Keys.Parent = this.GetGraphicalUiElementByName("KeyRows") ?? this;
                            Row4Keys.Parent = this.GetGraphicalUiElementByName("KeyRows") ?? this;
                            Row5Keys.Parent = this.GetGraphicalUiElementByName("KeyRows") ?? this;
                            Width = 0f;
                            WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                            XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                            Row1Keys.ChildrenLayout = Gum.Managers.ChildrenLayout.LeftToRightStack;
                            Row1Keys.Height = 20f;
                            Row1Keys.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            Row1Keys.Width = 0f;
                            Row1Keys.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                            Row1Keys.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                            Row1Keys.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            Row1Keys.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Top;
                            Row1Keys.YUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                            KeyRows.ChildrenLayout = Gum.Managers.ChildrenLayout.TopToBottomStack;
                            KeyRows.Height = 0f;
                            KeyRows.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                            KeyRows.Width = 90f;
                            KeyRows.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            KeyRows.X = 0f;
                            KeyRows.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                            KeyRows.XUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                            KeyRows.Y = 0f;
                            KeyRows.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            KeyRows.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            Key1.Height = 0f;
                            Key1.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                            Key1.Text = "1";
                            Key1.Width = 10f;
                            Key1.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            Key1.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            Key1.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            KeyQ.Height = 0f;
                            KeyQ.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                            KeyQ.Text = "Q";
                            KeyQ.Width = 10f;
                            KeyQ.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            KeyQ.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            KeyQ.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            KeyA.Height = 0f;
                            KeyA.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                            KeyA.Text = "A";
                            KeyA.Width = 10f;
                            KeyA.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            KeyA.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            KeyA.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            KeyZ.Height = 0f;
                            KeyZ.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                            KeyZ.Text = "Z";
                            KeyZ.Width = 10f;
                            KeyZ.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            KeyZ.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            KeyZ.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            KeyParenLeft.Height = 0f;
                            KeyParenLeft.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                            KeyParenLeft.Text = "(";
                            KeyParenLeft.Width = 10f;
                            KeyParenLeft.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            KeyParenLeft.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            KeyParenLeft.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            KeyW.Height = 0f;
                            KeyW.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                            KeyW.Text = "W";
                            KeyW.Width = 10f;
                            KeyW.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            KeyW.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            KeyW.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            KeyS.Height = 0f;
                            KeyS.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                            KeyS.Text = "S";
                            KeyS.Width = 10f;
                            KeyS.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            KeyS.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            KeyS.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            KeyX.Height = 0f;
                            KeyX.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                            KeyX.Text = "X";
                            KeyX.Width = 10f;
                            KeyX.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            KeyX.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            KeyX.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            KeyParenRight.Height = 0f;
                            KeyParenRight.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                            KeyParenRight.Text = ")";
                            KeyParenRight.Width = 10f;
                            KeyParenRight.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            KeyParenRight.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            KeyParenRight.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            KeyE.Height = 0f;
                            KeyE.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                            KeyE.Text = "E";
                            KeyE.Width = 10f;
                            KeyE.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            KeyE.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            KeyE.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            KeyD.Height = 0f;
                            KeyD.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                            KeyD.Text = "D";
                            KeyD.Width = 10f;
                            KeyD.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            KeyD.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            KeyD.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            KeyC.Height = 0f;
                            KeyC.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                            KeyC.Text = "C";
                            KeyC.Width = 10f;
                            KeyC.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            KeyC.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            KeyC.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            KeySpace.Height = 0f;
                            KeySpace.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                            KeySpace.Text = "SPACE";
                            KeySpace.Width = 50f;
                            KeySpace.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            KeySpace.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            KeySpace.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            KeyR.Height = 0f;
                            KeyR.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                            KeyR.Text = "R";
                            KeyR.Width = 10f;
                            KeyR.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            KeyR.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            KeyR.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            KeyF.Height = 0f;
                            KeyF.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                            KeyF.Text = "F";
                            KeyF.Width = 10f;
                            KeyF.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            KeyF.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            KeyF.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            KeyV.Height = 0f;
                            KeyV.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                            KeyV.Text = "V";
                            KeyV.Width = 10f;
                            KeyV.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            KeyV.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            KeyV.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            KeyT.Height = 0f;
                            KeyT.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                            KeyT.Text = "T";
                            KeyT.Width = 10f;
                            KeyT.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            KeyT.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            KeyT.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            KeyG.Height = 0f;
                            KeyG.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                            KeyG.Text = "G";
                            KeyG.Width = 10f;
                            KeyG.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            KeyG.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            KeyG.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            KeyB.Height = 0f;
                            KeyB.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                            KeyB.Text = "B";
                            KeyB.Width = 10f;
                            KeyB.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            KeyB.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            KeyB.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            KeyY.Height = 0f;
                            KeyY.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                            KeyY.Text = "Y";
                            KeyY.Width = 10f;
                            KeyY.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            KeyY.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            KeyY.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            KeyH.Height = 0f;
                            KeyH.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                            KeyH.Text = "H";
                            KeyH.Width = 10f;
                            KeyH.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            KeyH.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            KeyH.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            KeyN.Height = 0f;
                            KeyN.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                            KeyN.Text = "N";
                            KeyN.Width = 10f;
                            KeyN.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            KeyN.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            KeyN.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            KeyU.Height = 0f;
                            KeyU.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                            KeyU.Text = "U";
                            KeyU.Width = 10f;
                            KeyU.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            KeyU.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            KeyU.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            KeyJ.Height = 0f;
                            KeyJ.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                            KeyJ.Text = "J";
                            KeyJ.Width = 10f;
                            KeyJ.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            KeyJ.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            KeyJ.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            KeyM.Height = 0f;
                            KeyM.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                            KeyM.Text = "M";
                            KeyM.Width = 10f;
                            KeyM.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            KeyM.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            KeyM.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            KeyI.Height = 0f;
                            KeyI.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                            KeyI.Text = "I";
                            KeyI.Width = 10f;
                            KeyI.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            KeyI.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            KeyI.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            KeyK.Height = 0f;
                            KeyK.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                            KeyK.Text = "K";
                            KeyK.Width = 10f;
                            KeyK.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            KeyK.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            KeyK.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            KeyComma.Height = 0f;
                            KeyComma.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                            KeyComma.Text = ",";
                            KeyComma.Width = 10f;
                            KeyComma.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            KeyComma.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            KeyComma.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            KeyQuestion.Height = 0f;
                            KeyQuestion.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                            KeyQuestion.Text = "?";
                            KeyQuestion.Width = 10f;
                            KeyQuestion.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            KeyQuestion.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            KeyQuestion.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            KeyO.Height = 0f;
                            KeyO.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                            KeyO.Text = "O";
                            KeyO.Width = 10f;
                            KeyO.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            KeyO.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            KeyO.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            KeyL.Height = 0f;
                            KeyL.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                            KeyL.Text = "L";
                            KeyL.Width = 10f;
                            KeyL.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            KeyL.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            KeyL.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            KeyPeriod.Height = 0f;
                            KeyPeriod.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                            KeyPeriod.Text = ".";
                            KeyPeriod.Width = 10f;
                            KeyPeriod.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            KeyPeriod.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            KeyPeriod.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            KeyBang.Height = 0f;
                            KeyBang.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                            KeyBang.Text = "!";
                            KeyBang.Width = 10f;
                            KeyBang.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            KeyBang.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            KeyBang.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            KeyP.Height = 0f;
                            KeyP.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                            KeyP.Text = "P";
                            KeyP.Width = 10f;
                            KeyP.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            KeyP.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            KeyP.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            KeyUnderscore.Height = 0f;
                            KeyUnderscore.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                            KeyUnderscore.Text = "_";
                            KeyUnderscore.Width = 10f;
                            KeyUnderscore.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            KeyUnderscore.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            KeyUnderscore.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            KeyHyphen.Height = 0f;
                            KeyHyphen.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                            KeyHyphen.Text = "-";
                            KeyHyphen.Width = 10f;
                            KeyHyphen.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            KeyHyphen.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            KeyHyphen.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            KeyAmpersand.Height = 0f;
                            KeyAmpersand.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                            KeyAmpersand.Text = "&";
                            KeyAmpersand.Width = 10f;
                            KeyAmpersand.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            KeyAmpersand.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            KeyAmpersand.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            Key2.Height = 0f;
                            Key2.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                            Key2.Text = "2";
                            Key2.Width = 10f;
                            Key2.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            Key2.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            Key2.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            Key3.Height = 0f;
                            Key3.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                            Key3.Text = "3";
                            Key3.Width = 10f;
                            Key3.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            Key3.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            Key3.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            Key4.Height = 0f;
                            Key4.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                            Key4.Text = "4";
                            Key4.Width = 10f;
                            Key4.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            Key4.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            Key4.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            Key5.Height = 0f;
                            Key5.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                            Key5.Text = "5";
                            Key5.Width = 10f;
                            Key5.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            Key5.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            Key5.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            Key6.Height = 0f;
                            Key6.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                            Key6.Text = "6";
                            Key6.Width = 10f;
                            Key6.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            Key6.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            Key6.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            Key7.Height = 0f;
                            Key7.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                            Key7.Text = "7";
                            Key7.Width = 10f;
                            Key7.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            Key7.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            Key7.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            Key8.Height = 0f;
                            Key8.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                            Key8.Text = "8";
                            Key8.Width = 10f;
                            Key8.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            Key8.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            Key8.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            Key9.Height = 0f;
                            Key9.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                            Key9.Text = "9";
                            Key9.Width = 10f;
                            Key9.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            Key9.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            Key9.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            Key0.Height = 0f;
                            Key0.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                            Key0.Text = "0";
                            Key0.Width = 10f;
                            Key0.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            Key0.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            Key0.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            Row2Keys.ChildrenLayout = Gum.Managers.ChildrenLayout.LeftToRightStack;
                            Row2Keys.Height = 20f;
                            Row2Keys.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            Row2Keys.Width = 0f;
                            Row2Keys.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                            Row3Keys.ChildrenLayout = Gum.Managers.ChildrenLayout.LeftToRightStack;
                            Row3Keys.Height = 20f;
                            Row3Keys.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            Row3Keys.Width = 0f;
                            Row3Keys.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                            Row4Keys.ChildrenLayout = Gum.Managers.ChildrenLayout.LeftToRightStack;
                            Row4Keys.Height = 20f;
                            Row4Keys.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            Row4Keys.Width = 0f;
                            Row4Keys.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                            Row5Keys.ChildrenLayout = Gum.Managers.ChildrenLayout.LeftToRightStack;
                            Row5Keys.Height = 20f;
                            Row5Keys.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            Row5Keys.Width = 0f;
                            Row5Keys.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                            KeyBackspace.Height = 20f;
                            KeyBackspace.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            KeyBackspace.Text = "";
                            KeyBackspace.Width = 10f;
                            KeyBackspace.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            KeyBackspace.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                            KeyBackspace.XUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                            KeyReturn.Height = 40f;
                            KeyReturn.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            KeyReturn.Text = "";
                            KeyReturn.Width = 10f;
                            KeyReturn.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            KeyReturn.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                            KeyReturn.XUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                            KeyReturn.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Bottom;
                            KeyReturn.YUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                            KeyLeft.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            KeyLeft.Text = "";
                            KeyLeft.Width = 10f;
                            KeyLeft.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            KeyLeft.X = 0f;
                            KeyLeft.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                            KeyLeft.XUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                            KeyLeft.Y = 20f;
                            KeyLeft.YUnits = Gum.Converters.GeneralUnitType.Percentage;
                            KeyRight.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            KeyRight.Text = "";
                            KeyRight.Width = 10f;
                            KeyRight.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            KeyRight.X = 0f;
                            KeyRight.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                            KeyRight.XUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                            KeyRight.Y = 40f;
                            KeyRight.YUnits = Gum.Converters.GeneralUnitType.Percentage;
                            break;
                    }
                }
            }
            public CursorMoveCategory? CurrentCursorMoveCategoryState
            {
                get
                {
                    return mCurrentCursorMoveCategoryState;
                }
                set
                {
                    if (value != null)
                    {
                        mCurrentCursorMoveCategoryState = value;
                        switch(mCurrentCursorMoveCategoryState)
                        {
                            case  CursorMoveCategory.LeftRightMoveSupported:
                                KeyLeft.Visible = true;
                                KeyRight.Visible = true;
                                break;
                            case  CursorMoveCategory.NoMovement:
                                KeyLeft.Visible = false;
                                KeyRight.Visible = false;
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
                bool setKey0HeightFirstValue = false;
                bool setKey0HeightSecondValue = false;
                float Key0HeightFirstValue= 0;
                float Key0HeightSecondValue= 0;
                bool setKey0WidthFirstValue = false;
                bool setKey0WidthSecondValue = false;
                float Key0WidthFirstValue= 0;
                float Key0WidthSecondValue= 0;
                bool setKey1HeightFirstValue = false;
                bool setKey1HeightSecondValue = false;
                float Key1HeightFirstValue= 0;
                float Key1HeightSecondValue= 0;
                bool setKey1WidthFirstValue = false;
                bool setKey1WidthSecondValue = false;
                float Key1WidthFirstValue= 0;
                float Key1WidthSecondValue= 0;
                bool setKey2HeightFirstValue = false;
                bool setKey2HeightSecondValue = false;
                float Key2HeightFirstValue= 0;
                float Key2HeightSecondValue= 0;
                bool setKey2WidthFirstValue = false;
                bool setKey2WidthSecondValue = false;
                float Key2WidthFirstValue= 0;
                float Key2WidthSecondValue= 0;
                bool setKey3HeightFirstValue = false;
                bool setKey3HeightSecondValue = false;
                float Key3HeightFirstValue= 0;
                float Key3HeightSecondValue= 0;
                bool setKey3WidthFirstValue = false;
                bool setKey3WidthSecondValue = false;
                float Key3WidthFirstValue= 0;
                float Key3WidthSecondValue= 0;
                bool setKey4HeightFirstValue = false;
                bool setKey4HeightSecondValue = false;
                float Key4HeightFirstValue= 0;
                float Key4HeightSecondValue= 0;
                bool setKey4WidthFirstValue = false;
                bool setKey4WidthSecondValue = false;
                float Key4WidthFirstValue= 0;
                float Key4WidthSecondValue= 0;
                bool setKey5HeightFirstValue = false;
                bool setKey5HeightSecondValue = false;
                float Key5HeightFirstValue= 0;
                float Key5HeightSecondValue= 0;
                bool setKey5WidthFirstValue = false;
                bool setKey5WidthSecondValue = false;
                float Key5WidthFirstValue= 0;
                float Key5WidthSecondValue= 0;
                bool setKey6HeightFirstValue = false;
                bool setKey6HeightSecondValue = false;
                float Key6HeightFirstValue= 0;
                float Key6HeightSecondValue= 0;
                bool setKey6WidthFirstValue = false;
                bool setKey6WidthSecondValue = false;
                float Key6WidthFirstValue= 0;
                float Key6WidthSecondValue= 0;
                bool setKey7HeightFirstValue = false;
                bool setKey7HeightSecondValue = false;
                float Key7HeightFirstValue= 0;
                float Key7HeightSecondValue= 0;
                bool setKey7WidthFirstValue = false;
                bool setKey7WidthSecondValue = false;
                float Key7WidthFirstValue= 0;
                float Key7WidthSecondValue= 0;
                bool setKey8HeightFirstValue = false;
                bool setKey8HeightSecondValue = false;
                float Key8HeightFirstValue= 0;
                float Key8HeightSecondValue= 0;
                bool setKey8WidthFirstValue = false;
                bool setKey8WidthSecondValue = false;
                float Key8WidthFirstValue= 0;
                float Key8WidthSecondValue= 0;
                bool setKey9HeightFirstValue = false;
                bool setKey9HeightSecondValue = false;
                float Key9HeightFirstValue= 0;
                float Key9HeightSecondValue= 0;
                bool setKey9WidthFirstValue = false;
                bool setKey9WidthSecondValue = false;
                float Key9WidthFirstValue= 0;
                float Key9WidthSecondValue= 0;
                bool setKeyAHeightFirstValue = false;
                bool setKeyAHeightSecondValue = false;
                float KeyAHeightFirstValue= 0;
                float KeyAHeightSecondValue= 0;
                bool setKeyAWidthFirstValue = false;
                bool setKeyAWidthSecondValue = false;
                float KeyAWidthFirstValue= 0;
                float KeyAWidthSecondValue= 0;
                bool setKeyAmpersandHeightFirstValue = false;
                bool setKeyAmpersandHeightSecondValue = false;
                float KeyAmpersandHeightFirstValue= 0;
                float KeyAmpersandHeightSecondValue= 0;
                bool setKeyAmpersandWidthFirstValue = false;
                bool setKeyAmpersandWidthSecondValue = false;
                float KeyAmpersandWidthFirstValue= 0;
                float KeyAmpersandWidthSecondValue= 0;
                bool setKeyBHeightFirstValue = false;
                bool setKeyBHeightSecondValue = false;
                float KeyBHeightFirstValue= 0;
                float KeyBHeightSecondValue= 0;
                bool setKeyBWidthFirstValue = false;
                bool setKeyBWidthSecondValue = false;
                float KeyBWidthFirstValue= 0;
                float KeyBWidthSecondValue= 0;
                bool setKeyBackspaceHeightFirstValue = false;
                bool setKeyBackspaceHeightSecondValue = false;
                float KeyBackspaceHeightFirstValue= 0;
                float KeyBackspaceHeightSecondValue= 0;
                bool setKeyBackspaceWidthFirstValue = false;
                bool setKeyBackspaceWidthSecondValue = false;
                float KeyBackspaceWidthFirstValue= 0;
                float KeyBackspaceWidthSecondValue= 0;
                bool setKeyBangHeightFirstValue = false;
                bool setKeyBangHeightSecondValue = false;
                float KeyBangHeightFirstValue= 0;
                float KeyBangHeightSecondValue= 0;
                bool setKeyBangWidthFirstValue = false;
                bool setKeyBangWidthSecondValue = false;
                float KeyBangWidthFirstValue= 0;
                float KeyBangWidthSecondValue= 0;
                bool setKeyCHeightFirstValue = false;
                bool setKeyCHeightSecondValue = false;
                float KeyCHeightFirstValue= 0;
                float KeyCHeightSecondValue= 0;
                bool setKeyCWidthFirstValue = false;
                bool setKeyCWidthSecondValue = false;
                float KeyCWidthFirstValue= 0;
                float KeyCWidthSecondValue= 0;
                bool setKeyCommaHeightFirstValue = false;
                bool setKeyCommaHeightSecondValue = false;
                float KeyCommaHeightFirstValue= 0;
                float KeyCommaHeightSecondValue= 0;
                bool setKeyCommaWidthFirstValue = false;
                bool setKeyCommaWidthSecondValue = false;
                float KeyCommaWidthFirstValue= 0;
                float KeyCommaWidthSecondValue= 0;
                bool setKeyDHeightFirstValue = false;
                bool setKeyDHeightSecondValue = false;
                float KeyDHeightFirstValue= 0;
                float KeyDHeightSecondValue= 0;
                bool setKeyDWidthFirstValue = false;
                bool setKeyDWidthSecondValue = false;
                float KeyDWidthFirstValue= 0;
                float KeyDWidthSecondValue= 0;
                bool setKeyEHeightFirstValue = false;
                bool setKeyEHeightSecondValue = false;
                float KeyEHeightFirstValue= 0;
                float KeyEHeightSecondValue= 0;
                bool setKeyEWidthFirstValue = false;
                bool setKeyEWidthSecondValue = false;
                float KeyEWidthFirstValue= 0;
                float KeyEWidthSecondValue= 0;
                bool setKeyFHeightFirstValue = false;
                bool setKeyFHeightSecondValue = false;
                float KeyFHeightFirstValue= 0;
                float KeyFHeightSecondValue= 0;
                bool setKeyFWidthFirstValue = false;
                bool setKeyFWidthSecondValue = false;
                float KeyFWidthFirstValue= 0;
                float KeyFWidthSecondValue= 0;
                bool setKeyGHeightFirstValue = false;
                bool setKeyGHeightSecondValue = false;
                float KeyGHeightFirstValue= 0;
                float KeyGHeightSecondValue= 0;
                bool setKeyGWidthFirstValue = false;
                bool setKeyGWidthSecondValue = false;
                float KeyGWidthFirstValue= 0;
                float KeyGWidthSecondValue= 0;
                bool setKeyHHeightFirstValue = false;
                bool setKeyHHeightSecondValue = false;
                float KeyHHeightFirstValue= 0;
                float KeyHHeightSecondValue= 0;
                bool setKeyHWidthFirstValue = false;
                bool setKeyHWidthSecondValue = false;
                float KeyHWidthFirstValue= 0;
                float KeyHWidthSecondValue= 0;
                bool setKeyHyphenHeightFirstValue = false;
                bool setKeyHyphenHeightSecondValue = false;
                float KeyHyphenHeightFirstValue= 0;
                float KeyHyphenHeightSecondValue= 0;
                bool setKeyHyphenWidthFirstValue = false;
                bool setKeyHyphenWidthSecondValue = false;
                float KeyHyphenWidthFirstValue= 0;
                float KeyHyphenWidthSecondValue= 0;
                bool setKeyIHeightFirstValue = false;
                bool setKeyIHeightSecondValue = false;
                float KeyIHeightFirstValue= 0;
                float KeyIHeightSecondValue= 0;
                bool setKeyIWidthFirstValue = false;
                bool setKeyIWidthSecondValue = false;
                float KeyIWidthFirstValue= 0;
                float KeyIWidthSecondValue= 0;
                bool setKeyJHeightFirstValue = false;
                bool setKeyJHeightSecondValue = false;
                float KeyJHeightFirstValue= 0;
                float KeyJHeightSecondValue= 0;
                bool setKeyJWidthFirstValue = false;
                bool setKeyJWidthSecondValue = false;
                float KeyJWidthFirstValue= 0;
                float KeyJWidthSecondValue= 0;
                bool setKeyKHeightFirstValue = false;
                bool setKeyKHeightSecondValue = false;
                float KeyKHeightFirstValue= 0;
                float KeyKHeightSecondValue= 0;
                bool setKeyKWidthFirstValue = false;
                bool setKeyKWidthSecondValue = false;
                float KeyKWidthFirstValue= 0;
                float KeyKWidthSecondValue= 0;
                bool setKeyLHeightFirstValue = false;
                bool setKeyLHeightSecondValue = false;
                float KeyLHeightFirstValue= 0;
                float KeyLHeightSecondValue= 0;
                bool setKeyLWidthFirstValue = false;
                bool setKeyLWidthSecondValue = false;
                float KeyLWidthFirstValue= 0;
                float KeyLWidthSecondValue= 0;
                bool setKeyLeftWidthFirstValue = false;
                bool setKeyLeftWidthSecondValue = false;
                float KeyLeftWidthFirstValue= 0;
                float KeyLeftWidthSecondValue= 0;
                bool setKeyLeftXFirstValue = false;
                bool setKeyLeftXSecondValue = false;
                float KeyLeftXFirstValue= 0;
                float KeyLeftXSecondValue= 0;
                bool setKeyLeftYFirstValue = false;
                bool setKeyLeftYSecondValue = false;
                float KeyLeftYFirstValue= 0;
                float KeyLeftYSecondValue= 0;
                bool setKeyMHeightFirstValue = false;
                bool setKeyMHeightSecondValue = false;
                float KeyMHeightFirstValue= 0;
                float KeyMHeightSecondValue= 0;
                bool setKeyMWidthFirstValue = false;
                bool setKeyMWidthSecondValue = false;
                float KeyMWidthFirstValue= 0;
                float KeyMWidthSecondValue= 0;
                bool setKeyNHeightFirstValue = false;
                bool setKeyNHeightSecondValue = false;
                float KeyNHeightFirstValue= 0;
                float KeyNHeightSecondValue= 0;
                bool setKeyNWidthFirstValue = false;
                bool setKeyNWidthSecondValue = false;
                float KeyNWidthFirstValue= 0;
                float KeyNWidthSecondValue= 0;
                bool setKeyOHeightFirstValue = false;
                bool setKeyOHeightSecondValue = false;
                float KeyOHeightFirstValue= 0;
                float KeyOHeightSecondValue= 0;
                bool setKeyOWidthFirstValue = false;
                bool setKeyOWidthSecondValue = false;
                float KeyOWidthFirstValue= 0;
                float KeyOWidthSecondValue= 0;
                bool setKeyPHeightFirstValue = false;
                bool setKeyPHeightSecondValue = false;
                float KeyPHeightFirstValue= 0;
                float KeyPHeightSecondValue= 0;
                bool setKeyPWidthFirstValue = false;
                bool setKeyPWidthSecondValue = false;
                float KeyPWidthFirstValue= 0;
                float KeyPWidthSecondValue= 0;
                bool setKeyParenLeftHeightFirstValue = false;
                bool setKeyParenLeftHeightSecondValue = false;
                float KeyParenLeftHeightFirstValue= 0;
                float KeyParenLeftHeightSecondValue= 0;
                bool setKeyParenLeftWidthFirstValue = false;
                bool setKeyParenLeftWidthSecondValue = false;
                float KeyParenLeftWidthFirstValue= 0;
                float KeyParenLeftWidthSecondValue= 0;
                bool setKeyParenRightHeightFirstValue = false;
                bool setKeyParenRightHeightSecondValue = false;
                float KeyParenRightHeightFirstValue= 0;
                float KeyParenRightHeightSecondValue= 0;
                bool setKeyParenRightWidthFirstValue = false;
                bool setKeyParenRightWidthSecondValue = false;
                float KeyParenRightWidthFirstValue= 0;
                float KeyParenRightWidthSecondValue= 0;
                bool setKeyPeriodHeightFirstValue = false;
                bool setKeyPeriodHeightSecondValue = false;
                float KeyPeriodHeightFirstValue= 0;
                float KeyPeriodHeightSecondValue= 0;
                bool setKeyPeriodWidthFirstValue = false;
                bool setKeyPeriodWidthSecondValue = false;
                float KeyPeriodWidthFirstValue= 0;
                float KeyPeriodWidthSecondValue= 0;
                bool setKeyQHeightFirstValue = false;
                bool setKeyQHeightSecondValue = false;
                float KeyQHeightFirstValue= 0;
                float KeyQHeightSecondValue= 0;
                bool setKeyQWidthFirstValue = false;
                bool setKeyQWidthSecondValue = false;
                float KeyQWidthFirstValue= 0;
                float KeyQWidthSecondValue= 0;
                bool setKeyQuestionHeightFirstValue = false;
                bool setKeyQuestionHeightSecondValue = false;
                float KeyQuestionHeightFirstValue= 0;
                float KeyQuestionHeightSecondValue= 0;
                bool setKeyQuestionWidthFirstValue = false;
                bool setKeyQuestionWidthSecondValue = false;
                float KeyQuestionWidthFirstValue= 0;
                float KeyQuestionWidthSecondValue= 0;
                bool setKeyRHeightFirstValue = false;
                bool setKeyRHeightSecondValue = false;
                float KeyRHeightFirstValue= 0;
                float KeyRHeightSecondValue= 0;
                bool setKeyRWidthFirstValue = false;
                bool setKeyRWidthSecondValue = false;
                float KeyRWidthFirstValue= 0;
                float KeyRWidthSecondValue= 0;
                bool setKeyReturnHeightFirstValue = false;
                bool setKeyReturnHeightSecondValue = false;
                float KeyReturnHeightFirstValue= 0;
                float KeyReturnHeightSecondValue= 0;
                bool setKeyReturnWidthFirstValue = false;
                bool setKeyReturnWidthSecondValue = false;
                float KeyReturnWidthFirstValue= 0;
                float KeyReturnWidthSecondValue= 0;
                bool setKeyRightWidthFirstValue = false;
                bool setKeyRightWidthSecondValue = false;
                float KeyRightWidthFirstValue= 0;
                float KeyRightWidthSecondValue= 0;
                bool setKeyRightXFirstValue = false;
                bool setKeyRightXSecondValue = false;
                float KeyRightXFirstValue= 0;
                float KeyRightXSecondValue= 0;
                bool setKeyRightYFirstValue = false;
                bool setKeyRightYSecondValue = false;
                float KeyRightYFirstValue= 0;
                float KeyRightYSecondValue= 0;
                bool setKeyRowsHeightFirstValue = false;
                bool setKeyRowsHeightSecondValue = false;
                float KeyRowsHeightFirstValue= 0;
                float KeyRowsHeightSecondValue= 0;
                bool setKeyRowsWidthFirstValue = false;
                bool setKeyRowsWidthSecondValue = false;
                float KeyRowsWidthFirstValue= 0;
                float KeyRowsWidthSecondValue= 0;
                bool setKeyRowsXFirstValue = false;
                bool setKeyRowsXSecondValue = false;
                float KeyRowsXFirstValue= 0;
                float KeyRowsXSecondValue= 0;
                bool setKeyRowsYFirstValue = false;
                bool setKeyRowsYSecondValue = false;
                float KeyRowsYFirstValue= 0;
                float KeyRowsYSecondValue= 0;
                bool setKeySHeightFirstValue = false;
                bool setKeySHeightSecondValue = false;
                float KeySHeightFirstValue= 0;
                float KeySHeightSecondValue= 0;
                bool setKeySWidthFirstValue = false;
                bool setKeySWidthSecondValue = false;
                float KeySWidthFirstValue= 0;
                float KeySWidthSecondValue= 0;
                bool setKeySpaceHeightFirstValue = false;
                bool setKeySpaceHeightSecondValue = false;
                float KeySpaceHeightFirstValue= 0;
                float KeySpaceHeightSecondValue= 0;
                bool setKeySpaceWidthFirstValue = false;
                bool setKeySpaceWidthSecondValue = false;
                float KeySpaceWidthFirstValue= 0;
                float KeySpaceWidthSecondValue= 0;
                bool setKeyTHeightFirstValue = false;
                bool setKeyTHeightSecondValue = false;
                float KeyTHeightFirstValue= 0;
                float KeyTHeightSecondValue= 0;
                bool setKeyTWidthFirstValue = false;
                bool setKeyTWidthSecondValue = false;
                float KeyTWidthFirstValue= 0;
                float KeyTWidthSecondValue= 0;
                bool setKeyUHeightFirstValue = false;
                bool setKeyUHeightSecondValue = false;
                float KeyUHeightFirstValue= 0;
                float KeyUHeightSecondValue= 0;
                bool setKeyUWidthFirstValue = false;
                bool setKeyUWidthSecondValue = false;
                float KeyUWidthFirstValue= 0;
                float KeyUWidthSecondValue= 0;
                bool setKeyUnderscoreHeightFirstValue = false;
                bool setKeyUnderscoreHeightSecondValue = false;
                float KeyUnderscoreHeightFirstValue= 0;
                float KeyUnderscoreHeightSecondValue= 0;
                bool setKeyUnderscoreWidthFirstValue = false;
                bool setKeyUnderscoreWidthSecondValue = false;
                float KeyUnderscoreWidthFirstValue= 0;
                float KeyUnderscoreWidthSecondValue= 0;
                bool setKeyVHeightFirstValue = false;
                bool setKeyVHeightSecondValue = false;
                float KeyVHeightFirstValue= 0;
                float KeyVHeightSecondValue= 0;
                bool setKeyVWidthFirstValue = false;
                bool setKeyVWidthSecondValue = false;
                float KeyVWidthFirstValue= 0;
                float KeyVWidthSecondValue= 0;
                bool setKeyWHeightFirstValue = false;
                bool setKeyWHeightSecondValue = false;
                float KeyWHeightFirstValue= 0;
                float KeyWHeightSecondValue= 0;
                bool setKeyWWidthFirstValue = false;
                bool setKeyWWidthSecondValue = false;
                float KeyWWidthFirstValue= 0;
                float KeyWWidthSecondValue= 0;
                bool setKeyXHeightFirstValue = false;
                bool setKeyXHeightSecondValue = false;
                float KeyXHeightFirstValue= 0;
                float KeyXHeightSecondValue= 0;
                bool setKeyXWidthFirstValue = false;
                bool setKeyXWidthSecondValue = false;
                float KeyXWidthFirstValue= 0;
                float KeyXWidthSecondValue= 0;
                bool setKeyYHeightFirstValue = false;
                bool setKeyYHeightSecondValue = false;
                float KeyYHeightFirstValue= 0;
                float KeyYHeightSecondValue= 0;
                bool setKeyYWidthFirstValue = false;
                bool setKeyYWidthSecondValue = false;
                float KeyYWidthFirstValue= 0;
                float KeyYWidthSecondValue= 0;
                bool setKeyZHeightFirstValue = false;
                bool setKeyZHeightSecondValue = false;
                float KeyZHeightFirstValue= 0;
                float KeyZHeightSecondValue= 0;
                bool setKeyZWidthFirstValue = false;
                bool setKeyZWidthSecondValue = false;
                float KeyZWidthFirstValue= 0;
                float KeyZWidthSecondValue= 0;
                bool setRow1KeysHeightFirstValue = false;
                bool setRow1KeysHeightSecondValue = false;
                float Row1KeysHeightFirstValue= 0;
                float Row1KeysHeightSecondValue= 0;
                bool setRow1KeysWidthFirstValue = false;
                bool setRow1KeysWidthSecondValue = false;
                float Row1KeysWidthFirstValue= 0;
                float Row1KeysWidthSecondValue= 0;
                bool setRow2KeysHeightFirstValue = false;
                bool setRow2KeysHeightSecondValue = false;
                float Row2KeysHeightFirstValue= 0;
                float Row2KeysHeightSecondValue= 0;
                bool setRow2KeysWidthFirstValue = false;
                bool setRow2KeysWidthSecondValue = false;
                float Row2KeysWidthFirstValue= 0;
                float Row2KeysWidthSecondValue= 0;
                bool setRow3KeysHeightFirstValue = false;
                bool setRow3KeysHeightSecondValue = false;
                float Row3KeysHeightFirstValue= 0;
                float Row3KeysHeightSecondValue= 0;
                bool setRow3KeysWidthFirstValue = false;
                bool setRow3KeysWidthSecondValue = false;
                float Row3KeysWidthFirstValue= 0;
                float Row3KeysWidthSecondValue= 0;
                bool setRow4KeysHeightFirstValue = false;
                bool setRow4KeysHeightSecondValue = false;
                float Row4KeysHeightFirstValue= 0;
                float Row4KeysHeightSecondValue= 0;
                bool setRow4KeysWidthFirstValue = false;
                bool setRow4KeysWidthSecondValue = false;
                float Row4KeysWidthFirstValue= 0;
                float Row4KeysWidthSecondValue= 0;
                bool setRow5KeysHeightFirstValue = false;
                bool setRow5KeysHeightSecondValue = false;
                float Row5KeysHeightFirstValue= 0;
                float Row5KeysHeightSecondValue= 0;
                bool setRow5KeysWidthFirstValue = false;
                bool setRow5KeysWidthSecondValue = false;
                float Row5KeysWidthFirstValue= 0;
                float Row5KeysWidthSecondValue= 0;
                bool setWidthFirstValue = false;
                bool setWidthSecondValue = false;
                float WidthFirstValue= 0;
                float WidthSecondValue= 0;
                switch(firstState)
                {
                    case  VariableState.Default:
                        setKey0HeightFirstValue = true;
                        Key0HeightFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.Key0.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        if (interpolationValue < 1)
                        {
                            this.Key0.Parent = this.GetGraphicalUiElementByName("Row1Keys") ?? this;
                        }
                        if (interpolationValue < 1)
                        {
                            this.Key0.Text = "0";
                        }
                        setKey0WidthFirstValue = true;
                        Key0WidthFirstValue = 10f;
                        if (interpolationValue < 1)
                        {
                            this.Key0.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.Key0.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.Key0.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setKey1HeightFirstValue = true;
                        Key1HeightFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.Key1.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        if (interpolationValue < 1)
                        {
                            this.Key1.Parent = this.GetGraphicalUiElementByName("Row1Keys") ?? this;
                        }
                        if (interpolationValue < 1)
                        {
                            this.Key1.Text = "1";
                        }
                        setKey1WidthFirstValue = true;
                        Key1WidthFirstValue = 10f;
                        if (interpolationValue < 1)
                        {
                            this.Key1.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.Key1.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.Key1.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setKey2HeightFirstValue = true;
                        Key2HeightFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.Key2.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        if (interpolationValue < 1)
                        {
                            this.Key2.Parent = this.GetGraphicalUiElementByName("Row1Keys") ?? this;
                        }
                        if (interpolationValue < 1)
                        {
                            this.Key2.Text = "2";
                        }
                        setKey2WidthFirstValue = true;
                        Key2WidthFirstValue = 10f;
                        if (interpolationValue < 1)
                        {
                            this.Key2.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.Key2.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.Key2.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setKey3HeightFirstValue = true;
                        Key3HeightFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.Key3.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        if (interpolationValue < 1)
                        {
                            this.Key3.Parent = this.GetGraphicalUiElementByName("Row1Keys") ?? this;
                        }
                        if (interpolationValue < 1)
                        {
                            this.Key3.Text = "3";
                        }
                        setKey3WidthFirstValue = true;
                        Key3WidthFirstValue = 10f;
                        if (interpolationValue < 1)
                        {
                            this.Key3.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.Key3.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.Key3.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setKey4HeightFirstValue = true;
                        Key4HeightFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.Key4.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        if (interpolationValue < 1)
                        {
                            this.Key4.Parent = this.GetGraphicalUiElementByName("Row1Keys") ?? this;
                        }
                        if (interpolationValue < 1)
                        {
                            this.Key4.Text = "4";
                        }
                        setKey4WidthFirstValue = true;
                        Key4WidthFirstValue = 10f;
                        if (interpolationValue < 1)
                        {
                            this.Key4.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.Key4.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.Key4.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setKey5HeightFirstValue = true;
                        Key5HeightFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.Key5.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        if (interpolationValue < 1)
                        {
                            this.Key5.Parent = this.GetGraphicalUiElementByName("Row1Keys") ?? this;
                        }
                        if (interpolationValue < 1)
                        {
                            this.Key5.Text = "5";
                        }
                        setKey5WidthFirstValue = true;
                        Key5WidthFirstValue = 10f;
                        if (interpolationValue < 1)
                        {
                            this.Key5.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.Key5.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.Key5.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setKey6HeightFirstValue = true;
                        Key6HeightFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.Key6.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        if (interpolationValue < 1)
                        {
                            this.Key6.Parent = this.GetGraphicalUiElementByName("Row1Keys") ?? this;
                        }
                        if (interpolationValue < 1)
                        {
                            this.Key6.Text = "6";
                        }
                        setKey6WidthFirstValue = true;
                        Key6WidthFirstValue = 10f;
                        if (interpolationValue < 1)
                        {
                            this.Key6.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.Key6.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.Key6.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setKey7HeightFirstValue = true;
                        Key7HeightFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.Key7.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        if (interpolationValue < 1)
                        {
                            this.Key7.Parent = this.GetGraphicalUiElementByName("Row1Keys") ?? this;
                        }
                        if (interpolationValue < 1)
                        {
                            this.Key7.Text = "7";
                        }
                        setKey7WidthFirstValue = true;
                        Key7WidthFirstValue = 10f;
                        if (interpolationValue < 1)
                        {
                            this.Key7.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.Key7.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.Key7.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setKey8HeightFirstValue = true;
                        Key8HeightFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.Key8.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        if (interpolationValue < 1)
                        {
                            this.Key8.Parent = this.GetGraphicalUiElementByName("Row1Keys") ?? this;
                        }
                        if (interpolationValue < 1)
                        {
                            this.Key8.Text = "8";
                        }
                        setKey8WidthFirstValue = true;
                        Key8WidthFirstValue = 10f;
                        if (interpolationValue < 1)
                        {
                            this.Key8.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.Key8.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.Key8.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setKey9HeightFirstValue = true;
                        Key9HeightFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.Key9.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        if (interpolationValue < 1)
                        {
                            this.Key9.Parent = this.GetGraphicalUiElementByName("Row1Keys") ?? this;
                        }
                        if (interpolationValue < 1)
                        {
                            this.Key9.Text = "9";
                        }
                        setKey9WidthFirstValue = true;
                        Key9WidthFirstValue = 10f;
                        if (interpolationValue < 1)
                        {
                            this.Key9.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.Key9.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.Key9.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setKeyAHeightFirstValue = true;
                        KeyAHeightFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.KeyA.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        if (interpolationValue < 1)
                        {
                            this.KeyA.Parent = this.GetGraphicalUiElementByName("Row3Keys") ?? this;
                        }
                        if (interpolationValue < 1)
                        {
                            this.KeyA.Text = "A";
                        }
                        setKeyAWidthFirstValue = true;
                        KeyAWidthFirstValue = 10f;
                        if (interpolationValue < 1)
                        {
                            this.KeyA.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.KeyA.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.KeyA.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setKeyAmpersandHeightFirstValue = true;
                        KeyAmpersandHeightFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.KeyAmpersand.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        if (interpolationValue < 1)
                        {
                            this.KeyAmpersand.Parent = this.GetGraphicalUiElementByName("Row5Keys") ?? this;
                        }
                        if (interpolationValue < 1)
                        {
                            this.KeyAmpersand.Text = "&";
                        }
                        setKeyAmpersandWidthFirstValue = true;
                        KeyAmpersandWidthFirstValue = 10f;
                        if (interpolationValue < 1)
                        {
                            this.KeyAmpersand.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.KeyAmpersand.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.KeyAmpersand.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setKeyBHeightFirstValue = true;
                        KeyBHeightFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.KeyB.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        if (interpolationValue < 1)
                        {
                            this.KeyB.Parent = this.GetGraphicalUiElementByName("Row4Keys") ?? this;
                        }
                        if (interpolationValue < 1)
                        {
                            this.KeyB.Text = "B";
                        }
                        setKeyBWidthFirstValue = true;
                        KeyBWidthFirstValue = 10f;
                        if (interpolationValue < 1)
                        {
                            this.KeyB.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.KeyB.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.KeyB.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setKeyBackspaceHeightFirstValue = true;
                        KeyBackspaceHeightFirstValue = 20f;
                        if (interpolationValue < 1)
                        {
                            this.KeyBackspace.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.KeyBackspace.Text = "";
                        }
                        setKeyBackspaceWidthFirstValue = true;
                        KeyBackspaceWidthFirstValue = 10f;
                        if (interpolationValue < 1)
                        {
                            this.KeyBackspace.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.KeyBackspace.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                        }
                        if (interpolationValue < 1)
                        {
                            this.KeyBackspace.XUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                        }
                        setKeyBangHeightFirstValue = true;
                        KeyBangHeightFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.KeyBang.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        if (interpolationValue < 1)
                        {
                            this.KeyBang.Parent = this.GetGraphicalUiElementByName("Row5Keys") ?? this;
                        }
                        if (interpolationValue < 1)
                        {
                            this.KeyBang.Text = "!";
                        }
                        setKeyBangWidthFirstValue = true;
                        KeyBangWidthFirstValue = 10f;
                        if (interpolationValue < 1)
                        {
                            this.KeyBang.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.KeyBang.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.KeyBang.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setKeyCHeightFirstValue = true;
                        KeyCHeightFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.KeyC.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        if (interpolationValue < 1)
                        {
                            this.KeyC.Parent = this.GetGraphicalUiElementByName("Row4Keys") ?? this;
                        }
                        if (interpolationValue < 1)
                        {
                            this.KeyC.Text = "C";
                        }
                        setKeyCWidthFirstValue = true;
                        KeyCWidthFirstValue = 10f;
                        if (interpolationValue < 1)
                        {
                            this.KeyC.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.KeyC.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.KeyC.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setKeyCommaHeightFirstValue = true;
                        KeyCommaHeightFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.KeyComma.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        if (interpolationValue < 1)
                        {
                            this.KeyComma.Parent = this.GetGraphicalUiElementByName("Row4Keys") ?? this;
                        }
                        if (interpolationValue < 1)
                        {
                            this.KeyComma.Text = ",";
                        }
                        setKeyCommaWidthFirstValue = true;
                        KeyCommaWidthFirstValue = 10f;
                        if (interpolationValue < 1)
                        {
                            this.KeyComma.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.KeyComma.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.KeyComma.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setKeyDHeightFirstValue = true;
                        KeyDHeightFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.KeyD.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        if (interpolationValue < 1)
                        {
                            this.KeyD.Parent = this.GetGraphicalUiElementByName("Row3Keys") ?? this;
                        }
                        if (interpolationValue < 1)
                        {
                            this.KeyD.Text = "D";
                        }
                        setKeyDWidthFirstValue = true;
                        KeyDWidthFirstValue = 10f;
                        if (interpolationValue < 1)
                        {
                            this.KeyD.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.KeyD.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.KeyD.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setKeyEHeightFirstValue = true;
                        KeyEHeightFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.KeyE.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        if (interpolationValue < 1)
                        {
                            this.KeyE.Parent = this.GetGraphicalUiElementByName("Row2Keys") ?? this;
                        }
                        if (interpolationValue < 1)
                        {
                            this.KeyE.Text = "E";
                        }
                        setKeyEWidthFirstValue = true;
                        KeyEWidthFirstValue = 10f;
                        if (interpolationValue < 1)
                        {
                            this.KeyE.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.KeyE.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.KeyE.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setKeyFHeightFirstValue = true;
                        KeyFHeightFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.KeyF.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        if (interpolationValue < 1)
                        {
                            this.KeyF.Parent = this.GetGraphicalUiElementByName("Row3Keys") ?? this;
                        }
                        if (interpolationValue < 1)
                        {
                            this.KeyF.Text = "F";
                        }
                        setKeyFWidthFirstValue = true;
                        KeyFWidthFirstValue = 10f;
                        if (interpolationValue < 1)
                        {
                            this.KeyF.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.KeyF.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.KeyF.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setKeyGHeightFirstValue = true;
                        KeyGHeightFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.KeyG.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        if (interpolationValue < 1)
                        {
                            this.KeyG.Parent = this.GetGraphicalUiElementByName("Row3Keys") ?? this;
                        }
                        if (interpolationValue < 1)
                        {
                            this.KeyG.Text = "G";
                        }
                        setKeyGWidthFirstValue = true;
                        KeyGWidthFirstValue = 10f;
                        if (interpolationValue < 1)
                        {
                            this.KeyG.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.KeyG.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.KeyG.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setKeyHHeightFirstValue = true;
                        KeyHHeightFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.KeyH.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        if (interpolationValue < 1)
                        {
                            this.KeyH.Parent = this.GetGraphicalUiElementByName("Row3Keys") ?? this;
                        }
                        if (interpolationValue < 1)
                        {
                            this.KeyH.Text = "H";
                        }
                        setKeyHWidthFirstValue = true;
                        KeyHWidthFirstValue = 10f;
                        if (interpolationValue < 1)
                        {
                            this.KeyH.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.KeyH.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.KeyH.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setKeyHyphenHeightFirstValue = true;
                        KeyHyphenHeightFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.KeyHyphen.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        if (interpolationValue < 1)
                        {
                            this.KeyHyphen.Parent = this.GetGraphicalUiElementByName("Row4Keys") ?? this;
                        }
                        if (interpolationValue < 1)
                        {
                            this.KeyHyphen.Text = "-";
                        }
                        setKeyHyphenWidthFirstValue = true;
                        KeyHyphenWidthFirstValue = 10f;
                        if (interpolationValue < 1)
                        {
                            this.KeyHyphen.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.KeyHyphen.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.KeyHyphen.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setKeyIHeightFirstValue = true;
                        KeyIHeightFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.KeyI.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        if (interpolationValue < 1)
                        {
                            this.KeyI.Parent = this.GetGraphicalUiElementByName("Row2Keys") ?? this;
                        }
                        if (interpolationValue < 1)
                        {
                            this.KeyI.Text = "I";
                        }
                        setKeyIWidthFirstValue = true;
                        KeyIWidthFirstValue = 10f;
                        if (interpolationValue < 1)
                        {
                            this.KeyI.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.KeyI.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.KeyI.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setKeyJHeightFirstValue = true;
                        KeyJHeightFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.KeyJ.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        if (interpolationValue < 1)
                        {
                            this.KeyJ.Parent = this.GetGraphicalUiElementByName("Row3Keys") ?? this;
                        }
                        if (interpolationValue < 1)
                        {
                            this.KeyJ.Text = "J";
                        }
                        setKeyJWidthFirstValue = true;
                        KeyJWidthFirstValue = 10f;
                        if (interpolationValue < 1)
                        {
                            this.KeyJ.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.KeyJ.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.KeyJ.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setKeyKHeightFirstValue = true;
                        KeyKHeightFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.KeyK.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        if (interpolationValue < 1)
                        {
                            this.KeyK.Parent = this.GetGraphicalUiElementByName("Row3Keys") ?? this;
                        }
                        if (interpolationValue < 1)
                        {
                            this.KeyK.Text = "K";
                        }
                        setKeyKWidthFirstValue = true;
                        KeyKWidthFirstValue = 10f;
                        if (interpolationValue < 1)
                        {
                            this.KeyK.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.KeyK.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.KeyK.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setKeyLHeightFirstValue = true;
                        KeyLHeightFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.KeyL.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        if (interpolationValue < 1)
                        {
                            this.KeyL.Parent = this.GetGraphicalUiElementByName("Row3Keys") ?? this;
                        }
                        if (interpolationValue < 1)
                        {
                            this.KeyL.Text = "L";
                        }
                        setKeyLWidthFirstValue = true;
                        KeyLWidthFirstValue = 10f;
                        if (interpolationValue < 1)
                        {
                            this.KeyL.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.KeyL.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.KeyL.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        if (interpolationValue < 1)
                        {
                            this.KeyLeft.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.KeyLeft.Text = "";
                        }
                        setKeyLeftWidthFirstValue = true;
                        KeyLeftWidthFirstValue = 10f;
                        if (interpolationValue < 1)
                        {
                            this.KeyLeft.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setKeyLeftXFirstValue = true;
                        KeyLeftXFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.KeyLeft.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                        }
                        if (interpolationValue < 1)
                        {
                            this.KeyLeft.XUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                        }
                        setKeyLeftYFirstValue = true;
                        KeyLeftYFirstValue = 20f;
                        if (interpolationValue < 1)
                        {
                            this.KeyLeft.YUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setKeyMHeightFirstValue = true;
                        KeyMHeightFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.KeyM.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        if (interpolationValue < 1)
                        {
                            this.KeyM.Parent = this.GetGraphicalUiElementByName("Row4Keys") ?? this;
                        }
                        if (interpolationValue < 1)
                        {
                            this.KeyM.Text = "M";
                        }
                        setKeyMWidthFirstValue = true;
                        KeyMWidthFirstValue = 10f;
                        if (interpolationValue < 1)
                        {
                            this.KeyM.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.KeyM.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.KeyM.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setKeyNHeightFirstValue = true;
                        KeyNHeightFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.KeyN.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        if (interpolationValue < 1)
                        {
                            this.KeyN.Parent = this.GetGraphicalUiElementByName("Row4Keys") ?? this;
                        }
                        if (interpolationValue < 1)
                        {
                            this.KeyN.Text = "N";
                        }
                        setKeyNWidthFirstValue = true;
                        KeyNWidthFirstValue = 10f;
                        if (interpolationValue < 1)
                        {
                            this.KeyN.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.KeyN.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.KeyN.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setKeyOHeightFirstValue = true;
                        KeyOHeightFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.KeyO.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        if (interpolationValue < 1)
                        {
                            this.KeyO.Parent = this.GetGraphicalUiElementByName("Row2Keys") ?? this;
                        }
                        if (interpolationValue < 1)
                        {
                            this.KeyO.Text = "O";
                        }
                        setKeyOWidthFirstValue = true;
                        KeyOWidthFirstValue = 10f;
                        if (interpolationValue < 1)
                        {
                            this.KeyO.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.KeyO.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.KeyO.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setKeyPHeightFirstValue = true;
                        KeyPHeightFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.KeyP.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        if (interpolationValue < 1)
                        {
                            this.KeyP.Parent = this.GetGraphicalUiElementByName("Row2Keys") ?? this;
                        }
                        if (interpolationValue < 1)
                        {
                            this.KeyP.Text = "P";
                        }
                        setKeyPWidthFirstValue = true;
                        KeyPWidthFirstValue = 10f;
                        if (interpolationValue < 1)
                        {
                            this.KeyP.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.KeyP.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.KeyP.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setKeyParenLeftHeightFirstValue = true;
                        KeyParenLeftHeightFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.KeyParenLeft.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        if (interpolationValue < 1)
                        {
                            this.KeyParenLeft.Parent = this.GetGraphicalUiElementByName("Row5Keys") ?? this;
                        }
                        if (interpolationValue < 1)
                        {
                            this.KeyParenLeft.Text = "(";
                        }
                        setKeyParenLeftWidthFirstValue = true;
                        KeyParenLeftWidthFirstValue = 10f;
                        if (interpolationValue < 1)
                        {
                            this.KeyParenLeft.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.KeyParenLeft.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.KeyParenLeft.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setKeyParenRightHeightFirstValue = true;
                        KeyParenRightHeightFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.KeyParenRight.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        if (interpolationValue < 1)
                        {
                            this.KeyParenRight.Parent = this.GetGraphicalUiElementByName("Row5Keys") ?? this;
                        }
                        if (interpolationValue < 1)
                        {
                            this.KeyParenRight.Text = ")";
                        }
                        setKeyParenRightWidthFirstValue = true;
                        KeyParenRightWidthFirstValue = 10f;
                        if (interpolationValue < 1)
                        {
                            this.KeyParenRight.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.KeyParenRight.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.KeyParenRight.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setKeyPeriodHeightFirstValue = true;
                        KeyPeriodHeightFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.KeyPeriod.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        if (interpolationValue < 1)
                        {
                            this.KeyPeriod.Parent = this.GetGraphicalUiElementByName("Row4Keys") ?? this;
                        }
                        if (interpolationValue < 1)
                        {
                            this.KeyPeriod.Text = ".";
                        }
                        setKeyPeriodWidthFirstValue = true;
                        KeyPeriodWidthFirstValue = 10f;
                        if (interpolationValue < 1)
                        {
                            this.KeyPeriod.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.KeyPeriod.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.KeyPeriod.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setKeyQHeightFirstValue = true;
                        KeyQHeightFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.KeyQ.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        if (interpolationValue < 1)
                        {
                            this.KeyQ.Parent = this.GetGraphicalUiElementByName("Row2Keys") ?? this;
                        }
                        if (interpolationValue < 1)
                        {
                            this.KeyQ.Text = "Q";
                        }
                        setKeyQWidthFirstValue = true;
                        KeyQWidthFirstValue = 10f;
                        if (interpolationValue < 1)
                        {
                            this.KeyQ.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.KeyQ.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.KeyQ.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setKeyQuestionHeightFirstValue = true;
                        KeyQuestionHeightFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.KeyQuestion.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        if (interpolationValue < 1)
                        {
                            this.KeyQuestion.Parent = this.GetGraphicalUiElementByName("Row5Keys") ?? this;
                        }
                        if (interpolationValue < 1)
                        {
                            this.KeyQuestion.Text = "?";
                        }
                        setKeyQuestionWidthFirstValue = true;
                        KeyQuestionWidthFirstValue = 10f;
                        if (interpolationValue < 1)
                        {
                            this.KeyQuestion.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.KeyQuestion.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.KeyQuestion.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setKeyRHeightFirstValue = true;
                        KeyRHeightFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.KeyR.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        if (interpolationValue < 1)
                        {
                            this.KeyR.Parent = this.GetGraphicalUiElementByName("Row2Keys") ?? this;
                        }
                        if (interpolationValue < 1)
                        {
                            this.KeyR.Text = "R";
                        }
                        setKeyRWidthFirstValue = true;
                        KeyRWidthFirstValue = 10f;
                        if (interpolationValue < 1)
                        {
                            this.KeyR.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.KeyR.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.KeyR.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setKeyReturnHeightFirstValue = true;
                        KeyReturnHeightFirstValue = 40f;
                        if (interpolationValue < 1)
                        {
                            this.KeyReturn.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.KeyReturn.Text = "";
                        }
                        setKeyReturnWidthFirstValue = true;
                        KeyReturnWidthFirstValue = 10f;
                        if (interpolationValue < 1)
                        {
                            this.KeyReturn.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.KeyReturn.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                        }
                        if (interpolationValue < 1)
                        {
                            this.KeyReturn.XUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                        }
                        if (interpolationValue < 1)
                        {
                            this.KeyReturn.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Bottom;
                        }
                        if (interpolationValue < 1)
                        {
                            this.KeyReturn.YUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                        }
                        if (interpolationValue < 1)
                        {
                            this.KeyRight.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.KeyRight.Text = "";
                        }
                        setKeyRightWidthFirstValue = true;
                        KeyRightWidthFirstValue = 10f;
                        if (interpolationValue < 1)
                        {
                            this.KeyRight.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setKeyRightXFirstValue = true;
                        KeyRightXFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.KeyRight.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                        }
                        if (interpolationValue < 1)
                        {
                            this.KeyRight.XUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                        }
                        setKeyRightYFirstValue = true;
                        KeyRightYFirstValue = 40f;
                        if (interpolationValue < 1)
                        {
                            this.KeyRight.YUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.KeyRows.ChildrenLayout = Gum.Managers.ChildrenLayout.TopToBottomStack;
                        }
                        setKeyRowsHeightFirstValue = true;
                        KeyRowsHeightFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.KeyRows.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        setKeyRowsWidthFirstValue = true;
                        KeyRowsWidthFirstValue = 90f;
                        if (interpolationValue < 1)
                        {
                            this.KeyRows.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setKeyRowsXFirstValue = true;
                        KeyRowsXFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.KeyRows.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                        }
                        if (interpolationValue < 1)
                        {
                            this.KeyRows.XUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                        }
                        setKeyRowsYFirstValue = true;
                        KeyRowsYFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.KeyRows.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.KeyRows.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setKeySHeightFirstValue = true;
                        KeySHeightFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.KeyS.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        if (interpolationValue < 1)
                        {
                            this.KeyS.Parent = this.GetGraphicalUiElementByName("Row3Keys") ?? this;
                        }
                        if (interpolationValue < 1)
                        {
                            this.KeyS.Text = "S";
                        }
                        setKeySWidthFirstValue = true;
                        KeySWidthFirstValue = 10f;
                        if (interpolationValue < 1)
                        {
                            this.KeyS.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.KeyS.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.KeyS.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setKeySpaceHeightFirstValue = true;
                        KeySpaceHeightFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.KeySpace.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        if (interpolationValue < 1)
                        {
                            this.KeySpace.Parent = this.GetGraphicalUiElementByName("Row5Keys") ?? this;
                        }
                        if (interpolationValue < 1)
                        {
                            this.KeySpace.Text = "SPACE";
                        }
                        setKeySpaceWidthFirstValue = true;
                        KeySpaceWidthFirstValue = 50f;
                        if (interpolationValue < 1)
                        {
                            this.KeySpace.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.KeySpace.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.KeySpace.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setKeyTHeightFirstValue = true;
                        KeyTHeightFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.KeyT.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        if (interpolationValue < 1)
                        {
                            this.KeyT.Parent = this.GetGraphicalUiElementByName("Row2Keys") ?? this;
                        }
                        if (interpolationValue < 1)
                        {
                            this.KeyT.Text = "T";
                        }
                        setKeyTWidthFirstValue = true;
                        KeyTWidthFirstValue = 10f;
                        if (interpolationValue < 1)
                        {
                            this.KeyT.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.KeyT.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.KeyT.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setKeyUHeightFirstValue = true;
                        KeyUHeightFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.KeyU.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        if (interpolationValue < 1)
                        {
                            this.KeyU.Parent = this.GetGraphicalUiElementByName("Row2Keys") ?? this;
                        }
                        if (interpolationValue < 1)
                        {
                            this.KeyU.Text = "U";
                        }
                        setKeyUWidthFirstValue = true;
                        KeyUWidthFirstValue = 10f;
                        if (interpolationValue < 1)
                        {
                            this.KeyU.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.KeyU.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.KeyU.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setKeyUnderscoreHeightFirstValue = true;
                        KeyUnderscoreHeightFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.KeyUnderscore.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        if (interpolationValue < 1)
                        {
                            this.KeyUnderscore.Parent = this.GetGraphicalUiElementByName("Row3Keys") ?? this;
                        }
                        if (interpolationValue < 1)
                        {
                            this.KeyUnderscore.Text = "_";
                        }
                        setKeyUnderscoreWidthFirstValue = true;
                        KeyUnderscoreWidthFirstValue = 10f;
                        if (interpolationValue < 1)
                        {
                            this.KeyUnderscore.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.KeyUnderscore.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.KeyUnderscore.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setKeyVHeightFirstValue = true;
                        KeyVHeightFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.KeyV.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        if (interpolationValue < 1)
                        {
                            this.KeyV.Parent = this.GetGraphicalUiElementByName("Row4Keys") ?? this;
                        }
                        if (interpolationValue < 1)
                        {
                            this.KeyV.Text = "V";
                        }
                        setKeyVWidthFirstValue = true;
                        KeyVWidthFirstValue = 10f;
                        if (interpolationValue < 1)
                        {
                            this.KeyV.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.KeyV.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.KeyV.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setKeyWHeightFirstValue = true;
                        KeyWHeightFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.KeyW.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        if (interpolationValue < 1)
                        {
                            this.KeyW.Parent = this.GetGraphicalUiElementByName("Row2Keys") ?? this;
                        }
                        if (interpolationValue < 1)
                        {
                            this.KeyW.Text = "W";
                        }
                        setKeyWWidthFirstValue = true;
                        KeyWWidthFirstValue = 10f;
                        if (interpolationValue < 1)
                        {
                            this.KeyW.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.KeyW.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.KeyW.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setKeyXHeightFirstValue = true;
                        KeyXHeightFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.KeyX.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        if (interpolationValue < 1)
                        {
                            this.KeyX.Parent = this.GetGraphicalUiElementByName("Row4Keys") ?? this;
                        }
                        if (interpolationValue < 1)
                        {
                            this.KeyX.Text = "X";
                        }
                        setKeyXWidthFirstValue = true;
                        KeyXWidthFirstValue = 10f;
                        if (interpolationValue < 1)
                        {
                            this.KeyX.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.KeyX.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.KeyX.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setKeyYHeightFirstValue = true;
                        KeyYHeightFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.KeyY.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        if (interpolationValue < 1)
                        {
                            this.KeyY.Parent = this.GetGraphicalUiElementByName("Row2Keys") ?? this;
                        }
                        if (interpolationValue < 1)
                        {
                            this.KeyY.Text = "Y";
                        }
                        setKeyYWidthFirstValue = true;
                        KeyYWidthFirstValue = 10f;
                        if (interpolationValue < 1)
                        {
                            this.KeyY.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.KeyY.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.KeyY.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setKeyZHeightFirstValue = true;
                        KeyZHeightFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.KeyZ.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        if (interpolationValue < 1)
                        {
                            this.KeyZ.Parent = this.GetGraphicalUiElementByName("Row4Keys") ?? this;
                        }
                        if (interpolationValue < 1)
                        {
                            this.KeyZ.Text = "Z";
                        }
                        setKeyZWidthFirstValue = true;
                        KeyZWidthFirstValue = 10f;
                        if (interpolationValue < 1)
                        {
                            this.KeyZ.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.KeyZ.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.KeyZ.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        if (interpolationValue < 1)
                        {
                            this.Row1Keys.ChildrenLayout = Gum.Managers.ChildrenLayout.LeftToRightStack;
                        }
                        setRow1KeysHeightFirstValue = true;
                        Row1KeysHeightFirstValue = 20f;
                        if (interpolationValue < 1)
                        {
                            this.Row1Keys.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.Row1Keys.Parent = this.GetGraphicalUiElementByName("KeyRows") ?? this;
                        }
                        setRow1KeysWidthFirstValue = true;
                        Row1KeysWidthFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.Row1Keys.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        if (interpolationValue < 1)
                        {
                            this.Row1Keys.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.Row1Keys.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        if (interpolationValue < 1)
                        {
                            this.Row1Keys.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Top;
                        }
                        if (interpolationValue < 1)
                        {
                            this.Row1Keys.YUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                        }
                        if (interpolationValue < 1)
                        {
                            this.Row2Keys.ChildrenLayout = Gum.Managers.ChildrenLayout.LeftToRightStack;
                        }
                        setRow2KeysHeightFirstValue = true;
                        Row2KeysHeightFirstValue = 20f;
                        if (interpolationValue < 1)
                        {
                            this.Row2Keys.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.Row2Keys.Parent = this.GetGraphicalUiElementByName("KeyRows") ?? this;
                        }
                        setRow2KeysWidthFirstValue = true;
                        Row2KeysWidthFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.Row2Keys.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        if (interpolationValue < 1)
                        {
                            this.Row3Keys.ChildrenLayout = Gum.Managers.ChildrenLayout.LeftToRightStack;
                        }
                        setRow3KeysHeightFirstValue = true;
                        Row3KeysHeightFirstValue = 20f;
                        if (interpolationValue < 1)
                        {
                            this.Row3Keys.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.Row3Keys.Parent = this.GetGraphicalUiElementByName("KeyRows") ?? this;
                        }
                        setRow3KeysWidthFirstValue = true;
                        Row3KeysWidthFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.Row3Keys.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        if (interpolationValue < 1)
                        {
                            this.Row4Keys.ChildrenLayout = Gum.Managers.ChildrenLayout.LeftToRightStack;
                        }
                        setRow4KeysHeightFirstValue = true;
                        Row4KeysHeightFirstValue = 20f;
                        if (interpolationValue < 1)
                        {
                            this.Row4Keys.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.Row4Keys.Parent = this.GetGraphicalUiElementByName("KeyRows") ?? this;
                        }
                        setRow4KeysWidthFirstValue = true;
                        Row4KeysWidthFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.Row4Keys.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        if (interpolationValue < 1)
                        {
                            this.Row5Keys.ChildrenLayout = Gum.Managers.ChildrenLayout.LeftToRightStack;
                        }
                        setRow5KeysHeightFirstValue = true;
                        Row5KeysHeightFirstValue = 20f;
                        if (interpolationValue < 1)
                        {
                            this.Row5Keys.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.Row5Keys.Parent = this.GetGraphicalUiElementByName("KeyRows") ?? this;
                        }
                        setRow5KeysWidthFirstValue = true;
                        Row5KeysWidthFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.Row5Keys.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        setWidthFirstValue = true;
                        WidthFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        if (interpolationValue < 1)
                        {
                            this.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                        }
                        break;
                }
                switch(secondState)
                {
                    case  VariableState.Default:
                        setKey0HeightSecondValue = true;
                        Key0HeightSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.Key0.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.Key0.Parent = this.GetGraphicalUiElementByName("Row1Keys") ?? this;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.Key0.Text = "0";
                        }
                        setKey0WidthSecondValue = true;
                        Key0WidthSecondValue = 10f;
                        if (interpolationValue >= 1)
                        {
                            this.Key0.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.Key0.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.Key0.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setKey1HeightSecondValue = true;
                        Key1HeightSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.Key1.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.Key1.Parent = this.GetGraphicalUiElementByName("Row1Keys") ?? this;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.Key1.Text = "1";
                        }
                        setKey1WidthSecondValue = true;
                        Key1WidthSecondValue = 10f;
                        if (interpolationValue >= 1)
                        {
                            this.Key1.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.Key1.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.Key1.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setKey2HeightSecondValue = true;
                        Key2HeightSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.Key2.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.Key2.Parent = this.GetGraphicalUiElementByName("Row1Keys") ?? this;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.Key2.Text = "2";
                        }
                        setKey2WidthSecondValue = true;
                        Key2WidthSecondValue = 10f;
                        if (interpolationValue >= 1)
                        {
                            this.Key2.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.Key2.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.Key2.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setKey3HeightSecondValue = true;
                        Key3HeightSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.Key3.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.Key3.Parent = this.GetGraphicalUiElementByName("Row1Keys") ?? this;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.Key3.Text = "3";
                        }
                        setKey3WidthSecondValue = true;
                        Key3WidthSecondValue = 10f;
                        if (interpolationValue >= 1)
                        {
                            this.Key3.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.Key3.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.Key3.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setKey4HeightSecondValue = true;
                        Key4HeightSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.Key4.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.Key4.Parent = this.GetGraphicalUiElementByName("Row1Keys") ?? this;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.Key4.Text = "4";
                        }
                        setKey4WidthSecondValue = true;
                        Key4WidthSecondValue = 10f;
                        if (interpolationValue >= 1)
                        {
                            this.Key4.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.Key4.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.Key4.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setKey5HeightSecondValue = true;
                        Key5HeightSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.Key5.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.Key5.Parent = this.GetGraphicalUiElementByName("Row1Keys") ?? this;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.Key5.Text = "5";
                        }
                        setKey5WidthSecondValue = true;
                        Key5WidthSecondValue = 10f;
                        if (interpolationValue >= 1)
                        {
                            this.Key5.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.Key5.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.Key5.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setKey6HeightSecondValue = true;
                        Key6HeightSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.Key6.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.Key6.Parent = this.GetGraphicalUiElementByName("Row1Keys") ?? this;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.Key6.Text = "6";
                        }
                        setKey6WidthSecondValue = true;
                        Key6WidthSecondValue = 10f;
                        if (interpolationValue >= 1)
                        {
                            this.Key6.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.Key6.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.Key6.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setKey7HeightSecondValue = true;
                        Key7HeightSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.Key7.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.Key7.Parent = this.GetGraphicalUiElementByName("Row1Keys") ?? this;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.Key7.Text = "7";
                        }
                        setKey7WidthSecondValue = true;
                        Key7WidthSecondValue = 10f;
                        if (interpolationValue >= 1)
                        {
                            this.Key7.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.Key7.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.Key7.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setKey8HeightSecondValue = true;
                        Key8HeightSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.Key8.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.Key8.Parent = this.GetGraphicalUiElementByName("Row1Keys") ?? this;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.Key8.Text = "8";
                        }
                        setKey8WidthSecondValue = true;
                        Key8WidthSecondValue = 10f;
                        if (interpolationValue >= 1)
                        {
                            this.Key8.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.Key8.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.Key8.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setKey9HeightSecondValue = true;
                        Key9HeightSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.Key9.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.Key9.Parent = this.GetGraphicalUiElementByName("Row1Keys") ?? this;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.Key9.Text = "9";
                        }
                        setKey9WidthSecondValue = true;
                        Key9WidthSecondValue = 10f;
                        if (interpolationValue >= 1)
                        {
                            this.Key9.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.Key9.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.Key9.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setKeyAHeightSecondValue = true;
                        KeyAHeightSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.KeyA.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.KeyA.Parent = this.GetGraphicalUiElementByName("Row3Keys") ?? this;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.KeyA.Text = "A";
                        }
                        setKeyAWidthSecondValue = true;
                        KeyAWidthSecondValue = 10f;
                        if (interpolationValue >= 1)
                        {
                            this.KeyA.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.KeyA.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.KeyA.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setKeyAmpersandHeightSecondValue = true;
                        KeyAmpersandHeightSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.KeyAmpersand.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.KeyAmpersand.Parent = this.GetGraphicalUiElementByName("Row5Keys") ?? this;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.KeyAmpersand.Text = "&";
                        }
                        setKeyAmpersandWidthSecondValue = true;
                        KeyAmpersandWidthSecondValue = 10f;
                        if (interpolationValue >= 1)
                        {
                            this.KeyAmpersand.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.KeyAmpersand.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.KeyAmpersand.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setKeyBHeightSecondValue = true;
                        KeyBHeightSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.KeyB.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.KeyB.Parent = this.GetGraphicalUiElementByName("Row4Keys") ?? this;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.KeyB.Text = "B";
                        }
                        setKeyBWidthSecondValue = true;
                        KeyBWidthSecondValue = 10f;
                        if (interpolationValue >= 1)
                        {
                            this.KeyB.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.KeyB.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.KeyB.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setKeyBackspaceHeightSecondValue = true;
                        KeyBackspaceHeightSecondValue = 20f;
                        if (interpolationValue >= 1)
                        {
                            this.KeyBackspace.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.KeyBackspace.Text = "";
                        }
                        setKeyBackspaceWidthSecondValue = true;
                        KeyBackspaceWidthSecondValue = 10f;
                        if (interpolationValue >= 1)
                        {
                            this.KeyBackspace.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.KeyBackspace.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.KeyBackspace.XUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                        }
                        setKeyBangHeightSecondValue = true;
                        KeyBangHeightSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.KeyBang.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.KeyBang.Parent = this.GetGraphicalUiElementByName("Row5Keys") ?? this;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.KeyBang.Text = "!";
                        }
                        setKeyBangWidthSecondValue = true;
                        KeyBangWidthSecondValue = 10f;
                        if (interpolationValue >= 1)
                        {
                            this.KeyBang.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.KeyBang.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.KeyBang.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setKeyCHeightSecondValue = true;
                        KeyCHeightSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.KeyC.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.KeyC.Parent = this.GetGraphicalUiElementByName("Row4Keys") ?? this;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.KeyC.Text = "C";
                        }
                        setKeyCWidthSecondValue = true;
                        KeyCWidthSecondValue = 10f;
                        if (interpolationValue >= 1)
                        {
                            this.KeyC.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.KeyC.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.KeyC.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setKeyCommaHeightSecondValue = true;
                        KeyCommaHeightSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.KeyComma.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.KeyComma.Parent = this.GetGraphicalUiElementByName("Row4Keys") ?? this;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.KeyComma.Text = ",";
                        }
                        setKeyCommaWidthSecondValue = true;
                        KeyCommaWidthSecondValue = 10f;
                        if (interpolationValue >= 1)
                        {
                            this.KeyComma.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.KeyComma.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.KeyComma.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setKeyDHeightSecondValue = true;
                        KeyDHeightSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.KeyD.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.KeyD.Parent = this.GetGraphicalUiElementByName("Row3Keys") ?? this;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.KeyD.Text = "D";
                        }
                        setKeyDWidthSecondValue = true;
                        KeyDWidthSecondValue = 10f;
                        if (interpolationValue >= 1)
                        {
                            this.KeyD.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.KeyD.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.KeyD.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setKeyEHeightSecondValue = true;
                        KeyEHeightSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.KeyE.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.KeyE.Parent = this.GetGraphicalUiElementByName("Row2Keys") ?? this;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.KeyE.Text = "E";
                        }
                        setKeyEWidthSecondValue = true;
                        KeyEWidthSecondValue = 10f;
                        if (interpolationValue >= 1)
                        {
                            this.KeyE.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.KeyE.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.KeyE.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setKeyFHeightSecondValue = true;
                        KeyFHeightSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.KeyF.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.KeyF.Parent = this.GetGraphicalUiElementByName("Row3Keys") ?? this;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.KeyF.Text = "F";
                        }
                        setKeyFWidthSecondValue = true;
                        KeyFWidthSecondValue = 10f;
                        if (interpolationValue >= 1)
                        {
                            this.KeyF.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.KeyF.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.KeyF.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setKeyGHeightSecondValue = true;
                        KeyGHeightSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.KeyG.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.KeyG.Parent = this.GetGraphicalUiElementByName("Row3Keys") ?? this;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.KeyG.Text = "G";
                        }
                        setKeyGWidthSecondValue = true;
                        KeyGWidthSecondValue = 10f;
                        if (interpolationValue >= 1)
                        {
                            this.KeyG.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.KeyG.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.KeyG.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setKeyHHeightSecondValue = true;
                        KeyHHeightSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.KeyH.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.KeyH.Parent = this.GetGraphicalUiElementByName("Row3Keys") ?? this;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.KeyH.Text = "H";
                        }
                        setKeyHWidthSecondValue = true;
                        KeyHWidthSecondValue = 10f;
                        if (interpolationValue >= 1)
                        {
                            this.KeyH.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.KeyH.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.KeyH.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setKeyHyphenHeightSecondValue = true;
                        KeyHyphenHeightSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.KeyHyphen.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.KeyHyphen.Parent = this.GetGraphicalUiElementByName("Row4Keys") ?? this;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.KeyHyphen.Text = "-";
                        }
                        setKeyHyphenWidthSecondValue = true;
                        KeyHyphenWidthSecondValue = 10f;
                        if (interpolationValue >= 1)
                        {
                            this.KeyHyphen.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.KeyHyphen.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.KeyHyphen.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setKeyIHeightSecondValue = true;
                        KeyIHeightSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.KeyI.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.KeyI.Parent = this.GetGraphicalUiElementByName("Row2Keys") ?? this;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.KeyI.Text = "I";
                        }
                        setKeyIWidthSecondValue = true;
                        KeyIWidthSecondValue = 10f;
                        if (interpolationValue >= 1)
                        {
                            this.KeyI.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.KeyI.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.KeyI.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setKeyJHeightSecondValue = true;
                        KeyJHeightSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.KeyJ.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.KeyJ.Parent = this.GetGraphicalUiElementByName("Row3Keys") ?? this;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.KeyJ.Text = "J";
                        }
                        setKeyJWidthSecondValue = true;
                        KeyJWidthSecondValue = 10f;
                        if (interpolationValue >= 1)
                        {
                            this.KeyJ.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.KeyJ.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.KeyJ.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setKeyKHeightSecondValue = true;
                        KeyKHeightSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.KeyK.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.KeyK.Parent = this.GetGraphicalUiElementByName("Row3Keys") ?? this;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.KeyK.Text = "K";
                        }
                        setKeyKWidthSecondValue = true;
                        KeyKWidthSecondValue = 10f;
                        if (interpolationValue >= 1)
                        {
                            this.KeyK.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.KeyK.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.KeyK.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setKeyLHeightSecondValue = true;
                        KeyLHeightSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.KeyL.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.KeyL.Parent = this.GetGraphicalUiElementByName("Row3Keys") ?? this;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.KeyL.Text = "L";
                        }
                        setKeyLWidthSecondValue = true;
                        KeyLWidthSecondValue = 10f;
                        if (interpolationValue >= 1)
                        {
                            this.KeyL.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.KeyL.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.KeyL.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.KeyLeft.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.KeyLeft.Text = "";
                        }
                        setKeyLeftWidthSecondValue = true;
                        KeyLeftWidthSecondValue = 10f;
                        if (interpolationValue >= 1)
                        {
                            this.KeyLeft.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setKeyLeftXSecondValue = true;
                        KeyLeftXSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.KeyLeft.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.KeyLeft.XUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                        }
                        setKeyLeftYSecondValue = true;
                        KeyLeftYSecondValue = 20f;
                        if (interpolationValue >= 1)
                        {
                            this.KeyLeft.YUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setKeyMHeightSecondValue = true;
                        KeyMHeightSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.KeyM.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.KeyM.Parent = this.GetGraphicalUiElementByName("Row4Keys") ?? this;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.KeyM.Text = "M";
                        }
                        setKeyMWidthSecondValue = true;
                        KeyMWidthSecondValue = 10f;
                        if (interpolationValue >= 1)
                        {
                            this.KeyM.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.KeyM.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.KeyM.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setKeyNHeightSecondValue = true;
                        KeyNHeightSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.KeyN.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.KeyN.Parent = this.GetGraphicalUiElementByName("Row4Keys") ?? this;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.KeyN.Text = "N";
                        }
                        setKeyNWidthSecondValue = true;
                        KeyNWidthSecondValue = 10f;
                        if (interpolationValue >= 1)
                        {
                            this.KeyN.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.KeyN.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.KeyN.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setKeyOHeightSecondValue = true;
                        KeyOHeightSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.KeyO.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.KeyO.Parent = this.GetGraphicalUiElementByName("Row2Keys") ?? this;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.KeyO.Text = "O";
                        }
                        setKeyOWidthSecondValue = true;
                        KeyOWidthSecondValue = 10f;
                        if (interpolationValue >= 1)
                        {
                            this.KeyO.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.KeyO.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.KeyO.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setKeyPHeightSecondValue = true;
                        KeyPHeightSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.KeyP.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.KeyP.Parent = this.GetGraphicalUiElementByName("Row2Keys") ?? this;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.KeyP.Text = "P";
                        }
                        setKeyPWidthSecondValue = true;
                        KeyPWidthSecondValue = 10f;
                        if (interpolationValue >= 1)
                        {
                            this.KeyP.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.KeyP.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.KeyP.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setKeyParenLeftHeightSecondValue = true;
                        KeyParenLeftHeightSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.KeyParenLeft.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.KeyParenLeft.Parent = this.GetGraphicalUiElementByName("Row5Keys") ?? this;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.KeyParenLeft.Text = "(";
                        }
                        setKeyParenLeftWidthSecondValue = true;
                        KeyParenLeftWidthSecondValue = 10f;
                        if (interpolationValue >= 1)
                        {
                            this.KeyParenLeft.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.KeyParenLeft.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.KeyParenLeft.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setKeyParenRightHeightSecondValue = true;
                        KeyParenRightHeightSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.KeyParenRight.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.KeyParenRight.Parent = this.GetGraphicalUiElementByName("Row5Keys") ?? this;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.KeyParenRight.Text = ")";
                        }
                        setKeyParenRightWidthSecondValue = true;
                        KeyParenRightWidthSecondValue = 10f;
                        if (interpolationValue >= 1)
                        {
                            this.KeyParenRight.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.KeyParenRight.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.KeyParenRight.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setKeyPeriodHeightSecondValue = true;
                        KeyPeriodHeightSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.KeyPeriod.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.KeyPeriod.Parent = this.GetGraphicalUiElementByName("Row4Keys") ?? this;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.KeyPeriod.Text = ".";
                        }
                        setKeyPeriodWidthSecondValue = true;
                        KeyPeriodWidthSecondValue = 10f;
                        if (interpolationValue >= 1)
                        {
                            this.KeyPeriod.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.KeyPeriod.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.KeyPeriod.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setKeyQHeightSecondValue = true;
                        KeyQHeightSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.KeyQ.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.KeyQ.Parent = this.GetGraphicalUiElementByName("Row2Keys") ?? this;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.KeyQ.Text = "Q";
                        }
                        setKeyQWidthSecondValue = true;
                        KeyQWidthSecondValue = 10f;
                        if (interpolationValue >= 1)
                        {
                            this.KeyQ.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.KeyQ.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.KeyQ.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setKeyQuestionHeightSecondValue = true;
                        KeyQuestionHeightSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.KeyQuestion.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.KeyQuestion.Parent = this.GetGraphicalUiElementByName("Row5Keys") ?? this;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.KeyQuestion.Text = "?";
                        }
                        setKeyQuestionWidthSecondValue = true;
                        KeyQuestionWidthSecondValue = 10f;
                        if (interpolationValue >= 1)
                        {
                            this.KeyQuestion.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.KeyQuestion.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.KeyQuestion.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setKeyRHeightSecondValue = true;
                        KeyRHeightSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.KeyR.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.KeyR.Parent = this.GetGraphicalUiElementByName("Row2Keys") ?? this;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.KeyR.Text = "R";
                        }
                        setKeyRWidthSecondValue = true;
                        KeyRWidthSecondValue = 10f;
                        if (interpolationValue >= 1)
                        {
                            this.KeyR.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.KeyR.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.KeyR.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setKeyReturnHeightSecondValue = true;
                        KeyReturnHeightSecondValue = 40f;
                        if (interpolationValue >= 1)
                        {
                            this.KeyReturn.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.KeyReturn.Text = "";
                        }
                        setKeyReturnWidthSecondValue = true;
                        KeyReturnWidthSecondValue = 10f;
                        if (interpolationValue >= 1)
                        {
                            this.KeyReturn.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.KeyReturn.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.KeyReturn.XUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.KeyReturn.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Bottom;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.KeyReturn.YUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.KeyRight.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.KeyRight.Text = "";
                        }
                        setKeyRightWidthSecondValue = true;
                        KeyRightWidthSecondValue = 10f;
                        if (interpolationValue >= 1)
                        {
                            this.KeyRight.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setKeyRightXSecondValue = true;
                        KeyRightXSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.KeyRight.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.KeyRight.XUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                        }
                        setKeyRightYSecondValue = true;
                        KeyRightYSecondValue = 40f;
                        if (interpolationValue >= 1)
                        {
                            this.KeyRight.YUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.KeyRows.ChildrenLayout = Gum.Managers.ChildrenLayout.TopToBottomStack;
                        }
                        setKeyRowsHeightSecondValue = true;
                        KeyRowsHeightSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.KeyRows.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        setKeyRowsWidthSecondValue = true;
                        KeyRowsWidthSecondValue = 90f;
                        if (interpolationValue >= 1)
                        {
                            this.KeyRows.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setKeyRowsXSecondValue = true;
                        KeyRowsXSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.KeyRows.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.KeyRows.XUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                        }
                        setKeyRowsYSecondValue = true;
                        KeyRowsYSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.KeyRows.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.KeyRows.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setKeySHeightSecondValue = true;
                        KeySHeightSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.KeyS.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.KeyS.Parent = this.GetGraphicalUiElementByName("Row3Keys") ?? this;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.KeyS.Text = "S";
                        }
                        setKeySWidthSecondValue = true;
                        KeySWidthSecondValue = 10f;
                        if (interpolationValue >= 1)
                        {
                            this.KeyS.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.KeyS.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.KeyS.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setKeySpaceHeightSecondValue = true;
                        KeySpaceHeightSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.KeySpace.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.KeySpace.Parent = this.GetGraphicalUiElementByName("Row5Keys") ?? this;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.KeySpace.Text = "SPACE";
                        }
                        setKeySpaceWidthSecondValue = true;
                        KeySpaceWidthSecondValue = 50f;
                        if (interpolationValue >= 1)
                        {
                            this.KeySpace.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.KeySpace.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.KeySpace.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setKeyTHeightSecondValue = true;
                        KeyTHeightSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.KeyT.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.KeyT.Parent = this.GetGraphicalUiElementByName("Row2Keys") ?? this;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.KeyT.Text = "T";
                        }
                        setKeyTWidthSecondValue = true;
                        KeyTWidthSecondValue = 10f;
                        if (interpolationValue >= 1)
                        {
                            this.KeyT.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.KeyT.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.KeyT.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setKeyUHeightSecondValue = true;
                        KeyUHeightSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.KeyU.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.KeyU.Parent = this.GetGraphicalUiElementByName("Row2Keys") ?? this;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.KeyU.Text = "U";
                        }
                        setKeyUWidthSecondValue = true;
                        KeyUWidthSecondValue = 10f;
                        if (interpolationValue >= 1)
                        {
                            this.KeyU.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.KeyU.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.KeyU.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setKeyUnderscoreHeightSecondValue = true;
                        KeyUnderscoreHeightSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.KeyUnderscore.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.KeyUnderscore.Parent = this.GetGraphicalUiElementByName("Row3Keys") ?? this;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.KeyUnderscore.Text = "_";
                        }
                        setKeyUnderscoreWidthSecondValue = true;
                        KeyUnderscoreWidthSecondValue = 10f;
                        if (interpolationValue >= 1)
                        {
                            this.KeyUnderscore.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.KeyUnderscore.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.KeyUnderscore.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setKeyVHeightSecondValue = true;
                        KeyVHeightSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.KeyV.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.KeyV.Parent = this.GetGraphicalUiElementByName("Row4Keys") ?? this;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.KeyV.Text = "V";
                        }
                        setKeyVWidthSecondValue = true;
                        KeyVWidthSecondValue = 10f;
                        if (interpolationValue >= 1)
                        {
                            this.KeyV.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.KeyV.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.KeyV.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setKeyWHeightSecondValue = true;
                        KeyWHeightSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.KeyW.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.KeyW.Parent = this.GetGraphicalUiElementByName("Row2Keys") ?? this;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.KeyW.Text = "W";
                        }
                        setKeyWWidthSecondValue = true;
                        KeyWWidthSecondValue = 10f;
                        if (interpolationValue >= 1)
                        {
                            this.KeyW.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.KeyW.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.KeyW.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setKeyXHeightSecondValue = true;
                        KeyXHeightSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.KeyX.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.KeyX.Parent = this.GetGraphicalUiElementByName("Row4Keys") ?? this;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.KeyX.Text = "X";
                        }
                        setKeyXWidthSecondValue = true;
                        KeyXWidthSecondValue = 10f;
                        if (interpolationValue >= 1)
                        {
                            this.KeyX.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.KeyX.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.KeyX.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setKeyYHeightSecondValue = true;
                        KeyYHeightSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.KeyY.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.KeyY.Parent = this.GetGraphicalUiElementByName("Row2Keys") ?? this;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.KeyY.Text = "Y";
                        }
                        setKeyYWidthSecondValue = true;
                        KeyYWidthSecondValue = 10f;
                        if (interpolationValue >= 1)
                        {
                            this.KeyY.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.KeyY.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.KeyY.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setKeyZHeightSecondValue = true;
                        KeyZHeightSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.KeyZ.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.KeyZ.Parent = this.GetGraphicalUiElementByName("Row4Keys") ?? this;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.KeyZ.Text = "Z";
                        }
                        setKeyZWidthSecondValue = true;
                        KeyZWidthSecondValue = 10f;
                        if (interpolationValue >= 1)
                        {
                            this.KeyZ.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.KeyZ.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.KeyZ.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.Row1Keys.ChildrenLayout = Gum.Managers.ChildrenLayout.LeftToRightStack;
                        }
                        setRow1KeysHeightSecondValue = true;
                        Row1KeysHeightSecondValue = 20f;
                        if (interpolationValue >= 1)
                        {
                            this.Row1Keys.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.Row1Keys.Parent = this.GetGraphicalUiElementByName("KeyRows") ?? this;
                        }
                        setRow1KeysWidthSecondValue = true;
                        Row1KeysWidthSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.Row1Keys.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.Row1Keys.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.Row1Keys.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.Row1Keys.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Top;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.Row1Keys.YUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.Row2Keys.ChildrenLayout = Gum.Managers.ChildrenLayout.LeftToRightStack;
                        }
                        setRow2KeysHeightSecondValue = true;
                        Row2KeysHeightSecondValue = 20f;
                        if (interpolationValue >= 1)
                        {
                            this.Row2Keys.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.Row2Keys.Parent = this.GetGraphicalUiElementByName("KeyRows") ?? this;
                        }
                        setRow2KeysWidthSecondValue = true;
                        Row2KeysWidthSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.Row2Keys.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.Row3Keys.ChildrenLayout = Gum.Managers.ChildrenLayout.LeftToRightStack;
                        }
                        setRow3KeysHeightSecondValue = true;
                        Row3KeysHeightSecondValue = 20f;
                        if (interpolationValue >= 1)
                        {
                            this.Row3Keys.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.Row3Keys.Parent = this.GetGraphicalUiElementByName("KeyRows") ?? this;
                        }
                        setRow3KeysWidthSecondValue = true;
                        Row3KeysWidthSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.Row3Keys.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.Row4Keys.ChildrenLayout = Gum.Managers.ChildrenLayout.LeftToRightStack;
                        }
                        setRow4KeysHeightSecondValue = true;
                        Row4KeysHeightSecondValue = 20f;
                        if (interpolationValue >= 1)
                        {
                            this.Row4Keys.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.Row4Keys.Parent = this.GetGraphicalUiElementByName("KeyRows") ?? this;
                        }
                        setRow4KeysWidthSecondValue = true;
                        Row4KeysWidthSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.Row4Keys.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.Row5Keys.ChildrenLayout = Gum.Managers.ChildrenLayout.LeftToRightStack;
                        }
                        setRow5KeysHeightSecondValue = true;
                        Row5KeysHeightSecondValue = 20f;
                        if (interpolationValue >= 1)
                        {
                            this.Row5Keys.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.Row5Keys.Parent = this.GetGraphicalUiElementByName("KeyRows") ?? this;
                        }
                        setRow5KeysWidthSecondValue = true;
                        Row5KeysWidthSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.Row5Keys.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        setWidthSecondValue = true;
                        WidthSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                        }
                        break;
                }
                var wasSuppressed = mIsLayoutSuspended;
                if (wasSuppressed == false)
                {
                    SuspendLayout(true);
                }
                if (setKey0HeightFirstValue && setKey0HeightSecondValue)
                {
                    Key0.Height = Key0HeightFirstValue * (1 - interpolationValue) + Key0HeightSecondValue * interpolationValue;
                }
                if (setKey0WidthFirstValue && setKey0WidthSecondValue)
                {
                    Key0.Width = Key0WidthFirstValue * (1 - interpolationValue) + Key0WidthSecondValue * interpolationValue;
                }
                if (setKey1HeightFirstValue && setKey1HeightSecondValue)
                {
                    Key1.Height = Key1HeightFirstValue * (1 - interpolationValue) + Key1HeightSecondValue * interpolationValue;
                }
                if (setKey1WidthFirstValue && setKey1WidthSecondValue)
                {
                    Key1.Width = Key1WidthFirstValue * (1 - interpolationValue) + Key1WidthSecondValue * interpolationValue;
                }
                if (setKey2HeightFirstValue && setKey2HeightSecondValue)
                {
                    Key2.Height = Key2HeightFirstValue * (1 - interpolationValue) + Key2HeightSecondValue * interpolationValue;
                }
                if (setKey2WidthFirstValue && setKey2WidthSecondValue)
                {
                    Key2.Width = Key2WidthFirstValue * (1 - interpolationValue) + Key2WidthSecondValue * interpolationValue;
                }
                if (setKey3HeightFirstValue && setKey3HeightSecondValue)
                {
                    Key3.Height = Key3HeightFirstValue * (1 - interpolationValue) + Key3HeightSecondValue * interpolationValue;
                }
                if (setKey3WidthFirstValue && setKey3WidthSecondValue)
                {
                    Key3.Width = Key3WidthFirstValue * (1 - interpolationValue) + Key3WidthSecondValue * interpolationValue;
                }
                if (setKey4HeightFirstValue && setKey4HeightSecondValue)
                {
                    Key4.Height = Key4HeightFirstValue * (1 - interpolationValue) + Key4HeightSecondValue * interpolationValue;
                }
                if (setKey4WidthFirstValue && setKey4WidthSecondValue)
                {
                    Key4.Width = Key4WidthFirstValue * (1 - interpolationValue) + Key4WidthSecondValue * interpolationValue;
                }
                if (setKey5HeightFirstValue && setKey5HeightSecondValue)
                {
                    Key5.Height = Key5HeightFirstValue * (1 - interpolationValue) + Key5HeightSecondValue * interpolationValue;
                }
                if (setKey5WidthFirstValue && setKey5WidthSecondValue)
                {
                    Key5.Width = Key5WidthFirstValue * (1 - interpolationValue) + Key5WidthSecondValue * interpolationValue;
                }
                if (setKey6HeightFirstValue && setKey6HeightSecondValue)
                {
                    Key6.Height = Key6HeightFirstValue * (1 - interpolationValue) + Key6HeightSecondValue * interpolationValue;
                }
                if (setKey6WidthFirstValue && setKey6WidthSecondValue)
                {
                    Key6.Width = Key6WidthFirstValue * (1 - interpolationValue) + Key6WidthSecondValue * interpolationValue;
                }
                if (setKey7HeightFirstValue && setKey7HeightSecondValue)
                {
                    Key7.Height = Key7HeightFirstValue * (1 - interpolationValue) + Key7HeightSecondValue * interpolationValue;
                }
                if (setKey7WidthFirstValue && setKey7WidthSecondValue)
                {
                    Key7.Width = Key7WidthFirstValue * (1 - interpolationValue) + Key7WidthSecondValue * interpolationValue;
                }
                if (setKey8HeightFirstValue && setKey8HeightSecondValue)
                {
                    Key8.Height = Key8HeightFirstValue * (1 - interpolationValue) + Key8HeightSecondValue * interpolationValue;
                }
                if (setKey8WidthFirstValue && setKey8WidthSecondValue)
                {
                    Key8.Width = Key8WidthFirstValue * (1 - interpolationValue) + Key8WidthSecondValue * interpolationValue;
                }
                if (setKey9HeightFirstValue && setKey9HeightSecondValue)
                {
                    Key9.Height = Key9HeightFirstValue * (1 - interpolationValue) + Key9HeightSecondValue * interpolationValue;
                }
                if (setKey9WidthFirstValue && setKey9WidthSecondValue)
                {
                    Key9.Width = Key9WidthFirstValue * (1 - interpolationValue) + Key9WidthSecondValue * interpolationValue;
                }
                if (setKeyAHeightFirstValue && setKeyAHeightSecondValue)
                {
                    KeyA.Height = KeyAHeightFirstValue * (1 - interpolationValue) + KeyAHeightSecondValue * interpolationValue;
                }
                if (setKeyAWidthFirstValue && setKeyAWidthSecondValue)
                {
                    KeyA.Width = KeyAWidthFirstValue * (1 - interpolationValue) + KeyAWidthSecondValue * interpolationValue;
                }
                if (setKeyAmpersandHeightFirstValue && setKeyAmpersandHeightSecondValue)
                {
                    KeyAmpersand.Height = KeyAmpersandHeightFirstValue * (1 - interpolationValue) + KeyAmpersandHeightSecondValue * interpolationValue;
                }
                if (setKeyAmpersandWidthFirstValue && setKeyAmpersandWidthSecondValue)
                {
                    KeyAmpersand.Width = KeyAmpersandWidthFirstValue * (1 - interpolationValue) + KeyAmpersandWidthSecondValue * interpolationValue;
                }
                if (setKeyBHeightFirstValue && setKeyBHeightSecondValue)
                {
                    KeyB.Height = KeyBHeightFirstValue * (1 - interpolationValue) + KeyBHeightSecondValue * interpolationValue;
                }
                if (setKeyBWidthFirstValue && setKeyBWidthSecondValue)
                {
                    KeyB.Width = KeyBWidthFirstValue * (1 - interpolationValue) + KeyBWidthSecondValue * interpolationValue;
                }
                if (setKeyBackspaceHeightFirstValue && setKeyBackspaceHeightSecondValue)
                {
                    KeyBackspace.Height = KeyBackspaceHeightFirstValue * (1 - interpolationValue) + KeyBackspaceHeightSecondValue * interpolationValue;
                }
                if (setKeyBackspaceWidthFirstValue && setKeyBackspaceWidthSecondValue)
                {
                    KeyBackspace.Width = KeyBackspaceWidthFirstValue * (1 - interpolationValue) + KeyBackspaceWidthSecondValue * interpolationValue;
                }
                if (setKeyBangHeightFirstValue && setKeyBangHeightSecondValue)
                {
                    KeyBang.Height = KeyBangHeightFirstValue * (1 - interpolationValue) + KeyBangHeightSecondValue * interpolationValue;
                }
                if (setKeyBangWidthFirstValue && setKeyBangWidthSecondValue)
                {
                    KeyBang.Width = KeyBangWidthFirstValue * (1 - interpolationValue) + KeyBangWidthSecondValue * interpolationValue;
                }
                if (setKeyCHeightFirstValue && setKeyCHeightSecondValue)
                {
                    KeyC.Height = KeyCHeightFirstValue * (1 - interpolationValue) + KeyCHeightSecondValue * interpolationValue;
                }
                if (setKeyCWidthFirstValue && setKeyCWidthSecondValue)
                {
                    KeyC.Width = KeyCWidthFirstValue * (1 - interpolationValue) + KeyCWidthSecondValue * interpolationValue;
                }
                if (setKeyCommaHeightFirstValue && setKeyCommaHeightSecondValue)
                {
                    KeyComma.Height = KeyCommaHeightFirstValue * (1 - interpolationValue) + KeyCommaHeightSecondValue * interpolationValue;
                }
                if (setKeyCommaWidthFirstValue && setKeyCommaWidthSecondValue)
                {
                    KeyComma.Width = KeyCommaWidthFirstValue * (1 - interpolationValue) + KeyCommaWidthSecondValue * interpolationValue;
                }
                if (setKeyDHeightFirstValue && setKeyDHeightSecondValue)
                {
                    KeyD.Height = KeyDHeightFirstValue * (1 - interpolationValue) + KeyDHeightSecondValue * interpolationValue;
                }
                if (setKeyDWidthFirstValue && setKeyDWidthSecondValue)
                {
                    KeyD.Width = KeyDWidthFirstValue * (1 - interpolationValue) + KeyDWidthSecondValue * interpolationValue;
                }
                if (setKeyEHeightFirstValue && setKeyEHeightSecondValue)
                {
                    KeyE.Height = KeyEHeightFirstValue * (1 - interpolationValue) + KeyEHeightSecondValue * interpolationValue;
                }
                if (setKeyEWidthFirstValue && setKeyEWidthSecondValue)
                {
                    KeyE.Width = KeyEWidthFirstValue * (1 - interpolationValue) + KeyEWidthSecondValue * interpolationValue;
                }
                if (setKeyFHeightFirstValue && setKeyFHeightSecondValue)
                {
                    KeyF.Height = KeyFHeightFirstValue * (1 - interpolationValue) + KeyFHeightSecondValue * interpolationValue;
                }
                if (setKeyFWidthFirstValue && setKeyFWidthSecondValue)
                {
                    KeyF.Width = KeyFWidthFirstValue * (1 - interpolationValue) + KeyFWidthSecondValue * interpolationValue;
                }
                if (setKeyGHeightFirstValue && setKeyGHeightSecondValue)
                {
                    KeyG.Height = KeyGHeightFirstValue * (1 - interpolationValue) + KeyGHeightSecondValue * interpolationValue;
                }
                if (setKeyGWidthFirstValue && setKeyGWidthSecondValue)
                {
                    KeyG.Width = KeyGWidthFirstValue * (1 - interpolationValue) + KeyGWidthSecondValue * interpolationValue;
                }
                if (setKeyHHeightFirstValue && setKeyHHeightSecondValue)
                {
                    KeyH.Height = KeyHHeightFirstValue * (1 - interpolationValue) + KeyHHeightSecondValue * interpolationValue;
                }
                if (setKeyHWidthFirstValue && setKeyHWidthSecondValue)
                {
                    KeyH.Width = KeyHWidthFirstValue * (1 - interpolationValue) + KeyHWidthSecondValue * interpolationValue;
                }
                if (setKeyHyphenHeightFirstValue && setKeyHyphenHeightSecondValue)
                {
                    KeyHyphen.Height = KeyHyphenHeightFirstValue * (1 - interpolationValue) + KeyHyphenHeightSecondValue * interpolationValue;
                }
                if (setKeyHyphenWidthFirstValue && setKeyHyphenWidthSecondValue)
                {
                    KeyHyphen.Width = KeyHyphenWidthFirstValue * (1 - interpolationValue) + KeyHyphenWidthSecondValue * interpolationValue;
                }
                if (setKeyIHeightFirstValue && setKeyIHeightSecondValue)
                {
                    KeyI.Height = KeyIHeightFirstValue * (1 - interpolationValue) + KeyIHeightSecondValue * interpolationValue;
                }
                if (setKeyIWidthFirstValue && setKeyIWidthSecondValue)
                {
                    KeyI.Width = KeyIWidthFirstValue * (1 - interpolationValue) + KeyIWidthSecondValue * interpolationValue;
                }
                if (setKeyJHeightFirstValue && setKeyJHeightSecondValue)
                {
                    KeyJ.Height = KeyJHeightFirstValue * (1 - interpolationValue) + KeyJHeightSecondValue * interpolationValue;
                }
                if (setKeyJWidthFirstValue && setKeyJWidthSecondValue)
                {
                    KeyJ.Width = KeyJWidthFirstValue * (1 - interpolationValue) + KeyJWidthSecondValue * interpolationValue;
                }
                if (setKeyKHeightFirstValue && setKeyKHeightSecondValue)
                {
                    KeyK.Height = KeyKHeightFirstValue * (1 - interpolationValue) + KeyKHeightSecondValue * interpolationValue;
                }
                if (setKeyKWidthFirstValue && setKeyKWidthSecondValue)
                {
                    KeyK.Width = KeyKWidthFirstValue * (1 - interpolationValue) + KeyKWidthSecondValue * interpolationValue;
                }
                if (setKeyLHeightFirstValue && setKeyLHeightSecondValue)
                {
                    KeyL.Height = KeyLHeightFirstValue * (1 - interpolationValue) + KeyLHeightSecondValue * interpolationValue;
                }
                if (setKeyLWidthFirstValue && setKeyLWidthSecondValue)
                {
                    KeyL.Width = KeyLWidthFirstValue * (1 - interpolationValue) + KeyLWidthSecondValue * interpolationValue;
                }
                if (setKeyLeftWidthFirstValue && setKeyLeftWidthSecondValue)
                {
                    KeyLeft.Width = KeyLeftWidthFirstValue * (1 - interpolationValue) + KeyLeftWidthSecondValue * interpolationValue;
                }
                if (setKeyLeftXFirstValue && setKeyLeftXSecondValue)
                {
                    KeyLeft.X = KeyLeftXFirstValue * (1 - interpolationValue) + KeyLeftXSecondValue * interpolationValue;
                }
                if (setKeyLeftYFirstValue && setKeyLeftYSecondValue)
                {
                    KeyLeft.Y = KeyLeftYFirstValue * (1 - interpolationValue) + KeyLeftYSecondValue * interpolationValue;
                }
                if (setKeyMHeightFirstValue && setKeyMHeightSecondValue)
                {
                    KeyM.Height = KeyMHeightFirstValue * (1 - interpolationValue) + KeyMHeightSecondValue * interpolationValue;
                }
                if (setKeyMWidthFirstValue && setKeyMWidthSecondValue)
                {
                    KeyM.Width = KeyMWidthFirstValue * (1 - interpolationValue) + KeyMWidthSecondValue * interpolationValue;
                }
                if (setKeyNHeightFirstValue && setKeyNHeightSecondValue)
                {
                    KeyN.Height = KeyNHeightFirstValue * (1 - interpolationValue) + KeyNHeightSecondValue * interpolationValue;
                }
                if (setKeyNWidthFirstValue && setKeyNWidthSecondValue)
                {
                    KeyN.Width = KeyNWidthFirstValue * (1 - interpolationValue) + KeyNWidthSecondValue * interpolationValue;
                }
                if (setKeyOHeightFirstValue && setKeyOHeightSecondValue)
                {
                    KeyO.Height = KeyOHeightFirstValue * (1 - interpolationValue) + KeyOHeightSecondValue * interpolationValue;
                }
                if (setKeyOWidthFirstValue && setKeyOWidthSecondValue)
                {
                    KeyO.Width = KeyOWidthFirstValue * (1 - interpolationValue) + KeyOWidthSecondValue * interpolationValue;
                }
                if (setKeyPHeightFirstValue && setKeyPHeightSecondValue)
                {
                    KeyP.Height = KeyPHeightFirstValue * (1 - interpolationValue) + KeyPHeightSecondValue * interpolationValue;
                }
                if (setKeyPWidthFirstValue && setKeyPWidthSecondValue)
                {
                    KeyP.Width = KeyPWidthFirstValue * (1 - interpolationValue) + KeyPWidthSecondValue * interpolationValue;
                }
                if (setKeyParenLeftHeightFirstValue && setKeyParenLeftHeightSecondValue)
                {
                    KeyParenLeft.Height = KeyParenLeftHeightFirstValue * (1 - interpolationValue) + KeyParenLeftHeightSecondValue * interpolationValue;
                }
                if (setKeyParenLeftWidthFirstValue && setKeyParenLeftWidthSecondValue)
                {
                    KeyParenLeft.Width = KeyParenLeftWidthFirstValue * (1 - interpolationValue) + KeyParenLeftWidthSecondValue * interpolationValue;
                }
                if (setKeyParenRightHeightFirstValue && setKeyParenRightHeightSecondValue)
                {
                    KeyParenRight.Height = KeyParenRightHeightFirstValue * (1 - interpolationValue) + KeyParenRightHeightSecondValue * interpolationValue;
                }
                if (setKeyParenRightWidthFirstValue && setKeyParenRightWidthSecondValue)
                {
                    KeyParenRight.Width = KeyParenRightWidthFirstValue * (1 - interpolationValue) + KeyParenRightWidthSecondValue * interpolationValue;
                }
                if (setKeyPeriodHeightFirstValue && setKeyPeriodHeightSecondValue)
                {
                    KeyPeriod.Height = KeyPeriodHeightFirstValue * (1 - interpolationValue) + KeyPeriodHeightSecondValue * interpolationValue;
                }
                if (setKeyPeriodWidthFirstValue && setKeyPeriodWidthSecondValue)
                {
                    KeyPeriod.Width = KeyPeriodWidthFirstValue * (1 - interpolationValue) + KeyPeriodWidthSecondValue * interpolationValue;
                }
                if (setKeyQHeightFirstValue && setKeyQHeightSecondValue)
                {
                    KeyQ.Height = KeyQHeightFirstValue * (1 - interpolationValue) + KeyQHeightSecondValue * interpolationValue;
                }
                if (setKeyQWidthFirstValue && setKeyQWidthSecondValue)
                {
                    KeyQ.Width = KeyQWidthFirstValue * (1 - interpolationValue) + KeyQWidthSecondValue * interpolationValue;
                }
                if (setKeyQuestionHeightFirstValue && setKeyQuestionHeightSecondValue)
                {
                    KeyQuestion.Height = KeyQuestionHeightFirstValue * (1 - interpolationValue) + KeyQuestionHeightSecondValue * interpolationValue;
                }
                if (setKeyQuestionWidthFirstValue && setKeyQuestionWidthSecondValue)
                {
                    KeyQuestion.Width = KeyQuestionWidthFirstValue * (1 - interpolationValue) + KeyQuestionWidthSecondValue * interpolationValue;
                }
                if (setKeyRHeightFirstValue && setKeyRHeightSecondValue)
                {
                    KeyR.Height = KeyRHeightFirstValue * (1 - interpolationValue) + KeyRHeightSecondValue * interpolationValue;
                }
                if (setKeyRWidthFirstValue && setKeyRWidthSecondValue)
                {
                    KeyR.Width = KeyRWidthFirstValue * (1 - interpolationValue) + KeyRWidthSecondValue * interpolationValue;
                }
                if (setKeyReturnHeightFirstValue && setKeyReturnHeightSecondValue)
                {
                    KeyReturn.Height = KeyReturnHeightFirstValue * (1 - interpolationValue) + KeyReturnHeightSecondValue * interpolationValue;
                }
                if (setKeyReturnWidthFirstValue && setKeyReturnWidthSecondValue)
                {
                    KeyReturn.Width = KeyReturnWidthFirstValue * (1 - interpolationValue) + KeyReturnWidthSecondValue * interpolationValue;
                }
                if (setKeyRightWidthFirstValue && setKeyRightWidthSecondValue)
                {
                    KeyRight.Width = KeyRightWidthFirstValue * (1 - interpolationValue) + KeyRightWidthSecondValue * interpolationValue;
                }
                if (setKeyRightXFirstValue && setKeyRightXSecondValue)
                {
                    KeyRight.X = KeyRightXFirstValue * (1 - interpolationValue) + KeyRightXSecondValue * interpolationValue;
                }
                if (setKeyRightYFirstValue && setKeyRightYSecondValue)
                {
                    KeyRight.Y = KeyRightYFirstValue * (1 - interpolationValue) + KeyRightYSecondValue * interpolationValue;
                }
                if (setKeyRowsHeightFirstValue && setKeyRowsHeightSecondValue)
                {
                    KeyRows.Height = KeyRowsHeightFirstValue * (1 - interpolationValue) + KeyRowsHeightSecondValue * interpolationValue;
                }
                if (setKeyRowsWidthFirstValue && setKeyRowsWidthSecondValue)
                {
                    KeyRows.Width = KeyRowsWidthFirstValue * (1 - interpolationValue) + KeyRowsWidthSecondValue * interpolationValue;
                }
                if (setKeyRowsXFirstValue && setKeyRowsXSecondValue)
                {
                    KeyRows.X = KeyRowsXFirstValue * (1 - interpolationValue) + KeyRowsXSecondValue * interpolationValue;
                }
                if (setKeyRowsYFirstValue && setKeyRowsYSecondValue)
                {
                    KeyRows.Y = KeyRowsYFirstValue * (1 - interpolationValue) + KeyRowsYSecondValue * interpolationValue;
                }
                if (setKeySHeightFirstValue && setKeySHeightSecondValue)
                {
                    KeyS.Height = KeySHeightFirstValue * (1 - interpolationValue) + KeySHeightSecondValue * interpolationValue;
                }
                if (setKeySWidthFirstValue && setKeySWidthSecondValue)
                {
                    KeyS.Width = KeySWidthFirstValue * (1 - interpolationValue) + KeySWidthSecondValue * interpolationValue;
                }
                if (setKeySpaceHeightFirstValue && setKeySpaceHeightSecondValue)
                {
                    KeySpace.Height = KeySpaceHeightFirstValue * (1 - interpolationValue) + KeySpaceHeightSecondValue * interpolationValue;
                }
                if (setKeySpaceWidthFirstValue && setKeySpaceWidthSecondValue)
                {
                    KeySpace.Width = KeySpaceWidthFirstValue * (1 - interpolationValue) + KeySpaceWidthSecondValue * interpolationValue;
                }
                if (setKeyTHeightFirstValue && setKeyTHeightSecondValue)
                {
                    KeyT.Height = KeyTHeightFirstValue * (1 - interpolationValue) + KeyTHeightSecondValue * interpolationValue;
                }
                if (setKeyTWidthFirstValue && setKeyTWidthSecondValue)
                {
                    KeyT.Width = KeyTWidthFirstValue * (1 - interpolationValue) + KeyTWidthSecondValue * interpolationValue;
                }
                if (setKeyUHeightFirstValue && setKeyUHeightSecondValue)
                {
                    KeyU.Height = KeyUHeightFirstValue * (1 - interpolationValue) + KeyUHeightSecondValue * interpolationValue;
                }
                if (setKeyUWidthFirstValue && setKeyUWidthSecondValue)
                {
                    KeyU.Width = KeyUWidthFirstValue * (1 - interpolationValue) + KeyUWidthSecondValue * interpolationValue;
                }
                if (setKeyUnderscoreHeightFirstValue && setKeyUnderscoreHeightSecondValue)
                {
                    KeyUnderscore.Height = KeyUnderscoreHeightFirstValue * (1 - interpolationValue) + KeyUnderscoreHeightSecondValue * interpolationValue;
                }
                if (setKeyUnderscoreWidthFirstValue && setKeyUnderscoreWidthSecondValue)
                {
                    KeyUnderscore.Width = KeyUnderscoreWidthFirstValue * (1 - interpolationValue) + KeyUnderscoreWidthSecondValue * interpolationValue;
                }
                if (setKeyVHeightFirstValue && setKeyVHeightSecondValue)
                {
                    KeyV.Height = KeyVHeightFirstValue * (1 - interpolationValue) + KeyVHeightSecondValue * interpolationValue;
                }
                if (setKeyVWidthFirstValue && setKeyVWidthSecondValue)
                {
                    KeyV.Width = KeyVWidthFirstValue * (1 - interpolationValue) + KeyVWidthSecondValue * interpolationValue;
                }
                if (setKeyWHeightFirstValue && setKeyWHeightSecondValue)
                {
                    KeyW.Height = KeyWHeightFirstValue * (1 - interpolationValue) + KeyWHeightSecondValue * interpolationValue;
                }
                if (setKeyWWidthFirstValue && setKeyWWidthSecondValue)
                {
                    KeyW.Width = KeyWWidthFirstValue * (1 - interpolationValue) + KeyWWidthSecondValue * interpolationValue;
                }
                if (setKeyXHeightFirstValue && setKeyXHeightSecondValue)
                {
                    KeyX.Height = KeyXHeightFirstValue * (1 - interpolationValue) + KeyXHeightSecondValue * interpolationValue;
                }
                if (setKeyXWidthFirstValue && setKeyXWidthSecondValue)
                {
                    KeyX.Width = KeyXWidthFirstValue * (1 - interpolationValue) + KeyXWidthSecondValue * interpolationValue;
                }
                if (setKeyYHeightFirstValue && setKeyYHeightSecondValue)
                {
                    KeyY.Height = KeyYHeightFirstValue * (1 - interpolationValue) + KeyYHeightSecondValue * interpolationValue;
                }
                if (setKeyYWidthFirstValue && setKeyYWidthSecondValue)
                {
                    KeyY.Width = KeyYWidthFirstValue * (1 - interpolationValue) + KeyYWidthSecondValue * interpolationValue;
                }
                if (setKeyZHeightFirstValue && setKeyZHeightSecondValue)
                {
                    KeyZ.Height = KeyZHeightFirstValue * (1 - interpolationValue) + KeyZHeightSecondValue * interpolationValue;
                }
                if (setKeyZWidthFirstValue && setKeyZWidthSecondValue)
                {
                    KeyZ.Width = KeyZWidthFirstValue * (1 - interpolationValue) + KeyZWidthSecondValue * interpolationValue;
                }
                if (setRow1KeysHeightFirstValue && setRow1KeysHeightSecondValue)
                {
                    Row1Keys.Height = Row1KeysHeightFirstValue * (1 - interpolationValue) + Row1KeysHeightSecondValue * interpolationValue;
                }
                if (setRow1KeysWidthFirstValue && setRow1KeysWidthSecondValue)
                {
                    Row1Keys.Width = Row1KeysWidthFirstValue * (1 - interpolationValue) + Row1KeysWidthSecondValue * interpolationValue;
                }
                if (setRow2KeysHeightFirstValue && setRow2KeysHeightSecondValue)
                {
                    Row2Keys.Height = Row2KeysHeightFirstValue * (1 - interpolationValue) + Row2KeysHeightSecondValue * interpolationValue;
                }
                if (setRow2KeysWidthFirstValue && setRow2KeysWidthSecondValue)
                {
                    Row2Keys.Width = Row2KeysWidthFirstValue * (1 - interpolationValue) + Row2KeysWidthSecondValue * interpolationValue;
                }
                if (setRow3KeysHeightFirstValue && setRow3KeysHeightSecondValue)
                {
                    Row3Keys.Height = Row3KeysHeightFirstValue * (1 - interpolationValue) + Row3KeysHeightSecondValue * interpolationValue;
                }
                if (setRow3KeysWidthFirstValue && setRow3KeysWidthSecondValue)
                {
                    Row3Keys.Width = Row3KeysWidthFirstValue * (1 - interpolationValue) + Row3KeysWidthSecondValue * interpolationValue;
                }
                if (setRow4KeysHeightFirstValue && setRow4KeysHeightSecondValue)
                {
                    Row4Keys.Height = Row4KeysHeightFirstValue * (1 - interpolationValue) + Row4KeysHeightSecondValue * interpolationValue;
                }
                if (setRow4KeysWidthFirstValue && setRow4KeysWidthSecondValue)
                {
                    Row4Keys.Width = Row4KeysWidthFirstValue * (1 - interpolationValue) + Row4KeysWidthSecondValue * interpolationValue;
                }
                if (setRow5KeysHeightFirstValue && setRow5KeysHeightSecondValue)
                {
                    Row5Keys.Height = Row5KeysHeightFirstValue * (1 - interpolationValue) + Row5KeysHeightSecondValue * interpolationValue;
                }
                if (setRow5KeysWidthFirstValue && setRow5KeysWidthSecondValue)
                {
                    Row5Keys.Width = Row5KeysWidthFirstValue * (1 - interpolationValue) + Row5KeysWidthSecondValue * interpolationValue;
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
            public void InterpolateBetween (CursorMoveCategory firstState, CursorMoveCategory secondState, float interpolationValue) 
            {
                #if DEBUG
                if (float.IsNaN(interpolationValue))
                {
                    throw new System.Exception("interpolationValue cannot be NaN");
                }
                #endif
                switch(firstState)
                {
                    case  CursorMoveCategory.LeftRightMoveSupported:
                        if (interpolationValue < 1)
                        {
                            this.KeyLeft.Visible = true;
                        }
                        if (interpolationValue < 1)
                        {
                            this.KeyRight.Visible = true;
                        }
                        break;
                    case  CursorMoveCategory.NoMovement:
                        if (interpolationValue < 1)
                        {
                            this.KeyLeft.Visible = false;
                        }
                        if (interpolationValue < 1)
                        {
                            this.KeyRight.Visible = false;
                        }
                        break;
                }
                switch(secondState)
                {
                    case  CursorMoveCategory.LeftRightMoveSupported:
                        if (interpolationValue >= 1)
                        {
                            this.KeyLeft.Visible = true;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.KeyRight.Visible = true;
                        }
                        break;
                    case  CursorMoveCategory.NoMovement:
                        if (interpolationValue >= 1)
                        {
                            this.KeyLeft.Visible = false;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.KeyRight.Visible = false;
                        }
                        break;
                }
                var wasSuppressed = mIsLayoutSuspended;
                if (wasSuppressed == false)
                {
                    SuspendLayout(true);
                }
                if (interpolationValue < 1)
                {
                    mCurrentCursorMoveCategoryState = firstState;
                }
                else
                {
                    mCurrentCursorMoveCategoryState = secondState;
                }
                if (!wasSuppressed)
                {
                    ResumeLayout(true);
                }
            }
            #endregion
            #region State Interpolate To
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (JHP4SD.GumRuntimes.DefaultForms.KeyboardRuntime.VariableState fromState,JHP4SD.GumRuntimes.DefaultForms.KeyboardRuntime.VariableState toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null) 
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
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (JHP4SD.GumRuntimes.DefaultForms.KeyboardRuntime.CursorMoveCategory fromState,JHP4SD.GumRuntimes.DefaultForms.KeyboardRuntime.CursorMoveCategory toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null) 
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
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (CursorMoveCategory toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null ) 
            {
                Gum.DataTypes.Variables.StateSave current = GetCurrentValuesOnState(toState);
                Gum.DataTypes.Variables.StateSave toAsStateSave = this.ElementSave.Categories.First(item => item.Name == "CursorMoveCategory").States.First(item => item.Name == toState.ToString());
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
                tweener.Ended += ()=> this.CurrentCursorMoveCategoryState = toState;
                tweener.Start();
                StateInterpolationPlugin.TweenerManager.Self.Add(tweener);
                return tweener;
            }
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateToRelative (CursorMoveCategory toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null ) 
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
                tweener.Ended += ()=> this.CurrentCursorMoveCategoryState = toState;
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
                Key1.StopAnimations();
                KeyQ.StopAnimations();
                KeyA.StopAnimations();
                KeyZ.StopAnimations();
                KeyParenLeft.StopAnimations();
                KeyW.StopAnimations();
                KeyS.StopAnimations();
                KeyX.StopAnimations();
                KeyParenRight.StopAnimations();
                KeyE.StopAnimations();
                KeyD.StopAnimations();
                KeyC.StopAnimations();
                KeySpace.StopAnimations();
                KeyR.StopAnimations();
                KeyF.StopAnimations();
                KeyV.StopAnimations();
                KeyT.StopAnimations();
                KeyG.StopAnimations();
                KeyB.StopAnimations();
                KeyY.StopAnimations();
                KeyH.StopAnimations();
                KeyN.StopAnimations();
                KeyU.StopAnimations();
                KeyJ.StopAnimations();
                KeyM.StopAnimations();
                KeyI.StopAnimations();
                KeyK.StopAnimations();
                KeyComma.StopAnimations();
                KeyQuestion.StopAnimations();
                KeyO.StopAnimations();
                KeyL.StopAnimations();
                KeyPeriod.StopAnimations();
                KeyBang.StopAnimations();
                KeyP.StopAnimations();
                KeyUnderscore.StopAnimations();
                KeyHyphen.StopAnimations();
                KeyAmpersand.StopAnimations();
                Key2.StopAnimations();
                Key3.StopAnimations();
                Key4.StopAnimations();
                Key5.StopAnimations();
                Key6.StopAnimations();
                Key7.StopAnimations();
                Key8.StopAnimations();
                Key9.StopAnimations();
                Key0.StopAnimations();
                KeyBackspace.StopAnimations();
                KeyReturn.StopAnimations();
                KeyLeft.StopAnimations();
                KeyRight.StopAnimations();
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
                            Name = "X Origin",
                            Type = "HorizontalAlignment",
                            Value = XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Row1Keys.Children Layout",
                            Type = "ChildrenLayout",
                            Value = Row1Keys.ChildrenLayout
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Row1Keys.Height",
                            Type = "float",
                            Value = Row1Keys.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Row1Keys.Height Units",
                            Type = "DimensionUnitType",
                            Value = Row1Keys.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Row1Keys.Parent",
                            Type = "string",
                            Value = Row1Keys.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Row1Keys.Width",
                            Type = "float",
                            Value = Row1Keys.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Row1Keys.Width Units",
                            Type = "DimensionUnitType",
                            Value = Row1Keys.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Row1Keys.X Origin",
                            Type = "HorizontalAlignment",
                            Value = Row1Keys.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Row1Keys.X Units",
                            Type = "PositionUnitType",
                            Value = Row1Keys.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Row1Keys.Y Origin",
                            Type = "VerticalAlignment",
                            Value = Row1Keys.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Row1Keys.Y Units",
                            Type = "PositionUnitType",
                            Value = Row1Keys.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyRows.Children Layout",
                            Type = "ChildrenLayout",
                            Value = KeyRows.ChildrenLayout
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyRows.Height",
                            Type = "float",
                            Value = KeyRows.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyRows.Height Units",
                            Type = "DimensionUnitType",
                            Value = KeyRows.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyRows.Width",
                            Type = "float",
                            Value = KeyRows.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyRows.Width Units",
                            Type = "DimensionUnitType",
                            Value = KeyRows.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyRows.X",
                            Type = "float",
                            Value = KeyRows.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyRows.X Origin",
                            Type = "HorizontalAlignment",
                            Value = KeyRows.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyRows.X Units",
                            Type = "PositionUnitType",
                            Value = KeyRows.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyRows.Y",
                            Type = "float",
                            Value = KeyRows.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyRows.Y Origin",
                            Type = "VerticalAlignment",
                            Value = KeyRows.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyRows.Y Units",
                            Type = "PositionUnitType",
                            Value = KeyRows.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Key1.Height",
                            Type = "float",
                            Value = Key1.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Key1.Height Units",
                            Type = "DimensionUnitType",
                            Value = Key1.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Key1.Parent",
                            Type = "string",
                            Value = Key1.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Key1.Text",
                            Type = "string",
                            Value = Key1.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Key1.Width",
                            Type = "float",
                            Value = Key1.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Key1.Width Units",
                            Type = "DimensionUnitType",
                            Value = Key1.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Key1.Y Origin",
                            Type = "VerticalAlignment",
                            Value = Key1.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Key1.Y Units",
                            Type = "PositionUnitType",
                            Value = Key1.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyQ.Height",
                            Type = "float",
                            Value = KeyQ.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyQ.Height Units",
                            Type = "DimensionUnitType",
                            Value = KeyQ.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyQ.Parent",
                            Type = "string",
                            Value = KeyQ.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyQ.Text",
                            Type = "string",
                            Value = KeyQ.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyQ.Width",
                            Type = "float",
                            Value = KeyQ.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyQ.Width Units",
                            Type = "DimensionUnitType",
                            Value = KeyQ.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyQ.Y Origin",
                            Type = "VerticalAlignment",
                            Value = KeyQ.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyQ.Y Units",
                            Type = "PositionUnitType",
                            Value = KeyQ.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyA.Height",
                            Type = "float",
                            Value = KeyA.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyA.Height Units",
                            Type = "DimensionUnitType",
                            Value = KeyA.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyA.Parent",
                            Type = "string",
                            Value = KeyA.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyA.Text",
                            Type = "string",
                            Value = KeyA.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyA.Width",
                            Type = "float",
                            Value = KeyA.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyA.Width Units",
                            Type = "DimensionUnitType",
                            Value = KeyA.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyA.Y Origin",
                            Type = "VerticalAlignment",
                            Value = KeyA.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyA.Y Units",
                            Type = "PositionUnitType",
                            Value = KeyA.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyZ.Height",
                            Type = "float",
                            Value = KeyZ.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyZ.Height Units",
                            Type = "DimensionUnitType",
                            Value = KeyZ.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyZ.Parent",
                            Type = "string",
                            Value = KeyZ.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyZ.Text",
                            Type = "string",
                            Value = KeyZ.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyZ.Width",
                            Type = "float",
                            Value = KeyZ.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyZ.Width Units",
                            Type = "DimensionUnitType",
                            Value = KeyZ.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyZ.Y Origin",
                            Type = "VerticalAlignment",
                            Value = KeyZ.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyZ.Y Units",
                            Type = "PositionUnitType",
                            Value = KeyZ.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyParenLeft.Height",
                            Type = "float",
                            Value = KeyParenLeft.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyParenLeft.Height Units",
                            Type = "DimensionUnitType",
                            Value = KeyParenLeft.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyParenLeft.Parent",
                            Type = "string",
                            Value = KeyParenLeft.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyParenLeft.Text",
                            Type = "string",
                            Value = KeyParenLeft.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyParenLeft.Width",
                            Type = "float",
                            Value = KeyParenLeft.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyParenLeft.Width Units",
                            Type = "DimensionUnitType",
                            Value = KeyParenLeft.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyParenLeft.Y Origin",
                            Type = "VerticalAlignment",
                            Value = KeyParenLeft.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyParenLeft.Y Units",
                            Type = "PositionUnitType",
                            Value = KeyParenLeft.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyW.Height",
                            Type = "float",
                            Value = KeyW.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyW.Height Units",
                            Type = "DimensionUnitType",
                            Value = KeyW.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyW.Parent",
                            Type = "string",
                            Value = KeyW.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyW.Text",
                            Type = "string",
                            Value = KeyW.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyW.Width",
                            Type = "float",
                            Value = KeyW.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyW.Width Units",
                            Type = "DimensionUnitType",
                            Value = KeyW.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyW.Y Origin",
                            Type = "VerticalAlignment",
                            Value = KeyW.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyW.Y Units",
                            Type = "PositionUnitType",
                            Value = KeyW.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyS.Height",
                            Type = "float",
                            Value = KeyS.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyS.Height Units",
                            Type = "DimensionUnitType",
                            Value = KeyS.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyS.Parent",
                            Type = "string",
                            Value = KeyS.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyS.Text",
                            Type = "string",
                            Value = KeyS.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyS.Width",
                            Type = "float",
                            Value = KeyS.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyS.Width Units",
                            Type = "DimensionUnitType",
                            Value = KeyS.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyS.Y Origin",
                            Type = "VerticalAlignment",
                            Value = KeyS.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyS.Y Units",
                            Type = "PositionUnitType",
                            Value = KeyS.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyX.Height",
                            Type = "float",
                            Value = KeyX.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyX.Height Units",
                            Type = "DimensionUnitType",
                            Value = KeyX.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyX.Parent",
                            Type = "string",
                            Value = KeyX.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyX.Text",
                            Type = "string",
                            Value = KeyX.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyX.Width",
                            Type = "float",
                            Value = KeyX.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyX.Width Units",
                            Type = "DimensionUnitType",
                            Value = KeyX.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyX.Y Origin",
                            Type = "VerticalAlignment",
                            Value = KeyX.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyX.Y Units",
                            Type = "PositionUnitType",
                            Value = KeyX.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyParenRight.Height",
                            Type = "float",
                            Value = KeyParenRight.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyParenRight.Height Units",
                            Type = "DimensionUnitType",
                            Value = KeyParenRight.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyParenRight.Parent",
                            Type = "string",
                            Value = KeyParenRight.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyParenRight.Text",
                            Type = "string",
                            Value = KeyParenRight.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyParenRight.Width",
                            Type = "float",
                            Value = KeyParenRight.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyParenRight.Width Units",
                            Type = "DimensionUnitType",
                            Value = KeyParenRight.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyParenRight.Y Origin",
                            Type = "VerticalAlignment",
                            Value = KeyParenRight.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyParenRight.Y Units",
                            Type = "PositionUnitType",
                            Value = KeyParenRight.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyE.Height",
                            Type = "float",
                            Value = KeyE.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyE.Height Units",
                            Type = "DimensionUnitType",
                            Value = KeyE.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyE.Parent",
                            Type = "string",
                            Value = KeyE.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyE.Text",
                            Type = "string",
                            Value = KeyE.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyE.Width",
                            Type = "float",
                            Value = KeyE.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyE.Width Units",
                            Type = "DimensionUnitType",
                            Value = KeyE.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyE.Y Origin",
                            Type = "VerticalAlignment",
                            Value = KeyE.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyE.Y Units",
                            Type = "PositionUnitType",
                            Value = KeyE.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyD.Height",
                            Type = "float",
                            Value = KeyD.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyD.Height Units",
                            Type = "DimensionUnitType",
                            Value = KeyD.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyD.Parent",
                            Type = "string",
                            Value = KeyD.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyD.Text",
                            Type = "string",
                            Value = KeyD.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyD.Width",
                            Type = "float",
                            Value = KeyD.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyD.Width Units",
                            Type = "DimensionUnitType",
                            Value = KeyD.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyD.Y Origin",
                            Type = "VerticalAlignment",
                            Value = KeyD.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyD.Y Units",
                            Type = "PositionUnitType",
                            Value = KeyD.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyC.Height",
                            Type = "float",
                            Value = KeyC.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyC.Height Units",
                            Type = "DimensionUnitType",
                            Value = KeyC.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyC.Parent",
                            Type = "string",
                            Value = KeyC.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyC.Text",
                            Type = "string",
                            Value = KeyC.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyC.Width",
                            Type = "float",
                            Value = KeyC.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyC.Width Units",
                            Type = "DimensionUnitType",
                            Value = KeyC.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyC.Y Origin",
                            Type = "VerticalAlignment",
                            Value = KeyC.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyC.Y Units",
                            Type = "PositionUnitType",
                            Value = KeyC.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeySpace.Height",
                            Type = "float",
                            Value = KeySpace.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeySpace.Height Units",
                            Type = "DimensionUnitType",
                            Value = KeySpace.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeySpace.Parent",
                            Type = "string",
                            Value = KeySpace.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeySpace.Text",
                            Type = "string",
                            Value = KeySpace.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeySpace.Width",
                            Type = "float",
                            Value = KeySpace.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeySpace.Width Units",
                            Type = "DimensionUnitType",
                            Value = KeySpace.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeySpace.Y Origin",
                            Type = "VerticalAlignment",
                            Value = KeySpace.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeySpace.Y Units",
                            Type = "PositionUnitType",
                            Value = KeySpace.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyR.Height",
                            Type = "float",
                            Value = KeyR.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyR.Height Units",
                            Type = "DimensionUnitType",
                            Value = KeyR.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyR.Parent",
                            Type = "string",
                            Value = KeyR.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyR.Text",
                            Type = "string",
                            Value = KeyR.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyR.Width",
                            Type = "float",
                            Value = KeyR.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyR.Width Units",
                            Type = "DimensionUnitType",
                            Value = KeyR.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyR.Y Origin",
                            Type = "VerticalAlignment",
                            Value = KeyR.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyR.Y Units",
                            Type = "PositionUnitType",
                            Value = KeyR.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyF.Height",
                            Type = "float",
                            Value = KeyF.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyF.Height Units",
                            Type = "DimensionUnitType",
                            Value = KeyF.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyF.Parent",
                            Type = "string",
                            Value = KeyF.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyF.Text",
                            Type = "string",
                            Value = KeyF.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyF.Width",
                            Type = "float",
                            Value = KeyF.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyF.Width Units",
                            Type = "DimensionUnitType",
                            Value = KeyF.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyF.Y Origin",
                            Type = "VerticalAlignment",
                            Value = KeyF.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyF.Y Units",
                            Type = "PositionUnitType",
                            Value = KeyF.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyV.Height",
                            Type = "float",
                            Value = KeyV.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyV.Height Units",
                            Type = "DimensionUnitType",
                            Value = KeyV.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyV.Parent",
                            Type = "string",
                            Value = KeyV.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyV.Text",
                            Type = "string",
                            Value = KeyV.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyV.Width",
                            Type = "float",
                            Value = KeyV.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyV.Width Units",
                            Type = "DimensionUnitType",
                            Value = KeyV.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyV.Y Origin",
                            Type = "VerticalAlignment",
                            Value = KeyV.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyV.Y Units",
                            Type = "PositionUnitType",
                            Value = KeyV.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyT.Height",
                            Type = "float",
                            Value = KeyT.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyT.Height Units",
                            Type = "DimensionUnitType",
                            Value = KeyT.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyT.Parent",
                            Type = "string",
                            Value = KeyT.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyT.Text",
                            Type = "string",
                            Value = KeyT.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyT.Width",
                            Type = "float",
                            Value = KeyT.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyT.Width Units",
                            Type = "DimensionUnitType",
                            Value = KeyT.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyT.Y Origin",
                            Type = "VerticalAlignment",
                            Value = KeyT.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyT.Y Units",
                            Type = "PositionUnitType",
                            Value = KeyT.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyG.Height",
                            Type = "float",
                            Value = KeyG.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyG.Height Units",
                            Type = "DimensionUnitType",
                            Value = KeyG.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyG.Parent",
                            Type = "string",
                            Value = KeyG.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyG.Text",
                            Type = "string",
                            Value = KeyG.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyG.Width",
                            Type = "float",
                            Value = KeyG.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyG.Width Units",
                            Type = "DimensionUnitType",
                            Value = KeyG.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyG.Y Origin",
                            Type = "VerticalAlignment",
                            Value = KeyG.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyG.Y Units",
                            Type = "PositionUnitType",
                            Value = KeyG.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyB.Height",
                            Type = "float",
                            Value = KeyB.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyB.Height Units",
                            Type = "DimensionUnitType",
                            Value = KeyB.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyB.Parent",
                            Type = "string",
                            Value = KeyB.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyB.Text",
                            Type = "string",
                            Value = KeyB.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyB.Width",
                            Type = "float",
                            Value = KeyB.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyB.Width Units",
                            Type = "DimensionUnitType",
                            Value = KeyB.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyB.Y Origin",
                            Type = "VerticalAlignment",
                            Value = KeyB.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyB.Y Units",
                            Type = "PositionUnitType",
                            Value = KeyB.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyY.Height",
                            Type = "float",
                            Value = KeyY.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyY.Height Units",
                            Type = "DimensionUnitType",
                            Value = KeyY.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyY.Parent",
                            Type = "string",
                            Value = KeyY.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyY.Text",
                            Type = "string",
                            Value = KeyY.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyY.Width",
                            Type = "float",
                            Value = KeyY.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyY.Width Units",
                            Type = "DimensionUnitType",
                            Value = KeyY.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyY.Y Origin",
                            Type = "VerticalAlignment",
                            Value = KeyY.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyY.Y Units",
                            Type = "PositionUnitType",
                            Value = KeyY.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyH.Height",
                            Type = "float",
                            Value = KeyH.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyH.Height Units",
                            Type = "DimensionUnitType",
                            Value = KeyH.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyH.Parent",
                            Type = "string",
                            Value = KeyH.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyH.Text",
                            Type = "string",
                            Value = KeyH.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyH.Width",
                            Type = "float",
                            Value = KeyH.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyH.Width Units",
                            Type = "DimensionUnitType",
                            Value = KeyH.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyH.Y Origin",
                            Type = "VerticalAlignment",
                            Value = KeyH.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyH.Y Units",
                            Type = "PositionUnitType",
                            Value = KeyH.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyN.Height",
                            Type = "float",
                            Value = KeyN.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyN.Height Units",
                            Type = "DimensionUnitType",
                            Value = KeyN.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyN.Parent",
                            Type = "string",
                            Value = KeyN.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyN.Text",
                            Type = "string",
                            Value = KeyN.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyN.Width",
                            Type = "float",
                            Value = KeyN.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyN.Width Units",
                            Type = "DimensionUnitType",
                            Value = KeyN.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyN.Y Origin",
                            Type = "VerticalAlignment",
                            Value = KeyN.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyN.Y Units",
                            Type = "PositionUnitType",
                            Value = KeyN.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyU.Height",
                            Type = "float",
                            Value = KeyU.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyU.Height Units",
                            Type = "DimensionUnitType",
                            Value = KeyU.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyU.Parent",
                            Type = "string",
                            Value = KeyU.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyU.Text",
                            Type = "string",
                            Value = KeyU.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyU.Width",
                            Type = "float",
                            Value = KeyU.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyU.Width Units",
                            Type = "DimensionUnitType",
                            Value = KeyU.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyU.Y Origin",
                            Type = "VerticalAlignment",
                            Value = KeyU.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyU.Y Units",
                            Type = "PositionUnitType",
                            Value = KeyU.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyJ.Height",
                            Type = "float",
                            Value = KeyJ.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyJ.Height Units",
                            Type = "DimensionUnitType",
                            Value = KeyJ.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyJ.Parent",
                            Type = "string",
                            Value = KeyJ.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyJ.Text",
                            Type = "string",
                            Value = KeyJ.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyJ.Width",
                            Type = "float",
                            Value = KeyJ.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyJ.Width Units",
                            Type = "DimensionUnitType",
                            Value = KeyJ.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyJ.Y Origin",
                            Type = "VerticalAlignment",
                            Value = KeyJ.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyJ.Y Units",
                            Type = "PositionUnitType",
                            Value = KeyJ.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyM.Height",
                            Type = "float",
                            Value = KeyM.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyM.Height Units",
                            Type = "DimensionUnitType",
                            Value = KeyM.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyM.Parent",
                            Type = "string",
                            Value = KeyM.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyM.Text",
                            Type = "string",
                            Value = KeyM.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyM.Width",
                            Type = "float",
                            Value = KeyM.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyM.Width Units",
                            Type = "DimensionUnitType",
                            Value = KeyM.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyM.Y Origin",
                            Type = "VerticalAlignment",
                            Value = KeyM.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyM.Y Units",
                            Type = "PositionUnitType",
                            Value = KeyM.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyI.Height",
                            Type = "float",
                            Value = KeyI.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyI.Height Units",
                            Type = "DimensionUnitType",
                            Value = KeyI.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyI.Parent",
                            Type = "string",
                            Value = KeyI.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyI.Text",
                            Type = "string",
                            Value = KeyI.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyI.Width",
                            Type = "float",
                            Value = KeyI.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyI.Width Units",
                            Type = "DimensionUnitType",
                            Value = KeyI.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyI.Y Origin",
                            Type = "VerticalAlignment",
                            Value = KeyI.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyI.Y Units",
                            Type = "PositionUnitType",
                            Value = KeyI.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyK.Height",
                            Type = "float",
                            Value = KeyK.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyK.Height Units",
                            Type = "DimensionUnitType",
                            Value = KeyK.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyK.Parent",
                            Type = "string",
                            Value = KeyK.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyK.Text",
                            Type = "string",
                            Value = KeyK.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyK.Width",
                            Type = "float",
                            Value = KeyK.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyK.Width Units",
                            Type = "DimensionUnitType",
                            Value = KeyK.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyK.Y Origin",
                            Type = "VerticalAlignment",
                            Value = KeyK.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyK.Y Units",
                            Type = "PositionUnitType",
                            Value = KeyK.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyComma.Height",
                            Type = "float",
                            Value = KeyComma.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyComma.Height Units",
                            Type = "DimensionUnitType",
                            Value = KeyComma.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyComma.Parent",
                            Type = "string",
                            Value = KeyComma.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyComma.Text",
                            Type = "string",
                            Value = KeyComma.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyComma.Width",
                            Type = "float",
                            Value = KeyComma.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyComma.Width Units",
                            Type = "DimensionUnitType",
                            Value = KeyComma.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyComma.Y Origin",
                            Type = "VerticalAlignment",
                            Value = KeyComma.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyComma.Y Units",
                            Type = "PositionUnitType",
                            Value = KeyComma.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyQuestion.Height",
                            Type = "float",
                            Value = KeyQuestion.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyQuestion.Height Units",
                            Type = "DimensionUnitType",
                            Value = KeyQuestion.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyQuestion.Parent",
                            Type = "string",
                            Value = KeyQuestion.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyQuestion.Text",
                            Type = "string",
                            Value = KeyQuestion.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyQuestion.Width",
                            Type = "float",
                            Value = KeyQuestion.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyQuestion.Width Units",
                            Type = "DimensionUnitType",
                            Value = KeyQuestion.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyQuestion.Y Origin",
                            Type = "VerticalAlignment",
                            Value = KeyQuestion.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyQuestion.Y Units",
                            Type = "PositionUnitType",
                            Value = KeyQuestion.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyO.Height",
                            Type = "float",
                            Value = KeyO.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyO.Height Units",
                            Type = "DimensionUnitType",
                            Value = KeyO.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyO.Parent",
                            Type = "string",
                            Value = KeyO.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyO.Text",
                            Type = "string",
                            Value = KeyO.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyO.Width",
                            Type = "float",
                            Value = KeyO.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyO.Width Units",
                            Type = "DimensionUnitType",
                            Value = KeyO.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyO.Y Origin",
                            Type = "VerticalAlignment",
                            Value = KeyO.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyO.Y Units",
                            Type = "PositionUnitType",
                            Value = KeyO.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyL.Height",
                            Type = "float",
                            Value = KeyL.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyL.Height Units",
                            Type = "DimensionUnitType",
                            Value = KeyL.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyL.Parent",
                            Type = "string",
                            Value = KeyL.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyL.Text",
                            Type = "string",
                            Value = KeyL.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyL.Width",
                            Type = "float",
                            Value = KeyL.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyL.Width Units",
                            Type = "DimensionUnitType",
                            Value = KeyL.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyL.Y Origin",
                            Type = "VerticalAlignment",
                            Value = KeyL.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyL.Y Units",
                            Type = "PositionUnitType",
                            Value = KeyL.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyPeriod.Height",
                            Type = "float",
                            Value = KeyPeriod.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyPeriod.Height Units",
                            Type = "DimensionUnitType",
                            Value = KeyPeriod.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyPeriod.Parent",
                            Type = "string",
                            Value = KeyPeriod.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyPeriod.Text",
                            Type = "string",
                            Value = KeyPeriod.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyPeriod.Width",
                            Type = "float",
                            Value = KeyPeriod.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyPeriod.Width Units",
                            Type = "DimensionUnitType",
                            Value = KeyPeriod.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyPeriod.Y Origin",
                            Type = "VerticalAlignment",
                            Value = KeyPeriod.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyPeriod.Y Units",
                            Type = "PositionUnitType",
                            Value = KeyPeriod.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyBang.Height",
                            Type = "float",
                            Value = KeyBang.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyBang.Height Units",
                            Type = "DimensionUnitType",
                            Value = KeyBang.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyBang.Parent",
                            Type = "string",
                            Value = KeyBang.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyBang.Text",
                            Type = "string",
                            Value = KeyBang.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyBang.Width",
                            Type = "float",
                            Value = KeyBang.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyBang.Width Units",
                            Type = "DimensionUnitType",
                            Value = KeyBang.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyBang.Y Origin",
                            Type = "VerticalAlignment",
                            Value = KeyBang.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyBang.Y Units",
                            Type = "PositionUnitType",
                            Value = KeyBang.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyP.Height",
                            Type = "float",
                            Value = KeyP.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyP.Height Units",
                            Type = "DimensionUnitType",
                            Value = KeyP.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyP.Parent",
                            Type = "string",
                            Value = KeyP.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyP.Text",
                            Type = "string",
                            Value = KeyP.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyP.Width",
                            Type = "float",
                            Value = KeyP.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyP.Width Units",
                            Type = "DimensionUnitType",
                            Value = KeyP.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyP.Y Origin",
                            Type = "VerticalAlignment",
                            Value = KeyP.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyP.Y Units",
                            Type = "PositionUnitType",
                            Value = KeyP.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyUnderscore.Height",
                            Type = "float",
                            Value = KeyUnderscore.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyUnderscore.Height Units",
                            Type = "DimensionUnitType",
                            Value = KeyUnderscore.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyUnderscore.Parent",
                            Type = "string",
                            Value = KeyUnderscore.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyUnderscore.Text",
                            Type = "string",
                            Value = KeyUnderscore.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyUnderscore.Width",
                            Type = "float",
                            Value = KeyUnderscore.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyUnderscore.Width Units",
                            Type = "DimensionUnitType",
                            Value = KeyUnderscore.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyUnderscore.Y Origin",
                            Type = "VerticalAlignment",
                            Value = KeyUnderscore.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyUnderscore.Y Units",
                            Type = "PositionUnitType",
                            Value = KeyUnderscore.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyHyphen.Height",
                            Type = "float",
                            Value = KeyHyphen.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyHyphen.Height Units",
                            Type = "DimensionUnitType",
                            Value = KeyHyphen.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyHyphen.Parent",
                            Type = "string",
                            Value = KeyHyphen.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyHyphen.Text",
                            Type = "string",
                            Value = KeyHyphen.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyHyphen.Width",
                            Type = "float",
                            Value = KeyHyphen.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyHyphen.Width Units",
                            Type = "DimensionUnitType",
                            Value = KeyHyphen.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyHyphen.Y Origin",
                            Type = "VerticalAlignment",
                            Value = KeyHyphen.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyHyphen.Y Units",
                            Type = "PositionUnitType",
                            Value = KeyHyphen.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyAmpersand.Height",
                            Type = "float",
                            Value = KeyAmpersand.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyAmpersand.Height Units",
                            Type = "DimensionUnitType",
                            Value = KeyAmpersand.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyAmpersand.Parent",
                            Type = "string",
                            Value = KeyAmpersand.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyAmpersand.Text",
                            Type = "string",
                            Value = KeyAmpersand.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyAmpersand.Width",
                            Type = "float",
                            Value = KeyAmpersand.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyAmpersand.Width Units",
                            Type = "DimensionUnitType",
                            Value = KeyAmpersand.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyAmpersand.Y Origin",
                            Type = "VerticalAlignment",
                            Value = KeyAmpersand.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyAmpersand.Y Units",
                            Type = "PositionUnitType",
                            Value = KeyAmpersand.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Key2.Height",
                            Type = "float",
                            Value = Key2.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Key2.Height Units",
                            Type = "DimensionUnitType",
                            Value = Key2.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Key2.Parent",
                            Type = "string",
                            Value = Key2.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Key2.Text",
                            Type = "string",
                            Value = Key2.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Key2.Width",
                            Type = "float",
                            Value = Key2.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Key2.Width Units",
                            Type = "DimensionUnitType",
                            Value = Key2.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Key2.Y Origin",
                            Type = "VerticalAlignment",
                            Value = Key2.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Key2.Y Units",
                            Type = "PositionUnitType",
                            Value = Key2.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Key3.Height",
                            Type = "float",
                            Value = Key3.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Key3.Height Units",
                            Type = "DimensionUnitType",
                            Value = Key3.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Key3.Parent",
                            Type = "string",
                            Value = Key3.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Key3.Text",
                            Type = "string",
                            Value = Key3.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Key3.Width",
                            Type = "float",
                            Value = Key3.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Key3.Width Units",
                            Type = "DimensionUnitType",
                            Value = Key3.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Key3.Y Origin",
                            Type = "VerticalAlignment",
                            Value = Key3.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Key3.Y Units",
                            Type = "PositionUnitType",
                            Value = Key3.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Key4.Height",
                            Type = "float",
                            Value = Key4.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Key4.Height Units",
                            Type = "DimensionUnitType",
                            Value = Key4.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Key4.Parent",
                            Type = "string",
                            Value = Key4.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Key4.Text",
                            Type = "string",
                            Value = Key4.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Key4.Width",
                            Type = "float",
                            Value = Key4.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Key4.Width Units",
                            Type = "DimensionUnitType",
                            Value = Key4.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Key4.Y Origin",
                            Type = "VerticalAlignment",
                            Value = Key4.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Key4.Y Units",
                            Type = "PositionUnitType",
                            Value = Key4.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Key5.Height",
                            Type = "float",
                            Value = Key5.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Key5.Height Units",
                            Type = "DimensionUnitType",
                            Value = Key5.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Key5.Parent",
                            Type = "string",
                            Value = Key5.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Key5.Text",
                            Type = "string",
                            Value = Key5.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Key5.Width",
                            Type = "float",
                            Value = Key5.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Key5.Width Units",
                            Type = "DimensionUnitType",
                            Value = Key5.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Key5.Y Origin",
                            Type = "VerticalAlignment",
                            Value = Key5.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Key5.Y Units",
                            Type = "PositionUnitType",
                            Value = Key5.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Key6.Height",
                            Type = "float",
                            Value = Key6.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Key6.Height Units",
                            Type = "DimensionUnitType",
                            Value = Key6.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Key6.Parent",
                            Type = "string",
                            Value = Key6.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Key6.Text",
                            Type = "string",
                            Value = Key6.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Key6.Width",
                            Type = "float",
                            Value = Key6.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Key6.Width Units",
                            Type = "DimensionUnitType",
                            Value = Key6.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Key6.Y Origin",
                            Type = "VerticalAlignment",
                            Value = Key6.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Key6.Y Units",
                            Type = "PositionUnitType",
                            Value = Key6.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Key7.Height",
                            Type = "float",
                            Value = Key7.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Key7.Height Units",
                            Type = "DimensionUnitType",
                            Value = Key7.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Key7.Parent",
                            Type = "string",
                            Value = Key7.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Key7.Text",
                            Type = "string",
                            Value = Key7.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Key7.Width",
                            Type = "float",
                            Value = Key7.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Key7.Width Units",
                            Type = "DimensionUnitType",
                            Value = Key7.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Key7.Y Origin",
                            Type = "VerticalAlignment",
                            Value = Key7.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Key7.Y Units",
                            Type = "PositionUnitType",
                            Value = Key7.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Key8.Height",
                            Type = "float",
                            Value = Key8.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Key8.Height Units",
                            Type = "DimensionUnitType",
                            Value = Key8.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Key8.Parent",
                            Type = "string",
                            Value = Key8.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Key8.Text",
                            Type = "string",
                            Value = Key8.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Key8.Width",
                            Type = "float",
                            Value = Key8.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Key8.Width Units",
                            Type = "DimensionUnitType",
                            Value = Key8.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Key8.Y Origin",
                            Type = "VerticalAlignment",
                            Value = Key8.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Key8.Y Units",
                            Type = "PositionUnitType",
                            Value = Key8.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Key9.Height",
                            Type = "float",
                            Value = Key9.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Key9.Height Units",
                            Type = "DimensionUnitType",
                            Value = Key9.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Key9.Parent",
                            Type = "string",
                            Value = Key9.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Key9.Text",
                            Type = "string",
                            Value = Key9.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Key9.Width",
                            Type = "float",
                            Value = Key9.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Key9.Width Units",
                            Type = "DimensionUnitType",
                            Value = Key9.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Key9.Y Origin",
                            Type = "VerticalAlignment",
                            Value = Key9.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Key9.Y Units",
                            Type = "PositionUnitType",
                            Value = Key9.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Key0.Height",
                            Type = "float",
                            Value = Key0.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Key0.Height Units",
                            Type = "DimensionUnitType",
                            Value = Key0.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Key0.Parent",
                            Type = "string",
                            Value = Key0.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Key0.Text",
                            Type = "string",
                            Value = Key0.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Key0.Width",
                            Type = "float",
                            Value = Key0.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Key0.Width Units",
                            Type = "DimensionUnitType",
                            Value = Key0.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Key0.Y Origin",
                            Type = "VerticalAlignment",
                            Value = Key0.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Key0.Y Units",
                            Type = "PositionUnitType",
                            Value = Key0.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Row2Keys.Children Layout",
                            Type = "ChildrenLayout",
                            Value = Row2Keys.ChildrenLayout
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Row2Keys.Height",
                            Type = "float",
                            Value = Row2Keys.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Row2Keys.Height Units",
                            Type = "DimensionUnitType",
                            Value = Row2Keys.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Row2Keys.Parent",
                            Type = "string",
                            Value = Row2Keys.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Row2Keys.Width",
                            Type = "float",
                            Value = Row2Keys.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Row2Keys.Width Units",
                            Type = "DimensionUnitType",
                            Value = Row2Keys.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Row3Keys.Children Layout",
                            Type = "ChildrenLayout",
                            Value = Row3Keys.ChildrenLayout
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Row3Keys.Height",
                            Type = "float",
                            Value = Row3Keys.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Row3Keys.Height Units",
                            Type = "DimensionUnitType",
                            Value = Row3Keys.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Row3Keys.Parent",
                            Type = "string",
                            Value = Row3Keys.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Row3Keys.Width",
                            Type = "float",
                            Value = Row3Keys.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Row3Keys.Width Units",
                            Type = "DimensionUnitType",
                            Value = Row3Keys.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Row4Keys.Children Layout",
                            Type = "ChildrenLayout",
                            Value = Row4Keys.ChildrenLayout
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Row4Keys.Height",
                            Type = "float",
                            Value = Row4Keys.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Row4Keys.Height Units",
                            Type = "DimensionUnitType",
                            Value = Row4Keys.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Row4Keys.Parent",
                            Type = "string",
                            Value = Row4Keys.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Row4Keys.Width",
                            Type = "float",
                            Value = Row4Keys.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Row4Keys.Width Units",
                            Type = "DimensionUnitType",
                            Value = Row4Keys.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Row5Keys.Children Layout",
                            Type = "ChildrenLayout",
                            Value = Row5Keys.ChildrenLayout
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Row5Keys.Height",
                            Type = "float",
                            Value = Row5Keys.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Row5Keys.Height Units",
                            Type = "DimensionUnitType",
                            Value = Row5Keys.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Row5Keys.Parent",
                            Type = "string",
                            Value = Row5Keys.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Row5Keys.Width",
                            Type = "float",
                            Value = Row5Keys.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Row5Keys.Width Units",
                            Type = "DimensionUnitType",
                            Value = Row5Keys.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyBackspace.Height",
                            Type = "float",
                            Value = KeyBackspace.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyBackspace.Height Units",
                            Type = "DimensionUnitType",
                            Value = KeyBackspace.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyBackspace.Text",
                            Type = "string",
                            Value = KeyBackspace.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyBackspace.Width",
                            Type = "float",
                            Value = KeyBackspace.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyBackspace.Width Units",
                            Type = "DimensionUnitType",
                            Value = KeyBackspace.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyBackspace.X Origin",
                            Type = "HorizontalAlignment",
                            Value = KeyBackspace.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyBackspace.X Units",
                            Type = "PositionUnitType",
                            Value = KeyBackspace.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyReturn.Height",
                            Type = "float",
                            Value = KeyReturn.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyReturn.Height Units",
                            Type = "DimensionUnitType",
                            Value = KeyReturn.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyReturn.Text",
                            Type = "string",
                            Value = KeyReturn.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyReturn.Width",
                            Type = "float",
                            Value = KeyReturn.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyReturn.Width Units",
                            Type = "DimensionUnitType",
                            Value = KeyReturn.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyReturn.X Origin",
                            Type = "HorizontalAlignment",
                            Value = KeyReturn.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyReturn.X Units",
                            Type = "PositionUnitType",
                            Value = KeyReturn.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyReturn.Y Origin",
                            Type = "VerticalAlignment",
                            Value = KeyReturn.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyReturn.Y Units",
                            Type = "PositionUnitType",
                            Value = KeyReturn.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyLeft.Height Units",
                            Type = "DimensionUnitType",
                            Value = KeyLeft.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyLeft.Text",
                            Type = "string",
                            Value = KeyLeft.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyLeft.Width",
                            Type = "float",
                            Value = KeyLeft.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyLeft.Width Units",
                            Type = "DimensionUnitType",
                            Value = KeyLeft.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyLeft.X",
                            Type = "float",
                            Value = KeyLeft.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyLeft.X Origin",
                            Type = "HorizontalAlignment",
                            Value = KeyLeft.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyLeft.X Units",
                            Type = "PositionUnitType",
                            Value = KeyLeft.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyLeft.Y",
                            Type = "float",
                            Value = KeyLeft.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyLeft.Y Units",
                            Type = "PositionUnitType",
                            Value = KeyLeft.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyRight.Height Units",
                            Type = "DimensionUnitType",
                            Value = KeyRight.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyRight.Text",
                            Type = "string",
                            Value = KeyRight.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyRight.Width",
                            Type = "float",
                            Value = KeyRight.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyRight.Width Units",
                            Type = "DimensionUnitType",
                            Value = KeyRight.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyRight.X",
                            Type = "float",
                            Value = KeyRight.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyRight.X Origin",
                            Type = "HorizontalAlignment",
                            Value = KeyRight.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyRight.X Units",
                            Type = "PositionUnitType",
                            Value = KeyRight.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyRight.Y",
                            Type = "float",
                            Value = KeyRight.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyRight.Y Units",
                            Type = "PositionUnitType",
                            Value = KeyRight.YUnits
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
                            Name = "X Origin",
                            Type = "HorizontalAlignment",
                            Value = XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Row1Keys.Children Layout",
                            Type = "ChildrenLayout",
                            Value = Row1Keys.ChildrenLayout
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Row1Keys.Height",
                            Type = "float",
                            Value = Row1Keys.Height + 20f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Row1Keys.Height Units",
                            Type = "DimensionUnitType",
                            Value = Row1Keys.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Row1Keys.Parent",
                            Type = "string",
                            Value = Row1Keys.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Row1Keys.Width",
                            Type = "float",
                            Value = Row1Keys.Width + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Row1Keys.Width Units",
                            Type = "DimensionUnitType",
                            Value = Row1Keys.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Row1Keys.X Origin",
                            Type = "HorizontalAlignment",
                            Value = Row1Keys.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Row1Keys.X Units",
                            Type = "PositionUnitType",
                            Value = Row1Keys.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Row1Keys.Y Origin",
                            Type = "VerticalAlignment",
                            Value = Row1Keys.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Row1Keys.Y Units",
                            Type = "PositionUnitType",
                            Value = Row1Keys.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyRows.Children Layout",
                            Type = "ChildrenLayout",
                            Value = KeyRows.ChildrenLayout
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyRows.Height",
                            Type = "float",
                            Value = KeyRows.Height + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyRows.Height Units",
                            Type = "DimensionUnitType",
                            Value = KeyRows.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyRows.Width",
                            Type = "float",
                            Value = KeyRows.Width + 90f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyRows.Width Units",
                            Type = "DimensionUnitType",
                            Value = KeyRows.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyRows.X",
                            Type = "float",
                            Value = KeyRows.X + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyRows.X Origin",
                            Type = "HorizontalAlignment",
                            Value = KeyRows.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyRows.X Units",
                            Type = "PositionUnitType",
                            Value = KeyRows.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyRows.Y",
                            Type = "float",
                            Value = KeyRows.Y + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyRows.Y Origin",
                            Type = "VerticalAlignment",
                            Value = KeyRows.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyRows.Y Units",
                            Type = "PositionUnitType",
                            Value = KeyRows.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Key1.Height",
                            Type = "float",
                            Value = Key1.Height + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Key1.Height Units",
                            Type = "DimensionUnitType",
                            Value = Key1.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Key1.Parent",
                            Type = "string",
                            Value = Key1.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Key1.Text",
                            Type = "string",
                            Value = Key1.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Key1.Width",
                            Type = "float",
                            Value = Key1.Width + 10f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Key1.Width Units",
                            Type = "DimensionUnitType",
                            Value = Key1.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Key1.Y Origin",
                            Type = "VerticalAlignment",
                            Value = Key1.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Key1.Y Units",
                            Type = "PositionUnitType",
                            Value = Key1.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyQ.Height",
                            Type = "float",
                            Value = KeyQ.Height + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyQ.Height Units",
                            Type = "DimensionUnitType",
                            Value = KeyQ.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyQ.Parent",
                            Type = "string",
                            Value = KeyQ.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyQ.Text",
                            Type = "string",
                            Value = KeyQ.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyQ.Width",
                            Type = "float",
                            Value = KeyQ.Width + 10f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyQ.Width Units",
                            Type = "DimensionUnitType",
                            Value = KeyQ.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyQ.Y Origin",
                            Type = "VerticalAlignment",
                            Value = KeyQ.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyQ.Y Units",
                            Type = "PositionUnitType",
                            Value = KeyQ.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyA.Height",
                            Type = "float",
                            Value = KeyA.Height + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyA.Height Units",
                            Type = "DimensionUnitType",
                            Value = KeyA.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyA.Parent",
                            Type = "string",
                            Value = KeyA.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyA.Text",
                            Type = "string",
                            Value = KeyA.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyA.Width",
                            Type = "float",
                            Value = KeyA.Width + 10f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyA.Width Units",
                            Type = "DimensionUnitType",
                            Value = KeyA.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyA.Y Origin",
                            Type = "VerticalAlignment",
                            Value = KeyA.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyA.Y Units",
                            Type = "PositionUnitType",
                            Value = KeyA.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyZ.Height",
                            Type = "float",
                            Value = KeyZ.Height + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyZ.Height Units",
                            Type = "DimensionUnitType",
                            Value = KeyZ.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyZ.Parent",
                            Type = "string",
                            Value = KeyZ.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyZ.Text",
                            Type = "string",
                            Value = KeyZ.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyZ.Width",
                            Type = "float",
                            Value = KeyZ.Width + 10f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyZ.Width Units",
                            Type = "DimensionUnitType",
                            Value = KeyZ.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyZ.Y Origin",
                            Type = "VerticalAlignment",
                            Value = KeyZ.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyZ.Y Units",
                            Type = "PositionUnitType",
                            Value = KeyZ.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyParenLeft.Height",
                            Type = "float",
                            Value = KeyParenLeft.Height + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyParenLeft.Height Units",
                            Type = "DimensionUnitType",
                            Value = KeyParenLeft.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyParenLeft.Parent",
                            Type = "string",
                            Value = KeyParenLeft.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyParenLeft.Text",
                            Type = "string",
                            Value = KeyParenLeft.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyParenLeft.Width",
                            Type = "float",
                            Value = KeyParenLeft.Width + 10f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyParenLeft.Width Units",
                            Type = "DimensionUnitType",
                            Value = KeyParenLeft.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyParenLeft.Y Origin",
                            Type = "VerticalAlignment",
                            Value = KeyParenLeft.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyParenLeft.Y Units",
                            Type = "PositionUnitType",
                            Value = KeyParenLeft.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyW.Height",
                            Type = "float",
                            Value = KeyW.Height + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyW.Height Units",
                            Type = "DimensionUnitType",
                            Value = KeyW.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyW.Parent",
                            Type = "string",
                            Value = KeyW.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyW.Text",
                            Type = "string",
                            Value = KeyW.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyW.Width",
                            Type = "float",
                            Value = KeyW.Width + 10f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyW.Width Units",
                            Type = "DimensionUnitType",
                            Value = KeyW.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyW.Y Origin",
                            Type = "VerticalAlignment",
                            Value = KeyW.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyW.Y Units",
                            Type = "PositionUnitType",
                            Value = KeyW.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyS.Height",
                            Type = "float",
                            Value = KeyS.Height + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyS.Height Units",
                            Type = "DimensionUnitType",
                            Value = KeyS.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyS.Parent",
                            Type = "string",
                            Value = KeyS.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyS.Text",
                            Type = "string",
                            Value = KeyS.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyS.Width",
                            Type = "float",
                            Value = KeyS.Width + 10f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyS.Width Units",
                            Type = "DimensionUnitType",
                            Value = KeyS.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyS.Y Origin",
                            Type = "VerticalAlignment",
                            Value = KeyS.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyS.Y Units",
                            Type = "PositionUnitType",
                            Value = KeyS.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyX.Height",
                            Type = "float",
                            Value = KeyX.Height + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyX.Height Units",
                            Type = "DimensionUnitType",
                            Value = KeyX.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyX.Parent",
                            Type = "string",
                            Value = KeyX.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyX.Text",
                            Type = "string",
                            Value = KeyX.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyX.Width",
                            Type = "float",
                            Value = KeyX.Width + 10f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyX.Width Units",
                            Type = "DimensionUnitType",
                            Value = KeyX.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyX.Y Origin",
                            Type = "VerticalAlignment",
                            Value = KeyX.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyX.Y Units",
                            Type = "PositionUnitType",
                            Value = KeyX.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyParenRight.Height",
                            Type = "float",
                            Value = KeyParenRight.Height + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyParenRight.Height Units",
                            Type = "DimensionUnitType",
                            Value = KeyParenRight.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyParenRight.Parent",
                            Type = "string",
                            Value = KeyParenRight.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyParenRight.Text",
                            Type = "string",
                            Value = KeyParenRight.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyParenRight.Width",
                            Type = "float",
                            Value = KeyParenRight.Width + 10f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyParenRight.Width Units",
                            Type = "DimensionUnitType",
                            Value = KeyParenRight.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyParenRight.Y Origin",
                            Type = "VerticalAlignment",
                            Value = KeyParenRight.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyParenRight.Y Units",
                            Type = "PositionUnitType",
                            Value = KeyParenRight.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyE.Height",
                            Type = "float",
                            Value = KeyE.Height + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyE.Height Units",
                            Type = "DimensionUnitType",
                            Value = KeyE.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyE.Parent",
                            Type = "string",
                            Value = KeyE.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyE.Text",
                            Type = "string",
                            Value = KeyE.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyE.Width",
                            Type = "float",
                            Value = KeyE.Width + 10f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyE.Width Units",
                            Type = "DimensionUnitType",
                            Value = KeyE.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyE.Y Origin",
                            Type = "VerticalAlignment",
                            Value = KeyE.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyE.Y Units",
                            Type = "PositionUnitType",
                            Value = KeyE.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyD.Height",
                            Type = "float",
                            Value = KeyD.Height + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyD.Height Units",
                            Type = "DimensionUnitType",
                            Value = KeyD.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyD.Parent",
                            Type = "string",
                            Value = KeyD.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyD.Text",
                            Type = "string",
                            Value = KeyD.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyD.Width",
                            Type = "float",
                            Value = KeyD.Width + 10f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyD.Width Units",
                            Type = "DimensionUnitType",
                            Value = KeyD.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyD.Y Origin",
                            Type = "VerticalAlignment",
                            Value = KeyD.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyD.Y Units",
                            Type = "PositionUnitType",
                            Value = KeyD.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyC.Height",
                            Type = "float",
                            Value = KeyC.Height + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyC.Height Units",
                            Type = "DimensionUnitType",
                            Value = KeyC.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyC.Parent",
                            Type = "string",
                            Value = KeyC.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyC.Text",
                            Type = "string",
                            Value = KeyC.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyC.Width",
                            Type = "float",
                            Value = KeyC.Width + 10f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyC.Width Units",
                            Type = "DimensionUnitType",
                            Value = KeyC.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyC.Y Origin",
                            Type = "VerticalAlignment",
                            Value = KeyC.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyC.Y Units",
                            Type = "PositionUnitType",
                            Value = KeyC.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeySpace.Height",
                            Type = "float",
                            Value = KeySpace.Height + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeySpace.Height Units",
                            Type = "DimensionUnitType",
                            Value = KeySpace.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeySpace.Parent",
                            Type = "string",
                            Value = KeySpace.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeySpace.Text",
                            Type = "string",
                            Value = KeySpace.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeySpace.Width",
                            Type = "float",
                            Value = KeySpace.Width + 50f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeySpace.Width Units",
                            Type = "DimensionUnitType",
                            Value = KeySpace.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeySpace.Y Origin",
                            Type = "VerticalAlignment",
                            Value = KeySpace.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeySpace.Y Units",
                            Type = "PositionUnitType",
                            Value = KeySpace.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyR.Height",
                            Type = "float",
                            Value = KeyR.Height + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyR.Height Units",
                            Type = "DimensionUnitType",
                            Value = KeyR.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyR.Parent",
                            Type = "string",
                            Value = KeyR.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyR.Text",
                            Type = "string",
                            Value = KeyR.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyR.Width",
                            Type = "float",
                            Value = KeyR.Width + 10f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyR.Width Units",
                            Type = "DimensionUnitType",
                            Value = KeyR.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyR.Y Origin",
                            Type = "VerticalAlignment",
                            Value = KeyR.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyR.Y Units",
                            Type = "PositionUnitType",
                            Value = KeyR.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyF.Height",
                            Type = "float",
                            Value = KeyF.Height + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyF.Height Units",
                            Type = "DimensionUnitType",
                            Value = KeyF.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyF.Parent",
                            Type = "string",
                            Value = KeyF.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyF.Text",
                            Type = "string",
                            Value = KeyF.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyF.Width",
                            Type = "float",
                            Value = KeyF.Width + 10f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyF.Width Units",
                            Type = "DimensionUnitType",
                            Value = KeyF.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyF.Y Origin",
                            Type = "VerticalAlignment",
                            Value = KeyF.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyF.Y Units",
                            Type = "PositionUnitType",
                            Value = KeyF.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyV.Height",
                            Type = "float",
                            Value = KeyV.Height + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyV.Height Units",
                            Type = "DimensionUnitType",
                            Value = KeyV.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyV.Parent",
                            Type = "string",
                            Value = KeyV.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyV.Text",
                            Type = "string",
                            Value = KeyV.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyV.Width",
                            Type = "float",
                            Value = KeyV.Width + 10f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyV.Width Units",
                            Type = "DimensionUnitType",
                            Value = KeyV.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyV.Y Origin",
                            Type = "VerticalAlignment",
                            Value = KeyV.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyV.Y Units",
                            Type = "PositionUnitType",
                            Value = KeyV.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyT.Height",
                            Type = "float",
                            Value = KeyT.Height + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyT.Height Units",
                            Type = "DimensionUnitType",
                            Value = KeyT.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyT.Parent",
                            Type = "string",
                            Value = KeyT.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyT.Text",
                            Type = "string",
                            Value = KeyT.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyT.Width",
                            Type = "float",
                            Value = KeyT.Width + 10f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyT.Width Units",
                            Type = "DimensionUnitType",
                            Value = KeyT.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyT.Y Origin",
                            Type = "VerticalAlignment",
                            Value = KeyT.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyT.Y Units",
                            Type = "PositionUnitType",
                            Value = KeyT.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyG.Height",
                            Type = "float",
                            Value = KeyG.Height + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyG.Height Units",
                            Type = "DimensionUnitType",
                            Value = KeyG.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyG.Parent",
                            Type = "string",
                            Value = KeyG.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyG.Text",
                            Type = "string",
                            Value = KeyG.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyG.Width",
                            Type = "float",
                            Value = KeyG.Width + 10f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyG.Width Units",
                            Type = "DimensionUnitType",
                            Value = KeyG.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyG.Y Origin",
                            Type = "VerticalAlignment",
                            Value = KeyG.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyG.Y Units",
                            Type = "PositionUnitType",
                            Value = KeyG.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyB.Height",
                            Type = "float",
                            Value = KeyB.Height + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyB.Height Units",
                            Type = "DimensionUnitType",
                            Value = KeyB.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyB.Parent",
                            Type = "string",
                            Value = KeyB.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyB.Text",
                            Type = "string",
                            Value = KeyB.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyB.Width",
                            Type = "float",
                            Value = KeyB.Width + 10f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyB.Width Units",
                            Type = "DimensionUnitType",
                            Value = KeyB.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyB.Y Origin",
                            Type = "VerticalAlignment",
                            Value = KeyB.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyB.Y Units",
                            Type = "PositionUnitType",
                            Value = KeyB.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyY.Height",
                            Type = "float",
                            Value = KeyY.Height + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyY.Height Units",
                            Type = "DimensionUnitType",
                            Value = KeyY.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyY.Parent",
                            Type = "string",
                            Value = KeyY.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyY.Text",
                            Type = "string",
                            Value = KeyY.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyY.Width",
                            Type = "float",
                            Value = KeyY.Width + 10f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyY.Width Units",
                            Type = "DimensionUnitType",
                            Value = KeyY.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyY.Y Origin",
                            Type = "VerticalAlignment",
                            Value = KeyY.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyY.Y Units",
                            Type = "PositionUnitType",
                            Value = KeyY.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyH.Height",
                            Type = "float",
                            Value = KeyH.Height + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyH.Height Units",
                            Type = "DimensionUnitType",
                            Value = KeyH.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyH.Parent",
                            Type = "string",
                            Value = KeyH.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyH.Text",
                            Type = "string",
                            Value = KeyH.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyH.Width",
                            Type = "float",
                            Value = KeyH.Width + 10f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyH.Width Units",
                            Type = "DimensionUnitType",
                            Value = KeyH.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyH.Y Origin",
                            Type = "VerticalAlignment",
                            Value = KeyH.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyH.Y Units",
                            Type = "PositionUnitType",
                            Value = KeyH.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyN.Height",
                            Type = "float",
                            Value = KeyN.Height + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyN.Height Units",
                            Type = "DimensionUnitType",
                            Value = KeyN.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyN.Parent",
                            Type = "string",
                            Value = KeyN.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyN.Text",
                            Type = "string",
                            Value = KeyN.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyN.Width",
                            Type = "float",
                            Value = KeyN.Width + 10f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyN.Width Units",
                            Type = "DimensionUnitType",
                            Value = KeyN.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyN.Y Origin",
                            Type = "VerticalAlignment",
                            Value = KeyN.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyN.Y Units",
                            Type = "PositionUnitType",
                            Value = KeyN.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyU.Height",
                            Type = "float",
                            Value = KeyU.Height + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyU.Height Units",
                            Type = "DimensionUnitType",
                            Value = KeyU.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyU.Parent",
                            Type = "string",
                            Value = KeyU.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyU.Text",
                            Type = "string",
                            Value = KeyU.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyU.Width",
                            Type = "float",
                            Value = KeyU.Width + 10f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyU.Width Units",
                            Type = "DimensionUnitType",
                            Value = KeyU.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyU.Y Origin",
                            Type = "VerticalAlignment",
                            Value = KeyU.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyU.Y Units",
                            Type = "PositionUnitType",
                            Value = KeyU.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyJ.Height",
                            Type = "float",
                            Value = KeyJ.Height + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyJ.Height Units",
                            Type = "DimensionUnitType",
                            Value = KeyJ.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyJ.Parent",
                            Type = "string",
                            Value = KeyJ.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyJ.Text",
                            Type = "string",
                            Value = KeyJ.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyJ.Width",
                            Type = "float",
                            Value = KeyJ.Width + 10f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyJ.Width Units",
                            Type = "DimensionUnitType",
                            Value = KeyJ.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyJ.Y Origin",
                            Type = "VerticalAlignment",
                            Value = KeyJ.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyJ.Y Units",
                            Type = "PositionUnitType",
                            Value = KeyJ.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyM.Height",
                            Type = "float",
                            Value = KeyM.Height + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyM.Height Units",
                            Type = "DimensionUnitType",
                            Value = KeyM.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyM.Parent",
                            Type = "string",
                            Value = KeyM.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyM.Text",
                            Type = "string",
                            Value = KeyM.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyM.Width",
                            Type = "float",
                            Value = KeyM.Width + 10f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyM.Width Units",
                            Type = "DimensionUnitType",
                            Value = KeyM.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyM.Y Origin",
                            Type = "VerticalAlignment",
                            Value = KeyM.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyM.Y Units",
                            Type = "PositionUnitType",
                            Value = KeyM.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyI.Height",
                            Type = "float",
                            Value = KeyI.Height + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyI.Height Units",
                            Type = "DimensionUnitType",
                            Value = KeyI.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyI.Parent",
                            Type = "string",
                            Value = KeyI.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyI.Text",
                            Type = "string",
                            Value = KeyI.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyI.Width",
                            Type = "float",
                            Value = KeyI.Width + 10f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyI.Width Units",
                            Type = "DimensionUnitType",
                            Value = KeyI.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyI.Y Origin",
                            Type = "VerticalAlignment",
                            Value = KeyI.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyI.Y Units",
                            Type = "PositionUnitType",
                            Value = KeyI.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyK.Height",
                            Type = "float",
                            Value = KeyK.Height + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyK.Height Units",
                            Type = "DimensionUnitType",
                            Value = KeyK.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyK.Parent",
                            Type = "string",
                            Value = KeyK.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyK.Text",
                            Type = "string",
                            Value = KeyK.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyK.Width",
                            Type = "float",
                            Value = KeyK.Width + 10f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyK.Width Units",
                            Type = "DimensionUnitType",
                            Value = KeyK.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyK.Y Origin",
                            Type = "VerticalAlignment",
                            Value = KeyK.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyK.Y Units",
                            Type = "PositionUnitType",
                            Value = KeyK.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyComma.Height",
                            Type = "float",
                            Value = KeyComma.Height + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyComma.Height Units",
                            Type = "DimensionUnitType",
                            Value = KeyComma.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyComma.Parent",
                            Type = "string",
                            Value = KeyComma.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyComma.Text",
                            Type = "string",
                            Value = KeyComma.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyComma.Width",
                            Type = "float",
                            Value = KeyComma.Width + 10f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyComma.Width Units",
                            Type = "DimensionUnitType",
                            Value = KeyComma.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyComma.Y Origin",
                            Type = "VerticalAlignment",
                            Value = KeyComma.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyComma.Y Units",
                            Type = "PositionUnitType",
                            Value = KeyComma.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyQuestion.Height",
                            Type = "float",
                            Value = KeyQuestion.Height + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyQuestion.Height Units",
                            Type = "DimensionUnitType",
                            Value = KeyQuestion.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyQuestion.Parent",
                            Type = "string",
                            Value = KeyQuestion.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyQuestion.Text",
                            Type = "string",
                            Value = KeyQuestion.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyQuestion.Width",
                            Type = "float",
                            Value = KeyQuestion.Width + 10f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyQuestion.Width Units",
                            Type = "DimensionUnitType",
                            Value = KeyQuestion.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyQuestion.Y Origin",
                            Type = "VerticalAlignment",
                            Value = KeyQuestion.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyQuestion.Y Units",
                            Type = "PositionUnitType",
                            Value = KeyQuestion.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyO.Height",
                            Type = "float",
                            Value = KeyO.Height + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyO.Height Units",
                            Type = "DimensionUnitType",
                            Value = KeyO.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyO.Parent",
                            Type = "string",
                            Value = KeyO.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyO.Text",
                            Type = "string",
                            Value = KeyO.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyO.Width",
                            Type = "float",
                            Value = KeyO.Width + 10f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyO.Width Units",
                            Type = "DimensionUnitType",
                            Value = KeyO.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyO.Y Origin",
                            Type = "VerticalAlignment",
                            Value = KeyO.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyO.Y Units",
                            Type = "PositionUnitType",
                            Value = KeyO.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyL.Height",
                            Type = "float",
                            Value = KeyL.Height + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyL.Height Units",
                            Type = "DimensionUnitType",
                            Value = KeyL.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyL.Parent",
                            Type = "string",
                            Value = KeyL.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyL.Text",
                            Type = "string",
                            Value = KeyL.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyL.Width",
                            Type = "float",
                            Value = KeyL.Width + 10f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyL.Width Units",
                            Type = "DimensionUnitType",
                            Value = KeyL.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyL.Y Origin",
                            Type = "VerticalAlignment",
                            Value = KeyL.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyL.Y Units",
                            Type = "PositionUnitType",
                            Value = KeyL.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyPeriod.Height",
                            Type = "float",
                            Value = KeyPeriod.Height + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyPeriod.Height Units",
                            Type = "DimensionUnitType",
                            Value = KeyPeriod.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyPeriod.Parent",
                            Type = "string",
                            Value = KeyPeriod.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyPeriod.Text",
                            Type = "string",
                            Value = KeyPeriod.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyPeriod.Width",
                            Type = "float",
                            Value = KeyPeriod.Width + 10f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyPeriod.Width Units",
                            Type = "DimensionUnitType",
                            Value = KeyPeriod.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyPeriod.Y Origin",
                            Type = "VerticalAlignment",
                            Value = KeyPeriod.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyPeriod.Y Units",
                            Type = "PositionUnitType",
                            Value = KeyPeriod.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyBang.Height",
                            Type = "float",
                            Value = KeyBang.Height + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyBang.Height Units",
                            Type = "DimensionUnitType",
                            Value = KeyBang.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyBang.Parent",
                            Type = "string",
                            Value = KeyBang.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyBang.Text",
                            Type = "string",
                            Value = KeyBang.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyBang.Width",
                            Type = "float",
                            Value = KeyBang.Width + 10f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyBang.Width Units",
                            Type = "DimensionUnitType",
                            Value = KeyBang.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyBang.Y Origin",
                            Type = "VerticalAlignment",
                            Value = KeyBang.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyBang.Y Units",
                            Type = "PositionUnitType",
                            Value = KeyBang.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyP.Height",
                            Type = "float",
                            Value = KeyP.Height + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyP.Height Units",
                            Type = "DimensionUnitType",
                            Value = KeyP.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyP.Parent",
                            Type = "string",
                            Value = KeyP.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyP.Text",
                            Type = "string",
                            Value = KeyP.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyP.Width",
                            Type = "float",
                            Value = KeyP.Width + 10f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyP.Width Units",
                            Type = "DimensionUnitType",
                            Value = KeyP.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyP.Y Origin",
                            Type = "VerticalAlignment",
                            Value = KeyP.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyP.Y Units",
                            Type = "PositionUnitType",
                            Value = KeyP.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyUnderscore.Height",
                            Type = "float",
                            Value = KeyUnderscore.Height + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyUnderscore.Height Units",
                            Type = "DimensionUnitType",
                            Value = KeyUnderscore.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyUnderscore.Parent",
                            Type = "string",
                            Value = KeyUnderscore.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyUnderscore.Text",
                            Type = "string",
                            Value = KeyUnderscore.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyUnderscore.Width",
                            Type = "float",
                            Value = KeyUnderscore.Width + 10f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyUnderscore.Width Units",
                            Type = "DimensionUnitType",
                            Value = KeyUnderscore.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyUnderscore.Y Origin",
                            Type = "VerticalAlignment",
                            Value = KeyUnderscore.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyUnderscore.Y Units",
                            Type = "PositionUnitType",
                            Value = KeyUnderscore.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyHyphen.Height",
                            Type = "float",
                            Value = KeyHyphen.Height + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyHyphen.Height Units",
                            Type = "DimensionUnitType",
                            Value = KeyHyphen.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyHyphen.Parent",
                            Type = "string",
                            Value = KeyHyphen.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyHyphen.Text",
                            Type = "string",
                            Value = KeyHyphen.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyHyphen.Width",
                            Type = "float",
                            Value = KeyHyphen.Width + 10f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyHyphen.Width Units",
                            Type = "DimensionUnitType",
                            Value = KeyHyphen.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyHyphen.Y Origin",
                            Type = "VerticalAlignment",
                            Value = KeyHyphen.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyHyphen.Y Units",
                            Type = "PositionUnitType",
                            Value = KeyHyphen.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyAmpersand.Height",
                            Type = "float",
                            Value = KeyAmpersand.Height + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyAmpersand.Height Units",
                            Type = "DimensionUnitType",
                            Value = KeyAmpersand.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyAmpersand.Parent",
                            Type = "string",
                            Value = KeyAmpersand.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyAmpersand.Text",
                            Type = "string",
                            Value = KeyAmpersand.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyAmpersand.Width",
                            Type = "float",
                            Value = KeyAmpersand.Width + 10f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyAmpersand.Width Units",
                            Type = "DimensionUnitType",
                            Value = KeyAmpersand.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyAmpersand.Y Origin",
                            Type = "VerticalAlignment",
                            Value = KeyAmpersand.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyAmpersand.Y Units",
                            Type = "PositionUnitType",
                            Value = KeyAmpersand.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Key2.Height",
                            Type = "float",
                            Value = Key2.Height + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Key2.Height Units",
                            Type = "DimensionUnitType",
                            Value = Key2.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Key2.Parent",
                            Type = "string",
                            Value = Key2.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Key2.Text",
                            Type = "string",
                            Value = Key2.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Key2.Width",
                            Type = "float",
                            Value = Key2.Width + 10f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Key2.Width Units",
                            Type = "DimensionUnitType",
                            Value = Key2.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Key2.Y Origin",
                            Type = "VerticalAlignment",
                            Value = Key2.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Key2.Y Units",
                            Type = "PositionUnitType",
                            Value = Key2.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Key3.Height",
                            Type = "float",
                            Value = Key3.Height + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Key3.Height Units",
                            Type = "DimensionUnitType",
                            Value = Key3.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Key3.Parent",
                            Type = "string",
                            Value = Key3.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Key3.Text",
                            Type = "string",
                            Value = Key3.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Key3.Width",
                            Type = "float",
                            Value = Key3.Width + 10f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Key3.Width Units",
                            Type = "DimensionUnitType",
                            Value = Key3.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Key3.Y Origin",
                            Type = "VerticalAlignment",
                            Value = Key3.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Key3.Y Units",
                            Type = "PositionUnitType",
                            Value = Key3.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Key4.Height",
                            Type = "float",
                            Value = Key4.Height + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Key4.Height Units",
                            Type = "DimensionUnitType",
                            Value = Key4.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Key4.Parent",
                            Type = "string",
                            Value = Key4.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Key4.Text",
                            Type = "string",
                            Value = Key4.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Key4.Width",
                            Type = "float",
                            Value = Key4.Width + 10f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Key4.Width Units",
                            Type = "DimensionUnitType",
                            Value = Key4.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Key4.Y Origin",
                            Type = "VerticalAlignment",
                            Value = Key4.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Key4.Y Units",
                            Type = "PositionUnitType",
                            Value = Key4.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Key5.Height",
                            Type = "float",
                            Value = Key5.Height + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Key5.Height Units",
                            Type = "DimensionUnitType",
                            Value = Key5.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Key5.Parent",
                            Type = "string",
                            Value = Key5.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Key5.Text",
                            Type = "string",
                            Value = Key5.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Key5.Width",
                            Type = "float",
                            Value = Key5.Width + 10f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Key5.Width Units",
                            Type = "DimensionUnitType",
                            Value = Key5.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Key5.Y Origin",
                            Type = "VerticalAlignment",
                            Value = Key5.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Key5.Y Units",
                            Type = "PositionUnitType",
                            Value = Key5.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Key6.Height",
                            Type = "float",
                            Value = Key6.Height + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Key6.Height Units",
                            Type = "DimensionUnitType",
                            Value = Key6.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Key6.Parent",
                            Type = "string",
                            Value = Key6.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Key6.Text",
                            Type = "string",
                            Value = Key6.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Key6.Width",
                            Type = "float",
                            Value = Key6.Width + 10f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Key6.Width Units",
                            Type = "DimensionUnitType",
                            Value = Key6.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Key6.Y Origin",
                            Type = "VerticalAlignment",
                            Value = Key6.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Key6.Y Units",
                            Type = "PositionUnitType",
                            Value = Key6.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Key7.Height",
                            Type = "float",
                            Value = Key7.Height + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Key7.Height Units",
                            Type = "DimensionUnitType",
                            Value = Key7.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Key7.Parent",
                            Type = "string",
                            Value = Key7.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Key7.Text",
                            Type = "string",
                            Value = Key7.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Key7.Width",
                            Type = "float",
                            Value = Key7.Width + 10f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Key7.Width Units",
                            Type = "DimensionUnitType",
                            Value = Key7.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Key7.Y Origin",
                            Type = "VerticalAlignment",
                            Value = Key7.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Key7.Y Units",
                            Type = "PositionUnitType",
                            Value = Key7.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Key8.Height",
                            Type = "float",
                            Value = Key8.Height + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Key8.Height Units",
                            Type = "DimensionUnitType",
                            Value = Key8.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Key8.Parent",
                            Type = "string",
                            Value = Key8.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Key8.Text",
                            Type = "string",
                            Value = Key8.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Key8.Width",
                            Type = "float",
                            Value = Key8.Width + 10f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Key8.Width Units",
                            Type = "DimensionUnitType",
                            Value = Key8.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Key8.Y Origin",
                            Type = "VerticalAlignment",
                            Value = Key8.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Key8.Y Units",
                            Type = "PositionUnitType",
                            Value = Key8.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Key9.Height",
                            Type = "float",
                            Value = Key9.Height + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Key9.Height Units",
                            Type = "DimensionUnitType",
                            Value = Key9.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Key9.Parent",
                            Type = "string",
                            Value = Key9.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Key9.Text",
                            Type = "string",
                            Value = Key9.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Key9.Width",
                            Type = "float",
                            Value = Key9.Width + 10f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Key9.Width Units",
                            Type = "DimensionUnitType",
                            Value = Key9.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Key9.Y Origin",
                            Type = "VerticalAlignment",
                            Value = Key9.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Key9.Y Units",
                            Type = "PositionUnitType",
                            Value = Key9.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Key0.Height",
                            Type = "float",
                            Value = Key0.Height + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Key0.Height Units",
                            Type = "DimensionUnitType",
                            Value = Key0.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Key0.Parent",
                            Type = "string",
                            Value = Key0.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Key0.Text",
                            Type = "string",
                            Value = Key0.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Key0.Width",
                            Type = "float",
                            Value = Key0.Width + 10f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Key0.Width Units",
                            Type = "DimensionUnitType",
                            Value = Key0.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Key0.Y Origin",
                            Type = "VerticalAlignment",
                            Value = Key0.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Key0.Y Units",
                            Type = "PositionUnitType",
                            Value = Key0.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Row2Keys.Children Layout",
                            Type = "ChildrenLayout",
                            Value = Row2Keys.ChildrenLayout
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Row2Keys.Height",
                            Type = "float",
                            Value = Row2Keys.Height + 20f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Row2Keys.Height Units",
                            Type = "DimensionUnitType",
                            Value = Row2Keys.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Row2Keys.Parent",
                            Type = "string",
                            Value = Row2Keys.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Row2Keys.Width",
                            Type = "float",
                            Value = Row2Keys.Width + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Row2Keys.Width Units",
                            Type = "DimensionUnitType",
                            Value = Row2Keys.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Row3Keys.Children Layout",
                            Type = "ChildrenLayout",
                            Value = Row3Keys.ChildrenLayout
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Row3Keys.Height",
                            Type = "float",
                            Value = Row3Keys.Height + 20f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Row3Keys.Height Units",
                            Type = "DimensionUnitType",
                            Value = Row3Keys.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Row3Keys.Parent",
                            Type = "string",
                            Value = Row3Keys.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Row3Keys.Width",
                            Type = "float",
                            Value = Row3Keys.Width + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Row3Keys.Width Units",
                            Type = "DimensionUnitType",
                            Value = Row3Keys.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Row4Keys.Children Layout",
                            Type = "ChildrenLayout",
                            Value = Row4Keys.ChildrenLayout
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Row4Keys.Height",
                            Type = "float",
                            Value = Row4Keys.Height + 20f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Row4Keys.Height Units",
                            Type = "DimensionUnitType",
                            Value = Row4Keys.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Row4Keys.Parent",
                            Type = "string",
                            Value = Row4Keys.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Row4Keys.Width",
                            Type = "float",
                            Value = Row4Keys.Width + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Row4Keys.Width Units",
                            Type = "DimensionUnitType",
                            Value = Row4Keys.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Row5Keys.Children Layout",
                            Type = "ChildrenLayout",
                            Value = Row5Keys.ChildrenLayout
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Row5Keys.Height",
                            Type = "float",
                            Value = Row5Keys.Height + 20f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Row5Keys.Height Units",
                            Type = "DimensionUnitType",
                            Value = Row5Keys.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Row5Keys.Parent",
                            Type = "string",
                            Value = Row5Keys.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Row5Keys.Width",
                            Type = "float",
                            Value = Row5Keys.Width + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Row5Keys.Width Units",
                            Type = "DimensionUnitType",
                            Value = Row5Keys.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyBackspace.Height",
                            Type = "float",
                            Value = KeyBackspace.Height + 20f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyBackspace.Height Units",
                            Type = "DimensionUnitType",
                            Value = KeyBackspace.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyBackspace.Text",
                            Type = "string",
                            Value = KeyBackspace.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyBackspace.Width",
                            Type = "float",
                            Value = KeyBackspace.Width + 10f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyBackspace.Width Units",
                            Type = "DimensionUnitType",
                            Value = KeyBackspace.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyBackspace.X Origin",
                            Type = "HorizontalAlignment",
                            Value = KeyBackspace.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyBackspace.X Units",
                            Type = "PositionUnitType",
                            Value = KeyBackspace.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyReturn.Height",
                            Type = "float",
                            Value = KeyReturn.Height + 40f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyReturn.Height Units",
                            Type = "DimensionUnitType",
                            Value = KeyReturn.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyReturn.Text",
                            Type = "string",
                            Value = KeyReturn.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyReturn.Width",
                            Type = "float",
                            Value = KeyReturn.Width + 10f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyReturn.Width Units",
                            Type = "DimensionUnitType",
                            Value = KeyReturn.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyReturn.X Origin",
                            Type = "HorizontalAlignment",
                            Value = KeyReturn.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyReturn.X Units",
                            Type = "PositionUnitType",
                            Value = KeyReturn.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyReturn.Y Origin",
                            Type = "VerticalAlignment",
                            Value = KeyReturn.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyReturn.Y Units",
                            Type = "PositionUnitType",
                            Value = KeyReturn.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyLeft.Height Units",
                            Type = "DimensionUnitType",
                            Value = KeyLeft.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyLeft.Text",
                            Type = "string",
                            Value = KeyLeft.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyLeft.Width",
                            Type = "float",
                            Value = KeyLeft.Width + 10f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyLeft.Width Units",
                            Type = "DimensionUnitType",
                            Value = KeyLeft.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyLeft.X",
                            Type = "float",
                            Value = KeyLeft.X + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyLeft.X Origin",
                            Type = "HorizontalAlignment",
                            Value = KeyLeft.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyLeft.X Units",
                            Type = "PositionUnitType",
                            Value = KeyLeft.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyLeft.Y",
                            Type = "float",
                            Value = KeyLeft.Y + 20f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyLeft.Y Units",
                            Type = "PositionUnitType",
                            Value = KeyLeft.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyRight.Height Units",
                            Type = "DimensionUnitType",
                            Value = KeyRight.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyRight.Text",
                            Type = "string",
                            Value = KeyRight.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyRight.Width",
                            Type = "float",
                            Value = KeyRight.Width + 10f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyRight.Width Units",
                            Type = "DimensionUnitType",
                            Value = KeyRight.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyRight.X",
                            Type = "float",
                            Value = KeyRight.X + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyRight.X Origin",
                            Type = "HorizontalAlignment",
                            Value = KeyRight.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyRight.X Units",
                            Type = "PositionUnitType",
                            Value = KeyRight.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyRight.Y",
                            Type = "float",
                            Value = KeyRight.Y + 40f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyRight.Y Units",
                            Type = "PositionUnitType",
                            Value = KeyRight.YUnits
                        }
                        );
                        break;
                }
                return newState;
            }
            private Gum.DataTypes.Variables.StateSave GetCurrentValuesOnState (CursorMoveCategory state) 
            {
                Gum.DataTypes.Variables.StateSave newState = new Gum.DataTypes.Variables.StateSave();
                switch(state)
                {
                    case  CursorMoveCategory.LeftRightMoveSupported:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyLeft.Visible",
                            Type = "bool",
                            Value = KeyLeft.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyRight.Visible",
                            Type = "bool",
                            Value = KeyRight.Visible
                        }
                        );
                        break;
                    case  CursorMoveCategory.NoMovement:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyLeft.Visible",
                            Type = "bool",
                            Value = KeyLeft.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyRight.Visible",
                            Type = "bool",
                            Value = KeyRight.Visible
                        }
                        );
                        break;
                }
                return newState;
            }
            private Gum.DataTypes.Variables.StateSave AddToCurrentValuesWithState (CursorMoveCategory state) 
            {
                Gum.DataTypes.Variables.StateSave newState = new Gum.DataTypes.Variables.StateSave();
                switch(state)
                {
                    case  CursorMoveCategory.LeftRightMoveSupported:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyLeft.Visible",
                            Type = "bool",
                            Value = KeyLeft.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyRight.Visible",
                            Type = "bool",
                            Value = KeyRight.Visible
                        }
                        );
                        break;
                    case  CursorMoveCategory.NoMovement:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyLeft.Visible",
                            Type = "bool",
                            Value = KeyLeft.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyRight.Visible",
                            Type = "bool",
                            Value = KeyRight.Visible
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
                    else if (category.Name == "CursorMoveCategory")
                    {
                        if(state.Name == "LeftRightMoveSupported") this.mCurrentCursorMoveCategoryState = CursorMoveCategory.LeftRightMoveSupported;
                        if(state.Name == "NoMovement") this.mCurrentCursorMoveCategoryState = CursorMoveCategory.NoMovement;
                    }
                }
                base.ApplyState(state);
            }
            private bool tryCreateFormsObject;
            public JHP4SD.GumRuntimes.ContainerRuntime Row1Keys { get; set; }
            public JHP4SD.GumRuntimes.ContainerRuntime KeyRows { get; set; }
            public JHP4SD.GumRuntimes.DefaultForms.KeyboardKeyRuntime Key1 { get; set; }
            public JHP4SD.GumRuntimes.DefaultForms.KeyboardKeyRuntime KeyQ { get; set; }
            public JHP4SD.GumRuntimes.DefaultForms.KeyboardKeyRuntime KeyA { get; set; }
            public JHP4SD.GumRuntimes.DefaultForms.KeyboardKeyRuntime KeyZ { get; set; }
            public JHP4SD.GumRuntimes.DefaultForms.KeyboardKeyRuntime KeyParenLeft { get; set; }
            public JHP4SD.GumRuntimes.DefaultForms.KeyboardKeyRuntime KeyW { get; set; }
            public JHP4SD.GumRuntimes.DefaultForms.KeyboardKeyRuntime KeyS { get; set; }
            public JHP4SD.GumRuntimes.DefaultForms.KeyboardKeyRuntime KeyX { get; set; }
            public JHP4SD.GumRuntimes.DefaultForms.KeyboardKeyRuntime KeyParenRight { get; set; }
            public JHP4SD.GumRuntimes.DefaultForms.KeyboardKeyRuntime KeyE { get; set; }
            public JHP4SD.GumRuntimes.DefaultForms.KeyboardKeyRuntime KeyD { get; set; }
            public JHP4SD.GumRuntimes.DefaultForms.KeyboardKeyRuntime KeyC { get; set; }
            public JHP4SD.GumRuntimes.DefaultForms.KeyboardKeyRuntime KeySpace { get; set; }
            public JHP4SD.GumRuntimes.DefaultForms.KeyboardKeyRuntime KeyR { get; set; }
            public JHP4SD.GumRuntimes.DefaultForms.KeyboardKeyRuntime KeyF { get; set; }
            public JHP4SD.GumRuntimes.DefaultForms.KeyboardKeyRuntime KeyV { get; set; }
            public JHP4SD.GumRuntimes.DefaultForms.KeyboardKeyRuntime KeyT { get; set; }
            public JHP4SD.GumRuntimes.DefaultForms.KeyboardKeyRuntime KeyG { get; set; }
            public JHP4SD.GumRuntimes.DefaultForms.KeyboardKeyRuntime KeyB { get; set; }
            public JHP4SD.GumRuntimes.DefaultForms.KeyboardKeyRuntime KeyY { get; set; }
            public JHP4SD.GumRuntimes.DefaultForms.KeyboardKeyRuntime KeyH { get; set; }
            public JHP4SD.GumRuntimes.DefaultForms.KeyboardKeyRuntime KeyN { get; set; }
            public JHP4SD.GumRuntimes.DefaultForms.KeyboardKeyRuntime KeyU { get; set; }
            public JHP4SD.GumRuntimes.DefaultForms.KeyboardKeyRuntime KeyJ { get; set; }
            public JHP4SD.GumRuntimes.DefaultForms.KeyboardKeyRuntime KeyM { get; set; }
            public JHP4SD.GumRuntimes.DefaultForms.KeyboardKeyRuntime KeyI { get; set; }
            public JHP4SD.GumRuntimes.DefaultForms.KeyboardKeyRuntime KeyK { get; set; }
            public JHP4SD.GumRuntimes.DefaultForms.KeyboardKeyRuntime KeyComma { get; set; }
            public JHP4SD.GumRuntimes.DefaultForms.KeyboardKeyRuntime KeyQuestion { get; set; }
            public JHP4SD.GumRuntimes.DefaultForms.KeyboardKeyRuntime KeyO { get; set; }
            public JHP4SD.GumRuntimes.DefaultForms.KeyboardKeyRuntime KeyL { get; set; }
            public JHP4SD.GumRuntimes.DefaultForms.KeyboardKeyRuntime KeyPeriod { get; set; }
            public JHP4SD.GumRuntimes.DefaultForms.KeyboardKeyRuntime KeyBang { get; set; }
            public JHP4SD.GumRuntimes.DefaultForms.KeyboardKeyRuntime KeyP { get; set; }
            public JHP4SD.GumRuntimes.DefaultForms.KeyboardKeyRuntime KeyUnderscore { get; set; }
            public JHP4SD.GumRuntimes.DefaultForms.KeyboardKeyRuntime KeyHyphen { get; set; }
            public JHP4SD.GumRuntimes.DefaultForms.KeyboardKeyRuntime KeyAmpersand { get; set; }
            public JHP4SD.GumRuntimes.DefaultForms.KeyboardKeyRuntime Key2 { get; set; }
            public JHP4SD.GumRuntimes.DefaultForms.KeyboardKeyRuntime Key3 { get; set; }
            public JHP4SD.GumRuntimes.DefaultForms.KeyboardKeyRuntime Key4 { get; set; }
            public JHP4SD.GumRuntimes.DefaultForms.KeyboardKeyRuntime Key5 { get; set; }
            public JHP4SD.GumRuntimes.DefaultForms.KeyboardKeyRuntime Key6 { get; set; }
            public JHP4SD.GumRuntimes.DefaultForms.KeyboardKeyRuntime Key7 { get; set; }
            public JHP4SD.GumRuntimes.DefaultForms.KeyboardKeyRuntime Key8 { get; set; }
            public JHP4SD.GumRuntimes.DefaultForms.KeyboardKeyRuntime Key9 { get; set; }
            public JHP4SD.GumRuntimes.DefaultForms.KeyboardKeyRuntime Key0 { get; set; }
            public JHP4SD.GumRuntimes.ContainerRuntime Row2Keys { get; set; }
            public JHP4SD.GumRuntimes.ContainerRuntime Row3Keys { get; set; }
            public JHP4SD.GumRuntimes.ContainerRuntime Row4Keys { get; set; }
            public JHP4SD.GumRuntimes.ContainerRuntime Row5Keys { get; set; }
            public JHP4SD.GumRuntimes.DefaultForms.ButtonRuntime KeyBackspace { get; set; }
            public JHP4SD.GumRuntimes.DefaultForms.ButtonRuntime KeyReturn { get; set; }
            public JHP4SD.GumRuntimes.DefaultForms.KeyboardKeyRuntime KeyLeft { get; set; }
            public JHP4SD.GumRuntimes.DefaultForms.KeyboardKeyRuntime KeyRight { get; set; }
            public event FlatRedBall.Gui.WindowEvent Key1Click;
            public event FlatRedBall.Gui.WindowEvent KeyQClick;
            public event FlatRedBall.Gui.WindowEvent KeyAClick;
            public event FlatRedBall.Gui.WindowEvent KeyZClick;
            public event FlatRedBall.Gui.WindowEvent KeyParenLeftClick;
            public event FlatRedBall.Gui.WindowEvent KeyWClick;
            public event FlatRedBall.Gui.WindowEvent KeySClick;
            public event FlatRedBall.Gui.WindowEvent KeyXClick;
            public event FlatRedBall.Gui.WindowEvent KeyParenRightClick;
            public event FlatRedBall.Gui.WindowEvent KeyEClick;
            public event FlatRedBall.Gui.WindowEvent KeyDClick;
            public event FlatRedBall.Gui.WindowEvent KeyCClick;
            public event FlatRedBall.Gui.WindowEvent KeySpaceClick;
            public event FlatRedBall.Gui.WindowEvent KeyRClick;
            public event FlatRedBall.Gui.WindowEvent KeyFClick;
            public event FlatRedBall.Gui.WindowEvent KeyVClick;
            public event FlatRedBall.Gui.WindowEvent KeyTClick;
            public event FlatRedBall.Gui.WindowEvent KeyGClick;
            public event FlatRedBall.Gui.WindowEvent KeyBClick;
            public event FlatRedBall.Gui.WindowEvent KeyYClick;
            public event FlatRedBall.Gui.WindowEvent KeyHClick;
            public event FlatRedBall.Gui.WindowEvent KeyNClick;
            public event FlatRedBall.Gui.WindowEvent KeyUClick;
            public event FlatRedBall.Gui.WindowEvent KeyJClick;
            public event FlatRedBall.Gui.WindowEvent KeyMClick;
            public event FlatRedBall.Gui.WindowEvent KeyIClick;
            public event FlatRedBall.Gui.WindowEvent KeyKClick;
            public event FlatRedBall.Gui.WindowEvent KeyCommaClick;
            public event FlatRedBall.Gui.WindowEvent KeyQuestionClick;
            public event FlatRedBall.Gui.WindowEvent KeyOClick;
            public event FlatRedBall.Gui.WindowEvent KeyLClick;
            public event FlatRedBall.Gui.WindowEvent KeyPeriodClick;
            public event FlatRedBall.Gui.WindowEvent KeyBangClick;
            public event FlatRedBall.Gui.WindowEvent KeyPClick;
            public event FlatRedBall.Gui.WindowEvent KeyUnderscoreClick;
            public event FlatRedBall.Gui.WindowEvent KeyHyphenClick;
            public event FlatRedBall.Gui.WindowEvent KeyAmpersandClick;
            public event FlatRedBall.Gui.WindowEvent Key2Click;
            public event FlatRedBall.Gui.WindowEvent Key3Click;
            public event FlatRedBall.Gui.WindowEvent Key4Click;
            public event FlatRedBall.Gui.WindowEvent Key5Click;
            public event FlatRedBall.Gui.WindowEvent Key6Click;
            public event FlatRedBall.Gui.WindowEvent Key7Click;
            public event FlatRedBall.Gui.WindowEvent Key8Click;
            public event FlatRedBall.Gui.WindowEvent Key9Click;
            public event FlatRedBall.Gui.WindowEvent Key0Click;
            public event FlatRedBall.Gui.WindowEvent KeyBackspaceClick;
            public event FlatRedBall.Gui.WindowEvent KeyReturnClick;
            public event FlatRedBall.Gui.WindowEvent KeyLeftClick;
            public event FlatRedBall.Gui.WindowEvent KeyRightClick;
            public KeyboardRuntime (bool fullInstantiation = true, bool tryCreateFormsObject = true) 
            	: base(false, tryCreateFormsObject)
            {
                this.tryCreateFormsObject = tryCreateFormsObject;
                if (fullInstantiation)
                {
                    Gum.DataTypes.ElementSave elementSave = Gum.Managers.ObjectFinder.Self.GumProjectSave.Components.First(item => item.Name == "DefaultForms/Keyboard");
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
                Row1Keys = this.GetGraphicalUiElementByName("Row1Keys") as JHP4SD.GumRuntimes.ContainerRuntime;
                KeyRows = this.GetGraphicalUiElementByName("KeyRows") as JHP4SD.GumRuntimes.ContainerRuntime;
                Key1 = this.GetGraphicalUiElementByName("Key1") as JHP4SD.GumRuntimes.DefaultForms.KeyboardKeyRuntime;
                KeyQ = this.GetGraphicalUiElementByName("KeyQ") as JHP4SD.GumRuntimes.DefaultForms.KeyboardKeyRuntime;
                KeyA = this.GetGraphicalUiElementByName("KeyA") as JHP4SD.GumRuntimes.DefaultForms.KeyboardKeyRuntime;
                KeyZ = this.GetGraphicalUiElementByName("KeyZ") as JHP4SD.GumRuntimes.DefaultForms.KeyboardKeyRuntime;
                KeyParenLeft = this.GetGraphicalUiElementByName("KeyParenLeft") as JHP4SD.GumRuntimes.DefaultForms.KeyboardKeyRuntime;
                KeyW = this.GetGraphicalUiElementByName("KeyW") as JHP4SD.GumRuntimes.DefaultForms.KeyboardKeyRuntime;
                KeyS = this.GetGraphicalUiElementByName("KeyS") as JHP4SD.GumRuntimes.DefaultForms.KeyboardKeyRuntime;
                KeyX = this.GetGraphicalUiElementByName("KeyX") as JHP4SD.GumRuntimes.DefaultForms.KeyboardKeyRuntime;
                KeyParenRight = this.GetGraphicalUiElementByName("KeyParenRight") as JHP4SD.GumRuntimes.DefaultForms.KeyboardKeyRuntime;
                KeyE = this.GetGraphicalUiElementByName("KeyE") as JHP4SD.GumRuntimes.DefaultForms.KeyboardKeyRuntime;
                KeyD = this.GetGraphicalUiElementByName("KeyD") as JHP4SD.GumRuntimes.DefaultForms.KeyboardKeyRuntime;
                KeyC = this.GetGraphicalUiElementByName("KeyC") as JHP4SD.GumRuntimes.DefaultForms.KeyboardKeyRuntime;
                KeySpace = this.GetGraphicalUiElementByName("KeySpace") as JHP4SD.GumRuntimes.DefaultForms.KeyboardKeyRuntime;
                KeyR = this.GetGraphicalUiElementByName("KeyR") as JHP4SD.GumRuntimes.DefaultForms.KeyboardKeyRuntime;
                KeyF = this.GetGraphicalUiElementByName("KeyF") as JHP4SD.GumRuntimes.DefaultForms.KeyboardKeyRuntime;
                KeyV = this.GetGraphicalUiElementByName("KeyV") as JHP4SD.GumRuntimes.DefaultForms.KeyboardKeyRuntime;
                KeyT = this.GetGraphicalUiElementByName("KeyT") as JHP4SD.GumRuntimes.DefaultForms.KeyboardKeyRuntime;
                KeyG = this.GetGraphicalUiElementByName("KeyG") as JHP4SD.GumRuntimes.DefaultForms.KeyboardKeyRuntime;
                KeyB = this.GetGraphicalUiElementByName("KeyB") as JHP4SD.GumRuntimes.DefaultForms.KeyboardKeyRuntime;
                KeyY = this.GetGraphicalUiElementByName("KeyY") as JHP4SD.GumRuntimes.DefaultForms.KeyboardKeyRuntime;
                KeyH = this.GetGraphicalUiElementByName("KeyH") as JHP4SD.GumRuntimes.DefaultForms.KeyboardKeyRuntime;
                KeyN = this.GetGraphicalUiElementByName("KeyN") as JHP4SD.GumRuntimes.DefaultForms.KeyboardKeyRuntime;
                KeyU = this.GetGraphicalUiElementByName("KeyU") as JHP4SD.GumRuntimes.DefaultForms.KeyboardKeyRuntime;
                KeyJ = this.GetGraphicalUiElementByName("KeyJ") as JHP4SD.GumRuntimes.DefaultForms.KeyboardKeyRuntime;
                KeyM = this.GetGraphicalUiElementByName("KeyM") as JHP4SD.GumRuntimes.DefaultForms.KeyboardKeyRuntime;
                KeyI = this.GetGraphicalUiElementByName("KeyI") as JHP4SD.GumRuntimes.DefaultForms.KeyboardKeyRuntime;
                KeyK = this.GetGraphicalUiElementByName("KeyK") as JHP4SD.GumRuntimes.DefaultForms.KeyboardKeyRuntime;
                KeyComma = this.GetGraphicalUiElementByName("KeyComma") as JHP4SD.GumRuntimes.DefaultForms.KeyboardKeyRuntime;
                KeyQuestion = this.GetGraphicalUiElementByName("KeyQuestion") as JHP4SD.GumRuntimes.DefaultForms.KeyboardKeyRuntime;
                KeyO = this.GetGraphicalUiElementByName("KeyO") as JHP4SD.GumRuntimes.DefaultForms.KeyboardKeyRuntime;
                KeyL = this.GetGraphicalUiElementByName("KeyL") as JHP4SD.GumRuntimes.DefaultForms.KeyboardKeyRuntime;
                KeyPeriod = this.GetGraphicalUiElementByName("KeyPeriod") as JHP4SD.GumRuntimes.DefaultForms.KeyboardKeyRuntime;
                KeyBang = this.GetGraphicalUiElementByName("KeyBang") as JHP4SD.GumRuntimes.DefaultForms.KeyboardKeyRuntime;
                KeyP = this.GetGraphicalUiElementByName("KeyP") as JHP4SD.GumRuntimes.DefaultForms.KeyboardKeyRuntime;
                KeyUnderscore = this.GetGraphicalUiElementByName("KeyUnderscore") as JHP4SD.GumRuntimes.DefaultForms.KeyboardKeyRuntime;
                KeyHyphen = this.GetGraphicalUiElementByName("KeyHyphen") as JHP4SD.GumRuntimes.DefaultForms.KeyboardKeyRuntime;
                KeyAmpersand = this.GetGraphicalUiElementByName("KeyAmpersand") as JHP4SD.GumRuntimes.DefaultForms.KeyboardKeyRuntime;
                Key2 = this.GetGraphicalUiElementByName("Key2") as JHP4SD.GumRuntimes.DefaultForms.KeyboardKeyRuntime;
                Key3 = this.GetGraphicalUiElementByName("Key3") as JHP4SD.GumRuntimes.DefaultForms.KeyboardKeyRuntime;
                Key4 = this.GetGraphicalUiElementByName("Key4") as JHP4SD.GumRuntimes.DefaultForms.KeyboardKeyRuntime;
                Key5 = this.GetGraphicalUiElementByName("Key5") as JHP4SD.GumRuntimes.DefaultForms.KeyboardKeyRuntime;
                Key6 = this.GetGraphicalUiElementByName("Key6") as JHP4SD.GumRuntimes.DefaultForms.KeyboardKeyRuntime;
                Key7 = this.GetGraphicalUiElementByName("Key7") as JHP4SD.GumRuntimes.DefaultForms.KeyboardKeyRuntime;
                Key8 = this.GetGraphicalUiElementByName("Key8") as JHP4SD.GumRuntimes.DefaultForms.KeyboardKeyRuntime;
                Key9 = this.GetGraphicalUiElementByName("Key9") as JHP4SD.GumRuntimes.DefaultForms.KeyboardKeyRuntime;
                Key0 = this.GetGraphicalUiElementByName("Key0") as JHP4SD.GumRuntimes.DefaultForms.KeyboardKeyRuntime;
                Row2Keys = this.GetGraphicalUiElementByName("Row2Keys") as JHP4SD.GumRuntimes.ContainerRuntime;
                Row3Keys = this.GetGraphicalUiElementByName("Row3Keys") as JHP4SD.GumRuntimes.ContainerRuntime;
                Row4Keys = this.GetGraphicalUiElementByName("Row4Keys") as JHP4SD.GumRuntimes.ContainerRuntime;
                Row5Keys = this.GetGraphicalUiElementByName("Row5Keys") as JHP4SD.GumRuntimes.ContainerRuntime;
                KeyBackspace = this.GetGraphicalUiElementByName("KeyBackspace") as JHP4SD.GumRuntimes.DefaultForms.ButtonRuntime;
                KeyReturn = this.GetGraphicalUiElementByName("KeyReturn") as JHP4SD.GumRuntimes.DefaultForms.ButtonRuntime;
                KeyLeft = this.GetGraphicalUiElementByName("KeyLeft") as JHP4SD.GumRuntimes.DefaultForms.KeyboardKeyRuntime;
                KeyRight = this.GetGraphicalUiElementByName("KeyRight") as JHP4SD.GumRuntimes.DefaultForms.KeyboardKeyRuntime;
                Key1.Click += (unused) => Key1Click?.Invoke(this);
                KeyQ.Click += (unused) => KeyQClick?.Invoke(this);
                KeyA.Click += (unused) => KeyAClick?.Invoke(this);
                KeyZ.Click += (unused) => KeyZClick?.Invoke(this);
                KeyParenLeft.Click += (unused) => KeyParenLeftClick?.Invoke(this);
                KeyW.Click += (unused) => KeyWClick?.Invoke(this);
                KeyS.Click += (unused) => KeySClick?.Invoke(this);
                KeyX.Click += (unused) => KeyXClick?.Invoke(this);
                KeyParenRight.Click += (unused) => KeyParenRightClick?.Invoke(this);
                KeyE.Click += (unused) => KeyEClick?.Invoke(this);
                KeyD.Click += (unused) => KeyDClick?.Invoke(this);
                KeyC.Click += (unused) => KeyCClick?.Invoke(this);
                KeySpace.Click += (unused) => KeySpaceClick?.Invoke(this);
                KeyR.Click += (unused) => KeyRClick?.Invoke(this);
                KeyF.Click += (unused) => KeyFClick?.Invoke(this);
                KeyV.Click += (unused) => KeyVClick?.Invoke(this);
                KeyT.Click += (unused) => KeyTClick?.Invoke(this);
                KeyG.Click += (unused) => KeyGClick?.Invoke(this);
                KeyB.Click += (unused) => KeyBClick?.Invoke(this);
                KeyY.Click += (unused) => KeyYClick?.Invoke(this);
                KeyH.Click += (unused) => KeyHClick?.Invoke(this);
                KeyN.Click += (unused) => KeyNClick?.Invoke(this);
                KeyU.Click += (unused) => KeyUClick?.Invoke(this);
                KeyJ.Click += (unused) => KeyJClick?.Invoke(this);
                KeyM.Click += (unused) => KeyMClick?.Invoke(this);
                KeyI.Click += (unused) => KeyIClick?.Invoke(this);
                KeyK.Click += (unused) => KeyKClick?.Invoke(this);
                KeyComma.Click += (unused) => KeyCommaClick?.Invoke(this);
                KeyQuestion.Click += (unused) => KeyQuestionClick?.Invoke(this);
                KeyO.Click += (unused) => KeyOClick?.Invoke(this);
                KeyL.Click += (unused) => KeyLClick?.Invoke(this);
                KeyPeriod.Click += (unused) => KeyPeriodClick?.Invoke(this);
                KeyBang.Click += (unused) => KeyBangClick?.Invoke(this);
                KeyP.Click += (unused) => KeyPClick?.Invoke(this);
                KeyUnderscore.Click += (unused) => KeyUnderscoreClick?.Invoke(this);
                KeyHyphen.Click += (unused) => KeyHyphenClick?.Invoke(this);
                KeyAmpersand.Click += (unused) => KeyAmpersandClick?.Invoke(this);
                Key2.Click += (unused) => Key2Click?.Invoke(this);
                Key3.Click += (unused) => Key3Click?.Invoke(this);
                Key4.Click += (unused) => Key4Click?.Invoke(this);
                Key5.Click += (unused) => Key5Click?.Invoke(this);
                Key6.Click += (unused) => Key6Click?.Invoke(this);
                Key7.Click += (unused) => Key7Click?.Invoke(this);
                Key8.Click += (unused) => Key8Click?.Invoke(this);
                Key9.Click += (unused) => Key9Click?.Invoke(this);
                Key0.Click += (unused) => Key0Click?.Invoke(this);
                KeyBackspace.Click += (unused) => KeyBackspaceClick?.Invoke(this);
                KeyReturn.Click += (unused) => KeyReturnClick?.Invoke(this);
                KeyLeft.Click += (unused) => KeyLeftClick?.Invoke(this);
                KeyRight.Click += (unused) => KeyRightClick?.Invoke(this);
                if (tryCreateFormsObject)
                {
                    FormsControlAsObject = new FlatRedBall.Forms.Controls.Games.OnScreenKeyboard(this);
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
            public FlatRedBall.Forms.Controls.Games.OnScreenKeyboard FormsControl {get => (FlatRedBall.Forms.Controls.Games.OnScreenKeyboard) FormsControlAsObject;}
        }
    }
