/**
 * @(#) Building.cs
 */
using Assets.Module.Production;
using Lebeg134.Module.Resources;
using Lebeg134.Module.Session;
using Lebeg134.Units;
using System;
using System.Collections.Generic;

namespace Lebeg134.Module.Structures
{
    [Serializable]
    public abstract class Building : Structure, IOwnable, IBuilding
    {
        public event Action<Building> OnBuild;
        public event Action<Building> OnUpgrade;
        public event Action<Building> OnMaxLevelReached;

        protected Player owner;
        protected int level = 0;
        protected List<Recipe> recipes = new List<Recipe>();

        public Player Owner => owner;
        public BuildingState BuildingState
        {
            get
            {
                if (level == 0) return BuildingState.BUILD;
                if (level < GetMaxLevel()) return BuildingState.UPGRADE;
                if (level >= GetMaxLevel()) return BuildingState.MAXLEVEL;
                throw new Exception("Illegal building state");
            }
        }
        public int Level => level;
        public int MaxLevel => GetMaxLevel();
        public List<Recipe> Recipes => recipes;

        public void Acquire(Player by)
        {
            //Possibility to transfer ownership?, can implement later if needed
            owner = by;
        }
        public void Build(Player by)
        {
            if (CanBuild(by))
            {
                by.SubRes(GetCost(0));
                Acquire(by);
                OnBuild?.Invoke(this);
                if (BuildingState == BuildingState.MAXLEVEL)
                    OnMaxLevelReached?.Invoke(this);
            }
        }
        public bool CanBuild(Player by)
        {
            if (BuildingState != BuildingState.BUILD) return false;
            return CheckCriteria(by, 0);
        }
        public void Upgrade()
        {
            if (CanUpgrade())
            {
                owner.SubRes(GetCost(Level));
                OnUpgrade?.Invoke(this);
                if (BuildingState == BuildingState.MAXLEVEL)
                    OnMaxLevelReached?.Invoke(this);
            }
        }

        public bool CanUpgrade()
        {
            if (BuildingState != BuildingState.UPGRADE) return false;
            return CheckCriteria(owner, level);
        }
        public List<Resource> GetUpkeep()
        {
            return GetUpkeep(level);
        }
        public void PutResources(List<Resource> resources)
        {
            throw new NotImplementedException();
        }
        public List<Resource> GetProduce()
        {
            throw new NotImplementedException();
        }

        protected abstract int GetMaxLevel();
        protected abstract List<Resource> GetCost(int level);
        protected abstract List<IOwnable> GetCriteria(int level);
        protected abstract List<Resource> GetUpkeep(int level);

        protected virtual bool CheckCriteria(Player by, int level = 0)
        {
            return by.CheckResources(GetCost(level)) && by.CheckStructures(GetCriteria(level));
        }

        override protected string GetBasePath()
        {
            return base.GetBasePath() + "Building/";
        }
    }
}
