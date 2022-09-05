using EasyMeets.Core.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EasyMeets.Core.DAL.Context;

public class ExternalAttendeeConfig : IEntityTypeConfiguration<ExternalAttendee>
{
    public void Configure(EntityTypeBuilder<ExternalAttendee> builder)
    {
        builder.Property(at => at.AvailabilitySlotId)
            .IsRequired();
        
        builder.Property(at => at.Name)
            .IsRequired()
            .HasMaxLength(50);
        
        builder.Property(at => at.Email)
            .IsRequired()
            .HasMaxLength(50);
        
        builder.Property(at => at.TimeZoneName)
            .IsRequired()
            .HasMaxLength(50);
            
        builder.Property(at => at.TimeZoneValue)
            .IsRequired()
            .HasMaxLength(50);

        builder.HasOne(at => at.AvailabilitySlot)
            .WithMany(s => s.ExternalAttendees)
            .HasForeignKey(at => at.AvailabilitySlotId);

        builder.HasOne(at => at.Meeting)
            .WithMany(s => s.ExternalAttendees)
            .HasForeignKey(at => at.MeetingId);
    }
}