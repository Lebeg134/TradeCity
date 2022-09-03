using System;
using TradeCity.Engine.Resources;

/**
* @(#) Plastic.cs
*/
namespace TradeCity.Units.Resources.OilIndustry
{
    [Serializable]
    public class Plastic : StandardResource
    {
        public Plastic(int amount) : base(amount) { }
        public override string GetName()
        {
            return "Plastic";
        }
        public override string GetResourcepath()
        {
            return BasePath() + "cubes";
        }

        public override Resource GetNewResource(int amount)
        {
            return new Plastic(amount);
        }

        public override double GetValue()
        {
            return 20.625;
        }
    }
}
