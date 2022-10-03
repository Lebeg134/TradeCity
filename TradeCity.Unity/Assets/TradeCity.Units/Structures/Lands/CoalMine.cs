using System;
using System.Collections.Generic;
using TradeCity.Engine.Resources;
using TradeCity.Engine.Structures;
using TradeCity.Units.Resources.Common;
using TradeCity.Units.Resources.EnergySector;

namespace TradeCity.Units.Structures.Lands
{
    [Serializable]
    public class CoalMine : Land
    {
        public override string GetName()
        {
            return "Coal Mine";
        }

        public override string GetResourcePath()
        {
            return GetBasePath() + "CoalMine";
        }

        public override Land GetNew()
        {
            return new CoalMine();
        }

        protected override List<Resource> GetProduce(int level)
        {
            return new List<Resource> { new Coal(25) };
        }

        protected override List<Resource> GetCost(int level)
        {
            return new List<Resource> { new Money(100 * level + 250) };
        }
    }
}