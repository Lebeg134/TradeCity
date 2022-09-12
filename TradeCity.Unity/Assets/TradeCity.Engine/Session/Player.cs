using System;
using System.Collections.Generic;
using System.Linq;
using TradeCity.Engine.Production;
using TradeCity.Engine.Resources;
using TradeCity.Engine.Structures;
using TradeCity.Engine.Structures.Interfaces;
using TradeCity.Engine.TimeManager;

namespace TradeCity.Engine.Session
{
    [Serializable]
    public partial class Player : ITickable
    {
        //public event Action<IOwnable> OnAquire;
        //public event Action<Building> OnUpgrade;

        private readonly List<IOwnable> _owned = new();
        private readonly Dictionary<Type, Resource> _ownedResources = new();
        private IPlayerStrategy _playerStrategy;

        public Player()
        {
            _playerStrategy = new StandardPlayerStrategy(this);
            //foreach (Resource res in ownedResources.Values)
            //{
            //    res.OnAmountChange += (amount) => OnResourceChange.Invoke(res.GetNewResource(amount));
            //}
        }

        private ProductionSystem Production { get; set; }
        public static Player CurrentPlayer { get; set; }

        public void Tick()
        {
            _playerStrategy.Tick();
        }

        public void Register()
        {
            Clock.Instance.Register(this);
        }

        public event Action<Resource> OnResourceChange;


        public IEnumerable<Resource> GetAllRes()
        {
            return _ownedResources.Values;
        }

        public bool HasStructure(IOwnable structure)
        {
            return _owned.Any(ownable => ownable.GetType() == structure.GetType());
        }

        public bool CheckStructures(List<IOwnable> structures, bool throwException = false)
        {
            var valid = true;
            List<IOwnable> missingStructures = new();
            foreach (var ownable in structures)
                if (!HasStructure(ownable))
                {
                    valid = false;
                    missingStructures.Add(ownable);
                }

            if (!valid && throwException)
                throw new Exception();
            return valid;
        }

        public void GiveStructure(IOwnable structure)
        {
            _owned.Add(structure);
            structure.Acquire(this);
        }

        public List<Building> GetAllBuildings()
        {
            List<Building> ret = new();
            foreach (var item in _owned)
                if (item is Building building)
                    ret.Add(building);
            return ret;
        }

        public List<Land> GetLands()
        {
            List<Land> ret = new();
            foreach (var item in _owned)
                if (item is Land land)
                    ret.Add(land);
            return ret;
        }

        public bool HasResource(Resource res)
        {
            return _ownedResources.ContainsKey(res.GetType());
        }

        public bool CheckResource(Resource res)
        {
            return CheckResources(new List<Resource> { res });
        }

        public bool CheckResources(List<Resource> resources, bool throwException = false)
        {
            var valid = true;
            List<Resource> missingResources = new();
            foreach (var resource in resources)
                if (HasResource(resource))
                {
                    var dif = _ownedResources[resource.GetType()].GetStock() - resource.GetStock();
                    if (dif >= 0) continue;

                    missingResources.Add(resource.GetNewResource(dif));
                    valid = false;
                }
                else
                {
                    missingResources.Add(resource.GetNewResource(resource.GetStock()));
                }

            if (!valid && throwException)
                throw new Exception();
            return valid;
        }

        public void SubRes(Resource resource)
        {
            _ownedResources[resource.GetType()] -= resource;
            OnResourceChange?.Invoke(resource.GetNewResource(-resource.GetStock()));
        }

        public void SubRes(List<Resource> resources)
        {
            foreach (var res in resources) SubRes(res);
        }

        public int GetResCount(Resource resource)
        {
            return GetRes(resource).GetStock();
        }

        public Resource GetRes(Resource resource)
        {
            return _ownedResources[resource.GetType()];
        }

        public void GiveRes(Resource resource)
        {
            OnResourceChange?.Invoke(resource);
            _ownedResources[resource.GetType()] += resource;
        }

        public void GiveRes(List<Resource> resources)
        {
            foreach (var res in resources) GiveRes(res);
        }

        public void RegisterResources(List<Resource> newResList)
        {
            foreach (var res in newResList) _ownedResources.Add(res.GetType(), res.GetNewResource(0));
        }

        public void Freeze()
        {
            _playerStrategy.Freeze();
        }

        public void UnFreeze(IPlayerStrategy newStrategy)
        {
            _playerStrategy.UnFreeze(newStrategy);
        }

        public bool IsFrozen()
        {
            return _playerStrategy.IsFrozen();
        }

        public void GoBankrupt()
        {
            _playerStrategy.GoBankrupt();
        }
    }
}