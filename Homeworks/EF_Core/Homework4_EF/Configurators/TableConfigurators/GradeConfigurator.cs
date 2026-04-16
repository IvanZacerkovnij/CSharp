using Homework4_EF.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Homework4_EF.Configurators.TableConfigurators;

public class GradeConfigurator : IEntityTypeConfiguration<Grade>
{
    public void Configure(EntityTypeBuilder<Grade> builder)
    {
        builder.HasKey(g => g.Id);
        
        builder.ToTable(t =>
            t.HasCheckConstraint("CK_Value", "[Value] BETWEEN 1 AND 12"));
        
        builder.HasOne(s => s.Student)
            .WithMany(s => s.Grades)
            .HasForeignKey(g => g.StudentId);
        builder.HasOne(s => s.Subject)
            .WithMany(s => s.Grades)
            .HasForeignKey(g => g.SubjectId);
    }
}