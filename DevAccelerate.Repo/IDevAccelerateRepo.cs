using System;
using System.Collections.Generic;
using System.Text;

namespace DevAccelerate.Repo
{
    public interface IDevAccelerateRepo
    {
        Repo ReadFromJson(byte[] jsonBytes);

    }
}
