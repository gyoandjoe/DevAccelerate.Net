using System;
using System.Collections.Generic;

namespace DevAccelerate.Repo
{
    public class Repo
    {
        public string AggregateName { get; set; }

        public List<Property> Properties { get; set; }

        public List<Entity> Entities { get; set; }
        
    }
}
