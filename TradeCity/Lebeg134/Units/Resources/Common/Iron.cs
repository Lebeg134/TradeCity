

using JHP4SD.Lebeg134.Module.Resources;
/**
* @(#) Iron.cs
*/
namespace Lebeg134.Resources.Common
{
    public class Iron : StandardResource
    {
        public Iron(int amount) : base(amount) { }
        public override Resource getNewResource(int amount)
        {
            return new Iron(amount);
        }
    }

}
