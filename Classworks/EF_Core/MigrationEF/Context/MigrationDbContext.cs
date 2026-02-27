using Microsoft.EntityFrameworkCore;
using MigrationEF.Entity;
using Microsoft.Extensions.Configuration;

namespace MigrationEF.Context;

public class MigrationDbContext : DbContext
{
    public MigrationDbContext(DbContextOptions<MigrationDbContext> options): base(options)
    {
    }
    
    public DbSet<Student> Students { get; set; }
    public DbSet<Group> Groups { get; set; }

    // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    // {
    //     base.OnConfiguring(optionsBuilder);
    //     optionsBuilder.UseSqlServer(_connectionString);
    // }
}