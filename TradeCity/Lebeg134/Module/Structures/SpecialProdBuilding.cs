/**
* @(#) SpecialProdBuilding.cs
*/
using JHP4SD.Lebeg134.Module.Resources;
using JHP4SD.Lebeg134.Module.TimeManager;
using System.Collections.Generic;
namespace JHP4SD.Lebeg134.Module.Structures
{
	public abstract class SpecialProdBuilding : SpecialBuilding, IProducer
	{
        protected static readonly List<Resource> production;

        public List<Resource> getProduce()
        {
            return production;
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
