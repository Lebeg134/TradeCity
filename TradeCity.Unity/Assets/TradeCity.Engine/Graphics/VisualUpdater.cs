using System.Collections.Generic;

namespace TradeCity.Engine.Graphics
{
    public class VisualUpdater : IUpdateable
    {
        public static VisualUpdater Instance
        {
            get => _updater ??= new VisualUpdater();
            set => _updater = value;
        }

        private static VisualUpdater _updater;
        private readonly List<IUpdateable> _subscribers = new();

        public void Register(IUpdateable subscriber)
        {
            if (!_subscribers.Contains(subscriber))
                _subscribers.Add(subscriber);
        }

        public void UnRegister(IUpdateable subscriber)
        {
            if (_subscribers.Contains(subscriber))
                _subscribers.Remove(subscriber);
        }

        public void Update()
        {
            foreach (var subscriber in _subscribers)
            {
                subscriber.Update();
            }
        }
    }
}
