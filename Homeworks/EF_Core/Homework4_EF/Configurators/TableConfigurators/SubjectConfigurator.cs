using Homework4_EF.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Homework4_EF.Configurators.TableConfigurators;

public class SubjectConfigurator : IEntityTypeConfiguration<Subject>
{
    public void Configure(EntityTypeBuilder<Subject> builder)
    {
        builder.HasKey(s => s.Id);
        
        builder.HasIndex(s => s.Name).IsUnique();
        builder.Property(s => s.Name).HasMaxLength(100).IsRequired();
    }
}