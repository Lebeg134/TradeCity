/**
* @(#) SpecialProdBuilding.cs
*/
using Lebeg134.Module.Resources;
using System.Collections.Generic;
namespace Lebeg134.Module.Structures
{
	public class SpecialProdBuilding : SpecialBuilding, IProducer
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
        public void tick()
        {
            Produce();
        }
    }
	
}
