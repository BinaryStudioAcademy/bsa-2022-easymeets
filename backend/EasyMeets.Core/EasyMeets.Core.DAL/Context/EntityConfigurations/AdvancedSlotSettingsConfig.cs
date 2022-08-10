using EasyMeets.Core.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EasyMeets.Core.DAL.Context;

public class AdvancedSlotSettingsConfig : IEntityTypeConfiguration<AdvancedSlotSettings>
{
    public void Configure(EntityTypeBuilder<AdvancedSlotSettings> builder)
    {
        builder.Property(s => s.AvailabilitySlotId)
            .IsRequired();
        
        builder.Property(s => s.ActivityType)
            .IsRequired();
        
        builder.Property(s => s.Days)
            .IsRequired();
        
        builder.Property(s => s.StartDate)
            .IsRequired();
        
        builder.Property(s => s.EndDate)
            .IsRequired();
        
        builder.Property(s => s.MaxNumberOfBookings)
            .IsRequired();
        
        builder.Property(s => s.PaddingBeforeMeeting)
            .IsRequired();
        
        builder.Property(s => s.BookingScheduleBlockingTimeMeetingInHours)
            .IsRequired();
        
        builder.Property(s => s.Color)
            .IsRequired();
    }
}