using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace FluentApi.Context;

public class AcademyMigrationBuilder : IDesignTimeDbContextFactory<AcademyDbContex>
{
    public AcademyDbContex CreateDbContext(string[] args)
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json")
            .Build();
        
        var connectionString = builder.GetConnectionString("DefaultConnection");
        var options = new DbContextOptionsBuilder<AcademyDbContex>()
            .UseSqlServer(connectionString)
            .Options;

        return new AcademyDbContex(options);
    }
}