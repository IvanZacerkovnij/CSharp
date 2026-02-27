using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace MigrationEF.Context;

public class ContexDbFactory : IDesignTimeDbContextFactory<MigrationDbContext>
{
    public MigrationDbContext CreateDbContext(string[] args)
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json")
            .Build();
        
        var connectionString = builder.GetConnectionString("DefaultConnection");
        var options = new DbContextOptionsBuilder<MigrationDbContext>()
            .UseSqlServer(connectionString)
            .Options;

        return new MigrationDbContext(options);
    }
}