using JHP4SD.Lebeg134.Module.Resources;
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
        public override string getName()
        {
            return "Bricks";
        }

        public override Resource getNewResource(int amount)
        {
            return new Bricks(amount);
        }

        public override double getValue()
        {
            return 18.75;
        }
    }

}
