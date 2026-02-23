using Homework8.task2.Products;
using Homework8.task2.Categories;
using System.Collections;

namespace Homework8.task2;

public class Shop : IEnumerable<ICategory>
{
    private List<ICategory> _categories = new();

    public void AddCategory<T>(string name) where T : Product
    {
        _categories.Add(new Category<T>(name));
    }
    public void RemoveCategory(string name)
    {
        var category = _categories.FirstOrDefault(c => c.Name == name);
        if (category != null)
        {
            _categories.Remove(category);
            return;
        }
        throw new Exception($"Category {name} not found");
    }

    public void AddProduct(string categoryName , Product product)
    {
        var category = _categories.FirstOrDefault(c => c.Name == categoryName);
        if (category != null)
        {
            category.AddProduct(product);
            return;
        }
        throw new Exception($"Category {categoryName} found");
    }

    public void ShowCategories()
    {
        foreach (var category in _categories)
        {
            Console.WriteLine($"{category.Name}:");
            foreach (var item in category.Products)
            {
                Console.WriteLine("  " + item);
            }
        }
    }

    public void ShowProductsPriceBetween(double minPrice, double maxPrice)
    {
        foreach (var category in _categories)
        {
            foreach (var item in category.Products)
            {
                if (item.Price >= minPrice && item.Price <= maxPrice)
                {
                    Console.WriteLine(category.Name + ":");
                    Console.WriteLine($"  {item}");
                }
            }
        }
    }

    public void ShowProductAddedLastMonth()
    {
        foreach (var category in _categories)
        {
            foreach (var item in category.Products)
            {
                if (DateTime.Now.Month - item.AddedAt.Month <= 1)
                {
                    Console.WriteLine(category.Name + ":");
                    Console.WriteLine($"  {item}");
                }
            }
        }
    }
    
    public IEnumerator<ICategory> GetEnumerator()
    {
        return _categories.GetEnumerator();
    }
    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}