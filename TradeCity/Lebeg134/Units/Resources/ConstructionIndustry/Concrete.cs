

using JHP4SD.GumRuntimes;
using JHP4SD.Lebeg134.Module.Resources;
using System;
/**
* @(#) Concrete.cs
*/
namespace Lebeg134.Resources.ConstructionIndustry
{
    [Serializable]
    public class Concrete : StandardResource
    {
        public Concrete(int amount) : base(amount) { }
        public override string getName()
        {
            return "Concrete";
        }

        public override Resource getNewResource(int amount)
        {
            return new Concrete(amount);
        }

        public override SpriteRuntime getSprite()
        {
            return spriteLibrary.ConcreteSprite;
        }

        public override double getValue()
        {
            return 20;
        }
    }

}
