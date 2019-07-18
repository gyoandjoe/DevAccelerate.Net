using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevAccelerate.Repo.Implementation
{
    public class DevAccelerateRepo : IDevAccelerateRepo
    {
        public Repo ReadFromJson(byte[] jsonBytes)
        {
            string jsonStr = Encoding.UTF8.GetString(jsonBytes);
            return JsonConvert.DeserializeObject<Repo>(jsonStr);
        }
    }
}
