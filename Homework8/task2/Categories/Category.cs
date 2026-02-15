using Homework8.task2.Products;
using System.Collections;

namespace Homework8.task2.Categories;

public class Category<T> : ICategory ,IEnumerable<T> where T : Product
{
    public string Name { get; }
    public Type ProductType => typeof(T);
    private readonly List<T> _products = new();
    public IEnumerable<Product> Products => _products;

    public Category(string name)
    {
        Name = name;
    }

    public void AddProduct(T product)
    {
        _products.Add(product);
    }

    public void AddProduct(Product product)
    {
        if(product is T typedProduct)
        {
            _products.Add(typedProduct);
        }
    }
    public void RemoveProduct(string name)
    {
        var product = _products.FirstOrDefault(p => p.Name == name);
        if (product != null)
        {
            _products.Remove(product);
            return;
        }
        throw new Exception($"Product {name} not found");
    }

    public IEnumerator<T> GetEnumerator()
    {
        return _products.GetEnumerator();
    }
    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}