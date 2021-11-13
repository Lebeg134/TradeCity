    namespace JHP4SD.FormsControls.Screens
    {
        public partial class Level3GumForms
        {
            private Gum.Wireframe.GraphicalUiElement Visual;
            public FlatRedBall.Forms.Controls.Button BackButton { get; set; }
            public Level3GumForms () 
            {
                CustomInitialize();
            }
            public Level3GumForms (Gum.Wireframe.GraphicalUiElement visual) 
            {
                Visual = visual;
                ReactToVisualChanged();
                CustomInitialize();
            }
            private void ReactToVisualChanged () 
            {
                BackButton = (FlatRedBall.Forms.Controls.Button)Visual.GetGraphicalUiElementByName("BackButton").FormsControlAsObject;
            }
            partial void CustomInitialize();
        }
    }
