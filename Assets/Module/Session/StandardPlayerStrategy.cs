/**
 * @(#) StandardPlayerStrategy.cs
 */
using System;
using System.Collections.Generic;
using Lebeg134.Module.Resources;
using Lebeg134.Module.Structures;

namespace Lebeg134.Module.Session
{
    public partial class Player
    {
        [Serializable]
        public class StandardPlayerStrategy : PlayerStrategyBase
        {
            public StandardPlayerStrategy(Player subject) : base(subject) { }
            public override void tick()
            {
                Produce();
            }
            private void Produce()
            {
                foreach (Resource cntRes in player.cntResourcesBuffer.Values)
                {
                    player.ownedResources[cntRes.GetType()].setAmount(cntRes.amount());
                    cntRes.setAmount(0);
                }
                foreach (IProducer producer in player.owned)
                {
                    producer.Produce();
                }
                
            }
        }
    }
}
