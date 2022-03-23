    namespace JHP4SD.FormsControls.Components.LebegForms.BasicComponents
    {
        public partial class ResourceDisplayForms : FlatRedBall.Forms.Controls.UserControl
        {
            public FlatRedBall.Forms.Controls.Label LabelInstance { get; set; }
            public ResourceDisplayForms () 
            	: base()
            {
                CustomInitialize();
            }
            public ResourceDisplayForms (Gum.Wireframe.GraphicalUiElement visual) 
            	: base(visual)
            {
                CustomInitialize();
            }
            protected override void ReactToVisualChanged () 
            {
                LabelInstance = (FlatRedBall.Forms.Controls.Label)Visual.GetGraphicalUiElementByName("LabelInstance").FormsControlAsObject;
                base.ReactToVisualChanged();
            }
            partial void CustomInitialize();
        }
    }
