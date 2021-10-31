    namespace JHP4SD.FormsControls.Screens
    {
        public partial class Level1GumForms
        {
            private Gum.Wireframe.GraphicalUiElement Visual;
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
            }
            partial void CustomInitialize();
        }
    }
