    using System.Linq;
    namespace JHP4SD.GumRuntimes
    {
        public partial class MainMenuGumRuntime : Gum.Wireframe.GraphicalUiElement
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
                            PaceholderText.Parent = this.GetGraphicalUiElementByName("BackgroundImage");
                            BackgroundImage.Blue = 255;
                            BackgroundImage.Green = 255;
                            BackgroundImage.Height = 0f;
                            BackgroundImage.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                            BackgroundImage.Red = 255;
                            SetProperty("BackgroundImage.SourceFile", "../GlobalContent/Screen/CityNight.jpg");
                            BackgroundImage.Width = 0f;
                            BackgroundImage.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                            BackgroundImage.X = 0f;
                            BackgroundImage.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                            BackgroundImage.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            BackgroundImage.Y = 0f;
                            BackgroundImage.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            BackgroundImage.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            NewGameButton.MainButtonText = "New Game";
                            NewGameButton.X = 40f;
                            NewGameButton.Y = 40f;
                            LoadGameButton.MainButtonText = "Load Game";
                            LoadGameButton.WrapsChildren = false;
                            LoadGameButton.X = 40f;
                            LoadGameButton.Y = 230f;
                            MultiplayerButton.MainButtonText = "Multiplayer";
                            MultiplayerButton.X = 40f;
                            MultiplayerButton.Y = 420f;
                            SettingsButton.MainButtonText = "Settings";
                            SettingsButton.X = 40f;
                            SettingsButton.Y = 610f;
                            ExitButtonInstance.X = 40f;
                            ExitButtonInstance.Y = -40f;
                            ExitButtonInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Bottom;
                            ExitButtonInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                            GameName.Blue = 0;
                            GameName.FontSize = 128;
                            GameName.Green = 255;
                            GameName.Height = 0f;
                            GameName.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                            GameName.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                            GameName.Red = 255;
                            GameName.Text = "Trade City";
                            GameName.UseFontSmoothing = true;
                            GameName.VerticalAlignment = RenderingLibrary.Graphics.VerticalAlignment.Bottom;
                            GameName.Width = 0f;
                            GameName.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                            GameName.X = 0f;
                            GameName.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                            GameName.XUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                            GameName.Y = 0f;
                            GameName.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Bottom;
                            GameName.YUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                            PaceholderText.Alpha = 150;
                            PaceholderText.Blue = 0;
                            PaceholderText.FontSize = 128;
                            PaceholderText.Height = 100f;
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
                bool setBackgroundImageBlueFirstValue = false;
                bool setBackgroundImageBlueSecondValue = false;
                int BackgroundImageBlueFirstValue= 0;
                int BackgroundImageBlueSecondValue= 0;
                bool setBackgroundImageGreenFirstValue = false;
                bool setBackgroundImageGreenSecondValue = false;
                int BackgroundImageGreenFirstValue= 0;
                int BackgroundImageGreenSecondValue= 0;
                bool setBackgroundImageHeightFirstValue = false;
                bool setBackgroundImageHeightSecondValue = false;
                float BackgroundImageHeightFirstValue= 0;
                float BackgroundImageHeightSecondValue= 0;
                bool setBackgroundImageRedFirstValue = false;
                bool setBackgroundImageRedSecondValue = false;
                int BackgroundImageRedFirstValue= 0;
                int BackgroundImageRedSecondValue= 0;
                bool setBackgroundImageWidthFirstValue = false;
                bool setBackgroundImageWidthSecondValue = false;
                float BackgroundImageWidthFirstValue= 0;
                float BackgroundImageWidthSecondValue= 0;
                bool setBackgroundImageXFirstValue = false;
                bool setBackgroundImageXSecondValue = false;
                float BackgroundImageXFirstValue= 0;
                float BackgroundImageXSecondValue= 0;
                bool setBackgroundImageYFirstValue = false;
                bool setBackgroundImageYSecondValue = false;
                float BackgroundImageYFirstValue= 0;
                float BackgroundImageYSecondValue= 0;
                bool setExitButtonInstanceXFirstValue = false;
                bool setExitButtonInstanceXSecondValue = false;
                float ExitButtonInstanceXFirstValue= 0;
                float ExitButtonInstanceXSecondValue= 0;
                bool setExitButtonInstanceYFirstValue = false;
                bool setExitButtonInstanceYSecondValue = false;
                float ExitButtonInstanceYFirstValue= 0;
                float ExitButtonInstanceYSecondValue= 0;
                bool setGameNameBlueFirstValue = false;
                bool setGameNameBlueSecondValue = false;
                int GameNameBlueFirstValue= 0;
                int GameNameBlueSecondValue= 0;
                bool setGameNameFontSizeFirstValue = false;
                bool setGameNameFontSizeSecondValue = false;
                int GameNameFontSizeFirstValue= 0;
                int GameNameFontSizeSecondValue= 0;
                bool setGameNameGreenFirstValue = false;
                bool setGameNameGreenSecondValue = false;
                int GameNameGreenFirstValue= 0;
                int GameNameGreenSecondValue= 0;
                bool setGameNameHeightFirstValue = false;
                bool setGameNameHeightSecondValue = false;
                float GameNameHeightFirstValue= 0;
                float GameNameHeightSecondValue= 0;
                bool setGameNameRedFirstValue = false;
                bool setGameNameRedSecondValue = false;
                int GameNameRedFirstValue= 0;
                int GameNameRedSecondValue= 0;
                bool setGameNameWidthFirstValue = false;
                bool setGameNameWidthSecondValue = false;
                float GameNameWidthFirstValue= 0;
                float GameNameWidthSecondValue= 0;
                bool setGameNameXFirstValue = false;
                bool setGameNameXSecondValue = false;
                float GameNameXFirstValue= 0;
                float GameNameXSecondValue= 0;
                bool setGameNameYFirstValue = false;
                bool setGameNameYSecondValue = false;
                float GameNameYFirstValue= 0;
                float GameNameYSecondValue= 0;
                bool setLoadGameButtonXFirstValue = false;
                bool setLoadGameButtonXSecondValue = false;
                float LoadGameButtonXFirstValue= 0;
                float LoadGameButtonXSecondValue= 0;
                bool setLoadGameButtonYFirstValue = false;
                bool setLoadGameButtonYSecondValue = false;
                float LoadGameButtonYFirstValue= 0;
                float LoadGameButtonYSecondValue= 0;
                bool setMultiplayerButtonXFirstValue = false;
                bool setMultiplayerButtonXSecondValue = false;
                float MultiplayerButtonXFirstValue= 0;
                float MultiplayerButtonXSecondValue= 0;
                bool setMultiplayerButtonYFirstValue = false;
                bool setMultiplayerButtonYSecondValue = false;
                float MultiplayerButtonYFirstValue= 0;
                float MultiplayerButtonYSecondValue= 0;
                bool setNewGameButtonXFirstValue = false;
                bool setNewGameButtonXSecondValue = false;
                float NewGameButtonXFirstValue= 0;
                float NewGameButtonXSecondValue= 0;
                bool setNewGameButtonYFirstValue = false;
                bool setNewGameButtonYSecondValue = false;
                float NewGameButtonYFirstValue= 0;
                float NewGameButtonYSecondValue= 0;
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
                bool setPaceholderTextHeightFirstValue = false;
                bool setPaceholderTextHeightSecondValue = false;
                float PaceholderTextHeightFirstValue= 0;
                float PaceholderTextHeightSecondValue= 0;
                bool setPaceholderTextRotationFirstValue = false;
                bool setPaceholderTextRotationSecondValue = false;
                float PaceholderTextRotationFirstValue= 0;
                float PaceholderTextRotationSecondValue= 0;
                bool setSettingsButtonXFirstValue = false;
                bool setSettingsButtonXSecondValue = false;
                float SettingsButtonXFirstValue= 0;
                float SettingsButtonXSecondValue= 0;
                bool setSettingsButtonYFirstValue = false;
                bool setSettingsButtonYSecondValue = false;
                float SettingsButtonYFirstValue= 0;
                float SettingsButtonYSecondValue= 0;
                switch(firstState)
                {
                    case  VariableState.Default:
                        setBackgroundImageBlueFirstValue = true;
                        BackgroundImageBlueFirstValue = 255;
                        setBackgroundImageGreenFirstValue = true;
                        BackgroundImageGreenFirstValue = 255;
                        setBackgroundImageHeightFirstValue = true;
                        BackgroundImageHeightFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.BackgroundImage.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        setBackgroundImageRedFirstValue = true;
                        BackgroundImageRedFirstValue = 255;
                        if (interpolationValue < 1)
                        {
                            SetProperty("BackgroundImage.SourceFile", "../GlobalContent/Screen/CityNight.jpg");
                        }
                        setBackgroundImageWidthFirstValue = true;
                        BackgroundImageWidthFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.BackgroundImage.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        setBackgroundImageXFirstValue = true;
                        BackgroundImageXFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.BackgroundImage.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.BackgroundImage.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setBackgroundImageYFirstValue = true;
                        BackgroundImageYFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.BackgroundImage.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.BackgroundImage.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setExitButtonInstanceXFirstValue = true;
                        ExitButtonInstanceXFirstValue = 40f;
                        setExitButtonInstanceYFirstValue = true;
                        ExitButtonInstanceYFirstValue = -40f;
                        if (interpolationValue < 1)
                        {
                            this.ExitButtonInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Bottom;
                        }
                        if (interpolationValue < 1)
                        {
                            this.ExitButtonInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                        }
                        setGameNameBlueFirstValue = true;
                        GameNameBlueFirstValue = 0;
                        setGameNameFontSizeFirstValue = true;
                        GameNameFontSizeFirstValue = 128;
                        setGameNameGreenFirstValue = true;
                        GameNameGreenFirstValue = 255;
                        setGameNameHeightFirstValue = true;
                        GameNameHeightFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.GameName.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        if (interpolationValue < 1)
                        {
                            this.GameName.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                        }
                        setGameNameRedFirstValue = true;
                        GameNameRedFirstValue = 255;
                        if (interpolationValue < 1)
                        {
                            this.GameName.Text = "Trade City";
                        }
                        if (interpolationValue < 1)
                        {
                            this.GameName.UseFontSmoothing = true;
                        }
                        if (interpolationValue < 1)
                        {
                            this.GameName.VerticalAlignment = RenderingLibrary.Graphics.VerticalAlignment.Bottom;
                        }
                        setGameNameWidthFirstValue = true;
                        GameNameWidthFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.GameName.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        setGameNameXFirstValue = true;
                        GameNameXFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.GameName.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                        }
                        if (interpolationValue < 1)
                        {
                            this.GameName.XUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                        }
                        setGameNameYFirstValue = true;
                        GameNameYFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.GameName.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Bottom;
                        }
                        if (interpolationValue < 1)
                        {
                            this.GameName.YUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                        }
                        if (interpolationValue < 1)
                        {
                            this.LoadGameButton.MainButtonText = "Load Game";
                        }
                        if (interpolationValue < 1)
                        {
                            this.LoadGameButton.WrapsChildren = false;
                        }
                        setLoadGameButtonXFirstValue = true;
                        LoadGameButtonXFirstValue = 40f;
                        setLoadGameButtonYFirstValue = true;
                        LoadGameButtonYFirstValue = 230f;
                        if (interpolationValue < 1)
                        {
                            this.MultiplayerButton.MainButtonText = "Multiplayer";
                        }
                        setMultiplayerButtonXFirstValue = true;
                        MultiplayerButtonXFirstValue = 40f;
                        setMultiplayerButtonYFirstValue = true;
                        MultiplayerButtonYFirstValue = 420f;
                        if (interpolationValue < 1)
                        {
                            this.NewGameButton.MainButtonText = "New Game";
                        }
                        setNewGameButtonXFirstValue = true;
                        NewGameButtonXFirstValue = 40f;
                        setNewGameButtonYFirstValue = true;
                        NewGameButtonYFirstValue = 40f;
                        setPaceholderTextAlphaFirstValue = true;
                        PaceholderTextAlphaFirstValue = 150;
                        setPaceholderTextBlueFirstValue = true;
                        PaceholderTextBlueFirstValue = 0;
                        setPaceholderTextFontSizeFirstValue = true;
                        PaceholderTextFontSizeFirstValue = 128;
                        setPaceholderTextHeightFirstValue = true;
                        PaceholderTextHeightFirstValue = 100f;
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
                            this.PaceholderText.Parent = this.GetGraphicalUiElementByName("BackgroundImage");
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
                            this.SettingsButton.MainButtonText = "Settings";
                        }
                        setSettingsButtonXFirstValue = true;
                        SettingsButtonXFirstValue = 40f;
                        setSettingsButtonYFirstValue = true;
                        SettingsButtonYFirstValue = 610f;
                        break;
                }
                switch(secondState)
                {
                    case  VariableState.Default:
                        setBackgroundImageBlueSecondValue = true;
                        BackgroundImageBlueSecondValue = 255;
                        setBackgroundImageGreenSecondValue = true;
                        BackgroundImageGreenSecondValue = 255;
                        setBackgroundImageHeightSecondValue = true;
                        BackgroundImageHeightSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.BackgroundImage.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        setBackgroundImageRedSecondValue = true;
                        BackgroundImageRedSecondValue = 255;
                        if (interpolationValue >= 1)
                        {
                            SetProperty("BackgroundImage.SourceFile", "../GlobalContent/Screen/CityNight.jpg");
                        }
                        setBackgroundImageWidthSecondValue = true;
                        BackgroundImageWidthSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.BackgroundImage.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        setBackgroundImageXSecondValue = true;
                        BackgroundImageXSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.BackgroundImage.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.BackgroundImage.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setBackgroundImageYSecondValue = true;
                        BackgroundImageYSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.BackgroundImage.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.BackgroundImage.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setExitButtonInstanceXSecondValue = true;
                        ExitButtonInstanceXSecondValue = 40f;
                        setExitButtonInstanceYSecondValue = true;
                        ExitButtonInstanceYSecondValue = -40f;
                        if (interpolationValue >= 1)
                        {
                            this.ExitButtonInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Bottom;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.ExitButtonInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                        }
                        setGameNameBlueSecondValue = true;
                        GameNameBlueSecondValue = 0;
                        setGameNameFontSizeSecondValue = true;
                        GameNameFontSizeSecondValue = 128;
                        setGameNameGreenSecondValue = true;
                        GameNameGreenSecondValue = 255;
                        setGameNameHeightSecondValue = true;
                        GameNameHeightSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.GameName.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.GameName.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                        }
                        setGameNameRedSecondValue = true;
                        GameNameRedSecondValue = 255;
                        if (interpolationValue >= 1)
                        {
                            this.GameName.Text = "Trade City";
                        }
                        if (interpolationValue >= 1)
                        {
                            this.GameName.UseFontSmoothing = true;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.GameName.VerticalAlignment = RenderingLibrary.Graphics.VerticalAlignment.Bottom;
                        }
                        setGameNameWidthSecondValue = true;
                        GameNameWidthSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.GameName.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        setGameNameXSecondValue = true;
                        GameNameXSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.GameName.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.GameName.XUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                        }
                        setGameNameYSecondValue = true;
                        GameNameYSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.GameName.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Bottom;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.GameName.YUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.LoadGameButton.MainButtonText = "Load Game";
                        }
                        if (interpolationValue >= 1)
                        {
                            this.LoadGameButton.WrapsChildren = false;
                        }
                        setLoadGameButtonXSecondValue = true;
                        LoadGameButtonXSecondValue = 40f;
                        setLoadGameButtonYSecondValue = true;
                        LoadGameButtonYSecondValue = 230f;
                        if (interpolationValue >= 1)
                        {
                            this.MultiplayerButton.MainButtonText = "Multiplayer";
                        }
                        setMultiplayerButtonXSecondValue = true;
                        MultiplayerButtonXSecondValue = 40f;
                        setMultiplayerButtonYSecondValue = true;
                        MultiplayerButtonYSecondValue = 420f;
                        if (interpolationValue >= 1)
                        {
                            this.NewGameButton.MainButtonText = "New Game";
                        }
                        setNewGameButtonXSecondValue = true;
                        NewGameButtonXSecondValue = 40f;
                        setNewGameButtonYSecondValue = true;
                        NewGameButtonYSecondValue = 40f;
                        setPaceholderTextAlphaSecondValue = true;
                        PaceholderTextAlphaSecondValue = 150;
                        setPaceholderTextBlueSecondValue = true;
                        PaceholderTextBlueSecondValue = 0;
                        setPaceholderTextFontSizeSecondValue = true;
                        PaceholderTextFontSizeSecondValue = 128;
                        setPaceholderTextHeightSecondValue = true;
                        PaceholderTextHeightSecondValue = 100f;
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
                            this.PaceholderText.Parent = this.GetGraphicalUiElementByName("BackgroundImage");
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
                            this.SettingsButton.MainButtonText = "Settings";
                        }
                        setSettingsButtonXSecondValue = true;
                        SettingsButtonXSecondValue = 40f;
                        setSettingsButtonYSecondValue = true;
                        SettingsButtonYSecondValue = 610f;
                        break;
                }
                var wasSuppressed = mIsLayoutSuspended;
                if (wasSuppressed == false)
                {
                    SuspendLayout(true);
                }
                if (setBackgroundImageBlueFirstValue && setBackgroundImageBlueSecondValue)
                {
                    BackgroundImage.Blue = FlatRedBall.Math.MathFunctions.RoundToInt(BackgroundImageBlueFirstValue* (1 - interpolationValue) + BackgroundImageBlueSecondValue * interpolationValue);
                }
                if (setBackgroundImageGreenFirstValue && setBackgroundImageGreenSecondValue)
                {
                    BackgroundImage.Green = FlatRedBall.Math.MathFunctions.RoundToInt(BackgroundImageGreenFirstValue* (1 - interpolationValue) + BackgroundImageGreenSecondValue * interpolationValue);
                }
                if (setBackgroundImageHeightFirstValue && setBackgroundImageHeightSecondValue)
                {
                    BackgroundImage.Height = BackgroundImageHeightFirstValue * (1 - interpolationValue) + BackgroundImageHeightSecondValue * interpolationValue;
                }
                if (setBackgroundImageRedFirstValue && setBackgroundImageRedSecondValue)
                {
                    BackgroundImage.Red = FlatRedBall.Math.MathFunctions.RoundToInt(BackgroundImageRedFirstValue* (1 - interpolationValue) + BackgroundImageRedSecondValue * interpolationValue);
                }
                if (setBackgroundImageWidthFirstValue && setBackgroundImageWidthSecondValue)
                {
                    BackgroundImage.Width = BackgroundImageWidthFirstValue * (1 - interpolationValue) + BackgroundImageWidthSecondValue * interpolationValue;
                }
                if (setBackgroundImageXFirstValue && setBackgroundImageXSecondValue)
                {
                    BackgroundImage.X = BackgroundImageXFirstValue * (1 - interpolationValue) + BackgroundImageXSecondValue * interpolationValue;
                }
                if (setBackgroundImageYFirstValue && setBackgroundImageYSecondValue)
                {
                    BackgroundImage.Y = BackgroundImageYFirstValue * (1 - interpolationValue) + BackgroundImageYSecondValue * interpolationValue;
                }
                if (setExitButtonInstanceXFirstValue && setExitButtonInstanceXSecondValue)
                {
                    ExitButtonInstance.X = ExitButtonInstanceXFirstValue * (1 - interpolationValue) + ExitButtonInstanceXSecondValue * interpolationValue;
                }
                if (setExitButtonInstanceYFirstValue && setExitButtonInstanceYSecondValue)
                {
                    ExitButtonInstance.Y = ExitButtonInstanceYFirstValue * (1 - interpolationValue) + ExitButtonInstanceYSecondValue * interpolationValue;
                }
                if (setGameNameBlueFirstValue && setGameNameBlueSecondValue)
                {
                    GameName.Blue = FlatRedBall.Math.MathFunctions.RoundToInt(GameNameBlueFirstValue* (1 - interpolationValue) + GameNameBlueSecondValue * interpolationValue);
                }
                if (setGameNameFontSizeFirstValue && setGameNameFontSizeSecondValue)
                {
                    GameName.FontSize = FlatRedBall.Math.MathFunctions.RoundToInt(GameNameFontSizeFirstValue* (1 - interpolationValue) + GameNameFontSizeSecondValue * interpolationValue);
                }
                if (setGameNameGreenFirstValue && setGameNameGreenSecondValue)
                {
                    GameName.Green = FlatRedBall.Math.MathFunctions.RoundToInt(GameNameGreenFirstValue* (1 - interpolationValue) + GameNameGreenSecondValue * interpolationValue);
                }
                if (setGameNameHeightFirstValue && setGameNameHeightSecondValue)
                {
                    GameName.Height = GameNameHeightFirstValue * (1 - interpolationValue) + GameNameHeightSecondValue * interpolationValue;
                }
                if (setGameNameRedFirstValue && setGameNameRedSecondValue)
                {
                    GameName.Red = FlatRedBall.Math.MathFunctions.RoundToInt(GameNameRedFirstValue* (1 - interpolationValue) + GameNameRedSecondValue * interpolationValue);
                }
                if (setGameNameWidthFirstValue && setGameNameWidthSecondValue)
                {
                    GameName.Width = GameNameWidthFirstValue * (1 - interpolationValue) + GameNameWidthSecondValue * interpolationValue;
                }
                if (setGameNameXFirstValue && setGameNameXSecondValue)
                {
                    GameName.X = GameNameXFirstValue * (1 - interpolationValue) + GameNameXSecondValue * interpolationValue;
                }
                if (setGameNameYFirstValue && setGameNameYSecondValue)
                {
                    GameName.Y = GameNameYFirstValue * (1 - interpolationValue) + GameNameYSecondValue * interpolationValue;
                }
                if (setLoadGameButtonXFirstValue && setLoadGameButtonXSecondValue)
                {
                    LoadGameButton.X = LoadGameButtonXFirstValue * (1 - interpolationValue) + LoadGameButtonXSecondValue * interpolationValue;
                }
                if (setLoadGameButtonYFirstValue && setLoadGameButtonYSecondValue)
                {
                    LoadGameButton.Y = LoadGameButtonYFirstValue * (1 - interpolationValue) + LoadGameButtonYSecondValue * interpolationValue;
                }
                if (setMultiplayerButtonXFirstValue && setMultiplayerButtonXSecondValue)
                {
                    MultiplayerButton.X = MultiplayerButtonXFirstValue * (1 - interpolationValue) + MultiplayerButtonXSecondValue * interpolationValue;
                }
                if (setMultiplayerButtonYFirstValue && setMultiplayerButtonYSecondValue)
                {
                    MultiplayerButton.Y = MultiplayerButtonYFirstValue * (1 - interpolationValue) + MultiplayerButtonYSecondValue * interpolationValue;
                }
                if (setNewGameButtonXFirstValue && setNewGameButtonXSecondValue)
                {
                    NewGameButton.X = NewGameButtonXFirstValue * (1 - interpolationValue) + NewGameButtonXSecondValue * interpolationValue;
                }
                if (setNewGameButtonYFirstValue && setNewGameButtonYSecondValue)
                {
                    NewGameButton.Y = NewGameButtonYFirstValue * (1 - interpolationValue) + NewGameButtonYSecondValue * interpolationValue;
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
                if (setPaceholderTextHeightFirstValue && setPaceholderTextHeightSecondValue)
                {
                    PaceholderText.Height = PaceholderTextHeightFirstValue * (1 - interpolationValue) + PaceholderTextHeightSecondValue * interpolationValue;
                }
                if (setPaceholderTextRotationFirstValue && setPaceholderTextRotationSecondValue)
                {
                    PaceholderText.Rotation = PaceholderTextRotationFirstValue * (1 - interpolationValue) + PaceholderTextRotationSecondValue * interpolationValue;
                }
                if (setSettingsButtonXFirstValue && setSettingsButtonXSecondValue)
                {
                    SettingsButton.X = SettingsButtonXFirstValue * (1 - interpolationValue) + SettingsButtonXSecondValue * interpolationValue;
                }
                if (setSettingsButtonYFirstValue && setSettingsButtonYSecondValue)
                {
                    SettingsButton.Y = SettingsButtonYFirstValue * (1 - interpolationValue) + SettingsButtonYSecondValue * interpolationValue;
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
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (JHP4SD.GumRuntimes.MainMenuGumRuntime.VariableState fromState,JHP4SD.GumRuntimes.MainMenuGumRuntime.VariableState toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null) 
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
                NewGameButton.StopAnimations();
                LoadGameButton.StopAnimations();
                MultiplayerButton.StopAnimations();
                SettingsButton.StopAnimations();
                ExitButtonInstance.StopAnimations();
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
                            Name = "BackgroundImage.Blue",
                            Type = "int",
                            Value = BackgroundImage.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackgroundImage.Green",
                            Type = "int",
                            Value = BackgroundImage.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackgroundImage.Height",
                            Type = "float",
                            Value = BackgroundImage.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackgroundImage.Height Units",
                            Type = "DimensionUnitType",
                            Value = BackgroundImage.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackgroundImage.Red",
                            Type = "int",
                            Value = BackgroundImage.Red
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackgroundImage.SourceFile",
                            Type = "string",
                            Value = BackgroundImage.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackgroundImage.Width",
                            Type = "float",
                            Value = BackgroundImage.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackgroundImage.Width Units",
                            Type = "DimensionUnitType",
                            Value = BackgroundImage.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackgroundImage.X",
                            Type = "float",
                            Value = BackgroundImage.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackgroundImage.X Origin",
                            Type = "HorizontalAlignment",
                            Value = BackgroundImage.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackgroundImage.X Units",
                            Type = "PositionUnitType",
                            Value = BackgroundImage.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackgroundImage.Y",
                            Type = "float",
                            Value = BackgroundImage.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackgroundImage.Y Origin",
                            Type = "VerticalAlignment",
                            Value = BackgroundImage.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackgroundImage.Y Units",
                            Type = "PositionUnitType",
                            Value = BackgroundImage.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NewGameButton.MainButtonText",
                            Type = "string",
                            Value = NewGameButton.MainButtonText
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NewGameButton.X",
                            Type = "float",
                            Value = NewGameButton.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NewGameButton.Y",
                            Type = "float",
                            Value = NewGameButton.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LoadGameButton.MainButtonText",
                            Type = "string",
                            Value = LoadGameButton.MainButtonText
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LoadGameButton.Wraps Children",
                            Type = "bool",
                            Value = LoadGameButton.WrapsChildren
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LoadGameButton.X",
                            Type = "float",
                            Value = LoadGameButton.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LoadGameButton.Y",
                            Type = "float",
                            Value = LoadGameButton.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MultiplayerButton.MainButtonText",
                            Type = "string",
                            Value = MultiplayerButton.MainButtonText
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MultiplayerButton.X",
                            Type = "float",
                            Value = MultiplayerButton.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MultiplayerButton.Y",
                            Type = "float",
                            Value = MultiplayerButton.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SettingsButton.MainButtonText",
                            Type = "string",
                            Value = SettingsButton.MainButtonText
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SettingsButton.X",
                            Type = "float",
                            Value = SettingsButton.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SettingsButton.Y",
                            Type = "float",
                            Value = SettingsButton.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ExitButtonInstance.X",
                            Type = "float",
                            Value = ExitButtonInstance.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ExitButtonInstance.Y",
                            Type = "float",
                            Value = ExitButtonInstance.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ExitButtonInstance.Y Origin",
                            Type = "VerticalAlignment",
                            Value = ExitButtonInstance.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ExitButtonInstance.Y Units",
                            Type = "PositionUnitType",
                            Value = ExitButtonInstance.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "GameName.Blue",
                            Type = "int",
                            Value = GameName.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "GameName.FontSize",
                            Type = "int",
                            Value = GameName.FontSize
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "GameName.Green",
                            Type = "int",
                            Value = GameName.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "GameName.Height",
                            Type = "float",
                            Value = GameName.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "GameName.Height Units",
                            Type = "DimensionUnitType",
                            Value = GameName.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "GameName.HorizontalAlignment",
                            Type = "HorizontalAlignment",
                            Value = GameName.HorizontalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "GameName.Red",
                            Type = "int",
                            Value = GameName.Red
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "GameName.Text",
                            Type = "string",
                            Value = GameName.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "GameName.UseFontSmoothing",
                            Type = "bool",
                            Value = GameName.UseFontSmoothing
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "GameName.VerticalAlignment",
                            Type = "VerticalAlignment",
                            Value = GameName.VerticalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "GameName.Width",
                            Type = "float",
                            Value = GameName.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "GameName.Width Units",
                            Type = "DimensionUnitType",
                            Value = GameName.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "GameName.X",
                            Type = "float",
                            Value = GameName.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "GameName.X Origin",
                            Type = "HorizontalAlignment",
                            Value = GameName.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "GameName.X Units",
                            Type = "PositionUnitType",
                            Value = GameName.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "GameName.Y",
                            Type = "float",
                            Value = GameName.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "GameName.Y Origin",
                            Type = "VerticalAlignment",
                            Value = GameName.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "GameName.Y Units",
                            Type = "PositionUnitType",
                            Value = GameName.YUnits
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
                            Name = "PaceholderText.Height",
                            Type = "float",
                            Value = PaceholderText.Height
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
                            Name = "BackgroundImage.Blue",
                            Type = "int",
                            Value = BackgroundImage.Blue + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackgroundImage.Green",
                            Type = "int",
                            Value = BackgroundImage.Green + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackgroundImage.Height",
                            Type = "float",
                            Value = BackgroundImage.Height + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackgroundImage.Height Units",
                            Type = "DimensionUnitType",
                            Value = BackgroundImage.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackgroundImage.Red",
                            Type = "int",
                            Value = BackgroundImage.Red + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackgroundImage.SourceFile",
                            Type = "string",
                            Value = BackgroundImage.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackgroundImage.Width",
                            Type = "float",
                            Value = BackgroundImage.Width + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackgroundImage.Width Units",
                            Type = "DimensionUnitType",
                            Value = BackgroundImage.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackgroundImage.X",
                            Type = "float",
                            Value = BackgroundImage.X + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackgroundImage.X Origin",
                            Type = "HorizontalAlignment",
                            Value = BackgroundImage.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackgroundImage.X Units",
                            Type = "PositionUnitType",
                            Value = BackgroundImage.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackgroundImage.Y",
                            Type = "float",
                            Value = BackgroundImage.Y + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackgroundImage.Y Origin",
                            Type = "VerticalAlignment",
                            Value = BackgroundImage.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackgroundImage.Y Units",
                            Type = "PositionUnitType",
                            Value = BackgroundImage.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NewGameButton.MainButtonText",
                            Type = "string",
                            Value = NewGameButton.MainButtonText
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NewGameButton.X",
                            Type = "float",
                            Value = NewGameButton.X + 40f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NewGameButton.Y",
                            Type = "float",
                            Value = NewGameButton.Y + 40f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LoadGameButton.MainButtonText",
                            Type = "string",
                            Value = LoadGameButton.MainButtonText
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LoadGameButton.Wraps Children",
                            Type = "bool",
                            Value = LoadGameButton.WrapsChildren
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LoadGameButton.X",
                            Type = "float",
                            Value = LoadGameButton.X + 40f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LoadGameButton.Y",
                            Type = "float",
                            Value = LoadGameButton.Y + 230f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MultiplayerButton.MainButtonText",
                            Type = "string",
                            Value = MultiplayerButton.MainButtonText
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MultiplayerButton.X",
                            Type = "float",
                            Value = MultiplayerButton.X + 40f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MultiplayerButton.Y",
                            Type = "float",
                            Value = MultiplayerButton.Y + 420f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SettingsButton.MainButtonText",
                            Type = "string",
                            Value = SettingsButton.MainButtonText
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SettingsButton.X",
                            Type = "float",
                            Value = SettingsButton.X + 40f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SettingsButton.Y",
                            Type = "float",
                            Value = SettingsButton.Y + 610f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ExitButtonInstance.X",
                            Type = "float",
                            Value = ExitButtonInstance.X + 40f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ExitButtonInstance.Y",
                            Type = "float",
                            Value = ExitButtonInstance.Y + -40f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ExitButtonInstance.Y Origin",
                            Type = "VerticalAlignment",
                            Value = ExitButtonInstance.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ExitButtonInstance.Y Units",
                            Type = "PositionUnitType",
                            Value = ExitButtonInstance.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "GameName.Blue",
                            Type = "int",
                            Value = GameName.Blue + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "GameName.FontSize",
                            Type = "int",
                            Value = GameName.FontSize + 128
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "GameName.Green",
                            Type = "int",
                            Value = GameName.Green + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "GameName.Height",
                            Type = "float",
                            Value = GameName.Height + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "GameName.Height Units",
                            Type = "DimensionUnitType",
                            Value = GameName.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "GameName.HorizontalAlignment",
                            Type = "HorizontalAlignment",
                            Value = GameName.HorizontalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "GameName.Red",
                            Type = "int",
                            Value = GameName.Red + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "GameName.Text",
                            Type = "string",
                            Value = GameName.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "GameName.UseFontSmoothing",
                            Type = "bool",
                            Value = GameName.UseFontSmoothing
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "GameName.VerticalAlignment",
                            Type = "VerticalAlignment",
                            Value = GameName.VerticalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "GameName.Width",
                            Type = "float",
                            Value = GameName.Width + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "GameName.Width Units",
                            Type = "DimensionUnitType",
                            Value = GameName.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "GameName.X",
                            Type = "float",
                            Value = GameName.X + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "GameName.X Origin",
                            Type = "HorizontalAlignment",
                            Value = GameName.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "GameName.X Units",
                            Type = "PositionUnitType",
                            Value = GameName.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "GameName.Y",
                            Type = "float",
                            Value = GameName.Y + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "GameName.Y Origin",
                            Type = "VerticalAlignment",
                            Value = GameName.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "GameName.Y Units",
                            Type = "PositionUnitType",
                            Value = GameName.YUnits
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
                            Value = PaceholderText.FontSize + 128
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PaceholderText.Height",
                            Type = "float",
                            Value = PaceholderText.Height + 100f
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
            public JHP4SD.GumRuntimes.SpriteRuntime BackgroundImage { get; set; }
            public JHP4SD.GumRuntimes.LebegForms.BasicComponents.MainMenuButtonRuntime NewGameButton { get; set; }
            public JHP4SD.GumRuntimes.LebegForms.BasicComponents.MainMenuButtonRuntime LoadGameButton { get; set; }
            public JHP4SD.GumRuntimes.LebegForms.BasicComponents.MainMenuButtonRuntime MultiplayerButton { get; set; }
            public JHP4SD.GumRuntimes.LebegForms.BasicComponents.MainMenuButtonRuntime SettingsButton { get; set; }
            public JHP4SD.GumRuntimes.LebegForms.BasicComponents.ExitButtonRuntime ExitButtonInstance { get; set; }
            public JHP4SD.GumRuntimes.TextRuntime GameName { get; set; }
            public JHP4SD.GumRuntimes.TextRuntime PaceholderText { get; set; }
            public MainMenuGumRuntime (bool fullInstantiation = true, bool tryCreateFormsObject = true) 
            {
                this.tryCreateFormsObject = tryCreateFormsObject;
                if (fullInstantiation)
                {
                    Gum.DataTypes.ElementSave elementSave = Gum.Managers.ObjectFinder.Self.GumProjectSave.Screens.First(item => item.Name == "MainMenuGum");
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
                BackgroundImage = this.GetGraphicalUiElementByName("BackgroundImage") as JHP4SD.GumRuntimes.SpriteRuntime;
                NewGameButton = this.GetGraphicalUiElementByName("NewGameButton") as JHP4SD.GumRuntimes.LebegForms.BasicComponents.MainMenuButtonRuntime;
                LoadGameButton = this.GetGraphicalUiElementByName("LoadGameButton") as JHP4SD.GumRuntimes.LebegForms.BasicComponents.MainMenuButtonRuntime;
                MultiplayerButton = this.GetGraphicalUiElementByName("MultiplayerButton") as JHP4SD.GumRuntimes.LebegForms.BasicComponents.MainMenuButtonRuntime;
                SettingsButton = this.GetGraphicalUiElementByName("SettingsButton") as JHP4SD.GumRuntimes.LebegForms.BasicComponents.MainMenuButtonRuntime;
                ExitButtonInstance = this.GetGraphicalUiElementByName("ExitButtonInstance") as JHP4SD.GumRuntimes.LebegForms.BasicComponents.ExitButtonRuntime;
                GameName = this.GetGraphicalUiElementByName("GameName") as JHP4SD.GumRuntimes.TextRuntime;
                PaceholderText = this.GetGraphicalUiElementByName("PaceholderText") as JHP4SD.GumRuntimes.TextRuntime;
                if (tryCreateFormsObject)
                {
                    FormsControlAsObject = new JHP4SD.FormsControls.Screens.MainMenuGumForms(this);
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
            public JHP4SD.FormsControls.Screens.MainMenuGumForms FormsControl {get => (JHP4SD.FormsControls.Screens.MainMenuGumForms) FormsControlAsObject;}
        }
    }
