using Lebeg134.Module.Resources;
using System;
/**
* @(#) Oil.cs
*/
namespace Lebeg134.Resources.OilIndustry
{
    [Serializable]
    public class Oil : StandardResource
    {
        public Oil(int amount) : base(amount) { }
        public override string GetName()
        {
            return "Oil";
        }
        public override string GetResourcepath()
        {
            return BasePath() + "oil-drum";
        }
        public override Resource GetNewResource(int amount)
        {
            return new Oil(amount);
        }

        public override double GetValue()
        {
            return 20;
        }
    }
}
