using System;
using System.Collections.Generic;
using AutSoft.UnitySupplements.EventBus;
using TradeCity.Engine.Production;
using TradeCity.Engine.Resources;
using TradeCity.Engine.Session;
using TradeCity.Engine.Structures.Interfaces;

namespace TradeCity.Engine.Structures
{
    [Serializable]
    public abstract class Building : CommonStructure, IOwnable, IBuilding
    {
        protected List<Recipe> _recipes = new();
        
        public BuildingState BuildingState
        {
            get
            {
                if (_level == 0) return BuildingState.Build;
                if (_level < GetMaxLevel()) return BuildingState.Upgrade;
                if (_level >= GetMaxLevel()) return BuildingState.Maxlevel;
                throw new Exception("Illegal building state");
            }
        }

        public List<Recipe> Recipes => _recipes;

        public void Build(Player by)
        {
            if (CanBuild(by))
            {
                by.SubRes(GetCost(0));
                by.GiveStructure(this);
                _level = 1;
                var buildings = "{ ";
                by.GetAllBuildings().ForEach(building => buildings += building.GetName() + ", ");
                Acquire(by);
                _eventBus.Invoke(new BuildingBuilt(this, by));
                if (BuildingState == BuildingState.Maxlevel)
                    _eventBus.Invoke(new StructureMaxLevelReached(this));
            }
        }

        public bool CanBuild(Player by)
        {
            if (BuildingState != BuildingState.Build) return false;
            return CheckCriteria(by);
        }

        public virtual List<Resource> GetUpkeep()
        {
            return GetUpkeep(_level);
        }

        public virtual List<Resource> GetCost()
        {
            return GetCost(_level);
        }

        public virtual List<IOwnable> GetCriteria()
        {
            return GetCriteria(_level);
        }

        public void PutResources(List<Resource> resources)
        {
            throw new NotImplementedException();
        }

        public virtual List<Resource> GetProduce()
        {
            throw new NotImplementedException();
        }

        public void Tick()
        {

        }

        public void Register()
        {
            //cannot register directly
            throw new NotImplementedException();
        }

        protected virtual List<Resource> GetUpkeep(int level)
        {
            return new List<Resource>();
        }

        protected override string GetBasePath()
        {
            return base.GetBasePath() + "Building/";
        }

        public class BuildingBuilt:IEvent
        {
            public BuildingBuilt(Building building, Player byPlayer)
            {
                Building = building;
                ByPlayer = byPlayer;
            }

            public Building Building { get; }
            public Player ByPlayer { get; }
        }
    }
}