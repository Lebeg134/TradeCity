/**
* @(#) Player.cs
*/
using Lebeg134.Module.Resources;
using Lebeg134.Module.Structures;
using Lebeg134.Module.TimeManager;
using System.Collections.Generic;

namespace Lebeg134.Module.Session
{


    public class Player : ITickable
    {
        Session session;
        List<Building> ownedBuildings;
        List<Land> ownedLands;
        //List<Resource> ownedResources;
        Dictionary<System.Type, Resource> ownedResources;
        IPlayerStrategy playerStrategy;

        void simResources()
        {

        }
        public bool hasStructure(IOwnable structure)
        {
            foreach (Land land in ownedLands)
            {
                if (land.GetType() == structure.GetType())
                    return true;
            }
            foreach (Building building in ownedBuildings)
            {
                if (building.GetType() == structure.GetType())
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

        public void subRes(Resource res)
        {

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
            return 0;
        }

        public void giveRes(Resource resource)
        {

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

        public void unFreeze()
        {
            playerStrategy.unFreeze();
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
