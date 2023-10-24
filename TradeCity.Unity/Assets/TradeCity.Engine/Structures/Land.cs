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
    public abstract class Land : CommonStructure, ILand
    {
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

        public abstract int GetStartingPrice();

        public bool IsAuctionable()
        {
            return _owner == null;
        }

        public virtual Resource GetUpgradeCost()
        {
            return GetUpgradeCost(_level);
        }

        protected override int GetMaxLevel()
        {
            //Infinite Upgrade
            return -1;
        }

        public override Branches GetBranch()
        {
            return Branches.Common;
        }

        protected abstract List<Resource> GetProduce(int level);

        protected override string GetBasePath()
        {
            return base.GetBasePath() + "Land/";
        }

        protected abstract Resource GetUpgradeCost(int level);
    }
}