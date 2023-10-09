using System;
using System.Collections.Generic;
using AutSoft.UnitySupplements.EventBus;
using Injecter;
using TradeCity.Engine.Core;
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
            if (!CanBuild(by)) return;

            by.SubRes(GetCost(0));
            by.GiveStructure(this);
            _level = 1;
            Acquire(by);
            _eventBus.Invoke(new BuildingBuilt(this, by));
            if (BuildingState == BuildingState.Maxlevel)
                _eventBus.Invoke(new StructureMaxLevelReached(this));
            _eventBus.Subscribe<Structure.StructureStateChanged>(HandleStructureChange);
        }

        public bool CanBuild(Player by)
        {
            return BuildingState == BuildingState.Build && CheckCriteria(by);
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
        private void HandleStructureChange(StructureStateChanged message)
        {
            foreach (var criteria in GetCriteria())
            {
                if (criteria is not Structure criteriaStructure) continue;
                if (criteriaStructure == message.Subject && !message.NewState)
                {
                    IsOn = false;
                }
            }
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