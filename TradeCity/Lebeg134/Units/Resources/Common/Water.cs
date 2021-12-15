

using JHP4SD.GumRuntimes;
using JHP4SD.Lebeg134.Module.Resources;
using System;
/**
* @(#) Water.cs
*/
namespace Lebeg134.Resources.Common
{
    [Serializable]
    public class Water : ContinousResource
    {
        public Water(int amount) : base(amount) { }

        public override string getName()
        {
            return "Water";
        }

        public override Resource getNewResource(int amount)
        {
            return new Water(amount);
        }

        public override SpriteRuntime getSprite()
        {
            return spriteLibrary.WaterSprite;
        }
    }

}
