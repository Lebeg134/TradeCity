using System;
using TradeCity.Engine.Resources;

namespace TradeCity.Units.Resources.Common
{
    [Serializable]
    public class Steel : StandardResource
    {
        public Steel(int amount) : base(amount)
        {
        }

        public override string GetName()
        {
            return "Steel";
        }

        public override string GetResourcePath()
        {
            return BasePath() + "i-beam";
        }

        public override Resource GetNewResource(int amount)
        {
            return new Steel(amount);
        }

        public override double GetValue()
        {
            return 45;
        }
    }
}