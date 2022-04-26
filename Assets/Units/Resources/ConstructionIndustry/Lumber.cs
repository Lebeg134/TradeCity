using Lebeg134.Module.Resources;
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
        public override string GetName()
        {
            return "Lumber";
        }
        public override string GetResourcepath()
        {
            return BasePath() + "wood-beam";
        }
        public override Resource getNewResource(int amount)
        {
            return new Lumber(amount);
        }

        public override double GetValue()
        {
            return 12.5;
        }
    }

}
