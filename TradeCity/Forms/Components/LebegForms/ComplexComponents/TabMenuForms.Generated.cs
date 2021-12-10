    namespace JHP4SD.FormsControls.Components.LebegForms.ComplexComponents
    {
        public partial class TabMenuForms : FlatRedBall.Forms.Controls.UserControl
        {
            public FlatRedBall.Forms.Controls.ListBox CommonList { get; set; }
            public FlatRedBall.Forms.Controls.Button CommonTab { get; set; }
            public FlatRedBall.Forms.Controls.Button ConstructionTab { get; set; }
            public FlatRedBall.Forms.Controls.Button EnergyTab { get; set; }
            public FlatRedBall.Forms.Controls.Button OilTab { get; set; }
            public FlatRedBall.Forms.Controls.Button WorkforceTab { get; set; }
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
                CommonTab = (FlatRedBall.Forms.Controls.Button)Visual.GetGraphicalUiElementByName("CommonTab").FormsControlAsObject;
                ConstructionTab = (FlatRedBall.Forms.Controls.Button)Visual.GetGraphicalUiElementByName("ConstructionTab").FormsControlAsObject;
                EnergyTab = (FlatRedBall.Forms.Controls.Button)Visual.GetGraphicalUiElementByName("EnergyTab").FormsControlAsObject;
                OilTab = (FlatRedBall.Forms.Controls.Button)Visual.GetGraphicalUiElementByName("OilTab").FormsControlAsObject;
                WorkforceTab = (FlatRedBall.Forms.Controls.Button)Visual.GetGraphicalUiElementByName("WorkforceTab").FormsControlAsObject;
                base.ReactToVisualChanged();
            }
            partial void CustomInitialize();
        }
    }
