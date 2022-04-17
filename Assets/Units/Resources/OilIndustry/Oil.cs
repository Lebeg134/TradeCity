using JHP4SD.Lebeg134.Module.Resources;
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
        public override string getName()
        {
            return "Oil";
        }
        public override string GetResourcepath()
        {
            return BasePath() + "oil-drum";
        }
        public override Resource getNewResource(int amount)
        {
            return new Oil(amount);
        }

        public override double getValue()
        {
            return 20;
        }
    }
}
