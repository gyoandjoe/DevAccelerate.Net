using System;
using System.Collections.Generic;
using System.Text;

namespace DevAccelerate.Domain
{
    public class DevAccelerateService
    {
        private readonly IDevAccelerateRepo _repo;

        public DevAccelerateService(IDevAccelerateRepo repo)
        {
            _repo = repo;
        }

        public Aggregate GetAggregateFromJson(Byte[] jsonByte)
        {
            return _repo.ReadFromJson(jsonByte);
        }
    }
}
