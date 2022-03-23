/**
* @(#) ContinousResource.cs
*/
using JHP4SD.Lebeg134.Module.TimeManager;
using System;

namespace JHP4SD.Lebeg134.Module.Resources
{
    [Serializable]
    public abstract class ContinousResource : Resource, ITickable
    {
        static int baseLine = 0;
        public ContinousResource(int amount) : base(amount) { }
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

        public void register()
        {
            Clock.Instance.Register(this);
        }
    }
}
