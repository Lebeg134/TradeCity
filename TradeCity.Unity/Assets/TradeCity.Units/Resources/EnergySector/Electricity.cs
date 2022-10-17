using System;
using TradeCity.Engine.Resources;

namespace TradeCity.Units.Resources.EnergySector
{
    [Serializable]
    public class Electricity : ContinuousResource
    {
        public Electricity(int amount) : base(amount)
        {
        }

        public override string GetName()
        {
            return "Electricity";
        }

        public override string GetResourcePath()
        {
            return BasePath() + "electric";
        }

        public override Resource GetNewResource(int amount)
        {
            return new Electricity(amount);
        }
    }
}