using System.Collections.Generic;
using TradeCity.Engine.Resources;
using TradeCity.Engine.Structures.Interfaces;

namespace TradeCity.Engine.Structures.EasyInheritance
{
    public abstract class SpecialBuilding : Building
    {
        protected override List<Resource> GetCost(int level)
        {
            return GetCost();
        }

        protected override List<IOwnable> GetCriteria(int level)
        {
            return GetCriteria();
        }

        protected override int GetMaxLevel()
        {
            return 1;
        }

        protected override List<Resource> GetUpkeep(int level)
        {
            return GetUpkeep();
        }

        public abstract override List<Resource> GetCost();
        public abstract override List<IOwnable> GetCriteria();
        public abstract override List<Resource> GetUpkeep();
    }
}