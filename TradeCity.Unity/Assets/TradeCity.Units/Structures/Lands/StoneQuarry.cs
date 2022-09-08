using System;
using System.Collections.Generic;
using TradeCity.Engine.Resources;
using TradeCity.Engine.Structures;
using TradeCity.Units.Resources.Common;
using TradeCity.Units.Resources.ConstructionIndustry;

namespace TradeCity.Units.Structures.Lands
{
    [Serializable]
    public class StoneQuarry : Land
    {
        public override string GetName()
        {
            return "Stone Quarry";
        }

        public override string GetResourcepath()
        {
            return GetBasePath() + "StoneQuarry";
        }

        public override Land GetNew()
        {
            return new StoneQuarry();
        }

        protected override List<Resource> GetProduce(int level)
        {
            return new List<Resource> { new Stone(50) };
        }

        protected override List<Resource> GetCost(int level)
        {
            return new List<Resource> { new Money(100 * level) };
        }
    }
}