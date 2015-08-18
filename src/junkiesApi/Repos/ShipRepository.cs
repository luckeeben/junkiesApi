using System.Collections.Generic;
using System.Linq;
using junkiesApi.Models;

namespace junkiesApi.Repos
{
    public class ShipRepository : IShipRepository
    {
        readonly List<Ship> _items = new List<Ship>()
        {
            new Ship { Id = 1, SectorId = 1 } 
        };

        public IEnumerable<Ship> AllItems
        {
            get
            {
                return _items;
            }
        }

        public Ship GetById(int id)
        {
            return _items.FirstOrDefault(x => x.Id == id);
        }

        public void Add(Ship item)
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
