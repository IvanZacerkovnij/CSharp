using Homework1.Context;
using Homework1.Entities;

namespace Homework1.Manager;

public class ShopDBManger : IDisposable
{
    private ShopDBContext Db;
    
    public ShopDBManger(ShopDBContext db)
    {
        Db = db;
        Db.Database.EnsureCreated();
    }

    private void InputProduct(
        out string name,
        out string description,
        out double price,
        out int stockQuantity,
        out int categoryId)
    {
        Console.Write("Enter Product Name: ");
        name = Console.ReadLine();
        Console.Write("Enter Product Description: ");
        description = Console.ReadLine();
        Console.Write("Enter Product Price: ");
        price = double.Parse(Console.ReadLine());
        Console.Write("Enter quantity: ");
        stockQuantity = int.Parse(Console.ReadLine());
        Console.Write("Enter Category Id: ");
        categoryId = int.Parse(Console.ReadLine());
    }
    
    public void CreateProduct()
    {
        InputProduct(
            out string name,
            out string description,
            out double price,
            out int stockQuantity,
            out int categoryId);

        Db.Products.Add(new Product()
        {
            Name = name,
            Description = description,
            Price = price,
            StockQuantity = stockQuantity,
            CategoryId = categoryId
        });
        Db.SaveChanges();
    }

    private void InputCategory(out string name)
    {
        Console.Write("Enter Category Name: ");
        name = Console.ReadLine();
    }
    
    public void CreateCategory()
    {
        InputCategory(out string name);
        
        Db.Categories.Add(new Category(){ Name =  name });
        Db.SaveChanges();
    }

    private int InputProductId()
    {
        Console.Write("Enter Product Id: ");
        return int.Parse(Console.ReadLine());
    }

    private string NewProductName()
    {
        Console.Write("Enter new Product Name: ");
        return Console.ReadLine();
    }
    
    public void UpdateProductName()
    {
        var product = Db.Products.Find(InputProductId());
        if (product == null)
        {
            throw new Exception("Product not found");
        }
        product.Name = NewProductName();
        Db.SaveChanges();
    }

    private int InputNewQuantity()
    {
        Console.Write("Enter new Quantity: ");
        return int.Parse(Console.ReadLine());
    }

    public void UpdateProductQuantity()
    {
        var product = Db.Products.Find(InputProductId());
        if (product == null)
        {
            throw new Exception("Product not found");
        }
        product.StockQuantity = InputNewQuantity();
        Db.SaveChanges();
    }

    public void RemoveProduct()
    {
        var product = Db.Products.Find(InputProductId());
        if (product == null)
        {
            throw new Exception("Product not found");
        }
        Db.Products.Remove(product);
        Db.SaveChanges();
    }

    public void ShowProductsOutOfStock()
    {
        var product = Db.Products.Where(p => p.StockQuantity == 0).ToList();
        foreach (var p in product)
        {
            Console.WriteLine($"{p.Id} - {p.Name} - {p.StockQuantity} - {p.CategoryId}");
        }
    }

    public void ShowTop3MostExpensiveProducts()
    {
        var products = Db.Products.OrderBy(p => p.Price).Take(3).ToList();
        foreach (var p in products)
        {
            Console.WriteLine($"{p.Id} - {p.Name} - {p.Price}");
        }
    }
    
    public void Dispose()
    {
        Db.Dispose();
    }
}