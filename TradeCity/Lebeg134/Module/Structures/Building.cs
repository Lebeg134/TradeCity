/**
 * @(#) Building.cs
 */
using Lebeg134.Module.Resources;
using Lebeg134.Module.Session;
using System;
using System.Collections.Generic;

namespace Lebeg134.Module.Structures
{
    public class Building : Structure, IOwnable
    {
        private static readonly IOwnable[] Criteria;
        private static readonly Resource[] Cost;
        private static Resource[] Upkeep;
        Player owner;

        public Building(Player owner)
        {
            this.owner = owner;
        }
        public List<Resource> getUpkeep()
        {
            return new List<Resource>(Upkeep);
        }
        public void Build(Player by)
        {
            bool canBuild = true;
            List<Resource> missingRes = new List<Resource>();
            List<IOwnable> missingCrit = new List<IOwnable>();
            foreach (Resource res in Cost)
            {
                if (by.getRes(res) - res.amount() < 0)
                {
                    canBuild = false;
                    missingRes.Add(res); // TODO amount of missing resources
                }
            }
            if (!canBuild)
                throw new NotEnoughResourceException(missingRes);
            foreach (IOwnable ownable in Criteria)
            {
                if (!by.hasStructure(ownable))
                {
                    canBuild = false;
                    missingCrit.Add(ownable);
                }
            }
            if (!canBuild)
            {
                throw new MissingCriteriaException(missingCrit);
            }
            else
            {
                foreach (Resource resource in Cost)
                {
                    by.subRes(resource);
                }
                by.giveStructure(this);
            }
        }
        public virtual void acquire(Player by)
        {
            Build(by); //Possibility to transfer ownership, can implement later if needed
        }
    }

    [Serializable]
    internal class MissingCriteriaException : Exception
    {
        List<IOwnable> missingCriteria;
        public MissingCriteriaException(List<IOwnable> missingCriteria)
        {
            this.missingCriteria = missingCriteria;
        }
    }
}
