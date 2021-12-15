using JHP4SD.Lebeg134.Module.Graphics;
using JHP4SD.Lebeg134.Module.Resources;
using JHP4SD.Lebeg134.Module.Session;
using JHP4SD.Lebeg134.Module.Structures;
using JHP4SD.Lebeg134.Module.TimeManager;
using JHP4SD.Lebeg134.Units.Resources.Common;
using System;
using System.Collections.Generic;
using System.Linq;

namespace JHP4SD.GumRuntimes.LebegForms.BasicComponents
{
    public partial class LandListItemRuntime : IUpdateable, ITickable
    {
        LandListItemVisual visual = new LandListItemVisual();
        public int Price { set => price = value; }
        private int price;

        public Land Focus { set { visual.Focus = value; } }

        public void register()
        {
            Clock.Instance.Register(this);
        }

        public void tick()
        {
            Update();
        }

        public void Update()
        {
            visual.Update();
            UpdateButtonVisual();
        }
        public void UpdateButtonVisual()
        {
            if (Player.CurrentPlayer.checkResource(new Money(price)))
            {
                ButtonInstance.Enabled = true;
                ResourceDisplayInstance.SpriteInstance.Green = 255;
                ResourceDisplayInstance.SpriteInstance.Blue = 255;
            }
            else
            {
                ButtonInstance.Enabled = false;
                ResourceDisplayInstance.SpriteInstance.Green = 0;
                ResourceDisplayInstance.SpriteInstance.Blue = 0;
            }
        }

        partial void CustomInitialize()
        {
            ButtonInstance.Click += ButtonInstance_Click;
            Init();
        }
        public void Init()
        {
            visual.Init(TextInstance, SpriteInstance, ResourceDisplayInstance, new Money(price));
            UpdateButtonVisual();
        }

        private void ButtonInstance_Click(FlatRedBall.Gui.IWindow window)
        {
            if (Player.CurrentPlayer.checkResource(new Money(price)))
            {
                Player.CurrentPlayer.subRes(new Money(price));
                Player.CurrentPlayer.giveStructure(visual.Focus);
                Session.Instance.offers.Remove(visual.Focus);
                Resource.updater.Update();
            }
        }
    }
}
