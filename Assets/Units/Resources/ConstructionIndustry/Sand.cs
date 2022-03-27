using JHP4SD.Lebeg134.Module.Resources;
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
        public override string getName()
        {
            return "Sand";
        }

        public override Resource getNewResource(int amount)
        {
            return new Sand(amount);
        }

        public override double getValue()
        {
            return 2;
        }
    }

}
