using System;
using TradeCity.Engine.Resources;

/**
* @(#) Water.cs
*/
namespace TradeCity.Units.Resources.Common
{
    [Serializable]
    public class Water : ContinousResource
    {
        public Water(int amount) : base(amount) { }

        public override string GetName()
        {
            return "Water";
        }
        public override string GetResourcepath()
        {
            return BasePath() + "water-drop";
        }

        public override Resource GetNewResource(int amount)
        {
            return new Water(amount);
        }
    }

}
