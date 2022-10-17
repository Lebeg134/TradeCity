using System;
using TradeCity.Engine.Resources;

namespace TradeCity.Units.Resources.Common
{
    [Serializable]
    public class Wood : StandardResource
    {
        public Wood(int amount) : base(amount)
        {
        }

        public override string GetName()
        {
            return "Wood";
        }

        public override string GetResourcePath()
        {
            return BasePath() + "log";
        }

        public override Resource GetNewResource(int amount)
        {
            return new Wood(amount);
        }

        public override double GetValue()
        {
            return 5;
        }
    }
}