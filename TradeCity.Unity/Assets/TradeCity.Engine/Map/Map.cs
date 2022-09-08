using System;
using System.Collections.Generic;
using TradeCity.Engine.Session;
using TradeCity.Engine.Structures;
using TradeCity.Engine.TimeManager;

namespace TradeCity.Engine.Map
{
    [Serializable]
    public class Map : ITickable
    {
        private readonly int _defaultBid = 100;
        private readonly int _defaultTimePerRound = 100;
        private readonly List<Auction> _liveAuctions = new();
        private readonly int _sizeX, _sizeY;
        private readonly IMapStructure[,] _structures;

        public Map(int sizeX, int sizeY)
        {
            _sizeX = sizeX;
            _sizeY = sizeY;
            _structures = new IMapStructure[_sizeX, _sizeY];
            Register();
        }

        public void Tick()
        {
            foreach (var auction in _liveAuctions) auction.Tick();
        }

        public void Register()
        {
            Clock.Instance.Register(this);
        }

        public IMapStructure GetStructure(int x, int y)
        {
            return _structures[x, y];
        }

        public void StartAuction(int x, int y, Player by)
        {
            var subject = _structures[x, y];
            if (!subject.IsAuctionable())
                throw new InvalidOperationException();

            Auction newAuction = new((Land)subject, _defaultBid, _defaultTimePerRound, by);
            if (_liveAuctions.Contains(newAuction)) throw new InvalidOperationException();

            newAuction.OnFinish += OnAuctionFinished;
            _liveAuctions.Add(newAuction);
        }

        private void OnAuctionFinished(Auction auction)
        {
            auction.OnFinish -= OnAuctionFinished;
            _liveAuctions.Remove(auction);
        }
    }
}