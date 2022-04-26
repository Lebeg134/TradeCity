using Lebeg134.Module.Resources;
using System;
/**
* @(#) Bricks.cs
*/
namespace Lebeg134.Resources.ConstructionIndustry
{
    [Serializable]
    public class Bricks : StandardResource
    {
        public Bricks(int amount) : base(amount) { }
        public override string GetName()
        {
            return "Bricks";
        }
        public override string GetResourcepath()
        {
            return BasePath() + "brick-pile";
        }

        public override Resource GetNewResource(int amount)
        {
            return new Bricks(amount);
        }

        public override double GetValue()
        {
            return 18.75;
        }
    }

}
