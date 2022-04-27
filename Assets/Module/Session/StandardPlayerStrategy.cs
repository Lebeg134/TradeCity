/**
 * @(#) StandardPlayerStrategy.cs
 */
using Lebeg134.Module.Resources;
using Lebeg134.Module.Structures;
using System;

namespace Lebeg134.Module.Session
{
    public partial class Player
    {
        [Serializable]
        public class StandardPlayerStrategy : PlayerStrategyBase
        {
            public StandardPlayerStrategy(Player subject) : base(subject) { }
            public override void Tick()
            {
                Produce();
            }
            private void Produce()
            {
                foreach (Resource cntRes in player.cntResourcesBuffer.Values)
                {
                    player.ownedResources[cntRes.GetType()].SetAmount(cntRes.Amount());
                    cntRes.SetAmount(0);
                }
                foreach (IProducer producer in player.owned)
                {
                    producer.Produce();
                }

            }
        }
    }
}
