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
                _player.Production = new ProductionSystem(_player, new EvenDistributionStrartegy());
            }
            public override void Tick()
            {
                foreach (Resource res in _player.GetAllRes())
                {
                    res.Tick();
                }
                base.Tick();
                Produce();
            }
            private void Produce()
            {
                List<IProducer> producers = new();
                _player._owned.ForEach(owned =>
                {
                    if (owned is IProducer)
                    {
                        producers.Add((IProducer)owned);
                    }
                });
                _player.Production.Produce(producers);
                _player.Production.GatherProducts();
            }
        }
    }
}
