using System;
using System.Collections.Generic;
using System.Linq;
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

            if (!by.CheckResources(GetCost(0))) throw new Resource.NotEnoughResourceException();

            by.SubRes(GetCost(0));
            by.GiveStructure(this);
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

        public virtual Resource GetStartingCost()
        {
            return GetCost(0).FirstOrDefault();
        }

        public bool IsAuctionable()
        {
            return _owner == null;
        }

        public virtual Resource GetUpgradeCost()
        {
            return GetCost(_level).FirstOrDefault();
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
    }
}