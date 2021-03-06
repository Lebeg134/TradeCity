using Lebeg134.Module.Resources;
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
        public override string GetName()
        {
            return "Ink";
        }
        public override string GetResourcepath()
        {
            return BasePath() + "quill-ink";
        }
        public override Resource GetNewResource(int amount)
        {
            return new Ink(amount);
        }

        public override double GetValue()
        {
            return 18;
        }
    }
}
