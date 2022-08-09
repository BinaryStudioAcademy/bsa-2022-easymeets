using EasyMeets.Core.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EasyMeets.Core.DAL.Context;

public class CalendarVisibleForTeamConfig : IEntityTypeConfiguration<CalendarVisibleForTeam>
{
    public void Configure(EntityTypeBuilder<CalendarVisibleForTeam> builder)
    {
        builder.HasKey(t => new { t.CalendarId, t.TeamId });
        builder.Property(c => c.CalendarId)
            .IsRequired();
        
        builder.Property(c => c.TeamId)
            .IsRequired();

        builder.HasOne(c => c.Calendar)
            .WithMany(cl => cl.VisibleForTeams)
            .HasForeignKey(c => c.CalendarId);
        
        builder.HasOne(c => c.Team)
            .WithMany(t => t.VisibleCalendars)
            .HasForeignKey(c => c.TeamId);
    }
}