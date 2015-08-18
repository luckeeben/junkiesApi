using System.Collections.Generic;
using junkiesApi.Models;

namespace junkiesApi.Repos
{
    public interface IShipRepository
    {
        IEnumerable<Ship> AllItems { get; }
        void Add(Ship item);
        Ship GetById(int id);
        bool TryDelete(int id);
    }
}
