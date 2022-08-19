using EasyMeets.Core.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EasyMeets.Core.DAL.Context;

public class ScheduleItemConfig : IEntityTypeConfiguration<ScheduleItem>
{
    public void Configure(EntityTypeBuilder<ScheduleItem> builder)
    {
        builder.Property(i => i.ScheduleId)
            .IsRequired();

        builder.HasOne(i => i.Schedule)
            .WithMany(s => s.ScheduleItems)
            .HasForeignKey(i => i.ScheduleId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}