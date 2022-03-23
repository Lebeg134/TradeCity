    namespace JHP4SD.FormsControls.Screens
    {
        public partial class Level1GumForms
        {
            private Gum.Wireframe.GraphicalUiElement Visual;
            public FlatRedBall.Forms.Controls.Button SecretButton { get; set; }
            public Level1GumForms () 
            {
                CustomInitialize();
            }
            public Level1GumForms (Gum.Wireframe.GraphicalUiElement visual) 
            {
                Visual = visual;
                ReactToVisualChanged();
                CustomInitialize();
            }
            private void ReactToVisualChanged () 
            {
                SecretButton = (FlatRedBall.Forms.Controls.Button)Visual.GetGraphicalUiElementByName("SecretButton").FormsControlAsObject;
            }
            partial void CustomInitialize();
        }
    }
