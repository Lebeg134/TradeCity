using JHP4SD.Lebeg134.Module.Resources;
using System;
/**
* @(#) Paint.cs
*/
namespace Lebeg134.Resources.OilIndustry
{
    [Serializable]
    public class Paint : StandardResource
    {
        public Paint(int amount) : base(amount) { }
        public override string getName()
        {
            return "Paint";
        }

        public override Resource getNewResource(int amount)
        {
            return new Paint(amount);
        }

        public override double getValue()
        {
            return 15.625;
        }
    }
}
