/**
* @(#) CommonBuilding.cs
*/
using JHP4SD.Lebeg134.Module.Resources;
using System;
using System.Collections.Generic;

namespace JHP4SD.Lebeg134.Module.Structures
{
    public abstract class CommonBuilding : Building, IUpgradeable
    {
        protected static List<Resource>[] upgradeLevelsCosts { get; }
        protected static List<Resource>[] upkeepLevels { get; }
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
