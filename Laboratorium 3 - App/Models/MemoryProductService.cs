using Data;
using Data.Entities;

namespace Laboratorium_3___App.Models
{
    public class MemoryProductService : IProductService
    {
        private readonly Dictionary<int, Product> _items = new Dictionary<int, Product>();
        private int id = 1;

        public List<Product> FindAll()
        {
            return _items.Values.ToList();
        }

        public List<ProducerEntity> FindAllProducers()
        {
            using (var _context = new AppDbContext())
            return _context.Producers.ToList();
        }

        public Product? FindById(int id)
        {
            return _items[id];
        }

        public void RemoveById(int id)
        {
            _items.Remove(id);
        }

        public void Update(Product car)
        {
            if (_items.ContainsKey(car.Id))
            {
                _items[car.Id] = car;
            }
        }

        int IProductService.Add(Product product)
        {
            int id = _items.Keys.Count != 0 ? _items.Keys.Max() : 0;
            product.Id = id + 1;
            _items.Add(product.Id, product);
            return product.Id;

            //product.Id = id++;
            //_items.Add(product.Id, product);
        }
    }
}
