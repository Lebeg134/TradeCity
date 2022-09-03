using System;
using System.Collections.Generic;
using TradeCity.Engine.Resources;
using TradeCity.Engine.Session;
using TradeCity.Engine.Structures.Interfaces;

namespace TradeCity.Engine.Structures
{
    public abstract class CommonStructure : Structure, IOwnable, IUpgradeable
    {
        // ========== Public events
        public event Action<Structure> OnUpgrade;
        public event Action<Structure> OnMaxLevelReached;

        // ========== Attributes
        protected Player owner;
        protected int level = 0;

        // ========== Properties
        public Player Owner => owner;
        public int Level => level;
        public int MaxLevel => GetMaxLevel();

        // ========== Interface Implementations
        public virtual void Acquire(Player by)
        {
            //Possibility to transfer ownership?, can implement later if needed
            owner = by;
        }
        public virtual void Upgrade()
        {
            if (CanUpgrade())
            {
                owner.SubRes(GetCost(Level));
                level++;
                OnUpgrade?.Invoke(this);
                if (level >= MaxLevel)
                    OnMaxLevelReached?.Invoke(this);
            }
        }
        public bool CanUpgrade()
        {
            if (level >= MaxLevel) return false;
            return CheckCriteria(owner, level);
        }
        // ========== Internal Methods
        protected abstract int GetMaxLevel();
        protected abstract List<Resource> GetCost(int level);
        protected virtual List<IOwnable> GetCriteria(int level)
        {
            return new List<IOwnable>();
        }
        protected virtual bool CheckCriteria(Player by, int level = 0)
        {
            return by.CheckResources(GetCost(level)) && by.CheckStructures(GetCriteria(level));
        }
        protected void InvokeOnMaxLevelReached()
        {
            OnMaxLevelReached?.Invoke(this);
        }
    }
}
