using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Homework1_EF.Context;

public class ShopDbContextFactory : IDesignTimeDbContextFactory<ShopDBContext>
{
    public ShopDBContext CreateDbContext(string[] args)
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json")
            .Build();
        
        var connectionString = builder.GetConnectionString("DefaultConnection");
        var options = new DbContextOptionsBuilder<ShopDBContext>()
            .UseSqlServer(connectionString)
            .Options;

        return new ShopDBContext(options);
    }
}