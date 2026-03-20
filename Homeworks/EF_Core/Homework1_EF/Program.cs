using Homework1_EF.Context;
using Homework1_EF.Manager;
using Microsoft.Extensions.DependencyInjection;

namespace Homework1_EF;

class Program
{
    
    static void Main(string[] args)
    {
        var manager = new ShopDBManger();
        
        Console.WriteLine("==== Products ====");
        var products = manager.GetAllProducts();
        foreach (var product in products)
        {
            Console.WriteLine($"{product.Name} - {product.Price}");
        }
        
        Console.WriteLine("==== Categories ====");
        var categories = manager.GetAllCategories();
        foreach (var category in categories)
        {
            Console.WriteLine($"{category.Name}");
        }
    }
}