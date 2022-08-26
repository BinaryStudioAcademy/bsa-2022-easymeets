using EasyMeets.Core.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EasyMeets.Core.DAL.Context.EntityConfigurations;

public class QuestionsConfig  : IEntityTypeConfiguration<Question>
{
    public void Configure(EntityTypeBuilder<Question> builder)
    {
        builder.Property(q => q.QuestionText)
            .IsRequired()
            .HasMaxLength(300);
        
        builder.Property(q => q.IsMandatory)
            .IsRequired();
        
        builder.Property(q => q.AvailabilitySlotId)
            .IsRequired();

        builder.HasOne(q => q.AvailabilitySlot)
            .WithMany(s => s.Questions)
            .HasForeignKey(q => q.AvailabilitySlotId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}