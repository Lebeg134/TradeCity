using JHP4SD.Lebeg134.Module.Resources;
using System;
/**
* @(#) Kerosene.cs
*/
namespace Lebeg134.Resources.OilIndustry
{
    [Serializable]
    public class Kerosine : StandardResource
    {
        public Kerosine(int amount) : base(amount) { }
        public override string getName()
        {
            return "Kerosine";
        }
        public override string GetResourcepath()
        {
            return BasePath() + "commercial-airplane";
        }
        public override Resource getNewResource(int amount)
        {
            return new Kerosine(amount);
        }

        public override double getValue()
        {
            return 83.45;
        }
    }
}