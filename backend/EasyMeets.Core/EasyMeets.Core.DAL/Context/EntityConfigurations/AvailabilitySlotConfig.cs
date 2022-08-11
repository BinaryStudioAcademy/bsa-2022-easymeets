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
        
        builder.Property(s => s.LocationId)
            .IsRequired();
        
        builder.Property(s => s.Name)
            .IsRequired()
            .HasMaxLength(50);
        
        builder.Property(s => s.Description)
            .IsRequired()
            .HasMaxLength(300);
        
        builder.Property(s => s.Link)
            .IsRequired()
            .HasMaxLength(300);

        builder.Property(s => s.Type)
            .IsRequired();
        
        builder.Property(s => s.Size)
            .IsRequired();
        
        builder.Property(s => s.Frequency)
            .IsRequired();

        builder.HasOne(s => s.Author)
            .WithMany(u => u.CreatedSlots)
            .HasForeignKey(s => s.CreatedBy)
            .OnDelete(DeleteBehavior.Restrict);
        
        builder.HasOne(s => s.Team)
            .WithMany(t => t.AvailabilitySlots)
            .HasForeignKey(s => s.TeamId)
            .OnDelete(DeleteBehavior.Restrict);
        
        builder.HasOne(s => s.Location)
            .WithMany(l => l.AvailabilitySlots)
            .HasForeignKey(s => s.LocationId)
            .OnDelete(DeleteBehavior.Restrict);
        
        builder.HasOne(s => s.AdvancedSlotSettings)
            .WithOne(ad => ad.AvailabilitySlot)
            .HasForeignKey<AdvancedSlotSettings>(s => s.AvailabilitySlotId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}