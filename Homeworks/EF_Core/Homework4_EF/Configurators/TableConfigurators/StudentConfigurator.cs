using Homework4_EF.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Homework4_EF.Configurators.TableConfigurators;

public class StudentConfigurator : IEntityTypeConfiguration<Student>
{
    public void Configure(EntityTypeBuilder<Student> builder)
    {
        builder.HasKey(s => s.Id);
        builder.Property(s => s.Name)
            .HasMaxLength(100)
            .IsRequired();
        builder.HasIndex(s => s.Email).IsUnique();
        builder.Property(s => s.Email)
            .HasMaxLength(100);
        builder.HasOne(s => s.Group)
            .WithMany(g => g.Students)
            .HasForeignKey(g => g.GroupId);
    }
}