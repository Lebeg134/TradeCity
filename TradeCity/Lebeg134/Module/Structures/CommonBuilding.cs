/**
* @(#) CommonBuilding.cs
*/
using Lebeg134.Module.Resources;
using System.Collections.Generic;

namespace Lebeg134.Module.Structures
{
    public class CommonBuilding : Building, IUpgradeable
    {
        static readonly List<Resource>[] upgradeLevels;
        static readonly List<Resource>[] upkeepLevels;
        int level = 1; //Leveling starts from 1

        public void levelUp()
        {
            //Check conditions
            level++;
        }
        public override List<Resource> getUpkeep()
        {
            return upkeepLevels[level-1];
        }
    }

}
