

using JHP4SD.GumRuntimes;
using JHP4SD.Lebeg134.Module.Resources;
using JHP4SD.Lebeg134.Module.Structures;
using JHP4SD.Lebeg134.Units.Resources.Common;
using Lebeg134.Resources.Common;
using System;
using System.Collections.Generic;
/**
* @(#) ClearwaterLake.cs
*/
namespace Lebeg134.Structures.Lands
{
    [Serializable]
    public class ClearwaterLake : Land
    {
        public override string getName()
        {
            return "Lake";
        }

        public override Land GetNew()
        {
            return new ClearwaterLake();
        }

        public override SpriteRuntime GetSprite()
        {
            return spriteLibrary.ClearwaterLakeSprite;
        }

        protected override List<Resource> productionLevels(int level)
        {
            return new List<Resource>() { new Water(10) };
        }

        protected override List<Resource> upgradeLevelsCosts(int level)
        {
            return new List<Resource>() { new Money(100 * level) };
        }
    }

}
