using System;
using System.Collections.Generic;
using System.Text;

namespace DevAccelerate.Domain
{
    public class Event
    {
        public string EventName { get; set; }

        public string TriggerActionName { get; set; }

        public string PayloadType { get; set; }
    }
}
