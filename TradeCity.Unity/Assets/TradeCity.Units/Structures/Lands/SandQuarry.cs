using System;
using System.Collections.Generic;
using TradeCity.Engine.Resources;
using TradeCity.Engine.Structures;
using TradeCity.Units.Resources.Common;
using TradeCity.Units.Resources.ConstructionIndustry;

/**
* @(#) SandQuarry.cs
*/
namespace TradeCity.Units.Structures.Lands
{
    [Serializable]
    public class SandQuarry : Land
    {
        public override string GetName()
        {
            return "Sand Quarry";
        }
        public override string GetResourcepath()
        {
            return GetBasePath() + "SandQuarry";
        }
        public override Land GetNew()
        {
            return new SandQuarry();
        }

        protected override List<Resource> GetProduce(int level)
        {
            return new List<Resource>() { new Sand(50) };
        }

        protected override List<Resource> GetCost(int level)
        {
            return new List<Resource>() { new Money(100 * level) };
        }
    }
}
