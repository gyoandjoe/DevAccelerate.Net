using System;
using System.Collections.Generic;
using System.Text;

namespace DevAccelerate.Repo
{
    public class RepoEntity
    {
        public string EntityName { get; set; }

        public string BDTableName { get; set; }

        public List<RepoProperty> Properties { get; set; }

        
    }
}
