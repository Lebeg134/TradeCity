/**
* @(#) Land.cs
*/
using Lebeg134.Module.MapNS;
using Lebeg134.Module.Resources;
using Lebeg134.Module.Session;
using Lebeg134.Module.TimeManager;
using Lebeg134.Resources.Common;
using Lebeg134.Units;
using System;
using System.Collections.Generic;

namespace Lebeg134.Module.Structures
{
    [Serializable]
    public abstract class Land : CommonStructure, ILand, IMapStructure
    {
        private const int defaultMaxLevel = 100;
        // ========== Public events
        public event Action<Land> OnPurchase;

        // ========== Interface Implementations
        public void GetPosition()
        {
            throw new NotImplementedException();
        }
        public List<Resource> GetProduce()
        {
            return GetProduce(level);
        }
        public bool IsAuctionable()
        {
            return owner == null;
        }
        public void Purchase(Player by)
        {
            Acquire(by);
            OnPurchase?.Invoke(this);
            Register();
        }
        public void Register()
        {
            Clock.Instance.Register(this);
        }
        public void Tick()
        {
            owner?.GiveRes(GetProduce());
        }
        public abstract Land GetNew();
        //public abstract List<Resource> GetStartingCost();
        public List<Resource> GetStartingCost()
        {
            //TODO!!
            throw new NotImplementedException();
        }
        public int GetStartingPrice()
        {
            //TODO replace!!
            return 100;
        }

        // ========== Abstract method implementations
        protected override int GetMaxLevel()
        {
            return defaultMaxLevel;
        }
        public override Branches GetBranch()
        {
            //TODO replace!!
            throw new NotImplementedException();
        }

        // ========== Internal Methods
        protected abstract List<Resource> GetProduce(int level);
        override protected string GetBasePath()
        {
            return base.GetBasePath() + "Land/";
        }

        
    }
}
