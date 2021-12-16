

using JHP4SD.GumRuntimes;
using JHP4SD.Lebeg134.Module.Resources;
using JHP4SD.Lebeg134.Module.Structures;
using JHP4SD.Lebeg134.Units.Resources.Common;
using Lebeg134.Resources.ConstructionIndustry;
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
        public override string getName()
        {
            return "Sand Quarry";
        }

        public override Land GetNew()
        {
            return new SandQuarry();
        }

        public override SpriteRuntime GetSprite()
        {
            return spriteLibrary.SandQuarrySprite;
        }

        protected override List<Resource> productionLevels(int level)
        {
            return new List<Resource>() { new Sand(50 * level) };
        }

        protected override List<Resource> upgradeLevelsCosts(int level)
        {
            return new List<Resource>() { new Money(100 * level) };
        }
    }
}
