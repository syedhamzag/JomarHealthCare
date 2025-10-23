using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class BundleTrainingResultMap : IEntityTypeConfiguration<BundleTrainingResult>
    {
        public void Configure(EntityTypeBuilder<BundleTrainingResult> builder)
        {
            builder.ToTable("tbl_BundleTrainingResult");
            builder.HasKey(k => k.Id);

            #region Properties
            builder.Property(p => p.TrainingId)
             .HasColumnName("TrainingId");

            builder.Property(p => p.BundleId)
             .HasColumnName("BundleId");

            builder.Property(p => p.StaffId)
                .HasColumnName("StaffId");

            builder.Property(p => p.Status)
                .HasColumnName("Status")
                .HasMaxLength(50);
            #endregion
        }
    }
}
