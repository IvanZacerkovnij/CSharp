using Homework4_EF.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Homework4_EF.Configurators.TableConfigurators;

public class CuratorConfigurator : IEntityTypeConfiguration<Curator>
{
    public void Configure(EntityTypeBuilder<Curator> builder)
    {
        builder.HasKey(c => c.Id);
        builder.Property(c => c.Name).IsRequired().HasMaxLength(100);
        builder.Property(c => c.Surname).IsRequired().HasMaxLength(100);
    }
}