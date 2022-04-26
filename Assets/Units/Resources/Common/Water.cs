using Lebeg134.Module.Resources;
using System;
/**
* @(#) Water.cs
*/
namespace Lebeg134.Resources.Common
{
    [Serializable]
    public class Water : ContinousResource
    {
        public Water(int amount) : base(amount) { }

        public override string GetName()
        {
            return "Water";
        }
        public override string GetResourcepath()
        {
            return BasePath() + "water-drop";
        }

        public override Resource getNewResource(int amount)
        {
            return new Water(amount);
        }
    }

}
