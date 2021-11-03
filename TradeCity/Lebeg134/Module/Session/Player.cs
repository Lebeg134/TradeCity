/**
* @(#) Player.cs
*/
using JHP4SD.Lebeg134.Module.Resources;
using JHP4SD.Lebeg134.Module.Structures;
using JHP4SD.Lebeg134.Module.TimeManager;
using System.Collections.Generic;

namespace JHP4SD.Lebeg134.Module.Session
{


    public partial class Player : ITickable
    {
        Session session;
        List<IOwnable> owned;
        Dictionary<System.Type, Resource> ownedResources;
        IPlayerStrategy playerStrategy;

        public bool hasStructure(IOwnable structure)
        {
            foreach (IOwnable ownable in owned)
            {
                if (ownable.GetType() == structure.GetType())
                    return true;
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
            structure.acquire(this);
        }
        public bool hasResource(Resource res)
        {
            return ownedResources.ContainsKey(res.GetType());
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
        public Resource getProduces()
        {
            return null;
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
