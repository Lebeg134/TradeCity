using Lebeg134.Module.Resources;
using Lebeg134.Module.Structures;
using Lebeg134.Resources.OilIndustry;
using Lebeg134.Resources.Common;
using System;
using System.Collections.Generic;
/**
* @(#) OilField.cs
*/
namespace Lebeg134.Structures.Lands
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

        protected override List<Resource> ProductionLevels(int level)
        {
            return new List<Resource>() { new Oil(10) };
        }

        protected override List<Resource> UpgradeLevelsCosts(int level)
        {
            return new List<Resource>() { new Money(100 * level) };
        }
    }

}
