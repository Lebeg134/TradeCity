using System;
using System.Collections.Generic;
using TradeCity.Engine.Resources;
using TradeCity.Engine.Structures;
using TradeCity.Units.Resources.Common;

/**
* @(#) ClearwaterLake.cs
*/
namespace TradeCity.Units.Structures.Lands
{
    [Serializable]
    public class ClearwaterLake : Land
    {
        public override string GetName()
        {
            return "Lake";
        }
        public override string GetResourcepath()
        {
            return GetBasePath() + "Clearwaterlake";
        }

        public override Land GetNew()
        {
            return new ClearwaterLake();
        }

        protected override List<Resource> GetProduce(int level)
        {
            return new List<Resource>() { new Water(10) };
        }

        protected override List<Resource> GetCost(int level)
        {
            return new List<Resource>() { new Money(100 * level) };
        }
    }

}
