using System;
using TradeCity.Engine.Resources;

namespace TradeCity.Units.Resources.Common
{
    [Serializable]
    public class Water : ContinuousResource
    {
        public Water(int amount) : base(amount)
        {
        }

        public override string GetName()
        {
            return "Water";
        }

        public override string GetResourcePath()
        {
            return BasePath() + "water-drop";
        }

        public override Resource GetNewResource(int amount)
        {
            return new Water(amount);
        }
    }
}