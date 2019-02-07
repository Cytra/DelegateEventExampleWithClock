using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateEventExampleWithClocks
{
    class Program
    {
        static void Main(string[] args)
        {
            var clock = new Clock();
            var visibleClock = new VisibleClock();
            visibleClock.Subscribe(clock);

            var logger = new Logger();
            logger.Subscribe(clock);
            clock.RunClock();
        }
    }
}
