using System;
using System.Collections.Generic;
using System.Text;

namespace DevAccelerate.Domain
{
    public class Entity
    {
        public string EntityName { get; set; }
        public IEnumerable<Property> Properties { get; set; }        
        public IEnumerable<Action> Actions { get; set; }
    }
}
