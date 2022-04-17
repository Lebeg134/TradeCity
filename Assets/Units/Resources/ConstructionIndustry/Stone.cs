using JHP4SD.Lebeg134.Module.Resources;
using System;
/**
* @(#) Stone.cs
*/
namespace Lebeg134.Resources.ConstructionIndustry
{
    [Serializable]
    public class Stone : StandardResource
    {
        public Stone(int amount) : base(amount) { }
        public override string getName()
        {
            return "Stone";
        }
        public override string GetResourcepath()
        {
            return BasePath() + "stone-block";
        }

        public override Resource getNewResource(int amount)
        {
            return new Stone(amount);
        }

        public override double getValue()
        {
            return 2;
        }
    }

}
