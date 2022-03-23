

using JHP4SD.GumRuntimes;
using JHP4SD.Lebeg134.Module.Resources;
using JHP4SD.Lebeg134.Module.Structures;
using JHP4SD.Lebeg134.Units.Resources.Common;
using Lebeg134.Resources.OilIndustry;
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
        public override string getName()
        {
            return "Oil Field";
        }

        public override Land GetNew()
        {
            return new OilField();
        }

        public override SpriteRuntime GetSprite()
        {
            return spriteLibrary.OilFieldSprite;
        }

        protected override List<Resource> productionLevels(int level)
        {
            return new List<Resource>() { new Oil(10) };
        }

        protected override List<Resource> upgradeLevelsCosts(int level)
        {
            return new List<Resource>() { new Money(100 * level) };
        }
    }

}
