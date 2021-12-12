/**
* @(#) CommonBuilding.cs
*/
using JHP4SD.Lebeg134.Module.Resources;
using JHP4SD.Lebeg134.Module.Session;
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
        public override void Build(Player by)
        {
            base.Build(by);
            level = 1;
        }
        protected override List<Resource> Cost()
        {
            return upgradeLevelsCosts(0);
        }
    }

}
