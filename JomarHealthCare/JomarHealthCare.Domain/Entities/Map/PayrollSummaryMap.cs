using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class PayrollSummaryMap : IEntityTypeConfiguration<PayrollSummary>
    {
        public void Configure(EntityTypeBuilder<PayrollSummary> builder)
        {
            builder.ToTable("tbl_PayrollSummary");
            builder.HasKey(k => k.Id);

            #region Properties
            builder.Property(p => p.StartDate)
             .HasColumnName("StartDate")
             .HasMaxLength(20);

            builder.Property(p => p.EndDate)
             .HasColumnName("EndDate")
             .HasMaxLength (20);

            builder.Property(p => p.CompanyId)
                .HasColumnName("CompanyId")
                .HasMaxLength(450);

            builder.Property(p => p.CategoryofStaff)
                .HasColumnName("CategoryofStaff");

            builder.Property(p => p.TypeofStaffService)
            .HasColumnName("TypeofStaffService");

            builder.Property(p => p.StaffClass)
            .HasColumnName("StaffClass");

            builder.Property(p => p.Staff)
            .HasColumnName("Staff")
            .HasMaxLength(1024);
            #endregion
        }
    }
}
