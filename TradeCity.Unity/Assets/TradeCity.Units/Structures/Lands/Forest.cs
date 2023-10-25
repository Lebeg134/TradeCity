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
        protected static List<Resource>[] GetCostStats => new[]
        {
            new List<Resource> { new Wood(100) },
            new List<Resource> { new Wood(200) },
            new List<Resource> { new Wood(300) },
            new List<Resource> { new Wood(400) },
            new List<Resource> { new Wood(500) },
            new List<Resource> { new Wood(600) },
            new List<Resource> { new Wood(700) },
            new List<Resource> { new Wood(800) },
            new List<Resource> { new Wood(900) },
            new List<Resource> { new Wood(1000) }
        };

        protected static List<Resource>[] GetProduceStats => new[]
        {
            new List<Resource> { new Wood(10) },
            new List<Resource> { new Wood(20) },
            new List<Resource> { new Wood(30) },
            new List<Resource> { new Wood(40) },
            new List<Resource> { new Wood(50) },
            new List<Resource> { new Wood(60) },
            new List<Resource> { new Wood(70) },
            new List<Resource> { new Wood(80) },
            new List<Resource> { new Wood(90) },
            new List<Resource> { new Wood(100) }
        };

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
            return GetProduceStats[LebegUtil.IndexInRange(GetProduceStats, level - 1)];
        }

        protected override List<Resource> GetCost(int level)
        {
            return new List<Resource> { new Money(100 * level + 100) };
        }
    }
}