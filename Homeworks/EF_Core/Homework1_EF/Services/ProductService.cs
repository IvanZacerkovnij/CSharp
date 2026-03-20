using Homework1_EF.Entities;
using Homework1_EF.Interfaces;

namespace Homework1_EF.Services;

public class ProductService(IProductRepository _repo) : IProductService
{
    public IEnumerable<Product> GetAllProducts()
    {
        return _repo.GetAll();
    }

    public Product? GetProductById(int id)
    {
        return _repo.GetById(id);
    }

    public void Add(Product product)
    {
        _repo.Add(product);
    }

    public void Update(Product product)
    {
        _repo.Update(product);
    }

    public void Delete(Product product)
    {
        _repo.Delete(product);
    }
}