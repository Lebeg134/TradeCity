using System;
using TradeCity.Engine.Resources;

/**
* @(#) ReinforcedConcrete.cs
*/
namespace TradeCity.Units.Resources.ConstructionIndustry
{
    [Serializable]
    public class ReinforcedConcrete : StandardResource
    {
        public ReinforcedConcrete(int amount) : base(amount) { }
        public override string GetName()
        {
            return "Reinforced Concrete";
        }
        public override string GetResourcepath()
        {
            return BasePath() + "bunker";
        }
        public override Resource GetNewResource(int amount)
        {
            return new ReinforcedConcrete(amount);
        }

        public override double GetValue()
        {
            return 16.125;
        }
    }

}
