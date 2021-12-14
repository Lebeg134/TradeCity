

using JHP4SD.GumRuntimes;
using JHP4SD.Lebeg134.Module.Resources;
/**
* @(#) Electricity.cs
*/
namespace Lebeg134.Resources.EnergySector
{
    public class Electricity : ContinousResource
    {
        public Electricity(int amount) : base(amount) { }

        public override string getName()
        {
            return "Electricity";
        }

        public override Resource getNewResource(int amount)
        {
            return new Electricity(amount);
        }

        public override SpriteRuntime getSprite()
        {
            return spriteLibrary.ElectricitySprite;
        }
    }

}
