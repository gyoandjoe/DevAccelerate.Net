using System;
using System.Collections.Generic;
using System.Text;

namespace DevAccelerate.Repo
{
    public interface IDevAccelerateRepo
    {
        RepoAggregate ReadFromJson(byte[] jsonBytes);

    }
}
