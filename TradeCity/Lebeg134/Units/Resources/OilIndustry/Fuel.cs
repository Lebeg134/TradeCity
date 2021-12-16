

using JHP4SD.GumRuntimes;
using JHP4SD.Lebeg134.Module.Resources;
using System;
/**
* @(#) Fuel.cs
*/
namespace Lebeg134.Resources.OilIndustry
{
    [Serializable]
    public class Fuel : StandardResource
    {
        public Fuel(int amount) : base(amount) { }
        public override string getName()
        {
            return "Fuel";
        }

        public override Resource getNewResource(int amount)
        {
            return new Fuel(amount);
        }

        public override SpriteRuntime getSprite()
        {
            throw new NotImplementedException();
        }

        public override double getValue()
        {
            return 17.25;
        }
    }

}
