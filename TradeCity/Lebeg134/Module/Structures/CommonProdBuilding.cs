/**
* @(#) CommonProdBuilding.cs
*/
using JHP4SD.Lebeg134.Module.Resources;
using JHP4SD.Lebeg134.Module.TimeManager;
using System.Collections.Generic;


namespace JHP4SD.Lebeg134.Module.Structures
{
    public abstract class CommonProdBuilding : CommonBuilding, IProducer
    {
        protected static readonly List<Resource>[] productionLevels;
        public List<Resource> getProduce()
        {
            return productionLevels[level - 1]; //Level is 1 higher than index used for level stats
        }
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
