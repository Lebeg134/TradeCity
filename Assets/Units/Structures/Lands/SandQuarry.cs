using Lebeg134.Module.Resources;
using Lebeg134.Module.Structures;
using Lebeg134.Resources.ConstructionIndustry;
using Lebeg134.Units.Resources.Common;
using System;
using System.Collections.Generic;
/**
* @(#) SandQuarry.cs
*/
namespace Lebeg134.Structures.Lands
{
    [Serializable]
    public class SandQuarry : Land
    {
        public override string GetName()
        {
            return "Sand Quarry";
        }
        public override string GetResourcepath()
        {
            return GetBasePath() + "SandQuarry";
        }
        public override Land GetNew()
        {
            return new SandQuarry();
        }

        protected override List<Resource> ProductionLevels(int level)
        {
            return new List<Resource>() { new Sand(50) };
        }

        protected override List<Resource> UpgradeLevelsCosts(int level)
        {
            return new List<Resource>() { new Money(100 * level) };
        }
    }
}
