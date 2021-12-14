using JHP4SD.Lebeg134.Module.Resources;
using JHP4SD.Lebeg134.Module.Session;
using System;
using System.Collections.Generic;
using System.Linq;

namespace JHP4SD.GumRuntimes.LebegForms.BasicComponents
{
    public partial class ResourceListItemRuntime
    {
        public Resource Focus
        {
            set
            {
                _focus = value;
                Init();
            }
        }
        Resource _focus;
        partial void CustomInitialize()
        {
            if (_focus != null)
                Init();
        }
        public void Init()
        {
            ResourceText.Text = _focus.getName();

            ResourceDisplayInstance.SpriteInstance = _focus.getSprite();
            Update();
        }
        public void Update()
        {
            ResourceDisplayInstance.Amount = Player.CurrentPlayer.getRes(_focus);
        }

    }
}
