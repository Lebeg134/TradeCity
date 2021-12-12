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
        protected abstract List<Resource> upgradeLevelsCosts(int level);
        protected int level = 0; //Level 0 means unbuilt building

        public void levelUp()
        {
            if (owner.checkResources(upgradeLevelsCosts(level))) //Level is 1 higher than index used for level stats
                level++;
        }
        protected override List<Resource> Cost()
        {
            return upgradeLevelsCosts(0);
        }
    }

}
