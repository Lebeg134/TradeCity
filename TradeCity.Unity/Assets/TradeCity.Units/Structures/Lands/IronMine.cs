using System;
using System.Collections.Generic;
using TradeCity.Engine.Resources;
using TradeCity.Engine.Structures;
using TradeCity.Units.Resources.Common;

namespace TradeCity.Units.Structures.Lands
{
    [Serializable]
    public class IronMine : Land
    {
        public override string GetName()
        {
            return "Iron Mine";
        }
        public override string GetResourcepath()
        {
            return GetBasePath() + "IronMine";
        }
        public override Land GetNew()
        {
            return new IronMine();
        }

        protected override List<Resource> GetProduce(int level)
        {
            return new List<Resource> { new Iron(10) };
        }

        protected override List<Resource> GetCost(int level)
        {
            return new List<Resource> { new Money(100 * level + 250) };
        }
    }

}
