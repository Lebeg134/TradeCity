using JHP4SD.Lebeg134.Module.Graphics;
using JHP4SD.Lebeg134.Module.Resources;
using JHP4SD.Lebeg134.Module.Session;
using JHP4SD.Lebeg134.Module.TimeManager;
using System;
using System.Collections.Generic;
using System.Linq;

namespace JHP4SD.GumRuntimes.LebegForms.BasicComponents
{
    public partial class ResourceListItemRuntime: ITickable, IUpdateable
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
            ResourceDisplayInstance.Focus = _focus;
            Update();
            register();
            ResourceDisplayInstance.Update();
        }
        public void Update()
        {
            ResourceDisplayInstance.Update();
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
