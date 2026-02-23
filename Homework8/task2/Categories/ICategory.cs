using System.Collections;
using Homework8.task2.Products;

namespace Homework8.task2.Categories;

public interface ICategory
{
    string Name { get; }
    IEnumerable<Product> Products { get; }
    Type ProductType { get; }
    void AddProduct(Product product);
}