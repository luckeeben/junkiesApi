using System.Collections.Generic;
using junkiesApi.Models;

namespace junkiesApi.Repos
{
    public interface IQuadrantRepository
    {
        IEnumerable<Quadrant> AllItems { get; }
        void Add(Quadrant item);
        Quadrant GetById(int id);
        bool TryDelete(int id);
    }
}
