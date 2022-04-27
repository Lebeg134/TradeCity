using Lebeg134.Module.Resources;
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
        public override string GetName()
        {
            return "Stone";
        }
        public override string GetResourcepath()
        {
            return BasePath() + "stone-block";
        }

        public override Resource GetNewResource(int amount)
        {
            return new Stone(amount);
        }

        public override double GetValue()
        {
            return 2;
        }
    }

}
