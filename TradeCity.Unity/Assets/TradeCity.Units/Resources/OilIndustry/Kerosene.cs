using System;
using TradeCity.Engine.Resources;

/**
* @(#) Kerosene.cs
*/
namespace TradeCity.Units.Resources.OilIndustry
{
    [Serializable]
    public class Kerosine : StandardResource
    {
        public Kerosine(int amount) : base(amount) { }
        public override string GetName()
        {
            return "Kerosine";
        }
        public override string GetResourcepath()
        {
            return BasePath() + "commercial-airplane";
        }
        public override Resource GetNewResource(int amount)
        {
            return new Kerosine(amount);
        }

        public override double GetValue()
        {
            return 83.45;
        }
    }
}