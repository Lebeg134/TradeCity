    namespace JHP4SD.FormsControls.Components.LebegForms.ComplexComponents
    {
        public partial class TabMenuForms : FlatRedBall.Forms.Controls.UserControl
        {
            public FlatRedBall.Forms.Controls.ListBox CommonList { get; set; }
            public FlatRedBall.Forms.Controls.Button CityMenuTabInstance { get; set; }
            public FlatRedBall.Forms.Controls.Button CityMenuTabInstance1 { get; set; }
            public TabMenuForms () 
            	: base()
            {
                CustomInitialize();
            }
            public TabMenuForms (Gum.Wireframe.GraphicalUiElement visual) 
            	: base(visual)
            {
                CustomInitialize();
            }
            protected override void ReactToVisualChanged () 
            {
                CommonList = (FlatRedBall.Forms.Controls.ListBox)Visual.GetGraphicalUiElementByName("CommonList").FormsControlAsObject;
                CityMenuTabInstance = (FlatRedBall.Forms.Controls.Button)Visual.GetGraphicalUiElementByName("CityMenuTabInstance").FormsControlAsObject;
                CityMenuTabInstance1 = (FlatRedBall.Forms.Controls.Button)Visual.GetGraphicalUiElementByName("CityMenuTabInstance1").FormsControlAsObject;
                base.ReactToVisualChanged();
            }
            partial void CustomInitialize();
        }
    }
