using EasyMeets.Core.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EasyMeets.Core.DAL.Context;

public class UserConfig : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.Property(u => u.Name)
            .IsRequired()
            .HasMaxLength(50);

        builder.Property(u => u.Email)
            .IsRequired()
            .HasMaxLength(50);
        
        builder.Property(u => u.PhoneNumber)
            .HasMaxLength(10);
        
        builder.Property(u => u.ImagePath)
            .HasMaxLength(300);
        
        builder.Property(u => u.Country)
            .HasMaxLength(20);
        
        builder.Property(u => u.TimeZone)
            .HasMaxLength(10);
    }
}