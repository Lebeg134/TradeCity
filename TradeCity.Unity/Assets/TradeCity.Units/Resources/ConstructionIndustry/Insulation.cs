using System;
using TradeCity.Engine.Resources;

namespace TradeCity.Units.Resources.ConstructionIndustry
{
    [Serializable]
    public class Insulation : StandardResource
    {
        public Insulation(int amount) : base(amount)
        {
        }

        public override string GetName()
        {
            return "Insulation";
        }

        public override string GetResourcePath()
        {
            return BasePath() + "rolled-cloth";
        }

        public override Resource GetNewResource(int amount)
        {
            return new Insulation(amount);
        }

        public override double GetValue()
        {
            return 22.625;
        }
    }
}