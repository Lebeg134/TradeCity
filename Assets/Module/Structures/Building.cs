/**
 * @(#) Building.cs
 */
using JHP4SD.Lebeg134.Module.Resources;
using JHP4SD.Lebeg134.Module.Session;
using JHP4SD.Lebeg134.Units;
using System;
using System.Collections.Generic;

namespace JHP4SD.Lebeg134.Module.Structures
{
    [Serializable]
    public abstract class Building : Structure, IOwnable
    {
        public abstract List<IOwnable> Criteria();
        public abstract List<Resource> Cost();
        protected Player owner;
        public abstract override Branches getBranch();
        public Building(Player owner = null)
        {
            this.owner = owner;
        }
        public abstract List<Resource> getUpkeep();
        public virtual void Build(Player by)
        {
            if (CanBeBuilt(by))
            {
                by.subRes(Cost());
                by.giveStructure(this);
            }
        }
        public bool CanBeBuilt(Player by)
        {
            return by.checkResources(Cost()) && by.checkStructures(Criteria());
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
