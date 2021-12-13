using JHP4SD.Lebeg134.Module.Resources;
using JHP4SD.Lebeg134.Module.Session;
using System;
using System.Collections.Generic;
using System.Linq;

namespace JHP4SD.GumRuntimes.LebegForms.BasicComponents
{
    public partial class ResourceListItemRuntime
    {
        public Resource Focus { get; set; }
        partial void CustomInitialize () 
        {
            if (Focus != null)
                Init();
        }
        public void Init()
        {
            ResourceText.Text = Focus.getName();
            ResourceDisplayInstance.SpriteInstance.Texture = Focus.getIcon();
            Update();
        }
        public void Update()
        {
            ResourceDisplayInstance.Amount = Player.CurrentPlayer.getRes(Focus);
        }
        
    }
}
