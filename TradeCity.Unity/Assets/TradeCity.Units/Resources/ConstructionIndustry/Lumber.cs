using System;
using TradeCity.Engine.Resources;

namespace TradeCity.Units.Resources.ConstructionIndustry
{
    [Serializable]
    public class Lumber : StandardResource
    {
        public Lumber(int amount) : base(amount) { }
        public override string GetName()
        {
            return "Lumber";
        }
        public override string GetResourcepath()
        {
            return BasePath() + "wood-beam";
        }
        public override Resource GetNewResource(int amount)
        {
            return new Lumber(amount);
        }

        public override double GetValue()
        {
            return 12.5;
        }
    }

}
