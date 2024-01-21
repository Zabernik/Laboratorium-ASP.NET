using Data.Entities;

namespace Laboratorium_3___App.Models
{
    public class ProductMapper
    {
        public static Product FromEntity(ProductEntity entity)
        {
            return new Product()
            {
                Id = entity.Id,
                Name = entity.Name,
                Price = (float)entity.Price,
                DateOfProduction = entity.DateOfProduction,
                Description = entity.Description,
                Category = (Category)entity.Category,
                ProducerName = (string)entity.ProducerName,
            };
        }

        public static ProductEntity ToEntity(Product product)
        {
            return new ProductEntity()
            {
                Id = product.Id,
                Name = product.Name,
                DateOfProduction = product.DateOfProduction,
                Description = product.Description,
                Price = (decimal)product.Price,
                Category = (int)product.Category,
                ProducerName = product.ProducerName
            };
        }
    }
}
