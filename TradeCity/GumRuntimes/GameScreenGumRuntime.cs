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
    public partial class GameScreenGumRuntime : ITickable
    {
        partial void CustomInitialize () 
        {
            register();
            updateResourceDisplays();
        }
        void updateResourceDisplays()
        {
            Player player = Player.CurrentPlayer;
            MoneyDisplay.Amount = player.getRes(new Money(0));
            WorkforceDisplay.Amount = player.getRes(new Workforce(0));
            ElectricityDisplay.Amount = player.getRes(new Electricity(0));
            WoodDisplay.Amount = player.getRes(new Wood(0));
            IronDisplay.Amount = player.getRes(new Iron(0));
            SteelDisplay.Amount = player.getRes(new Steel(0));
            WaterDisplay.Amount = player.getRes(new Water(0));
            CoalDisplay.Amount = player.getRes(new Coal(0));
        }
        public void tick()
        {
            updateResourceDisplays();
        }

        public void register()
        {
            Clock.Instance.Register(this);
        }
        public new void Destroy() //Does this even get called? (nope)
        {
            Clock.Instance.unRegister(this);
        }
       }
}
