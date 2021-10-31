/**
* @(#) ContinousResource.cs
*/
using Lebeg134.Module.TimeManager;

namespace Lebeg134.Module.Resources
{
    public class ContinousResource : Resource, ITickable
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
        public void reset()
        {
            stock = 0;
        }
        public void tick()
        {
            reset();
        }
    }
}
