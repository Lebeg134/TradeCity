

using Gum.Managers;
using JHP4SD.GumRuntimes;
using JHP4SD.GumRuntimes.LebegForms.Resources;
using JHP4SD.Lebeg134.Module.Resources;
/**
* @(#) Iron.cs
*/
namespace Lebeg134.Resources.Common
{
    public class Iron : StandardResource
    {
        public Iron(int amount) : base(amount) { }

        public override SpriteRuntime getSprite()
        {
            return spriteLibrary.IronSprite;
        }
        public override string getName()
        {
            return "Iron";
        }

        public override Resource getNewResource(int amount)
        {
            return new Iron(amount);
        }

        public override double getValue()
        {
            return 5;
        }
    }

}
