using Lebeg134.Module.Resources;
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

        public override string GetName()
        {
            return "Workforce";
        }
        public override string GetResourcepath()
        {
            return BasePath() + "person";
        }

        public override Resource GetNewResource(int amount)
        {
            return new Workforce(amount);
        }
    }

}
