    namespace JHP4SD.FormsControls.Screens
    {
        public partial class MainMenuGumForms
        {
            private Gum.Wireframe.GraphicalUiElement Visual;
            public FlatRedBall.Forms.Controls.Button ButtonInstance { get; set; }
            public FlatRedBall.Forms.Controls.Button ButtonInstance2 { get; set; }
            public FlatRedBall.Forms.Controls.Button ButtonInstance3 { get; set; }
            public FlatRedBall.Forms.Controls.Button ButtonInstance1 { get; set; }
            public MainMenuGumForms () 
            {
                CustomInitialize();
            }
            public MainMenuGumForms (Gum.Wireframe.GraphicalUiElement visual) 
            {
                Visual = visual;
                ReactToVisualChanged();
                CustomInitialize();
            }
            private void ReactToVisualChanged () 
            {
                ButtonInstance = (FlatRedBall.Forms.Controls.Button)Visual.GetGraphicalUiElementByName("ButtonInstance").FormsControlAsObject;
                ButtonInstance2 = (FlatRedBall.Forms.Controls.Button)Visual.GetGraphicalUiElementByName("ButtonInstance2").FormsControlAsObject;
                ButtonInstance3 = (FlatRedBall.Forms.Controls.Button)Visual.GetGraphicalUiElementByName("ButtonInstance3").FormsControlAsObject;
                ButtonInstance1 = (FlatRedBall.Forms.Controls.Button)Visual.GetGraphicalUiElementByName("ButtonInstance1").FormsControlAsObject;
            }
            partial void CustomInitialize();
        }
    }
