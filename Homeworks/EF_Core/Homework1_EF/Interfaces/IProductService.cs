using Homework1_EF.Entities;

namespace Homework1_EF.Interfaces;

public interface IProductService
{
    IEnumerable<Product> GetAllProducts();
    Product? GetProductById(int id);
    
    void Add(Product product);
    void Update(Product product);
    void Delete(Product product);
}