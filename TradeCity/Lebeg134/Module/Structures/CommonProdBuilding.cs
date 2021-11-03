/**
* @(#) CommonProdBuilding.cs
*/
using JHP4SD.Lebeg134.Module.Resources;
using System.Collections.Generic;


namespace JHP4SD.Lebeg134.Module.Structures
{
    public class CommonProdBuilding : CommonBuilding, IProducer
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
        public void tick()
        {
            Produce();
        }
    }
}
