using System;
using System.Collections.Generic;
using System.Linq;
using TradeCity.Engine.Production;
using TradeCity.Engine.Structures;
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
                _player.Production = new ProductionSystem(_player, new EvenDistributionStrategy());
            }

            public override void Tick()
            {
                foreach (var res in _player.GetAllRes()) res.Tick();
                base.Tick();
                //Upkeep();
                Produce();
            }

            private void Produce()
            {
                List<IProducer> producers = new();
                _player._owned.ForEach(owned =>
                {
                    if (owned is IProducer producer) producers.Add(producer);
                });
                _player.Production.Produce(producers);
                _player.Production.GatherProducts();
            }
        }
    }
}