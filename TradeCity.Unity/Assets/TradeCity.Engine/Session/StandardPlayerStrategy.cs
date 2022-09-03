/**
 * @(#) StandardPlayerStrategy.cs
 */

using System;
using System.Collections.Generic;
using TradeCity.Engine.Production;
using TradeCity.Engine.Resources;
using TradeCity.Engine.Structures.Interfaces;

namespace TradeCity.Engine.Session
{
    public partial class Player
    {
        [Serializable]
        public class StandardPlayerStrategy : PlayerStrategyBase
        {
            public StandardPlayerStrategy(Player subject) : base(subject)
            {
                player.Production = new ProductionSystem(player, new EvenDistributionStrartegy());
            }
            public override void Tick()
            {
                foreach (Resource res in player.GetAllRes())
                {
                    res.Tick();
                }
                base.Tick();
                Produce();
            }
            private void Produce()
            {
                List<IProducer> producers = new();
                player.owned.ForEach((owned) =>
                {
                    if (owned is IProducer)
                    {
                        producers.Add((IProducer)owned);
                    }
                });
                player.Production.Produce(producers);
                player.Production.GatherProducts();
            }
        }
    }
}
