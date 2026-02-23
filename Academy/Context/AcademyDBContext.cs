using Academy.Entities;
using Microsoft.EntityFrameworkCore;

namespace Academy.Context;

public class AcademyDBContext : DbContext
{
    public DbSet<Student> Students { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        optionsBuilder.UseSqlServer(
            "Server=localhost,1433;Database=AcademyDB;User Id=SA;Password=Skylex717820732!;Encrypt=False;");
    }
}