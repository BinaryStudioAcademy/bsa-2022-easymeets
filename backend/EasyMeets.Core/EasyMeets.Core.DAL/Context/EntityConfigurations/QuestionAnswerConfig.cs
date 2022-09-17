using EasyMeets.Core.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EasyMeets.Core.DAL.Context.EntityConfigurations
{
    public class QuestionAnswerConfig : IEntityTypeConfiguration<QuestionAnswer>
    {
        public void Configure(EntityTypeBuilder<QuestionAnswer> builder)
        {
            builder.Property(q => q.Answer)
                .IsRequired()
                .HasMaxLength(120);

            builder.HasOne(q => q.Question)
                .WithMany()
                .HasForeignKey(q => q.QuestionId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(q => q.Meeting)
                .WithMany()
                .HasForeignKey(q => q.MeetingId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
