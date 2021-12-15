/**
* @(#) Player.cs
*/
using JHP4SD.Lebeg134.Module.Resources;
using JHP4SD.Lebeg134.Module.Structures;
using JHP4SD.Lebeg134.Module.TimeManager;
using System;
using System.Collections.Generic;

namespace JHP4SD.Lebeg134.Module.Session
{

    [Serializable]
    public partial class Player : ITickable
    {
        //Session session;
        List<IOwnable> owned = new List<IOwnable>();
        Dictionary<Type, Resource> ownedResources = new Dictionary<Type, Resource>();
        IPlayerStrategy playerStrategy;
        public static Player CurrentPlayer { get; set; }

        public Player()
        {
            Console.WriteLine("New Player created"); //DEBUG
            playerStrategy = new StandardPlayerStrategy(this);
        }
        internal IEnumerable<Resource> getAllRes()
        {
            return ownedResources.Values;
        }
        public bool hasStructure(IOwnable structure)
        {
            foreach (IOwnable ownable in owned)
            {
                if (ownable.GetType() == structure.GetType())
                    return true;
                Console.WriteLine(structure.ToString()); //DEBUG
            }
            return false;
        }
        public bool checkStructures(List<IOwnable> structures, bool throwException = false)
        {
            bool valid = true;
            List<IOwnable> missingStructures = new List<IOwnable>();
            foreach (IOwnable ownable in structures)
            {
                if (!hasStructure(ownable))
                {
                    valid = false;
                    missingStructures.Add(ownable);
                }
            }
            if (!valid && throwException)
                throw new MissingStructuresException(missingStructures);
            return valid;
        }
        public void giveStructure(IOwnable structure)
        {
            owned.Add(structure);
            structure.acquire(this);
        }
        public List<Building> getAllBuildings()
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
        public bool hasResource(Resource res)
        {
            return ownedResources.ContainsKey(res.GetType());
        }
        public bool checkResource(Resource res)
        {
            return checkResources(new List<Resource>() { res });
        }
        public bool checkResources(List<Resource> resources, bool throwException = false)
        {
            bool valid = true;
            List<Resource> missingResources = new List<Resource>();
            foreach (Resource resource in resources)
            {
                if (hasResource(resource))
                {
                    int dif = ownedResources[resource.GetType()].amount() - resource.amount();
                    if (dif < 0)
                    {
                        missingResources.Add(resource.getNewResource(dif));
                        valid = false;
                    }
                }
                else
                {
                    missingResources.Add(resource.getNewResource(resource.amount()));
                }
            }
            if (!valid && throwException)
                throw new NotEnoughResourceException(missingResources);
            return valid;
        }
        public void subRes(Resource resource)
        {
            ownedResources[resource.GetType()] -= resource;
        }
        public void subRes(List<Resource> resources)
        {
            foreach (Resource res in resources)
            {
                subRes(res);
            }
        }
        public int getRes(Resource resource)
        {
            return ownedResources[resource.GetType()].amount();
        }
        public Resource getResRef(Resource resource)
        {
            return ownedResources[resource.GetType()];
        }
        public void giveRes(Resource resource)
        {
            ownedResources[resource.GetType()] += resource;
        }
        public void giveRes(List<Resource> resources)
        {
            foreach (Resource res in resources)
            {
                giveRes(res);
            }
        }
        public void registerResources(List<Resource> newResList)
        {
            foreach (Resource res in newResList)
            {
                ownedResources.Add(res.GetType(), res.getNewResource(0));
            }
        }
        public void freeze()
        {
            playerStrategy.freeze();
        }
        public void unFreeze(IPlayerStrategy newStrategy)
        {
            playerStrategy.unFreeze(newStrategy);
        }
        public bool isFrozen()
        {
            return playerStrategy.isFrozen();
        }
        public void goBankrupt()
        {
            playerStrategy.goBankrupt();
        }
        public void tick()
        {
            playerStrategy.tick();
        }
        public void register()
        {
            Clock.Instance.Register(this);
        }
    }

}
