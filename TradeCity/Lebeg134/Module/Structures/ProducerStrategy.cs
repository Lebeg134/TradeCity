/**
* @(#) ProducerStrategy.cs
*/
using JHP4SD.Lebeg134.Module.Resources;
using JHP4SD.Lebeg134.Module.Session;

namespace JHP4SD.Lebeg134.Module.Structures
{
    static class ProducerStrategy
    {
        public static void Produce(Player owner, IProducer producer)
        {
            //TODO determine production of resources and subtract needed resources
            //if (owner.hasResource(...)) ...
            owner.giveRes(producer.getProduce());
        }
    }
}
