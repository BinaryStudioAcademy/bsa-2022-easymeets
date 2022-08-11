using EasyMeets.Core.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EasyMeets.Core.DAL.Context;

public class AdvancedSlotSettingsConfig : IEntityTypeConfiguration<AdvancedSlotSettings>
{
    public void Configure(EntityTypeBuilder<AdvancedSlotSettings> builder)
    {
        builder.Property(s => s.ActivityType)
            .IsRequired();
        
        builder.Property(s => s.Days)
            .IsRequired();
        
        builder.Property(s => s.StartDate)
            .IsRequired();

        builder.Property(s => s.MaxNumberOfBookings)
            .IsRequired();
        
        builder.Property(s => s.PaddingMeeting)
            .IsRequired();
        
        builder.Property(s => s.MinBookingMeetingDifference)
            .IsRequired();
        
        builder.Property(s => s.Color)
            .IsRequired();
        
        builder.HasOne(s => s.AvailabilitySlot)
            .WithOne(ad => ad.AdvancedSlotSettings)
            .HasForeignKey<AvailabilitySlot>(s => s.AdvancedSlotSettingsId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}