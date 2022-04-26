using Lebeg134.Module.Resources;
using Lebeg134.Module.Structures;
using Lebeg134.Units.Resources.Common;
using Lebeg134.Resources.ConstructionIndustry;
using System;
using System.Collections.Generic;
/**
* @(#) StoneQuarry.cs
*/
namespace Lebeg134.Structures.Lands
{
    [Serializable]
    public class StoneQuarry : Land
    {
        public override string GetName()
        {
            return "Stone Quarry";
        }
        public override string GetResourcepath()
        {
            return GetBasePath() + "StoneQuarry";
        }
        public override Land GetNew()
        {
            return new StoneQuarry();
        }

        protected override List<Resource> ProductionLevels(int level)
        {
            return new List<Resource>() { new Stone(50) };
        }

        protected override List<Resource> UpgradeLevelsCosts(int level)
        {
            return new List<Resource>() { new Money(100 * level) };
        }
    }
}
