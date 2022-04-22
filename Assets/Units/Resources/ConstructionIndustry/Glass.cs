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
        public override string GetName()
        {
            return "Glass";
        }
        public override string GetResourcepath()
        {
            return BasePath() + "broken-bottle";
        }
        public override Resource getNewResource(int amount)
        {
            return new Glass(amount);
        }

        public override double getValue()
        {
            return 43.75;
        }
    }

}
