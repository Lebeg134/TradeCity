using System;
using TradeCity.Engine.Resources;

/**
* @(#) Iron.cs
*/
namespace TradeCity.Units.Resources.Common
{
    [Serializable]
    public class Iron : StandardResource
    {
        public Iron(int amount) : base(amount) { }
        public override string GetName()
        {
            return "Iron";
        }
        public override string GetResourcepath()
        {
            return BasePath() + "ore";
        }
        public override Resource GetNewResource(int amount)
        {
            return new Iron(amount);
        }
        public override double GetValue()
        {
            return 10;
        }
    }

}
