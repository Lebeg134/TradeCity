using Lebeg134.Module.Resources;
using System;
/**
* @(#) Sand.cs
*/
namespace Lebeg134.Resources.ConstructionIndustry
{
    [Serializable]
    public class Sand : StandardResource
    {
        public Sand(int amount) : base(amount) { }
        public override string GetName()
        {
            return "Sand";
        }
        public override string GetResourcepath()
        {
            return BasePath() + "powder";
        }
        public override Resource GetNewResource(int amount)
        {
            return new Sand(amount);
        }

        public override double GetValue()
        {
            return 2;
        }
    }

}
