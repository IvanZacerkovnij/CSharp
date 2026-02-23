using System.Collections;
using System.Collections.Generic;

namespace shopProject;

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

    public void Sort()
    {
        _products.Sort();
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