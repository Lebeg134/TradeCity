using JHP4SD.Lebeg134.Module.Graphics;
using JHP4SD.Lebeg134.Module.Resources;
using JHP4SD.Lebeg134.Module.Session;
using JHP4SD.Lebeg134.Module.TimeManager;
using System;
using System.Collections.Generic;
using System.Linq;

namespace JHP4SD.GumRuntimes.LebegForms.BasicComponents
{
    public partial class ResourceListItemSmallRuntime
    {
        public Resource Focus
        {
            set
            {
                _focus = value;
                Init();
            }
            get => _focus;
        }
        Resource _focus;
        partial void CustomInitialize()
        {
            if (_focus != null)
                Init();
        }
        public void Init()
        {
            TextInstance.Text = _focus.getName();
            SpriteInstance.Texture = _focus.getSprite().Texture;
        }
    }
}
