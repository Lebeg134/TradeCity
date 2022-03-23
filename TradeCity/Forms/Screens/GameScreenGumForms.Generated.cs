    namespace JHP4SD.FormsControls.Screens
    {
        public partial class GameScreenGumForms
        {
            private Gum.Wireframe.GraphicalUiElement Visual;
            public FlatRedBall.Forms.Controls.ToggleButton PlayButtonInstance { get; set; }
            public JHP4SD.FormsControls.Components.LebegForms.ComplexComponents.ScreenSelectorForms ScreenSelectorInstance { get; set; }
            public FlatRedBall.Forms.Controls.Button BackButtonInstance { get; set; }
            public FlatRedBall.Forms.Controls.Games.DialogBox DialogBoxInstance { get; set; }
            public FlatRedBall.Forms.Controls.ListBox ResourceList { get; set; }
            public JHP4SD.FormsControls.Components.LebegForms.BasicComponents.ResourceDisplayForms WorkforceDisplay { get; set; }
            public JHP4SD.FormsControls.Components.LebegForms.BasicComponents.ResourceDisplayForms ElectricityDisplay { get; set; }
            public JHP4SD.FormsControls.Components.LebegForms.BasicComponents.ResourceDisplayForms WaterDisplay { get; set; }
            public JHP4SD.FormsControls.Components.LebegForms.BasicComponents.ResourceDisplayForms CoalDisplay { get; set; }
            public JHP4SD.FormsControls.Components.LebegForms.BasicComponents.ResourceDisplayForms MoneyDisplay { get; set; }
            public JHP4SD.FormsControls.Components.LebegForms.BasicComponents.ResourceDisplayForms WoodDisplay { get; set; }
            public JHP4SD.FormsControls.Components.LebegForms.BasicComponents.ResourceDisplayForms SteelDisplay { get; set; }
            public GameScreenGumForms () 
            {
                CustomInitialize();
            }
            public GameScreenGumForms (Gum.Wireframe.GraphicalUiElement visual) 
            {
                Visual = visual;
                ReactToVisualChanged();
                CustomInitialize();
            }
            private void ReactToVisualChanged () 
            {
                PlayButtonInstance = (FlatRedBall.Forms.Controls.ToggleButton)Visual.GetGraphicalUiElementByName("PlayButtonInstance").FormsControlAsObject;
                ScreenSelectorInstance = new JHP4SD.FormsControls.Components.LebegForms.ComplexComponents.ScreenSelectorForms(Visual.GetGraphicalUiElementByName("ScreenSelectorInstance"));
                BackButtonInstance = (FlatRedBall.Forms.Controls.Button)Visual.GetGraphicalUiElementByName("BackButtonInstance").FormsControlAsObject;
                DialogBoxInstance = (FlatRedBall.Forms.Controls.Games.DialogBox)Visual.GetGraphicalUiElementByName("DialogBoxInstance").FormsControlAsObject;
                ResourceList = (FlatRedBall.Forms.Controls.ListBox)Visual.GetGraphicalUiElementByName("ResourceList").FormsControlAsObject;
                WorkforceDisplay = new JHP4SD.FormsControls.Components.LebegForms.BasicComponents.ResourceDisplayForms(Visual.GetGraphicalUiElementByName("WorkforceDisplay"));
                ElectricityDisplay = new JHP4SD.FormsControls.Components.LebegForms.BasicComponents.ResourceDisplayForms(Visual.GetGraphicalUiElementByName("ElectricityDisplay"));
                WaterDisplay = new JHP4SD.FormsControls.Components.LebegForms.BasicComponents.ResourceDisplayForms(Visual.GetGraphicalUiElementByName("WaterDisplay"));
                CoalDisplay = new JHP4SD.FormsControls.Components.LebegForms.BasicComponents.ResourceDisplayForms(Visual.GetGraphicalUiElementByName("CoalDisplay"));
                MoneyDisplay = new JHP4SD.FormsControls.Components.LebegForms.BasicComponents.ResourceDisplayForms(Visual.GetGraphicalUiElementByName("MoneyDisplay"));
                WoodDisplay = new JHP4SD.FormsControls.Components.LebegForms.BasicComponents.ResourceDisplayForms(Visual.GetGraphicalUiElementByName("WoodDisplay"));
                SteelDisplay = new JHP4SD.FormsControls.Components.LebegForms.BasicComponents.ResourceDisplayForms(Visual.GetGraphicalUiElementByName("SteelDisplay"));
            }
            partial void CustomInitialize();
        }
    }
