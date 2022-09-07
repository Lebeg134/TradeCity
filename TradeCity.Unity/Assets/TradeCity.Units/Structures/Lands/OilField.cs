using System;
using System.Collections.Generic;
using TradeCity.Engine.Resources;
using TradeCity.Engine.Structures;
using TradeCity.Units.Resources.Common;
using TradeCity.Units.Resources.OilIndustry;

namespace TradeCity.Units.Structures.Lands
{
    [Serializable]
    public class OilField : Land
    {
        public override string GetName()
        {
            return "Oil Field";
        }
        public override string GetResourcepath()
        {
            return GetBasePath() + "OilField";
        }

        public override Land GetNew()
        {
            return new OilField();
        }

        protected override List<Resource> GetProduce(int level)
        {
            return new List<Resource> { new Oil(10) };
        }

        protected override List<Resource> GetCost(int level)
        {
            return new List<Resource> { new Money(100 * level) };
        }
    }

}
