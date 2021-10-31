/**
* @(#) Land.cs
*/
using Lebeg134.Module.Map;
using Lebeg134.Module.Resources;
using Lebeg134.Module.Session;
using System.Collections.Generic;

namespace Lebeg134.Module.Structures
{
    public class Land : Structure, IUpgradeable, IProducer, IOwnable, IMapStructure
    {
        protected static readonly List<Resource>[] upgradeLevelsCosts;
        protected static readonly List<Resource>[] productionLevels;
        protected static int startingPrice;
        protected Player owner;
        protected int level = 1; //Leveling starts from 1

        public void acquire(Player by)
        {
            owner = by;
        }
        public void levelUp()
        {
            if (owner.checkResources(upgradeLevelsCosts[level])) //Level is 1 higher than index used for level stats
                level++;
        }
        public List<Resource> getProduce()
        {
            return productionLevels[level - 1];
        }
        public void Produce()
        {
            ProducerStrategy.Produce(owner, this);
        }
        public void tick()
        {
            Produce();
        }
    }

}
