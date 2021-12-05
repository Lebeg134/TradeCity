

using JHP4SD.Lebeg134.Module.Resources;
/**
* @(#) Steel.cs
*/
namespace Lebeg134.Resources.Common
{
    public class Steel : StandardResource
    {
        public Steel(int amount) : base(amount) { }
        public override Resource getNewResource(int amount)
        {
            return new Steel(amount);
        }
    }

}
