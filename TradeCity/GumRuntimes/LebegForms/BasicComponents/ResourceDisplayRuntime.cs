using JHP4SD.Lebeg134.Module.Graphics;
using JHP4SD.Lebeg134.Module.Resources;
using System;
using System.Collections.Generic;
using System.Linq;

namespace JHP4SD.GumRuntimes.LebegForms.BasicComponents
{
    public partial class ResourceDisplayRuntime : IUpdateable
    {
        public Resource Focus
        {
            set
            {
                _focus = value;
                initTexture();
                Update();
            }
        }
        Resource _focus;
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
                else if (value < _amount)
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
        partial void CustomInitialize()
        {
            if (_focus != null)
            {
                initTexture();
            }
        }
        void initTexture()
        {
            SpriteInstance.Texture = _focus.getSprite().Texture;
        }
        public void Update()
        {
            Amount = _focus.amount();
        }
    }
}
