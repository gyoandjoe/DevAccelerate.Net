using System;
using System.Collections.Generic;
using System.Text;

namespace DevAccelerate.Domain
{
    /// <summary>
    /// Eventos externos a el raiz agregado a los que se esta subscrito el raiz agregado
    /// </summary>
    public class Subscriber
    {
        public string FromAggregate { get; set; }

        public string ExternalEventName { get; set; }

        public string ActionNameToExecute { get; set; }

        public string PayloadType { get; set; }
    }
}
