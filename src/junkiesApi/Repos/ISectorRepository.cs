using System.Collections.Generic;
using junkiesApi.Models;

namespace junkiesApi.Repos
{
    public interface ISectorRepository
    {
        IEnumerable<Sector> AllItems { get; }
        void Add(Sector item);
        Sector GetById(int id);
        bool TryDelete(int id);
    }
}
