using EasyMeets.Core.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EasyMeets.Core.DAL.Context;

public class TeamMemberConfig : IEntityTypeConfiguration<TeamMember>
{
    public void Configure(EntityTypeBuilder<TeamMember> builder)
    {
        builder.Property(t => t.UserId)
            .IsRequired();
        
        builder.Property(t => t.TeamId)
            .IsRequired();
        
        builder.Property(t => t.Role)
            .IsRequired();
        
        builder.Property(t => t.Status)
            .IsRequired();

        builder.HasOne(t => t.User)
            .WithMany(u => u.TeamMembers)
            .HasForeignKey(t => t.UserId)
            .OnDelete(DeleteBehavior.Cascade);
        
        builder.HasOne(t => t.Team)
            .WithMany(tm => tm.TeamMembers)
            .HasForeignKey(t => t.TeamId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}