/**
* @(#) ContinousResource.cs
*/

using System;

namespace TradeCity.Engine.Resources
{
    [Serializable]
    public abstract class ContinousResource : Resource
    {
        private readonly BufferResource buffer = new();
        public ContinousResource(int amount) : base(amount) { }
        public int Buffer => buffer.GetStock();

        public override Resource Gain(int amount)
        {
            buffer.Gain(amount);
            return this;
        }

        private void LoadBuffer()
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
