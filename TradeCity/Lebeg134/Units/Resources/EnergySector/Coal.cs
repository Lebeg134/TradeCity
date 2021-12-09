

using JHP4SD.Lebeg134.Module.Resources;
/**
* @(#) Coal.cs
*/
namespace Lebeg134.Resources.EnergySector
{
    public class Coal : StandardResource
    {
        public Coal(int amount):base(amount) { }
        public override Resource getNewResource(int amount)
        {
            return new Coal(amount);
        }
    }

}
