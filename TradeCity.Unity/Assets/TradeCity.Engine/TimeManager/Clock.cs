/**
* @(#) Clock.cs
*/
using System;
using System.Collections.Generic;
using System.Timers;

namespace Lebeg134.Module.TimeManager
{
    public class Clock
    {
        private static Clock instance = new Clock();
        public static Clock Instance
        {
            get
            {
                return instance;
            }
            set
            {
                instance = new Clock();
                foreach (ITickable tickable in value.tickables)
                {
                    if (tickable != null)
                        instance.Register(tickable);
                }
            }
        }
        Timer timer;
        List<ITickable> tickables = new List<ITickable>();
        int interval = (int)Speed.NORMAL;
        static Clock() { }
        private Clock()
        {
            timer = new Timer();
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
            {
                Pause();
            }
            else
            {
                Start();
            }
        }
        public void SetSpeed(Speed speed)
        {
            interval = (int)speed;
        }
        void Tick(object source, ElapsedEventArgs e)
        {
            try
            {
                tickables.ForEach((tickable) => tickable.Tick());
            }
            catch (Exception)
            {
                throw;
            }
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
    public enum Speed : int
    {
        SLOW = 2000,
        NORMAL = 1000,
        FAST = 250
    }
}
