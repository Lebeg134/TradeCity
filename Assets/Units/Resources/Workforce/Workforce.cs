using JHP4SD.Lebeg134.Module.Resources;
using System;
/**
* @(#) Workforce.cs
*/
namespace Lebeg134.Resources.Workforce
{
    [Serializable]
    public class Workforce : LimitResource
    {
        public Workforce(int amount) : base(amount) { }

        public override string getName()
        {
            return "Workforce";
        }

        public override Resource getNewResource(int amount)
        {
            return new Workforce(amount);
        }
    }

}
