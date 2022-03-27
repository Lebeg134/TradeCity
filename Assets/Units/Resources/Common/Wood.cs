

using JHP4SD.GumRuntimes;
using JHP4SD.Lebeg134.Module.Resources;
using System;
/**
* @(#) Wood.cs
*/
namespace Lebeg134.Resources.Common
{
    [Serializable]
    public class Wood : StandardResource
    {
        public Wood(int amount) : base(amount) { }

        public override string getName()
        {
            return "Wood";
        }

        public override Resource getNewResource(int amount)
        {
            return new Wood(amount);
        }

        public override SpriteRuntime getSprite()
        {
            return spriteLibrary.WoodSprite;
        }

        public override double getValue()
        {
            return 5;
        }
    }

}
