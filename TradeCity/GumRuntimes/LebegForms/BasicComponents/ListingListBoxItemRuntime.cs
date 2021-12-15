using JHP4SD.Lebeg134.Module.Graphics;
using JHP4SD.Lebeg134.Module.Market;
using JHP4SD.Lebeg134.Module.Resources;
using JHP4SD.Lebeg134.Module.TimeManager;
using System;
using System.Collections.Generic;
using System.Linq;

namespace JHP4SD.GumRuntimes.LebegForms.BasicComponents
{
    public partial class ListingListBoxItemRuntime : ITickable, IUpdateable
    {
        public SPListing Focus
        {
            set
            {
                _focus = value;
            }
        }
        private SPListing _focus;

        partial void CustomInitialize()
        {
            Init();
        }
        public void Init()
        {
            SellResourceDisplayInstance.Focus = _focus.Sell;
            SellResourceDisplayInstance.Update();
            AboveResourceDisplayInstance.Focus = _focus.Sell.getNewResource(_focus.above);
            AboveResourceDisplayInstance.Update();
            Update();
        }
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
            ForResourceDisplayInstance.Amount = _focus.getValue();
        }
    }
}
