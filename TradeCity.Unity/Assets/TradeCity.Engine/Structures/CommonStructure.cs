using System;
using System.Collections.Generic;
using TradeCity.Engine.Resources;
using TradeCity.Engine.Session;
using TradeCity.Engine.Structures.Interfaces;

namespace TradeCity.Engine.Structures
{
    [Serializable]
    public abstract class CommonStructure : Structure, IOwnable, IUpgradeable
    {
        protected int _level;
        
        protected Player _owner;
        public int Level => _level;
        public int MaxLevel => GetMaxLevel();
        
        public Player Owner => _owner;
        
        public virtual void Acquire(Player by)
        {
            //Possibility to transfer ownership?, can implement later if needed
            _owner = by;
        }
        
        public event Action<Structure> OnUpgrade;
        public event Action<Structure> OnMaxLevelReached;

        public virtual void Upgrade()
        {
            if (CanUpgrade())
            {
                _owner.SubRes(GetCost(Level));
                _level++;
                OnUpgrade?.Invoke(this);
                if (_level >= MaxLevel)
                    OnMaxLevelReached?.Invoke(this);
            }
        }

        public bool CanUpgrade()
        {
            if (_level >= MaxLevel) return false;
            return CheckCriteria(_owner, _level);
        }
        
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