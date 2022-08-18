using EasyMeets.Core.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EasyMeets.Core.DAL.Context;

public class TeamConfig : IEntityTypeConfiguration<Team>
{
    public void Configure(EntityTypeBuilder<Team> builder)
    {
        builder.Property(t => t.LogoPath)
            .IsRequired()
            .HasMaxLength(300);

        builder.Property(t => t.Name)
            .IsRequired()
            .HasMaxLength(50);

        builder.Property(t => t.PageLink)
            .IsRequired()
            .HasMaxLength(300);

        builder.Property(t => t.Description)
            .IsRequired()
            .HasMaxLength(300);
    }
}