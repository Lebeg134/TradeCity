using JHP4SD.Lebeg134.Module.Resources;
using System;
/**
* @(#) Wood.cs
*/
namespace Lebeg134.Resources.Common
{
    [Serializable]
    public class Wood : StandardResource
    {
        public Wood(int amount) : base(amount) { }

        public override string GetName()
        {
            return "Wood";
        }
        public override string GetResourcepath()
        {
            return BasePath() + "log";
        }

        public override Resource getNewResource(int amount)
        {
            return new Wood(amount);
        }

        public override double getValue()
        {
            return 5;
        }
    }

}
