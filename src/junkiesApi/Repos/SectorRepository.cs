using System.Collections.Generic;
using System.Linq;
using junkiesApi.Models;

namespace junkiesApi.Repos
{
    public class SectorRepository : ISectorRepository
    {
        readonly List<Sector> _items = new List<Sector>()
        {
            new Sector { Id = 1, No = 1000, QuadrantId = 1 },
            new Sector { Id = 2, No = 1001, QuadrantId = 1 },
            new Sector { Id = 3, No = 1002, QuadrantId = 1 },
            new Sector { Id = 4, No = 1003, QuadrantId = 1 },
            new Sector { Id = 5, No = 1004, QuadrantId = 1 },
            new Sector { Id = 6, No = 1005, QuadrantId = 1 },
            new Sector { Id = 7, No = 1006, QuadrantId = 1 },
            new Sector { Id = 8, No = 1007, QuadrantId = 1 },
            new Sector { Id = 9, No = 1008, QuadrantId = 1 },
            new Sector { Id = 10, No = 1009, QuadrantId = 1 },
            new Sector { Id = 11, No = 1010, QuadrantId = 1 }
        };

        public IEnumerable<Sector> AllItems
        {
            get
            {
                return _items;
            }
        }

        public Sector GetById(int id)
        {
            return _items.FirstOrDefault(x => x.Id == id);
        }

        public void Add(Sector item)
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
