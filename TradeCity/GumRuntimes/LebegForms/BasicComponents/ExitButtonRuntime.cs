using System;
using System.Collections.Generic;
using System.Linq;

namespace JHP4SD.GumRuntimes.LebegForms.BasicComponents
{
    public partial class ExitButtonRuntime
    {
        partial void CustomInitialize () 
        {
            Click += ExitButtonRuntime_Click;
        }

        private void ExitButtonRuntime_Click(FlatRedBall.Gui.IWindow window)
        {
            this.CloseWindow();
        }
    }
}
