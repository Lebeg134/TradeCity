using AutSoft.UnitySupplements.EventBus;
using Injecter;
using System;
using System.Collections.Generic;
using TradeCity.Engine.Core;
using TradeCity.Units;

namespace TradeCity.Engine.Structures
{
    [Serializable]
    public abstract class Structure : IEqualityComparer<Structure>
    {
        [NonSerialized]
        [Inject] protected readonly IEventBus _eventBus;

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

        public Structure()
        {
            _eventBus = EngineCore.InjectEventBus();
        }

        public virtual bool Equals(Structure x, Structure y)
        {
            return x.GetType() == y.GetType();
        }

        public virtual int GetHashCode(Structure obj)
        {
            return obj.GetType().GetHashCode();
        }

        public virtual void On()
        {
            if (_isOn) return;
            _isOn = true;
            _eventBus.Invoke(new StructureStateChanged(this, _isOn));
        }

        public virtual void Off()
        {
            if (!_isOn) return;
            _isOn = false;
            _eventBus.Invoke(new StructureStateChanged(this, _isOn));
        }

        public abstract string GetName();
        public abstract Branches GetBranch();

        public virtual string GetResourcePath()
        {
            return "Structure/Default";
        }

        protected virtual string GetBasePath()
        {
            return "Structure/";
        }

        public class StructureStateChanged : IEvent
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