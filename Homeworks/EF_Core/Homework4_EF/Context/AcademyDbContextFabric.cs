using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Homework4_EF.Context;

public class AcademyDbContextFabric : IDesignTimeDbContextFactory<AcademyDbContext>
{
    public AcademyDbContext CreateDbContext(string[] args)
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json")
            .Build();
        string connectionSting = builder.GetConnectionString("DefaultConnection");
        var options = new DbContextOptionsBuilder<AcademyDbContext>()
            .UseSqlServer(connectionSting)
            .Options;
        return new AcademyDbContext(options);
    }
}