

using JHP4SD.GumRuntimes;
using JHP4SD.Lebeg134.Module.Resources;
using System;
/**
* @(#) Glass.cs
*/
namespace Lebeg134.Resources.ConstructionIndustry
{
    [Serializable]
    public class Glass : StandardResource
    {
        public Glass(int amount) : base(amount) { }
        public override string getName()
        {
            return "Glass";
        }

        public override Resource getNewResource(int amount)
        {
            return new Glass(amount);
        }

        public override SpriteRuntime getSprite()
        {
            return spriteLibrary.GlassSprite;
        }

        public override double getValue()
        {
            return 43.75;
        }
    }

}
