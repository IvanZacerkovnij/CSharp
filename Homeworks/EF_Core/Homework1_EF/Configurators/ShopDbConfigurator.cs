using Homework1_EF.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Homework1_EF.Configurators;

public static class ShopDbConfigurator
{
    public static void Configure(DbContextOptionsBuilder options)
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json")
            .Build();
        
        var connectionString = builder.GetConnectionString("DefaultConnection"); 
        options.UseSqlServer(connectionString);
    }
}