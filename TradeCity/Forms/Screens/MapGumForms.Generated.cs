    namespace JHP4SD.FormsControls.Screens
    {
        public partial class MapGumForms
        {
            private Gum.Wireframe.GraphicalUiElement Visual;
            public MapGumForms () 
            {
                CustomInitialize();
            }
            public MapGumForms (Gum.Wireframe.GraphicalUiElement visual) 
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
