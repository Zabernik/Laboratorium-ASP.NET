namespace Laboratorium_3___App.Models
{
    public interface IProductService
    {
        void Add(Product product);
        void RemoveById(int id);
        void Update(Product product);
        List<Product> FindAll();
        Product? FindById(int id);
    }
}
