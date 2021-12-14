/**
* @(#) Clock.cs
*/
using System.Collections.Generic;
using System.Timers;

namespace JHP4SD.Lebeg134.Module.TimeManager
{
    public class Clock
    {
        private static readonly Clock _instance = new Clock();
        public static Clock Instance 
        { 
            get
            {
                return _instance;
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
            timer.Elapsed += tick;
        }
        public void initialize()
        {

        }
        public void start()
        {
            timer.Enabled = true;
        }
        public void pause()
        {
            timer.Enabled = false;
        }
        public void setSpeed(Speed speed)
        {
            interval = (int)speed;
        }
        void tick(object source, ElapsedEventArgs e)
        {
            foreach (ITickable tickable in tickables)
            {
                tickable.tick();
                if (!timer.Enabled) // Had a lot of crashes because this isn't thread safe
                    break;
            }
                
        }
        public void Register(ITickable tickable)
        {
            tickables.Add(tickable);
        }
        public void unRegister(ITickable tickable)
        {
            tickables.Remove(tickable);
        }
        public bool isEnabled()
        {
            return timer.Enabled;
        }
    }
    public enum Speed : int
    {
        SLOW = 2000,
        NORMAL = 1000,
        FAST = 250
    }
}
