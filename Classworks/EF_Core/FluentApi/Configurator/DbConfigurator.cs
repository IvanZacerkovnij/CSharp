using FluentApi.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace FluentApi.Configurator;

public static class DbConfigurator
{
    public static AcademyDbContex Configurator()
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