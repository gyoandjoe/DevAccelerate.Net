using System;
using System.Collections.Generic;
using System.Text;

namespace DevAccelerate.Repo
{
    public class RepoService
    {
        private readonly IRepoDevAccelerateRepo _repo;

        public RepoService(IRepoDevAccelerateRepo repo)
        {
            _repo = repo;
        }

        public RepoAggregate GetRepoFromJson(Byte[] jsonByte)
        {
            return _repo.ReadFromJson(jsonByte);
        }
    }
}
