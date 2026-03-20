using Homework1_EF.Entities;
using Microsoft.EntityFrameworkCore;

namespace Homework1_EF.Context;

public class ShopDBContext : DbContext
{
    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }

    public ShopDBContext(DbContextOptions<ShopDBContext> options) : base(options)
    {}
}