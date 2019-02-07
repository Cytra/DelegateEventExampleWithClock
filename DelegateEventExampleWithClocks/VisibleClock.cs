﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateEventExampleWithClocks
{
    public class VisibleClock
    {
        public void Subscribe(Clock theClock)
        {
            theClock.timeChanged += new Clock.TimeChangeHandler(newTime);
        }

        private void newTime(object clock, TimeEventArgs timeInfo)
        {
            Console.WriteLine("{0}:{1}:{2}", timeInfo.hour.ToString(), timeInfo.minute.ToString(), timeInfo.second.ToString());
        }
    }
}
