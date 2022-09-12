using EasyMeets.Core.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EasyMeets.Core.DAL.Context;

public class DayTimeRangeConfig : IEntityTypeConfiguration<DayTimeRange>
{
    public void Configure(EntityTypeBuilder<DayTimeRange> builder)
    {
        builder.Property(i => i.ExclusionDateId)
            .IsRequired();

        builder.HasOne(i => i.ExclusionDate)
            .WithMany(s => s.DayTimeRanges)
            .HasForeignKey(i => i.ExclusionDateId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}