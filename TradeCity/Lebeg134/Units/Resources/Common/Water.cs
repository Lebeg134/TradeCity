

using JHP4SD.Lebeg134.Module.Resources;
/**
* @(#) Water.cs
*/
namespace Lebeg134.Resources.Common
{
    public class Water : ContinousResource
    {
        public Water(int amount) : base(amount) { }
        public override Resource getNewResource(int amount)
        {
            return new Water(amount);
        }
    }

}
