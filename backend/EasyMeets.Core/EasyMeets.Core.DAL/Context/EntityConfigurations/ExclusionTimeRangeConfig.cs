using EasyMeets.Core.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EasyMeets.Core.DAL.Context;

public class ExclusionTimeRangeConfig : IEntityTypeConfiguration<ExclusionTimeRange>
{
    public void Configure(EntityTypeBuilder<ExclusionTimeRange> builder)
    {
        builder.Property(i => i.ScheduleId)
            .IsRequired();

        builder.HasOne(i => i.Schedule)
            .WithMany(s => s.ExclusionTimeRanges)
            .HasForeignKey(i => i.ScheduleId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}