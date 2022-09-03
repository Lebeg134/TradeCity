using System;
using TradeCity.Engine.Resources;

namespace TradeCity.Units.Resources.Common
{
    [Serializable]
    public class Money : StandardResource
    {
        public Money(int amount) : base(amount) { }

        public override string GetName()
        {
            return "Money";
        }
        public override string GetResourcepath()
        {
            return BasePath() + "money-stack";
        }

        public override Resource GetNewResource(int amount)
        {
            return new Money(amount);
        }

        public override double GetValue()
        {
            return 1;
        }
    }
}
