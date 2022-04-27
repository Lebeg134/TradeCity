using Lebeg134.Module.Resources;
using System;
/**
* @(#) Electricity.cs
*/
namespace Lebeg134.Resources.EnergySector
{
    [Serializable]
    public class Electricity : ContinousResource
    {
        public Electricity(int amount) : base(amount) { }

        public override string GetName()
        {
            return "Electricity";
        }
        public override string GetResourcepath()
        {
            return BasePath() + "electric";
        }
        public override Resource GetNewResource(int amount)
        {
            return new Electricity(amount);
        }

    }

}
