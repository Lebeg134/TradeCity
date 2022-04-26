using System.Collections.Generic;

namespace Lebeg134.Module.Graphics
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
            set
            {
                updater = value;
            }
        }
        static VisualUpdater updater;
        List<IUpdateable> subscribers = new List<IUpdateable>();

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
