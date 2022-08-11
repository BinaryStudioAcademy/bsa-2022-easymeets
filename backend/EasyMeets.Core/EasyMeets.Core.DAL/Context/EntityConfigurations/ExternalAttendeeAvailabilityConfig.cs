using EasyMeets.Core.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EasyMeets.Core.DAL.Context;

public class ExternalAttendeeAvailabilityConfig : IEntityTypeConfiguration<ExternalAttendeeAvailability>
{
    public void Configure(EntityTypeBuilder<ExternalAttendeeAvailability> builder)
    {
        builder.Property(av => av.ExternalAttendeeId)
            .IsRequired();
        
        builder.Property(av => av.StartEvent)
            .IsRequired();
        
        builder.Property(av => av.EndEvent)
            .IsRequired();

        builder.HasOne(av => av.ExternalAttendee)
            .WithMany(at => at.ExternalAttendeeAvailabilities)
            .HasForeignKey(av => av.ExternalAttendeeId);
    }
}