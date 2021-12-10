using JHP4SD.Lebeg134.Module.Structures;
using System;
using System.Collections.Generic;
using System.Linq;

namespace JHP4SD.FormsControls.Components.LebegForms.ComplexComponents
{
    public partial class TabMenuForms
    {
        partial void CustomInitialize () 
        {
        }
        public void RegisterBuilding(Building building)
        {
            // TODO building category enum and register to specific List

            var visual1 = new GumRuntimes.DefaultForms.BuildingListItemRuntime();
            var listBoxItem1 = visual1.FormsControl;
            listBoxItem1.UpdateToObject(building.ToString());
            CommonList.Items.Add(listBoxItem1);



            CommonList.Items.Add("Test");
        }
    }
}
