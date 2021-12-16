

using JHP4SD.GumRuntimes;
using JHP4SD.Lebeg134.Module.Resources;
using System;
/**
* @(#) ReinforcedConcrete.cs
*/
namespace Lebeg134.Resources.ConstructionIndustry
{
    [Serializable]
    public class ReinforcedConcrete : StandardResource
    {
        public ReinforcedConcrete(int amount) : base(amount) { }
        public override string getName()
        {
            return "Reinforced Concrete";
        }

        public override Resource getNewResource(int amount)
        {
            return new ReinforcedConcrete(amount);
        }

        public override SpriteRuntime getSprite()
        {
            return spriteLibrary.ReinforcedConcreteSprite;
        }

        public override double getValue()
        {
            return 16.125;
        }
    }

}
