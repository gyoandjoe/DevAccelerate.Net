using System;
using System.Collections.Generic;
using System.Text;

namespace DevAccelerate.Domain
{
    public class DevAccelerateService
    {
        private readonly IDevAccelerateDomainRepo _repo;

        public DevAccelerateService(IDevAccelerateDomainRepo repo)
        {
            _repo = repo;
        }

        public Aggregate GetAggregateFromJson(Byte[] jsonByte)
        {
            return _repo.ReadFromJson(jsonByte);
        }
    }
}
