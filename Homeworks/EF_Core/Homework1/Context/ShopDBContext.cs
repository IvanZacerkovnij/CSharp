using Microsoft.EntityFrameworkCore;
using Homework1.Entities;

namespace Homework1.Context;

public class ShopDBContext : DbContext
{
    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        optionsBuilder.UseSqlServer(
            $"Server=localhost,1433;" +
            $"Database=ShopDB;" +
            $"User Id=SA;" +
            $"Password=********;" +
            $"Encrypt=False;");
    }
}