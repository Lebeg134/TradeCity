/**
 * @(#) StandardPlayerStrategy.cs
 */
using Lebeg134.Module.Production;
using Lebeg134.Module.Resources;
using Lebeg134.Module.Structures;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Lebeg134.Module.Session
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
                base.Tick();
                Produce();
            }
            private void Produce()
            {
                List<IProducer> producers = new List<IProducer>();
                player.owned.ForEach((owned) => {
                    if (owned is IProducer)
                    {
                        producers.Add((IProducer)owned);
                    }
                });
                foreach (Resource res in player.GetAllRes())
                {
                    res.Tick();
                }
                player.Production.Produce(producers);
                player.Production.GatherProducts();
            }
        }
    }
}
