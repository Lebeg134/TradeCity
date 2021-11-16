    namespace JHP4SD.FormsControls.Screens
    {
        public partial class SettingsGumForms
        {
            private Gum.Wireframe.GraphicalUiElement Visual;
            public FlatRedBall.Forms.Controls.Button BackButtonInstance { get; set; }
            public FlatRedBall.Forms.Controls.ComboBox MyComboBoxInstance { get; set; }
            public SettingsGumForms () 
            {
                CustomInitialize();
            }
            public SettingsGumForms (Gum.Wireframe.GraphicalUiElement visual) 
            {
                Visual = visual;
                ReactToVisualChanged();
                CustomInitialize();
            }
            private void ReactToVisualChanged () 
            {
                BackButtonInstance = (FlatRedBall.Forms.Controls.Button)Visual.GetGraphicalUiElementByName("BackButtonInstance").FormsControlAsObject;
                MyComboBoxInstance = (FlatRedBall.Forms.Controls.ComboBox)Visual.GetGraphicalUiElementByName("MyComboBoxInstance").FormsControlAsObject;
            }
            partial void CustomInitialize();
        }
    }
