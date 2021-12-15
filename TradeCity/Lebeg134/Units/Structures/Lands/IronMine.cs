

using JHP4SD.GumRuntimes;
using JHP4SD.Lebeg134.Module.Resources;
using JHP4SD.Lebeg134.Module.Structures;
using JHP4SD.Lebeg134.Units.Resources.Common;
using Lebeg134.Resources.Common;
using System.Collections.Generic;
/**
* @(#) IronMine.cs
*/
namespace Lebeg134.Structures.Lands
{
    public class IronMine : Land
    {
        public override string getName()
        {
            return "Iron Mine";
        }

        public override SpriteRuntime getSprite()
        {
            return spriteLibrary.IronMineSprite;
    }

        protected override List<Resource> productionLevels(int level)
        {
            return new List<Resource> { new Iron(10 * level + 50) };
        }

        protected override List<Resource> upgradeLevelsCosts(int level)
        {
            return new List<Resource> { new Money(100 * level + 250) };
        }
    }

}
