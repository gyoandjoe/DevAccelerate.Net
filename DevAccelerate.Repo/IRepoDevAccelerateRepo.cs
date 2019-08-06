using System;
using System.Collections.Generic;
using System.Text;

namespace DevAccelerate.Repo
{
    public interface IRepoDevAccelerateRepo
    {
        RepoAggregate ReadFromJson(byte[] jsonBytes);

    }
}
