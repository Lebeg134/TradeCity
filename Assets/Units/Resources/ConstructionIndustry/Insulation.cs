using Lebeg134.Module.Resources;
using System;
/**
* @(#) Insulation.cs
*/
namespace Lebeg134.Resources.ConstructionIndustry
{
    [Serializable]
    public class Insulation : StandardResource
    {
        public Insulation(int amount) : base(amount) { }
        public override string GetName()
        {
            return "Insulation";
        }
        public override string GetResourcepath()
        {
            return BasePath() + "rolled-cloth";
        }
        public override Resource getNewResource(int amount)
        {
            return new Insulation(amount);
        }
        public override double GetValue()
        {
            return 22.625;
        }
    }

}
