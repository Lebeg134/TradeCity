/**
* @(#) CommonProdBuilding.cs
*/
using Lebeg134.Module.Resources;
using Lebeg134.Module.TimeManager;
using System;
using System.Collections.Generic;


namespace Lebeg134.Module.Structures
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
