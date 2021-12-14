using JHP4SD.GumRuntimes;
using JHP4SD.Lebeg134.Module.Resources;
/**
* @(#) Workforce.cs
*/
namespace Lebeg134.Resources.Workforce
{
    public class Workforce : LimitResource
    {
        public Workforce(int amount) : base(amount) { }

        public override string getName()
        {
            return "Workforce";
        }

        public override Resource getNewResource(int amount)
        {
            return new Workforce(amount);
        }

        public override SpriteRuntime getSprite()
        {
            return spriteLibrary.WorkforceSprite;
        }
    }

}
