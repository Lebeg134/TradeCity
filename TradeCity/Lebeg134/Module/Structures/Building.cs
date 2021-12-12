/**
 * @(#) Building.cs
 */
using JHP4SD.Lebeg134.Module.Resources;
using JHP4SD.Lebeg134.Module.Session;
using System;
using System.Collections.Generic;

namespace JHP4SD.Lebeg134.Module.Structures
{
    public abstract class Building : Structure, IOwnable
    {
        protected abstract List<IOwnable> Criteria();
        protected abstract List<Resource> Cost();
        protected Player owner;

        public Building(Player owner = null)
        {
            this.owner = owner;
        }
        public abstract List<Resource> getUpkeep();
        public void Build(Player by)
        {
            if (by.checkResources(Cost()) &&
                by.checkStructures(Criteria()))
            {
                by.subRes(Cost());
                by.giveStructure(this);
            }
        }
        public virtual void acquire(Player by)
        {
            //Possibility to transfer ownership?, can implement later if needed
            owner = by;
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
