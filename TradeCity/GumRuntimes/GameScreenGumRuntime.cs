using JHP4SD.Lebeg134.Module.Graphics;
using JHP4SD.Lebeg134.Module.Resources;
using JHP4SD.Lebeg134.Module.Session;
using JHP4SD.Lebeg134.Module.TimeManager;
using JHP4SD.Lebeg134.Units.Resources.Common;
using Lebeg134.Resources.Common;
using Lebeg134.Resources.EnergySector;
using Lebeg134.Resources.Workforce;
using System;
using System.Collections.Generic;
using System.Linq;

namespace JHP4SD.GumRuntimes
{
    public partial class GameScreenGumRuntime : ITickable, IUpdateable
    {
        partial void CustomInitialize () 
        {
            Resource.spriteLibrary = new LebegForms.Resources.ResourceIconsRuntime();
            register();
            Player player = Player.CurrentPlayer;
            MoneyDisplay.Focus = player.getResRef(new Money(0));
            WorkforceDisplay.Focus = player.getResRef(new Workforce(0));
            ElectricityDisplay.Focus = player.getResRef(new Electricity(0));
            WoodDisplay.Focus = player.getResRef(new Wood(0));
            IronDisplay.Focus = player.getResRef(new Iron(0));
            SteelDisplay.Focus = player.getResRef(new Steel(0));
            WaterDisplay.Focus = player.getResRef(new Water(0));
            CoalDisplay.Focus = player.getResRef(new Coal(0));
            Resource.updater.Register(this);
            Update();
        }

        public void tick()
        {
            Update();
        }

        public void register()
        {
            Clock.Instance.Register(this);
        }

        public void Update()
        {
            MoneyDisplay.Update();
            WorkforceDisplay.Update();
            ElectricityDisplay.Update();
            WoodDisplay.Update();
            IronDisplay.Update();
            SteelDisplay.Update();
            WaterDisplay.Update();
            CoalDisplay.Update();
        }
        public new void Destroy() //Does this even get called? (nope)
        {
            Clock.Instance.unRegister(this);
            Resource.updater.UnRegister(this);
        }
    }
}
