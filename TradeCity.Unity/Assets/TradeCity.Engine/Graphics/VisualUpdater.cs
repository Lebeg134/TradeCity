using System.Collections.Generic;

namespace TradeCity.Engine.Graphics
{
    public class VisualUpdater : IUpdateable
    {
        public static VisualUpdater Instance
        {
            get
            {
                if (updater == null)
                    updater = new VisualUpdater();
                return updater;
            }
            set => updater = value;
        }

        private static VisualUpdater updater;
        private readonly List<IUpdateable> subscribers = new();

        public void Register(IUpdateable subscriber)
        {
            if (!subscribers.Contains(subscriber))
                subscribers.Add(subscriber);
        }
        public void UnRegister(IUpdateable subscriber)
        {
            if (subscribers.Contains(subscriber))
                subscribers.Remove(subscriber);
        }
        public void Update()
        {
            foreach (IUpdateable subscriber in subscribers)
            {
                subscriber.Update();
            }
        }
    }
}
