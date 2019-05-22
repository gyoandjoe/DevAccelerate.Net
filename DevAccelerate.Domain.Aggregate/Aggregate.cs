using System;
using System.Collections;
using System.Collections.Generic;

namespace DevAccelerate.Domain
{
    public class Aggregate
    {
        public string AggregateName { get; set; }
        public IEnumerable<Property> Properties { get; set; }
        public IEnumerable<Entity> Entities { get; set; }
        public IEnumerable<Action> Actions { get; set; }
        public IEnumerable<Event> Events { get; set; }
        public IEnumerable<EventReceiver> EventsReceiver { get; set; }
    }
}
