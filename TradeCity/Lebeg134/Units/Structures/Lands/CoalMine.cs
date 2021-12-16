

using JHP4SD.GumRuntimes;
using JHP4SD.Lebeg134.Module.Resources;
using JHP4SD.Lebeg134.Module.Structures;
using JHP4SD.Lebeg134.Units.Resources.Common;
using Lebeg134.Resources.EnergySector;
using System;
using System.Collections.Generic;
/**
* @(#) CoalMine.cs
*/
namespace Lebeg134.Structures.Lands
{
    [Serializable]
    public class CoalMine: Land
	{
        public override string getName()
        {
            return "Coal Mine";
        }

        public override Land GetNew()
        {
            return new CoalMine();
        }

        public override SpriteRuntime GetSprite()
        {
            return spriteLibrary.CoalMineSprite;
        }

        protected override List<Resource> productionLevels(int level)
        {
            return new List<Resource> { new Coal(25 * level) };
        }

        protected override List<Resource> upgradeLevelsCosts(int level)
        {
            return new List<Resource> { new Money(100 * level+250) };
        }
    }
	
}
