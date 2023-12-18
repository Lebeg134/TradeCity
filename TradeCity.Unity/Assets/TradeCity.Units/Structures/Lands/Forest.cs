using System;
using System.Collections.Generic;
using TradeCity.Engine.Resources;
using TradeCity.Engine.Structures;
using TradeCity.Engine.Utilities;
using TradeCity.Units.Resources.Common;

namespace TradeCity.Units.Structures.Lands
{
    [Serializable]
    public class Forest : Land
    {

        public override string GetName()
        {
            return "Forest";
        }

        public override string GetResourcePath()
        {
            return GetBasePath() + "Forest";
        }

        public override Land GetNew()
        {
            return new Forest();
        }

        protected override List<Resource> GetProduce(int level)
        {
            return new List<Resource> { new Wood(50 * level + 10) };
        }

        protected override List<Resource> GetCost(int level)
        {
            return new List<Resource> { new Money(100 * level + 100) };
        }
    }
}