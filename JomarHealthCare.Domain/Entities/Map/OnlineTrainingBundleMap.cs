using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class OnlineTrainingBundleMap : IEntityTypeConfiguration<OnlineTrainingBundle>
    {
        public void Configure(EntityTypeBuilder<OnlineTrainingBundle> builder)
        {
            builder.ToTable("tbl_OnlineTrainingBundle");
            builder.HasKey(k => k.Id);

            #region Properties
            builder.Property(p => p.Name)
             .HasColumnName("Name")
             .HasMaxLength(450);

            builder.Property(p => p.IsPaid)
            .HasColumnName("IsPaid");

            builder.Property(p => p.Fee)
            .HasColumnName("Fee");

            builder.Property(p => p.TrainingType)
            .HasColumnName("TrainingType");

            builder.Property(p => p.StripeProductId)
            .HasColumnName("StripeProductId")
            .IsRequired(false);

            builder.Property(p => p.StripePaymentLinkId)
            .HasColumnName("StripePaymentLinkId")
            .IsRequired(false);

            builder.Property(p => p.CreatedBy)
             .HasColumnName("CreatedBy")
             .HasMaxLength(450);

            #endregion
        }
    }
}
