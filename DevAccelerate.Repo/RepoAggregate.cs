using System;
using System.Collections.Generic;

namespace DevAccelerate.Repo
{
    public class RepoAggregate
    {
        public string AggregateName { get; set; }

        public List<RepoProperty> Properties { get; set; }

        public List<RepoEntity> Entities { get; set; }

        public string BDTableName { get; set; }

        public string BDSchema { get; set; }

        public string ConectionStringName { get; set; }

        public List<string> DQL { get; set; }

        public List<string> DML { get; set; }

        public string ConexionName { get; set; }



    }
}
