using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace DelegateEventExampleWithClocks
{
    public class Clock
    {
        public int hour { get; set; }
        public int minute { get; set; }
        public int second { get; set; }

        public delegate void TimeChangeHandler(object clock, TimeEventArgs timeInfo);

        public event TimeChangeHandler timeChanged;

        public void RunClock()
        {
            while (true)
            {
                Thread.Sleep(100);
                DateTime currentTime = DateTime.Now;
                if (currentTime.Second != this.second)
                {
                    TimeEventArgs timeEventArgs = new TimeEventArgs()
                    {
                        hour = currentTime.Hour,
                        second = currentTime.Second,
                        minute = currentTime.Minute
                    };

                    if (timeChanged != null)
                    {
                        timeChanged(this, timeEventArgs);
                    }

                    this.second = currentTime.Second;
                    this.minute = currentTime.Minute;
                    this.hour = currentTime.Hour;
                }
            }
        }
    }
}
