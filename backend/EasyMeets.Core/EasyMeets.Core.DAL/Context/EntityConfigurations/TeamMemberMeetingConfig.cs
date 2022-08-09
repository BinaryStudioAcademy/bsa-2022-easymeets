using EasyMeets.Core.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EasyMeets.Core.DAL.Context;

public class TeamMemberMeetingConfig : IEntityTypeConfiguration<TeamMemberMeeting>
{
    public void Configure(EntityTypeBuilder<TeamMemberMeeting> builder)
    {
        builder.HasKey(m => new { m.MemberId, m.EventId });
        
        builder.Property(m => m.MemberId)
            .IsRequired();
        
        builder.Property(m => m.EventId)
            .IsRequired();
        
        builder.Property(m => m.Priority)
            .IsRequired();

        builder.HasOne(m => m.Event)
            .WithMany(e => e.TeamMeetings)
            .HasForeignKey(m => m.EventId)
            .OnDelete(DeleteBehavior.Cascade);
        
        builder.HasOne(m => m.User)
            .WithMany(u => u.TeamMeetings)
            .HasForeignKey(m => m.MemberId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}