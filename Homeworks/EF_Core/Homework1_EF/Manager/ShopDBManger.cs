using Homework1_EF.Configurators;
using Homework1_EF.Context;
using Homework1_EF.Entities;
using Homework1_EF.Interfaces;
using Homework1_EF.Repositories;
using Homework1_EF.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Homework1_EF.Manager;

public class ShopDBManger
{
    private ServiceCollection _builder;
    private IServiceProvider _serviceProvider;
    
    public ShopDBManger()
    {
        _builder = new ServiceCollection();
        _builder.AddDbContext<ShopDBContext>(options => ShopDbConfigurator.Configure(options));

        _builder.AddScoped<IProductService, ProductService>();
        _builder.AddScoped<ICategoryService, CategoryService>();
            
        _builder.AddScoped<IProductRepository, ProductRepository>();
        _builder.AddScoped<ICategoryRepository, CategoryRepository>();
        
        _serviceProvider = _builder.BuildServiceProvider();
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
            
        var productService = _serviceProvider.GetService<IProductService>();    
        productService.Add(new Product()
        {
            Name = name,
            Description = description,
            Price = price,
            StockQuantity = stockQuantity,
            CategoryId = categoryId
        });
    }

    private void InputCategory(out string name)
    {
        Console.Write("Enter Category Name: ");
        name = Console.ReadLine();
    }
    
    public void CreateCategory()
    {
        InputCategory(out string name);
        
        var categoryService = _serviceProvider.GetService<ICategoryService>();
        categoryService.Add(new Category(){ Name =  name });
    }

    private int InputCategoryId()
    {
        Console.Write("Enter Categoty Id: ");
        return int.Parse(Console.ReadLine());
    }
    public void UpdateCategory()
    {
        var categoryService = _serviceProvider.GetService<ICategoryService>();
        var category = categoryService.GetCategoryById(InputCategoryId());
        if (category == null)
        {
            throw new Exception("Category not found");
        }
        InputCategory(out string name);
        category.Name = name;
        
        categoryService.Update(category);
    }

    public void DeleteCategory()
    {
        var categoryService = _serviceProvider.GetService<ICategoryService>();
        var category = categoryService.GetCategoryById(InputCategoryId());
        if (category == null)
        {
            throw new Exception("Category not found");
        }
        categoryService.Delete(category);
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
       var productService = _serviceProvider.GetService<IProductService>();
       var product = productService.GetProductById(InputProductId());
       if (product == null)
       {
           throw new Exception("Product not found");
       }
       product.Name = NewProductName();
       productService.Update(product);
    }

    private int InputNewQuantity()
    {
        Console.Write("Enter new Quantity: ");
        return int.Parse(Console.ReadLine());
    }

    public void UpdateProductQuantity()
    {
       var productService = _serviceProvider.GetService<IProductService>();
       var product = productService.GetProductById(InputProductId());
       if (product == null)
       {
           throw new Exception("Product not found");
       }
       product.StockQuantity = InputNewQuantity();
       productService.Update(product);
    }

    public void RemoveProduct()
    {
        var productService = _serviceProvider.GetService<IProductService>();
        var product = productService.GetProductById(InputProductId());
        if (product == null)
        {
            throw new Exception("Product not found");
        }
        productService.Delete(product);
    }

    public IEnumerable<Product> GetAllProducts()
    {
        return _serviceProvider.GetService<IProductRepository>().GetAll();
    }
    
    public IEnumerable<Category> GetAllCategories()
    {
        return _serviceProvider.GetService<ICategoryRepository>().GetAll();
    }
}