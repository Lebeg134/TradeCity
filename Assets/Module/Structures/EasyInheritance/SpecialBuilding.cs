using Lebeg134.Module.Resources;
using Lebeg134.Module.Structures;
using Lebeg134.Units;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lebeg134.Module.Structures
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

        public override abstract List<Resource> GetCost();
        public override abstract List<IOwnable> GetCriteria();
        public override abstract List<Resource> GetUpkeep();
    }
}
