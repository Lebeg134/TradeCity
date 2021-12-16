

using JHP4SD.GumRuntimes;
using JHP4SD.Lebeg134.Module.Resources;
using System;
/**
* @(#) Insulation.cs
*/
namespace Lebeg134.Resources.ConstructionIndustry
{
    [Serializable]
    public class Insulation : StandardResource
    {
        public Insulation(int amount) : base(amount) { }
        public override string getName()
        {
            return "Insulation";
        }

        public override Resource getNewResource(int amount)
        {
            return new Insulation(amount);
        }

        public override SpriteRuntime getSprite()
        {
            throw new NotImplementedException();
        }

        public override double getValue()
        {
            return 22.625;
        }
    }

}
