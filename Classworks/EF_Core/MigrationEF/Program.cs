using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using MigrationEF.Context;
using MigrationEF.Entity;

namespace MigrationEF;

class Program
{
    static void Main(string[] args)
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json")
            .Build();
        
        var connectionString = builder.GetConnectionString("DefaultConnection");
        var options = new DbContextOptionsBuilder<MigrationDbContext>()
            .UseSqlServer(connectionString)
            .Options;
        using (var db = new MigrationDbContext(options))
        {
            db.Groups.Add(new Group() { Name = "231" });
            db.SaveChanges();
            
            db.Students.Add(new Student(){Name = "Ivan", Age = 20, Gender = "Male" , GroupId = 1 });
            db.Students.Add(new Student(){Name = "Maksim", Age = 20, Gender = "Male", GroupId = 2 });
            db.SaveChanges();
        }
    }
}