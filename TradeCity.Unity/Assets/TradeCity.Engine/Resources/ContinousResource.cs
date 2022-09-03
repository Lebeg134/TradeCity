using System;

namespace TradeCity.Engine.Resources
{
    [Serializable]
    public abstract class ContinousResource : Resource
    {
        private readonly BufferResource _buffer = new();
        public ContinousResource(int amount) : base(amount) { }
        public int Buffer => _buffer.GetStock();

        public override Resource Gain(int amount)
        {
            _buffer.Gain(amount);
            return this;
        }

        private void LoadBuffer()
        {
            _stock = _buffer.GetStock();
            _buffer.Clear();
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
                _stock = 0;
            }
        }
    }
}
