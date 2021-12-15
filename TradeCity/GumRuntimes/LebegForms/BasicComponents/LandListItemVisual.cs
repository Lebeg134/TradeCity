using JHP4SD.Lebeg134.Module.Graphics;
using JHP4SD.Lebeg134.Module.Resources;
using JHP4SD.Lebeg134.Module.Structures;
using JHP4SD.Lebeg134.Module.TimeManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JHP4SD.GumRuntimes.LebegForms.BasicComponents
{
    class LandListItemVisual: IUpdateable, ITickable
    {
        public Land Focus
        {
            get
            {
                return _focus;
            }
            set
            {
                _focus = value;
            }
        }
        Land _focus;
        public void Init(TextRuntime landNameDisplay, SpriteRuntime LandImage, ResourceDisplayRuntime resourceDisplayer, Resource resource)
        {
            if (_focus == null) return;
            landNameDisplay.Text = _focus.getName();
            //LandImage.Texture = _focus.getSprite().Texture;
            resourceDisplayer.Focus = resource;
            resourceDisplayer.Update(); //make change arrow dissapear
            Update();
        }
        public virtual void Update()
        {
            // We don't need to update anything actually
        }

        public void tick()
        {
            Update();
        }

        public void register()
        {
            Clock.Instance.Register(this);
        }
    }
}
