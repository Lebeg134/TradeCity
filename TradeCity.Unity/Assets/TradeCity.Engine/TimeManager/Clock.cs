using System.Collections.Generic;
using System.Linq;
using System.Timers;

namespace TradeCity.Engine.TimeManager
{
    public class Clock
    {
        private static Clock _instance = new();

        public static Clock Instance
        {
            get => _instance;
            set
            {
                _instance = new Clock();
                foreach (var tickable in value.tickables.Where(tickable => tickable != null))
                    _instance.Register(tickable);
            }
        }

        private readonly Timer timer = new();
        private readonly List<ITickable> tickables = new();
        private int interval = (int)Speed.NORMAL;

        static Clock()
        {
        }

        private Clock()
        {
            timer.Interval = interval;
            timer.Elapsed += Tick;
        }

        public void Initialize()
        {
        }

        public void Start()
        {
            timer.Enabled = true;
        }

        public void Pause()
        {
            timer.Enabled = false;
        }

        public void Toggle()
        {
            if (timer.Enabled)
                Pause();
            else
                Start();
        }

        public void SetSpeed(Speed speed)
        {
            interval = (int)speed;
        }

        private void Tick(object source, ElapsedEventArgs e)
        {
            tickables.ForEach((tickable) => tickable.Tick());
        }

        public void Register(ITickable tickable)
        {
            tickables.Add(tickable);
        }

        public void UnRegister(ITickable tickable)
        {
            tickables.Remove(tickable);
        }

        public bool IsEnabled()
        {
            return timer.Enabled;
        }

        public void Clear()
        {
            tickables.Clear();
        }
    }

    public enum Speed
    {
        SLOW = 2000,
        NORMAL = 1000,
        FAST = 250
    }
}