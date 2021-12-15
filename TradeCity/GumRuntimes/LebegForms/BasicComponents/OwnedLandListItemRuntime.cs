using JHP4SD.GumRuntimes.LebegForms.BasicComponents;
using JHP4SD.Lebeg134.Module.Graphics;
using JHP4SD.Lebeg134.Module.Structures;
using JHP4SD.Lebeg134.Module.TimeManager;
using System;
using System.Collections.Generic;
using System.Linq;

namespace JHP4SD.GumRuntimes.LebegForms.BasicComponents
{
    public partial class OwnedLandListItemRuntime
    {
        LandListItemVisual visual = new LandListItemVisual();
        public Land Focus { set { visual.Focus = value; } }

        partial void CustomInitialize () 
        {
            Init();
        }
        public void Init()
        {
            if (visual.Focus == null) return;
            visual.Init(TextInstance, SpriteInstance, ResourceDisplayInstance, visual.Focus.getProduce().First());
        }
    }
}
