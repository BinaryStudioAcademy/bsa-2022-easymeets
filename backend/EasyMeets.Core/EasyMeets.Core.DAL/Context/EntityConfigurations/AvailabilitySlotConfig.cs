using EasyMeets.Core.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EasyMeets.Core.DAL.Context;

public class AvailabilitySlotConfig : IEntityTypeConfiguration<AvailabilitySlot>
{
    public void Configure(EntityTypeBuilder<AvailabilitySlot> builder)
    {
        builder.Property(s => s.TeamId)
            .IsRequired();

        builder.Property(s => s.LocationType)
            .IsRequired();

        builder.Property(s => s.Name)
            .IsRequired()
            .HasMaxLength(50);

        builder.Property(s => s.WelcomeMessage)
            .IsRequired()
            .HasMaxLength(300);

        builder.Property(s => s.Link)
            .IsRequired()
            .HasMaxLength(300);

        builder.Property(s => s.Type)
            .IsRequired();

        builder.Property(s => s.Size)
            .IsRequired();

        builder.Property(s => s.Color)
            .IsRequired();

        builder.Property(s => s.Language)
            .IsRequired()
            .HasMaxLength(20);

        builder.Property(s => s.BookingsPerDay)
            .IsRequired();

        builder.Property(s => s.TimeZoneVisibility)
            .IsRequired();

        builder.Property(s => s.PasswordProtection)
            .HasMaxLength(20);

        builder.HasOne(s => s.Author)
            .WithMany(u => u.CreatedSlots)
            .HasForeignKey(s => s.CreatedBy)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(s => s.Team)
            .WithMany(t => t.AvailabilitySlots)
            .HasForeignKey(s => s.TeamId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(s => s.AdvancedSlotSettings)
            .WithOne(ad => ad.AvailabilitySlot)
            .HasForeignKey<AdvancedSlotSettings>(s => s.AvailabilitySlotId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasMany(s => s.EmailTemplates)
            .WithOne(s => s.AvailabilitySlot)
            .HasForeignKey(s => s.AvailabilitySlotId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasMany(s => s.Questions)
            .WithOne(q => q.AvailabilitySlot)
            .HasForeignKey(q => q.AvailabilitySlotId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}