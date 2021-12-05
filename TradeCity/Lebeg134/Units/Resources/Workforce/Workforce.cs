using JHP4SD.Lebeg134.Module.Resources;
/**
* @(#) Workforce.cs
*/
namespace Lebeg134.Resources.Workforce
{
    public class Workforce : LimitResource
    {
        public Workforce(int amount) : base(amount) { }
        public override Resource getNewResource(int amount)
        {
            return new Workforce(amount);
        }
    }

}
