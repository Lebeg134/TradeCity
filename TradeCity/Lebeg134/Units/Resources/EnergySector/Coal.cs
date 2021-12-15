

using JHP4SD.GumRuntimes;
using JHP4SD.Lebeg134.Module.Resources;
/**
* @(#) Coal.cs
*/
namespace Lebeg134.Resources.EnergySector
{
    public class Coal : StandardResource
    {
        public Coal(int amount):base(amount) { }

        public override string getName()
        {
            return "Coal";
        }

        public override Resource getNewResource(int amount)
        {
            return new Coal(amount);
        }

        public override SpriteRuntime getSprite()
        {
            return spriteLibrary.CoalSprite;
        }

        public override double getValue()
        {
            return 1.5;
        }
    }

}
