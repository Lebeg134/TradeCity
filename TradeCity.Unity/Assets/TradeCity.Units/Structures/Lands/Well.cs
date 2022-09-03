using System;
using System.Collections.Generic;
using TradeCity.Engine.Resources;
using TradeCity.Engine.Structures;
using TradeCity.Units.Resources.Common;

/**
* @(#) Well.cs
*/
namespace TradeCity.Units.Structures.Lands
{
    [Serializable]
    public class Well : Land
    {
        public override string GetName()
        {
            return "Pumping Station";
        }
        public override string GetResourcepath()
        {
            return GetBasePath() + "Well";
        }
        public override Land GetNew()
        {
            return new Well();
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
