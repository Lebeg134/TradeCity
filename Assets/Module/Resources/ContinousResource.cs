/**
* @(#) ContinousResource.cs
*/
using Lebeg134.Module.TimeManager;
using System;

namespace Lebeg134.Module.Resources
{
    [Serializable]
    public abstract class ContinousResource : Resource
    {
        private BufferResource buffer = new BufferResource();
        public ContinousResource(int amount) : base(amount) { }
        public int Buffer { get { return buffer.GetStock(); } }

        public override Resource Gain(int amount)
        {
            buffer.Gain(amount);
            return this;
        }
        void LoadBuffer()
        {
            stock = buffer.GetStock();
            buffer.Clear();
        }
        public override void Tick()
        {
            LoadBuffer();
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
