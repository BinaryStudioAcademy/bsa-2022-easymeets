using EasyMeets.Core.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EasyMeets.Core.DAL.Context;

public class QuestionsConfig  : IEntityTypeConfiguration<Question>
{
    public void Configure(EntityTypeBuilder<Question> builder)
    {
        builder.Property(q => q.AvailabilitySlotId)
            .IsRequired();

        builder.Property(q => q.Text)
            .IsRequired()
            .HasMaxLength(300);

        builder.HasOne(q => q.AvailabilitySlot)
            .WithMany(s => s.Questions)
            .HasForeignKey(q => q.AvailabilitySlotId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}