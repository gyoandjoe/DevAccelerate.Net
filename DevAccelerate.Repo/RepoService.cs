using System;
using System.Collections.Generic;
using System.Text;

namespace DevAccelerate.Repo
{
    public class RepoService
    {
        private readonly IDevAccelerateRepo _repo;

        public RepoService(IDevAccelerateRepo repo)
        {
            _repo = repo;
        }

        public RepoAggregate GetRepoFromJson(Byte[] jsonByte)
        {
            return _repo.ReadFromJson(jsonByte);
        }
    }
}
