using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevAccelerate.Repo.Implementation
{
    public class DevAccelerateRepo : IRepoDevAccelerateRepo
    {
        public RepoAggregate ReadFromJson(byte[] jsonBytes)
        {
            string jsonStr = Encoding.UTF8.GetString(jsonBytes);
            return JsonConvert.DeserializeObject<RepoAggregate>(jsonStr);
        }
    }
}
