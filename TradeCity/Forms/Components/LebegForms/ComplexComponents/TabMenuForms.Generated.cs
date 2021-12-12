    namespace JHP4SD.FormsControls.Components.LebegForms.ComplexComponents
    {
        public partial class TabMenuForms : FlatRedBall.Forms.Controls.UserControl
        {
            public FlatRedBall.Forms.Controls.ListBox CommonList { get; set; }
            public FlatRedBall.Forms.Controls.ListBox ConstructionList { get; set; }
            public FlatRedBall.Forms.Controls.Button CommonTab { get; set; }
            public FlatRedBall.Forms.Controls.Button ConstructionTab { get; set; }
            public FlatRedBall.Forms.Controls.Button EnergyTab { get; set; }
            public FlatRedBall.Forms.Controls.Button OilTab { get; set; }
            public FlatRedBall.Forms.Controls.Button WorkforceTab { get; set; }
            public FlatRedBall.Forms.Controls.ListBox EnergyList { get; set; }
            public FlatRedBall.Forms.Controls.ListBox OilList { get; set; }
            public FlatRedBall.Forms.Controls.ListBox WorkforceList { get; set; }
            public FlatRedBall.Forms.Controls.Popups.Toast ToastInstance { get; set; }
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
                ConstructionList = (FlatRedBall.Forms.Controls.ListBox)Visual.GetGraphicalUiElementByName("ConstructionList").FormsControlAsObject;
                CommonTab = (FlatRedBall.Forms.Controls.Button)Visual.GetGraphicalUiElementByName("CommonTab").FormsControlAsObject;
                ConstructionTab = (FlatRedBall.Forms.Controls.Button)Visual.GetGraphicalUiElementByName("ConstructionTab").FormsControlAsObject;
                EnergyTab = (FlatRedBall.Forms.Controls.Button)Visual.GetGraphicalUiElementByName("EnergyTab").FormsControlAsObject;
                OilTab = (FlatRedBall.Forms.Controls.Button)Visual.GetGraphicalUiElementByName("OilTab").FormsControlAsObject;
                WorkforceTab = (FlatRedBall.Forms.Controls.Button)Visual.GetGraphicalUiElementByName("WorkforceTab").FormsControlAsObject;
                EnergyList = (FlatRedBall.Forms.Controls.ListBox)Visual.GetGraphicalUiElementByName("EnergyList").FormsControlAsObject;
                OilList = (FlatRedBall.Forms.Controls.ListBox)Visual.GetGraphicalUiElementByName("OilList").FormsControlAsObject;
                WorkforceList = (FlatRedBall.Forms.Controls.ListBox)Visual.GetGraphicalUiElementByName("WorkforceList").FormsControlAsObject;
                ToastInstance = (FlatRedBall.Forms.Controls.Popups.Toast)Visual.GetGraphicalUiElementByName("ToastInstance").FormsControlAsObject;
                base.ReactToVisualChanged();
            }
            partial void CustomInitialize();
        }
    }
