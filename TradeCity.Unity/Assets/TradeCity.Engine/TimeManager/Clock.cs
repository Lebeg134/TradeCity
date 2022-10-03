using AutSoft.UnitySupplements.EventBus;
using System.Collections.Generic;
using System.Linq;
using System.Timers;
using Injecter;

namespace TradeCity.Engine.TimeManager
{
    public class Clock
    {
        [Inject] private IEventBus _eventBus = default!;

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
            _eventBus.Invoke(new ClockStarted(this));
        }

        public void Pause()
        {
            _timer.Enabled = false;
            _eventBus.Invoke(new ClockStopped(this));
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

        public sealed class ClockStopped : IEvent
        {
            public ClockStopped(Clock stoppedClock)
            {
                StoppedClock = stoppedClock;
            }

            public Clock StoppedClock { get; }
        }

        public sealed class ClockStarted : IEvent
        {
            public ClockStarted(Clock startedClock)
            {
                StartedClock = startedClock;
            }

            public Clock StartedClock { get; }
        }
    }

    public enum Speed
    {
        Slow = 2000,
        Normal = 1000,
        Fast = 250
    }
}