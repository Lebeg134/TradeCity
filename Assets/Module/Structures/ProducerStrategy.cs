/**
* @(#) ProducerStrategy.cs
*/
using Lebeg134.Module.Session;

namespace Lebeg134.Module.Structures
{
    static class ProducerStrategy
    {
        public static void Produce(Player owner, IProducer producer)
        {
            // Could implement more complex method later
            if (owner.CheckResources(producer.GetUpkeep()))
            {
                owner.SubRes(producer.GetUpkeep());
                owner.GiveRes(producer.GetProduce());
            }
        }
    }
}
