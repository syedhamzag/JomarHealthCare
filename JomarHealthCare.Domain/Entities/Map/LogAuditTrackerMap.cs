using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class LogAuditTrackerMap : IEntityTypeConfiguration<LogAuditTracker>
    {
        public void Configure(EntityTypeBuilder<LogAuditTracker> builder)
        {
            builder.ToTable("tbl_LogAuditTracke");
            builder.HasKey(k => k.Id);

            #region Properties

            builder.Property(p => p.Id)
                .HasColumnName("Id")
                .IsRequired();

            builder.Property(p => p.AuditRemarks)
             .HasColumnName("AuditRemarks")
              .HasMaxLength(500);

            builder.Property(p => p.ActionRecommendation)
             .HasColumnName("ActionRecommendation")
              .HasMaxLength(500);

            builder.Property(p => p.EvidenceOfActionTaken)
               .HasColumnName("EvidenceOfActionTaken")
               .HasMaxLength(500);

            builder.Property(p => p.Status)
               .HasColumnName("Status")
               .HasMaxLength(50)
               .IsRequired();

            builder.Property(p => p.NameOfAuditor)
               .HasColumnName("NameOfAuditor")
               .HasMaxLength(250)
               .IsRequired();

            builder.Property(p => p.DateOfAudit)
             .HasColumnName("Date")
             .IsRequired();

            builder.Property(p => p.EmailAuditToStaff)
             .HasColumnName("EmailAuditToStaff")
             .IsRequired();

            builder.Property(p => p.ConcernWithStaff)
             .HasColumnName("DoseGiven")
              .HasMaxLength(50);

            builder.Property(p => p.ConcernWithStaff)
             .HasColumnName("ConcernWithStaff")
              .IsRequired();

            builder.Property(p => p.ConcertWithClient)
             .HasColumnName("ConcertWithClient")
              .IsRequired();

            builder.Property(p => p.StaffRotaPeriodId)
             .HasColumnName("StaffRotaPeriodId")
              .IsRequired();

            #endregion
        }
    }
}
