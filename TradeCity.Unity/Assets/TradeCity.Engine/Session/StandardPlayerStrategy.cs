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
                Upkeep();
                Produce();
            }

            private void Upkeep()
            {
                var buildingUsage = new SortedDictionary<Building, int>();
                _player._owned.ForEach(owned =>
                {
                    if (owned is not Building building) return;
                    CriteriaUpkeepHelper(building, buildingUsage);
                });

                foreach (var pair in buildingUsage.OrderByDescending(key => key.Value))
                {
                    var building = pair.Key;
                    var upkeep = building.GetUpkeep();
                    if (building.IsOn && _player.CheckResources(upkeep))
                    {
                        _player.SubRes(upkeep);
                    }
                    else
                    {
                        building.IsOn = false;
                    }

                }
            }

            private void CriteriaUpkeepHelper(Building building, SortedDictionary<Building, int> buildingUsage)
            {
                if (buildingUsage == null) throw new ArgumentNullException(nameof(buildingUsage));
                foreach (var criteria in building.GetCriteria())
                {
                    if (criteria is Building criteriaBuilding)
                    {
                        CriteriaUpkeepHelper(criteriaBuilding,  buildingUsage);
                    }
                }
                if (buildingUsage.TryGetValue(building, out _))
                {
                    buildingUsage[building]++;
                }
                else
                {
                    buildingUsage.Add(building, 1);
                }
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