using FluentApi.Entities;
using Microsoft.EntityFrameworkCore;

namespace FluentApi.Context;

public class AcademyDbContex : DbContext
{
    public DbSet<Student> Students { get; set; }
    public DbSet<Group>  Groups { get; set; }
    public DbSet<Curator> Curators { get; set; }
    public DbSet<Subject> Subjects { get; set; }
    public DbSet<GradeSubjectStudent> GradeSubjectStudents { get; set; }
    
    public AcademyDbContex(DbContextOptions<AcademyDbContex> options) : base(options)
    {}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Student>()
            .HasOne(s => s.Group)
            .WithMany(g => g.Students)
            .HasForeignKey(s => s.GroupId);
        modelBuilder.Entity<Group>()
            .HasOne(g => g.Curator)
            .WithMany(c => c.Groups)
            .HasForeignKey(g => g.CuratorId);
        modelBuilder.Entity<Subject>()
            .Property(s => s.Name)
            .HasMaxLength(100)
            .IsRequired();
        modelBuilder.Entity<GradeSubjectStudent>()
            .HasKey(k =>
                new { k.StudentId, k.SubjectId });
        modelBuilder.Entity<GradeSubjectStudent>()
            .HasOne(s => s.Student)
            .WithMany(s => s.Subjects)
            .HasForeignKey(s => s.StudentId);
        modelBuilder.Entity<GradeSubjectStudent>()
            .HasOne(s => s.Subject)
            .WithMany(s => s.Students)
            .HasForeignKey(s => s.SubjectId);
        modelBuilder.Entity<GradeSubjectStudent>()
            .ToTable(t => 
                t.HasCheckConstraint("CK_Value","[Value] BETWEEN 1 AND 12"));
    }
}