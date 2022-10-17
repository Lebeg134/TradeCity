using System;
using TradeCity.Engine.Resources;

namespace TradeCity.Units.Resources.OilIndustry
{
    [Serializable]
    public class Chemicals : StandardResource
    {
        public Chemicals(int amount) : base(amount)
        {
        }

        public override string GetName()
        {
            return "Chemicals";
        }

        public override string GetResourcePath()
        {
            return BasePath() + "chemical-drop";
        }

        public override Resource GetNewResource(int amount)
        {
            return new Chemicals(amount);
        }

        public override double GetValue()
        {
            return 18.75;
        }
    }
}