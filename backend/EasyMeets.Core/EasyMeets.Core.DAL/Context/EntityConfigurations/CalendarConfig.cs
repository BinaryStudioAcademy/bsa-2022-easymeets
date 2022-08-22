using EasyMeets.Core.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EasyMeets.Core.DAL.Context;

public class CalendarConfig : IEntityTypeConfiguration<Calendar>
{
    public void Configure(EntityTypeBuilder<Calendar> builder)
    {
        builder.Property(c => c.UserId)
            .IsRequired();
        
        builder.Property(c => c.AccessToken)
            .IsRequired()
            .HasMaxLength(255);
        
        builder.Property(c => c.RefreshToken)
            .HasMaxLength(255)
            .IsRequired();
        
        builder.Property(c => c.ConnectedCalendar)
            .HasMaxLength(50)
            .IsRequired();
        
        builder.Property(c => c.AddEventsFromTeamId)
            .IsRequired();
        
        builder.HasOne(c => c.User)
            .WithMany(u => u.Calendars)
            .HasForeignKey(c => c.UserId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(c => c.ImportEventsFromTeam)
            .WithMany(t => t.ExportEventsToCalendars)
            .HasForeignKey(c => c.AddEventsFromTeamId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}