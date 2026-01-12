using System.Collections;
using System.Collections.Generic;

namespace ConsoleApp1;

public class Shop : IEnumerable<Product>
{
    public string Name { get; set; }
    private List<Product> _products = new List<Product>();
    
    public Shop(string name)
    {
        Name = name;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public IEnumerator<Product> GetEnumerator()
    {
        return _products.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    } 
}