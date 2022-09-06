using EasyMeets.Core.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EasyMeets.Core.DAL.Context.EntityConfigurations;

public class CalendarEventConfig : IEntityTypeConfiguration<CalendarEvent>
{
    public void Configure(EntityTypeBuilder<CalendarEvent> builder)
    {
        builder.Property(e => e.UserId).IsRequired();

        builder.HasOne(e => e.User)
            .WithMany(u => u.CalendarEvents)
            .HasForeignKey(e => e.UserId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}