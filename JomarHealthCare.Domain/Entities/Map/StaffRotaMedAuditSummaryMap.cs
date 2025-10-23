using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class StaffRotaMedAuditSummaryMap : IEntityTypeConfiguration<StaffRotaMedAuditSummary>
    {
        public void Configure(EntityTypeBuilder<StaffRotaMedAuditSummary> builder)
        {
            builder.ToTable("tbl_StaffRotaMedAuditSummary");
            builder.HasKey(k => k.Id);

            #region Properties

            builder.Property(p => p.Id)
                .HasColumnName("Id")
                .IsRequired();

            builder.Property(p => p.DateOfAudit)
                 .HasColumnName("DateOfAudit")
                 .HasMaxLength(50)
                 .IsRequired();


            builder.Property(p => p.NameOfAuditor)
               .HasColumnName("NameOfAuditor")
               .HasMaxLength(250);

            builder.Property(p => p.AuditPeriodStart)
                 .HasColumnName("AuditPeriodStart")
                 .HasMaxLength(20);

            builder.Property(p => p.AuditPeriodEnd)
                 .HasColumnName("AuditPeriodEnd")
                 .HasMaxLength(20);

            builder.Property(p => p.TotalClient)
                .HasColumnName("TotalClient");

            builder.Property(p => p.TotalStaff)
                .HasColumnName("TotalStaff");

            builder.Property(p => p.StaffWithConcern)
                .HasColumnName("StaffWithConcern");

            builder.Property(p => p.ClientWithConcern)
                .HasColumnName("ClientWithConcern");

            builder.Property(p => p.NoOfClose)
               .HasColumnName("NoOfClose");

            builder.Property(p => p.NoOfPending)
               .HasColumnName("NoOfPending");

            builder.Property(p => p.NoOfGPContacted)
               .HasColumnName("NoOfGPContacted");

            builder.Property(p => p.NoOfNoticIssueToStaff)
               .HasColumnName("NoOfNoticIssueToStaff");

            builder.Property(p => p.NoOfNoticIssueToClient)
               .HasColumnName("NoOfNoticIssueToClient");

            builder.Property(p => p.AuditClosingStatements)
               .HasColumnName("AuditClosingStatements")
               .HasMaxLength(500);
            #endregion

        }
    }
}
