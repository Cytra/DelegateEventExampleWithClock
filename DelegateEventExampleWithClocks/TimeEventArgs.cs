using System;

namespace DelegateEventExampleWithClocks
{
    public class TimeEventArgs : EventArgs
    {
        public int hour { get; set; }
        public int minute { get; set; }
        public int second { get; set; }
    }
}