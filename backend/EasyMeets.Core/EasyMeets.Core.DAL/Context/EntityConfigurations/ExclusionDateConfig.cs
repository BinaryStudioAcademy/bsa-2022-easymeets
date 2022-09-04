using EasyMeets.Core.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EasyMeets.Core.DAL.Context;

public class ExclusionDateConfig : IEntityTypeConfiguration<ExclusionDate>
{
    public void Configure(EntityTypeBuilder<ExclusionDate> builder)
    {
        builder.Property(i => i.ScheduleId)
            .IsRequired();

        builder.HasOne(i => i.Schedule)
            .WithMany(s => s.ExclusionDates)
            .HasForeignKey(i => i.ScheduleId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}