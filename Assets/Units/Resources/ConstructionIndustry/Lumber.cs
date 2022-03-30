using JHP4SD.Lebeg134.Module.Resources;
using System;
/**
* @(#) Lumber.cs
*/
namespace Lebeg134.Resources.ConstructionIndustry
{
    [Serializable]
    public class Lumber : StandardResource
    {
        public Lumber(int amount) : base(amount) { }
        public override string getName()
        {
            return "Lumber";
        }

        public override Resource getNewResource(int amount)
        {
            return new Lumber(amount);
        }

        public override double getValue()
        {
            return 12.5;
        }
    }

}
