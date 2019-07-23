using System;
using System.Collections.Generic;
using System.Text;

namespace DevAccelerate.Repo
{
    public class RepoProperty
    {
        public string Name { get; set; }

        public string BDType { get; set; }

        public List<string> DMLAttributes { get; set; }

        public List<string> DQLAttributes { get; set; }
    }
}
