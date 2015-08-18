using System.Collections.Generic;
using System.Linq;
using junkiesApi.Models;

namespace junkiesApi.Repos
{
    public class QuadrantRepository : IQuadrantRepository
    {
        readonly List<Quadrant> _items = new List<Quadrant>()
        {
            new Quadrant { Id = 1, Name = "Alpha" },
            new Quadrant { Id = 2, Name = "Beta" }
        };

        public IEnumerable<Quadrant> AllItems
        {
            get
            {
                return _items;
            }
        }

        public Quadrant GetById(int id)
        {
            return _items.FirstOrDefault(x => x.Id == id);
        }

        public void Add(Quadrant item)
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
