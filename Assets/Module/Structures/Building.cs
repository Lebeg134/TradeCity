/**
 * @(#) Building.cs
 */
using Lebeg134.Module.Production;
using Lebeg134.Module.Resources;
using Lebeg134.Module.Session;
using Lebeg134.Units;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Lebeg134.Module.Structures
{
    [Serializable]
    public abstract class Building : CommonStructure, IOwnable, IBuilding
    {
        // ========== Public events
        public event Action<Building> OnBuild;

        // ========== Attributes
        protected List<Recipe> recipes = new List<Recipe>();

        // ========== Properties
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
        public List<Recipe> Recipes => recipes;

        // ========== Interface Implementations
        public void Build(Player by)
        {
            if (CanBuild(by))
            {
                by.SubRes(GetCost(0));
                by.GiveStructure(this);
                level = 1;
                Debug.Log(GetName()+" built");
                string buildings = "{ ";
                by.GetAllBuildings().ForEach((building) => buildings += building.GetName() + ", ");
                Debug.Log(buildings + "}");
                Acquire(by);
                OnBuild?.Invoke(this);
                if (BuildingState == BuildingState.MAXLEVEL)
                    InvokeOnMaxLevelReached();
            }
        }
        public bool CanBuild(Player by)
        {
            if (BuildingState != BuildingState.BUILD) return false;
            return CheckCriteria(by, 0);
        }
        public virtual List<Resource> GetUpkeep()
        {
            return GetUpkeep(level);
        }
        public virtual List<Resource> GetCost()
        {
            return GetCost(level);
        }
        public virtual List<IOwnable> GetCriteria()
        {
            return GetCriteria(level);
        }
        public void PutResources(List<Resource> resources)
        {
            throw new NotImplementedException();
        }
        public virtual List<Resource> GetProduce()
        {
            throw new NotImplementedException();
        }

        // ========== Internal Methods
        protected abstract List<Resource> GetUpkeep(int level);
        override protected string GetBasePath()
        {
            return base.GetBasePath() + "Building/";
        }
    }
}
