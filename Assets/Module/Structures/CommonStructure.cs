using Assets.Module.Production;
using Lebeg134.Module.Resources;
using Lebeg134.Module.Session;
using Lebeg134.Module.Structures;
using Lebeg134.Units;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lebeg134.Module.Structures
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
        public void Acquire(Player by)
        {
            //Possibility to transfer ownership?, can implement later if needed
            owner = by;
        }
        public void Upgrade()
        {
            if (CanUpgrade())
            {
                owner.SubRes(GetCost(Level));
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
        protected abstract List<IOwnable> GetCriteria(int level);
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
