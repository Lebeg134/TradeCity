#nullable enable
using AutSoft.UnitySupplements.EventBus;
using System.Collections.Generic;
using System.Linq;
using System.Timers;
using Injecter;
using TradeCity.Engine.Core;
using System;

namespace TradeCity.Engine.TimeManager
{
    public class Clock : IClock
    {
        [Inject] 
        private readonly IEventBus _eventBus;
        
        private readonly List<ITickable> _tickables = new();

        private readonly Timer _timer = new();
        private int _interval = (int)Speed.Normal;

        public bool IsEnabled => _timer.Enabled;
        
        public Clock()
        {
            _eventBus = EngineCore.InjectEventBus();
            _timer.Interval = _interval;
            _timer.Elapsed += Tick;
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

        public void Remove(ITickable tickable)
        {
            if (!_tickables.Contains((tickable))) return;
            _tickables.Remove(tickable);
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