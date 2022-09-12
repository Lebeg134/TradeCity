using System;
using TradeCity.Engine.Resources;
using TradeCity.Engine.Session;
using TradeCity.Engine.TimeManager;
using TradeCity.Units.Resources.Common;

namespace TradeCity.Engine.Market
{
    [Serializable]
    public class SpListing : ITickable
    {
        public int Above;

        public SpListing(Resource sellable, int sellAbove)
        {
            Sell = sellable;
            Above = sellAbove;
        }

        public Resource Sell
        {
            get => (Resource)Sellable;
            set
            {
                if (value is ISellable sellable)
                    Sellable = sellable;
                else
                    throw new Exception("Resource not sellable");
            }
        }

        public ISellable Sellable { get; private set; }

        public void Tick()
        {
            Complete();
        }

        public void Register()
        {
            Clock.Instance.Register(this);
        }

        public void Complete(bool throws = false)
        {
            if (Player.CurrentPlayer.GetResCount(Sell) > Above && Player.CurrentPlayer.HasResource(Sell))
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

        public void CompleteAll()
        {
            while (Player.CurrentPlayer.GetResCount(Sell) > Above && Player.CurrentPlayer.HasResource(Sell))
                try
                {
                    Complete();
                }
                catch (Exception)
                {
                    break;
                }
        }

        public int GetValue()
        {
            return (int)Math.Floor(Sellable.GetStock() * Sellable.GetValue());
        }
    }
}