using System;
using System.Collections.Generic;
using TradeCity.Engine.Resources;
using TradeCity.Engine.Structures;
using TradeCity.Units.Resources.Common;
using TradeCity.Units.Resources.OilIndustry;

/**
* @(#) OilRig.cs
*/
namespace TradeCity.Units.Structures.Lands
{
    [Serializable]
    public class OilRig : Land
    {
        public override string GetName()
        {
            return "Oil Rig";
        }
        public override string GetResourcepath()
        {
            return GetBasePath() + "OilRig";
        }

        public override Land GetNew()
        {
            return new OilRig();
        }

        protected override List<Resource> GetProduce(int level)
        {
            return new List<Resource> { new Oil(20) };
        }

        protected override List<Resource> GetCost(int level)
        {
            return new List<Resource> { new Money(100 * level) };
        }
    }

}
