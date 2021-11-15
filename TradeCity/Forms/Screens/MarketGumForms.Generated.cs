    namespace JHP4SD.FormsControls.Screens
    {
        public partial class MarketGumForms
        {
            private Gum.Wireframe.GraphicalUiElement Visual;
            public MarketGumForms () 
            {
                CustomInitialize();
            }
            public MarketGumForms (Gum.Wireframe.GraphicalUiElement visual) 
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
