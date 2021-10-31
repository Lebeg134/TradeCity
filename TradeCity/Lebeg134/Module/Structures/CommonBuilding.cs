/**
* @(#) CommonBuilding.cs
*/
using Lebeg134.Module.Resources;
using System;
using System.Collections.Generic;

namespace Lebeg134.Module.Structures
{
    public class CommonBuilding : Building, IUpgradeable
    {
        protected static readonly List<Resource>[] upgradeLevelsCosts;
        protected static readonly List<Resource>[] upkeepLevels;
        protected int level = 1; //Leveling starts from 1

        public void levelUp()
        {
            if (owner.checkResources(upgradeLevelsCosts[level])) //Level is 1 higher than index used for level stats
                level++;
        }
        public override List<Resource> getUpkeep()
        {
            return upkeepLevels[level - 1];
        }
    }

}
