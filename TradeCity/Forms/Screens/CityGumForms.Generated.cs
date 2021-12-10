    namespace JHP4SD.FormsControls.Screens
    {
        public partial class CityGumForms
        {
            private Gum.Wireframe.GraphicalUiElement Visual;
            public JHP4SD.FormsControls.Components.LebegForms.ComplexComponents.TabMenuForms BuildingTabs { get; set; }
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
                BuildingTabs = new JHP4SD.FormsControls.Components.LebegForms.ComplexComponents.TabMenuForms(Visual.GetGraphicalUiElementByName("BuildingTabs"));
            }
            partial void CustomInitialize();
        }
    }
