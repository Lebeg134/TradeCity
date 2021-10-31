/**
 * @(#) ContinousResource.cs
 */

namespace Lebeg134.Module.Resources
{
    public class ContinousResource : Resource
    {
        static int baseLine = 0;
        public void IncBase(int by)
        {
            baseLine += by;
        }
        public void DecBase(int by)
        {
            baseLine -= by;
        }
    }
}
