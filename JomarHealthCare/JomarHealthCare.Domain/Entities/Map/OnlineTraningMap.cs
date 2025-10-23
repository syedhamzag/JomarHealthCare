using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class OnlineTraningMap : IEntityTypeConfiguration<OnlineTraning>
    {
        public void Configure(EntityTypeBuilder<OnlineTraning> builder)
        {
            builder.ToTable("tbl_OnlineTraning");
            builder.HasKey(k => k.Id);

            #region Properties

            builder.Property(p => p.ClassId)
             .HasColumnName("ClassId");

            builder.Property(p => p.Duration)
             .HasColumnName("Duration");
            builder.Property(p => p.Name)
             .HasColumnName("Name")
             .HasMaxLength(450);

            builder.Property(p => p.Author)
             .HasColumnName("Author")
             .HasMaxLength(450);

            builder.Property(p => p.MaterialId)
             .HasColumnName("MaterialId");

            builder.Property(p => p.Video)
            .HasColumnName("Video")
            .HasMaxLength(450);

            builder.Property(p => p.Attachment)
            .HasColumnName("Attachment")
            .HasMaxLength(450);

            builder.Property(p => p.PassingMarks)
             .HasColumnName("PassingMarks");

            builder.Property(p => p.CreatedBy)
            .HasColumnName("CreatedBy")
            .HasMaxLength(450);

            builder.Property(p => p.IsPaid)
            .HasColumnName("IsPaid");

            builder.Property(p => p.Fee)
            .HasColumnName("Fee");

            builder.Property(p => p.RenewalDate)
            .HasColumnName("RenewalDate");

            builder.Property(p => p.IsHasLogQuestion)
            .HasColumnName("IsHasLogQuestion");

            builder.Property(p => p.PaymentURL)
            .HasColumnName("PaymentURL");

            builder.Property(p => p.TrainingType)
            .HasColumnName("TrainingType");

            builder.Property(p => p.StripeProductId)
           .HasColumnName("StripeProductId")
           .IsRequired(false);

            builder.Property(p => p.StripePaymentLinkId)
              .HasColumnName("StripePaymentLinkId")
              .IsRequired(false);

            builder.Property(p => p.AuthorSignature)
             .HasColumnName("AuthorSignature")
             .HasMaxLength(1024);
            #endregion
        }
    }
}
