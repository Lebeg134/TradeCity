using JHP4SD.Lebeg134.Module.MarketNS;
using JHP4SD.Lebeg134.Module.Resources;
using JHP4SD.Lebeg134.Module.Session;
using JHP4SD.Lebeg134.Module.TimeManager;
using JHP4SD.Lebeg134.Units.Resources.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JHP4SD.Lebeg134.Module.Market
{
    public class SPListing: ITickable
    {
        public Resource Sell
        {
            get => (Resource)sell; 
            set
            {
                if (value is ISellable)
                    sell = (ISellable)value;
                else
                    throw new Exception("Resource not sellable");
            }
        }
        public ISellable sellable { get => sell; }
        ISellable sell;
        public int above;
        public SPListing(Resource sellable, int sellAbove)
        {
            Sell = sellable;
            above = sellAbove;
        }
        public void tick()
        {
            Player player = Player.CurrentPlayer;
            if (player.getRes(Sell) > above && player.hasResource(Sell))
            {
                player.subRes(Sell);
                player.giveRes(new Money(getValue()));
            }
        }
        public int getValue()
        {
            return (int)Math.Floor(sell.amount() * sell.getValue());
        }
        public void register()
        {
            Clock.Instance.Register(this);
        }
    }
}
