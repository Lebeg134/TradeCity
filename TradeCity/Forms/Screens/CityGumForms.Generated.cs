    namespace JHP4SD.FormsControls.Screens
    {
        public partial class CityGumForms
        {
            private Gum.Wireframe.GraphicalUiElement Visual;
            public CityGumForms () 
            {
                CustomInitialize();
            }
            public CityGumForms (Gum.Wireframe.GraphicalUiElement visual) 
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
