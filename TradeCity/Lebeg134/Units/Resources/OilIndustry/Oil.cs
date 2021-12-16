

using JHP4SD.GumRuntimes;
using JHP4SD.Lebeg134.Module.Resources;
using System;
/**
* @(#) Oil.cs
*/
namespace Lebeg134.Resources.OilIndustry
{
    [Serializable]
    public class Oil : StandardResource
    {
        public Oil(int amount) : base(amount) { }
        public override string getName()
        {
            return "Oil";
        }

        public override Resource getNewResource(int amount)
        {
            return new Oil(amount);
        }

        public override SpriteRuntime getSprite()
        {
            throw new NotImplementedException();
        }

        public override double getValue()
        {
            return 20;
        }
    }
}
