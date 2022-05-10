/**
* @(#) Player.cs
*/
using Lebeg134.Module.Production;
using Lebeg134.Module.Resources;
using Lebeg134.Module.Structures;
using Lebeg134.Module.TimeManager;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Lebeg134.Module.Session
{

    [Serializable]
    public partial class Player : ITickable
    {
        public event Action<Resource> OnResourceChange;
        //public event Action<IOwnable> OnAquire;
        //public event Action<Building> OnUpgrade;

        List<IOwnable> owned = new List<IOwnable>();
        Dictionary<Type, Resource> ownedResources = new Dictionary<Type, Resource>();
        IPlayerStrategy playerStrategy;
        ProductionSystem Production { get; set; }
        public static Player CurrentPlayer { get; set; }

        public Player()
        {
            playerStrategy = new StandardPlayerStrategy(this);
            //foreach (Resource res in ownedResources.Values)
            //{
            //    res.OnAmountChange += (amount) => OnResourceChange.Invoke(res.GetNewResource(amount));
            //}
        }


        internal IEnumerable<Resource> GetAllRes()
        {
            return ownedResources.Values;
        }
        public bool HasStructure(IOwnable structure)
        {
            foreach (IOwnable ownable in owned)
            {
                if (ownable.GetType() == structure.GetType())
                    return true;
            }
            return false;
        }
        public bool CheckStructures(List<IOwnable> structures, bool throwException = false)
        {
            bool valid = true;
            List<IOwnable> missingStructures = new List<IOwnable>();
            foreach (IOwnable ownable in structures)
            {
                if (!HasStructure(ownable))
                {
                    valid = false;
                    missingStructures.Add(ownable);
                }
            }
            if (!valid && throwException)
                throw new Exception();
            return valid;
        }
        public void GiveStructure(IOwnable structure)
        {
            owned.Add(structure);
            structure.Acquire(this);
        }
        public List<Building> GetAllBuildings()
        {
            List<Building> ret = new List<Building>();
            foreach (IOwnable item in owned)
            {
                if (item is Building)
                {
                    ret.Add((Building)item);
                }
            }
            return ret;
        }
        public List<Land> GetLands()
        {
            List<Land> ret = new List<Land>();
            foreach (IOwnable item in owned)
            {
                if (item is Land)
                {
                    ret.Add((Land)item);
                }
            }
            return ret;
        }
        public bool HasResource(Resource res)
        {
            return ownedResources.ContainsKey(res.GetType());
        }
        public bool CheckResource(Resource res)
        {
            return CheckResources(new List<Resource>() { res });
        }
        public bool CheckResources(List<Resource> resources, bool throwException = false)
        {
            bool valid = true;
            List<Resource> missingResources = new List<Resource>();
            foreach (Resource resource in resources)
            {
                if (HasResource(resource))
                {
                    int dif = ownedResources[resource.GetType()].GetStock() - resource.GetStock();
                    if (dif < 0)
                    {
                        missingResources.Add(resource.GetNewResource(dif));
                        valid = false;
                    }
                }
                else
                {
                    missingResources.Add(resource.GetNewResource(resource.GetStock()));
                }
            }
            if (!valid && throwException)
                throw new Exception();
            return valid;
        }
        public void SubRes(Resource resource)
        {
            ownedResources[resource.GetType()] -= resource;
            OnResourceChange?.Invoke(resource.GetNewResource(-resource.GetStock()));
        }
        public void SubRes(List<Resource> resources)
        {
            foreach (Resource res in resources)
            {
                SubRes(res);
            }
        }
        public int GetRes(Resource resource)
        {
            return ownedResources[resource.GetType()].GetStock();
        }
        public Resource GetResRef(Resource resource)
        {
            return ownedResources[resource.GetType()];
        }
        public void GiveRes(Resource resource)
        {
            OnResourceChange?.Invoke(resource);
            ownedResources[resource.GetType()] += resource;
        }
        public void GiveRes(List<Resource> resources)
        {
            foreach (Resource res in resources)
            {
                GiveRes(res);
            }
        }
        public void RegisterResources(List<Resource> newResList)
        {
            foreach (Resource res in newResList)
            {
                ownedResources.Add(res.GetType(), res.GetNewResource(0));
            }
        }
        public void Freeze()
        {
            playerStrategy.Freeze();
        }
        public void UnFreeze(IPlayerStrategy newStrategy)
        {
            playerStrategy.UnFreeze(newStrategy);
        }
        public bool IsFrozen()
        {
            return playerStrategy.IsFrozen();
        }
        public void GoBankrupt()
        {
            playerStrategy.GoBankrupt();
        }
        public void Tick()
        {
            playerStrategy.Tick();
        }
        public void Register()
        {
            Clock.Instance.Register(this);
        }
    }

}
