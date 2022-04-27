using Lebeg134.Module.MarketNS;
using Lebeg134.Module.Resources;
using Lebeg134.Module.Session;
using Lebeg134.Module.TimeManager;
using Lebeg134.Resources.Common;
using System;

namespace Lebeg134.Module.Market
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
        public ISellable Sellable { get => sell; }
        ISellable sell;
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
            return (int)Math.Floor(sell.Amount() * sell.GetValue());
        }
        public void Register()
        {
            Clock.Instance.Register(this);
        }
    }
}
