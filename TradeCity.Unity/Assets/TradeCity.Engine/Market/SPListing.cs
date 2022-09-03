using System;
using TradeCity.Engine.Resources;
using TradeCity.Engine.Session;
using TradeCity.Engine.TimeManager;
using TradeCity.Units.Resources.Common;

namespace TradeCity.Engine.Market
{
    [Serializable]
    public class SPListing : ITickable
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
        public ISellable Sellable => sell;

        private ISellable sell;
        public int above;
        public SPListing(Resource sellable, int sellAbove)
        {
            Sell = sellable;
            above = sellAbove;
        }
        public void Tick()
        {
            Complete();
        }
        public void Complete(bool throws = false)
        {
            if (Player.CurrentPlayer.GetRes(Sell) > above && Player.CurrentPlayer.HasResource(Sell))
            {
                try
                {
                    Player.CurrentPlayer.SubRes(Sell);
                    Player.CurrentPlayer.GiveRes(new Money(GetValue()));
                }
                catch (Exception)
                {
                    if (throws) throw;
                }

            }
        }
        public void CompleteAll()
        {
            while (Player.CurrentPlayer.GetRes(Sell) > above && Player.CurrentPlayer.HasResource(Sell))
            {
                try
                {
                    Complete();
                }
                catch (Exception)
                {

                    break;
                }
            }
        }
        public int GetValue()
        {
            return (int)Math.Floor(sell.GetStock() * sell.GetValue());
        }
        public void Register()
        {
            Clock.Instance.Register(this);
        }
    }
}
