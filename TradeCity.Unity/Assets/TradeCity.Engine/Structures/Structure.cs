using System;
using System.Collections.Generic;
using AutSoft.UnitySupplements.EventBus;
using TradeCity.Units;

namespace TradeCity.Engine.Structures
{
    [Serializable]
    public abstract class Structure : IEqualityComparer<Structure>
    {
        protected bool _isOn = true;

        public bool IsOn
        {
            get => _isOn;
            set
            {
                if (value)
                    On();
                else
                    Off();
            }
        }

        public virtual bool Equals(Structure x, Structure y)
        {
            return x.GetType() == y.GetType();
        }

        public virtual int GetHashCode(Structure obj)
        {
            return obj.GetType().GetHashCode();
        }

        public event Action<Structure> OnTurnOn;
        public event Action<Structure> OnTurnOff;

        public virtual void On()
        {
            if (!_isOn)
            {
                _isOn = true;
                OnTurnOn?.Invoke(this);
            }
        }

        public virtual void Off()
        {
            if (_isOn)
            {
                _isOn = false;
                OnTurnOff?.Invoke(this);
            }
        }

        public abstract string GetName();
        public abstract Branches GetBranch();

        public virtual string GetResourcepath()
        {
            return "Structure/Default";
        }

        protected virtual string GetBasePath()
        {
            return "Structure/";
        }

        public sealed class StructureStateChanged : IEvent
        {
            public StructureStateChanged(Structure subject, bool newState)
            {
                Subject = subject;
                NewState = newState;
            }

            public Structure Subject { get; }
            public bool NewState { get; }
        }
    }
}