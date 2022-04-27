/**
* @(#) SpecialProdBuilding.cs
*/
using Lebeg134.Module.Resources;
using Lebeg134.Module.TimeManager;
using System;
using System.Collections.Generic;
namespace Lebeg134.Module.Structures
{
    [Serializable]
    public abstract class SpecialProdBuilding : SpecialBuilding, IProducer
    {
        abstract public List<Resource> GetProduce();
        public void Produce()
        {
            ProducerStrategy.Produce(owner, this);
        }

        public void Register()
        {
            Clock.Instance.Register(this);
        }

        public void Tick()
        {
            Produce();
        }
    }

}
