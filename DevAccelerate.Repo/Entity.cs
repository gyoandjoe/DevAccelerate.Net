using System;
using System.Collections.Generic;
using System.Text;

namespace DevAccelerate.Repo
{
    public class Entity
    {
        public string EntityName { get; set; }

        public string BDTableName { get; set; }

        public List<Property> Properties { get; set; }

        
    }
}
