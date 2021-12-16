

using JHP4SD.GumRuntimes;
using JHP4SD.Lebeg134.Module.Resources;
using JHP4SD.Lebeg134.Module.Structures;
using JHP4SD.Lebeg134.Units.Resources.Common;
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
        public override string getName()
        {
            return "Stone Quarry";
        }

        public override Land GetNew()
        {
            return new StoneQuarry();
        }

        public override SpriteRuntime GetSprite()
        {
            return spriteLibrary.StoneQuarrySprite;
        }

        protected override List<Resource> productionLevels(int level)
        {
            return new List<Resource>() { new Stone(50) };
        }

        protected override List<Resource> upgradeLevelsCosts(int level)
        {
            return new List<Resource>() { new Money(100 * level) };
        }
    }
}
