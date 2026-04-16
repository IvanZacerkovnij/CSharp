
using Homework4_EF.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Homework4_EF.Configurators.TableConfigurators;

public class GroupConfigurator : IEntityTypeConfiguration<Group>
{
    public void Configure(EntityTypeBuilder<Group> builder)
    {
        builder.HasKey(g => g.Id);
        builder.Property(g => g.Name)
            .HasMaxLength(100)
            .IsRequired();
        
        builder.HasOne(g => g.Curator)
            .WithOne(g => g.Group)
            .HasForeignKey<Group>(g => g.CuratorId);
    }
}