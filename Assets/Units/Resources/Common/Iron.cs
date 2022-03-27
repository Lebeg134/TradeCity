using JHP4SD.Lebeg134.Module.Resources;
using System;
/**
* @(#) Iron.cs
*/
namespace Lebeg134.Resources.Common
{
    [Serializable]
    public class Iron : StandardResource
    {
        public Iron(int amount) : base(amount) { }
        public override string getName()
        {
            return "Iron";
        }
        public override Resource getNewResource(int amount)
        {
            return new Iron(amount);
        }
        public override double getValue()
        {
            return 10;
        }
    }

}