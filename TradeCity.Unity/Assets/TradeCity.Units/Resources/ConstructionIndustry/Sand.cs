using System;
using TradeCity.Engine.Resources;

namespace TradeCity.Units.Resources.ConstructionIndustry
{
    [Serializable]
    public class Sand : StandardResource
    {
        public Sand(int amount) : base(amount)
        {
        }

        public override string GetName()
        {
            return "Sand";
        }

        public override string GetResourcePath()
        {
            return BasePath() + "powder";
        }

        public override Resource GetNewResource(int amount)
        {
            return new Sand(amount);
        }

        public override double GetValue()
        {
            return 2;
        }
    }
}