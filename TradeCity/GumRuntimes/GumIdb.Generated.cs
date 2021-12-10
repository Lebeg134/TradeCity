    namespace FlatRedBall.Gum
    {
        public  class GumIdbExtensions
        {
            public static void RegisterTypes () 
            {
                GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("Circle", typeof(JHP4SD.GumRuntimes.CircleRuntime));
                GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("ColoredRectangle", typeof(JHP4SD.GumRuntimes.ColoredRectangleRuntime));
                GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("Container", typeof(JHP4SD.GumRuntimes.ContainerRuntime));
                GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("Container<T>", typeof(JHP4SD.GumRuntimes.ContainerRuntime<>));
                GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("NineSlice", typeof(JHP4SD.GumRuntimes.NineSliceRuntime));
                GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("Polygon", typeof(JHP4SD.GumRuntimes.PolygonRuntime));
                GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("Rectangle", typeof(JHP4SD.GumRuntimes.RectangleRuntime));
                GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("Sprite", typeof(JHP4SD.GumRuntimes.SpriteRuntime));
                GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("Text", typeof(JHP4SD.GumRuntimes.TextRuntime));
                GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("DefaultForms/Button", typeof(JHP4SD.GumRuntimes.DefaultForms.ButtonRuntime));
                GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("DefaultForms/CheckBox", typeof(JHP4SD.GumRuntimes.DefaultForms.CheckBoxRuntime));
                GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("DefaultForms/ColoredFrame", typeof(JHP4SD.GumRuntimes.DefaultForms.ColoredFrameRuntime));
                GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("DefaultForms/ComboBox", typeof(JHP4SD.GumRuntimes.DefaultForms.ComboBoxRuntime));
                GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("DefaultForms/DialogBox", typeof(JHP4SD.GumRuntimes.DefaultForms.DialogBoxRuntime));
                GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("DefaultForms/Keyboard", typeof(JHP4SD.GumRuntimes.DefaultForms.KeyboardRuntime));
                GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("DefaultForms/KeyboardKey", typeof(JHP4SD.GumRuntimes.DefaultForms.KeyboardKeyRuntime));
                GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("DefaultForms/Label", typeof(JHP4SD.GumRuntimes.DefaultForms.LabelRuntime));
                GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("DefaultForms/ListBox", typeof(JHP4SD.GumRuntimes.DefaultForms.ListBoxRuntime));
                GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("DefaultForms/ListBoxItem", typeof(JHP4SD.GumRuntimes.DefaultForms.ListBoxItemRuntime));
                GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("DefaultForms/PasswordBox", typeof(JHP4SD.GumRuntimes.DefaultForms.PasswordBoxRuntime));
                GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("DefaultForms/RadioButton", typeof(JHP4SD.GumRuntimes.DefaultForms.RadioButtonRuntime));
                GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("DefaultForms/ScrollBar", typeof(JHP4SD.GumRuntimes.DefaultForms.ScrollBarRuntime));
                GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("DefaultForms/ScrollBarThumb", typeof(JHP4SD.GumRuntimes.DefaultForms.ScrollBarThumbRuntime));
                GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("DefaultForms/ScrollViewer", typeof(JHP4SD.GumRuntimes.DefaultForms.ScrollViewerRuntime));
                GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("DefaultForms/Slider", typeof(JHP4SD.GumRuntimes.DefaultForms.SliderRuntime));
                GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("DefaultForms/TextBox", typeof(JHP4SD.GumRuntimes.DefaultForms.TextBoxRuntime));
                GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("DefaultForms/Toast", typeof(JHP4SD.GumRuntimes.DefaultForms.ToastRuntime));
                GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("DefaultForms/ToggleButton", typeof(JHP4SD.GumRuntimes.DefaultForms.ToggleButtonRuntime));
                GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("DefaultForms/TreeView", typeof(JHP4SD.GumRuntimes.DefaultForms.TreeViewRuntime));
                GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("DefaultForms/TreeViewItem", typeof(JHP4SD.GumRuntimes.DefaultForms.TreeViewItemRuntime));
                GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("DefaultForms/TreeViewToggleButton", typeof(JHP4SD.GumRuntimes.DefaultForms.TreeViewToggleButtonRuntime));
                GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("DefaultForms/UserControl", typeof(JHP4SD.GumRuntimes.DefaultForms.UserControlRuntime));
                GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("LebegForms/BasicComponents/BackButton", typeof(JHP4SD.GumRuntimes.LebegForms.BasicComponents.BackButtonRuntime));
                GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("LebegForms/BasicComponents/CityMenuTab", typeof(JHP4SD.GumRuntimes.LebegForms.BasicComponents.CityMenuTabRuntime));
                GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("LebegForms/BasicComponents/ExitButton", typeof(JHP4SD.GumRuntimes.LebegForms.BasicComponents.ExitButtonRuntime));
                GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("LebegForms/BasicComponents/MainMenuButton", typeof(JHP4SD.GumRuntimes.LebegForms.BasicComponents.MainMenuButtonRuntime));
                GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("LebegForms/BasicComponents/PlayButton", typeof(JHP4SD.GumRuntimes.LebegForms.BasicComponents.PlayButtonRuntime));
                GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("LebegForms/BasicComponents/ResourceDisplay", typeof(JHP4SD.GumRuntimes.LebegForms.BasicComponents.ResourceDisplayRuntime));
                GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("LebegForms/BasicComponents/TabButton", typeof(JHP4SD.GumRuntimes.LebegForms.BasicComponents.TabButtonRuntime));
                GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("LebegForms/ComplexComponents/ScreenSelector", typeof(JHP4SD.GumRuntimes.LebegForms.ComplexComponents.ScreenSelectorRuntime));
                GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("LebegForms/ComplexComponents/TabMenu", typeof(JHP4SD.GumRuntimes.LebegForms.ComplexComponents.TabMenuRuntime));
                GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("LebegForms/ComplexComponents/Topic", typeof(JHP4SD.GumRuntimes.LebegForms.ComplexComponents.TopicRuntime));
                GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("CityGum", typeof(JHP4SD.GumRuntimes.CityGumRuntime));
                GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("GameScreenGum", typeof(JHP4SD.GumRuntimes.GameScreenGumRuntime));
                GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("MainMenuGum", typeof(JHP4SD.GumRuntimes.MainMenuGumRuntime));
                GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("MapGum", typeof(JHP4SD.GumRuntimes.MapGumRuntime));
                GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("MarketGum", typeof(JHP4SD.GumRuntimes.MarketGumRuntime));
                GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("MultiplayerGum", typeof(JHP4SD.GumRuntimes.MultiplayerGumRuntime));
                GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("SettingsGum", typeof(JHP4SD.GumRuntimes.SettingsGumRuntime));
                
                FlatRedBall.Forms.Controls.FrameworkElement.DefaultFormsComponents[typeof(FlatRedBall.Forms.Controls.Button)] = typeof(JHP4SD.GumRuntimes.DefaultForms.ButtonRuntime);
                FlatRedBall.Forms.Controls.FrameworkElement.DefaultFormsComponents[typeof(FlatRedBall.Forms.Controls.CheckBox)] = typeof(JHP4SD.GumRuntimes.DefaultForms.CheckBoxRuntime);
                FlatRedBall.Forms.Controls.FrameworkElement.DefaultFormsComponents[typeof(FlatRedBall.Forms.Controls.ComboBox)] = typeof(JHP4SD.GumRuntimes.DefaultForms.ComboBoxRuntime);
                FlatRedBall.Forms.Controls.FrameworkElement.DefaultFormsComponents[typeof(FlatRedBall.Forms.Controls.Games.DialogBox)] = typeof(JHP4SD.GumRuntimes.DefaultForms.DialogBoxRuntime);
                FlatRedBall.Forms.Controls.FrameworkElement.DefaultFormsComponents[typeof(FlatRedBall.Forms.Controls.Games.OnScreenKeyboard)] = typeof(JHP4SD.GumRuntimes.DefaultForms.KeyboardRuntime);
                FlatRedBall.Forms.Controls.FrameworkElement.DefaultFormsComponents[typeof(FlatRedBall.Forms.Controls.Label)] = typeof(JHP4SD.GumRuntimes.DefaultForms.LabelRuntime);
                FlatRedBall.Forms.Controls.FrameworkElement.DefaultFormsComponents[typeof(FlatRedBall.Forms.Controls.ListBox)] = typeof(JHP4SD.GumRuntimes.DefaultForms.ListBoxRuntime);
                FlatRedBall.Forms.Controls.FrameworkElement.DefaultFormsComponents[typeof(FlatRedBall.Forms.Controls.ListBoxItem)] = typeof(JHP4SD.GumRuntimes.DefaultForms.ListBoxItemRuntime);
                FlatRedBall.Forms.Controls.FrameworkElement.DefaultFormsComponents[typeof(FlatRedBall.Forms.Controls.PasswordBox)] = typeof(JHP4SD.GumRuntimes.DefaultForms.PasswordBoxRuntime);
                FlatRedBall.Forms.Controls.FrameworkElement.DefaultFormsComponents[typeof(FlatRedBall.Forms.Controls.RadioButton)] = typeof(JHP4SD.GumRuntimes.DefaultForms.RadioButtonRuntime);
                FlatRedBall.Forms.Controls.FrameworkElement.DefaultFormsComponents[typeof(FlatRedBall.Forms.Controls.ScrollBar)] = typeof(JHP4SD.GumRuntimes.DefaultForms.ScrollBarRuntime);
                FlatRedBall.Forms.Controls.FrameworkElement.DefaultFormsComponents[typeof(FlatRedBall.Forms.Controls.ScrollViewer)] = typeof(JHP4SD.GumRuntimes.DefaultForms.ScrollViewerRuntime);
                FlatRedBall.Forms.Controls.FrameworkElement.DefaultFormsComponents[typeof(FlatRedBall.Forms.Controls.Slider)] = typeof(JHP4SD.GumRuntimes.DefaultForms.SliderRuntime);
                FlatRedBall.Forms.Controls.FrameworkElement.DefaultFormsComponents[typeof(FlatRedBall.Forms.Controls.TextBox)] = typeof(JHP4SD.GumRuntimes.DefaultForms.TextBoxRuntime);
                FlatRedBall.Forms.Controls.FrameworkElement.DefaultFormsComponents[typeof(FlatRedBall.Forms.Controls.Popups.Toast)] = typeof(JHP4SD.GumRuntimes.DefaultForms.ToastRuntime);
                FlatRedBall.Forms.Controls.FrameworkElement.DefaultFormsComponents[typeof(FlatRedBall.Forms.Controls.ToggleButton)] = typeof(JHP4SD.GumRuntimes.DefaultForms.ToggleButtonRuntime);
                FlatRedBall.Forms.Controls.FrameworkElement.DefaultFormsComponents[typeof(FlatRedBall.Forms.Controls.TreeView)] = typeof(JHP4SD.GumRuntimes.DefaultForms.TreeViewRuntime);
                FlatRedBall.Forms.Controls.FrameworkElement.DefaultFormsComponents[typeof(FlatRedBall.Forms.Controls.TreeViewItem)] = typeof(JHP4SD.GumRuntimes.DefaultForms.TreeViewItemRuntime);
                FlatRedBall.Forms.Controls.FrameworkElement.DefaultFormsComponents[typeof(FlatRedBall.Forms.Controls.UserControl)] = typeof(JHP4SD.GumRuntimes.DefaultForms.UserControlRuntime);
                FlatRedBall.Forms.Controls.FrameworkElement.DefaultFormsComponents[typeof(JHP4SD.FormsControls.Components.LebegForms.BasicComponents.ResourceDisplayForms)] = typeof(JHP4SD.GumRuntimes.LebegForms.BasicComponents.ResourceDisplayRuntime);
                FlatRedBall.Forms.Controls.FrameworkElement.DefaultFormsComponents[typeof(JHP4SD.FormsControls.Components.LebegForms.ComplexComponents.ScreenSelectorForms)] = typeof(JHP4SD.GumRuntimes.LebegForms.ComplexComponents.ScreenSelectorRuntime);
                FlatRedBall.Forms.Controls.FrameworkElement.DefaultFormsComponents[typeof(JHP4SD.FormsControls.Components.LebegForms.ComplexComponents.TabMenuForms)] = typeof(JHP4SD.GumRuntimes.LebegForms.ComplexComponents.TabMenuRuntime);
            }
        }
    }
