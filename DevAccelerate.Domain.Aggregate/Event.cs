using System;
using System.Collections.Generic;
using System.Text;

namespace DevAccelerate.Domain
{
    public class Event
    {
        public string EventName { get; set; }

        /// <summary>
        /// Action que dispara este evento
        /// </summary>
        public string TriggerByActionName { get; set; }

        public string PayloadType { get; set; }
    }
}
