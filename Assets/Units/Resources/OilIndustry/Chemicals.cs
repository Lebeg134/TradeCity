using Lebeg134.Module.Resources;
using System;
/**
* @(#) Chemicals.cs
*/
namespace Lebeg134.Resources.OilIndustry
{
    [Serializable]
    public class Chemicals : StandardResource
    {
        public Chemicals(int amount) : base(amount) { }
        public override string GetName()
        {
            return "Chemicals";
        }
        public override string GetResourcepath()
        {
            return BasePath() + "chemical-drop";
        }
        public override Resource getNewResource(int amount)
        {
            return new Chemicals(amount);
        }

        public override double GetValue()
        {
            return 18.75;
        }
    }

}
