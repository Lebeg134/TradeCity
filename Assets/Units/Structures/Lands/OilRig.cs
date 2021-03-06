using Lebeg134.Module.Resources;
using Lebeg134.Module.Structures;
using Lebeg134.Resources.Common;
using Lebeg134.Resources.OilIndustry;
using System;
using System.Collections.Generic;
/**
* @(#) OilRig.cs
*/
namespace Lebeg134.Structures.Lands
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
            return new List<Resource>() { new Oil(20) };
        }

        protected override List<Resource> GetCost(int level)
        {
            return new List<Resource>() { new Money(100 * level) };
        }
    }

}
