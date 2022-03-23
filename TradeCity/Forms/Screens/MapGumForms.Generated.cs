    namespace JHP4SD.FormsControls.Screens
    {
        public partial class MapGumForms
        {
            private Gum.Wireframe.GraphicalUiElement Visual;
            public FlatRedBall.Forms.Controls.ListBox OwnedLands { get; set; }
            public FlatRedBall.Forms.Controls.ListBox BuyableLands { get; set; }
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
                OwnedLands = (FlatRedBall.Forms.Controls.ListBox)Visual.GetGraphicalUiElementByName("OwnedLands").FormsControlAsObject;
                BuyableLands = (FlatRedBall.Forms.Controls.ListBox)Visual.GetGraphicalUiElementByName("BuyableLands").FormsControlAsObject;
            }
            partial void CustomInitialize();
        }
    }
