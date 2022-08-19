using EasyMeets.Core.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EasyMeets.Core.DAL.Context;

public class SlotMemberConfig : IEntityTypeConfiguration<SlotMember>
{
    public void Configure(EntityTypeBuilder<SlotMember> builder)
    {
        builder.Property(m => m.MemberId)
            .IsRequired();
        
        builder.Property(m => m.EventId)
            .IsRequired();
        
        builder.Property(m => m.Priority)
            .IsRequired();

        builder.Property(m => m.ScheduleId)
            .IsRequired();

        builder.HasOne(m => m.Schedule)
            .WithMany(s => s.Members)
            .HasForeignKey(m => m.ScheduleId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(m => m.Event)
            .WithMany(e => e.SlotMembers)
            .HasForeignKey(m => m.EventId)
            .OnDelete(DeleteBehavior.Cascade);
        
        builder.HasOne(m => m.User)
            .WithMany(u => u.SlotMembers)
            .HasForeignKey(m => m.MemberId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}