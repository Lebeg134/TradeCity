using JHP4SD.Lebeg134.Module.Resources;
using System;
/**
* @(#) Concrete.cs
*/
namespace Lebeg134.Resources.ConstructionIndustry
{
    [Serializable]
    public class Concrete : StandardResource
    {
        public Concrete(int amount) : base(amount) { }
        public override string GetName()
        {
            return "Concrete";
        }
        public override string GetResourcepath()
        {
            return BasePath() + "concrete-bag";
        }
        public override Resource getNewResource(int amount)
        {
            return new Concrete(amount);
        }

        public override double getValue()
        {
            return 20;
        }
    }

}
