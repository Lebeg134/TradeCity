using System;
using System.Collections.Generic;
using System.Linq;

namespace JHP4SD.GumRuntimes.LebegForms.BasicComponents
{
    public partial class ResourceDisplayRuntime
    {
        public int Amount
        { 
            set
            {
                LabelInstance.TextInstance.Text = "" + value;
                if (value > _amount)
                {
                    ChangeIndicatorDown.Visible = false;
                    ChangeIndicatorUp.Visible = true;
                }
                else if(value < _amount)
                {
                    ChangeIndicatorDown.Visible = true;
                    ChangeIndicatorUp.Visible = false;
                }
                else
                {
                    ChangeIndicatorDown.Visible = false;
                    ChangeIndicatorUp.Visible = false;
                }
                _amount = value;
            } 
        }
        int _amount = 0;
        partial void CustomInitialize () 
        {

        }
    }
}
