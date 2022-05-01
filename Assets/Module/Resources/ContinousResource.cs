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
        private BufferResource buffer;
        public ContinousResource(int amount) : base(amount) { }

        public override Resource Gain(int amount)
        {
            return buffer.Gain(amount);
        }
        void LoadBuffer()
        {
            stock = buffer.GetStock();
            buffer.Clear();
        }
        public void Tick()
        {
            LoadBuffer();
        }
        public void Register()
        {
            Clock.Instance.Register(this);
        }
        internal class BufferResource : Resource
        {
            public BufferResource(int amount = 0) : base(amount) { }
            public override string GetName()
            {
                return "BufferResource";
            }

            public override Resource GetNewResource(int amount)
            {
                return new BufferResource(amount);
            }
            public void Clear()
            {
                stock = 0;
            }
        }
    }
}
