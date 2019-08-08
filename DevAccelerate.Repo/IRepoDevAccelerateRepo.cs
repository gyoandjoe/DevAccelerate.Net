using System;
using System.Collections.Generic;
using System.Text;

namespace DevAccelerate.Repo
{
    public interface IDevAccelerateRepoRepo
    {
        RepoAggregate ReadFromJson(byte[] jsonBytes);

    }
}
