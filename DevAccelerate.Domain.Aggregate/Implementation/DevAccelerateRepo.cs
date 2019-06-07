using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevAccelerate.Domain.Implementation
{
    public class DevAccelerateRepo : IDevAccelerateRepo
    {
        public Aggregate ReadFromJson(byte[] jsonBytes)
        {
            string jsonStr = Encoding.UTF8.GetString(jsonBytes);
            return JsonConvert.DeserializeObject<Aggregate>(jsonStr);
        }
    }
}
