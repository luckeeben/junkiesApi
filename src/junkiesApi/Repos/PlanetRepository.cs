using System.Collections.Generic;
using System.Linq;
using junkiesApi.Models;

namespace junkiesApi.Repos
{
    public class PlanetRepository : IPlanetRepository
    {
        readonly List<Planet> _items = new List<Planet>()
        {
            new Planet { Id = 1, Name = "1000.1", SectorId = 1 },
            new Planet { Id = 2, Name = "1000.2", SectorId = 1 },
            new Planet { Id = 3, Name = "1000.3", SectorId = 1 },
            new Planet { Id = 4, Name = "1000.4", SectorId = 1 },
            new Planet { Id = 5, Name = "1001.1", SectorId = 2 },
            new Planet { Id = 6, Name = "1001.2", SectorId = 2 },
            new Planet { Id = 7, Name = "1001.3", SectorId = 2 },
            new Planet { Id = 8, Name = "1001.4", SectorId = 2 },
            new Planet { Id = 9, Name = "1002.1", SectorId = 3 },
            new Planet { Id = 10, Name = "1003.1", SectorId = 4 }
        };

        public IEnumerable<Planet> AllItems
        {
            get
            {
                return _items;
            }
        }

        public Planet GetById(int id)
        {
            return _items.FirstOrDefault(x => x.Id == id);
        }

        public void Add(Planet item)
        {
            item.Id = 1 + _items.Max(x => (int?)x.Id) ?? 0;
            _items.Add(item);
        }

        public bool TryDelete(int id)
        {
            var item = GetById(id);
            if (item == null)
            {
                return false;
            }
            _items.Remove(item);
            return true;
        }
    }
}
