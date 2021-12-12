/**
* @(#) Structure.cs
*/
using JHP4SD.Lebeg134.Units;
using System.Collections.Generic;
namespace JHP4SD.Lebeg134.Module.Structures
{
	public abstract class Structure : IEqualityComparer<Structure>
	{
		protected bool state; //true = on, false = off
		public virtual void On()
        {
			state = true;
        }
		public virtual void Off()
        {
			state = false;
        }
		public bool GetState()
        {
			return state;
        }
        public virtual bool Equals(Structure x, Structure y)
        {
            return x.GetType() == y.GetType();
        }
        public virtual Branches getBranch()
        {
            return Branches.COMMON;
        }

        public virtual int GetHashCode(Structure obj)
        {
            return obj.GetType().GetHashCode();
        }
    }
}
