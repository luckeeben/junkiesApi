using System.Collections.Generic;
using junkiesApi.Models;

namespace junkiesApi.Repos
{
    public interface IPlanetRepository
    {
        IEnumerable<Planet> AllItems { get; }
        void Add(Planet item);
        Planet GetById(int id);
        bool TryDelete(int id);
    }
}
