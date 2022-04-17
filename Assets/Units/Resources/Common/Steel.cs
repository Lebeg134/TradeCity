using JHP4SD.Lebeg134.Module.Resources;
using System;
/**
* @(#) Steel.cs
*/
namespace Lebeg134.Resources.Common
{
    [Serializable]
    public class Steel : StandardResource
    {
        public Steel(int amount) : base(amount) { }

        public override string getName()
        {
            return "Steel";
        }
        public override string GetResourcepath()
        {
            return BasePath() + "i-beam";
        }

        public override Resource getNewResource(int amount)
        {
            return new Steel(amount);
        }

        public override double getValue()
        {
            return 45;
        }
    }

}
