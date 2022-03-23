    namespace JHP4SD.FormsControls.Components.LebegForms.BasicComponents
    {
        public partial class LandListItemForms : FlatRedBall.Forms.Controls.UserControl
        {
            public JHP4SD.FormsControls.Components.LebegForms.BasicComponents.ResourceDisplayForms ResourceDisplayInstance { get; set; }
            public FlatRedBall.Forms.Controls.Button ButtonInstance { get; set; }
            public LandListItemForms () 
            	: base()
            {
                CustomInitialize();
            }
            public LandListItemForms (Gum.Wireframe.GraphicalUiElement visual) 
            	: base(visual)
            {
                CustomInitialize();
            }
            protected override void ReactToVisualChanged () 
            {
                ResourceDisplayInstance = new JHP4SD.FormsControls.Components.LebegForms.BasicComponents.ResourceDisplayForms(Visual.GetGraphicalUiElementByName("ResourceDisplayInstance"));
                ButtonInstance = (FlatRedBall.Forms.Controls.Button)Visual.GetGraphicalUiElementByName("ButtonInstance").FormsControlAsObject;
                base.ReactToVisualChanged();
            }
            partial void CustomInitialize();
        }
    }
