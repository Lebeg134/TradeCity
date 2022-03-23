    namespace JHP4SD.FormsControls.Screens
    {
        public partial class MultiplayerGumForms
        {
            private Gum.Wireframe.GraphicalUiElement Visual;
            public MultiplayerGumForms () 
            {
                CustomInitialize();
            }
            public MultiplayerGumForms (Gum.Wireframe.GraphicalUiElement visual) 
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
