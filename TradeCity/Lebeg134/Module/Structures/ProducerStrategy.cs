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
            // Could implement more complex method later
            if (owner.checkResources(producer.getUpkeep()))
            {
                owner.subRes(producer.getUpkeep());
                owner.giveRes(producer.getProduce());
            }
        }
    }
}
