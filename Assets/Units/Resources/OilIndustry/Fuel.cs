using Lebeg134.Module.Resources;
using System;
/**
* @(#) Fuel.cs
*/
namespace Lebeg134.Resources.OilIndustry
{
    [Serializable]
    public class Fuel : StandardResource
    {
        public Fuel(int amount) : base(amount) { }
        public override string GetName()
        {
            return "Fuel";
        }
        public override string GetResourcepath()
        {
            return BasePath() + "gas-pump";
        }
        public override Resource getNewResource(int amount)
        {
            return new Fuel(amount);
        }

        public override double GetValue()
        {
            return 17.25;
        }
    }

}
