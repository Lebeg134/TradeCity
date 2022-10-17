using System;
using TradeCity.Engine.Resources;

namespace TradeCity.Units.Resources.ConstructionIndustry
{
    [Serializable]
    public class Concrete : StandardResource
    {
        public Concrete(int amount) : base(amount)
        {
        }

        public override string GetName()
        {
            return "Concrete";
        }

        public override string GetResourcePath()
        {
            return BasePath() + "concrete-bag";
        }

        public override Resource GetNewResource(int amount)
        {
            return new Concrete(amount);
        }

        public override double GetValue()
        {
            return 20;
        }
    }
}