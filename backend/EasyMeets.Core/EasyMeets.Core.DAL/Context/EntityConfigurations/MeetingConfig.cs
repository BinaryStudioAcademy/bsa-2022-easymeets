using EasyMeets.Core.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EasyMeets.Core.DAL.Context;

public class MeetingConfig : IEntityTypeConfiguration<Meeting>
{
    public void Configure(EntityTypeBuilder<Meeting> builder)
    {
        builder.Property(m => m.CreatedBy)
            .IsRequired();
        
        builder.Property(m => m.LocationId)
            .IsRequired();
        
        builder.Property(m => m.Name)
            .IsRequired()
            .HasMaxLength(50);
        
        builder.Property(m => m.Description)
            .IsRequired()
            .HasMaxLength(50);
        
        builder.Property(m => m.Duration)
            .IsRequired();
        
        builder.Property(m => m.StartTime)
            .IsRequired();

        builder.HasOne(m => m.Location)
            .WithMany(l => l.Meetings)
            .HasForeignKey(m => m.LocationId)
            .OnDelete(DeleteBehavior.Restrict);
        
        builder.HasOne(m => m.Team)
            .WithMany(t => t.Meetings)
            .HasForeignKey(m => m.TeamId)
            .OnDelete(DeleteBehavior.Restrict);
        
        builder.HasOne(m => m.Author)
            .WithMany(u => u.CreatedMeetings)
            .HasForeignKey(m => m.CreatedBy)
            .OnDelete(DeleteBehavior.Restrict);
    }
}