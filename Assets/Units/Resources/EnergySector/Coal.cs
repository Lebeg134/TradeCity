using JHP4SD.Lebeg134.Module.Resources;
using System;
/**
* @(#) Coal.cs
*/
namespace Lebeg134.Resources.EnergySector
{
    [Serializable]
    public class Coal : StandardResource
    {
        public Coal(int amount):base(amount) { }

        public override string getName()
        {
            return "Coal";
        }
        public override string GetResourcepath()
        {
            return BasePath() + "coal-pile";
        }
        public override Resource getNewResource(int amount)
        {
            return new Coal(amount);
        }

        public override double getValue()
        {
            return 1.5;
        }
    }

}
