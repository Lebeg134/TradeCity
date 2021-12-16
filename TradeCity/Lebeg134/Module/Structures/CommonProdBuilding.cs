/**
* @(#) CommonProdBuilding.cs
*/
using JHP4SD.Lebeg134.Module.Resources;
using JHP4SD.Lebeg134.Module.TimeManager;
using System;
using System.Collections.Generic;


namespace JHP4SD.Lebeg134.Module.Structures
{
    [Serializable]
    public abstract class CommonProdBuilding : CommonBuilding, IProducer
    {
        public abstract List<Resource> getProduce();
        public void Produce()
        {
            ProducerStrategy.Produce(owner, this);
        }

        public void register()
        {
            Clock.Instance.Register(this);
        }

        public void tick()
        {
            Produce();
        }
    }
}
