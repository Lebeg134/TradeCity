using System;
using TradeCity.Engine.Resources;

namespace TradeCity.Units.Resources.OilIndustry
{
    [Serializable]
    public class Fuel : StandardResource
    {
        public Fuel(int amount) : base(amount)
        {
        }

        public override string GetName()
        {
            return "Fuel";
        }

        public override string GetResourcePath()
        {
            return BasePath() + "gas-pump";
        }

        public override Resource GetNewResource(int amount)
        {
            return new Fuel(amount);
        }

        public override double GetValue()
        {
            return 17.25;
        }
    }
}