using JHP4SD.Lebeg134.Module.Resources;
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

        public override string getName()
        {
            return "Electricity";
        }

        public override Resource getNewResource(int amount)
        {
            return new Electricity(amount);
        }

    }

}
