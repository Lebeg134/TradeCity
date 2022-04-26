/**
* @(#) CommonBuilding.cs
*/
using Lebeg134.Module.Resources;
using Lebeg134.Module.Session;
using System;
using System.Collections.Generic;

namespace Lebeg134.Module.Structures
{
    [Serializable]
    public abstract class CommonBuilding : Building, IUpgradeable
    {
        protected int level = 0; //Level 0 means unbuilt building
        public abstract List<Resource> UpgradeLevelsCosts(int level);
        public void LevelUp()
        {
            if (CheckLevelUp())
            {
                owner.SubRes(UpgradeLevelsCosts(level));
                level++;
            }

        }
        public bool CheckLevelUp()
        {
            return level < GetMaxLevel() && owner.CheckResources(UpgradeLevelsCosts(level));
        }

        public abstract int GetMaxLevel();
        public bool IsMaxLevel()
        {
            return level == GetMaxLevel();
        }

        public override void Build(Player by)
        {
            base.Build(by);
            level = 1;
        }
        public override List<Resource> Cost()
        {
            if (GetMaxLevel() > level)
                return UpgradeLevelsCosts(level);
            else
                return new List<Resource>();
        }

        public int GetLevel()
        {
            return level;
        }
    }

}
