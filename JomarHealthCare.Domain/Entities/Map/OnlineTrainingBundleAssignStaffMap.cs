using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class OnlineTrainingBundleAssignStaffMap : IEntityTypeConfiguration<OnlineTrainingBundleAssignStaff>
    {
        public void Configure(EntityTypeBuilder<OnlineTrainingBundleAssignStaff> builder)
        {
            builder.ToTable("tbl_OnlineTrainingBundleAssignStaff");
            builder.HasKey(k => k.Id);

            #region Properties
            builder.Property(p => p.OnlineTrainingBundleId)
             .HasColumnName("OnlineTrainingBundleId");

            builder.Property(p => p.Date)
             .HasColumnName("Date");

            builder.Property(p => p.StaffId)
             .HasColumnName("StaffId");

            builder.Property(p => p.NoOfCompleteCourse)
            .HasColumnName("NoOfCompleteCourse");

            builder.Property(p => p.Status)
            .HasColumnName("Status")
            .HasMaxLength(50);

            builder.Property(p => p.EligibleForTest)
            .HasColumnName("EligibleForTest");

            builder.Property(p => p.PaymentEvidence)
             .HasColumnName("PaymentEvidence")
             .HasMaxLength(256);

            builder.Property(p => p.Comments)
             .HasColumnName("Comments")
             .HasMaxLength(1024);
            #endregion
        }
    }
}
