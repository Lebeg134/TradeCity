using System;
using System.Collections.Generic;
using TradeCity.Engine.Core;
using TradeCity.Engine.Map;
using TradeCity.Engine.Resources;
using TradeCity.Engine.Session;
using TradeCity.Engine.Structures.Interfaces;
using TradeCity.Units;

namespace TradeCity.Engine.Structures
{
    [Serializable]
    public abstract class Land : CommonStructure, ILand, IMapStructure
    {
        private const int DefaultMaxLevel = 100;

        public event Action<Land> OnPurchase;

        public override void Acquire(Player by)
        {
            base.Acquire(by);
            OnPurchase?.Invoke(this);
        }

        public List<Resource> GetProduce()
        {
            return GetProduce(_level);
        }

        public void Purchase(Player by)
        {
            Acquire(by);
        }

        public void Register()
        {
            EngineCore.RegisterTickable(this);
        }

        public void Tick()
        {
            _owner.GiveRes(GetProduce());
        }

        public abstract Land GetNew();

        //public abstract List<Resource> GetStartingCost();
        public List<Resource> GetStartingCost()
        {
            //TODO!!
            throw new NotImplementedException();
        }

        public void GetPosition()
        {
            throw new NotImplementedException();
        }

        public bool IsAuctionable()
        {
            return _owner == null;
        }

        public int GetStartingPrice()
        {
            //TODO replace!!
            return 100;
        }

        protected override int GetMaxLevel()
        {
            return DefaultMaxLevel;
        }

        public override Branches GetBranch()
        {
            //TODO replace!!
            throw new NotImplementedException();
        }

        protected abstract List<Resource> GetProduce(int level);

        protected override string GetBasePath()
        {
            return base.GetBasePath() + "Land/";
        }
    }
}