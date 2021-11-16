    namespace JHP4SD.FormsControls.Screens
    {
        public partial class SettingsGumForms
        {
            private Gum.Wireframe.GraphicalUiElement Visual;
            public FlatRedBall.Forms.Controls.Button BackButtonInstance { get; set; }
            public SettingsGumForms () 
            {
                CustomInitialize();
            }
            public SettingsGumForms (Gum.Wireframe.GraphicalUiElement visual) 
            {
                Visual = visual;
                ReactToVisualChanged();
                CustomInitialize();
            }
            private void ReactToVisualChanged () 
            {
                BackButtonInstance = (FlatRedBall.Forms.Controls.Button)Visual.GetGraphicalUiElementByName("BackButtonInstance").FormsControlAsObject;
            }
            partial void CustomInitialize();
        }
    }
