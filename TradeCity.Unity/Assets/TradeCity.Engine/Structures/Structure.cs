/**
* @(#) Structure.cs
*/

using System;
using System.Collections.Generic;
using TradeCity.Engine.Graphics;
using TradeCity.Units;

namespace TradeCity.Engine.Structures
{
    [Serializable]
    public abstract class Structure : IEqualityComparer<Structure>, IGetRes
    {
        public event Action<Structure> OnTurnOn;
        public event Action<Structure> OnTurnOff;
        protected bool isOn = true;
        public bool IsOn
        {
            get => isOn;
            set
            {
                if (value)
                {
                    On();
                }
                else
                {
                    Off();
                }
            }
        }
        public virtual void On()
        {
            if (!isOn)
            {
                isOn = true;
                OnTurnOn?.Invoke(this);
            }

        }
        public virtual void Off()
        {
            if (isOn)
            {
                isOn = false;
                OnTurnOff?.Invoke(this);
            }
        }
        public abstract string GetName();
        public abstract Branches GetBranch();
        public virtual bool Equals(Structure x, Structure y)
        {
            return x.GetType() == y.GetType();
        }
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
