using System;
using System.Collections.Generic;
using System.Text;

namespace DevAccelerate.Domain
{
    public interface IDevAccelerateDomainRepo
    {
        Aggregate ReadFromJson(byte[] jsonBytes);
        
    }
}
