using System.Collections.Generic;
using System.Linq;
using System.Timers;

namespace TradeCity.Engine.TimeManager
{
    public class Clock
    {
        private static Clock _instance = new();
        private readonly List<ITickable> _tickables = new();

        private readonly Timer _timer = new();
        private int _interval = (int)Speed.Normal;

        static Clock()
        {
        }

        private Clock()
        {
            _timer.Interval = _interval;
            _timer.Elapsed += Tick;
        }

        public static Clock Instance
        {
            get => _instance;
            set
            {
                _instance = new Clock();
                foreach (var tickable in value._tickables.Where(tickable => tickable != null))
                    _instance.Register(tickable);
            }
        }

        public void Initialize()
        {
        }

        public void Start()
        {
            _timer.Enabled = true;
        }

        public void Pause()
        {
            _timer.Enabled = false;
        }

        public void Toggle()
        {
            if (_timer.Enabled)
                Pause();
            else
                Start();
        }

        public void SetSpeed(Speed speed)
        {
            _interval = (int)speed;
        }

        private void Tick(object source, ElapsedEventArgs e)
        {
            _tickables.ForEach(tickable => tickable.Tick());
        }

        public void Register(ITickable tickable)
        {
            _tickables.Add(tickable);
        }

        public void UnRegister(ITickable tickable)
        {
            _tickables.Remove(tickable);
        }

        public bool IsEnabled()
        {
            return _timer.Enabled;
        }

        public void Clear()
        {
            _tickables.Clear();
        }
    }

    public enum Speed
    {
        Slow = 2000,
        Normal = 1000,
        Fast = 250
    }
}