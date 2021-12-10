    namespace JHP4SD.FormsControls.Screens
    {
        public partial class CityGumForms
        {
            private Gum.Wireframe.GraphicalUiElement Visual;
            public JHP4SD.FormsControls.Components.LebegForms.ComplexComponents.TabMenuForms TabMenuInstance { get; set; }
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
                TabMenuInstance = new JHP4SD.FormsControls.Components.LebegForms.ComplexComponents.TabMenuForms(Visual.GetGraphicalUiElementByName("TabMenuInstance"));
            }
            partial void CustomInitialize();
        }
    }
