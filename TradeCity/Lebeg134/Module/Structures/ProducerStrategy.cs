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
            System.Console.WriteLine("Checking Producer: "+producer.ToString());//DEBUG
            // Could implement more complex method later
            if (owner.checkResources(producer.getUpkeep()))
            {
                System.Console.WriteLine("Producing...");//DEBUG
                owner.subRes(producer.getUpkeep());
                owner.giveRes(producer.getProduce());
            }
        }
    }
}
