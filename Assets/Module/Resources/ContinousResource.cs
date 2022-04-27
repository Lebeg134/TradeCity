/**
* @(#) ContinousResource.cs
*/
using Lebeg134.Module.TimeManager;
using System;

namespace Lebeg134.Module.Resources
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
        public void Reset()
        {
            stock = 0;
        }
        public void Tick()
        {
            Reset();
        }

        public void Register()
        {
            Clock.Instance.Register(this);
        }
    }
}
