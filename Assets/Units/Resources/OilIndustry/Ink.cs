using JHP4SD.Lebeg134.Module.Resources;
using System;
/**
* @(#) Ink.cs
*/
namespace Lebeg134.Resources.OilIndustry
{
    [Serializable]
    public class Ink : StandardResource
    {
        public Ink(int amount) : base(amount) { }
        public override string getName()
        {
            return "Ink";
        }

        public override Resource getNewResource(int amount)
        {
            return new Ink(amount);
        }

        public override double getValue()
        {
            return 18;
        }
    }
}
