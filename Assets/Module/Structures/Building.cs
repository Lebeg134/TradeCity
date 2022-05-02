/**
 * @(#) Building.cs
 */
using Lebeg134.Module.Resources;
using Lebeg134.Module.Session;
using Lebeg134.Units;
using System;
using System.Collections.Generic;

namespace Lebeg134.Module.Structures
{
    [Serializable]
    public abstract class Building : Structure, IOwnable, IUpgradeable
    {
        public event Action<Building> OnBuild;
        public event Action<Building> OnUpgrade;
        public event Action<Building> OnMaxLevelReached;
        protected Player owner;
        protected int level = 0;
        public BuildingState BuildingState
        {
            get
            {
                if (level == 0) return BuildingState.BUILD;
                if (level < REPLACEMEGetMaxLevel()) return BuildingState.UPGRADE;
                if (level >= REPLACEMEGetMaxLevel()) return BuildingState.MAXLEVEL;
                throw new Exception("Illegal building state");
            }
        }
        public int Level => level;
        public int MaxLevel => REPLACEMEGetMaxLevel();

        public Building(Player owner = null)
        {
            this.owner = owner;
        }
        public abstract List<IOwnable> GetCriteria(int level);
        public abstract List<Resource> GetCost(int level);
        public abstract List<Resource> GetUpkeep(int level);
        protected virtual bool Construct(Player by, int level = 0)
        {
            if (CheckCriteria(by, level))
            {
                by.SubRes(GetCost(level));
                by.GiveStructure(this);
                BuildingState buildingState = BuildingState;
                this.level++;
                if (buildingState == BuildingState.BUILD) OnBuild?.Invoke(this);
                if (buildingState == BuildingState.UPGRADE) OnUpgrade?.Invoke(this);
                if (BuildingState == BuildingState.MAXLEVEL) OnMaxLevelReached?.Invoke(this);
                return true;
            }
            return false;
        }
        public virtual bool CheckCriteria(Player by, int level = 0)
        {
            return by.CheckResources(GetCost(level)) && by.CheckStructures(GetCriteria(level));
        }
        public bool CheckCriteria()
        {
            return CheckCriteria(owner, level);
        }
        public virtual void Build(Player by)
        {
            if (level == 0 && Construct(by, 0))
            {
                // TODO Register Off events
            }
        }
        public void LevelUp()
        {
            if (level > 0 && level < MaxLevel)
                Construct(owner, level);
        }
        public bool CanBuild(Player by)
        {
            if (level != 0) return false;
            return CheckCriteria(by, 0);
        }
        public virtual void Acquire(Player by)
        {
            //Possibility to transfer ownership?, can implement later if needed
            owner = by;
        }
        override protected string GetBasePath()
        {
            return base.GetBasePath() + "Building/";
        }
        public abstract int REPLACEMEGetMaxLevel();
        public int REPLACEMEGetLevel()
        {
            //TODO Remove!
            throw new NotImplementedException();
        }
    }

    [Serializable]
    internal class MissingStructuresException : Exception
    {
        List<IOwnable> missingStructures;
        public MissingStructuresException(List<IOwnable> missingStructures)
        {
            this.missingStructures = missingStructures;
        }
    }
}
