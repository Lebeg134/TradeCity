/**
 * @(#) Building.cs
 */
using Lebeg134.Module.Resources;
using Lebeg134.Module.Session;
using Lebeg134.Units;
using System;
using System.Collections.Generic;

namespace Lebeg134.Module.Structures
{
    [Serializable]
    public abstract class Building : Structure, IOwnable
    {
        public abstract List<IOwnable> Criteria();
        public abstract List<Resource> Cost();
        protected Player owner;
        public abstract override Branches GetBranch();
        public Building(Player owner = null)
        {
            this.owner = owner;
        }
        public abstract List<Resource> GetUpkeep();
        public virtual void Build(Player by)
        {
            if (CanBuild(by))
            {
                by.SubRes(Cost());
                by.GiveStructure(this);
            }
        }
        public bool CanBuild(Player by)
        {
            return by.CheckResources(Cost()) && by.CheckStructures(Criteria());
        }
        public virtual void Acquire(Player by)
        {
            //Possibility to transfer ownership?, can implement later if needed
            owner = by;
        }
        override protected string GetBasePath()
        {
            return base.GetBasePath() + "Building/";
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
