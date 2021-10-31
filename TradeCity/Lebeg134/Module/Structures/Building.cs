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
        protected Player owner;

        public Building(Player owner = null)
        {
            this.owner = owner;
        }
        public virtual List<Resource> getUpkeep()
        {
            return new List<Resource>(Upkeep);
        }
        public void Build(Player by)
        {
            if (by.checkResources(new List<Resource>(Cost))&&
                by.checkStructures(new List<IOwnable>(Criteria)))
            {
                by.subRes(new List<Resource>(Cost));
                by.giveStructure(this);
            }
        }
        public virtual void acquire(Player by)
        {
            Build(by); //Possibility to transfer ownership, can implement later if needed
        }
    }

    [Serializable]
    internal class MissingStructuresException : Exception
    {
        List<IOwnable> missingStructures;
        public MissingStructuresException(List<IOwnable> missingStructures)
        {
            this.missingStructures = missingStructures;
        }
    }
}
