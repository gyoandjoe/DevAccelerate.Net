using System;
using System.Collections.Generic;
using System.Text;

namespace DevAccelerate.Repo
{
    public class DevAccelerateService
    {
        private readonly IDevAccelerateRepo _repo;

        public DevAccelerateService(IDevAccelerateRepo repo)
        {
            _repo = repo;
        }

        public Repo GetRepoFromJson(Byte[] jsonByte)
        {
            return _repo.ReadFromJson(jsonByte);
        }
    }
}
