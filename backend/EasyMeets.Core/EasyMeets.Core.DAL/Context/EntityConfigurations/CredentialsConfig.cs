using EasyMeets.Core.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EasyMeets.Core.DAL.Context;

public class CredentialsConfig : IEntityTypeConfiguration<Credentials>
{
    public void Configure(EntityTypeBuilder<Credentials> builder)
    {
        builder.Property(cr => cr.UserId).IsRequired();

        builder
            .HasOne(cr => cr.User)
            .WithMany(u => u.Credentials)
            .HasForeignKey(cr => cr.UserId);
    }
}