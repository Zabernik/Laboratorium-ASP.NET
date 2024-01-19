using Data;
using Data.Entities;

namespace Laboratorium_3___App.Models
{
    public class EFProductService : IProductService
    {
        private readonly AppDbContext _context;

        public EFProductService(AppDbContext context)
        {
            _context = context;
        }
        public int Add(Product product)
        {
            var e = _context.Products.Add(ProductMapper.ToEntity(product));
            int id = e.Entity.Id;
            _context.SaveChanges();
            return id;
        }

        public List<Product> FindAll()
        {
            return _context.Products.Select(e => ProductMapper.FromEntity(e)).ToList();
        }

        public List<ProducerEntity> FindAllProducers()
        {
            return _context.Producers.ToList();
        }

        public Product? FindById(int id)
        {
            var find = _context.Products.Find(id);
            return find != null ? ProductMapper.FromEntity(find) : null;
        }

        public void RemoveById(int id)
        {
            var find = _context.Products.Find(id);
            if (find != null)
            {
                _context.Products.Remove(find);
                _context.SaveChanges();
            }
        }

        public void Update(Product product)
        {
            var entity = ProductMapper.ToEntity(product);
            _context.Products.Update(entity);
            _context.SaveChanges();
        }
    }
}
