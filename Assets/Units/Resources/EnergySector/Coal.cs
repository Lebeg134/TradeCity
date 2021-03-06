using Lebeg134.Module.Resources;
using System;
/**
* @(#) Coal.cs
*/
namespace Lebeg134.Resources.EnergySector
{
    [Serializable]
    public class Coal : StandardResource
    {
        public Coal(int amount) : base(amount) { }

        public override string GetName()
        {
            return "Coal";
        }
        public override string GetResourcepath()
        {
            return BasePath() + "coal-pile";
        }
        public override Resource GetNewResource(int amount)
        {
            return new Coal(amount);
        }

        public override double GetValue()
        {
            return 1.5;
        }
    }

}
