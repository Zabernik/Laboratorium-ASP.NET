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

        void IProductService.Add(Product product)
        {
            product.Id = id++;
            _items.Add(product.Id, product);
        }
    }
}
