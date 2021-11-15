    namespace JHP4SD.FormsControls.Screens
    {
        public partial class SettingsGumForms
        {
            private Gum.Wireframe.GraphicalUiElement Visual;
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
            }
            partial void CustomInitialize();
        }
    }
