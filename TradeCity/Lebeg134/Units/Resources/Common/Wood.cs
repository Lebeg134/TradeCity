

using JHP4SD.GumRuntimes;
using JHP4SD.Lebeg134.Module.Resources;
/**
* @(#) Wood.cs
*/
namespace Lebeg134.Resources.Common
{
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
    }

}
