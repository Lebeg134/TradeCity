

using Gum.Managers;
using JHP4SD.Lebeg134.Module.Resources;
/**
* @(#) Iron.cs
*/
namespace Lebeg134.Resources.Common
{
    public class Iron : StandardResource
    {
        public Iron(int amount) : base(amount) { }

        public override TextureAddress getIcon()
        {
            throw new System.NotImplementedException();
        }

        public override string getName()
        {
            return "Iron";
        }

        public override Resource getNewResource(int amount)
        {
            return new Iron(amount);
        }
    }

}
