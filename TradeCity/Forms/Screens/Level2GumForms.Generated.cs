    namespace JHP4SD.FormsControls.Screens
    {
        public partial class Level2GumForms
        {
            private Gum.Wireframe.GraphicalUiElement Visual;
            public Level2GumForms () 
            {
                CustomInitialize();
            }
            public Level2GumForms (Gum.Wireframe.GraphicalUiElement visual) 
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
