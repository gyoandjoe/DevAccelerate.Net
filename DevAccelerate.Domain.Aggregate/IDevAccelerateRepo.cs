using System;
using System.Collections.Generic;
using System.Text;

namespace DevAccelerate.Domain
{
    public interface IDevAccelerateRepo
    {
        Aggregate ReadFromJson(byte[] jsonBytes);
        
    }
}
