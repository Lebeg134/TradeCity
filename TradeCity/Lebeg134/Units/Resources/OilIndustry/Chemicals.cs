

using JHP4SD.GumRuntimes;
using JHP4SD.Lebeg134.Module.Resources;
using System;
/**
* @(#) Chemicals.cs
*/
namespace Lebeg134.Resources.OilIndustry
{
    [Serializable]
    public class Chemicals : StandardResource
    {
        public Chemicals(int amount) : base(amount) { }
        public override string getName()
        {
            return "Chemicals";
        }

        public override Resource getNewResource(int amount)
        {
            return new Chemicals(amount);
        }

        public override SpriteRuntime getSprite()
        {
            throw new NotImplementedException();
        }

        public override double getValue()
        {
            return 18.75;
        }
    }

}
