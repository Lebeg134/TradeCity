/**
* @(#) Structure.cs
*/
using Assets.Module.Graphics;
using JHP4SD.Lebeg134.Module.Graphics;
using JHP4SD.Lebeg134.Units;
using System;
using System.Collections.Generic;
namespace JHP4SD.Lebeg134.Module.Structures
{
    [Serializable]
    public abstract class Structure : IEqualityComparer<Structure>, IGetRes
	{
        public static VisualUpdater updater = new VisualUpdater();
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
        public abstract string getName();
        public virtual int GetHashCode(Structure obj)
        {
            return obj.GetType().GetHashCode();
        }

        virtual public string GetResourcepath()
        {
            return "Structure/Default";
        }
        virtual protected string getBasePath()
        {
            return "Structure/";
        }
    }
}
