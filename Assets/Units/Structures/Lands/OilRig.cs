using JHP4SD.Lebeg134.Module.Resources;
using JHP4SD.Lebeg134.Module.Structures;
using JHP4SD.Lebeg134.Units.Resources.Common;
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
        public override string getName()
        {
            return "Oil Rig";
        }

        public override Land GetNew()
        {
            return new OilRig();
        }

        protected override List<Resource> productionLevels(int level)
        {
            return new List<Resource>() { new Oil(20) };
        }

        protected override List<Resource> upgradeLevelsCosts(int level)
        {
            return new List<Resource>() { new Money(100 * level) };
        }
    }

}
