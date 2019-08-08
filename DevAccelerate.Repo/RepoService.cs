using System;
using System.Collections.Generic;
using System.Text;

namespace DevAccelerate.Repo
{
    public class RepoService
    {
        private readonly IDevAccelerateRepoRepo _repo;

        public RepoService(IDevAccelerateRepoRepo repo)
        {
            _repo = repo;
        }

        public RepoAggregate GetRepoFromJson(Byte[] jsonByte)
        {
            return _repo.ReadFromJson(jsonByte);
        }
    }
}
