using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class LogAuditOfficerToActMap : IEntityTypeConfiguration<LogAuditOfficerToAct>
    {
        public void Configure(EntityTypeBuilder<LogAuditOfficerToAct> builder)
        {
            builder.ToTable("tbl_LogAudit_OfficerToAct");
            builder.HasKey(k => k.LogAuditOfficerToActId);

            #region Properties
            builder.Property(p => p.LogAuditOfficerToActId)
               .HasColumnName("LogAuditOfficerToActId")
               .IsRequired();

            builder.Property(p => p.StaffPersonalInfoId)
              .HasColumnName("StaffPersonalInfoId")
              .IsRequired();

            builder.Property(p => p.LogAuditId)
             .HasColumnName("LogAuditId")
             .IsRequired();

            #endregion
        }
    }
}
