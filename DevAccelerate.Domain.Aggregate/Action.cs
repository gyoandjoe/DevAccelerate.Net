using System;
using System.Collections.Generic;
using System.Text;

namespace DevAccelerate.Domain
{
    public class Action
    {
        public string ActionName { get; set; }

        public string ReturnType { get; set; }

        public IEnumerable<Parameter> Parameters { get; set; }
    }
}
