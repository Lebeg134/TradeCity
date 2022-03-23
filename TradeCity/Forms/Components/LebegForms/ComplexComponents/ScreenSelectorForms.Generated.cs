    namespace JHP4SD.FormsControls.Components.LebegForms.ComplexComponents
    {
        public partial class ScreenSelectorForms : FlatRedBall.Forms.Controls.UserControl
        {
            public FlatRedBall.Forms.Controls.Button CityTab { get; set; }
            public FlatRedBall.Forms.Controls.Button MapTab { get; set; }
            public FlatRedBall.Forms.Controls.Button MarketTab { get; set; }
            public ScreenSelectorForms () 
            	: base()
            {
                CustomInitialize();
            }
            public ScreenSelectorForms (Gum.Wireframe.GraphicalUiElement visual) 
            	: base(visual)
            {
                CustomInitialize();
            }
            protected override void ReactToVisualChanged () 
            {
                CityTab = (FlatRedBall.Forms.Controls.Button)Visual.GetGraphicalUiElementByName("CityTab").FormsControlAsObject;
                MapTab = (FlatRedBall.Forms.Controls.Button)Visual.GetGraphicalUiElementByName("MapTab").FormsControlAsObject;
                MarketTab = (FlatRedBall.Forms.Controls.Button)Visual.GetGraphicalUiElementByName("MarketTab").FormsControlAsObject;
                base.ReactToVisualChanged();
            }
            partial void CustomInitialize();
        }
    }
