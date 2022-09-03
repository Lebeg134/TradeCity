using System;
using TradeCity.Engine.Resources;

/**
* @(#) Glass.cs
*/
namespace TradeCity.Units.Resources.ConstructionIndustry
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
        public override Resource GetNewResource(int amount)
        {
            return new Glass(amount);
        }

        public override double GetValue()
        {
            return 43.75;
        }
    }

}
