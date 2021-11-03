/**
 * @(#) StandardPlayerStrategy.cs
 */
using System.Collections.Generic;
using JHP4SD.Lebeg134.Module.Resources;
using JHP4SD.Lebeg134.Module.Structures;

namespace JHP4SD.Lebeg134.Module.Session
{
    public partial class Player
    {
        public class StandardPlayerStrategy : PlayerStrategyBase
        {
            public StandardPlayerStrategy(Player subject) : base(subject) { }
            public void tick()
            {
                Produce();
            }
            private void Produce()
            {
                List<Resource> resources = new List<Resource>();
                foreach (IProducer producer in player.owned)
                {
                    producer.Produce();
                }
            }
        }
    }
}
    
}
