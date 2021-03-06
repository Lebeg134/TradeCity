using Lebeg134.Module.Resources;
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
        public override string GetName()
        {
            return "Paint";
        }
        public override string GetResourcepath()
        {
            return BasePath() + "paint-bucket";
        }

        public override Resource GetNewResource(int amount)
        {
            return new Paint(amount);
        }

        public override double GetValue()
        {
            return 15.625;
        }
    }
}
