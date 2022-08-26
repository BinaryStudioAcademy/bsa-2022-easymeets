using EasyMeets.Core.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders; 

namespace EasyMeets.Core.DAL.Context.EntityConfigurations
{
    public class MeetingMemberConfig : IEntityTypeConfiguration<MeetingMember>
    {
        public void Configure(EntityTypeBuilder<MeetingMember> builder)
        {
            builder.HasKey(mm => new { mm.TeamMemberId, mm.MeetingId });

            builder.Property(tm => tm.TeamMemberId)
                .IsRequired();

            builder.Property(m => m.MeetingId)
                .IsRequired();

            builder.HasOne(tm => tm.TeamMember)
           .WithMany(m => m.MeetingMembers)
           .HasForeignKey(us => us.TeamMemberId);

            builder.HasOne(tm => tm.Meeting)
           .WithMany(m => m.MeetingMembers)
           .HasForeignKey(us => us.MeetingId);
        }
    }
}
