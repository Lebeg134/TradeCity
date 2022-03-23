    namespace JHP4SD.FormsControls.Screens
    {
        public partial class MarketGumForms
        {
            private Gum.Wireframe.GraphicalUiElement Visual;
            public FlatRedBall.Forms.Controls.ListBox MyListingsList { get; set; }
            public FlatRedBall.Forms.Controls.ComboBox ComboBoxInstance { get; set; }
            public FlatRedBall.Forms.Controls.TextBox ToSellAmountTextBoxInstance { get; set; }
            public JHP4SD.FormsControls.Components.LebegForms.BasicComponents.ResourceDisplayForms ResourceDisplayInstance { get; set; }
            public FlatRedBall.Forms.Controls.Button SellOneButtonInstance { get; set; }
            public FlatRedBall.Forms.Controls.Button SellAllButtonInstance { get; set; }
            public FlatRedBall.Forms.Controls.TextBox AutoSellAmountTextBoxInstance { get; set; }
            public FlatRedBall.Forms.Controls.Button AutoSellButtonInstance { get; set; }
            public MarketGumForms () 
            {
                CustomInitialize();
            }
            public MarketGumForms (Gum.Wireframe.GraphicalUiElement visual) 
            {
                Visual = visual;
                ReactToVisualChanged();
                CustomInitialize();
            }
            private void ReactToVisualChanged () 
            {
                MyListingsList = (FlatRedBall.Forms.Controls.ListBox)Visual.GetGraphicalUiElementByName("MyListingsList").FormsControlAsObject;
                ComboBoxInstance = (FlatRedBall.Forms.Controls.ComboBox)Visual.GetGraphicalUiElementByName("ComboBoxInstance").FormsControlAsObject;
                ToSellAmountTextBoxInstance = (FlatRedBall.Forms.Controls.TextBox)Visual.GetGraphicalUiElementByName("ToSellAmountTextBoxInstance").FormsControlAsObject;
                ResourceDisplayInstance = new JHP4SD.FormsControls.Components.LebegForms.BasicComponents.ResourceDisplayForms(Visual.GetGraphicalUiElementByName("ResourceDisplayInstance"));
                SellOneButtonInstance = (FlatRedBall.Forms.Controls.Button)Visual.GetGraphicalUiElementByName("SellOneButtonInstance").FormsControlAsObject;
                SellAllButtonInstance = (FlatRedBall.Forms.Controls.Button)Visual.GetGraphicalUiElementByName("SellAllButtonInstance").FormsControlAsObject;
                AutoSellAmountTextBoxInstance = (FlatRedBall.Forms.Controls.TextBox)Visual.GetGraphicalUiElementByName("AutoSellAmountTextBoxInstance").FormsControlAsObject;
                AutoSellButtonInstance = (FlatRedBall.Forms.Controls.Button)Visual.GetGraphicalUiElementByName("AutoSellButtonInstance").FormsControlAsObject;
            }
            partial void CustomInitialize();
        }
    }
