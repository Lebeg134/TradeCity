    namespace JHP4SD.FormsControls.Screens
    {
        public partial class MapGumForms
        {
            private Gum.Wireframe.GraphicalUiElement Visual;
            public FlatRedBall.Forms.Controls.Button ButtonInstance { get; set; }
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
                ButtonInstance = (FlatRedBall.Forms.Controls.Button)Visual.GetGraphicalUiElementByName("ButtonInstance").FormsControlAsObject;
            }
            partial void CustomInitialize();
        }
    }
