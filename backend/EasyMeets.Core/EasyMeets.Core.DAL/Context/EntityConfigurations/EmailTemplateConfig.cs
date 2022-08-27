using EasyMeets.Core.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EasyMeets.Core.DAL.Context
{
    public class EmailTemplateConfig : IEntityTypeConfiguration<EmailTemplate>
    {
        public void Configure(EntityTypeBuilder<EmailTemplate> builder)
        {
            builder.Property(q => q.AvailabilitySlotId)
                .IsRequired();

            builder.Property(q => q.Subject)
                .IsRequired()
                .HasMaxLength(30);

            builder.Property(q => q.Body)
                .IsRequired()
                .HasMaxLength(300);

            builder.HasOne(q => q.AvailabilitySlot)
                .WithMany(s => s.EmailTemplates)
                .HasForeignKey(q => q.AvailabilitySlotId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
