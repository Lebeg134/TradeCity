    namespace JHP4SD.FormsControls.Screens
    {
        public partial class GameScreenGumForms
        {
            private Gum.Wireframe.GraphicalUiElement Visual;
            public FlatRedBall.Forms.Controls.ToggleButton PlayButtonInstance { get; set; }
            public FlatRedBall.Forms.Controls.Button BackButtonInstance { get; set; }
            public JHP4SD.FormsControls.Components.LebegForms.ComplexComponents.ScreenSelectorForms ScreenSelectorInstance { get; set; }
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
                BackButtonInstance = (FlatRedBall.Forms.Controls.Button)Visual.GetGraphicalUiElementByName("BackButtonInstance").FormsControlAsObject;
                ScreenSelectorInstance = new JHP4SD.FormsControls.Components.LebegForms.ComplexComponents.ScreenSelectorForms(Visual.GetGraphicalUiElementByName("ScreenSelectorInstance"));
            }
            partial void CustomInitialize();
        }
    }
