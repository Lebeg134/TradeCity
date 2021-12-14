using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JHP4SD.Lebeg134.Module.Graphics
{
    public class VisualUpdater: IUpdateable
    {
        public static VisualUpdater Instance
        {
            get
            {
                if (_updater == null)
                    _updater = new VisualUpdater();
                return _updater;
            }
            set
            {
                _updater = value;
            }
        }
        static VisualUpdater _updater;
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
