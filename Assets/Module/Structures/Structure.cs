/**
* @(#) Structure.cs
*/
using Lebeg134.Module.Graphics;
using Lebeg134.Units;
using System;
using System.Collections.Generic;
namespace Lebeg134.Module.Structures
{
    [Serializable]
    public abstract class Structure : IEqualityComparer<Structure>, IGetRes
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
        public virtual Branches GetBranch()
        {
            return Branches.COMMON;
        }
        public abstract string GetName();
        public virtual int GetHashCode(Structure obj)
        {
            return obj.GetType().GetHashCode();
        }

        virtual public string GetResourcepath()
        {
            return "Structure/Default";
        }
        virtual protected string GetBasePath()
        {
            return "Structure/";
        }
    }
}
