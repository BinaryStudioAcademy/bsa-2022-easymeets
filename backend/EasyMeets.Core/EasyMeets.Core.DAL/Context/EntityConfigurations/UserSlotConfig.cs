using EasyMeets.Core.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EasyMeets.Core.DAL.Context;

public class UserSlotConfig : IEntityTypeConfiguration<UserSlot>
{
    public void Configure(EntityTypeBuilder<UserSlot> builder)
    {
        builder.Property(us => us.UserId)
            .IsRequired();
        
        builder.Property(us => us.AvailabilitySlotId)
            .IsRequired();

        builder.HasOne(us => us.User)
            .WithMany(u => u.Slots)
            .HasForeignKey(us => us.UserId);
        
        builder.HasOne(us => us.AvailabilitySlot)
            .WithMany(s => s.Members)
            .HasForeignKey(us => us.AvailabilitySlotId);
    }
}