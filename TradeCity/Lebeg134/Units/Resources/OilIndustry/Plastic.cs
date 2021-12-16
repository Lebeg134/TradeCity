

using JHP4SD.GumRuntimes;
using JHP4SD.Lebeg134.Module.Resources;
using System;
/**
* @(#) Plastic.cs
*/
namespace Lebeg134.Resources.OilIndustry
{
    [Serializable]
    public class Plastic : StandardResource
    {
        public Plastic(int amount) : base(amount) { }
        public override string getName()
        {
            return "Plastic";
        }

        public override Resource getNewResource(int amount)
        {
            return new Plastic(amount);
        }

        public override SpriteRuntime getSprite()
        {
            return spriteLibrary.PlasticSprite;
        }

        public override double getValue()
        {
            return 20.625;
        }
    }
}
