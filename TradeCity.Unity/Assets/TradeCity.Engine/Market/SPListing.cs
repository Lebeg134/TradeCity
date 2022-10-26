using Injecter;
using System;
using TradeCity.Engine.Core;
using TradeCity.Engine.Core.Interfaces;
using TradeCity.Engine.Resources;
using TradeCity.Engine.Session;
using TradeCity.Engine.TimeManager;
using TradeCity.Units.Resources.Common;

namespace TradeCity.Engine.Market
{
    [Serializable]
    public class SpListing : ITickable
    {
        [NonSerialized]
        [Inject] private readonly IPlayerService _playerService;
        public int Above;

        public SpListing(Resource sellable, int sellAbove)
        {
            _playerService = EngineCore.InjectPlayerService();
            Sell = sellable;
            Above = sellAbove;
        }

        ~SpListing()
        {
            EngineCore.RemoveTickable(this);
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
            EngineCore.RegisterTickable(this);
        }

        public void Complete(bool throws = false)
        {
            if (_playerService.CurrentPlayer.GetResCount(Sell) > Above && _playerService.CurrentPlayer.HasResource(Sell))
                try
                {
                    _playerService.CurrentPlayer.SubRes(Sell);
                    _playerService.CurrentPlayer.GiveRes(new Money(GetValue()));
                }
                catch (Exception)
                {
                    if (throws) throw;
                }
        }

        public void CompleteAll()
        {
            while (_playerService.CurrentPlayer.GetResCount(Sell) > Above && _playerService.CurrentPlayer.HasResource(Sell))
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