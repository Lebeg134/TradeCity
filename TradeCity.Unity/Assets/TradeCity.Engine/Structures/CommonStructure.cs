using System;
using System.Collections.Generic;
using AutSoft.UnitySupplements.EventBus;
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

        public virtual void Upgrade()
        {
            if (!CanUpgrade()) return;
            _owner.SubRes(GetCost(Level));
            _level++;
            _eventBus.Invoke(new StructureUpgraded(this));
            if (_level >= MaxLevel)
                _eventBus.Invoke(new StructureMaxLevelReached(this));
        }

        public bool CanUpgrade()
        {
            if (MaxLevel == -1) 
                return CheckCriteria(_owner, _level);
            return _level < MaxLevel && CheckCriteria(_owner, _level);
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

        public class StructureUpgraded : IEvent
        {
            public StructureUpgraded(CommonStructure subject)
            {
                Subject = subject;
            }
            public CommonStructure Subject { get; }
        }

        public class StructureMaxLevelReached : IEvent
        {
            public StructureMaxLevelReached(CommonStructure subject)
            {
                Subject = subject;
            }
            public CommonStructure Subject { get; }
        }
    }
}