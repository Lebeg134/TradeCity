/**
 * @(#) Gas.cs
 */

using TradeCity.Engine.Resources;

namespace TradeCity.Units.Resources.OilIndustry
{
    public class Gas: ContinuousResource
    {
        public Gas(int amount) : base(amount){}

        public override string GetName()
        {
            return "Gas";
        }

        public override Resource GetNewResource(int amount)
        {
            return new Gas(amount);
        }
    }
}