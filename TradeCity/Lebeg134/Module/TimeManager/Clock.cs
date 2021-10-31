/**
* @(#) Clock.cs
*/
using System.Collections.Generic;
using System.Timers;

namespace Lebeg134.Module.TimeManager
{
    public class Clock
    {
        Timer timer;
        List<ITickable> tickables = new List<ITickable>();
        int interval = (int)Speed.NORMAL;
        public Clock()
        {
            timer = new Timer();
            timer.Interval = interval;
            timer.Elapsed += tick;
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
                tickable.tick();
        }
    }
    public enum Speed: int
    {
        SLOW = 2000,
        NORMAL = 1000,
        FAST = 250
    }
}
