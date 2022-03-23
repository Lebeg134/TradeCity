    namespace JHP4SD.FormsControls.Screens
    {
        public partial class MainMenuGumForms
        {
            private Gum.Wireframe.GraphicalUiElement Visual;
            public FlatRedBall.Forms.Controls.Button NewGameButton { get; set; }
            public FlatRedBall.Forms.Controls.Button LoadGameButton { get; set; }
            public FlatRedBall.Forms.Controls.Button MultiplayerButton { get; set; }
            public FlatRedBall.Forms.Controls.Button SettingsButton { get; set; }
            public FlatRedBall.Forms.Controls.Button ExitButtonInstance { get; set; }
            public MainMenuGumForms () 
            {
                CustomInitialize();
            }
            public MainMenuGumForms (Gum.Wireframe.GraphicalUiElement visual) 
            {
                Visual = visual;
                ReactToVisualChanged();
                CustomInitialize();
            }
            private void ReactToVisualChanged () 
            {
                NewGameButton = (FlatRedBall.Forms.Controls.Button)Visual.GetGraphicalUiElementByName("NewGameButton").FormsControlAsObject;
                LoadGameButton = (FlatRedBall.Forms.Controls.Button)Visual.GetGraphicalUiElementByName("LoadGameButton").FormsControlAsObject;
                MultiplayerButton = (FlatRedBall.Forms.Controls.Button)Visual.GetGraphicalUiElementByName("MultiplayerButton").FormsControlAsObject;
                SettingsButton = (FlatRedBall.Forms.Controls.Button)Visual.GetGraphicalUiElementByName("SettingsButton").FormsControlAsObject;
                ExitButtonInstance = (FlatRedBall.Forms.Controls.Button)Visual.GetGraphicalUiElementByName("ExitButtonInstance").FormsControlAsObject;
            }
            partial void CustomInitialize();
        }
    }
