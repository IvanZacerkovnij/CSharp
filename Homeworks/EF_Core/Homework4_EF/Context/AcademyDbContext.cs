using Homework4_EF.Configurators.TableConfigurators;
using Homework4_EF.Entities;
using Microsoft.EntityFrameworkCore;

namespace Homework4_EF.Context;

public class AcademyDbContext : DbContext
{
    public DbSet<Curator> Curators { get; set; }
    public DbSet<Group> Groups { get; set; }
    public DbSet<Student> Students { get; set; }
    public DbSet<Subject> Subjects { get; set; }
    public DbSet<Grade> Grades { get; set; }
    
    public  AcademyDbContext(DbContextOptions options) : base(options)
    {}

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.ApplyConfiguration(new CuratorConfigurator());
        builder.ApplyConfiguration(new GroupConfigurator());
        builder.ApplyConfiguration(new StudentConfigurator());
        builder.ApplyConfiguration(new SubjectConfigurator());
        builder.ApplyConfiguration(new GradeConfigurator());
    }
}