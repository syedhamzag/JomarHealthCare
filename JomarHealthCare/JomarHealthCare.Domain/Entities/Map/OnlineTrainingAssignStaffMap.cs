using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class OnlineTrainingAssignStaffMap : IEntityTypeConfiguration<OnlineTrainingAssignStaff>
    {
        public void Configure(EntityTypeBuilder<OnlineTrainingAssignStaff> builder)
        {
            builder.ToTable("tbl_OnlineTrainingAssignStaff");
            builder.HasKey(k => k.Id);

            #region Properties
            builder.Property(p => p.OnlineTrainingId)
             .HasColumnName("OnlineTrainingId");

            builder.Property(p => p.Date)
             .HasColumnName("Date");
            
            builder.Property(p => p.StaffId)
             .HasColumnName("StaffId");

            builder.Property(p => p.ObtainMarks)
            .HasColumnName("ObtainMarks");

             builder.Property(p => p.Status)
             .HasColumnName("Status")
             .HasMaxLength(50);

            builder.Property(p => p.EligibleForTest)
            .HasColumnName("EligibleForTest");

            builder.Property(p => p.PaymentEvidence)
             .HasColumnName("PaymentEvidence")
             .HasMaxLength (256);

            builder.Property(p => p.Comments)
             .HasColumnName("Comments")
             .HasMaxLength(1024);
            #endregion
        }
    }
}
